using System.Globalization;
namespace Conta_Bancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria Conta;

            Console.Write("Entre com o número da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial? (s/n): ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {

                Console.Write("Digite o valor do deposito inicial: $ ");
                double depositoIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta = new ContaBancaria(numero, titular, depositoIni);
            }
            else
            {
                Conta = new ContaBancaria(numero, titular); 
                  
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(Conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: $ ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(Conta);
            Console.WriteLine();
            Console.WriteLine("Deseja fazer saque? (s/n)");
            char resp2 = char.Parse(Console.ReadLine());
            if (resp2 == 's' || resp2 == 'S')
                {
                Console.Write("Qual o valor que deseja sacar? : ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Conta.Saque(saque);
                Console.WriteLine("Dados da Conta atualizados: ");
                Console.WriteLine(Conta);
            }
            else
            {
                Console.WriteLine("Agradecemos sua preferencia!");
            }
        }
        
    }

}
