namespace POExml
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.checkBoxE = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox源 = new System.Windows.Forms.TextBox();
            this.textBox目标 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "执行覆盖";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(537, 41);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(75, 21);
            this.buttonT.TabIndex = 1;
            this.buttonT.Text = "选择目标";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(537, 12);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(75, 21);
            this.buttonS.TabIndex = 2;
            this.buttonS.Text = "选择源";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 419);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(600, 10);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Visible = false;
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(14, 390);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 23);
            this.buttonDiv.TabIndex = 25;
            this.buttonDiv.Text = "读取目录";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // checkBoxE
            // 
            this.checkBoxE.AutoSize = true;
            this.checkBoxE.Checked = true;
            this.checkBoxE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxE.Location = new System.Drawing.Point(13, 368);
            this.checkBoxE.Name = "checkBoxE";
            this.checkBoxE.Size = new System.Drawing.Size(132, 16);
            this.checkBoxE.TabIndex = 26;
            this.checkBoxE.Text = "只覆盖目标英文文本";
            this.checkBoxE.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "源";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "目标";
            // 
            // textBox源
            // 
            this.textBox源.Location = new System.Drawing.Point(72, 12);
            this.textBox源.Name = "textBox源";
            this.textBox源.Size = new System.Drawing.Size(459, 21);
            this.textBox源.TabIndex = 29;
            // 
            // textBox目标
            // 
            this.textBox目标.Location = new System.Drawing.Point(72, 41);
            this.textBox目标.Name = "textBox目标";
            this.textBox目标.Size = new System.Drawing.Size(459, 21);
            this.textBox目标.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(599, 294);
            this.textBox1.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox目标);
            this.Controls.Add(this.textBox源);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxE);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "POEXML小工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.CheckBox checkBoxE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox源;
        private System.Windows.Forms.TextBox textBox目标;
        private System.Windows.Forms.TextBox textBox1;
    }
}

