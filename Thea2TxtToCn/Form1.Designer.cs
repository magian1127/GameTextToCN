namespace Thea2TxtToCn
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBaiduAppId = new System.Windows.Forms.TextBox();
            this.textBoxBaiduKey = new System.Windows.Forms.TextBox();
            this.buttonFY = new System.Windows.Forms.Button();
            this.checkBoxAutoUp = new System.Windows.Forms.CheckBox();
            this.openFileDialogT = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogS = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox来源OUTs = new System.Windows.Forms.TextBox();
            this.textBox来源标题 = new System.Windows.Forms.TextBox();
            this.textBox来源STORY = new System.Windows.Forms.TextBox();
            this.textBox目标STORY = new System.Windows.Forms.TextBox();
            this.textBox目标标题 = new System.Windows.Forms.TextBox();
            this.textBox目标OUTs = new System.Windows.Forms.TextBox();
            this.buttonNoKey = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBox目标 = new System.Windows.Forms.TextBox();
            this.textBox来源 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 80;
            this.label3.Text = "百度 APP ID";
            // 
            // textBoxBaiduAppId
            // 
            this.textBoxBaiduAppId.Location = new System.Drawing.Point(470, 482);
            this.textBoxBaiduAppId.Name = "textBoxBaiduAppId";
            this.textBoxBaiduAppId.Size = new System.Drawing.Size(218, 21);
            this.textBoxBaiduAppId.TabIndex = 79;
            // 
            // textBoxBaiduKey
            // 
            this.textBoxBaiduKey.Location = new System.Drawing.Point(470, 511);
            this.textBoxBaiduKey.Name = "textBoxBaiduKey";
            this.textBoxBaiduKey.Size = new System.Drawing.Size(218, 21);
            this.textBoxBaiduKey.TabIndex = 78;
            // 
            // buttonFY
            // 
            this.buttonFY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFY.Enabled = false;
            this.buttonFY.Location = new System.Drawing.Point(314, 481);
            this.buttonFY.Name = "buttonFY";
            this.buttonFY.Size = new System.Drawing.Size(75, 23);
            this.buttonFY.TabIndex = 77;
            this.buttonFY.Text = "百度翻译";
            this.buttonFY.UseVisualStyleBackColor = true;
            this.buttonFY.Click += new System.EventHandler(this.buttonFY_Click);
            // 
            // checkBoxAutoUp
            // 
            this.checkBoxAutoUp.AutoSize = true;
            this.checkBoxAutoUp.Checked = true;
            this.checkBoxAutoUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoUp.Location = new System.Drawing.Point(18, 484);
            this.checkBoxAutoUp.Name = "checkBoxAutoUp";
            this.checkBoxAutoUp.Size = new System.Drawing.Size(132, 16);
            this.checkBoxAutoUp.TabIndex = 76;
            this.checkBoxAutoUp.Text = "切换时自动更新条目";
            this.checkBoxAutoUp.UseVisualStyleBackColor = true;
            // 
            // openFileDialogT
            // 
            this.openFileDialogT.FileName = "openFileDialogT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 81;
            this.label4.Text = "百度密钥";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBox来源OUTs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox来源标题, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox来源STORY, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox目标STORY, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox目标标题, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox目标OUTs, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNoKey, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrev, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonNext, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonUpdate, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNote, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 408);
            this.tableLayoutPanel1.TabIndex = 75;
            // 
            // textBox来源OUTs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox来源OUTs, 2);
            this.textBox来源OUTs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox来源OUTs.Location = new System.Drawing.Point(3, 192);
            this.textBox来源OUTs.Multiline = true;
            this.textBox来源OUTs.Name = "textBox来源OUTs";
            this.textBox来源OUTs.ReadOnly = true;
            this.textBox来源OUTs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox来源OUTs.Size = new System.Drawing.Size(374, 156);
            this.textBox来源OUTs.TabIndex = 65;
            this.textBox来源OUTs.WordWrap = false;
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
            // textBox来源STORY
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox来源STORY, 2);
            this.textBox来源STORY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox来源STORY.Location = new System.Drawing.Point(3, 30);
            this.textBox来源STORY.Multiline = true;
            this.textBox来源STORY.Name = "textBox来源STORY";
            this.textBox来源STORY.ReadOnly = true;
            this.textBox来源STORY.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox来源STORY.Size = new System.Drawing.Size(374, 156);
            this.textBox来源STORY.TabIndex = 54;
            // 
            // textBox目标STORY
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox目标STORY, 2);
            this.textBox目标STORY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox目标STORY.Location = new System.Drawing.Point(383, 30);
            this.textBox目标STORY.Multiline = true;
            this.textBox目标STORY.Name = "textBox目标STORY";
            this.textBox目标STORY.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox目标STORY.Size = new System.Drawing.Size(374, 156);
            this.textBox目标STORY.TabIndex = 56;
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
            // textBox目标OUTs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox目标OUTs, 2);
            this.textBox目标OUTs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox目标OUTs.Location = new System.Drawing.Point(383, 192);
            this.textBox目标OUTs.Multiline = true;
            this.textBox目标OUTs.Name = "textBox目标OUTs";
            this.textBox目标OUTs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox目标OUTs.Size = new System.Drawing.Size(374, 156);
            this.textBox目标OUTs.TabIndex = 66;
            this.textBox目标OUTs.WordWrap = false;
            // 
            // buttonNoKey
            // 
            this.buttonNoKey.AutoSize = true;
            this.buttonNoKey.Enabled = false;
            this.buttonNoKey.Location = new System.Drawing.Point(3, 381);
            this.buttonNoKey.Name = "buttonNoKey";
            this.buttonNoKey.Size = new System.Drawing.Size(111, 22);
            this.buttonNoKey.TabIndex = 63;
            this.buttonNoKey.Text = "查找未汉化的条目";
            this.buttonNoKey.UseVisualStyleBackColor = true;
            this.buttonNoKey.Click += new System.EventHandler(this.buttonNoKey_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(302, 381);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 61;
            this.buttonPrev.Text = "上一条";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(383, 381);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 59;
            this.buttonNext.Text = "下一条";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(682, 381);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 64;
            this.buttonUpdate.Text = "更新条目";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxNote
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxNote, 4);
            this.textBoxNote.Location = new System.Drawing.Point(3, 354);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(754, 21);
            this.textBoxNote.TabIndex = 67;
            // 
            // textBox目标
            // 
            this.textBox目标.Location = new System.Drawing.Point(73, 41);
            this.textBox目标.Name = "textBox目标";
            this.textBox目标.Size = new System.Drawing.Size(615, 21);
            this.textBox目标.TabIndex = 74;
            // 
            // textBox来源
            // 
            this.textBox来源.Location = new System.Drawing.Point(73, 12);
            this.textBox来源.Name = "textBox来源";
            this.textBox来源.Size = new System.Drawing.Size(616, 21);
            this.textBox来源.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 72;
            this.label2.Text = "目标";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 71;
            this.label1.Text = "来源";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(14, 509);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 70;
            this.buttonLoad.Text = "读取文件";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 538);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(754, 10);
            this.progressBar1.TabIndex = 69;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Enabled = false;
            this.buttonSaveFile.Location = new System.Drawing.Point(694, 509);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFile.TabIndex = 66;
            this.buttonSaveFile.Text = "保存目标";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(694, 12);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(75, 21);
            this.buttonS.TabIndex = 68;
            this.buttonS.Text = "选择来源";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(694, 41);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(75, 21);
            this.buttonT.TabIndex = 67;
            this.buttonT.Text = "选择目标";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBaiduAppId);
            this.Controls.Add(this.textBoxBaiduKey);
            this.Controls.Add(this.buttonFY);
            this.Controls.Add(this.checkBoxAutoUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox目标);
            this.Controls.Add(this.textBox来源);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "西娅2事件文本汉化工具";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBaiduAppId;
        private System.Windows.Forms.TextBox textBoxBaiduKey;
        private System.Windows.Forms.Button buttonFY;
        private System.Windows.Forms.CheckBox checkBoxAutoUp;
        private System.Windows.Forms.OpenFileDialog openFileDialogT;
        private System.Windows.Forms.OpenFileDialog openFileDialogS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBox来源标题;
        private System.Windows.Forms.Button buttonNoKey;
        private System.Windows.Forms.TextBox textBox来源STORY;
        private System.Windows.Forms.TextBox textBox目标STORY;
        private System.Windows.Forms.TextBox textBox目标标题;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.TextBox textBox目标;
        private System.Windows.Forms.TextBox textBox来源;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.TextBox textBox来源OUTs;
        private System.Windows.Forms.TextBox textBox目标OUTs;
        private System.Windows.Forms.TextBox textBoxNote;
    }
}

