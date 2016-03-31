using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Magic_square
{
    public partial class NameRegister: Form
    {
        public PlayForm playform;
        public Controler contform;
        public Ranking rankform;

        public NameRegister()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //ウィンドウの大きさを固定
        }

        private void btn_Regest_Click(object sender, EventArgs e)
        {
            rankform.GraphMake(playform.side, true);
            this.Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Show_Ranking();
        }

        private void Regist_Closing(object sender , FormClosingEventArgs e)
        {
            Show_Ranking();
        }

        private void Show_Ranking()
        {
            this.Dispose(); //このフォームを破棄
            rankform.GraphMake(playform.side, false);  //ランキングを生成して表示
        }
    }
}
