// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("Hello, World!");

    Console.WriteLine("Menu d'action :");
    Console.WriteLine("1- Donner la date du jour");
    Console.WriteLine("2- Effectuer le calcul 3+3");
    Console.WriteLine("3- Quitter le programme");
    Console.WriteLine("Veuillez choisir une option :");
    var inputKey = Console.ReadKey();

// Console.WriteLine(inputKey.KeyChar == 1
//     ? "Vous avez cliqué sur la touche 1"
//     : "Vous avez cliqué sur une touche autre que 1");

    Console.WriteLine(inputKey.KeyChar == '1'
        ? "Vous avez cliqué sur la touche 1"
        : inputKey.KeyChar == '2'
            ? "Vous avez cliqué sur la touche 2"
            : inputKey.KeyChar == '3'
                ? "Vous avez cliqué sur la touche 3"
                : "Vous avez cliqué sur une touche autre que 1 ou 2 ou 3"
    );

    if (inputKey.KeyChar == '3')
    {
        // break;
        Environment.Exit(0);
    }

// Console.WriteLine(inputKey.KeyChar switch
//     {
//         '1' => "Vous avez cliqué sur la touche 1",
//         '2' => "Vous avez cliqué sur la touche 2",
//         '3' => "Vous avez cliqué sur la touche 3",
//         _ => "Vous avez cliqué sur une touche autre que 1 ou 2 ou 3"
//     }
// );

// if ((inputKey.KeyChar == 1 || inputKey.KeyChar == 2) && inputKey.KeyChar != 3)
// {
//     Console.WriteLine("Entrée correcte");
// }
//
// if ((inputKey.KeyChar == 1) || (inputKey.KeyChar == 2) && (inputKey.KeyChar != 3))
// {
//     Console.WriteLine("Entrée correcte");
// }

    Console.WriteLine("Ceci est la fin du programme");
}