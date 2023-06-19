namespace desafio_POO.utils
{
    public static class InteractionMethods
    {
        static Basico calculosBasicos = new();
        static Estatistico calculosEstatiscos = new();



        public static void ShowMenu()
        {

            Console.WriteLine("#### ESCOLHA UMA OPERAÇÃO ########\n");
            Console.WriteLine(" 1 - SOMAR");
            Console.WriteLine(" 2 - SUBTRAIR");
            Console.WriteLine(" 3 - MULTIPLICAR");
            Console.WriteLine(" 4 - DIVIDIR");
            Console.WriteLine(" 5 - MÉDIA ARITMÉTICA");
            Console.WriteLine(" 0 - SAIR DA APLICAÇÃO");

        }

        public static void ShowResult(double R)
        {
            //Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X\n");
            Console.WriteLine("O RESULTADO DA OPERAÇÃO É {0} \n", R);
            Console.WriteLine("-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X\n");
            Console.ResetColor();
        }

        public static void LerValoresCalculo()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            calculosBasicos.X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDigite o segundo valor: ");
            calculosBasicos.Y = Convert.ToDouble(Console.ReadLine());
        }

        public static void LerValoresMedia()
        {
            Console.WriteLine("Deseja calcular a média com quantos números?");
            int qtd = Convert.ToInt32(Console.ReadLine());


            if (qtd < 2)
            {
                Console.WriteLine("Precisamos de pelo menos 2 múmeros!");
                LerValoresMedia();
            }
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite o {0}º número: ", i + 1);
                double x = Convert.ToDouble(Console.ReadLine());
                calculosEstatiscos.valores[i] = x;

            }
            calculosEstatiscos.CalcularMedia(qtd);
            ShowResult(calculosEstatiscos.R);

        }
    }
}