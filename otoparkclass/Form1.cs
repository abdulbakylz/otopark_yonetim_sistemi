namespace otoparkclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void girisbtn_Click_1(object sender, EventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Plakayý girmeyi unuttunuz!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Giriþ saatini girmeyi unuttunuz!!");
                return;
            }

            double girisSaati = Convert.ToDouble(textBox1.Text);

            MessageBox.Show(textBox3.Text + "'lý Aracýn Giriþ iþlemini baþarýlý bir þekilde tamamladýnýz.");
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Plakayý girmeyi unuttunuz!!");
                return;
            }

           
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("çýkýþ saatini girmeyi unuttunuz!!");
                return;
            }

            double cikisSaati = Convert.ToDouble(textBox2.Text);
            double girisSaati = Convert.ToDouble(textBox1.Text);

            if (cikisSaati <= girisSaati)
            {
                MessageBox.Show("Çýkýþ saati, giriþ saatinden küçük veya eþit olamaz!");
                return;
            }

          
            otopark otopark = new otopark(textBox3.Text, 10, girisSaati, cikisSaati);

            
            otopark.hesabislemi();

            bool taksiSecildi = radioButton1.Checked;
            bool ticariAracSecildi = radioButton2.Checked;
            bool minibussecildi = radioButton3.Checked;

            
            otopark.Otoparktancýkýs(taksiSecildi, ticariAracSecildi, minibussecildi, (int)(cikisSaati - girisSaati));

         
            double toplamUcret = otopark.BakiyeOgren();
            string formatliUcret = toplamUcret.ToString("F2");

            MessageBox.Show(textBox3.Text + "'lý Aracýn Çýkýþ iþlemi yapýlýyor. Toplam ücretiniz: " + formatliUcret + " TL");
        }
    }
}
