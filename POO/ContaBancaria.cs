namespace POO
{
    public class ContaBancaria
    {
        //Atributo privado  acesso apenas na própria classe
        private double saldo;

        //Método público void (sem retorno), que pode ser acessado de qualquer classe da aplicação
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }
        //Método público void (sem retorno), que pode ser acessado de qualquer classe da aplicação
        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
            }
        }
        // Método público com rertono de um atrivuto privado, pode ser acessado de qualquer classe da aplicação
        public double ConsultarSaldo() 
        {
            return saldo;
        }
    }
}
