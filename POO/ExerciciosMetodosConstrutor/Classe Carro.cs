
namespace ExerciciosMetodosConstrutor
{
    public class Carro
    {
        //propriedade


        public string Modelo;

        public string Marca;

        public int Ano;

        public Carro(string mo, string ma, int a)
        {
            Modelo = mo;
            Marca = ma;
            Ano = a;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, Ano: {Ano}");
        }
    }
}