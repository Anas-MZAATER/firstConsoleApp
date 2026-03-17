using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Dictionary<string, Action> exercices = new Dictionary<string, Action>()
        {
            { "somme", Somme },
            { "division", Division },
            { "permutation", Permutation },
            { "triangle", Triangle },
            { "binaire", Binaire }
        };

            Console.WriteLine("Méthodes disponibles :");
            foreach (var key in exercices.Keys)
            {
                Console.WriteLine("- " + key);
            }

            Console.Write("\nChoix : ");
            string choix = Console.ReadLine().ToLower();

            if (exercices.ContainsKey(choix))
            {
                exercices[choix]();
            }
            else
            {
                Console.WriteLine("Méthode non trouvée !");
            }
        }
    }

    static void Somme()
    {
        Console.Write("Entrez a : ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Entrez b : ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Somme = " + (a + b));
    }

    static void Division()
    {
        Console.Write("Entrez a : ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Entrez b : ");
        double b = double.Parse(Console.ReadLine());

        if (b != 0)
            Console.WriteLine("Résultat = " + (a / b));
        else
            Console.WriteLine("Division par zéro !");
    }

    static void Permutation()
    {
        Console.Write("Entrez a : ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Entrez b : ");
        int b = int.Parse(Console.ReadLine());

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"Après permutation : a={a}, b={b}");
    }

    static void Triangle()
    {
        Console.Write("Entrez le nombre : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Entrez la largeur : ");
        int largeur = int.Parse(Console.ReadLine());

        for (int i = 1; i <= largeur; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write(n);
            Console.WriteLine();
        }
    }

    static void Binaire()
    {
        Console.Write("Entrez un nombre : ");
        int nombre = int.Parse(Console.ReadLine());

        Console.WriteLine("Binaire = " + Convert.ToString(nombre, 2));
    }
}