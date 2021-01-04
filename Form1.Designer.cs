namespace neta
{
    partial class netaform
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.current = new System.Windows.Forms.Label();
            this.startbox = new System.Windows.Forms.TextBox();
            this.endbox = new System.Windows.Forms.TextBox();
            this.elapsed = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.eventname = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ibemei = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Location = new System.Drawing.Point(3, 38);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(55, 12);
            this.current.TabIndex = 0;
            this.current.Text = "現在時間:";
            this.current.Click += new System.EventHandler(this.current_Click);
            // 
            // startbox
            // 
            this.startbox.Location = new System.Drawing.Point(12, 37);
            this.startbox.Name = "startbox";
            this.startbox.Size = new System.Drawing.Size(212, 19);
            this.startbox.TabIndex = 1;
            this.startbox.Text = "2020-12-16T06:00:00Z";
            // 
            // endbox
            // 
            this.endbox.Location = new System.Drawing.Point(12, 62);
            this.endbox.Name = "endbox";
            this.endbox.Size = new System.Drawing.Size(213, 19);
            this.endbox.TabIndex = 2;
            this.endbox.Text = "2020/12/17 21:00";
            // 
            // elapsed
            // 
            this.elapsed.AutoSize = true;
            this.elapsed.Location = new System.Drawing.Point(4, 60);
            this.elapsed.Name = "elapsed";
            this.elapsed.Size = new System.Drawing.Size(55, 12);
            this.elapsed.TabIndex = 4;
            this.elapsed.Text = "経過時間:";
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.Location = new System.Drawing.Point(4, 82);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(51, 12);
            this.left.TabIndex = 5;
            this.left.Text = "残り時間:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.eventname);
            this.panel1.Controls.Add(this.end);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.duration);
            this.panel1.Controls.Add(this.current);
            this.panel1.Controls.Add(this.left);
            this.panel1.Controls.Add(this.elapsed);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 190);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 166);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(378, 21);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 90;
            // 
            // eventname
            // 
            this.eventname.AutoSize = true;
            this.eventname.Location = new System.Drawing.Point(4, 16);
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(55, 12);
            this.eventname.TabIndex = 9;
            this.eventname.Text = "イベント名:";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(4, 151);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(55, 12);
            this.end.TabIndex = 8;
            this.end.Text = "終了時間:";
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(4, 127);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(53, 12);
            this.start.TabIndex = 7;
            this.start.Text = "開始時間";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(4, 104);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(50, 12);
            this.duration.TabIndex = 6;
            this.duration.Text = "イベ期間:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "ぐぐるから取得";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ibemei
            // 
            this.ibemei.Location = new System.Drawing.Point(11, 14);
            this.ibemei.Name = "ibemei";
            this.ibemei.Size = new System.Drawing.Size(213, 19);
            this.ibemei.TabIndex = 8;
            this.ibemei.Text = "ibemei";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.ibemei);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.startbox);
            this.panel2.Controls.Add(this.endbox);
            this.panel2.Location = new System.Drawing.Point(27, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 100);
            this.panel2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "シャニマス",
            "でれすて",
            "みりした",
            "みりした韓国",
            "みりした中華",
            "サイドＭ",
            "モバマス",
            "プロセカ"});
            this.comboBox1.Location = new System.Drawing.Point(269, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "プロセカ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // netaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 311);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "netaform";
            this.Text = "netaform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label current;
        private System.Windows.Forms.TextBox startbox;
        private System.Windows.Forms.TextBox endbox;
        private System.Windows.Forms.Label elapsed;
        private System.Windows.Forms.Label left;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ibemei;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label eventname;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}

