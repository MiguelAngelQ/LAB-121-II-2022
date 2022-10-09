namespace apk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            try {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                textBox3.Text = "La suma es " + Convert.ToString(a + b);
            }
            catch (Exception error) {
                textBox3.Text = "ERROR";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            
        }
    }
}