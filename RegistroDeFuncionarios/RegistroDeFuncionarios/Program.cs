using System;
using System.Globalization;
using System.Collections.Generic;

namespace empresa { 
class Programa
{
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionarios serão registrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionario #{i}:");
                Console.Write($"Id: {i}");
                int id = i;
                Console.WriteLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double sal = double.Parse(Console.ReadLine());
                list.Add(new Funcionarios(id, nome, sal));
                Console.WriteLine();
            }
            Console.WriteLine("Algum funcionario recebera aumento?");
            Console.WriteLine("Digite 1 para sim e 0 para não");
            int verificar = int.Parse(Console.ReadLine());
            if(verificar == 1)
            {
                Console.WriteLine("Insira o ID do funcionario que recebera um aumento: ");
                int ProcurarId = int.Parse(Console.ReadLine());

                Funcionarios func = list.Find(x => x.Id == ProcurarId);
                if (func != null)
                {
                    Console.Write("Insira a porcentagem: ");
                    double porcentagem = double.Parse(Console.ReadLine());
                    func.Aumento(porcentagem);
                }
                else { Console.WriteLine("digite um Id valido"); }
                Console.WriteLine();
                Console.WriteLine("Lista de funcionarios atualizada:");
                foreach (Funcionarios obj in list)
                {
                    Console.WriteLine($"Id: {obj.Id} \nNome: {obj.Nome} \nSalario: {obj.Sal}");
                }
            }else if(verificar == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Lista de funcionarios:");
                foreach (Funcionarios obj in list)
                {
                    Console.WriteLine($"Id: {obj.Id} \nNome: {obj.Nome} \nSalario: {obj.Sal}");
                }
            }
            else {
                while (verificar != 1 || verificar != 0) { 
                    Console.WriteLine("Insira um valor valido");
                    Console.WriteLine("Digite 1 para sim e 0 para não");
                    verificar = int.Parse(Console.ReadLine());
                    if (verificar == 1)
                    {
                        Console.WriteLine("Insira o ID do funcionario que recebera um aumento: ");
                        int ProcurarId = int.Parse(Console.ReadLine());
                        Funcionarios func = list.Find(x => x.Id == ProcurarId);
                        if (func != null)
                        {
                            Console.Write("Insira a porcentagem: ");
                            double porcentagem = double.Parse(Console.ReadLine());
                            func.Aumento(porcentagem);
                        }
                        else { Console.WriteLine("digite um Id valido"); }
                        Console.WriteLine();
                        Console.WriteLine("Lista de funcionarios atualizada:");
                        foreach (Funcionarios obj in list)
                        {
                            Console.WriteLine($"Id: {obj.Id} \nNome: {obj.Nome} \nSalario: {obj.Sal}");
                        }
                        break;
                    }
                    else if (verificar == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lista de funcionarios:");
                        foreach (Funcionarios obj in list)
                        {
                            Console.WriteLine($"Id: {obj.Id} \nNome: {obj.Nome} \nSalario: {obj.Sal}");
                        }
                        break;
                    }
                }
            }
        }
    }
}