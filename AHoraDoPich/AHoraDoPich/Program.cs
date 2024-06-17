using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHoraDoPich
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alarme alarme = new Alarme();

            String resposta = "S";
            while (resposta != "N") 
            {
                Console.Clear();
                Console.WriteLine("A Hora Do Pich");
                Console.Write("Informe a Duração do Pich: ");
                int tempo = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Informe o efeito sonoro (1 até 500): ");
                int efeitoSonoro = Convert.ToInt32(Console.ReadLine());

                //alarme.EfeitoSonoro = efeitoSonoro;
                alarme = new Alarme(tempo, efeitoSonoro);
                alarme.Tempo = tempo;

                alarme.IniciarMario();
                Console.WriteLine("Que pena o seu tempo acabou !!! ");
                Console.WriteLine("Executar o programa novamente ?: S/N ");
                resposta = Console.ReadLine().ToUpper();
            }

           
        }
    }
}
