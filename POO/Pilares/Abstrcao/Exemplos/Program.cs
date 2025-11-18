using Exemplos;

// Cachorro toto = new Cachorro ();
// toto.FazerSom();
// toto.Mover();


// Gato gatinho = new Gato ();
// gatinho.FazerSom();
// gatinho.Mover();

// Pessoa Matheus = new Pessoa ();
// Matheus.FazerSom();
// Matheus.Mover();

//2. Classe ContaBancaria
//Crie um classe abstrata ContaBancaria com métodos
//Depositar(double valor) e Sacar(double valor).
//Crie duas classes: ContaCorrente e ContaPoupanca, cada uma
//com sua própria forma de calcular o saldo após saque (por exemplo, taxa diferente).




ContaCorrente contaCorrente = new ContaCorrente("Maria", 1000);
            ContaPoupanca contaPoupanca = new ContaPoupanca("João", 1000);

            contaCorrente.Depositar(500);
            contaCorrente.Sacar(200);

            Console.WriteLine();

            contaPoupanca.Depositar(300);
            contaPoupanca.Sacar(200);

            Console.ReadLine();
