
using WinFormsApp1.Classes;

namespace WinFormsApp1
{
    public partial class userLoginForm : Form
    {
        public userLoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            authentication.Login(loginEmailField.Text, loginPassField.Text);
            return; //todo: link with user dashboard
        }
    }
}
