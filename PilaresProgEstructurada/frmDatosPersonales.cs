using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilaresProgEstructurada
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (this.txtNombre.Text.Length > 0)
                {
                    this.lstNombres.Items.Add(this.txtNombre.Text);
                    this.txtNombre.Text = "";
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            // 1. validar que haya datos ingresados en la caja de texto
            // 2. agregar el nombre ingresado en el listbox (clic botón agregar)
            // 3. el nombre se debe agregar cuando el usuario pulse enter 
            //    en la caja de texto
        }
    }
}
