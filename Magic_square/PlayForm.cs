using System;

using System.Drawing;
using System.Windows.Forms;

namespace Magic_square
{
    public partial class PlayForm : Form
    {
        private TextBox[] textboxes;
        private Label[] labels;
        public string lab_default = "0";
        public int side = 0;
        public bool clear = false;

        public Controler contform;
        public NameRegister nRegist;

        public PlayForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;　//枠線を選択できないようにする(＝大きさ固定)
        }

        /// <summary>
        ///魔方陣の作成
        /// <param name="input">一辺のマス数</param>
        /// </summary>
        public void Create_MS(int input)
        {
            side = input;  //メンバ変数に代入

            this.Height = 30 * (side + 3) + 30;
            this.Width = 35 * (side + 2) + 20;
            int side_sqrt = side * side; //一辺の二乗
            int cnt_lab = 0; //ラベルカウント変数
            int margin_top = 50, margin_left = 30; //余白の定義
            textboxes = new TextBox[side_sqrt];
            labels = new Label[side * 2 + 1];
            for (int i = 0; i < textboxes.Length; i++)
            {
                //一辺の長さになったら改行処理
                if (i % side == 0)
                {
                    margin_top = 50 + -30 * side * (i / side);
                    margin_left = 30 + 35 * (i / side);
                    //ラベル作成
                    int[] lab_id = new int[] { cnt_lab, (side * 2 - 1 - cnt_lab) };
                    //プロパティ設定
                    foreach (int id in lab_id)
                    {
                        labels[id] = new Label();
                        labels[id].Name = "SumLab" + cnt_lab.ToString();
                        labels[id].Text = lab_default ;
                        labels[id].Width = 20;
                        labels[id].Font = new Font("Arial", 8);
                        labels[id].TextAlign = ContentAlignment.BottomCenter;
                        labels[id].ForeColor = Color.Red;
                    }
                    labels[lab_id[0]].Left = margin_left + 7;
                    labels[lab_id[0]].Top = 20;
                    labels[lab_id[1]].Left = 35 * (side + 1);
                    labels[lab_id[1]].Top = 30 * (side + 1) - cnt_lab * 30 -  13;
                    //コントロールに追加
                    Controls.Add(labels[lab_id[0]]);
                    Controls.Add(labels[lab_id[1]]);
                    cnt_lab++;
                }
                //テキストボックスコントロールのインスタンス作成
                textboxes[i] = new TextBox();
        
                //プロパティ設定
                textboxes[i].Name = i.ToString();
                textboxes[i].Width = 30; //横の長さ
                textboxes[i].Top = margin_top + i * 30; //上からの位置
                textboxes[i].Left = margin_left ; //左からの位置
                textboxes[i].Font = new Font("Arial", 12, FontStyle.Bold); //フォント設定
                textboxes[i].TextAlign = HorizontalAlignment.Center;
                //数字とバックスペースのみ入力できるよう、KeyPressイベントに処理を追加
                textboxes[i].KeyPress += new KeyPressEventHandler(NumPress);
                //入力チェックと合計値表示のために、TextChangedイベントに処理を追加
                textboxes[i].TextChanged += new EventHandler(NumChanged);

                //コントロールをフォームに追加
                Controls.Add(textboxes[i]);
            }
            //斜めの合計値表示ラベルの作成
            labels[side * 2] = new Label();
            labels[side * 2].Name = (side * 2).ToString();
            labels[side * 2].Text = lab_default;
            labels[side * 2].Width = 20;
            labels[side * 2].Font = new Font("Arial", 8);
            labels[side * 2].TextAlign = ContentAlignment.BottomCenter;
            labels[side * 2].ForeColor = Color.Red;
            labels[side * 2].Left = 35 * (side + 1);
            labels[side * 2].Top = 30 * (side + 1) + 10;
            Controls.Add(labels[side * 2]);
        }

        public void DeleteAll()
        {
            for (int i = 0; i < (side * side); i++)
            {
                textboxes[i].Text = "";
            }
            for (int j = 0; j < (side * 2 + 1); j++)
            {
                labels[j].Text = "0";
            }
        }

        private void NumPress(object sender, KeyPressEventArgs e)
        {
            //0～9(数字)と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            //バックスペースが入力された時、ラベルを空白にする
            if (e.KeyChar == '\b')
            {
                int input = 0, id = 0, side_sqrt = side * side;
                try
                {
                    input = int.Parse(((TextBox)sender).Text); //TextBoxに入力された数字
                    id = int.Parse(((TextBox)sender).Name); //Textboxの名前(＝コントロールID)
                }
                catch { /* Do Nothing */ }

                //入力欄の縦、横のラベルを"-"(文字色：黒)にする
                int[] tmp = new int[] { (id / side), (id % side + side), (side * 2) };
                for (int i = 0; i < tmp.Length; ++i)
                {
                    labels[tmp[i]].Text = "-";
                    labels[tmp[i]].ForeColor = Color.Black;
                }
            }
        }

