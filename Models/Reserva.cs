namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: 
            //Verificar se a capacidade é maior ou igual ao número 
            // de hóspedes sendo recebido
            // *IMPLEMENTE AQUI* 
            bool verificarCapacidade = Suite.Capacidade >= hospedes.Count;
            if (verificarCapacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
            // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
            // *IMPLEMENTE AQUI*
                throw new Exception ("Quantidade de hospedes maior qua a capacidade.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;     
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        public int ObterQuantidadeDeDias()
        {
            return DiasReservados;
        }

        public decimal CalcularValorDiaria()
        {
            
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, 
            // conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados > 10)
            {
                decimal percentual = (10.0M / 100.0M); 
                decimal valor_final = valor - (percentual * valor);
                valor = valor_final;
            }
            return valor;
        }
    }
}