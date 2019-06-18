using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda
{
    public partial class registrar : UserControl
    {
        validar vl = new validar();
        conexion c = new conexion();

        public registrar()
        {
            InitializeComponent();
        }

        private void registrar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }

        private void btnRedondear_Click(object sender, EventArgs e)
        {
            if (c.verificar(Convert.ToInt32(textBox1.Text)) == 0){
                MessageBox.Show(c.insertar(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text));
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show(" NO SE PUEDE REGISTRAR REFERENCIAS REPETIDAS");
            }
        }
    }
}
