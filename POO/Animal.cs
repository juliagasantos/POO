namespace POO
{
    public class Animal
    {
        private string nome = "Sonic";
        private string raca = "Shitzu";

        public void Comer()
        {
            Console.WriteLine("O animal está comendo");
        }
        public void DadosAnimal()
        {
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Raça: {this.raca}");
        }
    }

    //Classe cachorro herda todos os atrivutos e métodos da classe Animal
    public class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine("O cachorro está latindo");
        }
    }
}
