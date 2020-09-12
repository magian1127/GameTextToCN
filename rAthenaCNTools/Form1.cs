using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace rAthenaCNTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (richTextBox1.Lines[6] != "")
                    {
                        string filePath = richTextBox1.Lines[6];
                        List<string> list = ReadInfoFromFileTXT(filePath);

                        WriteInfoTofile(richTextBox1.Lines[6].Replace(".txt", ".sql.txt"), list, Encoding.Default);
                        string[] lines = richTextBox1.Lines;
                        lines[0] = "OK";
                        richTextBox1.Lines = lines;
                    }
                    else
                    {
                        string filePath = richTextBox1.Lines[4];
                        List<string> list = ReadInfoFromFile(filePath);

                        WriteInfoTofile(richTextBox1.Lines[4] + ".txt", list, Encoding.Default);
                        string[] lines = richTextBox1.Lines;
                        lines[0] = "OK";
                        richTextBox1.Lines = lines;
                    }
                    break;
                case 1:
                    if (true)
                    {
                        string filePath = richTextBox1.Lines[6];
                        List<string> list = new List<string>();

                        if (File.Exists(filePath))
                        {
                            // 打开文件时 一定要注意编码
                            using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                            {
                                string sRL;
                                while ((sRL = sr.ReadLine()) != null)
                                {
                                    if (sRL.Contains(",") && !sRL.Contains("???"))
                                    {
                                        string[] sAtemp = sRL.Split(',');
                                        if (sAtemp.Length > 8)
                                        {
                                            string stemp = sAtemp[0].Replace("//", "") + "#" + sAtemp[8].Replace("\"", "") + "#";
                                            list.Add(stemp);
                                        }
                                    }
                                }
                            }
                        }

                        WriteInfoTofile(richTextBox1.Lines[6].Replace(".txt", ".sql.txt"), list, Encoding.Default);
                        string[] lines = richTextBox1.Lines;
                        lines[0] = "OK";
                        richTextBox1.Lines = lines;
                    }
                    break;
                case 2:
                default:
                    if (true)
                    {
                        string[] lines = richTextBox1.Lines;
                        lines[0] = "请选择字典源的类型";
                        richTextBox1.Lines = lines;

                    }
                    break;
            }
        }

        /// <summary>
        /// 这个函数把文件的每一行读入list
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private List<string> ReadInfoFromFileTXT(string filePath)
        {
            if (File.Exists(filePath))
            {
                List<string> list = new List<string>();
                // 打开文件时 一定要注意编码
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    string sRL;
                    while ((sRL = sr.ReadLine()) != null)
                    {
                        if (sRL.Contains(",") && !sRL.Contains("???"))
                        {
                            string[] sAtemp = sRL.Split(',');
                            if (sAtemp.Length > 2)
                            {
                                string stemp = sAtemp[0].Replace("//", "") + "#" + sAtemp[2] + "#";
                                list.Add(stemp);

                                string[] lines = richTextBox1.Lines;
                                lines[0] = stemp;
                                richTextBox1.Lines = lines;
                            }
                        }
                    }
                }
                return list;
            }
            return null;
        }

        /// <summary>
        /// 这个函数把文件的每一行读入list
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private List<string> ReadInfoFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                List<string> list = new List<string>();
                // 打开文件时 一定要注意编码
                using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
                {
                    string sRL;
                    while ((sRL = sr.ReadLine()) != null)
                    {
                        if (sRL.Contains("` VALUES (") && !sRL.Contains("???"))
                        {
                            string[] sAtemp = sRL.Split(',');
                            if (sAtemp.Length > 2)
                            {
                                string stemp = sAtemp[0].Split('(')[1] + "#" + sAtemp[2].Remove(sAtemp[2].Length - 1).Remove(0, 1) + "#";
                                list.Add(stemp);

                                string[] lines = richTextBox1.Lines;
                                lines[0] = stemp;
                                richTextBox1.Lines = lines;
                            }
                        }
                    }
                }
                return list;
            }
            return null;
        }

        /// <summary>
        /// 这个函数把list中的每一行写入文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="list"></param>
        private void WriteInfoTofile(string filePath, List<string> list, Encoding encoding)
        {
            //创建一个文件流，用以写入或者创建一个StreamWriter 
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, encoding);
            sw.Flush();
            // 使用StreamWriter来往文件中写入内容 
            sw.BaseStream.Seek(0, SeekOrigin.Begin);
            for (int i = 0; i < list.Count; i++) sw.WriteLine(list[i]);
            //关闭此文件t 
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void buttonEnabled()
        {
            buttonSQL.Enabled = !buttonSQL.Enabled;
            buttonTXT.Enabled = !buttonTXT.Enabled;
            buttonDIV.Enabled = !buttonDIV.Enabled;
            buttonHH.Enabled = !buttonHH.Enabled;
            buttonDictionary.Enabled = !buttonDictionary.Enabled;
            buttonC.Enabled = !buttonC.Enabled;
            buttonGenerate.Enabled = !buttonGenerate.Enabled;
        }

        BackgroundWorker backgroundWorker;
        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    //item_db和mob_db的sql和txt
                    if (richTextBox1.Lines[2] != "" && (richTextBox1.Lines[4] != "" || richTextBox1.Lines[6] != ""))
                    {
                        backgroundWorker = new BackgroundWorker();
                        buttonEnabled();
                        progressBar1.Visible = true;
                        backgroundWorker = new BackgroundWorker();
                        backgroundWorker.WorkerReportsProgress = true;
                        backgroundWorker.WorkerSupportsCancellation = true;
                        backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
                        backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
                        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
                        backgroundWorker.RunWorkerAsync();
                    }
                    else
                    {
                        string[] lines = richTextBox1.Lines;
                        lines[0] = "请选择汉化文件和字典";
                        richTextBox1.Lines = lines;
                    }
                    break;
                case 1:
                    //quest_db.txt
                    if (richTextBox1.Lines[2] != "" && richTextBox1.Lines[6] != "")
                    {
                        backgroundWorker = new BackgroundWorker();
                        buttonEnabled();
                        progressBar1.Visible = true;
                        backgroundWorker = new BackgroundWorker();
                        backgroundWorker.WorkerReportsProgress = true;
                        backgroundWorker.WorkerSupportsCancellation = true;
                        backgroundWorker.DoWork += new DoWorkEventHandler(quest_db_HH);
                        backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
                        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
                        backgroundWorker.RunWorkerAsync();
                    }
                    else
                    {
                        string[] lines = richTextBox1.Lines;
                        lines[0] = "请选择txt文件和字典";
                        richTextBox1.Lines = lines;
                    }
                    break;
                case 2:
                    //npc文件夹里脚本内怪物刷新名称
                    if (richTextBox1.Lines[2] != "" && richTextBox1.Lines[8] != "")
                    {
                        backgroundWorker = new BackgroundWorker();
                        buttonEnabled();
                        progressBar1.Visible = true;
                        backgroundWorker = new BackgroundWorker();
                        backgroundWorker.WorkerReportsProgress = true;
                        backgroundWorker.WorkerSupportsCancellation = true;
                        backgroundWorker.DoWork += new DoWorkEventHandler(DirectoryHH);
                        backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
                        backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
                        backgroundWorker.RunWorkerAsync();
                    }
                    else
                    {
                        string[] lines = richTextBox1.Lines;
                        lines[0] = "请选择目录和字典";
                        richTextBox1.Lines = lines;
                    }
                    break;
                default:
                    break;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Visible = false;
            buttonEnabled();
            string[] lines = richTextBox1.Lines;
            lines[0] = "";
            richTextBox1.Lines = lines;
        }

        private void quest_db_HH(object sender, DoWorkEventArgs e)
        {
            string filePath2 = richTextBox1.Lines[2];
            List<string> list2 = ReadInfoFromFile2(filePath2, Encoding.Default);
            string filePath = richTextBox1.Lines[6];
            List<string> list = ReadInfoFromFile2(filePath, Encoding.Default);
            //创建一个文件流，用以写入或者创建一个StreamWriter 
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Flush();
            // 使用StreamWriter来往文件中写入内容 
            sw.BaseStream.Seek(0, SeekOrigin.Begin);

            int iC = list2.Count;
            foreach (string item in list)
            {
                string sTemp = item;
                string[] sAtemp = sTemp.Split(',');
                if (sAtemp.Length > 8)
                {
                    foreach (string item2 in list2)
                    {
                        string[] s2 = item2.Split('#');
                        if (s2.Length > 1)
                        {
                            if (sAtemp[0].Replace("//", "") == s2[0])
                            {
                                sAtemp[8] = "\"" + s2[1] + "\"";

                                sTemp = string.Join(",", sAtemp, 0, 9);

                                backgroundWorker.ReportProgress(100 - (list2.Count * 100 / iC));
                                string[] lines = richTextBox1.Lines;
                                lines[0] = item2;
                                richTextBox1.Lines = lines;
                                list2.Remove(item2);
                                break;
                            }
                        }
                    }
                }
                sw.WriteLine(sTemp);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath2 = richTextBox1.Lines[2];
            List<string> list2 = ReadInfoFromFile2(filePath2, Encoding.Default);

            if (richTextBox1.Lines[4] != "")
            {
                string filePath = richTextBox1.Lines[4];
                List<string> list = ReadInfoFromFile2(filePath, Encoding.UTF8);

                //创建一个文件流，用以写入或者创建一个StreamWriter 
                FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Flush();
                // 使用StreamWriter来往文件中写入内容 
                sw.BaseStream.Seek(0, SeekOrigin.Begin);

                int iC = list2.Count;

                foreach (string item in list)
                {
                    string sTemp = item;
                    if (item.Contains("` VALUES ("))
                    {
                        string[] sAtemp = sTemp.Split(',');
                        if (sAtemp.Length > 2)
                        {
                            foreach (string item2 in list2)
                            {
                                string[] s2 = item2.Split('#');
                                if (s2.Length > 1)
                                {
                                    if (sAtemp[0].Split('(')[1] == s2[0])
                                    {
                                        sAtemp[2] = "'" + s2[1] + "'";

                                        sTemp = string.Join(",", sAtemp);

                                        backgroundWorker.ReportProgress(100 - (list2.Count * 100 / iC));
                                        string[] lines = richTextBox1.Lines;
                                        lines[0] = item2;
                                        richTextBox1.Lines = lines;
                                        list2.Remove(item2);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    sw.WriteLine(sTemp);

                }
                backgroundWorker.ReportProgress(90);
                sw.Flush();
                sw.Close();
                fs.Close();

                WriteInfoTofile(filePath2.Replace(".txt", "_lastS.txt"), list2, Encoding.Default);
                backgroundWorker.ReportProgress(99);
            }

            if (richTextBox1.Lines[6] != "")
            {
                string filePath = richTextBox1.Lines[6];
                List<string> list = ReadInfoFromFile2(filePath, Encoding.Default);

                //创建一个文件流，用以写入或者创建一个StreamWriter 
                FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Flush();
                // 使用StreamWriter来往文件中写入内容 
                sw.BaseStream.Seek(0, SeekOrigin.Begin);

                int iC = list2.Count;

                foreach (string item in list)
                {
                    string sTemp = item;
                    if (item.Contains(","))
                    {
                        string[] sAtemp = sTemp.Split(',');
                        if (sAtemp.Length > 2)
                        {
                            foreach (string item2 in list2)
                            {
                                string[] s2 = item2.Split('#');
                                if (s2.Length > 1)
                                {
                                    if (sAtemp[0].Replace("//", "") == s2[0])
                                    {
                                        sAtemp[2] = s2[1];

                                        sTemp = string.Join(",", sAtemp);

                                        backgroundWorker.ReportProgress(100 - (list2.Count * 100 / iC));
                                        string[] lines = richTextBox1.Lines;
                                        lines[0] = item2;
                                        richTextBox1.Lines = lines;
                                        list2.Remove(item2);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    sw.WriteLine(sTemp);

                }
                backgroundWorker.ReportProgress(90);
                sw.Flush();
                sw.Close();
                fs.Close();

                WriteInfoTofile(filePath2.Replace(".txt", "_lastT.txt"), list2, Encoding.Default);
                backgroundWorker.ReportProgress(99);
            }
        }

        private List<string> ReadInfoFromFile2(string filePath, Encoding encoding)
        {
            if (File.Exists(filePath))
            {
                List<string> list = new List<string>();
                using (StreamReader sr = new StreamReader(filePath, encoding))
                {
                    string sRL;
                    while ((sRL = sr.ReadLine()) != null)
                    {
                        list.Add(sRL);
                    }
                }
                return list;
            }
            return null;
        }

        private void buttonDictionary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "字典文件|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = richTextBox1.Lines;
                lines[2] = openFileDialog.FileName;
                richTextBox1.Lines = lines;
            }
        }

        private void buttonSQL_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQL|*.sql";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = richTextBox1.Lines;
                lines[4] = openFileDialog.FileName;
                richTextBox1.Lines = lines;
            }
        }

        private void buttonTXT_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = richTextBox1.Lines;
                lines[6] = openFileDialog.FileName;
                richTextBox1.Lines = lines;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            string s1 = "9";
            string s2 = "4";
            string s3 = "z";
            string s4 = "l";
            string s5 = ".";
            string s6 = "c";
            string s7 = "o";
            string s8 = "m";
            labelZZ.Text = s1 + s2 + s3 + s4 + s5 + s6 + s7 + s8;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1.Lines;
            lines[0] = "";
            lines[2] = "";
            lines[4] = "";
            lines[6] = "";
            lines[8] = "";
            richTextBox1.Lines = lines;

        }
        int m_numFiles = 0;        //文件总数
        ArrayList m_pathList = new ArrayList();//包含所有文件路径的数组
        string[] files;            //所有文件名
        private void buttonDIV_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = richTextBox1.Lines;
                lines[8] = folderBrowserDialog.SelectedPath;
                richTextBox1.Lines = lines;
            }
        }
        private void buttonMobs_Click(object sender, EventArgs e)
        {

        }

        private void DirectoryHH(object sender, DoWorkEventArgs e)
        {
            ParseDirectory(richTextBox1.Lines[8], "*.txt");
            files = CreatePathList();        //生成文件名数组
            string filePath2 = richTextBox1.Lines[2];
            List<string> list2 = ReadInfoFromFile2(filePath2, Encoding.Default);
            for (int i = 0; i < files.Length; i++)
            {
                List<string> list = ReadInfoFromFile2(files[i], Encoding.Default);

                //创建一个文件流，用以写入或者创建一个StreamWriter 
                FileStream fs = new FileStream(files[i], FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Flush();
                // 使用StreamWriter来往文件中写入内容 
                sw.BaseStream.Seek(0, SeekOrigin.Begin);

                foreach (string item in list)
                {
                    string sTemp = item;
                    if (item.Contains("\tmonster\t") || item.Contains("\tboss_monster\t"))
                    {
                        string[] sAtemp = sTemp.Split('\t');
                        if (sAtemp.Length > 3)
                        {
                            foreach (string item2 in list2)
                            {
                                string[] s2 = item2.Split('#');
                                if (s2.Length > 1)
                                {
                                    if (sAtemp[3].Split(',')[0] == s2[0])
                                    {
                                        sAtemp[2] = s2[1];

                                        sTemp = string.Join("\t", sAtemp);

                                        string[] lines = richTextBox1.Lines;
                                        lines[0] = item2;
                                        richTextBox1.Lines = lines;
                                    }
                                }
                            }
                        }
                    }
                    sw.WriteLine(sTemp);
                }
                sw.Flush();
                sw.Close();
                fs.Close();

                backgroundWorker.ReportProgress(i * 100 / files.Length);
            }
        }

        void ParseDirectory(string path, string filter)
        {
            string[] dirs = Directory.GetDirectories(path);//得到子目录
            IEnumerator iter = dirs.GetEnumerator();
            while (iter.MoveNext())
            {
                string str = (string)(iter.Current);
                ParseDirectory(str, filter);
            }
            string[] files = Directory.GetFiles(path, filter);
            if (files.Length > 0)
            {
                m_numFiles += files.Length;
                m_pathList.Add(files);
            }
        }
        string[] CreatePathList()
        {
            if (m_numFiles <= 0)
            {
                return null;
            }

            string[] str = new string[m_numFiles];
            int index = 0;

            try
            {
                IEnumerator pathIter = m_pathList.GetEnumerator();
                while (pathIter.MoveNext())
                {
                    string[] ar = (string[])(pathIter.Current);
                    IEnumerator fileIter = ar.GetEnumerator();
                    while (fileIter.MoveNext())
                    {
                        str[index] = (string)(fileIter.Current);
                        ++index;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            return str;
        }
    }
}
