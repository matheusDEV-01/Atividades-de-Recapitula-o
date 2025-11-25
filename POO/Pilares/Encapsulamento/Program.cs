using Encapsulamento;

// float Dinheiro = 200;

// ContaBancaria contaMath = new ContaBancaria();
// ContaBancaria contaEdu = new ContaBancaria(Dinheiro);

// contaMath.Depositar(Dinheiro);

// System.Console.WriteLine($"Saldo do Math R${contaMath.GetSaldo()}");

// System.Console.WriteLine($"Saldo do Edu R${contaEdu.GetSaldo()}");

// contaMath.Sacar(50);
// Console.WriteLine($"Saldo atualizado da conta: R$:{contaMath.GetSaldo()}");
// Console.WriteLine($"Saldo da conta : R$:{contaEdu.GetSaldo()}");

Carro meuCarro = new Carro();

meuCarro.DefinirMarca("Toyota");
meuCarro.DefinirModelo("Corolla");

meuCarro.Acelerar(50);
meuCarro.Frear(30); // aqui deve zerar a velocidade

Console.WriteLine("Marca: " + meuCarro.ObterMarca());
Console.WriteLine("Modelo: " + meuCarro.ObterModelo());
Console.WriteLine("Velocidade Atual: " + meuCarro.ObterVelocidade());