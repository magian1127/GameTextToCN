using System;
using System.Collections;
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
using System.Xml;

namespace POExml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<string> files目标 = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {

            Form1.CheckForIllegalCrossThreadCalls = false;
            ThreadStart ts = new ThreadStart(StoT);
            Thread th = new Thread(ts);
            th.Start();
        }

        private void buttonEnabled()
        {
            buttonS.Enabled = !buttonS.Enabled;
            buttonT.Enabled = !buttonT.Enabled;
            buttonDiv.Enabled = !buttonDiv.Enabled;
            button1.Enabled = !button1.Enabled;
            checkBoxE.Enabled = !checkBoxE.Enabled;
            textBox源.Enabled = !textBox源.Enabled;
            textBox目标.Enabled = !textBox目标.Enabled;
        }
        private void StoT()
        {
            buttonEnabled();
            textBox1.Clear();
            for (int i1 = 0; i1 < files目标.Count; i1++)
            {
                string s源地址 = files目标[i1].Replace(textBox目标.Text, textBox源.Text);

                textBox1.AppendText("源　:" + s源地址 + "\n");
                textBox1.AppendText("目标:" + files目标[i1] + "\n");


                if (!File.Exists(s源地址))
                {
                    textBox1.AppendText("错误:源不存在" + "\n");
                    continue;
                }

                XmlDocument xmls = new XmlDocument();
                xmls.Load(s源地址);
                XmlNodeList childlists = xmls["StringTableFile"]["Entries"].ChildNodes;

                XmlDocument xmlt = new XmlDocument();
                xmlt.Load(files目标[i1]);
                XmlNodeList childlistt = xmlt["StringTableFile"]["Entries"].ChildNodes;

                progressBar1.Visible = true;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = childlistt.Count;

                int i = 0;
                foreach (XmlNode entry in childlistt)
                {
                    i++;
                    if (entry["DefaultText"] != null)
                    {
                        //跳过包含中文的
                        if (checkBoxE.Checked && Regex.IsMatch(entry["DefaultText"].InnerText, @"[\u4e00-\u9fa5]"))
                        {
                            continue;
                        }

                        XmlNode temp = xmls.SelectSingleNode("//Entry[ID='" + entry["ID"].InnerText + "']");

                        if (temp != null)
                        {
                            entry["DefaultText"].InnerText = temp["DefaultText"].InnerText;
                        }
                    }
                    progressBar1.Value = i;
                }

                xmlt.Save(files目标[i1]);
                textBox1.AppendText("保存成功" + "\n");
                textBox1.AppendText(" " + "\n");
            }
            buttonEnabled();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox源.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                files目标 = new List<string>();
                ParseDirectory(folderBrowserDialog.SelectedPath, files目标);
                textBox目标.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            files目标 = new List<string>();

            ParseDirectory(textBox目标.Text, files目标);
        }

        void ParseDirectory(string path, List<string> list)
        {

            List<string> tttt = new List<string>();
            string[] dirs = Directory.GetDirectories(path);//得到子目录
            IEnumerator iter = dirs.GetEnumerator();
            while (iter.MoveNext())
            {
                string str = (string)(iter.Current);
                ParseDirectory(str, list);
            }
            string[] files = Directory.GetFiles(path, "*.stringtable");
            if (files.Length > 0)
            {
                list.AddRange(files);
            }
        }

    }
}
