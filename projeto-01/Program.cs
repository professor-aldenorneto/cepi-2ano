using System;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Runtime.Serialization;

namespace primeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            sbyte n1 = 127;
            Console.WriteLine(n1);

            float n2 = 4.0f; //por padrao do tipo de dado utilizar um F ao Final
            double n3 = 4.0;
            Console.WriteLine(n2);
            Console.WriteLine(n3);

            byte n4 = 255;
            Console.WriteLine(n4);

            int n5 = 1000;
            int n6 = int.MaxValue;
            Console.WriteLine(n5);
            Console.WriteLine(n6);

            long n7 = 2147483648L; //padrao do tipo de dado utilizar um L ao final
            Console.WriteLine(n7);

            bool completo = false;
            char genero = 'M';
            char letra = '\u0264';
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);

            string nome = "Maria";
            Console.WriteLine(nome);

            object obj1 = "Aldenor neto";
            object obj2 = 3.14;

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            int idade = 32;
            double saldo = 10.35784;
            string nomeM = "Maria";

            Console.WriteLine("dfjkdjkjfkdh" + saldo.ToString("F2", CultureInfo.InvariantCulture) + "sjhjhsbf");
            
            
            int a1 = 10 / 2;//Declaração de variavel 
            //a1 += 1;
            //a1 -= 1;
            //a1 /= 2;
            // a1 %= 3;
            //a1++;
            //a1--;
            //int b1 = ++a1;
            //int b2 = --a1;

            int b2 = (3 + 4) * (2-1);
           
            Console.WriteLine(a1);
            Console.WriteLine(b2);

            string t1 = "ABC";
            t1 += "DEF";
            Console.WriteLine(t1);

            // Formula de bhaskara <-----
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // <- primeiro passo achar o DELTA
            double x1 = (-b +Math.Sqrt(delta)) / (2.0*a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            
            //------ Conversões ---//
            float c = 4.5f;
            double d = c;
            Console.WriteLine(d);

            double d2 = 4.5;
            float c2 = (float)d2;
            Console.WriteLine(c2);

            double d3 = 2.0;
            int c3;

            c3 = (int)d3;
            Console.WriteLine(c3);

            int x = 5, y = 2;

            double resultado = (double) x / y;
            Console.WriteLine(resultado); //<- SAIDA DE DADOS
            
            //-------------
            
            string frase = Console.ReadLine(); //<- ENTRADA DE DADOS
            //Console.WriteLine("Voce Digitou: " +frase);
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            //string s = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("Voce Digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a +b +c);
            
            string[] vet2 = Console.ReadLine().Split(' ');
            string p1 = vet2[0];
            string p2 = vet2[1];
            string p3 = vet2[2];
            Console.WriteLine(p1 + " " +p2 +" "+p3);
            

            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Voce Digitou:");
            Console.WriteLine(n1);
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Voce Digitou: "+ch);
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Voce Digitou: " + n2);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
                       
            string[] vet3 = Console.ReadLine().Split(' ');
            string nome = vet3[0];
            char sexo = char.Parse(vet3[1]);
            int idade = int.Parse(vet3[2]);
            double altura= double.Parse(vet3[3]);
            Console.WriteLine("---------------------");
            Console.WriteLine("Voce digitou:");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            //------------------------------EXERCICIO 02 PARA FIXAÇÃO
            //Console.WriteLine ("'); <-- COMANDO PARA EXIBIR NA TELA
            //Console.ReadLine(); <-- COMANDO PARA LER/CAPTURAR O QUE DIGITA NA TELA
           
            //PRIMEIRA PERGUNTA
            Console.WriteLine("Entre com seu nome Completo: ");
            string nomecompleto = Console.ReadLine();
            //SEGUNDA PERGUNTA
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            //TERCEIRA PERGUNTA
            Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine());
            //QUARTA PERGUNTA
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma Linha) ");
            string[] vetor1 = Console.ReadLine().Split(',');
            string sobrenome = vetor1[0];
            int idade1 = int.Parse(vetor1[1]);
            double altura1 = double.Parse(vetor1[2]);
            Console.WriteLine("-------------------");
            Console.WriteLine(sobrenome + " " + idade1 +" " + altura1 +" ");

            //----------------------------exercicio teste----------------------------------
            double largura, comprimento, precoMetroQuadrado, area, preco;
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preco = area * precoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
            
            //------------------------- Operadores Comparativos
            int a = 10;
            bool c1 = a < 10;//false
            bool c2 = a < 20;//true
            bool c3 = a > 10;//false
            bool c4 = a > 5;//true
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("---------------------");
            bool c5 = a <= 10; //true
            bool c6 = a >= 10; //true
            bool c7 = a == 10; //true
            bool c8 = a != 10; //false
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
          
            //------------------------- Operadores Logicos
            bool d1 = 2 > 3 || 4 != 5; //true
            bool d2 = !(2 > 3) && 4 != 5; // true
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine("--------------");
            
            bool d3 = 10 < 5;  //false
            bool d4 = d1 || d2 && d3; // true
            Console.WriteLine(d3);
            Console.WriteLine(d4);
          
            int x = 10;
            //Console.WriteLine("Bom dia!");
            if (x < 5)
            { 
                Console.WriteLine("Boa tarde!"); 
            }            
            Console.WriteLine("Boa Noite!");
            //-----------------Descobrir se o numero e par ou impar--------------
            Console.WriteLine("Entre com um numero inteiro: ");
            int y = int.Parse(Console.ReadLine());
            if (y % 2 == 0)
            { Console.WriteLine("Numero PAR"); }
            else
            { Console.WriteLine("Numero IMPAR"); }
            //-----------------Verificar se é Bom dia, Boa tarde ou boa noite -----
            
            Console.WriteLine("Qual Hora Atual? ");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            { Console.WriteLine("Bom dia"); }
            else if (hora >= 12 && hora < 18)
            { Console.WriteLine("Boa Tarde!"); }
            else
            { Console.WriteLine("Boa Noite!"); }
            //---------------------- ESCOPO/INICIALIZAÇÃO --------------
            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;
            if (preco > 100.0)
            {
                desconto = preco * 0.1;
            }
            Console.WriteLine(desconto);
            //----------------EXEMPLO DE EXERCICIO ----------------
            double n1, n2, soma;
            Console.WriteLine("Digite a Nota 01: ");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a Nota 02: ");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = n1 + n2;
            if (soma < 60.0)
            { Console.WriteLine("Reprovado"); }
            ;
            Console.ReadLine();
            //----------------EXEMPLO DE EXERCICIO 2 --------------
            int w, e, r;
            string[] quadrado = Console.ReadLine().Split(',');
            w = int.Parse(quadrado[0]);
            e = int.Parse(quadrado[1]);
            r = int.Parse(quadrado[2]);
            if (w < e && w < r)
            { Console.WriteLine("MENOR = " + w); }
            else if (e < r)
            { Console.WriteLine("MENOR = " + e); }
            else
            { Console.WriteLine("MENOR = " + r); };
            
            //---------------- FUNÇÕES -------------
            
            //------- Exemplo de while --------
            Console.WriteLine("começe com uma palavra: ");
            int n = int.Parse(Console.ReadLine()); 

            while (n < 100)
            {
                Console.WriteLine("Digite uma palavra aqui: ");
                n = int.Parse(Console.ReadLine());
            }         
            
            //------------- FOR / PARA

            Console.Write("Quantos numeros inteiros você quer somar: ");
            int numeroInteiro = int.Parse(Console.ReadLine());

            int soma=0;

            for (int i = 1; i <= numeroInteiro; i++)
            {
                //Console.WriteLine("oi");
                Console.WriteLine("Valor : #{0}", i);
                int valor = int.Parse(Console.ReadLine());
                //soma = soma + valor; 
                soma += valor;
            }
            Console.WriteLine("SOMA = "+ soma);
           
            //--(teste seu conhecimento) Leia um valor inteiro x (1 <=x <= 1000). em seguida mostre os impares de 1 ate x,
            //--um valor por linha,inclusive o x se for o caso.
            Console.Write("Digite um numero inteiro: ");
            int impar = int.Parse(Console.ReadLine());
            for (int i = 1; i <= impar; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
             */
            //Exercicio (formula de heron) - Sem usar Orientação a objetos
            /*
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));//Função matematica raiz > math.Sqrt
            
            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));//Função matematica raiz > math.Sqrt

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) 
            {                Console.WriteLine("Maior Área X");     }
            else { Console.WriteLine("Maior Área Y"); };
           
            Triangulo x, y;

            x= new Triangulo();
            y= new Triangulo();

            Console.WriteLine("Entre com as medidas do X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        
            double areaX = x.Area();//Função matematica raiz > math.Sqrt

            double areaY = y.Area();//Função matematica raiz > math.Sqrt

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            { Console.WriteLine("Maior Área X"); }
            else { Console.WriteLine("Maior Área Y"); }
            ;
            //-- Turma B parou aqui
             */
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);





        }
    }
}
