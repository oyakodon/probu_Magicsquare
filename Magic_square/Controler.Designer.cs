namespace Magic_square
{
    partial class Controler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controler));
            this.btn_DeleteAll = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_CntDown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_DeleteAll
            // 
            this.btn_DeleteAll.Location = new System.Drawing.Point(12, 12);
            this.btn_DeleteAll.Name = "btn_DeleteAll";
            this.btn_DeleteAll.Size = new System.Drawing.Size(62, 23);
            this.btn_DeleteAll.TabIndex = 0;
            this.btn_DeleteAll.Text = "全消去";
            this.btn_DeleteAll.UseVisualStyleBackColor = true;
            this.btn_DeleteAll.Click += new System.EventHandler(this.btn_DeleteAll_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(315, 12);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(75, 23);
            this.btn_Pause.TabIndex = 1;
            this.btn_Pause.Text = "一時停止";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("MS UI Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Exit.Location = new System.Drawing.Point(396, 12);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(59, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "終了";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "経過時間：";
            // 
            // lab_CntDown
            // 
            this.lab_CntDown.Font = new System.Drawing.Font("MS UI Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_CntDown.Location = new System.Drawing.Point(189, 12);
            this.lab_CntDown.Name = "lab_CntDown";
            this.lab_CntDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_CntDown.Size = new System.Drawing.Size(103, 23);
            this.lab_CntDown.TabIndex = 4;
            this.lab_CntDown.Text = "00:00:00";
            this.lab_CntDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Controler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 44);
            this.Controls.Add(this.lab_CntDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_DeleteAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Controler";
            this.Text = "Magic Square - 操作パネル";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controler_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_DeleteAll;
        public System.Windows.Forms.Button btn_Pause;
        public System.Windows.Forms.Label lab_CntDown;
    }
}