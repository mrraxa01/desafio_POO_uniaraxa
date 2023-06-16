using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_POO
{
    public class Estatistico: Calculo
    {
        
        public void CalcularMedia( double[] valores)
        {
            double soma =0;

            foreach (double valor in valores){
              soma += valor;
            }
           
            R = soma / valores.Length;
        }
    }
}