using System;
using System.Media;
using System.Threading;
using System.Runtime.InteropServices;

namespace JEUX_D_ENIGUME
{
    class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisCon = GetConsoleWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        // State of application once loaded
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
        static void Main(string[] args)
        
        {
            
            ShowWindow(ThisCon, MAXIMIZE);

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black; //choisit la couleur du fond de la console 

                Console.SetCursorPosition(80, 30); //placement des deux propositions
              
                if (Start() == 1) //si la réponse des deux propositions est égal à 1, alors elle donnera ça 
                {
                    Tonnom();
                }
                else //si la réponse des deux propositions est égal à 2, alors ça donnera cela 
                {
                    Tonprenom();

                    while (true)
                    {
                      
                        if (Fleche(new string[] { "un baton lumineux", "un Oeuf" }) == 1) // nouveau string avec une flèche le suivant
                        {
                            Unbatonlumineux();
                        }
                        else
                        {
                            Unoeuf();
                            while (true)
                            {
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
                                                while (true)
                                                {

                                                    if (Fleche(new string[] { "Une Pomme", "Une pasteque" }) == 1)
                                                    {
                                                        Unepomme();
                                                    }
                                                    else
                                                    {
                                                        Unepasteque();
                                                        while (true)
                                                        {
                                                            if (Fleche(new string[] { "Quebec City", "Ottawa" }) == 1)
                                                            {
                                                                quebeccity();
                                                            }
                                                            else
                                                            {
                                                                ottawa();
                                                                while (true)
                                                                {
                                                                    if (Fleche(new string[] { "14 personnes", "9 personnes " }) == 1)
                                                                    {
                                                                        quatorzepersonne();
                                                                    }
                                                                    else
                                                                    {
                                                                        neufpersonnes();
                                                                        while (true)
                                                                        {
                                                                            if (Fleche(new string[] { "Oui", "Non" }) == 1)
                                                                            {
                                                                                oui();
                                                                            }
                                                                            else
                                                                            {
                                                                                non();
                                                                            }


                                                                        }
                                                                    }
                                                                    
                                                                }
                                                            }

                                                        }

                                                    }

                                                }

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
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(50, 20);
            Console.WriteLine("█▀▀█ ▀█▀  █▀▀▀  █▄  █  █   █  █▀▀▀  █▄  █  █  █  █▀▀▀ 　  █▀▀▄  █▀▀█  █▄  █  █▀▀▀█ 　  █▀▀█  █  █ ▀█▀ 　  █▀▀▀█  █  █ ▀█▀  █▀▀▀█        █ █▀▀▀ 　 ▄ ▀▄ ");
            Console.SetCursorPosition(50, 21);
            Console.WriteLine("█▀▀▄  █   █▀▀▀  █ █ █   █ █   █▀▀▀  █ █ █  █  █  █▀▀▀ 　  █  █  █▄▄█  █ █ █  ▀▀▀▄▄ 　  █  █  █  █  █  　  ▀▀▀▄▄  █  █  █   ▀▀▀▄▄     ▄  █ █▀▀▀ 　    █ ");
            Console.SetCursorPosition(50, 22);
            Console.WriteLine("█▄▄█ ▄█▄  █▄▄▄  █  ▀█   ▀▄▀   █▄▄▄  █  ▀█  ▀▄▄▀  █▄▄▄ 　  █▄▄▀  █  █  █  ▀█  █▄▄▄█ 　  ▀▀█▄  ▀▄▄▀ ▄█▄ 　  █▄▄▄█  ▀▄▄▀ ▄█▄  █▄▄▄█     █▄▄█ █▄▄▄ 　 ▀ ▄▀");
            Console.SetCursorPosition(109, 40);
            Console.WriteLine("VEUILLEZ APPUYER ENTRER ...");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("Voici les explications du jeu :");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("Un garçon et sa famille sont bloqué dans la maison de leur vosin je jardinier");
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("ils se sont reveillé un bon matin et se sont retrouvé dans la maison de le voisin sans le vouloir.");
            Console.SetCursorPosition(80, 22);
            Console.WriteLine("Votre but à vous c'est de répondre juste aux devinettes que le jardinier va vous posé");
            Console.SetCursorPosition(80, 24);
            Console.WriteLine("Pour chaque mauvaise réponse vous aurez sûrement une deuxième chance");
            Console.SetCursorPosition(80, 26);
            Console.WriteLine("une chance de vous rattraper pour pas que James et sa famile meurent");
            Console.SetCursorPosition(80, 28);
            Console.WriteLine("Sa vie est entre vos mains alors faites les bon choix ");
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(112, 40);
            Console.WriteLine("Appuier entrer...");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("BIENVENUE, vous êtes sur le point de jouer  à qui suis-je assez PARTICULIER, vous êtes prêts ?");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("C'est l'histoire d'un garçon nommer James est bloqué dans la maison de son voisin");
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("le jardinier et il doit résoudre des enigmes assez compliqueées même très difficiles");
            Console.SetCursorPosition(80, 22);
            Console.WriteLine("pour s'en sortir vivant, seriez capable de le saver en faisant les bons choix ?");
            Console.SetCursorPosition(80, 24);
            Console.WriteLine("Le jardinier qui tenait le garçon lui parlait depuis un micro cacher dans la salon");
            Console.SetCursorPosition(80, 26);
            Console.WriteLine("oui le garçon était bloqué dans la maison mais il a été amené dans le salon sans qui le sache");
            Console.SetCursorPosition(80, 28);
            Console.WriteLine("L'homme lui expliqua comment ça allait se deroulé que si il ne repondait pas au questions proprement");
            Console.SetCursorPosition(80, 30);
            Console.WriteLine("Il allait tué sa famille devant lui pour ensuite l'achever en dernier dans le bain de sang causé");
            Console.SetCursorPosition(80, 32);
            Console.WriteLine("par sa famille morte étalé sur le sol. La premiere question du Monsieur était :");
            Console.SetCursorPosition(80, 34);
            Console.WriteLine();
            Console.SetCursorPosition(80, 36);
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
                Console.SetCursorPosition(80, Console.CursorTop + 2);
                Console.WriteLine(reponse);
            }

            Console.SetCursorPosition(18, Console.CursorTop - 1 - (reponses.Length - 1) * 3);
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
                            Console.SetCursorPosition(75, Console.CursorTop - 3);
                            Console.Write("→");

                            selectedOption--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (selectedOption < reponses.Length)
                        {
                            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(75, Console.CursorTop + 3);
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
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 50);
            Console.WriteLine("VOUS AVEZ FAUX DÉS LE DÉPART, VEUILLEZ METTRE LA BONNE RÉPONSE SVP:)");
            Thread.Sleep(10000);
            Console.Clear();
        }
        public static void Tonprenom()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("BRAVO ! Tu as trouvé la bonne réponse mais cela ne veut pas dire que tu as reussi");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("pour autant MAIS C'EST QUE LE DEBUT AHAHA, passons à la deuxieme étape");
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("tu peux aller dans la piece d'à coter... ");
            Console.WriteLine();
            Console.SetCursorPosition(80, 22);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(80, 24);
            Console.WriteLine("Te voici maintenant dans la CUISINE, voici la devinette ?");
            Console.WriteLine();
            Console.SetCursorPosition(80, 26);
            Console.WriteLine("Question 2 : En étant cassé je suis plus utile que quand je ne le suis pas, QUI SUIS JE ?");
            Console.WriteLine();
            Console.WriteLine();
            
        }

        public static void Unbatonlumineux()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.SetCursorPosition(80, 40);
            Console.WriteLine("VOUS ÊTES MUL VOUS N'AVEZ PAS TROUVÉ LA BONNE RÉPONSE ALORS QUE C'EST ÉVIDENT. VEUILLEZ RESSAYE SVP !");
            Thread.Sleep(10000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("Question 2 : En étant cassé je suis plus utile que quand je ne le suis pas, QUI SUIS JE ?");
        }

        public static void Unoeuf()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("BRAVO ! Endirait que vous avez un peu de chance aujourd'hui. J'ai bien dit un peu par ce que");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("vous êtes quand meme bloqué ici ahaha. Cria l'homme");
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("Tu peux donc avancé dans la piéce superieur qui est LA SALLE DE BAIN AHAHAH. dit le jardinier ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.SetCursorPosition(80, 26);
            Console.WriteLine("Te voila maintenant dans la SALLE DE BAIN, tu peux fermé la porte derrière toi, si tu reponds");
            Console.SetCursorPosition(80, 28);
            Console.WriteLine("juste à la question, une porte s'ouvrira à toi dans la salle de bain ");
            Console.SetCursorPosition(80, 30);
            Console.WriteLine("Voici ma devinette !");
            Console.SetCursorPosition(80, 32); 
            Console.WriteLine("Question 3 : Je suis un mois où vous les êtres humains dormé moins, QUI SUIS JE ?");
            Console.WriteLine();
            Console.WriteLine();
            
        } 

        public static void lemoisdecembre()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(80, 48);
            Console.WriteLine("TU ES VRAIMENT NUL EN FAÎTES TROUVER LA BONNE REPONSE MÊME ÇA TU N'ARRIVES PAS . VOUS ÊTES MORT !");
            Thread.Sleep(10000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("Question 3 : Je suis un mois où vous les êtres humains dormé moins, QUI SUIS JE ?");
            
        }

        public static void lemoisdefevrier() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("BRAVO ! Tu es très fort mais cela ne veut pas dire que tu vas reuissir mon petit gars hahahahahahaha");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("Passe dans la piece d'accoter, je te laisse deviné ou c'est en tout juste pour information ce n'est pas");
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("dans cette tour haha. Tu n'est peut être pas au courant mais ou j'habite c'est a dire ou tu te trouves");
            Console.SetCursorPosition(80, 22);
            Console.WriteLine("maintenant, il y a 2 tours, la tour principal et la tour secondaire. La tour secondaire est pire qu'ici");
            Console.SetCursorPosition(80, 24);
            Console.WriteLine("je ne suis pas sensé te dire ç mais bon ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 30);
            Console.WriteLine("Te voila enfin arrivé dans la deuxieme tour, tu peux prendre place car tu es actuellement dans MON BUREAU");
            Console.SetCursorPosition(80, 32);
            Console.WriteLine("Tu touches à une seul chose je te tue sur le champ mon petit gars !");
            Console.SetCursorPosition(80, 34);
            Console.WriteLine("Voici maintenant la devinette !");
            Console.WriteLine();
            Console.SetCursorPosition(80, 42);
            Console.WriteLine("Question 4 : Je suis quelque chose que tu mets dans ta bouche environ 3 fois ou plus par jour");
            Console.SetCursorPosition(80, 44);
            Console.WriteLine("Je suis peut etre un aliment, un objet ou quelque chose de non comestible mais on me mache quand même, QUI SUIS JE ?");
            Console.WriteLine("");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
          

            
        }

        public static void Unchewinggum()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(80, 61);
            Console.WriteLine("TU ES VRAIMENT NUL, IL N'Y A PAS PLUS NUL QUE TOI LOOSER. TU ES MORT MON PETIT AHAHAHA :)");
            Thread.Sleep(10000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("Question 4 : Je suis quelque chose que tu mets dans ta bouche environ 3 fois ou plus par jour");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("Je suis peut etre un aliment, un objet ou quelque chose de non comestible mais on me mache quand même, QUI SUIS JE ?");
        }

        public static void Delasalade()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(80, 63);
            Console.WriteLine("VOUS ÊTES VRAIMENT ACCOTER DE LA PLAQUE, VOUS CROYEZ VRAIMENT QUE LA REPONSE ETAIT LA SALADE SALE BÊTE");
            Console.WriteLine();
            Console.SetCursorPosition(80, 57);
            Console.WriteLine("COMMENT CROIRE CELA SALE BETE :) ");
            Thread.Sleep(10000);
            Console.Clear(); 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("Question 4 : Je suis quelque chose que tu mets dans ta bouche environ 3 fois ou plus par jour");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("Je suis peut etre un aliment, un objet ou quelque chose de non comestible mais on me mache quand même, QUI SUIS JE ?");
        }

        public static void Unebrosseàdent()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("BRAVO ! tu as encore trouvé la bonne reponse sale petit morveux, je te prie de faire attention");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("à la piéce d'apres car tu rsiques de frissonné mon garçon.");
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("Tu te trouve actuellement dans LA CAGE A LION AHAHAHAHA");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(80, 24);
            Console.WriteLine("Question 5 : Tu arrete de me manger quand je suis d'une autre couleur et tu continues quand je suis rouge, QUI SUIS JE ?");
          
        }

