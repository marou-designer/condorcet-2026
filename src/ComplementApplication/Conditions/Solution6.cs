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
// var validKeys = new List<char> { '1', '2', '3' };
// if (!validKeys.Contains(inputKey.KeyChar))
// {
//     Console.WriteLine("Vous avez cliqué sur " + inputKey.KeyChar);
//     Console.WriteLine("Option inconnue");
// }
// else
// {
//     switch (inputKey.KeyChar)
//     {
//         case '1':
//             Console.WriteLine("Vous avez cliqué sur " + inputKey.KeyChar);
//             Console.WriteLine("La date du jour est " + DateTime.Now);
//             break;
//         case '2':
//             Console.WriteLine("Vous avez cliqué sur " + inputKey.KeyChar);
//             Console.WriteLine("Le résultat du calcul 3+3 est 6");
//             break;
//         case '3':
//             Console.WriteLine("Vous avez cliqué sur " + inputKey.KeyChar);
//             Environment.Exit(0);
//             break;
//     }
// }
//
// inputKey = Console.ReadKey();
// switch (inputKey.KeyChar)
// {
//     case '1':
//         Console.WriteLine("Vous avez cliqué sur un nombre impair valide");
//         break;
//     case '2':
//         Console.WriteLine("Vous avez cliqué sur un nombre pair valide");
//         break;
// }
//
// Console.WriteLine("Ceci est la fin du programme");