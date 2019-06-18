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
    public partial class consultar : UserControl
    {
        validar vl = new validar();
        public consultar()
        {
            InitializeComponent();
        }

        private void consultar_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();
            c.consultarPersona(dgv);
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
        }
    }
}
