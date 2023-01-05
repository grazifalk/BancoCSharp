namespace BancoCSharp.Models
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(Titular titular) : base(titular)
        {
        }

        public ContaPoupanca(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }

        public override void ImprimirExtrato()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("******* Extrato Conta Poupança *******");
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
            Console.WriteLine("**************************************");
            Console.WriteLine("*********** Fim do Extrato ***********");
            Console.WriteLine("**************************************");
            Console.WriteLine();
        }
    }
}