using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using ClassLibrary;

namespace XmlToCN
{
    public partial class Form1 : Form
    {
        Config Conf;
        public Form1()
        {
            InitializeComponent();

            AsNum.JsonConfig.JsonConfig.Regist<Config>();
            Conf = AsNum.JsonConfig.JsonConfig.Get<Config>();
            textBox来源.Text = Conf.SourceFile;
            textBox目标.Text = Conf.TargetFile;
            textBoxBaiduAppId.Text = Conf.BaiDuFYAppId;
            textBoxBaiduKey.Text = Conf.BaiDuFYKey;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            openFileDialogS.Reset();
            if (System.IO.Path.IsPathRooted(textBox来源.Text))
            {
                openFileDialogS.InitialDirectory = System.IO.Path.GetDirectoryName(textBox来源.Text);
            }
            if (openFileDialogS.ShowDialog() == DialogResult.OK)
            {
                textBox来源.Text = openFileDialogS.FileName;
                buttonLoad.Enabled = true;

                buttonNoKey.Enabled = false;
                buttonPrev.Enabled = false;
                buttonNext.Enabled = false;
                buttonUpdate.Enabled = false;
                buttonSaveFile.Enabled = false;
                buttonFY.Enabled = false;
            }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            openFileDialogT.Reset();
            if (System.IO.Path.IsPathRooted(textBox目标.Text))
            {
                openFileDialogT.InitialDirectory = System.IO.Path.GetDirectoryName(textBox目标.Text);
            }
            if (openFileDialogT.ShowDialog() == DialogResult.OK)
            {
                textBox目标.Text = openFileDialogT.FileName;
                buttonLoad.Enabled = true;

                buttonNoKey.Enabled = false;
                buttonPrev.Enabled = false;
                buttonNext.Enabled = false;
                buttonUpdate.Enabled = false;
                buttonSaveFile.Enabled = false;
                buttonFY.Enabled = false;
            }
        }

        XDocument xml来源;
        IEnumerable<XElement> xml来源List;
        XDocument xml目标;
        IEnumerable<XElement> xml目标List;
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            buttonUpdate_Click(sender, e);

            // 1 读取目标和来源XML
            if (!File.Exists(textBox来源.Text))
            {
                textBoxNote.Text = "来源无法读取或者不存在";
                return;
            }
            xml来源 = XDocument.Load(textBox来源.Text, LoadOptions.PreserveWhitespace);
            xml来源List = xml来源.Descendants("Entry");//此处直接ToList 会导致后面引用问题.

            if (!File.Exists(textBox目标.Text))
            {
                textBoxNote.Text = "目标无法读取或者不存在";
                return;
            }
            xml目标 = XDocument.Load(textBox目标.Text, LoadOptions.PreserveWhitespace);
            xml目标List = xml目标.Descendants("Entry");

            buttonLoad.Enabled = false;

            textBoxNote.Text = "读取完成";

            entryIndex = -1;

            buttonNext_Click(sender, e);

            buttonNoKey.Enabled = true;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonSaveFile.Enabled = true;
            buttonFY.Enabled = true;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = xml来源List.Count() - 1;
        }

        int entryIndex = -1;
        XElement sEntry;
        XElement tEntry;

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (entryIndex < xml来源List.Count())
            {
                entryIndex++;
            }

            if (xml来源List.Count() <= entryIndex || entryIndex < 0)
            {
                textBoxNote.Text = "最后一条了";
                return;
            }
            progressBar1.Value = entryIndex;
            KeyCompare();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (entryIndex > 0)
            {
                entryIndex--;
            }

