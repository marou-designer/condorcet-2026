// // See https://aka.ms/new-console-template for more information
//
// Console.WriteLine("Hello, World!");
//
// // Console.WriteLine("Veuillez saisir un texte :");
// // var input = Console.ReadLine();
// // Console.WriteLine("L'utilisateur a saisi : " + input);
//
// Console.WriteLine("Menu d'action :");
// Console.WriteLine("1- Donner la date du jour");
// Console.WriteLine("2- Effectuer le calcul 3+3");
// Console.WriteLine("3- Quitter le programme");
// Console.WriteLine("Veuillez choisir une option :");
// var inputKey = Console.ReadKey();
//
// if (inputKey.KeyChar == '1')
// {
//     Console.WriteLine("Vous avez cliqué sur " + inputKey.KeyChar);
//     Console.WriteLine("La date du jour est " + DateTime.Now);
// }
// else
// {
//     if (inputKey.KeyChar == '2')
//     {
//         Console.WriteLine("Vous avez cliqué sur " + inputKey.KeyChar);
//         Console.WriteLine("Le résultat du calcul 3+3 est 6");
//     }
//     else
//     {
//         if (inputKey.KeyChar == '3')
//         {
//             Console.WriteLine("Vous avez cliqué sur " + inputKey.KeyChar);
//             Environment.Exit(0);
//         }
//         else // ni 1, ni 2, ni 3
//         {
//             Console.WriteLine("Vous avez cliqué sur " + inputKey.KeyChar);
//             Console.WriteLine("Option inconnue");
//         }
//     }
// }
//
// Console.WriteLine("Ceci est la fin du programme");