using System;

namespace _Alunos
{
    class Program
    {
        static void Main(string[] args)
        {   

                /* 
                Faça um programa que receba o nome e quatro notas de 10 alunso e armazene essas notas em bertores. Calcule e mostre:
                
                A. A média do aluno - Função
                B. A quantidade de Aprivados (Média >= 7)
                C. A quantidade de Reprovados (Média < 7)
                D. A média geral dos 10 Alunos. 
                */


                int qa = 10;
                
                string [] nome = new string [qa];
                string [] situacao = new string [qa];
                double [] nt1 = new double [qa];
                double [] nt2 = new double [qa];
                double [] nt3 = new double [qa];
                double [] nt4 = new double [qa];
                double [] media = new double [qa];
                int cr = 0;
                int ca = 0;
                double mediat = 0;
                double mediast = 0;

                for (int i = 0; i < qa ; i++) 
                {
                    
                    Console.WriteLine($"Qual o nome do {i}º aluno: ");
                    nome [i] = Console.ReadLine();
                
                    Console.WriteLine($"Qual A 1º nota do {i}º aluno: ");
                    nt1 [i] = double.Parse( Console.ReadLine() );

                    Console.WriteLine($"Qual a 2º nota do {i}º aluno: ");
                    nt2 [i] = double.Parse( Console.ReadLine() );

                    Console.WriteLine($"Qual a 3º nota do {i}º aluno: ");
                    nt3 [i] = double.Parse( Console.ReadLine() );

                    Console.WriteLine($"Qual a 4º nota do {i}º aluno: ");
                    nt4 [i] = double.Parse( Console.ReadLine() );

                    media [i] = (nt1[i] + nt2[i] + nt3[i] + nt4[i]) / 4;

                    if (media[i] < 7) {

                        cr = cr + 1;
                        situacao [i] = "Reprovado";

                    };
                    
                    if (media[i] >=7) {

                        ca = ca + 1;
                        situacao [i] = "Aprovado";
                        
                    };
                };

                    string read = "";

                    Console.Write("Deseja Visualizar? (enter)");

                    while( read == "")  {
                
                    for (var c = 0; c < qa; c++){

                        Console.WriteLine($"Infos do {c}º aluno ");
                        Console.WriteLine($"Nome: {nome[c]} ");
                        Console.WriteLine($"Nota1: {nt1[c]} ");
                        Console.WriteLine($"Nota2: {nt2[c]} ");
                        Console.WriteLine($"Nota3: {nt3[c]} ");
                        Console.WriteLine($"Nota4: {nt4[c]} ");
                        Console.WriteLine($"Média: {media[c]} ");
                        Console.WriteLine($"Situação: {situacao[c]} ");

                        mediast = media[c] + mediast;
                        mediat = mediast / 10;
                        
                    };

                    Console.WriteLine($"=================================");
                    Console.WriteLine($"Total de alunos Aprovados: {ca}");
                    Console.WriteLine($"Total de alunos Reprovados: {cr}");
                    Console.WriteLine($"Média dos alunos: {mediat}");
                    
                    Console.Write("Deseja Visualizar novamente? (enter)");
                    read = Console.ReadLine();

            }
        }
    }
}
