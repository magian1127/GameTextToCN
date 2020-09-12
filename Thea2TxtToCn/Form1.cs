using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Newtonsoft.Json;

namespace Thea2TxtToCn
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

        private string ReadInfoFromFileString(string filePath, Encoding encoding)
        {
            if (File.Exists(filePath))
            {
                List<string> list = new List<string>();
                using (StreamReader sr = new StreamReader(filePath, encoding))
                {
                    return sr.ReadToEnd();
                }
            }
            return null;
        }


        /// <summary>
        /// 截取字符串中开始和结束字符串中间的字符串
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="startStr">开始字符串(正则一些符号需要转义)</param>
        /// <param name="endStr">结束字符串(正则一些符号需要转义)</param>
        /// <returns>中间字符串</returns>
        public string SubstringSingle(string source, string startStr, string endStr)
        {
            Regex rg = new Regex("(?<=(" + startStr + "))[.\\s\\S]*?(?=(" + endStr + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(source).Value;
        }

        /// <summary>
        /// （批量）截取字符串中开始和结束字符串中间的字符串
        /// </summary>
        /// <param name="source">源字符串</param>
        /// <param name="startStr">开始字符串(正则一些符号需要转义)</param>
        /// <param name="endStr">结束字符串(正则一些符号需要转义)</param>
        /// <returns>中间字符串</returns>
        public List<string> SubstringMultiple(string source, string startStr, string endStr)
        {
            Regex rg = new Regex("(?<=(" + startStr + "))[.\\s\\S]*?(?=(" + endStr + "))", RegexOptions.Multiline | RegexOptions.Singleline);

            MatchCollection matches = rg.Matches(source);

            List<string> resList = new List<string>();

            foreach (Match item in matches)
                resList.Add(item.Value);

            return resList;
        }

        public List<Event> TxtToList(string filePath)
        {
            List<Event> events = new List<Event>();

            string filetxt = ReadInfoFromFileString(filePath, Encoding.UTF8);

            List<string> eventList = SubstringMultiple(filetxt.Replace("-- [EVENT] --", "-- [EVENT] --[NAME]"), "-- \\[EVENT\\] --", "\\[/EVENT\\]");

            foreach (var eventtxt in eventList)
            {
                Event newEvent = new Event();
                newEvent.Name = SubstringSingle(eventtxt, "\\[NAME\\]", "\r\n\\+\\[NODE\\]");//获取事件标题
                List<string> nodeList = SubstringMultiple(eventtxt.Replace("+[NODE]", "+[NODE][NAME]"), "\\+\\[NODE\\]", "\\[/NODE\\]");
                newEvent.NODE = new List<Node>();
                foreach (var nodetxt in nodeList)
                {
                    Node newNode = new Node();
                    newNode.Name = SubstringSingle(nodetxt, "\\[NAME\\]", "\r\n\\[STORY\\]");//获取节点索引
                    newNode.STORY = SubstringSingle(nodetxt, "\\[STORY\\]\r\n", "\r\n\\[/STORY\\]");//获取节点内容
                    newNode.OUT = SubstringMultiple(nodetxt.Replace("[OUT]", "[/OUT][OUT]") + "[/OUT]", "\\[OUT\\]", "\r\n\\[/OUT\\]");
                    newEvent.NODE.Add(newNode);
                }
                events.Add(newEvent);
            }

            return events;
        }

        List<Event> events来源 = new List<Event>();
        List<Event> events目标 = new List<Event>();

        int eventIndex = -1;
        int nodeIndex = -1;
        Event sEvent;
        Node sNode;
        Event tEvent;
        Node tNode;

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            events来源 = TxtToList(textBox来源.Text);
            events目标 = TxtToList(textBox目标.Text);

            buttonLoad.Enabled = false;

            textBoxNote.Text = "读取完成";

            eventIndex = 0;
            nodeIndex = -1;

            buttonNext_Click(sender, e);

            buttonNoKey.Enabled = true;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            buttonUpdate.Enabled = true;
            buttonSaveFile.Enabled = true;
            buttonFY.Enabled = true;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = events来源.Count() - 1;

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (nodeIndex < events来源[eventIndex].NODE.Count() - 1)
            {//判定节点索引
                nodeIndex++;
            }
            else if (eventIndex < events来源.Count() - 1)
            {//判定事件索引
                eventIndex++;
                nodeIndex = 0;
            }
            else
            {
                textBoxNote.Text = "最后一条了";
                return;
            }

            progressBar1.Value = eventIndex;
            Compare();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (nodeIndex > 0)
            {//判定节点索引
                nodeIndex--;
            }
            else if (eventIndex > 0)
            {
                eventIndex--;
                nodeIndex = events来源[eventIndex].NODE.Count() - 1;
            }
            else
            {
                textBoxNote.Text = "第一条了";
                return;
            }

            progressBar1.Value = eventIndex;
            Compare();

        }

        /// <summary>
        /// 
        /// </summary>
        private void Compare()
        {
            if (checkBoxAutoUp.Checked)
            {
                buttonUpdate_Click(null, null);
            }

            sEvent = null;
            sNode = null;
            tEvent = null;
            tNode = null;

            sEvent = events来源[eventIndex];
            sNode = sEvent.NODE[nodeIndex];

            textBox来源标题.Text = sEvent.Name;
            textBox来源STORY.Text = sNode.STORY;
            textBox来源OUTs.Text = string.Join("\r\n", sNode.OUT);

            //判定目标是否有该节点
            tEvent = events目标.Where(item => item.Name.Equals(sEvent.Name)).FirstOrDefault();
            if (tEvent == null)
            {

                if (eventIndex < events目标.Count)
                {
                    events目标.Insert(eventIndex, JsonConvert.DeserializeObject<Event>(JsonConvert.SerializeObject(sEvent)));
                    tEvent = events目标[eventIndex];
                }
                else
                {
                    events目标.Add(JsonConvert.DeserializeObject<Event>(JsonConvert.SerializeObject(sEvent)));
                    tEvent = events目标.Last();
                }

            }

            tNode = tEvent.NODE.Where(item => item.Name.Equals(sNode.Name)).FirstOrDefault();
            if (tNode == null)
            {
                if (nodeIndex < tEvent.NODE.Count())
                {
                    tEvent.NODE.Insert(nodeIndex, JsonConvert.DeserializeObject<Node>(JsonConvert.SerializeObject(sNode)));
                    tNode = tEvent.NODE[nodeIndex];
                }
                else
                {
                    tEvent.NODE.Add(JsonConvert.DeserializeObject<Node>(JsonConvert.SerializeObject(sNode)));
                    tNode = tEvent.NODE.Last();
                }
            }

            textBox目标标题.Text = tEvent.Name;
            textBox目标STORY.Text = tNode.STORY;
            textBox目标OUTs.Text = string.Join("\r\n", tNode.OUT);

            textBoxNote.Text = $"EVENT:{sEvent.Name} NODE:{sNode.Name} 索引:{eventIndex}-{nodeIndex}";
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
            buttonUpdate_Click(sender, e);

            buttonEnabled();
            nodeIndex++;
            textBoxNote.Text = "开始查找...";
            Form1.CheckForIllegalCrossThreadCalls = false;
            ThreadStart ts = new ThreadStart(FindTxt);
            Thread th = new Thread(ts);
            th.Start();
        }

        private void FindTxt()
        {
            bool noTxt = false;
            int nodeIndexTemp = nodeIndex;
            for (int i = eventIndex; i < events来源.Count(); i++)
            {
                var event来源Item = events来源[i];

                progressBar1.Value = i;

                var event目标Item = events目标.Where(item => item.Name.Equals(event来源Item.Name)).FirstOrDefault();
                if (event目标Item == null)
                {
                    eventIndex = i;
                    nodeIndex = 0;
                    noTxt = true;
                }
                else
                {
                    for (int nodeI = nodeIndexTemp; nodeI < event来源Item.NODE.Count(); nodeI++)
                    {
                        var node目标Item = event目标Item.NODE.Where(item => item.Name.Equals(event来源Item.NODE[nodeI].Name)).FirstOrDefault();
                        if (node目标Item == null || event来源Item.NODE[nodeI].OUT.Count() != node目标Item.OUT.Count() || event来源Item.NODE[nodeI].STORY.Equals(node目标Item.STORY))
                        {//目标节点不存在,或者节点输出的选择数不同,或者内容文本未汉化
                            eventIndex = i;
                            nodeIndex = nodeI;
                            noTxt = true;
                            break;
                        }
                        else
                        {
                            foreach (var item in event来源Item.NODE[nodeI].OUT)
                            {//判定目标节点输出的选择中是否有相同的未汉化文本
                                var outTemp = node目标Item.OUT.Where(o => o.Equals(item)).FirstOrDefault();
                                if (!string.IsNullOrWhiteSpace(outTemp))
                                {
                                    eventIndex = i;
                                    nodeIndex = nodeI;
                                    noTxt = true;
                                    break;
                                }
                            }
                        }

                        if (noTxt)
                        {
                            break;
                        }

                    }
                    nodeIndexTemp = 0;
                }

                if (noTxt)
                {
                    break;
                }

            }

            if (noTxt)
            {
                Compare();
            }
            else
            {
                textBoxNote.Text = "找不到";
            }
            buttonEnabled();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (tNode != null)
            {
                tNode.STORY = textBox目标STORY.Text;
                tNode.OUT = textBox目标OUTs.Lines.ToList();
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            Conf.SourceFile = textBox来源.Text;
            Conf.TargetFile = textBox目标.Text;
            Conf.BaiDuFYAppId = textBoxBaiduAppId.Text;
            Conf.BaiDuFYKey = textBoxBaiduKey.Text;
            AsNum.JsonConfig.JsonConfig.Save(Conf);

            buttonUpdate_Click(sender, e);

            buttonSaveFile.Enabled = false;

            textBoxNote.Text = "保存中";

            StringBuilder sb = new StringBuilder();
            for (int indexE = 0; indexE < events目标.Count(); indexE++)
            {
                var newEvent = events目标[indexE];
                sb.AppendLine("-- [EVENT] --" + newEvent.Name);
                for (int indexN = 0; indexN < newEvent.NODE.Count(); indexN++)
                {
                    var newNode = newEvent.NODE[indexN];
                    sb.AppendLine("+[NODE]" + newNode.Name);
                    sb.AppendLine("[STORY]");
                    sb.AppendLine(newNode.STORY);
                    sb.AppendLine("[/STORY]");
                    for (int indexOut = 0; indexOut < newNode.OUT.Count(); indexOut++)
                    {
                        sb.AppendLine("[OUT]" + newNode.OUT[indexOut]);
                    }
                    sb.AppendLine("[/NODE]");
                    sb.AppendLine();
                }
                sb.AppendLine("[/EVENT]");
                sb.AppendLine();
            }
            System.IO.File.WriteAllText(textBox目标.Text, sb.ToString());

            textBoxNote.Text = "保存完毕";

            buttonSaveFile.Enabled = true;
            buttonLoad.Enabled = true;
        }

        private void buttonFY_Click(object sender, EventArgs e)
        {
            ClassLibrary.BaiduFanyi.TranslationResult result = ClassLibrary.BaiduFanyi.Fanyi.GetTranslationFromBaiduFanyi(textBox来源STORY.Text, ClassLibrary.BaiduFanyi.Language.en, ClassLibrary.BaiduFanyi.Language.zh, textBoxBaiduAppId.Text, textBoxBaiduKey.Text);
            //判断是否出错
            if (result.Error_code == null)
            {
                string[] newSTORY = new string[result.Trans_result.Count()];
                for (int i = 0; i < newSTORY.Count(); i++)
                {
                    newSTORY[i] = result.Trans_result[i].Dst;
                }
                textBox目标STORY.Lines = newSTORY;

                //防止请求过快
                Thread.Sleep(1000);

                result = ClassLibrary.BaiduFanyi.Fanyi.GetTranslationFromBaiduFanyi(textBox来源OUTs.Text, ClassLibrary.BaiduFanyi.Language.en, ClassLibrary.BaiduFanyi.Language.zh, textBoxBaiduAppId.Text, textBoxBaiduKey.Text);
                if (result.Error_code == null)
                {
                    string[] newOUT = new string[result.Trans_result.Count()];
                    for (int i = 0; i < newOUT.Count(); i++)
                    {
                        newOUT[i] = result.Trans_result[i].Dst;
                    }
                    textBox目标OUTs.Lines = newOUT;
                    textBoxNote.Text = $"EVENT:{sEvent.Name} NODE:{sNode.Name} 索引:{eventIndex}-{nodeIndex} 机翻成功";

                    Thread.Sleep(500);
                }
                else
                {
                    textBoxNote.Text = "翻译出错，错误码：" + result.Error_code + "，错误信息：" + result.Error_msg;
                }

            }
            else
            {
                textBoxNote.Text = "翻译出错，错误码：" + result.Error_code + "，错误信息：" + result.Error_msg;
            }
        }
    }
}
