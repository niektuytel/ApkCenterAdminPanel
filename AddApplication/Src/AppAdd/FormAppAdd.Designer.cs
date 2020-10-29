namespace AddApplication.Src.AllForms
{
    partial class FormAppAdd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_icon = new System.Windows.Forms.GroupBox();
            this.txtIconUrl = new System.Windows.Forms.TextBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtWebsiteUrl = new System.Windows.Forms.TextBox();
            this.txtApkUrl = new System.Windows.Forms.TextBox();
            this.txtImageUrl1 = new System.Windows.Forms.TextBox();
            this.groupBox_images = new System.Windows.Forms.GroupBox();
            this.txtImageUrl6 = new System.Windows.Forms.TextBox();
            this.txtImageUrl2 = new System.Windows.Forms.TextBox();
            this.txtImageUrl3 = new System.Windows.Forms.TextBox();
            this.txtImageUrl5 = new System.Windows.Forms.TextBox();
            this.txtImageUrl4 = new System.Windows.Forms.TextBox();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAbout = new System.Windows.Forms.TextBox();
            this.cbbAboutCountry = new System.Windows.Forms.ComboBox();
            this.groupBox_reviews = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReviewStar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReviewTotal = new System.Windows.Forms.TextBox();
            this.txtDownloadsTotal = new System.Windows.Forms.TextBox();
            this.groupBox_downloads = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_pegi = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbPegi = new System.Windows.Forms.ComboBox();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.groupBox_apk = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApkVersion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbLimitCount = new System.Windows.Forms.ComboBox();
            this.label_finished = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.panel_all = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_apk2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cLstPopular = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cLstTypesApi = new System.Windows.Forms.CheckedListBox();
            this.cbFormSettings = new System.Windows.Forms.CheckBox();
            this.cbFormPhone = new System.Windows.Forms.CheckBox();
            this.panel_apk = new System.Windows.Forms.Panel();
            this.groupBox_icon.SuspendLayout();
            this.groupBox_images.SuspendLayout();
            this.groupBox_info.SuspendLayout();
            this.groupBox_reviews.SuspendLayout();
            this.groupBox_downloads.SuspendLayout();
            this.groupBox_pegi.SuspendLayout();
            this.groupBox_apk.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_all.SuspendLayout();
            this.panel_apk2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_apk.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_icon
            // 
            this.groupBox_icon.Controls.Add(this.txtIconUrl);
            this.groupBox_icon.Location = new System.Drawing.Point(3, 3);
            this.groupBox_icon.Name = "groupBox_icon";
            this.groupBox_icon.Size = new System.Drawing.Size(430, 45);
            this.groupBox_icon.TabIndex = 4;
            this.groupBox_icon.TabStop = false;
            this.groupBox_icon.Text = "icon url*";
            // 
            // txtIconUrl
            // 
            this.txtIconUrl.Location = new System.Drawing.Point(4, 16);
            this.txtIconUrl.Name = "txtIconUrl";
            this.txtIconUrl.Size = new System.Drawing.Size(417, 23);
            this.txtIconUrl.TabIndex = 0;
            this.txtIconUrl.TextChanged += new System.EventHandler(this.IconUrl_EditText);
            // 
            // cbbCategory
            // 
            this.cbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(74, 92);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(356, 23);
            this.cbbCategory.TabIndex = 3;
            this.cbbCategory.TextChanged += new System.EventHandler(this.Category_ComboBox);
            // 
            // txtTitle
            // 
            this.txtTitle.AccessibleName = "title";
            this.txtTitle.Location = new System.Drawing.Point(74, 64);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(356, 23);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.Title_EditText);
            // 
            // txtWebsiteUrl
            // 
            this.txtWebsiteUrl.Location = new System.Drawing.Point(74, 37);
            this.txtWebsiteUrl.Name = "txtWebsiteUrl";
            this.txtWebsiteUrl.Size = new System.Drawing.Size(605, 23);
            this.txtWebsiteUrl.TabIndex = 1;
            this.txtWebsiteUrl.TextChanged += new System.EventHandler(this.WebsiteUrl_EditText);
            // 
            // txtApkUrl
            // 
            this.txtApkUrl.Location = new System.Drawing.Point(74, 8);
            this.txtApkUrl.Name = "txtApkUrl";
            this.txtApkUrl.Size = new System.Drawing.Size(605, 23);
            this.txtApkUrl.TabIndex = 1;
            this.txtApkUrl.TextChanged += new System.EventHandler(this.ApkUrl_EditText);
            // 
            // txtImageUrl1
            // 
            this.txtImageUrl1.Location = new System.Drawing.Point(4, 22);
            this.txtImageUrl1.Name = "txtImageUrl1";
            this.txtImageUrl1.Size = new System.Drawing.Size(417, 23);
            this.txtImageUrl1.TabIndex = 0;
            this.txtImageUrl1.TextChanged += new System.EventHandler(this.Images_EditText);
            // 
            // groupBox_images
            // 
            this.groupBox_images.Controls.Add(this.txtImageUrl6);
            this.groupBox_images.Controls.Add(this.txtImageUrl2);
            this.groupBox_images.Controls.Add(this.txtImageUrl3);
            this.groupBox_images.Controls.Add(this.txtImageUrl5);
            this.groupBox_images.Controls.Add(this.txtImageUrl4);
            this.groupBox_images.Controls.Add(this.txtImageUrl1);
            this.groupBox_images.Location = new System.Drawing.Point(3, 54);
            this.groupBox_images.Name = "groupBox_images";
            this.groupBox_images.Size = new System.Drawing.Size(430, 193);
            this.groupBox_images.TabIndex = 4;
            this.groupBox_images.TabStop = false;
            this.groupBox_images.Text = "image urls";
            // 
            // txtImageUrl6
            // 
            this.txtImageUrl6.Location = new System.Drawing.Point(4, 167);
            this.txtImageUrl6.Name = "txtImageUrl6";
            this.txtImageUrl6.Size = new System.Drawing.Size(417, 23);
            this.txtImageUrl6.TabIndex = 0;
            this.txtImageUrl6.TextChanged += new System.EventHandler(this.Images_EditText);
            // 
            // txtImageUrl2
            // 
            this.txtImageUrl2.Location = new System.Drawing.Point(4, 51);
            this.txtImageUrl2.Name = "txtImageUrl2";
            this.txtImageUrl2.Size = new System.Drawing.Size(417, 23);
            this.txtImageUrl2.TabIndex = 0;
            this.txtImageUrl2.TextChanged += new System.EventHandler(this.Images_EditText);
            // 
            // txtImageUrl3
            // 
            this.txtImageUrl3.Location = new System.Drawing.Point(4, 80);
            this.txtImageUrl3.Name = "txtImageUrl3";
            this.txtImageUrl3.Size = new System.Drawing.Size(417, 23);
            this.txtImageUrl3.TabIndex = 0;
            this.txtImageUrl3.TextChanged += new System.EventHandler(this.Images_EditText);
            // 
            // txtImageUrl5
            // 
            this.txtImageUrl5.Location = new System.Drawing.Point(4, 138);
            this.txtImageUrl5.Name = "txtImageUrl5";
            this.txtImageUrl5.Size = new System.Drawing.Size(417, 23);
            this.txtImageUrl5.TabIndex = 0;
            this.txtImageUrl5.TextChanged += new System.EventHandler(this.Images_EditText);
            // 
            // txtImageUrl4
            // 
            this.txtImageUrl4.Location = new System.Drawing.Point(4, 109);
            this.txtImageUrl4.Name = "txtImageUrl4";
            this.txtImageUrl4.Size = new System.Drawing.Size(417, 23);
            this.txtImageUrl4.TabIndex = 0;
            this.txtImageUrl4.TextChanged += new System.EventHandler(this.Images_EditText);
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.label5);
            this.groupBox_info.Controls.Add(this.txtAbout);
            this.groupBox_info.Controls.Add(this.cbbAboutCountry);
            this.groupBox_info.Location = new System.Drawing.Point(3, 253);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(670, 242);
            this.groupBox_info.TabIndex = 5;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "about this app*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Country*:";
            // 
            // txtAbout
            // 
            this.txtAbout.Location = new System.Drawing.Point(6, 51);
            this.txtAbout.Multiline = true;
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAbout.Size = new System.Drawing.Size(656, 185);
            this.txtAbout.TabIndex = 1;
            this.txtAbout.Visible = false;
            this.txtAbout.TextChanged += new System.EventHandler(this.TextAbout_EditText);
            // 
            // cbbAboutCountry
            // 
            this.cbbAboutCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAboutCountry.FormattingEnabled = true;
            this.cbbAboutCountry.Location = new System.Drawing.Point(268, 22);
            this.cbbAboutCountry.Name = "cbbAboutCountry";
            this.cbbAboutCountry.Size = new System.Drawing.Size(181, 23);
            this.cbbAboutCountry.TabIndex = 0;
            this.cbbAboutCountry.TextChanged += new System.EventHandler(this.CountryAbout_ComboBox);
            // 
            // groupBox_reviews
            // 
            this.groupBox_reviews.Controls.Add(this.label9);
            this.groupBox_reviews.Controls.Add(this.txtReviewStar);
            this.groupBox_reviews.Controls.Add(this.label8);
            this.groupBox_reviews.Controls.Add(this.txtReviewTotal);
            this.groupBox_reviews.Location = new System.Drawing.Point(10, 70);
            this.groupBox_reviews.Name = "groupBox_reviews";
            this.groupBox_reviews.Size = new System.Drawing.Size(200, 72);
            this.groupBox_reviews.TabIndex = 6;
            this.groupBox_reviews.TabStop = false;
            this.groupBox_reviews.Text = "reviews*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Star*:";
            // 
            // txtReviewStar
            // 
            this.txtReviewStar.Location = new System.Drawing.Point(58, 15);
            this.txtReviewStar.Name = "txtReviewStar";
            this.txtReviewStar.Size = new System.Drawing.Size(44, 23);
            this.txtReviewStar.TabIndex = 1;
            this.txtReviewStar.TextChanged += new System.EventHandler(this.Reviews_EditText);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total*:";
            // 
            // txtReviewTotal
            // 
            this.txtReviewTotal.Location = new System.Drawing.Point(58, 44);
            this.txtReviewTotal.Name = "txtReviewTotal";
            this.txtReviewTotal.Size = new System.Drawing.Size(132, 23);
            this.txtReviewTotal.TabIndex = 1;
            this.txtReviewTotal.TextChanged += new System.EventHandler(this.Reviews_EditText);
            // 
            // txtDownloadsTotal
            // 
            this.txtDownloadsTotal.Location = new System.Drawing.Point(59, 22);
            this.txtDownloadsTotal.Name = "txtDownloadsTotal";
            this.txtDownloadsTotal.Size = new System.Drawing.Size(132, 23);
            this.txtDownloadsTotal.TabIndex = 1;
            this.txtDownloadsTotal.TextChanged += new System.EventHandler(this.Downloads_EditText);
            // 
            // groupBox_downloads
            // 
            this.groupBox_downloads.Controls.Add(this.txtDownloadsTotal);
            this.groupBox_downloads.Controls.Add(this.label7);
            this.groupBox_downloads.Location = new System.Drawing.Point(10, 148);
            this.groupBox_downloads.Name = "groupBox_downloads";
            this.groupBox_downloads.Size = new System.Drawing.Size(200, 54);
            this.groupBox_downloads.TabIndex = 6;
            this.groupBox_downloads.TabStop = false;
            this.groupBox_downloads.Text = "downloads*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total*:";
            // 
            // groupBox_pegi
            // 
            this.groupBox_pegi.Controls.Add(this.label6);
            this.groupBox_pegi.Controls.Add(this.cbbPegi);
            this.groupBox_pegi.Location = new System.Drawing.Point(10, 208);
            this.groupBox_pegi.Name = "groupBox_pegi";
            this.groupBox_pegi.Size = new System.Drawing.Size(145, 54);
            this.groupBox_pegi.TabIndex = 6;
            this.groupBox_pegi.TabStop = false;
            this.groupBox_pegi.Text = "pegi*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Age*:";
            // 
            // cbbPegi
            // 
            this.cbbPegi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPegi.FormattingEnabled = true;
            this.cbbPegi.Items.AddRange(new object[] {
            "3",
            "7",
            "12",
            "16",
            "18"});
            this.cbbPegi.Location = new System.Drawing.Point(59, 22);
            this.cbbPegi.Name = "cbbPegi";
            this.cbbPegi.Size = new System.Drawing.Size(64, 23);
            this.cbbPegi.TabIndex = 1;
            this.cbbPegi.TextChanged += new System.EventHandler(this.Pegi_ComboBox);
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.ForeColor = System.Drawing.Color.Red;
            this.btnAddApplication.Location = new System.Drawing.Point(849, 560);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(199, 40);
            this.btnAddApplication.TabIndex = 7;
            this.btnAddApplication.Text = "Add Application";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Visible = false;
            this.btnAddApplication.Click += new System.EventHandler(this.ButtonClicked);
            // 
            // groupBox_apk
            // 
            this.groupBox_apk.Controls.Add(this.label10);
            this.groupBox_apk.Controls.Add(this.txtApkVersion);
            this.groupBox_apk.Location = new System.Drawing.Point(10, 10);
            this.groupBox_apk.Name = "groupBox_apk";
            this.groupBox_apk.Size = new System.Drawing.Size(200, 54);
            this.groupBox_apk.TabIndex = 6;
            this.groupBox_apk.TabStop = false;
            this.groupBox_apk.Text = "apk*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Version*:";
            // 
            // txtApkVersion
            // 
            this.txtApkVersion.Location = new System.Drawing.Point(59, 22);
            this.txtApkVersion.Name = "txtApkVersion";
            this.txtApkVersion.Size = new System.Drawing.Size(132, 23);
            this.txtApkVersion.TabIndex = 1;
            this.txtApkVersion.TextChanged += new System.EventHandler(this.ApkVersion_EditText);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbbLimitCount);
            this.groupBox1.Location = new System.Drawing.Point(848, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limit Usage*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "times a day";
            // 
            // cbbLimitCount
            // 
            this.cbbLimitCount.DisplayMember = "1";
            this.cbbLimitCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLimitCount.FormattingEnabled = true;
            this.cbbLimitCount.Items.AddRange(new object[] {
            "None",
            "2",
            "5",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cbbLimitCount.Location = new System.Drawing.Point(6, 22);
            this.cbbLimitCount.Name = "cbbLimitCount";
            this.cbbLimitCount.Size = new System.Drawing.Size(117, 23);
            this.cbbLimitCount.TabIndex = 0;
            this.cbbLimitCount.SelectedIndexChanged += new System.EventHandler(this.Limit_ComboBox);
            // 
            // label_finished
            // 
            this.label_finished.AutoSize = true;
            this.label_finished.Location = new System.Drawing.Point(998, 603);
            this.label_finished.Name = "label_finished";
            this.label_finished.Size = new System.Drawing.Size(49, 15);
            this.label_finished.TabIndex = 10;
            this.label_finished.Text = "finished";
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Location = new System.Drawing.Point(968, 603);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(24, 15);
            this.lblThreads.TabIndex = 10;
            this.lblThreads.Text = "0/0";
            this.lblThreads.Click += new System.EventHandler(this.LabelClicked);
            // 
            // panel_all
            // 
            this.panel_all.Controls.Add(this.label4);
            this.panel_all.Controls.Add(this.label3);
            this.panel_all.Controls.Add(this.label2);
            this.panel_all.Controls.Add(this.panel_apk2);
            this.panel_all.Controls.Add(this.label1);
            this.panel_all.Controls.Add(this.groupBox3);
            this.panel_all.Controls.Add(this.groupBox2);
            this.panel_all.Controls.Add(this.cbFormSettings);
            this.panel_all.Controls.Add(this.cbFormPhone);
            this.panel_all.Controls.Add(this.txtApkUrl);
            this.panel_all.Controls.Add(this.groupBox1);
            this.panel_all.Controls.Add(this.panel_apk);
            this.panel_all.Controls.Add(this.txtWebsiteUrl);
            this.panel_all.Controls.Add(this.lblThreads);
            this.panel_all.Controls.Add(this.cbbCategory);
            this.panel_all.Controls.Add(this.label_finished);
            this.panel_all.Controls.Add(this.btnAddApplication);
            this.panel_all.Controls.Add(this.txtTitle);
            this.panel_all.Location = new System.Drawing.Point(1, 1);
            this.panel_all.Name = "panel_all";
            this.panel_all.Size = new System.Drawing.Size(1054, 627);
            this.panel_all.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Category*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Title*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Website Url:";
            // 
            // panel_apk2
            // 
            this.panel_apk2.Controls.Add(this.groupBox_apk);
            this.panel_apk2.Controls.Add(this.groupBox_reviews);
            this.panel_apk2.Controls.Add(this.groupBox_downloads);
            this.panel_apk2.Controls.Add(this.groupBox_pegi);
            this.panel_apk2.Location = new System.Drawing.Point(461, 98);
            this.panel_apk2.Name = "panel_apk2";
            this.panel_apk2.Size = new System.Drawing.Size(218, 270);
            this.panel_apk2.TabIndex = 12;
            this.panel_apk2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Apk Url:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cLstPopular);
            this.groupBox3.Location = new System.Drawing.Point(848, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 153);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Popular In";
            // 
            // cLstPopular
            // 
            this.cLstPopular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cLstPopular.CheckOnClick = true;
            this.cLstPopular.FormattingEnabled = true;
            this.cLstPopular.Location = new System.Drawing.Point(5, 16);
            this.cLstPopular.Name = "cLstPopular";
            this.cLstPopular.Size = new System.Drawing.Size(188, 126);
            this.cLstPopular.TabIndex = 14;
            this.cLstPopular.SelectedIndexChanged += new System.EventHandler(this.Popular_CheckList);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cLstTypesApi);
            this.groupBox2.Location = new System.Drawing.Point(848, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 153);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Api Type*";
            // 
            // cLstTypesApi
            // 
            this.cLstTypesApi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cLstTypesApi.CheckOnClick = true;
            this.cLstTypesApi.FormattingEnabled = true;
            this.cLstTypesApi.Items.AddRange(new object[] {
            "Child Environment",
            "Non Addictive Environment"});
            this.cLstTypesApi.Location = new System.Drawing.Point(5, 16);
            this.cLstTypesApi.Name = "cLstTypesApi";
            this.cLstTypesApi.Size = new System.Drawing.Size(188, 126);
            this.cLstTypesApi.TabIndex = 14;
            this.cLstTypesApi.SelectedIndexChanged += new System.EventHandler(this.TypenApis_CheckList);
            // 
            // cbFormSettings
            // 
            this.cbFormSettings.AutoSize = true;
            this.cbFormSettings.Location = new System.Drawing.Point(980, 8);
            this.cbFormSettings.Name = "cbFormSettings";
            this.cbFormSettings.Size = new System.Drawing.Size(68, 19);
            this.cbFormSettings.TabIndex = 13;
            this.cbFormSettings.Text = "Settings";
            this.cbFormSettings.UseVisualStyleBackColor = true;
            this.cbFormSettings.CheckedChanged += new System.EventHandler(this.FormSettings_CheckBox);
            // 
            // cbFormPhone
            // 
            this.cbFormPhone.AutoSize = true;
            this.cbFormPhone.Location = new System.Drawing.Point(883, 8);
            this.cbFormPhone.Name = "cbFormPhone";
            this.cbFormPhone.Size = new System.Drawing.Size(88, 19);
            this.cbFormPhone.TabIndex = 13;
            this.cbFormPhone.Text = "Phone View";
            this.cbFormPhone.UseVisualStyleBackColor = true;
            this.cbFormPhone.CheckedChanged += new System.EventHandler(this.FormPhone_CheckBox);
            // 
            // panel_apk
            // 
            this.panel_apk.Controls.Add(this.groupBox_icon);
            this.panel_apk.Controls.Add(this.groupBox_info);
            this.panel_apk.Controls.Add(this.groupBox_images);
            this.panel_apk.Location = new System.Drawing.Point(6, 121);
            this.panel_apk.Name = "panel_apk";
            this.panel_apk.Size = new System.Drawing.Size(673, 499);
            this.panel_apk.TabIndex = 12;
            this.panel_apk.Visible = false;
            // 
            // FormAppAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 632);
            this.Controls.Add(this.panel_all);
            this.Name = "FormAppAdd";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateFormClosing);
            this.groupBox_icon.ResumeLayout(false);
            this.groupBox_icon.PerformLayout();
            this.groupBox_images.ResumeLayout(false);
            this.groupBox_images.PerformLayout();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.groupBox_reviews.ResumeLayout(false);
            this.groupBox_reviews.PerformLayout();
            this.groupBox_downloads.ResumeLayout(false);
            this.groupBox_downloads.PerformLayout();
            this.groupBox_pegi.ResumeLayout(false);
            this.groupBox_pegi.PerformLayout();
            this.groupBox_apk.ResumeLayout(false);
            this.groupBox_apk.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_all.ResumeLayout(false);
            this.panel_all.PerformLayout();
            this.panel_apk2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel_apk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.ComboBox cbbAboutCountry;
        private System.Windows.Forms.ComboBox cbbPegi;

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtWebsiteUrl;
        private System.Windows.Forms.TextBox txtApkUrl;
        private System.Windows.Forms.TextBox txtIconUrl;
        private System.Windows.Forms.TextBox txtImageUrl1;
        private System.Windows.Forms.TextBox txtImageUrl6;
        private System.Windows.Forms.TextBox txtImageUrl2;
        private System.Windows.Forms.TextBox txtImageUrl3;
        private System.Windows.Forms.TextBox txtImageUrl5;
        private System.Windows.Forms.TextBox txtImageUrl4;
        private System.Windows.Forms.TextBox txtAbout;
        private System.Windows.Forms.TextBox txtReviewStar;
        private System.Windows.Forms.TextBox txtReviewTotal;
        private System.Windows.Forms.TextBox txtDownloadsTotal;

        private System.Windows.Forms.GroupBox groupBox_icon;
        private System.Windows.Forms.GroupBox groupBox_images;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.GroupBox groupBox_reviews;
        private System.Windows.Forms.GroupBox groupBox_downloads;
        private System.Windows.Forms.GroupBox groupBox_pegi;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.GroupBox groupBox_apk;
        private System.Windows.Forms.TextBox txtApkVersion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbLimitCount;
        private System.Windows.Forms.Label label_finished;
        private System.Windows.Forms.Label lblThreads;
        private System.Windows.Forms.Panel panel_all;
        private System.Windows.Forms.Panel panel_apk2;
        private System.Windows.Forms.Panel panel_apk;
        public System.Windows.Forms.CheckBox cbFormPhone;
        public System.Windows.Forms.CheckBox cbFormSettings;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox cLstTypesApi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox cLstPopular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

