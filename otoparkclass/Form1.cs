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
                MessageBox.Show("Plakay� girmeyi unuttunuz!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Giri� saatini girmeyi unuttunuz!!");
                return;
            }

            double girisSaati = Convert.ToDouble(textBox1.Text);

            MessageBox.Show(textBox3.Text + "'l� Arac�n Giri� i�lemini ba�ar�l� bir �ekilde tamamlad�n�z.");
        }

        private void cikisbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Plakay� girmeyi unuttunuz!!");
                return;
            }

           
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("��k�� saatini girmeyi unuttunuz!!");
                return;
            }

            double cikisSaati = Convert.ToDouble(textBox2.Text);
            double girisSaati = Convert.ToDouble(textBox1.Text);

            if (cikisSaati <= girisSaati)
            {
                MessageBox.Show("��k�� saati, giri� saatinden k���k veya e�it olamaz!");
                return;
            }

          
            otopark otopark = new otopark(textBox3.Text, 10, girisSaati, cikisSaati);

            
            otopark.hesabislemi();

            bool taksiSecildi = radioButton1.Checked;
            bool ticariAracSecildi = radioButton2.Checked;
            bool minibussecildi = radioButton3.Checked;

            
            otopark.Otoparktanc�k�s(taksiSecildi, ticariAracSecildi, minibussecildi, (int)(cikisSaati - girisSaati));

         
            double toplamUcret = otopark.BakiyeOgren();
            string formatliUcret = toplamUcret.ToString("F2");

            MessageBox.Show(textBox3.Text + "'l� Arac�n ��k�� i�lemi yap�l�yor. Toplam �cretiniz: " + formatliUcret + " TL");
        }
    }
}
