using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using AddApplication.Utils;
using System.Threading.Tasks;
using System.Net;
using AddApplication.Models;
using System.IO;

namespace AddApplication.Src.AllForms
{

    partial class FormPhone : Form
    {
        public AppPhoneModel PhoneData;
        private readonly FormAppAdd _formAppAdd;


        public FormPhone(FormAppAdd formMain)
        {
            Icon = Properties.Resources.logo21;
            BackColor = ColorTranslator.FromHtml("#FCFDFF");
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;

            InitializeComponent();

            _formAppAdd = formMain;
            PhoneData = new AppPhoneModel();

            picPegi.Image = Properties.Resources.pegi_3;
            picPegi.SizeMode = PictureBoxSizeMode.StretchImage;

            _ = UpdateAllAsync();
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            _formAppAdd.cbFormPhone.Checked = false;
        }

        public void UpdateTitle(string value)
        {
            if(value != lblTitle.Text)
            {
                lblTitle.Text = value;
            }
        }

        public async Task UpdateIconAsync(string value)
        {
            if (PhoneData.LatestIcon != value)
            {
                // check
                if(value == "" || value == null)
                {
                    picIcon.InitialImage = null;
                    return;
                }

                // download image
                Image image = await Task.Run( 
                    () => Download.ImageFromUrl(value) 
                );

                // set icon default
                picIcon.Image = image;
                picIcon.Size = new Size(75, 75);
                picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                PhoneData.LatestIcon = value;
            }
        }
        
        public void UpdateReviewStar(string value)
        {
            if(lblReviewStar.Text != value)
            {
                lblReviewStar.Text = value;
            }
        }
        
        public void UpdateReviewTotal(long value)
        {
            if (PhoneData.LatestReviews != value)
            {
                string val;

                if (value >= 1000000000)
                    val = (value / 1000000000).ToString() + "B";
                else if (value >= 1000000)
                    val = (value / 1000000).ToString() + "M";
                else if (value >= 1000)
                    val = (value / 1000).ToString() + "K";
                else
                    val = (value).ToString();
                
                lblReviewTotal.Text = val + " Reviews";
                PhoneData.LatestReviews = value;
            }
        }

        public void UpdateDownloadsTotal(long value)
        {

            if (PhoneData.LatestDownloads != value)
            {
                string val;

                if(value >= 1000000000)
                {
                    val = (value / 1000000000).ToString() + "B+";
                }
                else if (value >= 1000000)
                {
                    val = (value / 1000000).ToString() + "M+";
                }
                else if (value >= 1000)
                {
                    val = (value / 1000).ToString() + "K+";
                }
                else
                {
                    val = (value).ToString();
                }

                lblDownloads.Text = val;
                PhoneData.LatestDownloads = value;
            }
        }

        public void UpdatePegi(int value)
        {
            if (PhoneData.LatestPegi != value)
            {
                if(value == 3)
                {
                    picPegi.Image = Properties.Resources.pegi_3;
                }
                else if(value == 7)
                {
                    picPegi.Image = Properties.Resources.pegi_7;
                }
                else if (value == 12)
                {
                    picPegi.Image = Properties.Resources.pegi_12;
                }
                else if (value == 16)
                {
                    picPegi.Image = Properties.Resources.pegi_16;
                }
                else if (value == 18)
                {
                    picPegi.Image = Properties.Resources.pegi_18;
                }

                picPegi.SizeMode = PictureBoxSizeMode.StretchImage;
                PhoneData.LatestPegi = value;
            }
        }

        public async Task UpdateImagesAsync(string[] values)
        {
            if (values == null)
            {
                return;
            }
            else if (PhoneData.LatestImages == null)
            {
                PhoneData.LatestImages = new string[values.Length];
            }

            if (PhoneData.LatestImages == null || !PhoneData.LatestImages.SequenceEqual(values))
            {
                values.CopyTo(PhoneData.LatestImages,0);
                imageList1.Images.Clear();
                lstImages.Items.Clear();


                // update image(s)
                Image[] images = new Image[values.Length];
                for (int i = 0; i < values.Length; i++ )
                {
                    string value = values[i];
                    if (value == "" || value == null)
                    {
                        continue;
                    }

                    bool succeeded = await Task.Run(
                        () => ImageFromUrl(value, ref images[i])
                    );
                }
                
                lstImages.View = View.LargeIcon;
                foreach (Image image  in images)
                {
                    if(image != null)
                    {
                        imageList1.Images.Add(image);
                    }
                }


                // add list
                imageList1.ImageSize = new Size(85, 150);
                imageList1.ColorDepth = ColorDepth.Depth32Bit;
                lstImages.LargeImageList = imageList1;

                for (int i = 0; i < values.Length; i++)
                {
                    ListViewItem item = new ListViewItem
                    {
                        ImageIndex = i
                    };
                    lstImages.Items.Add(item);
                }

            }
        }

        public void UpdateAbout(string value)
        {
            if (lblAbout.Text != value)
            {
                lblAbout.Text = value;
            }
        }

        public async Task UpdateAllAsync()
        {
            AppModel app = FormAppAdd.ApplicationModel;
            if (app == null) return;

            
            UpdateTitle(app.Title);

            UpdateReviewStar(app.Apk.Reviews.Star.ToString());

            long review_total = PhoneData.LatestReviews;
            PhoneData.LatestReviews = 0;
            UpdateReviewTotal(review_total);

            long downloads = PhoneData.LatestDownloads;
            PhoneData.LatestDownloads = 0;
            UpdateDownloadsTotal(downloads);

            int pegi = PhoneData.LatestPegi;
            PhoneData.LatestPegi = 0;
            UpdatePegi(pegi);

            if (app.Apk.About.ContainsKey("Globally") && app.Apk.About["Globally"].Text != "")
            {
                UpdateAbout(app.Apk.About["Globally"].Text);
            }

            string icon = PhoneData.LatestIcon;
            PhoneData.LatestIcon = "";
            await UpdateIconAsync(icon);

            string[] images = PhoneData.LatestImages;
            PhoneData.LatestImages = null;
            await UpdateImagesAsync(images);
            
        }

        private bool ImageFromUrl(string imageUrl, ref Image image)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(imageUrl);
            webRequest.AllowWriteStreamBuffering = true;
            webRequest.Timeout = 30000;

            WebResponse response = null;
            try
            {
                response = webRequest.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }
            


            Stream stream = response.GetResponseStream();
            image = Image.FromStream(stream);

            response.Close();

            return true;
        }

    }
}
