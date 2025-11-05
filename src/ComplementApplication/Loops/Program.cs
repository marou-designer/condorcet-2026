// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
// index-based
var integers = new List<int>
{
    1,
    45,
    23,
    155,
    355,
    3,
    12
};

PrintForEach();
// PrintForI();
// PrintWhile();
// PrintWhileSecure();
// PrintWhileWithInfiniteLoop();

void PrintForEach()
{
    int i = 0;
    // LINQ
    // foreach (int integer in integers.OrderBy(x => x))
    foreach (int integer in integers)
    {
        // Console.WriteLine("L'élément à la position " + (i + 1) + " est " + integers[i]);
        Console.WriteLine("L'élément actuel est " + integer);

        if (integer == 155)
            break;

        i++;
    }
}

// for-loop
void PrintForI()
{
    // for (int i = 0; i < integers.Count; i++)
    // {
    //     Console.WriteLine("L'élément à la position " + (i + 1) + " est " + integers[i]);
    //     // fin de l'itération => déclenchement de i++
    // }
    
    // for (int i = integers.Count - 1; i != -1; i--)
    for (int i = integers.Count - 1; i >= 0; i--)
    {
        if (i == 2)
            continue;
        
        Console.WriteLine("L'élément à la position " + (i + 1) + " est " + integers[i]);
        // fin de l'itération => déclenchement de i--

        if (i == 4)
            // return; // exit whole method or function
            break; // exit current loop
        else
            continue;
    }
    
    Console.WriteLine("Fin de la boucle");
}

void PrintWhileSecure()
{
    int i = 0;
    while (i <= 100)
    {
        i++;
        i++;
        i++;
        Console.WriteLine("Mon nombre est " + i);
    }

    Console.WriteLine("Ma boucle est terminée");
}

void PrintWhile()
{
    int i = 0;
    while (i != 100)
    {
        i++;
        i++;
        i++;
        Console.WriteLine("Mon nombre est " + i);
    }

    Console.WriteLine("Ma boucle est terminée");
}

void PrintWhileWithInfiniteLoop()
{
    int i = 0;
    while (true)
    {
        i++;
        // i++;
        // i++;
        Console.WriteLine("Mon nombre est " + i);
        if (i == 100)
        {
            break;
        }
    }

    Console.WriteLine("Ma boucle est terminée");
}