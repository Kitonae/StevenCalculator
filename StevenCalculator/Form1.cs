namespace StevenCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int calc = 666;
            int input = int.Parse(textBox1.Text);
            int wynik = input * calc;
            
            textBox2.Text = wynik.ToString();
        }
    }
}