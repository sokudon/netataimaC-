using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace neta
{
    public partial class netaform : Form
    {
        public netaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();

            wc.Encoding = Encoding.UTF8;

            //[["海へ出るつもりじゃなかったし","シャニマス","2021/01/01 0:00","2021-01-12T03:00:00.000Z"],
            //["LIVE Carnival Wish you Happiness！！","デレステ","2021-01-01T06:00:00.000Z","2021-01-11T12:00:00.000Z"]
            //,["なんどでも笑おう","ミリシタ","2021-01-02T06:00:00.000Z","2021-01-09T12:00:00.000Z"],["Raise the FLAG","ミリシタ","2021-01-04T06:00:00.000Z","2021-01-11T12:00:00.000Z"],["高舉旗","ミリシタ","2021-01-04T07:00:00.000Z","2021-01-11T13:00:00.000Z"],
            //["新春来福!!正月ﾗｲﾌﾞ2021","サイドM","2020-12-30T15:00:00.000Z","2021-01-07T04:00:00.000Z"],
            //["第57回ドリームLIVEフェスティバル 新春SP","モバマス","2020-12-31T06:00:00.000Z","2021-01-08T14:00:00.000Z"],
            //["セカイのハッピーニューイヤー！","プロセカ","2020-12-31T06:00:00.000Z","2020-12-31T06:00:00.000Z"]]

            string url = "https://script.google.com/macros/s/AKfycbyQmmF6EGgRvfAfF8thzVnMNCRlJfh1dbYs_plQJ_9WwqzI4QR4lAjf/exec";

            //string proseka = "https://script.google.com/macros/s/AKfycbyQcx1oVrb6npnIptpeUpnk5NyZpljcnex9IHxboBGeMBw6qvu8/exec";
            //string miri = "https://script.google.com/macros/s/AKfycbyZbP4x6lww_pAMHd4bajB9MvCh3kY_H__E_0AKk9CBkCPJa-dK/exec";
            //string dere = "https://script.google.com/macros/s/AKfycbxxrM9jrW0bZAqDaJnlDxXeN76UOoKesi2XV9Ejw-a6Ncy_5K28sO_Row/exec";
            //string[] usedt ={proseka, miri, dere};

            
            var selecter = comboBox1.SelectedIndex;

            try
            {
                string text = wc.DownloadString(url); 
                var obj = Codeplex.Data.DynamicJson.Parse(text);



                ibemei.Text = obj[selecter][0];
                startbox.Text = obj[selecter][2];
                endbox.Text = obj[selecter][3];


            }
            catch (WebException exc)
            {
                endbox.Text = exc.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.startbox.Text = Properties.Settings.Default.st;
            this.endbox.Text = Properties.Settings.Default.en;
            this.ibemei.Text = Properties.Settings.Default.ibe;
            this.comboBox1.Text = Properties.Settings.Default.goog;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.st = this.startbox.Text;
            Properties.Settings.Default.en = this.endbox.Text;
            Properties.Settings.Default.ibe = this.ibemei.Text;
            Properties.Settings.Default.goog = this.comboBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            eventname.Text = ibemei.Text;
            DateTime dt = DateTime.Now;
            current.Text = "現在時間:" + dt.ToString();

            DateTime st;//= DateTime.Parse(startbox.Text);
            DateTime en;//= DateTime.Parse(endbox.Text);
            string format = "yyyy/MM/dd HH:mm:ss";

            if (DateTime.TryParse(startbox.Text, out st))
            {

            }
            else {

                start.Text =  "invalid date(ex: 2020/12/18 21:00 or 2020-12-18T21:00:00+09:00)";
                elapsed.Text = "--";
                left.Text = "--";
                duration.Text = "--";

                return;
            }
            if (DateTime.TryParse(endbox.Text, out en))
            {

            }
            else {

                end.Text = "invalid date(ex: 2020/12/18 21:00 or 2020-12-18T21:00:00+09:00)";
                elapsed.Text = "--";

                left.Text = "--";
                duration.Text = "--";

                return;
            }


            start.Text ="開始時間:" + st.ToString(format);
            end.Text = "終了時間:"+en.ToString(format);

            TimeSpan elapsedSpan = dt - st;

            string dd = elapsedSpan.Days.ToString();
            string hh = elapsedSpan.Hours.ToString();
            string mm = elapsedSpan.Minutes.ToString();
            string ss = elapsedSpan.Seconds.ToString();
            if (st < dt)
            {
                elapsed.Text = "経過時間:"+dd + "日" + hh + "時間" +
                mm + "分" + ss + "秒";
            }
            else
            {

                elapsed.Text = "開始されてません";
            }

            TimeSpan leftSpan = en - dt;

            dd = leftSpan.Days.ToString();
            hh = leftSpan.Hours.ToString();
            mm = leftSpan.Minutes.ToString();
            ss = leftSpan.Seconds.ToString();

            if (en > dt)
            {
                left.Text = "残り時間:" + dd + "日" + hh + "時間" +
                     mm + "分" + ss + "秒";
            }
            else
            {
                left.Text = "終了しています";
            }

            TimeSpan drationSpan = en - st;

            dd = drationSpan.Days.ToString();
            hh = drationSpan.Hours.ToString();
            mm = drationSpan.TotalHours.ToString();

            duration.Text = "イベ期間:"+dd + "日" + hh + "時間," + mm + "時間";

            double bar = (dt-st).TotalSeconds/(en-st).TotalSeconds *100;
            bar = Math.Round(bar, 2, MidpointRounding.AwayFromZero);
            if (bar > 100) {
                bar = 100;
            }
            if (bar <0)
            {
                bar = 0;
            }
            label1.Text = bar + "%";
            bar = Math.Floor(bar);
            progressBar1.Value = Convert.ToInt32(bar.ToString());

        }

        private void current_Click(object sender, EventArgs e)
        {

        }

        private void end_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path = @"data.ics";

            try
            {
                // Create the file, or overwrite if the file exists.
                using (FileStream fs = File.Create(path))
                {
                    string tmp =Properties.Resources.ical;
                    string ibemie = ibemei.Text;

                    DateTime st;//= DateTime.Parse(startbox.Text);
                    DateTime en;//= DateTime.Parse(endbox.Text);
                    string format = "yyyyMMdd'T'HHmmssZ";

                    string sst = "";
                    string sen = "";
                    if (DateTime.TryParse(startbox.Text, out st))
                    {
                        sst =st.ToUniversalTime().ToString(format);
                    }
                    if (DateTime.TryParse(endbox.Text, out en))
                    {
                        sen = en.ToUniversalTime().ToString(format);
                    }
                    string game = "[" + comboBox1.Text + "]";

                    //= Regex.Replace("{置換対象文字列}", "{正規表現パターン}", "{置換パターン}");
                    tmp = Regex.Replace(tmp, "SUMMARY:うづき", "SUMMARY:" + game + ibemie);
                    tmp = Regex.Replace(tmp, "20200423T150000Z", sst);
                    tmp = Regex.Replace(tmp, "20200424T150000Z", sen);
                    tmp = Regex.Replace(tmp, "\\\\r\\\\n", "\r\n");

                    byte[] info = new UTF8Encoding(true).GetBytes(tmp);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }

                //カレンダー起動
                var proc = new System.Diagnostics.Process();

                proc.StartInfo.FileName =path;
                proc.StartInfo.UseShellExecute = true;
                proc.Start();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
    
