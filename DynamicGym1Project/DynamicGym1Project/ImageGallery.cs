using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DynamicGym1Project
{
    class ImageGallery
    {
        // attribute
        private Image Img { get; set; }

        // method
        public Image RandomImage()
        {
            Random random = new Random();

            // add images to image list
            ImageList list = new ImageList();
            list.Images.Add(Properties.Resources.onemore1);
            list.Images.Add(Properties.Resources.proud1);
            list.Images.Add(Properties.Resources.pickdumb11);
            list.Images.Add(Properties.Resources.pickdumb2);
            list.Images.Add(Properties.Resources.quote11);
            list.Images.Add(Properties.Resources.quote2);

            int shuffle = random.Next(0,list.Images.Count);
            return list.Images[shuffle];
        }

        public void LoadNAddImage(PictureBox img,ImageList imgList)
        {
            try
            {                 
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "C:/Picture/";
            of.Filter = "All Files|*.*|JPEG|*.jpg|Bitmaps|*.bmp|GIFs|*.gif|PNG|*.png";
            of.FilterIndex = 2;
            of.Multiselect = true;
            if (of.ShowDialog() == DialogResult.OK)
            {
                imgList.Images.Add(img.Image);
                img.Image = Image.FromFile(of.FileName);
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                img.BorderStyle = BorderStyle.Fixed3D;

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
}
    }
}
