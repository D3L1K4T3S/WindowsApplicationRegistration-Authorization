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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.EmailField.AutoSize = false;
            this.EmailField.Size = new Size(this.EmailField.Size.Width, 30);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void ExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.Gray;
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.White;
        }

        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EmailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void PasswordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String loginUser = EmailField.Text;
            String passUser = PasswordField.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login` = @uL AND `Password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Авторизован");
            else
                MessageBox.Show("Не авторизован");

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
