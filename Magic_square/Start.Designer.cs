namespace Magic_square
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btn_Create = new System.Windows.Forms.Button();
            this.lab_Explain = new System.Windows.Forms.Label();
            this.bar_SideNum = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_showRank = new System.Windows.Forms.Button();
            this.line_horizon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bar_SideNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(98, 114);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(92, 23);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "作成";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // lab_Explain
            // 
            this.lab_Explain.AutoSize = true;
            this.lab_Explain.Location = new System.Drawing.Point(14, 9);
            this.lab_Explain.Name = "lab_Explain";
            this.lab_Explain.Size = new System.Drawing.Size(171, 60);
            this.lab_Explain.TabIndex = 1;
            this.lab_Explain.Text = "作成したい魔法陣の一辺の数を\r\n選択して、「作成」を押してください。\r\n例)右の図だと「3」\r\n\r\n  1　　　　 　　　　　　　　　　　　　27";
            // 
            // bar_SideNum
            // 
            this.bar_SideNum.CausesValidation = false;
            this.bar_SideNum.Location = new System.Drawing.Point(14, 66);
            this.bar_SideNum.Maximum = 27;
            this.bar_SideNum.Minimum = 1;
            this.bar_SideNum.Name = "bar_SideNum";
            this.bar_SideNum.Size = new System.Drawing.Size(176, 45);
            this.bar_SideNum.TabIndex = 4;
            this.bar_SideNum.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.bar_SideNum.Value = 1;
            this.bar_SideNum.ValueChanged += new System.EventHandler(this.bar_SideNum_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magic_square.Properties.Resources.magic_square;
            this.pictureBox1.Location = new System.Drawing.Point(228, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 115);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "一辺の長さ : 1";
            // 
            // btn_continue
            // 
            this.btn_continue.Enabled = false;
            this.btn_continue.Location = new System.Drawing.Point(228, 141);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(131, 23);
            this.btn_continue.TabIndex = 8;
            this.btn_continue.Text = "ゲームを再開";
            this.btn_continue.UseVisualStyleBackColor = true;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_showRank
            // 
            this.btn_showRank.Location = new System.Drawing.Point(98, 143);
            this.btn_showRank.Name = "btn_showRank";
            this.btn_showRank.Size = new System.Drawing.Size(92, 23);
            this.btn_showRank.TabIndex = 9;
            this.btn_showRank.Text = "ランキングを見る";
            this.btn_showRank.UseVisualStyleBackColor = true;
            this.btn_showRank.Click += new System.EventHandler(this.btn_showRank_Click);
            // 
            // line_horizon
            // 
            this.line_horizon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.line_horizon.Location = new System.Drawing.Point(210, 7);
            this.line_horizon.Name = "line_horizon";
            this.line_horizon.Size = new System.Drawing.Size(1, 171);
            this.line_horizon.TabIndex = 7;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 189);
            this.Controls.Add(this.btn_showRank);
            this.Controls.Add(this.btn_continue);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.line_horizon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_Explain);
            this.Controls.Add(this.bar_SideNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "Magic Square - 設定";
            ((System.ComponentModel.ISupportInitialize)(this.bar_SideNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label lab_Explain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_showRank;
        private System.Windows.Forms.Label line_horizon;
        public System.Windows.Forms.TrackBar bar_SideNum;
    }
}