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

Carro c1 = new Carro();

c1.DefinirMarca("Toyota");
c1.DefinirModelo("Corolla");

c1.Acelerar(40);
c1.Frear(20); 

Console.WriteLine($"Marca: {c1.ObterMarca()}");
Console.WriteLine($"Modelo: {c1.ObterModelo()}");
Console.WriteLine($"Velocidade Atual:{c1.ObterVelocidade()}");