﻿

using desafio_POO.utils;

namespace desafio_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Basico calculosBasicos = new();


            bool exibeMenu = true;

            do
            {

                InteractionMethods.ShowMenu();
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        exibeMenu = false;
                        break;
                    case 1:
                        lerValoresCalculo();
                        calculosBasicos.Somar();
                        InteractionMethods.ShowResult(calculosBasicos.R);
                        break;
                    case 2:
                        lerValoresCalculo();
                        calculosBasicos.Subtrair();
                        InteractionMethods.ShowResult(calculosBasicos.R);
                        break;
                    case 3:
                        lerValoresCalculo();
                        calculosBasicos.Multiplicar();
                        InteractionMethods.ShowResult(calculosBasicos.R);
                        break;
                    case 4:
                        lerValoresCalculo();
                        calculosBasicos.Dividir();
                        if (calculosBasicos.ExceptionByZero)
                            InteractionMethods.ShowException("Não é possível dividir por zero!");
                        else
                            InteractionMethods.ShowResult(calculosBasicos.R);
                        break;
                    case 5:
                        InteractionMethods.LerValoresMedia();
                        break;

                }

            } while (exibeMenu);

            void lerValoresCalculo(){
                Console.WriteLine("Digite o primeiro valor: ");
                calculosBasicos.X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nDigite o segundo valor: ");
                calculosBasicos.Y = Convert.ToInt32(Console.ReadLine());    
            } 

            /*  double[] lerValoresMedia(){

                Console.WriteLine("Deseja calcular a média com quantos números?");
                int qtd = Convert.ToInt32(Console.ReadLine());
                double[] valores = new double[qtd];

                if(qtd < 2)
                {
                    Console.WriteLine("Precisamos de pelo menos 2 múmeros!");
                    lerValoresMedia();
                }
                 for(int i=0; i < qtd; i++)
                    { 
                        Console.WriteLine("Digite o {0}º número: ", i+1);
                        valores[i] = Convert.ToInt32(Console.ReadLine());
                    }       

                return valores;
            } */

        }
    }


}