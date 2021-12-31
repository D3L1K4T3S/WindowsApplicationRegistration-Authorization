using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProduct
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            EmailField.Text = "Введите email";
            PasswordField.Text = "Введите пароль";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
            if (PasswordField.Text == "Введите пароль")
            {
                PasswordField.UseSystemPasswordChar = false;
                PasswordField.ForeColor = Color.Gray;
            }
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string loginuser = EmailField.Text;
            string passworduser = PasswordField.Text;

            if(EmailField.Text == "Введите имя")
            {
                MessageBox.Show("Сначала Введите имя");
                return;
            }

            if (EmailField.Text == "Введите пароль")
            {
                MessageBox.Show("Сначала Введите пароль");
                return;
            }

            if (isUserExists())
                return;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`ID`, `Login`, `Password`) VALUES (NULL,@login,@pass)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passworduser;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Уже с таким лгином зарегистрирован пользвоатель");

            db.closeConnection();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        Point lastpoint;
        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.Gray;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.ForeColor = Color.Gray;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.ForeColor = Color.Black;
        }

        private void EmailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailField_Enter(object sender, EventArgs e)
        {
            if(EmailField.Text == "Введите email")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.Black;
            }
 
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (EmailField.Text == "")
            {
                EmailField.Text = "Введите email";
                EmailField.ForeColor = Color.Gray;
            }
                
            
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if(PasswordField.Text == "Введите пароль")
            {
                PasswordField.Text = "";
                PasswordField.UseSystemPasswordChar = true;
                PasswordField.ForeColor = Color.Black;
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if(PasswordField.Text == "")
            {
                PasswordField.Text = "Введите пароль";
                PasswordField.ForeColor = Color.Gray;
                PasswordField.UseSystemPasswordChar = false;
            }
        }

        public Boolean isUserExists()
        {
            String loginUser = EmailField.Text;
            String passUser = PasswordField.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = EmailField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
