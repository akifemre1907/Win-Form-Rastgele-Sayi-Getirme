namespace Form_Rastgele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi;
        Random rastgele = new Random();

        

        private void button1_Click(object sender, EventArgs e)
        {

            sayi = rastgele.Next(1, 101);
            label1.Text = sayi.ToString();
            label1.Visible= true;
           
        }
    }
}