using System;

namespace JEUX_D_ENIGUME
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;



                if (Start() == 1)
                {
                    Tonnom();
                }
                else
                {
                    Tonprenom();

                    while (true)
                    {

                        if (Fleche(new string[] { "un baton lumineux", "un Oeuf" }) == 1)
                        {
                            Unbatonlumineux();
                        }

                        else
                        {
                            Unoeuf();

                            if (Fleche(new string[] { "le mois de Décembre ?", "le mois de Fevrier ?" }) == 1)
                            {
                                lemoisdecembre();
                            }
                            else
                            {
                                lemoisdefevrier();
                                while (true)
                                {
                                    string[] responses = { "Un paquet de chewing-gum ?", "De la salade ", "Une brosse à dent ?" };
                                    switch (Fleche(responses))
                                    {
                                        case 1:
                                            Unchewinggum();
                                            break;

                                        case 2:
                                            Delasalade();
                                            break;

                                        case 3:
                                            Unebrosseàdent();
                                            break;

                                    }

                                    while (true)
                                    {

                                        if (Fleche(new string[] { "Une Pomme", "Une pasteque" }) == 1)
                                        {
                                            Unepomme();
                                        }
                                        else
                                        {
                                            Unepasteque();
                                        }

                                    }

                                }

                            }


                        }
                    }

                }
            }



        }




        public static int Start()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("█▀▀█ ▀█▀  █▀▀▀  █▄  █  █   █  █▀▀▀  █▄  █  █  █  █▀▀▀ 　  █▀▀▄  █▀▀█  █▄  █  █▀▀▀█ 　  █▀▀█  █  █ ▀█▀ 　  █▀▀▀█  █  █ ▀█▀  █▀▀▀█        █ █▀▀▀ 　 ▄ ▀▄ ");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("█▀▀▄  █   █▀▀▀  █ █ █   █ █   █▀▀▀  █ █ █  █  █  █▀▀▀ 　  █  █  █▄▄█  █ █ █  ▀▀▀▄▄ 　  █  █  █  █  █  　  ▀▀▀▄▄  █  █  █   ▀▀▀▄▄     ▄  █ █▀▀▀ 　    █ ");
            Console.SetCursorPosition(50, 9);
            Console.WriteLine("█▄▄█ ▄█▄  █▄▄▄  █  ▀█   ▀▄▀   █▄▄▄  █  ▀█  ▀▄▄▀  █▄▄▄ 　  █▄▄▀  █  █  █  ▀█  █▄▄▄█ 　  ▀▀█▄  ▀▄▄▀ ▄█▄ 　  █▄▄▄█  ▀▄▄▀ ▄█▄  █▄▄▄█     █▄▄█ █▄▄▄ 　 ▀ ▄▀");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Appuie entrer...");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Aujourd'hui nous allons jouer à qui suis-je assez PARTICULIER, vous êtes prêts ?");
            Console.WriteLine("C'est l'histoire d'un garçon nommer James est bloqué dans la maison de son voisin le jardinier et il doit résoudre des enigmes assez compliqueées même très difficiles pour s'en sortir vivant, seriez capable de le saver en faisant les bons choix ?");
            Console.WriteLine("Le jardinier qui tenait le garçon lui parlait depuis un micro cacher dans la sallon, oui le gar'con était bloqué dans la maison mais il a été amené dans le salon sans qui le sache. L'homme lui expliqua comment ça allait se deroulé que si il ne repondait pas au questions proprement ou les repondaient faux, il allait tué sa famille devant lui pour ensuite l'achever en dernier dans le bain de sang causé par sa famille morte étalé sur le sol. La premiere question du Monsieur était :");
            Console.WriteLine();
            Console.WriteLine("Question 1 : Je suis quelque chose qui t'appartient mais que les gens utilisent plus que toi, QUI SUIS-JE ?");
            Console.WriteLine();
            Console.WriteLine();

            string[] responses = { "Ton nom ?", "Ton prénom ?"};

            return Fleche(responses);
        }

        public static int Fleche(string[] reponses)
        {


            foreach (string reponse in reponses)
            {
                Console.SetCursorPosition(10, Console.CursorTop + 2);
                Console.WriteLine(reponse);
            }

            Console.SetCursorPosition(8, Console.CursorTop - 1 - (reponses.Length - 1) * 3);
            Console.Write("→");

            bool loop = true;
            int selectedOption = 1;


            while (loop)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedOption > 1)
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(8, Console.CursorTop - 3);
                            Console.Write("→");
                            selectedOption--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (selectedOption < reponses.Length)
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(8, Console.CursorTop + 3);
                            Console.Write("→");
                            selectedOption++;
                        }
                        break; 
                    case ConsoleKey.Enter:
                        loop = false;
                        Console.SetCursorPosition(0, Console.CursorTop + 2 + (reponses.Length - 1) * 3);
                        return selectedOption;
                }


            }

            return selectedOption;

        }

        public static void Tonnom()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VOUS AVEZ FAUX VOUS ALLEZ MOURIR ESPECE D'ENFANT SANS FOYER AHAHAHAHA :)");
            Environment.Exit(0);
        }
        public static void Tonprenom()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BRAVO ! Tu as trouvé la bonne réponse mais cela ne veut pas dire que tu as reussi, pour autant MAIS C'EST QUE LE DEBUT AHAHA, passons à la deuxieme étape. tu peux aller dans la piece d'accoter... ");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Te voici maintenant dans la CUISINE, voici la devinette ?");
            Console.WriteLine();
            Console.WriteLine("Question 2 : En étant cassé je suis plus utile que quand je ne le suis pas, QUI SUIS JE ?");
            Console.WriteLine();
            Console.WriteLine();
            
        }

        public static void Unbatonlumineux()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TU ES NUL TA N'AS PAS REUSSI à TROUVER LA BONNE REPONSE. VOUS ÊTES MORT !");
            Environment.Exit(0);
        }

        public static void Unoeuf()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BRAVO ! Endirait que vous avez un peu de chance aujourd'hui. J'ai bien dit un peu par ce que vous êtes quand meme bloqué ici ahaha. Repondit l'homme ");
            Console.WriteLine("Tu peux donc avancé dans la piéce superieur qui est LA SALLE DE BAIN AHAHAH. dit le jardinier ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Te voila maintenant dans la SALLE DE BAIN, tu peux fermé la porte derrière toi, si tu reponds juste à la question, une porte s'ouvrira à toi dans la salle de bain ");
            Console.WriteLine("Voici ma devinette !");
            Console.WriteLine("Question 3 : Je suis un mois où vous les êtres humains dormé moins, QUI SUIS JE ?");
            Console.WriteLine();
            Console.WriteLine();
            
        } 

        public static void lemoisdecembre()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TU ES NUL TA N'AS PAS REUSSI à TROUVER LA BONNE REPONSE. VOUS ÊTES MORT !");
            Environment.Exit(0);
        }

        public static void lemoisdefevrier()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BRAVO ! Tu es très fort mais cela ne veut pas dire que tu vas reuissir mon petit gars hahahahahahaha");
            Console.WriteLine("Passe dans la piece d'accoter, je te laisse deviné ou c'est en tout juste pour information ce n'est pas dans cette tour haha. Tu n'est peut être pas au courant mais ou j'habite ^c'est a dire ou tu te trouves maintenant, il y a 2 tours, la tour principal et la tour secondaire. La tour secondaire est pire qu'ici, je ne suis pas sensé te dire ç mais bon ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Te voila enfin arrivé dans la deuxieme tour, tu peux prendre place car tu es actuellement dans MON BUREAU. Tu touches à une seul chose je te tue sur le champ mon petit gars !");
            Console.WriteLine("Voici maintenant la devinette !");
            Console.WriteLine("Question 4 : Je suis quelque chose que tu mets dans ta bouche environ 3 fois ou plus par jour. Je suis peut etre un aliment, un objet ou quelque chose de non comestible mais on me mache quand même, QUI SUIS JE ?");
            Console.WriteLine("");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
          

            
        }

        public static void Unchewinggum()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TU ES VRAMINE NUL, IL N'Y A PAS PLUS NUL QUE TOI LOOSER. TU ES MORT MON PETIT AHAHAHA :)");
            Environment.Exit(0);
        }

        public static void Delasalade()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VOUS ÊTES VRAIMENT ACCOTER DE LA PLAQUE, VOUS CROYEZ VRAIMENT QUE LA REPONSE ETAIT LA SALADE SALE BÊTE");
            Console.WriteLine();
            Console.WriteLine("COMMENT CROIRE CELA SALE BETE :) ");
            Environment.Exit(0);
        }

        public static void Unebrosseàdent()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Bravo tu as encore trouvé la bonne reponse sale petit morveux, je te prie de faire attention a la piéce d'apres car tu rsiques de frissonné mon garçon.");            
            Console.WriteLine("Tu te trouve actuellement dans LA CAGE A LION AHAHAHAHA");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Voici ma devinette !");
            Console.WriteLine();
            Console.WriteLine("Tu arrete de me manger quand je suis d'une autre couleur et tu continues quand je suis rouge, QUI SUIS JE ?");
          
        }

        public static void Unepomme()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TU ES VRAIMENT NUL, TU ES MORT AHAHAHA :)");
            Environment.Exit(0);
        }

        public static void Unepasteque()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bravo tu as trouvé la bonne reponse c'est belle est bien ton jour de chance si tu vois ce que je veux dire AHAHAHA. Tu peux avanceé dans la pièce d'accoter qui est LE JARDIN.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Vous êtes arrivé dans LE JARDIN, cette question sera trés difficile, j'espere que tu es bon en Géographie par ce que les trois prochaines devinette seront de culture generale et si tu reponds faux tu sais ce qui t'attends mon ptit gars ");
        }

    }
}
