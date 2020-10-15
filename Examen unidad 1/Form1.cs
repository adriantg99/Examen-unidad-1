using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_unidad_1
{
    public partial class Form1 : Form
    {
        int[] valor = new int[24];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            
                if (i < 25)
                {
                    valor[i] = i;
                MessageBox.Show("El valor del numero actual es: " + valor[i]);
                i += 1;

            }
            else
            {
                MessageBox.Show("Llego al valor maximo del contador");
            }
            

        
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {

            if (i > 0)
            {
                i -= 1;

                MessageBox.Show("Se ha restado un valor al vector, el valor actual es: "+i);
            }
            else
            {
                MessageBox.Show("No se le pueden restar más valores");
            }
            
        }
    }
}
