
using WinFormsApp1.Classes;

namespace WinFormsApp1
{
    public partial class userSignupForm : Form
    {
        public userSignupForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentication user = new Authentication();
            user.userSignUp(userNameField.Text, lastNameField.Text, emailField.Text, phoneField.Text, passwordField.Text);
            userLoginForm loginForm = new userLoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
