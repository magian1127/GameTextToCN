namespace rAthenaCNTools
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonHH = new System.Windows.Forms.Button();
            this.buttonDictionary = new System.Windows.Forms.Button();
            this.buttonSQL = new System.Windows.Forms.Button();
            this.buttonTXT = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDIV = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelZZ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(547, 401);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "生成字典";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(610, 296);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "\n字典文件：\n\nSQL 文件：\n\nTXT 文件：\n\n其他目录：\n";
            // 
            // buttonHH
            // 
            this.buttonHH.Location = new System.Drawing.Point(12, 401);
            this.buttonHH.Name = "buttonHH";
            this.buttonHH.Size = new System.Drawing.Size(75, 23);
            this.buttonHH.TabIndex = 2;
            this.buttonHH.Text = "汉化";
            this.buttonHH.UseVisualStyleBackColor = true;
            this.buttonHH.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonDictionary
            // 
            this.buttonDictionary.Location = new System.Drawing.Point(12, 314);
            this.buttonDictionary.Name = "buttonDictionary";
            this.buttonDictionary.Size = new System.Drawing.Size(75, 23);
            this.buttonDictionary.TabIndex = 17;
            this.buttonDictionary.Text = "选择字典";
            this.buttonDictionary.UseVisualStyleBackColor = true;
            this.buttonDictionary.Click += new System.EventHandler(this.buttonDictionary_Click);
            // 
            // buttonSQL
            // 
            this.buttonSQL.Location = new System.Drawing.Point(93, 314);
            this.buttonSQL.Name = "buttonSQL";
            this.buttonSQL.Size = new System.Drawing.Size(75, 23);
            this.buttonSQL.TabIndex = 18;
            this.buttonSQL.Text = "选择SQL";
            this.buttonSQL.UseVisualStyleBackColor = true;
            this.buttonSQL.Click += new System.EventHandler(this.buttonSQL_Click);
            // 
            // buttonTXT
            // 
            this.buttonTXT.Location = new System.Drawing.Point(174, 314);
            this.buttonTXT.Name = "buttonTXT";
            this.buttonTXT.Size = new System.Drawing.Size(75, 23);
            this.buttonTXT.TabIndex = 19;
            this.buttonTXT.Text = "选择TXT";
            this.buttonTXT.UseVisualStyleBackColor = true;
            this.buttonTXT.Click += new System.EventHandler(this.buttonTXT_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 430);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(610, 10);
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Visible = false;
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(466, 401);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 23);
            this.buttonC.TabIndex = 24;
            this.buttonC.Text = "清空选项";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonDIV
            // 
            this.buttonDIV.Location = new System.Drawing.Point(255, 314);
            this.buttonDIV.Name = "buttonDIV";
            this.buttonDIV.Size = new System.Drawing.Size(75, 23);
            this.buttonDIV.TabIndex = 25;
            this.buttonDIV.Text = "选择目录";
            this.buttonDIV.UseVisualStyleBackColor = true;
            this.buttonDIV.Click += new System.EventHandler(this.buttonDIV_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "item_db和mob_db的sql和txt",
            "quest_db.txt",
            "npc文件夹里脚本内怪物刷新名称"});
            this.comboBox1.Location = new System.Drawing.Point(131, 343);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(491, 20);
            this.comboBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "汉化文件类型选择：";
            // 
            // labelZZ
            // 
            this.labelZZ.AutoSize = true;
            this.labelZZ.Location = new System.Drawing.Point(569, 319);
            this.labelZZ.Name = "labelZZ";
            this.labelZZ.Size = new System.Drawing.Size(53, 12);
            this.labelZZ.TabIndex = 29;
            this.labelZZ.Text = "94zl.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 452);
            this.Controls.Add(this.labelZZ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDIV);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonTXT);
            this.Controls.Add(this.buttonSQL);
            this.Controls.Add(this.buttonDictionary);
            this.Controls.Add(this.buttonHH);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rathena汉化器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonHH;
        private System.Windows.Forms.Button buttonDictionary;
        private System.Windows.Forms.Button buttonSQL;
        private System.Windows.Forms.Button buttonTXT;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonDIV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelZZ;
    }
}

