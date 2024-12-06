namespace final
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                selectedCandidate = "Joe Biden";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                selectedCandidate = "Donald Trump";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                selectedCandidate = "Viktor Yanukovych";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedCandidate))
            {
                MessageBox.Show($"You chose: {selectedCandidate}\nThank you for participating in the election!", "Election Result");
                Application.Exit(); 
            }
            else
            {
                MessageBox.Show("Please select a candidate before submitting.", "Error");
            }
        }

        private string selectedCandidate;
    }
}
