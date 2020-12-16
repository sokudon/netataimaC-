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
            this.current = new System.Windows.Forms.Label();
            this.startbox = new System.Windows.Forms.TextBox();
            this.endbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.elapsed = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.duration = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ibemei = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eventname = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Location = new System.Drawing.Point(3, 45);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(53, 12);
            this.current.TabIndex = 0;
            this.current.Text = "現在時間";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "情報反映";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // elapsed
            // 
            this.elapsed.AutoSize = true;
            this.elapsed.Location = new System.Drawing.Point(3, 69);
            this.elapsed.Name = "elapsed";
            this.elapsed.Size = new System.Drawing.Size(53, 12);
            this.elapsed.TabIndex = 4;
            this.elapsed.Text = "経過時間";
            // 
            // left
            // 
            this.left.AutoSize = true;
            this.left.Location = new System.Drawing.Point(3, 91);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(49, 12);
            this.left.TabIndex = 5;
            this.left.Text = "残り時間";
            // 
            // panel1
            // 
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
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(6, 112);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(29, 12);
            this.duration.TabIndex = 6;
            this.duration.Text = "期間";
            this.duration.Click += new System.EventHandler(this.duration_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(3, 136);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(53, 12);
            this.start.TabIndex = 7;
            this.start.Text = "開始時間";
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(3, 157);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(53, 12);
            this.end.TabIndex = 8;
            this.end.Text = "終了時間";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 53);
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
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(27, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 100);
            this.panel2.TabIndex = 9;
            // 
            // eventname
            // 
            this.eventname.AutoSize = true;
            this.eventname.Location = new System.Drawing.Point(4, 16);
            this.eventname.Name = "eventname";
            this.eventname.Size = new System.Drawing.Size(20, 12);
            this.eventname.TabIndex = 9;
            this.eventname.Text = "ibe";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "プロセカ",
            "ミリシタ",
            "でれすて"});
            this.comboBox1.Location = new System.Drawing.Point(327, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "プロセカ";
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
        private System.Windows.Forms.Button button1;
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
    }
}

