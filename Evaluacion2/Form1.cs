using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            promedio Wen = new promedio();
            Wen.nombre = txt_NomA.Text;
            Wen.Cuenta = Convert.ToInt64(txt_NumC.Text);
            Wen.Nota1 = Convert.ToInt32(txt_nota1.Text);
            Wen.Nota2 = Convert.ToInt32(txt_nota2.Text);
            Wen.Nota3 = Convert.ToInt32(txt_nota3.Text);
            Wen.Nota4 = Convert.ToInt32(txt_nota4.Text);


            MessageBox.Show(Wen.nombre + "   Su calificacion es:     " + Wen.result() + "      " + Wen.Notificacion());
        }
    }
}
