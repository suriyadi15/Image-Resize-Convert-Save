using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Resize_Convert_Save
{
    public partial class FormMain : Form
    {
        Bitmap ori,result;
        public FormMain()
        {
            InitializeComponent();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog() { Filter="Image File (*.bmp; *.png; *.jpg)|*.bmp;*.png;*.jpg"};
            DialogResult r = op.ShowDialog();
            if (r == DialogResult.OK)
            {
                ori = new Bitmap(op.FileName);
                pictureBoxOri.Image = ori;
            }
        }

        private void buttonProccess_Click(object sender, EventArgs e)
        {
            try {
                int width = Convert.ToInt32(textBoxWidth.Text);
                int height = Convert.ToInt32(textBoxHeight.Text);
                string pixelFormat = comboBoxPixelFormat.SelectedItem.ToString();

                PixelFormat pf = PixelFormat.Format24bppRgb;
                if (pixelFormat == "32bppRGB")
                    pf = PixelFormat.Format32bppRgb;
                else if (pixelFormat == "32bppARGB")
                    pf = PixelFormat.Format32bppArgb;
                result = Edit(ori, width, height, 1, pf);
                pictureBoxResult.Image = result;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void saveResultImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog d = new SaveFileDialog() {
                Filter = @"Image File (*.png)|*.png|
                         Image File (*.bmp)|*.bmp|
                         Image File (*.jpg)|*.jpg"
            };
            if (d.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string extention = Path.GetExtension(d.FileName);
                    ImageFormat imgF = ImageFormat.Bmp;
                    if (extention == ".png")
                        imgF = ImageFormat.Png;
                    Save(result, 100, d.FileName, imgF);

                    MessageBox.Show("Save success...");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        /// <summary>
        /// Edit bitmap and return bitmap
        /// </summary>
        /// <param name="image"></param>
        /// <param name="maxWidth"></param>
        /// <param name="maxHeight"></param>
        /// <param name="quality"></param>
        /// <param name="pf"></param>
        /// <returns></returns>
        /// Code From codeproject.com
        public Bitmap Edit(Bitmap image, int maxWidth, int maxHeight, int quality, PixelFormat pf)
        {
            // Get the image's original width and height
            int originalWidth = image.Width;
            int originalHeight = image.Height;

            // To preserve the aspect ratio
            float ratioX = (float)maxWidth / (float)originalWidth;
            float ratioY = (float)maxHeight / (float)originalHeight;
            float ratio = Math.Min(ratioX, ratioY);

            // New width and height based on aspect ratio
            int newWidth = (int)(originalWidth * ratio);
            int newHeight = (int)(originalHeight * ratio);

            // Convert other formats (including CMYK) to RGB.
            Bitmap newImage = new Bitmap(newWidth, newHeight, pf);

            // Draws the image in the specified size with quality mode set to HighQuality
            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            return newImage;
        }

        public void Save(Bitmap newImage,int quality, string filePath,ImageFormat imgF)
        {
            // Get an ImageCodecInfo object that represents the JPEG codec.
            ImageCodecInfo imageCodecInfo = this.GetEncoderInfo(imgF);

            // Create an Encoder object for the Quality parameter.
            System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object. 
            EncoderParameters encoderParameters = new EncoderParameters(1);

            // Save the image as a JPEG file with quality level.
            EncoderParameter encoderParameter = new EncoderParameter(encoder, quality);
            encoderParameters.Param[0] = encoderParameter;
            newImage.Save(filePath, imageCodecInfo, encoderParameters);
        }
        /// <summary>
        /// Method to get encoder infor for given image format.
        /// </summary>
        /// <param name="format">Image format</param>
        /// <returns>image codec info.</returns>
        private ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            return ImageCodecInfo.GetImageDecoders().SingleOrDefault(c => c.FormatID == format.Guid);
        }
        //////////////
    }
}
