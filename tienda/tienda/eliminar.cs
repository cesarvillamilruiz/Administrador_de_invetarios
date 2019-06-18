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
    public partial class eliminar : UserControl
    {
        conexion c = new conexion();
        
        public eliminar()
        {
            InitializeComponent();
        }

        private void eliminar_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }

        private void btnRedondear_Click(object sender, EventArgs e)
        {
            if (c.verificar(Convert.ToInt32(textBox1.Text)) >= 1)
            {
                MessageBox.Show(c.eliminar(Convert.ToInt32(textBox1.Text)));
            }
        }
    }
}
