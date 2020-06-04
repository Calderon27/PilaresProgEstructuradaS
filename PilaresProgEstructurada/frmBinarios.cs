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
    public partial class frmBinarios : Form
    {
        public frmBinarios()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if(this.txtNumero.Text.Length==0)
            {
                MessageBox.Show("Debe ingresar un entero....");
                return; //abandonar ejecucion
            }

            int numero = int.Parse(this.txtNumero.Text);
            binario(numero);
        }
        void binario(int num)
        {
            //declarar un vector de enteros
            int[] vector = new int[8];
            int residuo = 0,i=0;
            while (num > 0)
            {
                residuo = num % 2;
                vector[i++] = residuo;
                num /= 2;
            }
            i = 0;
            foreach(int k in vector)
            {
                if (i == 0) this.checkBox8.Checked = k == 1 ? true : false;
                if (i == 1) this.checkBox7.Checked = k == 1 ? true : false;
                if (i == 2) this.checkBox6.Checked = k == 1 ? true : false;
                if (i == 3) this.checkBox5.Checked = k == 1 ? true : false;
                if (i == 4) this.checkBox4.Checked = k == 1 ? true : false;
                if (i == 5) this.checkBox3.Checked = k == 1 ? true : false;
                if (i == 6) this.checkBox2.Checked = k == 1 ? true : false;
                if (i == 7) this.checkBox1.Checked = k == 1 ? true : false;
                i++;                
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
           
        }
       
        private void txtNumero_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 32 && e.KeyChar <= 47)||(e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}