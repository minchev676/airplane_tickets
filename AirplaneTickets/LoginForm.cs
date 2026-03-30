using System;
using System.Linq;
using System.Windows.Forms;
using AirplaneTickets.Data;
using AirplaneTickets.Data.Models;

namespace AirplaneTickets
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.MaximizeBox = false;   // маха бутона за maximize
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // прави прозореца фиксиран размер
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Моля, въведи потребителско име и парола.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u =>
                    u.Username == username &&
                    u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Успешен вход!");

                    Form1 form1 = new Form1(user);
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Грешно потребителско име или парола!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}