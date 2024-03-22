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

                Console.WriteLine("Hello, World!");

                 choose = Convert.ToInt32(Console.ReadLine());
                
                Console.Clear();

                switch (choose)
                {
                    case 1:
                        soma();
                        break;

                    case 2:

                    break;

                    case 3:

                    break;

                    case 4:

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
            Console.WriteLine($"{valor1} + {valor2} = {result}");
            Console.ReadLine();

        }
    }
}
