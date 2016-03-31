using System;
using System.Windows.Forms;

namespace Magic_square
{
    public partial class Start : Form
    {
        //メンバ変数
        public PlayForm playform;
        public Controler contform;
        public NameRegister nRegist;
        public Ranking rankform;

	    public bool notPlaying = true;
        public bool DEBUG = true;

        public Start()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //ウィンドウの大きさを固定
        }

        private void bar_SideNum_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = "一辺の長さ : " + bar_SideNum.Value;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            //初回起動判定
            bool lunch = true;
            if (playform != null)
            {
                lunch = false;
                DialogResult ret = MessageBox.Show("魔方陣を解き終わっていませんが、新しい魔方陣を作成しますか？",
                                                                            "確認",
                                                                            MessageBoxButtons.OKCancel,
                                                                            MessageBoxIcon.Question,
                                                                            MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.OK)
                {
                    lunch = true;
                }
            }

            //ディスプレイの高さ　と　幅を取得
            int h = Screen.PrimaryScreen.Bounds.Height;
            int w = Screen.PrimaryScreen.Bounds.Width;
            //もし、ディスプレイのサイズよりも大きくなる場合、警告する
            if (( (30 * (bar_SideNum.Value + 3) + 30) > h - 205)||
                  (35 * (bar_SideNum.Value + 2) + 20 > w - 40))
            {
                lunch = false;
                DialogResult ret = MessageBox.Show("魔方陣がタスクバーに覆い隠されてしまう可能性があります。\nこの魔方陣を表示させますか？\n(「キャンセル」を押すと設定画面に戻ります。)",
                                                                            "警告",
                                                                            MessageBoxButtons.OKCancel,
                                                                            MessageBoxIcon.Warning,
                                                                            MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.OK)
                {
                    lunch = true;
                }
            }

            if (lunch)
            {
		        //フラグをプレイ中に
		        notPlaying = false;

                /* フォームインスタンスの作成 */
                playform = new PlayForm();
                contform = new Controler();
                nRegist = new NameRegister();
                rankform = new Ranking();

                // 子フォームに、各フォームを制御する情報を伝達
                contform.playform = this.playform;
                contform.setform = this;
                playform.contform = this.contform;
                playform.nRegist = this.nRegist;
                nRegist.playform = this.playform;
                nRegist.contform = this.contform;
                nRegist.rankform = this.rankform;
                rankform.nRegist = this.nRegist;
                rankform.contform = this.contform;
                rankform.setform = this;

                /* 魔方陣の生成 */
                if (bar_SideNum.Value == 2)
                {
                    MessageBox.Show("一辺が「2」の魔方陣では仕様上、各列の合計値を表示できません。\n　ご注意ください。", "注意",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Warning);
                    playform.lab_default = "-";
                }

                playform.Create_MS(bar_SideNum.Value);

                //フォーム表示・非表示
                this.btn_Create.Text = "新規作成";
                this.Hide();
                playform.Show();
                contform.Show();
                btn_continue.Enabled = true;
                playform.Top = 145;
                playform.Left = 20;
                playform.StartPosition = FormStartPosition.Manual;

                //コントローラウィンドウ位置変更
                contform.Top = playform.Top - 85;
                contform.Left = playform.Left;
            }
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            this.Hide();
            playform.Show();
            contform.Show();
            btn_continue.Enabled = false;
            contform.timer.Start();
        }

        private void btn_showRank_Click(object sender, EventArgs e)
        {
            rankform = new Ranking();
            rankform.setform = this;
            rankform.GraphMake(bar_SideNum.Value, false);
        }
    }
}
