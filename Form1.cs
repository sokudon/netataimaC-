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



            DateTime dt = DateTime.Now;
            current.Text = dt.ToString();

            DateTime st = DateTime.Parse(startbox.Text);
            DateTime en = DateTime.Parse(endbox.Text);


            string format = "yyyy/MM/dd HH:mm:ss";

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
            else {

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
            else {
                left.Text = "終了しています";
            }

        TimeSpan drationSpan = en - st;

        dd = drationSpan.Days.ToString();
                    hh = drationSpan.Hours.ToString();
                    mm = drationSpan.TotalHours.ToString();

            duration.Text = dd + "日" + hh + "時間,"　+mm + "時間";

            eventname.Text = ibemei.Text;
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

        private void duration_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {

        }
    }
}
    