            if (xml来源List.Count() <= entryIndex || entryIndex < 0)
            {
                textBoxNote.Text = "第一条了";
                return;
            }
            progressBar1.Value = entryIndex;
            KeyCompare();
        }

        /// <summary>
        /// 根据来源对比目标条目,如果不存在的KEY则复制一份过去
        /// </summary>
        private void KeyCompare()
        {
            if (checkBoxAutoUp.Checked)
            {
                buttonUpdate_Click(null, null);
            }

            sEntry = null;
            tEntry = null;

            sEntry = xml来源List.ToList()[entryIndex];

            textBox来源标题.Text = sEntry?.Attribute("Key")?.Value?.ToString();
            textBox来源内容.Text = sEntry?.Attribute("Val")?.Value?.ToString();


            var xmlTList = xml目标List.Where(entry => entry.Attribute("Key").Value.Equals(textBox来源标题.Text));
            if (xmlTList.Count() == 0)
            {//复制来源条目到目标合集
                var xml条目父级 = xml目标.Descendants().First().Descendants().First();
                xml条目父级.Add(@"
  ");//添加换行
                xml条目父级.Add(sEntry);
                tEntry = xml条目父级.Descendants().Last();

                textBoxNote.Text = $"{sEntry.Name} 索引:{entryIndex} 目标中此条不存在,请汉化";
            }
            else
            {
                tEntry = xmlTList.First();
                textBoxNote.Text = $"{sEntry.Name} 索引:{entryIndex}";
            }

            textBox目标标题.Text = tEntry?.Attribute("Key")?.Value?.ToString();
            textBox目标内容.Text = tEntry?.Attribute("Val")?.Value?.ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Conf.SourceFile = textBox来源.Text;
            Conf.TargetFile = textBox目标.Text;
            Conf.BaiDuFYAppId = textBoxBaiduAppId.Text;
            Conf.BaiDuFYKey = textBoxBaiduKey.Text;
            AsNum.JsonConfig.JsonConfig.Save(Conf);

            buttonUpdate_Click(sender, e);

            buttonSaveFile.Enabled = false;

            textBoxNote.Text = "保存中";


            XmlWriterSettings xws = new XmlWriterSettings();
            xws.OmitXmlDeclaration = true;
            using (XmlWriter xw = XmlWriter.Create(textBox目标.Text, xws))
            {
                if (checkBoxSaveS.Checked)
                {
                    XDocument xmlNew = new XDocument(xml来源);
                    var xmlNewList = xmlNew.Descendants("Entry");

                    foreach (var item in xmlNewList)
                    {//从来源中获取文本替换目标条目文本,最后覆盖到目标文本
                        string key = item.Attribute("Key").Value;
                        var t目标条目 = xml目标List.Where(entry => entry.Attribute("Key").Value.Equals(key)).FirstOrDefault();

                        if (t目标条目 != null)
                        {
                            item.Attribute("Val").Value = t目标条目.Attribute("Val").Value;
                        }
                    }
                    xmlNew.Save(xw);
                }
                else
                {
                    xml目标.Save(xw);
                }

            }

            textBoxNote.Text = "保存完毕";

            buttonSaveFile.Enabled = true;
            buttonLoad.Enabled = true;
        }

        private void buttonEnabled()
        {
            buttonS.Enabled = !buttonS.Enabled;
            buttonT.Enabled = !buttonT.Enabled;
            buttonNoKey.Enabled = !buttonNoKey.Enabled;
            buttonPrev.Enabled = !buttonPrev.Enabled;
            buttonNext.Enabled = !buttonNext.Enabled;
            buttonUpdate.Enabled = !buttonUpdate.Enabled;
            buttonSaveFile.Enabled = !buttonSaveFile.Enabled;
            buttonFY.Enabled = !buttonFY.Enabled;
        }

        private void buttonNoKey_Click(object sender, EventArgs e)
        {
            buttonEnabled();
            entryIndex++;
            textBoxNote.Text = "开始查找...";
            Form1.CheckForIllegalCrossThreadCalls = false;
            ThreadStart ts = new ThreadStart(FindKey);
            Thread th = new Thread(ts);
            th.Start();
        }

        private void FindKey()
        {
            bool noKey = false;
            for (int i = entryIndex; i < xml来源List.Count(); i++)
            {
                var item = xml来源List.ToList()[i];
                string key = item?.Attribute("Key")?.Value?.ToString();

                progressBar1.Value = i;

                textBoxNote.Text = $"匹配 {key} 中";

                if (!string.IsNullOrWhiteSpace(key))
                {//根据key查找目标集合中是否有该key
                    var tempTList = xml目标List.Where(entry => entry.Attribute("Key").Value.Equals(key));

                    if (tempTList.Count() == 0)
                    {
                        noKey = true;
                        entryIndex = i;
                        break;
                    }
                    else
                    {
                        var elementT = tempTList.First();

                        //对比来源和目标内容是否相同,相同说明也没汉化
                        if (item.Attribute("Val").Value.Equals(elementT.Attribute("Val").Value))
                        {
                            noKey = true;
                            entryIndex = i;
                            break;
                        }
                    }
                }
            }

            if (noKey)
            {
                KeyCompare();
            }
            else
            {
                textBoxNote.Text = "找不到";
            }
            buttonEnabled();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (tEntry != null && !string.IsNullOrWhiteSpace(textBox目标内容.Text) && !tEntry.Attribute("Val").Value.Equals(textBox目标内容.Text))
            {
                tEntry.Attribute("Val").Value = textBox目标内容.Text;
            }
        }

        private void buttonFY_Click(object sender, EventArgs e)
        {
            ClassLibrary.BaiduFanyi.TranslationResult result = ClassLibrary.BaiduFanyi.Fanyi.GetTranslationFromBaiduFanyi(textBox来源内容.Text, ClassLibrary.BaiduFanyi.Language.en, ClassLibrary.BaiduFanyi.Language.zh, textBoxBaiduAppId.Text, textBoxBaiduKey.Text);
            //判断是否出错
            if (result.Error_code == null)
            {
                string[] newText = new string[result.Trans_result.Count()];
                for (int i = 0; i < newText.Count(); i++)
                {
                    newText[i] = result.Trans_result[i].Dst;
                }
                textBox目标内容.Lines = newText;
                textBoxNote.Text = $"{sEntry.Name} 索引:{entryIndex} 机翻成功";
            }
            else
            {
                //检查appid和密钥是否正确
                textBoxNote.Text = "翻译出错，错误码：" + result.Error_code + "，错误信息：" + result.Error_msg;
            }
        }

    }
}
