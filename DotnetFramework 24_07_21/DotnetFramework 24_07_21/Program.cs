using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetFramework_24_07_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Danilo, por favor, digite o nome do primeiro aluno:\n");
            string aluno1 = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("Digite a primeira nota do(a) " + aluno1);
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do(a) " + aluno1);
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota do(a) " + aluno1);
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Danilo, por favor, digite o nome do segundo aluno:\n");
            string aluno2 = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota do(a) " + aluno2);
            double nota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do(a) " + aluno2);
            double nota5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota do(a) " + aluno2);
            double nota6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Danilo, por favor, digite o nome do terceiro aluno:\n");
            string aluno3 = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota do(a) " + aluno3);
            double nota7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do(a) " + aluno3);
            double nota8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota do(a) " + aluno3);
            double nota9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Danilo, por favor, digite o nome do quarto aluno:\n");
            string aluno4 = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota do(a) " + aluno4);
            double nota10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do(a) " + aluno4);
            double nota11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota do(a) " + aluno4);
            double nota12 = Convert.ToDouble(Console.ReadLine());
            double soma1 = nota1 + nota2 + nota3;
            double média1 = soma1 / 3;
            double soma2 = nota4 + nota5 + nota6;
            double média2 = soma2 / 3;
            double soma3 = nota7 + nota8 + nota9;
            double média3 = soma3 / 3;
            double soma4 = nota10 + nota11 + nota12;
            double média4 = soma4 / 3;
            Console.WriteLine("A média das três notas do(a) " + aluno1);
            Console.WriteLine("é:" + média1);
            Console.WriteLine("A média das três notas do(a) " + aluno2);
            Console.WriteLine("é:" + média2);
            Console.WriteLine("A média das três notas do(a) " + aluno3);
            Console.WriteLine("é:" + média3);
            Console.WriteLine("A média das três notas do(a) " + aluno4);
            Console.WriteLine("é:" + média4);
            Console.Read();
        }
    }
}
