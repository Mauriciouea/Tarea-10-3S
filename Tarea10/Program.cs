using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Crear conjunto ficticio de 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();

        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // 2. Crear conjunto de vacunados con Pfizer (75)
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // 3. Crear conjunto de vacunados con AstraZeneca (75)
        HashSet<string> astrazeneca = new HashSet<string>();
        for (int i = 50; i < 125; i++) // Algunos repetidos para simular doble dosis
        {
            astrazeneca.Add("Ciudadano " + i);
        }

        // 4. Operaciones de conjuntos

        // Ciudadanos vacunados con ambas dosis
        var ambasDosis = pfizer.Intersect(astrazeneca);

        // Ciudadanos solo Pfizer
        var soloPfizer = pfizer.Except(astrazeneca);

        // Ciudadanos solo AstraZeneca
        var soloAstra = astrazeneca.Except(pfizer);

        // Ciudadanos vacunados (al menos una dosis)
        var vacunados = pfizer.Union(astrazeneca);

        // Ciudadanos no vacunados
        var noVacunados = ciudadanos.Except(vacunados);

        // 5. Mostrar resultados
        Console.WriteLine("Total ciudadanos: " + ciudadanos.Count);
        Console.WriteLine("Vacunados Pfizer: " + pfizer.Count);
        Console.WriteLine("Vacunados AstraZeneca: " + astrazeneca.Count);
        Console.WriteLine();

        Console.WriteLine("Ciudadanos con ambas dosis: " + ambasDosis.Count());
        Console.WriteLine("Ciudadanos solo Pfizer: " + soloPfizer.Count());
        Console.WriteLine("Ciudadanos solo AstraZeneca: " + soloAstra.Count());
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count());

        Console.WriteLine("\nEjemplo de ciudadanos no vacunados:");
        foreach (var c in noVacunados.Take(10))
        {
            Console.WriteLine(c);
        }
    }
}
