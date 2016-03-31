using System;
using System.Windows.Forms;

namespace Magic_square
{
    public partial class Controler : Form
    {
        public int tick = 0;
        public Timer timer;
        public PlayForm playform;
        public Start setform;

        public Controler()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;　//枠線を選択できないようにする(＝大きさ固定)

            // タイマー生成
            timer = new Timer();
            timer.Tick += new EventHandler(this.OnTick_Timer); //イベント設定
            timer.Interval = 1; //間隔設定
            timer.Start(); // タイマーを開始            
        }

        public void OnTick_Timer(object sender, EventArgs e)
        {
            ++tick;
            TimeSpan ts = new TimeSpan(0, 0, 0, tick * 6 / 7);
            lab_CntDown.Text = ts.ToString();
        }

        private void Controler_Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_DeleteAll_Click(object sender, EventArgs e) { playform.DeleteAll(); }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            timer.Stop();
            playform.Hide();
            this.Hide();
            setform.Show();
            setform.btn_continue.Enabled = true;
        }
    }
}
