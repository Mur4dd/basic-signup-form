namespace Day_1
{
    public partial class Form1 : Form
    {
        string str = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string mail = "muradahmadli1208@gmail.com";
            string pass = "Murad1208.";

            if (mailBox.Text == mail && passBox.Text == pass)
            {
                result.Text = "Welcome " + mail;
            }
            else
            {
                result.Text = "Password or e-mail incorret !";
            }

            if (manCheck.Checked)
            {
                str += "Your Gender is Man";
            }
            else if (womanCheck.Checked)
            {
                str += "Your Gender is Woman";
            }
            else if (anyCheck.Checked)
            {
                str += "Your Gender is Any";
            }
            else
            {
                str += "Your Gender is Empty";
            }

            MessageBox.Show(str , "- Infromation -");
        }
    }
}
