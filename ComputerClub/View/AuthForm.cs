using System;
using System.Windows.Forms;
using ComputerClub.Entity;
using ComputerClub.Service;
using ComputerClub.Utils;

namespace ComputerClub
{
    public partial class AuthForm : Form
    {
        private IUserService _userService;

        public AuthForm()
        {
            InitializeComponent();
            _userService = new UserServiceImpl();
            CheckAdminUser();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            User currentUser = _userService.GetUserByLogin(loginBox.Text);

            if (currentUser != null)
            {
                if(CheckRoleUser(currentUser.Login) && 
                    Hash.VerifyPassword(passwordBox.Text, currentUser.Password) && 
                    currentUser.Login.Contains(loginBox.Text))
                {
                    MessageBox.Show("Вы успешно вошли!");
                    OpenForm.OpenFormNewDialog(this, new MainForm());
                } 
                else
                {
                    MessageBox.Show("Неккоректные данные!");
                }
            }
        }

        public void InitUserOnDataBase() 
        {
            _userService.Create(new User(
                "admin",
                "cyberZone",
                "admin"
            ));
        }

        private void CheckAdminUser()
        {
            if (_userService.GetAll().Count < 1)
                InitUserOnDataBase();
        }

        private bool CheckRoleUser(string role)
        {
            return role.Contains("admin");
        }

        private void CheckedPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkedPassword.Checked)
                passwordBox.PasswordChar = '\0';
            else
                passwordBox.PasswordChar = '*';

        }
    }
}
