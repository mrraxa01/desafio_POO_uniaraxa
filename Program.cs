﻿
namespace desafio_POO;
class Program
{
static void Main(string[] args){

Basico calculosBasicos = new();
Estatistico calculosEstatisticos = new();
bool exibeMenu = true;

do
{

Console.WriteLine("#### ESCOLHA UMA OPERAÇÃO ########\n");
Console.WriteLine(" 1 - SOMAR");
Console.WriteLine(" 2 - SUBTRAIR");
Console.WriteLine(" 3 - MULTIPLICAR");
Console.WriteLine(" 4 - DIVIDIR");
Console.WriteLine(" 5 - MÉDIA ARITMÉTICA");
Console.WriteLine(" 0 - SAIR DA APLICAÇÃO");

int opcao = Convert.ToInt32(Console.ReadLine());

switch(opcao)
{
    case 0:
        exibeMenu = false;
        break;
    case 1:
        lerValoresCalculo();
        calculosBasicos.Somar();
        Console.WriteLine("RESULTADO ==> " + calculosBasicos.R );
        break;
    case 2:
        lerValoresCalculo();
        calculosBasicos.Subtrair();
        Console.WriteLine("RESULTADO ==> " + calculosBasicos.R );
        break;
    case 3:
        lerValoresCalculo();
        calculosBasicos.Multiplicar();
        Console.WriteLine("RESULTADO ==> " + calculosBasicos.R );
        break;
    case 4:
        lerValoresCalculo();
        calculosBasicos.Dividir();
        Console.WriteLine("RESULTADO ==> " + calculosBasicos.R );
        break;
    case 5:
        calculosEstatisticos.CalcularMedia(lerValoresMedia());
        Console.WriteLine("RESULTADO ==> " + calculosEstatisticos.R );
        break;

}   

}while(exibeMenu);

 void lerValoresCalculo(){
    Console.WriteLine("Digite o primeiro valor: ");
    calculosBasicos.X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nDigite o segundo valor: ");
    calculosBasicos.Y = Convert.ToInt32(Console.ReadLine());    
}

 double[] lerValoresMedia(){
    
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
}

}
}