        public static void Unepomme()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(80, 40);
            Console.WriteLine("TU ES VRAIMENT NUL, TU ES MORT AHAHAHA :)");
            Thread.Sleep(10000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("Question 5 : Tu arrete de me manger quand je suis d'une autre couleur et tu continues quand je suis rouge, QUI SUIS JE ?");
        }

        public static void Unepasteque()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("BRAVO ! tu as trouvé la bonne reponse c'est belle est bien ton jour de chance si tu vois ce que je veux dire AHAHAHA. Tu peux avanceé dans la pièce d'accoter qui est LE JARDIN.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("Vous êtes arrivé dans LE JARDIN, cette question sera trés difficile , instal toi bien quelque part");
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("carrement j'ai tondu le gazon rien que pour toi. J'espere que tu es bon en Géographie par ce que les");
            Console.SetCursorPosition(80, 22);
            Console.WriteLine("trois prochaines devinette seront de culture generale et si tu reponds faux tu sais ce qui t'attends mon ptit gars ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(80, 26);
            Console.WriteLine("Question 6 : Quelle la capital du Canada ? :)");
            Console.WriteLine();
        }

        public static void quebeccity()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(80, 40);
            Console.WriteLine("TU ES VRAIMENT NUL MON PETIT GARS. LA CHANCE N'EST PAS AU RENDEZ-VOUS AUJOURD'HUI AHAHAHAHAHA :)");
            Thread.Sleep(10000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Question 6 : Quelle la capital du Canada ? :)");
            Console.WriteLine();
        }

