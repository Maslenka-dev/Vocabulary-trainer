namespace Vocabulary_trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Program.ArrayOfEngWords()[Program.random.Next(Program.ArrayOfEngWords().Length)];
        }
    }
}
