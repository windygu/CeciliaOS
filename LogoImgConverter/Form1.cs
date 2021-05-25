using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoImgConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            Bitmap bmp = (Bitmap)Image.FromFile(path);
            string base64 = BitmapOper.ImgToBase64String(bmp);
            File.WriteAllText(base64, "base64.txt");
            System.Diagnostics.Process.Start("base64.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string base64 = textBox1.Text;
            Bitmap img = BitmapOper.Base64StringToImage(base64);
            pictureBox1.Image = img;
        }
    }
    public static class BitmapOper
    {
        //图片转为base64编码的字符串
        public static string ImgToBase64String(Bitmap bmp)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //threeebase64编码的字符串转为图片
        public static Bitmap Base64StringToImage(string strbase64)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(strbase64);
                MemoryStream ms = new MemoryStream(arr);
                Bitmap bmp = new Bitmap(ms);
                ms.Close();
                return bmp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