        public static void ottawa()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("BRAVO ! enidrait bien qu'aujourd'hui est ton jour de chance, tu peux avancé dans l'avant derniere");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("pièce qui se trouve dans LA CAVE AHAHAHA");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("Te voila maintenant dans LA CAVE, il fait sombre hein, on te voit plus dit donc, on se demande pourquoi ahahahaha");
            Console.WriteLine();
            Console.SetCursorPosition(80, 22);
            Console.WriteLine("Je vais te poser la dernière question, la question final, celle qui libera toutes ta famille de la mort que je les");
            Console.SetCursorPosition(80, 24);
            Console.WriteLine("avaient réservé si tu trouves la devinette :)(:");
            Console.SetCursorPosition(80, 26);
            Console.WriteLine("Alors tu as interet a trouvé cette devinette la mon ptit gars");
            Console.WriteLine();
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("Question 7 : Monsieur et Madame Dupont ont 6 fils. Ils ont tous une sœur, combien y-a-t-il de personne dans cette famille ?");
            

        }

        public static void quatorzepersonne()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 2);
            Console.WriteLine("██╗░░░██╗░█████╗░██╗░░░██╗██╗██████╗░███████╗  ██████╗░███████╗░█████╗░██████╗░  ██████╗░██████╗░░█████╗░");
            Console.SetCursorPosition(80, 3);
            Console.WriteLine("╚██╗░██╔╝██╔══██╗██║░░░██║╚█║██╔══██╗██╔════╝  ██╔══██╗██╔════╝██╔══██╗██╔══██╗  ██╔══██╗██╔══██╗██╔══██╗");
            Console.SetCursorPosition(80, 4);
            Console.WriteLine(" ╚████╔╝░██║░░██║██║░░░██║░╚╝██████╔╝█████╗░░  ██║░░██║█████╗░░███████║██║░░██║  ██████╦╝██████╔╝██║░░██║");
            Console.SetCursorPosition(80, 5);
            Console.WriteLine("  ╚██╔╝░░██║░░██║██║░░░██║░░░██╔══██╗██╔══╝░░  ██║░░██║██╔══╝░░██╔══██║██║░░██║  ██╔══██╗██╔══██╗██║░░██║");
            Console.SetCursorPosition(80, 6);
            Console.WriteLine(" ░░██║░░░╚█████╔╝╚██████╔╝░░░██║░░██║███████╗  ██████╔╝███████╗██║░░██║██████╔╝  ██████╦╝██║░░██║╚█████╔╝");
            Console.SetCursorPosition(80, 7);
            Console.WriteLine("░░░╚═╝░░░░╚════╝░░╚═════╝░░░░╚═╝░░╚═╝╚══════╝  ╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚═╝░░╚═╝░╚════╝░");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("ENDIRAIT BIEN QUE TU SAIS PAS COMPTE MON PETIT GARS. TU N'AS PLUS AUCUNE CHANCE");
            Console.SetCursorPosition(80, 18);
            Console.WriteLine("ESPECE DE BÊTE. TU VAS MOURRIR ENTRE");
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("LES MAINS DE TA FAMILLIES QUI ELLES AUSSI VA MOURIR DEVANT TES YEUX AHAHAHAHA");
            Console.WriteLine();
            Console.SetCursorPosition(80, 22);
            Console.WriteLine("TU ES NUL TU AS PERDU, JE VAIS VOUS TUER SUR LE CHAMP AHAHAHA");
            Console.SetCursorPosition(80, 24);
            Console.WriteLine("Le jardinier prit sa hache et ramena le garçon dans le lieu ou était cacher ses parents, ils étaient dnas une salle");
            Console.SetCursorPosition(80, 26);
            Console.WriteLine("assez sombre, il n'y avait presque meme pas de lumière qui passait, c'était beaucoup trop lugubre. Il commencça par la");
            Console.SetCursorPosition(80, 28);
            Console.WriteLine("petite soeur en la tirant au millieu de la salle, il prit sa hache et la trancha le coup sans hésitation");
            Thread.Sleep(100000);
            Environment.Exit(0);
        }
        private static void neufpersonnes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("██████╗░██████╗░░█████╗░██╗░░░██╗░█████╗░  ████████╗██╗░░░██╗  ░█████╗░░██████  ██████╗░███████╗██╗░░░██╗░██████╗░██████╗██╗  ██╗██╗░░");
            Console.SetCursorPosition(60, 3);
            Console.WriteLine("██╔══██╗██╔══██╗██╔══██╗██║░░░██║██╔══██╗  ╚══██╔══╝██║░░░██║  ██╔══██╗██╔════╝ ██╔══██╗██╔════╝██║░░░██║██╔════╝██╔════╝██║  ╚═╝╚██╗░ ");
            Console.SetCursorPosition(60, 4);
            Console.WriteLine("██████╦╝██████╔╝███████║╚██╗░██╔╝██║░░██║  ░░░██║░░░██║░░░██║  ███████║╚█████╗  ██████╔╝█████╗░░██║░░░██║╚█████╗░╚█████╗░██║  ░░░░╚██╗");
            Console.SetCursorPosition(60, 5);
            Console.WriteLine("██╔══██╗██╔══██╗██╔══██║░╚████╔╝░██║░░██║  ░░░██║░░░██║░░░██║  ██╔══██║░╚═══██╗ ██╔══██╗██╔══╝░░██║░░░██║░╚═══██╗░╚═══██╗██║  ██╗░██╔╝");
            Console.SetCursorPosition(60, 6);
            Console.WriteLine("██████╦╝██║░░██║██║░░██║░░╚██╔╝░░╚█████╔╝  ░░░██║░░░╚██████╔╝  ██║░░██║██████╔  ██║░░██║███████╗╚██████╔╝██████╔╝██████╔╝██║  ╚█║██╔╝░");
            Console.SetCursorPosition(60, 7);
            Console.WriteLine("╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░  ░░░╚═╝░░░░╚═════╝░  ╚═╝░░╚═╝╚═════╝  ╚═╝░░╚═╝╚══════╝░╚═════╝░╚═════╝░╚═════╝░╚═╝  ░╚╝╚═╝░░");
            Console.WriteLine();
            Console.WriteLine();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("Voulez-vous avoir une récompense de ma part ?");
        }

        private static void oui()
        {
            Console.Clear();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("Tu as donc répondu OUI, je vais donc t'annoncer ce que tu as gagné. TU AS GAGNÉ ..... TOUTE MON ESTIMES ENVERS TOI ET MON RESPECT :=)");
            Console.WriteLine("BIEN JOUER À TOI ");
        }

        private static void non()
        {
            Console.Clear();
            Console.SetCursorPosition(80, 16);
            Console.WriteLine("DOMMAGE POUR VOUS, de toute façon je n'allais rien vous donné :=(");
            Thread.Sleep(10000);
            Environment.Exit(0);
        }
    }
}
