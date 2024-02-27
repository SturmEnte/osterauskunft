namespace Osterauskunft
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int[] result = Osterrechner.calculateEeasterDate(int.Parse(yearInput.Text));

            dayOutput.Text = result[0].ToString();

            if (result[1] == 3)
            {
                monthOutput.Text = "März";
            }
            else if (result[1] == 4)
            {
                monthOutput.Text = "April";
            }
            else
            {
                monthOutput.Text = "Unknown";
            }
        }

        private void Geben_Sie_ein_Jahr_ein_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
