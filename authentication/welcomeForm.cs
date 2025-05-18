
namespace WinFormsApp1
{
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void userSignWelcome_Click(object sender, EventArgs e)
        {

        }

        private void loginBtnWelcome_Click(object sender, EventArgs e)
        {
            UserWelcome userWelcome = new UserWelcome();
            userWelcome.Show();
            this.Hide();

        }

        private void driverBtn_Click(object sender, EventArgs e)
        {
            driverWelcome driverWelcome = new driverWelcome();
            driverWelcome.Show();
            this.Hide();
        }
    }
}
