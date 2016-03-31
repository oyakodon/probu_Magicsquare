namespace Magic_square
{
    partial class NameRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameRegister));
            this.btn_Regest = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Regest
            // 
            this.btn_Regest.Location = new System.Drawing.Point(12, 68);
            this.btn_Regest.Name = "btn_Regest";
            this.btn_Regest.Size = new System.Drawing.Size(75, 23);
            this.btn_Regest.TabIndex = 0;
            this.btn_Regest.Text = "登録";
            this.btn_Regest.UseVisualStyleBackColor = true;
            this.btn_Regest.Click += new System.EventHandler(this.btn_Regest_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(153, 68);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "キャンセル";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(29, 43);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(187, 19);
            this.txt_Name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "今回の記録をランキングに保存する場合は、\r\n下に名前を入力して、「登録」を押してください。";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 103);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Regest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NameRegister";
            this.Text = "名前登録";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Regist_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Regest;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Name;
    }
}