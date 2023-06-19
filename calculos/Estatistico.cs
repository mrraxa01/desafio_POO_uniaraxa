using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_POO
{
    public class Estatistico: Calculo
    {
        public double[] valores = new double[3];

        public void CalcularMedia()
        {
            Console.WriteLine("1");
            double soma =0;
            int qtdeValidNumbers =0;

            foreach (double valor in valores){
                Console.WriteLine("2" + valores[1]);
                qtdeValidNumbers++;
                soma += valor;
              
            }
           Console.WriteLine("3");
            R = soma / qtdeValidNumbers;
        }
    }
}