using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesSis03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o Seu salário Bruto: ");
            double sal = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do seu vale alimentação: ");
            double vale = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor recebido por filho: ");
            double fil = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantos filhos você tem: ");
            double filhosQtd = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor recebido por hora extra: ");
            double hora = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas extras trabalhadas: ");
            double ValorHr = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor descontado pelo INSS: ");
            double inss = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valordescontado pelo IRPF: ");
            double irpf = double.Parse(Console.ReadLine());
          
            //calculo do salario liquido com seus descontos e seus acréscimos 
            double SalLiq = sal - (inss + irpf) + (fil * filhosQtd) + (hora * ValorHr);
            //
            Console.WriteLine("Seu salárioliquido é de: " + SalLiq);

            //primeiro exercio completo.
            //inicio do segundo exercicio

            Console.WriteLine("Quantidade de Adultos que se hospedarão: ");
                int adul = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de crianças que irão se hospedar: ");
                int cria = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor da diária para os adultos: ");
                double diaria = double.Parse(Console.ReadLine());

            //com isso calcularemos o valor total da hospedagem ao fim dos dias 
            Console.WriteLine("Quantos dias a familia irá ficar hospedada no hotel: ");
                int dias = int.Parse(Console.ReadLine());

            //valor final da diaria dos adultos e das crianças juntas :
            double ValFin= adul * diaria + (adul / 2) * cria;
            //valor da total da hospedagem
            double ValFinDia = ValFin * dias;

            Console.WriteLine("Quantidade de parcelas: ");
                int parce = int.Parse(Console.ReadLine());

            double valPar = ValFinDia / parce;

            Console.WriteLine("Valor da diária da familia: " + ValFin);
            Console.WriteLine("Valor total da hospedagem: " + ValFinDia);
            Console.WriteLine("Valor da diária da familia: " + valPar);








            Console.ReadKey();

        }
    }
}
