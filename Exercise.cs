using System;
using System.Globalization;

namespace Atividades_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";

            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;

            //Console.WriteLine($"Produtos: ");
            //Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");
            //Console.WriteLine($"{produto2}, cujo preço é $ {preco2}");
            //Console.WriteLine();
            //Console.WriteLine($"Registro : {idade} anos de idade, código {codigo} e gênero: {genero}");

            /*--------------------------------------------------------------------------------------------------------------------------------------*/
            //int nmr1 = 10;
            //int nmr2 = 30;
            //int soma = 0;

            //soma = nmr1 + nmr2;

            //Console.WriteLine($"Soma: {soma}");

            //int nmr3 = -30;
            //int nmr4 = 10;
            //int soma2 = nmr3 + nmr4;

            //Console.WriteLine($"Soma: {soma2}");

            //int nmr5 = 0;
            //int nmr6 = 0;
            //int soma3 = nmr5 + nmr6;

            //Console.WriteLine($"Soma: {soma3}");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //double pi = 3.14159;

            //Console.WriteLine("Informe o raio: ");
            //double raio = double.Parse(Console.ReadLine());

            //double areaCirculo = pi * (raio + raio);

            //Console.WriteLine($"Área do circulo: {areaCirculo.ToString("F4")}");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite um valor para A: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um valor para B: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um valor para C: ");
            //int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um valor para D: ");
            //int d = int.Parse(Console.ReadLine());

            //int diferenca = (a * b) - (c * d);

            //Console.WriteLine($"Diferença: {diferenca}");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite o numero do funcionário: ");
            //int nmrFuncionario = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o numero de horas trabalhadas: ");
            //int nmrHoraTrabalhada = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor da hora trabalhada: ");
            //double valorHora = double.Parse(Console.ReadLine());
            //double salario = nmrHoraTrabalhada * valorHora;
            //Console.WriteLine($"Numero: {nmrFuncionario}");
            //Console.WriteLine($"Salário: {salario.ToString("F2")}");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite o codigo da peça: ");
            //int codigoPeca1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de peças que você deseja: ");
            //int nmrPeca1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor da(s) peça(s): ");
            //double valorPeca1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o código da segunda peça: ");
            //int codigoPeca2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade de peças que você deseja: ");
            //int nmrPeca2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digete o valor da(s) peça(s): ");
            //double valorPeca2 = double.Parse(Console.ReadLine());

            //double valorPagar = (nmrPeca1 * valorPeca1) + (nmrPeca2 * valorPeca2);
            //Console.WriteLine($"Valor a pagar: {valorPagar.ToString("F2")}");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite o valor A: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor B: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor C: ");
            //double c = double.Parse(Console.ReadLine());

            //double pi = 3.14159;
            //double areaTriangulo = (a * c) / 2;
            //double areaCirculo = pi * (c * c);
            //double areaTrapezio = (a + b) / 2 * c;
            //double areaQuadrado = b * b;
            //double areaRetangulo = a * b;

            //Console.WriteLine($"Resultado da Área do triangulo: {areaTriangulo.ToString("F3")}");
            //Console.WriteLine($"Resultado da Área do circulo: {areaCirculo.ToString("F3")}");
            //Console.WriteLine($"Resultado da Área do trapezio: {areaTrapezio.ToString("F3")}");
            //Console.WriteLine($"Resultado da Área do quadrado: {areaQuadrado.ToString("F3")}");
            //Console.WriteLine($"Resultado da Área do retangulo: {areaRetangulo.ToString("F3")}");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite um numero: ");
            //int nmr = int.Parse(Console.ReadLine());

            //if(nmr < 0)
            //    Console.WriteLine("Negativo");
            //else
            //    Console.WriteLine("Não negativo");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite um numero: ");
            //int nmr = int.Parse(Console.ReadLine());

            //if(nmr % 2 == 0)
            //    Console.WriteLine("Par");
            //else
            //    Console.WriteLine("Impar");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite um numero: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um numero: ");
            //int b = int.Parse(Console.ReadLine());

            //if(a % b == 0 || b % a == 0)
            //    Console.WriteLine("São multiplos");
            //else
            //    Console.WriteLine("Não são multiplos");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite a hora de inicio da partida");
            //int horaInicio = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a hora do fim da partida");
            //int horaFim = int.Parse(Console.ReadLine());

            //int dia = 24;
            //int horas;
            //if(horaInicio < horaFim)
            //{
            //    horas = horaFim - horaInicio;
            //}
            //else
            //{
            //    horas = dia - horaInicio + horaFim;
            //}

            //Console.WriteLine($"A duração do jogo foi de {horas} horas");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite o código do produto: ");
            //int codigo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade que você deseja: ");
            //int quantidade = int.Parse(Console.ReadLine());
            //double valor = 0;
            //if(codigo == 1)
            //{
            //    valor = 4 * quantidade;
            //}
            //else if(codigo == 2)
            //{
            //    valor = 4.5 * quantidade;
            //}
            //else if(codigo == 3)
            //{
            //    valor = 5 * quantidade;
            //}
            //else if(codigo == 4)
            //{
            //    valor = 2 * quantidade;
            //}
            //else
            //{
            //    valor = 1.5 * quantidade;
            //}
            //Console.WriteLine($"Valor da compra: R${valor.ToString("F2")}");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite um valor: ");
            //double valor = double.Parse(Console.ReadLine());
            //if(valor >= 0 && valor <= 25)
            //{
            //    Console.WriteLine("Valor entre 0 e 25");
            //}
            //else if(valor >= 25 && valor <= 50)
            //{
            //    Console.WriteLine("Valor entre 25 e 50");
            //}
            //else if(valor >= 50 && valor <= 75)
            //{
            //    Console.WriteLine("Valor entre 50 e 75");
            //}
            //else if(valor >= 75 && valor <= 100)
            //{
            //    Console.WriteLine("Valor entre 75 e 100");
            //}
            //else
            //{
            //    Console.WriteLine("Fora de intervalo");
            //}
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite o valor de X : ");
            //double x = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor de Y : ");
            //double y = double.Parse(Console.ReadLine());

            //if(x > 0 && y > 0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else if(x < 0 && y > 0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if(x < 0 && y < 0)
            //{
            //    Console.WriteLine("Q3");
            //}
            //else if(x > 0 && y < 0)
            //{
            //    Console.WriteLine("Q4");
            //}
            //else
            //{
            //    Console.WriteLine("Origem");
            //}
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite seu salário em Lisarb: ");
            //double salario = double.Parse(Console.ReadLine());
            //double imposto = 0;
            //if(salario >= 0 && salario <= 2000)
            //{
            //    Console.WriteLine("Isento");
            //}
            //else if(salario > 2000 && salario <= 3000)
            //{
            //    imposto = (salario - 2000)* 0.08;
            //    Console.WriteLine($"R$ {imposto.ToString("F2")}");
            //}
            //else if(salario > 3000 && salario <= 4500)
            //{
            //    imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            //    Console.WriteLine($"R$ {imposto.ToString("F2")}");
            //}
            //else
            //{
            //    imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            //    Console.WriteLine($"R$ {imposto.ToString("F2")}");
            //}
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite a senha: ");
            //int senha = int.Parse(Console.ReadLine());

            //while(senha != 2002)
            //{
            //     Console.WriteLine("Senha inválida");
            //    senha = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Acesso permitido");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite o valor de X: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor de Y: ");
            //double y = double.Parse(Console.ReadLine());

            //while(x != 0 || y != 0)
            //{
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("Q1");
            //    }
            //    else if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("Q2");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("Q3");
            //    }
            //    else if (x > 0 && y < 0)
            //    {
            //        Console.WriteLine("Q4");
            //    }
            //    Console.WriteLine("Digite o valor de X: ");
            //    x = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o valor de Y: ");
            //    y = double.Parse(Console.ReadLine());
            //}
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite um codigo: ");
            //int codigo = int.Parse(Console.ReadLine());
            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;
            //while(codigo != 4)
            //{
            //    if(codigo == 1)
            //    {
            //        alcool++;
            //    }
            //    else if(codigo == 2)
            //    {
            //        gasolina++;
            //    }
            //    else if(codigo == 3)
            //    {
            //        diesel++;
            //    }
            //    codigo = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Muito Obrigado!");
            //Console.WriteLine($"Alcool: {alcool}");
            //Console.WriteLine($"Gasolina: {gasolina}");
            //Console.WriteLine($"Diesel: {diesel}");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite um valor: ");
            //int valor = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= valor; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite a quantidade de valores: ");
            //int valor = int.Parse(Console.ReadLine());
            //int dentro = 0;
            //int fora = 0;
            //for (int i = 0; i < valor; i++)
            //{
            //    Console.WriteLine("Digite um numero: ");
            //    int x = int.Parse(Console.ReadLine());
            //    if (x >= 10 && x <= 20)
            //        dentro++;

            //    else
            //        fora++;

            //}
            //Console.WriteLine($"{dentro} in");
            //Console.WriteLine($"{fora} out");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //int valor = int.Parse(Console.ReadLine());

            //for (int i = 0; i < valor; i++)
            //{
            //    Console.WriteLine("Digite o primeiro peso: ");
            //    double peso1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o segundo peso: ");
            //    double peso2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o terceiro peso: ");
            //    double peso3 = double.Parse(Console.ReadLine());

            //    double mediaPonderada = (peso1 * 2 + peso2 * 3 + peso3 * 5) / 10;

            //    Console.WriteLine(mediaPonderada.ToString("F1"));
            //}
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite um número: ");
            //int valor = int.Parse(Console.ReadLine());
            //int nmr1 = 0;
            //int nmr2 = 0;
            //int calculo = nmr1 / nmr2
            //for (int i = 0; i < valor; i++)
            //{
            //    Console.WriteLine("Digite um numero para divisão: ");
            //    nmr1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite outro numero para divisão: ");
            //    nmr2 = int.Parse(Console.ReadLine());
            //    if (nmr2 == 0)
            //        Console.WriteLine("Divisão impossivel");
            //}
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine($"Digite um valor: ");
            //int valor = int.Parse(Console.ReadLine());
            //int fatorial = 1;
            //for (int i = 1; i <= valor; i++)
            //{
            //    fatorial = fatorial * i;
            //}
            //Console.WriteLine($"Resultado: {fatorial} ");
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite um numero : ");
            //int nmr = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= nmr; i++)
            //{
            //    if(nmr % i == 0)
            //    {
            //        nmr = nmr / i;
            //        Console.WriteLine(nmr);
            //    }
            //}
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/
            //Console.WriteLine("Digite um numero positivo: ");
            //int nmr = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= nmr; i++)
            //{
            //    int linha = i;
            //    int quadrado = i * i;
            //    int cubo = i * i * i;
            //    Console.WriteLine($"{linha}, {quadrado}, {cubo}");
            //}
            /*--------------------------------------------------------------------------------------------------------------------------------------------*/

        }
    }
}

