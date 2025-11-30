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
            if (Hospedes.Count > ObterQuantidadeHospedes())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade de hospede excedida");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Suite.Capacidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = Suite.ValorDiaria * DiasReservados;

            if ( DiasReservados >= 10)
            {
                valor = valor - (valor * 0.10M);
            }

            return valor;
        }
    }
}