//----------------------Classes, atributos e métodos----------------------

//Cria um novo objeto do tipo referencial do tipo Pessoa com uma nova instância
using POO;

Pessoa pessoa = new Pessoa();

//Recebendo os valores para atrivultos da objeto "pessoa"
//pessoa.nome = Console.ReadLine();
pessoa.idade = 24;

//Atribuindo os valores para os atributos do objeto diretamente
pessoa.nome = "Clayton";
pessoa.idade = 24;

//Acessando o método da classe pessoa
pessoa.Apresentar();


//------------------------------Encapsulamento------------------------------
ContaBancaria contaBancaria = new ();
contaBancaria.Depositar(1000);
contaBancaria.Depositar(1000);
contaBancaria.Depositar(1000);
contaBancaria.Sacar(500);
Console.WriteLine($"{contaBancaria.ConsultarSaldo()}");


//----------------------------------Herença----------------------------------
Cachorro dog = new();
dog.Comer();
dog.Latir();
dog.DadosAnimal();


//--------------------------------Polimorfismo--------------------------------
Forma forma = new Circulo();
forma.Desenhar();
