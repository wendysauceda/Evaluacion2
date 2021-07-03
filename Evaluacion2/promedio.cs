using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion2
{
   public class promedio
    {

        private string nombreEs;
        private int cuenta;
        private decimal nota1;
        private decimal nota2;
        private decimal nota3;
        private decimal nota4;
        private decimal resultado;
        private string notificacion;


        public string nombre { get; set; }

        public decimal Cuenta { get; set; }

        public decimal Nota1 { get; set; }

        public decimal Nota2 { get; set; }

        public decimal Nota3 { get; set; }

        public decimal Nota4 { get; set; }

        public promedio() { }

        public promedio(string nombre_, int Cuenta_)
        {
            nombre = nombre_;
            Cuenta = Cuenta_;

        }

        public promedio(decimal nota1_, decimal nota2_, decimal nota3_ , decimal nota4_)
        {

            Nota1 = nota1_;
            Nota2 = nota2_;
            Nota3 = nota3_;
            Nota4 = nota4_;
        }

        public decimal result()
        {
            resultado = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            return resultado;
        }

        public string Notificacion()
        {
          
            if(Convert.ToDecimal(resultado)>=70 && Convert.ToDecimal(resultado)<=100)
            {
                notificacion = "Aprobado";
            }
            else
            {
                notificacion = "Reprobado";

            }


            return notificacion;


        }     





    }
}
