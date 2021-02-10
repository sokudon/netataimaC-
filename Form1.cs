using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace neta
{
    public partial class NETA_TIMER : Form
    {
        public NETA_TIMER()
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

     
            
            var selecter = comboBox1.SelectedIndex;

            try
            {
                string text = wc.DownloadString(url); 
                var obj = Codeplex.Data.DynamicJson.Parse(text);



                ibemei.Text = obj[selecter][0];
                startbox.Text = obj[selecter][2];
                endbox.Text = obj[selecter][3];


                Properties.Settings.Default.json = text;

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
            this.progressBar1.Width = Properties.Settings.Default.barlen;
            this.parcent.Left = Properties.Settings.Default.parcent;
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

            bool utc = Properties.Settings.Default.useutc;
            bool ms = Properties.Settings.Default.usems;
            string format = Properties.Settings.Default.datetimeformat;//"yyyy/MM/dd HH:mm:ss'(GMT'zzz')'";
            eventname.Text = ibemei.Text;
            DateTime dt = DateTime.Now;
          

            DateTime st;//= DateTime.Parse(startbox.Text);
            DateTime en;//= DateTime.Parse(endbox.Text);

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
            if (utc)
            {
                string rp = Properties.Settings.Default.useutch + ":" + Properties.Settings.Default.useutcm;
                format = format.Replace("K",rp).Replace("zzz", rp).Replace("zz", Properties.Settings.Default.useutch).Replace("z", Properties.Settings.Default.useutch);
                current.Text = "現在時間:" + dt.ToUniversalTime().AddHours(Properties.Settings.Default.useutcint).ToString(format);
                start.Text = "開始時間:" + st.ToUniversalTime().AddHours(Properties.Settings.Default.useutcint).ToString(format);
                end.Text = "終了時間:" + en.ToUniversalTime().AddHours(Properties.Settings.Default.useutcint).ToString(format);

            }
            else if (ms) {

                TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById(Properties.Settings.Default.mstime);

                DateTimeOffset ddt = DateTime.SpecifyKind(dt, DateTimeKind.Local);
                DateTimeOffset sst = DateTime.SpecifyKind(st, DateTimeKind.Local);
                DateTimeOffset een = DateTime.SpecifyKind(en, DateTimeKind.Local);

                string formatd = getoffset(ddt, format,tzi);
                string formats = getoffset(sst, format, tzi);
                string formate = getoffset(een, format, tzi);


                current.Text = "現在時間:" + TimeZoneInfo.ConvertTime(ddt, tzi).ToString(formatd);
                start.Text = "開始時間:" + TimeZoneInfo.ConvertTime(sst, tzi).ToString(formats);
                end.Text = "終了時間:" + TimeZoneInfo.ConvertTime(een, tzi).ToString(formate);


            }
            else
            {
                current.Text = "現在時間:" + dt.ToString(format);
                start.Text = "開始時間:" + st.ToString(format);
                end.Text = "終了時間:" + en.ToString(format);
            }




            if (st < dt)
            {
                TimeSpan elapsedSpan = dt - st;
                elapsed.Text = "経過時間:"+ getleft(elapsedSpan);
            }
            else
            {

                elapsed.Text = "イベントがまだ開始されてません";
            }


            if (en > dt)
            {
                TimeSpan leftSpan = en - dt;
                left.Text = "残り時間:" + getleft(leftSpan);
            }
            else
            {
                left.Text = "イベントはすでに終了しています";
            }

            TimeSpan drationSpan = en - st;

            duration.Text = "イベ期間:"+ getleft(drationSpan);

            double bar = (dt-st).TotalSeconds/(en-st).TotalSeconds *100;
            bar = Math.Round(bar, 2, MidpointRounding.AwayFromZero);
            if (bar > 100) {
                bar = 100;
            }
            if (bar <0)
            {
                bar = 0;
            }
            parcent.Text = bar + "%";
            bar = Math.Floor(bar);
            progressBar1.Value = Convert.ToInt32(bar.ToString());

        }

        private string getoffset(DateTimeOffset dt,string format,TimeZoneInfo tz)
        {
            var o1 = tz.GetUtcOffset(dt);
            string st = o1.ToString();

            string rp = Regex.Replace("+" + st, ":\\d\\d$", "");
            string rp2 = Regex.Replace("+" + st, ":\\d\\d:\\d\\d$", "");
            rp = Regex.Replace(rp, "\\+\\-", "-");
            rp2 = Regex.Replace(rp2, "\\+\\-", "-");

            string tmp = tz.StandardName;

            var DST  =tz.IsDaylightSavingTime(dt);
            if (DST) {
                tmp = tz.DaylightName;
            }

            format = format.Replace("zzz", rp).Replace("zz", rp2).Replace("z", rp2).Replace("K", tmp);


            return format;
        }

        private string getleft(TimeSpan tspan)
        {
            string leftformat = Properties.Settings.Default.lefttimeformat;

            string dd = tspan.Days.ToString();
            string hh = tspan.Hours.ToString("00");
            string mm = tspan.Minutes.ToString("00");
            string ss = tspan.Seconds.ToString("00");

            string h = tspan.Hours.ToString("0");
            string m = tspan.Minutes.ToString("0");
            string s = tspan.Seconds.ToString("0");

            string ds = tspan.TotalDays.ToString("0.000");
            string hs = tspan.TotalHours.ToString("0.000");

            string MM= tspan.TotalDays.ToString("#");
            string HH = tspan.TotalHours.ToString("#");

            string[] rp = { HH, MM, ds, hs, dd, hh, mm, ss, h, m, s };
            string[] rpb = { "HH", "MM", "ds", "hs", "dd", "hh", "mm", "ss", "h", "m", "s" };

            string left = leftformat;
            for (var i = 0; i < rp.Length; i++) {
                left = left.Replace(rpb[i], rp[i]);
            }

            return left;
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

        private void 時刻設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = new dtformat(this);
            form2.ShowDialog(this);
            form2.Dispose();
        }

        private void バージョンToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form2 = new VER();
            form2.ShowDialog();
            form2.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selecter = comboBox1.SelectedIndex;

            try
            {
                if (Properties.Settings.Default.json != "") { 
                var obj = Codeplex.Data.DynamicJson.Parse(Properties.Settings.Default.json);



                ibemei.Text = obj[selecter][0];
                startbox.Text = obj[selecter][2];
                endbox.Text = obj[selecter][3];
            }

            }
            catch (WebException exc)
            {
                endbox.Text = exc.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            DateTime dt = DateTime.Now;

            string url = Properties.Settings.Default.api.ToString().Replace("TODAY()",dt.ToString("yyyy-MM-dd"));
            string parseop = Properties.Settings.Default.parse;
            string text = "";
            var erros = "";
            try
            {
                text = wc.DownloadString(url);
            }
            catch (WebException exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }

            try
            {
                var obj = Codeplex.Data.DynamicJson.Parse(text);
                var objorig = obj;
                string[] op = parseop.Split(',');
                string[] get = { "", "", "" };
                if (text == "[]" || text == "{}")
                {
                    MessageBox.Show("JSONがから[] {}です,apiurlを確認してください（）");
                    return;
                }
                else
                {
                    for (var k = 0; k < op.Length; k++)
                    {
                        obj = objorig;
                        string[] path = op[k].Split('/');
                        erros = op[k];
                        for (var i = 1; i < path.Length;)
                        {
                            if (obj.IsArray)
                            {
                                if (obj.IsDefined(0)==false)
                                {
                                    break;
                                }
                                obj = obj[0];
                            }
                            else if (obj.IsObject)
                            {
                                obj = obj[path[i]];
                                i++;
                            }
                            if (i == path.Length - 1)
                            {
                                if (obj.IsObject)
                                {
                                    get[k] = obj[path[i]];
                                    break;
                                }
                            }
                        }
                    }

                    ibemei.Text = get[0];
                    startbox.Text = get[1];
                    endbox.Text = get[2];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " エラー場所:'"+ erros +"'");
            }
        }
    }
}
    
