using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    /*Prgrama de herencia, es la caracteristica de pasar atributos y metodos a otros objetos o clases*/
    //Clase Mamá
    //Comentario 26-04-2024
    class Operacion
    {
        /*Guardar los espaciosde memoria de 3 valores*/
        //Modificador, tipo de dato, nombre
        protected           int         valor1;
        protected           int         valor2;
        protected           int         resultado;
       
        //comentsario desde web

        // metodo o funcion de operacion
        public int Valor1 //caja de memoria 1
        {
            get { return valor1; } //vamos por el valor de la caja de tecto
            set { valor1 = value; } //Lo guardamos en memoria
        }
        public int Valor2 //caja de memoria 2
        {
            get { return valor2; } //vamos por el valor de la caja de tecto
            set { valor2 = value; } //Lo guardamos en memoria
        }
        public int Resultado //caja de memoria 1
        {
            get { return resultado; } //vamos por el valor de la caja de tecto
            set { resultado = value; } //Lo guardamos en memoria
        }

    }

    class sumar : Operacion
    {
        public int operar (int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 + valor2;
        }
    }
    class restar : Operacion
    {
        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 - valor2;
        }
    }
    class multiplicar : Operacion
    {
        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 * valor2;
        }
    }
    class dividir : Operacion
    {
        public int operar(int v1, int v2)
        {
            valor1 = v1;
            valor2 = v2;
            return resultado = valor1 / valor2;
        }
    }

    static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
