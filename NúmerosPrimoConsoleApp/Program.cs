namespace NúmerosPrimoConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                int divisor = 0;
                Console.Clear();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Olá, aqui iremos verificar se o número digitado é primo.");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Por favor digite o número para verifição:");                

                int numero = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= numero; i++)
                {
                    if (numero / i == 0)
                        divisor++;
                }
                if (divisor == 2)
                    Console.WriteLine("Este número é primo");
                else
                    Console.WriteLine("Este número não é primo");


                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;

            }
        }
    }
}
