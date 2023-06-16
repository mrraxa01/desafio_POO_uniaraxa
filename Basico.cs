using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_POO

{
    public class Basico: Calculo
    {
        private double num1;
        private double num2;
        public double X
        {
            set{ num1 = value;}
        }
        public double Y
        {
            set{ num2 = value;}
        }

        public void Somar(){
            R = num1 + num2;
        }

        public void Subtrair(){
            R = num1 - num2;
        }

        public void Multiplicar(){
            R = num1 * num2;
        }

        public void Dividir(){
            try
            {
                if(num2 == 0)
                    throw new DivideByZeroException();
                
                R = num1/num2;
            }
            catch(DivideByZeroException ex)
            {
                R = 0;
                Console.WriteLine("Não é possível dividir por zero - " + ex.Message);
            }
        }
    }


}