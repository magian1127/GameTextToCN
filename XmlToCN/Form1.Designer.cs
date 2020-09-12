namespace XmlToCN
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBox来源内容 = new System.Windows.Forms.TextBox();
            this.textBox目标 = new System.Windows.Forms.TextBox();
            this.textBox来源 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.textBox目标内容 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBox来源标题 = new System.Windows.Forms.TextBox();
            this.buttonNoKey = new System.Windows.Forms.Button();
            this.textBox目标标题 = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.openFileDialogS = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogT = new System.Windows.Forms.OpenFileDialog();
            this.checkBoxAutoUp = new System.Windows.Forms.CheckBox();
            this.buttonFY = new System.Windows.Forms.Button();
            this.textBoxBaiduAppId = new System.Windows.Forms.TextBox();
            this.textBoxBaiduKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSaveS = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNote
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxNote, 4);
            this.textBoxNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNote.Location = new System.Drawing.Point(3, 355);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(754, 21);
            this.textBoxNote.TabIndex = 55;
            // 
            // textBox来源内容
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox来源内容, 2);
            this.textBox来源内容.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox来源内容.Location = new System.Drawing.Point(3, 30);
            this.textBox来源内容.Multiline = true;
            this.textBox来源内容.Name = "textBox来源内容";
            this.textBox来源内容.ReadOnly = true;
            this.textBox来源内容.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox来源内容.Size = new System.Drawing.Size(374, 319);
            this.textBox来源内容.TabIndex = 54;
            // 
            // textBox目标
            // 
            this.textBox目标.Location = new System.Drawing.Point(73, 42);
            this.textBox目标.Name = "textBox目标";
            this.textBox目标.Size = new System.Drawing.Size(615, 21);
            this.textBox目标.TabIndex = 53;
            // 
            // textBox来源
            // 
            this.textBox来源.Location = new System.Drawing.Point(73, 13);
            this.textBox来源.Name = "textBox来源";
            this.textBox来源.Size = new System.Drawing.Size(616, 21);
            this.textBox来源.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 51;
            this.label2.Text = "目标";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "来源";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(14, 510);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 48;
            this.buttonLoad.Text = "读取文件";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 539);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(754, 10);
            this.progressBar1.TabIndex = 47;
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(694, 13);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(75, 21);
            this.buttonS.TabIndex = 46;
            this.buttonS.Text = "选择来源";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(694, 42);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(75, 21);
            this.buttonT.TabIndex = 45;
            this.buttonT.Text = "选择目标";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.Location = new System.Drawing.Point(694, 510);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFile.TabIndex = 44;
            this.buttonSaveFile.Text = "保存目标";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox目标内容
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox目标内容, 2);
            this.textBox目标内容.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox目标内容.Location = new System.Drawing.Point(383, 30);
            this.textBox目标内容.Multiline = true;
            this.textBox目标内容.Name = "textBox目标内容";
            this.textBox目标内容.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox目标内容.Size = new System.Drawing.Size(374, 319);
            this.textBox目标内容.TabIndex = 56;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonUpdate, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox来源标题, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNoKey, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox来源内容, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNote, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox目标内容, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox目标标题, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonNext, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrev, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 408);
            this.tableLayoutPanel1.TabIndex = 58;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(682, 382);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 64;
            this.buttonUpdate.Text = "更新条目";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBox来源标题
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox来源标题, 2);
            this.textBox来源标题.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox来源标题.Location = new System.Drawing.Point(3, 3);
            this.textBox来源标题.Name = "textBox来源标题";
            this.textBox来源标题.ReadOnly = true;
            this.textBox来源标题.Size = new System.Drawing.Size(374, 21);
            this.textBox来源标题.TabIndex = 57;
            // 
            // buttonNoKey
            // 
            this.buttonNoKey.AutoSize = true;
            this.buttonNoKey.Enabled = false;
            this.buttonNoKey.Location = new System.Drawing.Point(3, 382);
            this.buttonNoKey.Name = "buttonNoKey";
            this.buttonNoKey.Size = new System.Drawing.Size(111, 23);
            this.buttonNoKey.TabIndex = 63;
            this.buttonNoKey.Text = "查找未汉化的条目";
            this.buttonNoKey.UseVisualStyleBackColor = true;
            this.buttonNoKey.Click += new System.EventHandler(this.buttonNoKey_Click);
            // 
            // textBox目标标题
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox目标标题, 2);
            this.textBox目标标题.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox目标标题.Location = new System.Drawing.Point(383, 3);
            this.textBox目标标题.Name = "textBox目标标题";
            this.textBox目标标题.ReadOnly = true;
            this.textBox目标标题.Size = new System.Drawing.Size(374, 21);
            this.textBox目标标题.TabIndex = 58;
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(383, 382);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 59;
            this.buttonNext.Text = "下一条";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(302, 382);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 61;
            this.buttonPrev.Text = "上一条";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // openFileDialogT
            // 
            this.openFileDialogT.FileName = "openFileDialogT";
            // 
            // checkBoxAutoUp
            // 
            this.checkBoxAutoUp.AutoSize = true;
            this.checkBoxAutoUp.Checked = true;
            this.checkBoxAutoUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoUp.Location = new System.Drawing.Point(18, 485);
            this.checkBoxAutoUp.Name = "checkBoxAutoUp";
            this.checkBoxAutoUp.Size = new System.Drawing.Size(132, 16);
            this.checkBoxAutoUp.TabIndex = 59;
            this.checkBoxAutoUp.Text = "切换时自动更新条目";
            this.checkBoxAutoUp.UseVisualStyleBackColor = true;
            // 
            // buttonFY
            // 
            this.buttonFY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFY.Enabled = false;
            this.buttonFY.Location = new System.Drawing.Point(314, 482);
            this.buttonFY.Name = "buttonFY";
            this.buttonFY.Size = new System.Drawing.Size(75, 23);
            this.buttonFY.TabIndex = 60;
            this.buttonFY.Text = "百度翻译";
            this.buttonFY.UseVisualStyleBackColor = true;
            this.buttonFY.Click += new System.EventHandler(this.buttonFY_Click);
            // 
            // textBoxBaiduAppId
            // 
            this.textBoxBaiduAppId.Location = new System.Drawing.Point(470, 483);
            this.textBoxBaiduAppId.Name = "textBoxBaiduAppId";
            this.textBoxBaiduAppId.Size = new System.Drawing.Size(218, 21);
            this.textBoxBaiduAppId.TabIndex = 62;
            // 
            // textBoxBaiduKey
            // 
            this.textBoxBaiduKey.Location = new System.Drawing.Point(470, 512);
            this.textBoxBaiduKey.Name = "textBoxBaiduKey";
            this.textBoxBaiduKey.Size = new System.Drawing.Size(218, 21);
            this.textBoxBaiduKey.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 63;
            this.label3.Text = "百度 APP ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 64;
            this.label4.Text = "百度密钥";
            // 
            // checkBoxSaveS
            // 
            this.checkBoxSaveS.AutoSize = true;
            this.checkBoxSaveS.Location = new System.Drawing.Point(156, 485);
            this.checkBoxSaveS.Name = "checkBoxSaveS";
            this.checkBoxSaveS.Size = new System.Drawing.Size(132, 16);
            this.checkBoxSaveS.TabIndex = 65;
            this.checkBoxSaveS.Text = "用来源格式保存目标";
            this.checkBoxSaveS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.checkBoxSaveS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBaiduAppId);
            this.Controls.Add(this.textBoxBaiduKey);
            this.Controls.Add(this.buttonFY);
            this.Controls.Add(this.checkBoxAutoUp);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox目标);
            this.Controls.Add(this.textBox来源);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonSaveFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "XML文本汉化工具";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.TextBox textBox来源内容;
        private System.Windows.Forms.TextBox textBox目标;
        private System.Windows.Forms.TextBox textBox来源;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.TextBox textBox目标内容;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox目标标题;
        private System.Windows.Forms.TextBox textBox来源标题;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNoKey;
        private System.Windows.Forms.OpenFileDialog openFileDialogS;
        private System.Windows.Forms.OpenFileDialog openFileDialogT;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.CheckBox checkBoxAutoUp;
        private System.Windows.Forms.Button buttonFY;
        private System.Windows.Forms.TextBox textBoxBaiduAppId;
        private System.Windows.Forms.TextBox textBoxBaiduKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxSaveS;
    }
}

