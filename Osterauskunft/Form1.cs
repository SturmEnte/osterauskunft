namespace Osterauskunft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int[] result = Osterrechner.calculateEeasterDate(int.Parse(yearInput.Text));

            if (result[0] == -1)
            {
                dayOutput.Text = "Fehler beim";
                monthOutput.Text = "berechnen :(";
                return;
            }

            dayOutput.Text = result[0].ToString();

            if (result[1] == 3)
            {
                monthOutput.Text = "März";
            }
            else if (result[1] == 4)
            {
                monthOutput.Text = "April";
            }
            
        }
    }
}
