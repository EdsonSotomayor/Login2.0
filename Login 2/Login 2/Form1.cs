using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            if (User.Text == "Juancho" && Pasword.Text=="123tamarindo")
            {
                MessageBox.Show("Bievenido " + User);
                this.Hide();
                Ventana2 CursosVentana = new Ventana2();
                CursosVentana.Show();
                this.Visible = false;

            }
            else
            {
                MessageBox.Show("Usurio o contraseña no valido");
                User.Text = "";
                Pasword.Text = "";
                User.Focus();
            }
        }

        private void Head_Click(object sender, EventArgs e)
        {

        }

        private void Pasword_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Pasword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (User.Text == "Juancho" && Pasword.Text == "123tamarindo")
                {
                    MessageBox.Show("Bievenido " + User);
                    this.Hide();
                    Ventana2 CursosVentana = new Ventana2();
                    CursosVentana.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Usurio o contraseña no valido");
                    User.Text = "";
                    Pasword.Text = "";
                    User.Focus();
                }
            }

        }

        private void User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Pasword.Focus();
            }
    }
    }
}
