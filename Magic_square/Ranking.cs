using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Magic_square
{
    public partial class Ranking : Form
    {
        public NameRegister nRegist;
        public Controler contform;
        public Start setform;
        public const string FILENAME = "magicSquare.rank"; //ランキング保存用ファイル名

        public Ranking()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //ウィンドウの大きさを固定
        }

        public void GraphMake(int side, bool flugPlayed)
        {
            //ランキング表作成　及び　ランキング保存処理
            /* ファイルからランキングデータを読み込んでソートして順位を計算して表に表示してファイルに保存する */

            Encoding utf8Enc = Encoding.GetEncoding("UTF-8"); //文字コード
            string Record = contform.lab_CntDown.Text; //今回のレコード

            //追記・新記録判定　処理
            if (flugPlayed)
            {
                //追記
                DateTime dt = DateTime.Now;
                StreamWriter sw = new StreamWriter(FILENAME, true, utf8Enc);
                //[ランキング保存形式]
                //一辺(side),名前,クリアまでの経過時間(00:00:00),日付(MM/dd)
                sw.WriteLine(side + "," + nRegist.txt_Name.Text + "," + contform.lab_CntDown.Text + "," + dt.ToString("yyyy/MM/dd"));
                sw.Close();                
            }

            //RANKファイルが存在するかどうか判定
            string rankpath =  Directory.GetCurrentDirectory() + "\\" + FILENAME;
            if (File.Exists(rankpath))
            {
                // RANKファイルオープン
                StreamReader sr =
                    new StreamReader(FILENAME, utf8Enc);
                // RANKファイルの各セルをDataGridViewに表示
                grid_Rank.Rows.Clear();
                int r = 0;
                String lin = "";
                do
                {
                    lin = sr.ReadLine();
                    if (lin != null)
                    {
                        String[] csv = lin.Split(',');
                        if (csv[0] == side.ToString())
                        {
                            grid_Rank.Rows.Add();
                            for (int c = 0; c <= csv.GetLength(0) - 1; c++)
                            {
                                if (c < grid_Rank.Columns.Count)
                                {
                                    grid_Rank.Rows[r].Cells[c].Value = csv[c];
                                }
                            }
                            r += 1;
                        }
                    }
                } while (lin != null);
                // RANKファイルクローズ
                sr.Close();

                // ランキングが登録されているか判定
                if (r != 0)
                {

                    //プレイ中かどうかを判定
                    if (!(setform.notPlaying))
                    {
                        //所要時間の短い順にソートし、新記録かを判定
                        grid_Rank.Sort(grid_Rank.Columns[2], ListSortDirection.Ascending);
                        DataGridViewRow rankData = null;
                        string clearMsg = "魔法陣が解かれました";
                        string diagTitle = "クリア";

                        //
                        rankData = grid_Rank.Rows.Cast<DataGridViewRow>().First(row => row.Cells[2].Value.Equals(Record));
                        if (grid_Rank.Rows[0].Cells[2].Value.ToString() == Record)
                        {
                            clearMsg = "おめでとうございます、新記録を達成しました！";
                            picBox_yosano.SizeMode = PictureBoxSizeMode.StretchImage;
                            picBox_yosano.Image = Properties.Resources.yosano; //新記録だったので与謝野晶子を表示
                        }

                        string diagMsg = clearMsg + "\n一辺の数\t：" + side + "\nタイム\t：" + Record + "\n順位\t：" + (rankData.Index + 1);
                        

                    }

                    this.Text += " / 一辺の数：" + side.ToString();

                    grid_Rank.ReadOnly = true;

                    this.Show(); //やっと表示させる
                } else
                {
                    //ランキングが登録されていない場合
                    MessageBox.Show("ランキングデータがありません。","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else {
                //もし、RANKファイルが存在しないなら
                //例) 初回起動時の設定画面からのランキング表示
                MessageBox.Show("ランキングデータがありません。","警告",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void Ranking_Closing(object sender, FormClosingEventArgs e)
        {
            if (!(setform.notPlaying))
            //もし、!プレイしてない(つまりプレイ中、又はクリア後)ならば、終了する
            {
                //「×」ボタン押下で閉じた時の終了処理
                this.Dispose();
                Application.Exit();
            }
        }

        private void grid_Rank_KeyDown(object sender, KeyEventArgs e)
        {
            if (setform.DEBUG)
            {
                if(e.KeyCode == Keys.F1)
                {
                    //デバッグモード時にF1キーを押すと与謝野を表示
                    picBox_yosano.SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox_yosano.Image = Properties.Resources.yosano;

                }
            }
        }
    }
}
