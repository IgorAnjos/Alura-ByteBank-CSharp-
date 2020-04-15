using ByteBank.Modelos;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(0257,261604);

            Console.WriteLine(conta.Numero);




            DateTime dataFimPagamento = new DateTime(2019,08,12);
            DateTime dataCorrente = DateTime.Now;

            //Comparar Data
            TimeSpan diferenca = dataFimPagamento - dataCorrente;
            TimeSpan diferenca2 = TimeSpan.FromMinutes(60);

            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            string mensagem2 = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca2);

            Console.WriteLine(dataFimPagamento);
            Console.WriteLine(dataCorrente);

            Console.WriteLine(mensagem);
            Console.WriteLine(mensagem2);


            Console.ReadLine();
        }

        //formatar o resultado entre datas
        static string GetInervaloDeTempoLegivel(TimeSpan timeSpan)
        {

            if (timeSpan.Days > 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;
                return quantidadeMeses + " meses";

                if (timeSpan.Days == 1)
                    return  " 1 mês";
            }
            else if(timeSpan.Days >7)
            {
                int quantidadeSemanas = timeSpan.Days / 7;
                return quantidadeSemanas + " semanas";

            }


            return timeSpan.Days + " dias";
        }

    }
}
