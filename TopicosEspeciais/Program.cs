using System;
using System.Globalization;

namespace TopicosEspeciais
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // com 'var' o tipo é inferido quando a variável for iniciada
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            //o inconveniente é que pode se perder e o compilador não consegue ajudar porque é tudo var

            // switch case:
            /* int dia = int.Parse(Console.ReadLine());



             switch (dia)
             {
                 case 1:
                     Console.WriteLine("Segunda-feira");
                     break;

                 case 2:
                     Console.WriteLine("Terça-feira");
                     break;


                 case 3:
                     Console.WriteLine("Quarta-feira");
                     break;

                 case 4:
                     Console.WriteLine("Quinta-feira");
                     break;

                 case 5:
                     Console.WriteLine("Sexta-feira");
                     break;

                 case 6:
                     Console.WriteLine("Sábado");
                     break;

                 case 7:
                     Console.WriteLine("Domingo");
                     break;


                     default:
                     Console.WriteLine("Dia não encontrado");
                     break;



             } */

            //expressão ternária, opcional ao if else quando se deseja decidir um valor (condição) ?   valor se verdadeiro : valor se falso
            //double preco = double.Parse(Console.ReadLine());

            //com a expressão ternária assim:

            //double desconto =   (preco < 20) ? preco * 0.1 : preco * 0.05;
            //Console.WriteLine(desconto);


            /*Com o if ficaria assim: 
            
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
               
            }

            else
            {
                desconto = preco * 0.05;
            } 
            */

            /*
            string original = "abcde FGHIJ ABC abc DEFG ";
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");
            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");
            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2); */

            /*
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); //número que a memória guarda da data e horário gerada
            */

            DateTime d1 = DateTime.Now;
            string s1 = d1.ToLongDateString();             
            Console.WriteLine(s1);

            //por padrão deve-se armazenar em formato UTC, porém deve-se instanciar e mostrar em formato local

            DateTime d2 = new DateTime(2021, 01, 14, 11, 14, 58, DateTimeKind.Local);
            DateTime d3 = new DateTime(2021, 01, 14, 11, 14, 58, DateTimeKind.Utc);

            Console.WriteLine(d2.ToUniversalTime());
            Console.WriteLine(d3);
            Console.WriteLine("Bom dia!");
        }
    }
}