using BusinessLayer;
using Domain.DatabaseClass;
using System.Windows.Forms;

namespace ArizaKabulApp
{
    public partial class Form1 : Form
    {
        public CihazKayit cihaz = new CihazKayit();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null)
                {
                    cihaz.CihazAdi = textBox1.Text;
                    cihaz.Ad = textBox2.Text;
                    cihaz.Soyad = textBox3.Text;
                    cihaz.Email = textBox4.Text;

                    DBMetot dBmetot = new DBMetot();

                    var aa = dBmetot.CihazKaydet(cihaz);

                    Form2 form3 = new Form2(aa);
                    form3.Form2ye_Gidecek_Veri = aa;
                    form3.Show();
                }

                else
                {
                    MessageBox.Show("Tüm Hepsini Doldurunuz !!!");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Oluþtu {ex.Message} ");

            }


        }
    }
}
