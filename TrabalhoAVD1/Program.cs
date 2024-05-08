using System;

public class Aluno
{

    public void Matricular(string nome, int idade, string curso)
    {
        string Nome = nome;
        int Idade = idade;
        string Curso = curso;

        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($" -- > {Nome} de {Idade} anos, está matriculado no curso de {Curso}.");
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------------------------------------------");

    }
}

public class Turma
{
    public void TurmaSala(string nome, string professor)
    {
        string Nome = nome;
        string Professor = professor;

        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($" -- > {Nome} da Unifoa,com o professor {Professor}.");
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------------------------------------------");

    }
}

public class Professor
{
    internal string Nome;

    public void EmAula(string nome)
    {
        string Nome = nome;

        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"-- > O professor em sala de aula é {Nome}");
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------------------------------------------");

    }
}
class Program
    {
        static void Main(string[] args)
        {
        Professor prof = new Professor();
        prof.Nome = "Rosenclever";


        Turma turma = new Turma();
            turma.TurmaSala("5° Periodo", "Rosenclever");


        Aluno estudante = new Aluno();
        estudante.Matricular("Henrique", 20, "Sistema de Informação");

        prof.EmAula(prof.Nome);
    }
    }