        private void NumChanged(object sender, EventArgs e)
        {
            //変数設定
            int input = 0, id = 0;
            int side_sqrt = side * side;
            try
            {
                input = int.Parse(((TextBox)sender).Text); //TextBoxに入力された数字
                id = int.Parse(((TextBox)sender).Name); //Textboxの名前(＝コントロールID)

            } catch{ /* Do Nothing */ }

            //一辺の数が`2`でないなら、判定(2は、全ての数が同じにならないと魔方陣が成立しない例外の為)
            if (side != 2)
            {
                //入力の範囲チェック
                if (input < 0 || side_sqrt < input)
                {
                    string title = this.Text;
                    this.Text = "範囲外の入力";
                    System.Media.SystemSounds.Exclamation.Play();
                    System.Threading.Thread.Sleep(1000);
                    ((TextBox)sender).Text = "";
                    this.Text = title;
                }

                //縦・横列の合計値の表示処理
                int y = id % side, x = id / side, sum_len = 0, sum_wid = 0;
                for (int i = 0; i < side; i++)
                {
                    if (textboxes[x * side + i].Text != "")
                    {
                        sum_len += int.Parse(textboxes[x * side + i].Text);
                    }
                    if (textboxes[y + i * side].Text != "")
                    {
                        sum_wid += int.Parse(textboxes[y + i * side].Text);
                    }
                }
                if (sum_len == (side * (side_sqrt + 1)) / 2)
                {
                    labels[x].ForeColor = Color.Green;
                }
                else
                {
                    labels[x].ForeColor = Color.Red;
                }
                if (sum_wid == (side * (side_sqrt + 1)) / 2)
                {
                    labels[y + side].ForeColor = Color.Green;
                }
                else
                {
                    labels[y + side].ForeColor = Color.Red;
                }
                labels[x].Text = sum_len.ToString();
                labels[y + side].Text = sum_wid.ToString();

                //斜めの合計値の表示処理
                int sum_slant = 0;
                for (int i = 0; i < side; i++)
                {
                    int temp = (side + 1) * i;
                    if (textboxes[temp].Text != "")
                    {
                        sum_slant += int.Parse(textboxes[temp].Text);
                    }
                }
                if (sum_slant == (side * (side_sqrt + 1)) / 2)
                {
                    labels[side * 2].ForeColor = Color.Green;
                }
                else
                {
                    labels[side * 2].ForeColor = Color.Red;
                }
                labels[side * 2].Text = sum_slant.ToString();
        }

            //クリア判定
            if (!clear)
            {
                clear = true;
                if (side == 2)
                {
                    //2の場合のみ特別
                    //まず、合計して
                    int sum = 0, target = 0;
                    try
                    {
                        target = int.Parse(textboxes[0].Text);
                        for (int i = 0; i < (side * side); ++i)
                        {
                            sum += int.Parse(textboxes[i].Text);
                         }
                    } catch { clear = false; }
                    //全て同じ数でないといけないので、4で割ったらどれか一つと同じになる
                    /* 1 1
                        1 1
                    sum = 4, 4 / 4 = 1 = textboxes[0] */
                    if (sum / 4 != target)
                    {
                        clear = false;
                    }
                }
                else
                {
                    //2以外の場合
                    //各合計値が適正(算出された一列の和と等しい)か判定
                    for (int i = 0; i < (side * 2 + 1); ++i)
                    {
                        try
                        {
                            if (int.Parse(labels[i].Text) != (side * (side_sqrt + 1)) / 2)
                            {
                                clear = false;
                                break;
                            }
                        } catch
                        {
                            clear = false;
                            break;
                        }
                    }
                }

                if (clear)
                {
                    //クリアイベント
                    MessageBox.Show("魔法陣が解かれました。", "クリア", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    contform.timer.Stop();
                    contform.btn_DeleteAll.Enabled = false;
                    contform.btn_Pause.Enabled = false;
                    nRegist.Show();
                }
            }
        }

        private void PlayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string diagMsg;
            if (!clear)
            {
                diagMsg = "魔方陣を解き終わっていませんが、終了しますか？";
            } else
            {
                diagMsg = "終了します、よろしいですか？";
            }
            DialogResult ret = MessageBox.Show(diagMsg,
                                                                        "確認",
                                                                        MessageBoxButtons.OKCancel,
                                                                        MessageBoxIcon.Question,
                                                                        MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void PlayForm_LocationChanged(object sender, EventArgs e)
        {
            //コントローラウィンドウ位置変更
            contform.Top = this.Top - 85;
            contform.Left = this.Left;
        }
    }
}
