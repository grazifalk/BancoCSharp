namespace BancoCSharp.Models
{
    public class ContaInvestimento : ContaBancaria
    {
        public double ValorInvestido { get; private set; }
        public ContaInvestimento(Titular titular) : base(titular)
        {
        }

        public ContaInvestimento(Titular titular, double saldoAbertura, double limiteEspecial) : base(titular, saldoAbertura, limiteEspecial)
        {
        }

        public override void ImprimirExtrato()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("***** Extrato Conta Investimento *****");
            Console.WriteLine("**************************************");
            Console.WriteLine();
            Console.WriteLine("Gerado em: " + DateTime.Now);
            Console.WriteLine();

            foreach (var movimentacao in Movimentacoes)
            {
                Console.WriteLine(movimentacao.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Saldo atual: R$ " + Saldo);
            Console.WriteLine();
            Console.WriteLine("Limite especial: R$ " + LimiteChequeEspecial);
            Console.WriteLine();
            Console.WriteLine("**************************************");
            Console.WriteLine("*********** Fim do Extrato ***********");
            Console.WriteLine("**************************************");
            Console.WriteLine();
        }
    }
}