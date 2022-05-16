namespace WindowForm_day3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_dic = new System.Windows.Forms.ListBox();
            this.lb_file = new System.Windows.Forms.ListBox();
            this.lb_dicinfo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_dic
            // 
            this.lb_dic.FormattingEnabled = true;
            this.lb_dic.ItemHeight = 18;
            this.lb_dic.Location = new System.Drawing.Point(55, 37);
            this.lb_dic.Name = "lb_dic";
            this.lb_dic.Size = new System.Drawing.Size(488, 94);
            this.lb_dic.TabIndex = 0;
            // 
            // lb_file
            // 
            this.lb_file.FormattingEnabled = true;
            this.lb_file.ItemHeight = 18;
            this.lb_file.Location = new System.Drawing.Point(55, 160);
            this.lb_file.Name = "lb_file";
            this.lb_file.Size = new System.Drawing.Size(488, 94);
            this.lb_file.TabIndex = 1;
            // 
            // lb_dicinfo
            // 
            this.lb_dicinfo.FormattingEnabled = true;
            this.lb_dicinfo.ItemHeight = 18;
            this.lb_dicinfo.Location = new System.Drawing.Point(55, 287);
            this.lb_dicinfo.Name = "lb_dicinfo";
            this.lb_dicinfo.Size = new System.Drawing.Size(488, 94);
            this.lb_dicinfo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 73);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 73);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 73);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_dicinfo);
            this.Controls.Add(this.lb_file);
            this.Controls.Add(this.lb_dic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_dic;
        private System.Windows.Forms.ListBox lb_file;
        private System.Windows.Forms.ListBox lb_dicinfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

