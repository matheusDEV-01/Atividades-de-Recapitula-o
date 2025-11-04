

namespace ClassesEObjetos
{
    public class AgênciaBancária
    {
        public string titular = "";
        public double saldo = 0;

        public void Depositar()
        {
            Console.WriteLine("Digite o valor de seu depósito:");
            double valor = double.Parse(Console.ReadLine());
            saldo += valor;
        }

        public void Sacar()
        {
            Console.WriteLine("Digite o valor que quer sacar:");
            double valor = double.Parse(Console.ReadLine());

            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }
        }
    }
}




