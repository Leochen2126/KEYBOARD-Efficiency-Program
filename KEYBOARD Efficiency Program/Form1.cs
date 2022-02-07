namespace KEYBOARD_Efficiency_Program
{
    public partial class Form1 : Form
    {
        int time = 0;
        int incorrect = 0;
        int correct = 0;
        Form2 original;
        string MODE;

        public Form1(Form2 ori, string iMODE)
        {
            InitializeComponent();
            this.original = ori;
            this.MODE = iMODE;
            if (MODE == "both")
            {
                label3.Text = Word.getCapWord();
            }
            else if (MODE == "right")
            {
                label3.Text = Word.getRight();
            }
            else { label3.Text = Word.getLeft(); }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkWord(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == label3.Text)
                {
                    if (MODE == "both")
                    {
                        label3.Text = Word.getCapWord();
                    }
                    else if (MODE == "right")
                    {
                        label3.Text = Word.getRight();
                    }
                    else { label3.Text = Word.getLeft(); }

                    textBox1.Text = null;
                    correct += 1;
                    label2.Text = "Correct: " + correct;
                }
                else
                {
                    if (MODE == "both")
                    {
                        label3.Text = Word.getCapWord();
                    }
                    else if (MODE == "right")
                    {
                        label3.Text = Word.getRight();
                    }
                    else { label3.Text = Word.getLeft(); }
                    textBox1.Text = null;
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time += 1;
            label1.Text = "Timer: " + time;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            time = 0;
            correct = 0;
            label1.Text = "Timer: " + time;
            label2.Text = "Correct: " + correct;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            original.Show();

            this.Hide();
            this.Close();
            this.Dispose(true);
            
        }
    }

   
}