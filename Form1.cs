namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtKg_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            double kg = double.Parse(txtKg.Text);
            double height = double.Parse(txtHeight.Text);

            double result = kg / (height * height);

            lblResult.Text = $"Индекс на телесна маса: {result:F2}";

            if (result >= 18.5 && result <= 25)
            {
                lblResult.ForeColor = Color.ForestGreen;
            }
            else
            {
                lblResult.ForeColor = Color.Red;
            }
        }



        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}