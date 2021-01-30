namespace neta
{
    partial class dtformat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "経過/残り:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 208);
            this.panel1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox2.Location = new System.Drawing.Point(23, 158);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(267, 20);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 136);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(191, 16);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "M$のタイムゾーン(夏時間修正あり)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox1.Items.AddRange(new object[] {
            "(GMT-12:00)国際日付変更線西側 日付変更線標準時,M$0",
            "(GMT-11:00)ミッドウェー島、サモア サモア標準時,M$1",
            "(GMT-10:00)ハワイ ハワイ標準時,M$2",
            "(GMT-09:00)アラスカ アラスカ標準時,M$3",
            "(GMT-08:00)(米国およびカナダ) は、太平洋標準時ティファナ 太平洋標準時,M$4",
            "(GMT-07:00)(米国およびカナダ)、山地標準時 山地標準時,M$A",
            "(GMT-07:00)チワワ、ラパス、マサトラン メキシコ標準時 2,M$D",
            "(GMT-07:00)アリゾナ州 米国山地標準時,M$F",
            "(GMT-06:00)(米国およびカナダ) の中部標準時 中部標準時,M$14",
            "(GMT-06:00)サスカチェワン カナダ中部標準時,M$19",
            "(GMT-06:00)グアダラハラ、メキシコシティ、モンテレイ メキシコ山地標準時,M$1E",
            "(GMT-06:00)中央アメリカ 中央アメリカ標準時,M$21",
            "(GMT-05:00)(米国およびカナダ)、東部標準時 東部標準時,M$23",
            "(GMT-05:00)インディアナ (東部) 米国東部標準時,M$28",
            "(GMT-05:00)ボゴタ、リマ、Quito 亜北極地帯の太平洋標準時,M$2D",
            "(GMT-04:00)大西洋標準時 (カナダ) 大西洋標準時,M$32",
            "(GMT-04:00)ジョージタウン、ラパス、サン ・ ファン 亜北極地帯西部標準時,M$37",
            "(GMT-04:00)サンティアゴ 太平洋亜北極地帯 (標準時),M$38",
            "(GMT-03:30)ニューファンドランド ニューファンドランドおよびラブラドル標準時,M$3C",
            "(GMT-03:00)ブラジリア 南アメリカ東部標準時,M$41",
            "(GMT-03:00)ジョージタウン 亜北極地帯東部標準時,M$46",
            "(GMT-03:00)グリーンランド グリーンランド標準時,M$49",
            "(GMT-02:00)中部大西洋 中央大西洋標準時,M$4B",
            "(GMT-01:00)アゾレス諸島 アゾレス諸島標準時,M$50",
            "(GMT-01:00)カーボベルデ諸島 カーボベルデ標準時,M$53",
            "(GMT+00:00)グリニッジ標準時: ダブリン、エジンバラ、リスボン、ロンドン GMT 標準時,M$55",
            "(GMT+00:00)モンロビア、レイキャビク グリニッジ標準時,M$5A",
            "(GMT+01:00)サニーベイル, カリフォルニア州、ブラチスラバ、ブダペスト、Ljubljana、プラハ 中央ヨーロッパ標準時,M$5F",
            "(GMT+01:00)サラエボ、Skopje、ワルシャワ、Zagreb 中央ヨーロッパ標準時,M$64",
            "(GMT+01:00)ブリュッセル、コペンハーゲン、マドリッド、パリ ロマンス標準時,M$69",
            "(GMT+01:00)アムステルダム、ベルリン、ベルン、ローマ、ストックホルム、ウィーン 西ヨーロッパ標準時,M$6E",
            "(GMT+01:00)西中央アフリカ 西中央アフリカ標準時,M$71",
            "(GMT+02:00)ミンスク 東ヨーロッパ標準時,M$73",
            "(GMT+02:00)カイロ エジプト標準時,M$78",
            "(GMT+02:00)ヘルシンキ、キエフ、リガ、ソフィア、Tallinn、Vilnius ファイル (標準時),M$7D",
            "(GMT+02:00)アテネ、ブカレスト、イスタンブール GTB 標準時,M$82",
            "(GMT+02:00)エルサレム イスラエル標準時,M$87",
            "(GMT+02:00)ハラレ、プレトリア 南アフリカ標準時,M$8C",
            "(GMT+03:00)モスクワ、サンクト ペテルスブルグ、ボルゴグラード ロシア標準時,M$91",
            "(GMT+03:00)クウェート、リヤド アラブ標準時,M$96",
            "(GMT+03:00)ナイロビ 東アフリカ標準時,M$9B",
            "(GMT+03:00)バグダッド アラブ標準時,M$9E",
            "(GMT+03:30)テヘラン イラン標準時,M$A0",
            "(GMT+04:00)アブダビ、マスカット アラビア標準時,M$A5",
            "(GMT+04:00)バクー、トビリシ、エレバン コーカサス標準時,M$AA",
            "(GMT+04:30)カブール 移行アフガニスタン標準時,M$AF",
            "(GMT+05:00)エカテリンバーグ エカテリンバーグ標準時,M$B4",
            "(GMT+05:00)タシケント 西アジア標準時,M$B9",
            "(GMT+05:30)チェンナイ、カルカッタ、ムンバイ、ニューデリー インド標準時,M$BE",
            "(GMT+05:45)カトマンズ ネパール標準時,M$C1",
            "(GMT+06:00)アスタナ、ダッカ 中央アジア標準時,M$C3",
            "(GMT+06:00)スリジャヤワルダナプラコッテ スリランカ標準時,M$C8",
            "(GMT+06:00)アルマアトイ、ノボシビルスク 北中央アジア標準時,M$C9",
            "(GMT+06:30)ヤンゴン (ラングーン) ミャンマー標準時,M$CB",
            "(GMT+07:00)バンコク、ハノイ、ジャカルタ 東南アジア標準時,M$CD",
            "(GMT+07:00)クラスノヤルスク 北アジア標準時,M$CF",
            "(GMT+08:00)北京、重慶、ホンコン、ウルムチ 中国 (標準時),M$D2",
            "(GMT+08:00)クアラルンプール、シンガポール シンガポール標準時,M$D7",
            "(GMT+08:00)台北 台北標準時,M$DC",
            "(GMT+08:00)パース 西オーストラリア標準時,M$E1",
            "(GMT+08:00)イルクーツク、ウランバートル 北アジア東部標準時,M$E3",
            "(GMT+09:00)(ソウル) 韓国 (標準時),M$E6",
            "(GMT+09:00)大阪、札幌、東京 東京 (標準時),M$EB",
            "(GMT+09:00)ヤクーツク ヤクーツク標準時,M$F0",
            "(GMT+09:30)ダーウィン オーストラリア中央標準時,M$F5",
            "(GMT+09:30)アデレード 中央オーストラリア標準時,M$FA",
            "(GMT+10:00)キャンベラ、メルボルン、シドニー オーストラリア東部標準時,M$FF",
            "(GMT+10:00)ブリスベン 東オーストラリア標準時,M$104",
            "(GMT+10:00)ホバート タスマニア標準時,M$109",
            "(GMT+10:00)ウラジオ ストック ウラジオ ストック標準時,M$10E",
            "(GMT+10:00)グアム、ポートモレスビー 西太平洋標準時,M$113",
            "(GMT+11:00)マガダン、ソロモン諸島、ニューカレドニア 中央太平洋標準時,M$118",
            "(GMT+12:00)フィジー、カムチャツカ、マーシャル フィジー諸島標準時,M$11D",
            "(GMT+12:00)オークランド、ウェリントン ニュージーランド標準時,M$122",
            "(GMT+13:00)ヌクアロファ トンガ標準時,M$12C",
            "(GMT-03:00)ブエノスアイレス アゼルバイジャン標準時,M$80000040",
            "(GMT+02:00)コロンバス, ジョージア州 中東標準時,M$80000041",
            "(GMT+02:00)Amman ヨルダン標準時,M$80000042",
            "(GMT-06:00)グアダラハラ、メキシコシティ、モンテレー - 新規 中部標準時 (メキシコ),M$80000043",
            "(GMT-07:00)チワワ、ラパス、マサトラン - 新規 山地標準時 (メキシコ),M$80000044",
            "(GMT-08:00)ティファナ、バハカリフォルニア 太平洋標準時 (メキシコ),M$80000045",
            "(GMT+02:00)Windhoek ナミビア標準時,M$80000046",
            "(GMT+03:00)トビリシ グルジア標準時,M$80000047",
            "(GMT-04:00)Manaus 中央ブラジル標準時,M$80000048",
            "(GMT-03:00)モンテビデオ モンテビデオ標準時,M$80000049",
            "(GMT+04:00)エレバン アルメニア標準時,M$8000004A",
            "(GMT-04:30)カラカス ベネズエラ標準時,M$8000004B",
            "(GMT-03:00)ブエノスアイレス アルゼンチン標準時,M$8000004C",
            "(GMT+00:00)カサブランカ モロッコ標準時,M$8000004D",
            "(GMT+05:00)イスラマバード、カラチ パキスタン標準時,M$8000004E",
            "(GMT+04:00)ポートルイス モーリシャス標準時,M$8000004F",
            "(GMT+00:00)世界協定時刻 UTC,M$80000050",
            "(GMT-04:00)Asuncion パラグアイ標準時,M$80000051",
            "(GMT+12:00)Petropavlovsk Kamchatsky カムチャツカ標準時,M$80000052"});
            this.comboBox1.Location = new System.Drawing.Point(23, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(210, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "UTC任意時間を使う(夏時間修正なし)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 19);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "現在時刻:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtformat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 247);
            this.Controls.Add(this.panel1);
            this.Name = "dtformat";
            this.Text = "datetimeformat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dtformat_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}