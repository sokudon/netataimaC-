using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Net;

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

            string proseka = "https://script.google.com/macros/s/AKfycbyQcx1oVrb6npnIptpeUpnk5NyZpljcnex9IHxboBGeMBw6qvu8/exec";
            string miri = "https://script.google.com/macros/s/AKfycbyZbP4x6lww_pAMHd4bajB9MvCh3kY_H__E_0AKk9CBkCPJa-dK/exec";
            string dere = "https://script.google.com/macros/s/AKfycbxxrM9jrW0bZAqDaJnlDxXeN76UOoKesi2XV9Ejw-a6Ncy_5K28sO_Row/exec";

            string[] usedt ={proseka, miri, dere};

            proseka = usedt[comboBox1.SelectedIndex];


            try
            {
                string text = wc.DownloadString(proseka);
                string str = "[0-9]{4}.*?Z";
                MatchCollection m = Regex.Matches(text, str);
                int i = 0;
                string[] ms= {"Invalid date","Invalid date"};

                foreach (Match mm in m)
                {
                    ms[i] = mm.Value;
                    i++;
                    if (i > 2) {
                        break;
                    }
                }
                str = "ibemie.+";
                Match mi = Regex.Match(text, str);
                string ibe = "event name";
                if (mi.Success)
                {
                    ibe = mi.Value.Replace("ibemie=\"","").Replace("\";", "");
                }

                ibemei.Text = ibe;
                startbox.Text = ms[0];
                endbox.Text = ms[1];


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
            current.Text = dt.ToString();

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


            start.Text = st.ToString(format);
            end.Text = en.ToString(format);

            TimeSpan elapsedSpan = dt - st;

            string dd = elapsedSpan.Days.ToString();
            string hh = elapsedSpan.Hours.ToString();
            string mm = elapsedSpan.Minutes.ToString();
            string ss = elapsedSpan.Seconds.ToString();
            if (st < dt)
            {
                elapsed.Text = dd + "日" + hh + "時間" +
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
                left.Text = dd + "日" + hh + "時間" +
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

            duration.Text = dd + "日" + hh + "時間," + mm + "時間";

            double bar = (dt-st).TotalSeconds/(en-st).TotalSeconds *100;
            bar = Math.Round(bar, 2, MidpointRounding.AwayFromZero);
            if (bar > 100) {
                bar = 100;
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
    }
}
    
