using System;

namespace Calculette
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            float if1 = 0 , if2 = 0 , isol; // initialsation a 0 por éviter les conflit
            do
            {
                Console.Write("Choisir une opération ");
                Console.WriteLine("\n Taper 'A' pour une addtion \n S pour une soustraction \n M pour une multiplication \n D pour une division \n C2 pour effectuer un carré \n C3 pour effectuer un cube \n F pour fermer la calculette \n\n");
                s = Console.ReadLine();
                Console.Clear();

                switch (s)
                {
                    case "A":

                        Console.WriteLine("Vous avez choisi l'operation 'addition.");


                            Lecture_operand(if1, if2);
                            isol = if1 + if2;
                            Console.Write("Le resultat de l'operation : " + if1 + " + " + if2 + " = ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(isol);
                            Console.ResetColor();

                        Console.ReadKey();

                        break;

                    case "M":

                        Console.WriteLine("Vous avez choisi l'operation 'multiplication.");

                            Lecture_operand(if1, if2);
                            isol = if1 * if2;
                            Console.Write("Le resultat de l'operation : " + if1 + " * " + if2 + " = ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(isol);
                            Console.ResetColor();

                        Console.ReadKey();
                        Console.Clear();


                        break;

                    case "D":

                        Console.WriteLine("Vous avez choisi l'operation 'division.");
                            Lecture_operand(if1, if2);
                            isol = if1 / if2;
                            Console.Write("Le resultat de l'operation : " + if1 + " / " + if2 + " = ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(isol);
                            Console.ResetColor();

                        break;

                    case "S":

                        Console.WriteLine("Vous avez choisi l'operation 'soustraction.");
                            Lecture_operand(if1, if2);
                            isol = if1 - if2;
                            Console.Write("Le resultat de l'operation : " + if1 + " - " + if2 + " = ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(isol);
                            Console.ResetColor();
                        break;

                    case "C2":

                        Console.WriteLine("Vous avez choisi l'operation 'carré'.");

                        try
                        {
                            Console.WriteLine("Donner le facteur a mettre au carré:");
                            if1 = Convert.ToInt32(Console.ReadLine());
                            isol = if1 * if1;
                            Console.Write("Le carré de" + if1 + "est de ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(isol);
                            Console.ResetColor();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Erreur de format");
                        }


                        Console.ReadKey();
                        Console.Clear();


                        break;

                    case "C3":

                        Console.WriteLine("Vous avez choisi l'operation 'cube.");

                        // f1 = Console.ReadLine();  cette ligne n'est pas necessaire car elle est directement ligne 25

                        try
                        {
                            Console.WriteLine("Donner le facteur a mettre au cube:");
                            if1 = Convert.ToInt32(Console.ReadLine());
                            isol = if1 * if1 * if1;
                            Console.Write("Le cube de" + if1 + "est de ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(isol);
                            Console.ResetColor();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Erreur de format");
                        }

                        Console.ReadKey();
                        Console.Clear();


                        break;

                    case "F":

                        return;



                    default:

                        Console.WriteLine("Aucune des operations possibles a ete selectionner \n");
                        break;

                }


            }
            while (true);
        }

        static float Lecture_operand(float if1,float if2) // accisition des données 
        {
            //do
            //{

                //try
                //{   
                    Console.WriteLine("Donner le premier opérand :");
                    if1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Donner le deuxieme opérand :");
                    if2 = Convert.ToInt32(Console.ReadLine());
                    return Convert.ToSingle(if1 * if2);
               // }
                //catch (FormatException)
                //{
                    //Console.WriteLine("Erreur de format");
                    //Console.ReadKey();
                //}
           // }

            //while (false);
        }
    }
}