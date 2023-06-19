using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_POO
{
    public class Estatistico: Calculo
    {
        public double[] valores = new double[100];

        public void CalcularMedia(int qtd)
        {
            double soma =0;
           
            for (int i = 0; i<qtd; i++){
                soma += valores[i];
            }    
            
            R = soma / qtd;
        }
    }
}