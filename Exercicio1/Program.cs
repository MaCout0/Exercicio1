namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            #region variaveis
            
            int choose = 0;
            #endregion

            while (choose != 5)
            {
                Console.Clear();

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("             Calculadora");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Selecione uma das seguintes opções: \n");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multipicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");
                choose = Convert.ToInt32(Console.ReadLine());
                
                Console.Clear();

                switch (choose)
                {
                    case 1:
                        
                        soma();
                        break;

                    case 2:
                        
                        subtracao();
                        break;

                    case 3:
                        multiplicacao();
                        break;

                    case 4:
                        divisao();
                        break;
                }
            }

            return;
        }

        static void soma()
        {
            int valor1 = 0, valor2 = 0, result = 0;
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            result = valor1 + valor2;
            Console.WriteLine($"\nO resultado da operação é: {valor1} + {valor2} = {result} \n\npressione qualquer tecla para voltar ao menu!!");
            Console.ReadLine();

        }

        static void subtracao()
        {
            int valor1, valor2, result;
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            result = valor1 - valor2;
            Console.WriteLine($"\nO resultado da operação é: {valor1} - {valor2} = {result} \n\npressione qualquer tecla para voltar ao menu!!");
            Console.ReadLine();
        }

        static void multiplicacao()
        {
            int valor1 = 0, valor2 = 0, result = 0;
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            result = valor1 * valor2;
            Console.WriteLine($"\nO resultado da operação é: {valor1} * {valor2} = {result} \n\npressione qualquer tecla para voltar ao menu!!");
            Console.ReadLine();
        }

        static void divisao()
        {
            int valor1 = 0, valor2 = 0, result = 0;
            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            result = valor1 / valor2;
            Console.WriteLine($"\nO resultado da operação é: {valor1} / {valor2} = {result} \n\npressione qualquer tecla para voltar ao menu!!");
            Console.ReadLine();
        }

        

        
    }
}
