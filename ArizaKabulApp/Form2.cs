using BusinessLayer;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArizaKabulApp
{
    public partial class Form2 : Form
    {
        public Guid Form2ye_Gidecek_Veri;

        public string veri;


        public Form2(Guid guid)
        {

            InitializeComponent();

            veri = guid.ToString();

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(veri, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(5);





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += PrintPage;
            pd.Document = doc;
            if(pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bitmap=new Bitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.DrawToBitmap(bitmap,new Rectangle(0,0,pictureBox1.Width,pictureBox1.Height));

            e.Graphics.DrawImage(bitmap,0,0);
            bitmap.Dispose();
        }
    }
}
