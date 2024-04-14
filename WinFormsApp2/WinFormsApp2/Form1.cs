using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private string password = "";
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string firstName = InputName.Text;
            string lastName = InputLastName.Text;
            string position = "";
            if (positionBox.SelectedIndex != -1)
            {
                position = positionBox.SelectedIndex.ToString();
            }
            MessageBox.Show($"Dane pracownika: {firstName} {lastName} {position} Hasło: {password}");
        }

        private void PasswordButton_Click(object sender, EventArgs e)
        {
            string alphabet = "qwertyuiopasdfghijklzxcvbnm";
            string digitals = "01231456789";
            string șpeciaIChars = "!@#$%^&*()";

            password = "";
            int charsCounter = 0;
            if (charsCounterTb.Text !="") charsCounter =int.Parse
                    (charsCounterTb.Text);

            if (UpperLowerCh.Checked)
            {
                password += getRandomChar(alphabet.ToUpper());
            }
            if (DigitsCh.Checked)
            {
                password += getRandomChar(digitals);
            }
            if (SpecialCharsCh.Checked)
            {
                password += getRandomChar(șpeciaIChars);
            }
            if (charsCounter > password.Length)
            {
                while (password.Length < charsCounter)
                {
                    password += getRandomChar(alphabet);
                }
            }
            MessageBox.Show(password);
        }
        private char getRandomChar(string characters )
        {
            int index = r.Next(0, characters.Length);
            return characters[index];
        }
    }
}
