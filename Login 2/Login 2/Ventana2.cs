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
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void Ventana2_Load(object sender, EventArgs e)
        {

        }

        private void Comprar_Click(object sender, EventArgs e)
        {
            int precio1 = 50, precio2= 40, precio3 = 100;
            int conteo = 0;
            string seleccion;

            if (CsharpCheckBox.Checked == true)
            {
                conteo++;
                precio1 = 50;
            }
            if (VisualBasicCheckBox.Checked== true)
            {
                conteo++;
                precio2 = 40;
            }
            if (PythoncheckBox.Checked== true)
            {
                conteo++;
                precio3 = 100;
            }
            if (TarjetaRadioButton.Checked== true)
            {
                seleccion = "Tarjeta de credito/debito";
            }
            else 
            {
                seleccion = "Paypal";
            }
        int precio = precio1 + precio2 + precio3;
            MessageBox.Show(" Has seleccionado" + conteo + " cursos y tu metodo de pago es " + seleccion + ".... " + " Total a pagar: " + precio + "Pesos mx/mes" );

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formulario = new Form1();
            formulario.Visible = true;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
