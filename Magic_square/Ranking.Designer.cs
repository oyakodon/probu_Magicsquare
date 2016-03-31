namespace Magic_square
{
    partial class Ranking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            this.grid_Rank = new System.Windows.Forms.DataGridView();
            this.Column_side = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ClearTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picBox_yosano = new System.Windows.Forms.PictureBox();
            this.lab_ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Rank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_yosano)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Rank
            // 
            this.grid_Rank.AllowUserToAddRows = false;
            this.grid_Rank.AllowUserToDeleteRows = false;
            this.grid_Rank.AllowUserToResizeColumns = false;
            this.grid_Rank.AllowUserToResizeRows = false;
            this.grid_Rank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Rank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_side,
            this.Column_Name,
            this.Column_ClearTime,
            this.Column_Date});
            this.grid_Rank.Location = new System.Drawing.Point(12, 116);
            this.grid_Rank.Name = "grid_Rank";
            this.grid_Rank.RowHeadersVisible = false;
            this.grid_Rank.RowTemplate.Height = 21;
            this.grid_Rank.Size = new System.Drawing.Size(328, 237);
            this.grid_Rank.TabIndex = 0;
            this.grid_Rank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_Rank_KeyDown);
            // 
            // Column_side
            // 
            this.Column_side.HeaderText = "一辺の数";
            this.Column_side.Name = "Column_side";
            this.Column_side.Visible = false;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "名前";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_ClearTime
            // 
            this.Column_ClearTime.HeaderText = "クリアタイム";
            this.Column_ClearTime.Name = "Column_ClearTime";
            // 
            // Column_Date
            // 
            this.Column_Date.HeaderText = "日付";
            this.Column_Date.Name = "Column_Date";
            // 
            // picBox_yosano
            // 
            this.picBox_yosano.Image = global::Magic_square.Properties.Resources.magic_square;
            this.picBox_yosano.Location = new System.Drawing.Point(358, 12);
            this.picBox_yosano.Name = "picBox_yosano";
            this.picBox_yosano.Size = new System.Drawing.Size(158, 341);
            this.picBox_yosano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox_yosano.TabIndex = 2;
            this.picBox_yosano.TabStop = false;
            // 
            // lab_
            // 
            this.lab_.AutoSize = true;
            this.lab_.Location = new System.Drawing.Point(10, 12);
            this.lab_.Name = "lab_";
            this.lab_.Size = new System.Drawing.Size(35, 12);
            this.lab_.TabIndex = 3;
            this.lab_.Text = "label1";
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 365);
            this.Controls.Add(this.lab_);
            this.Controls.Add(this.picBox_yosano);
            this.Controls.Add(this.grid_Rank);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ranking";
            this.Text = "ランキング";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ranking_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Rank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_yosano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView grid_Rank;
        public System.Windows.Forms.PictureBox picBox_yosano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_side;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ClearTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Date;
        private System.Windows.Forms.Label lab_;
    }
}