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

                                    string[] responses = { "Confrontation avec l'homme pour savoir quel est son soucis", "Se retourner et courir", "Attaquer l'homme" };

                                    switch (Fleche(responses))
                                    {
                                        case 1:
                                            confrontationaveclhomme();
                                            break;

                                        case 2:
                                            lahache();
                                            break;

                                        case 3:
                                            prendrelebus();
                                            break;

                                    }
                                }
                                while (true)
                                {

                                    string[] responses = { "Confrontation avec l'homme pour savoir quel est son soucis", "Se retourner et courir", "Attaquer l'homme" };

                                    switch (Fleche(responses))
                                    {
                                        case 1:
                                            confrontationaveclhomme();
                                            break;

                                        case 2:
                                            lahache();
                                            break;

                                        case 3:
                                            prendrelebus();
                                            break;

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
            Console.WriteLine("██████╗░██╗███████╗███╗░░██╗██╗░░░██╗███████╗███╗░░██╗██╗░░░██╗███████╗  ██████╗░░█████╗░███╗░░██╗░██████");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("██╔══██╗██║██╔════╝████╗░██║██║░░░██║██╔════╝████╗░██║██║░░░██║██╔════╝  ██╔══██╗██╔══██╗████╗░██║██╔════");
            Console.SetCursorPosition(50, 9);
            Console.WriteLine("██╔══██╗██║██╔══╝░░██║╚████║░╚████╔╝░██╔══╝░░██║╚████║██║░░░██║██╔══╝░░  ██║░░██║██╔══██║██║╚████║░╚═══██╗");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("░██████╗░██╗░░░██╗██╗  ░██████╗██╗░░░██╗██╗░██████╗  ░░░░░██╗███████╗  ██╗██╗░░██╔═══██╗██║░░░██║██║  ██╔════╝██║░░░██║██║██╔════╝  ░░░░░██║██╔════╝  ╚═╝╚██╗░");
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
            Console.WriteLine("Le jardinier qui tenait le garçon lui parlait depuis un micro cacher dans la sallon, oui le gar'con était bloqué dans la maison mais il a été amené dans le salon sans qui le sache. L'homme lui expliqua comment ça allait se deroulé que si il ne repondait pas au questions proprement ou les repondaient faux, il allait tué sa famille devant lui pour ensuite l'achever en dernier dans le bain de sang causé par sa famille morte étalé sur le sol. La prmiere question du jardinier était : ");
            Console.WriteLine();
            Console.WriteLine("Question 1 : Je suis quelque chose qui t'appartient mais que les gens utilisent plus que toi, QUI SUIS-JE ?");
            Console.WriteLine();
            Console.WriteLine("=============================================================================================================================================================================================================================================");

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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BRAVO ! Tu as trouvé la bonne réponse mais cela ne veut pas dire que tu as reussi, pour autant MAIS C'EST QUE LE DEBUT AHAHA, passons à la deuxieme étape. tu peux aller dans la piece d'accoter... ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Te voici maintenant dans la CUISINE, voici la devinette ?");
            Console.WriteLine();
            Console.WriteLine("Question 2 : En étant cassé je suis plus utile que quand je ne le suis pas, QUI SUIS JE ?");
            Console.WriteLine();
            Console.WriteLine("=============================================================================================================================================================================================================================================");

        }

        public static void Unbatonlumineux()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("TU ES NUL TA N'AS PAS REUSSI à TROUVER LA BONNE REPONSE. VOUS ÊTES MORT !");
            Environment.Exit(0);
        }

        public static void Unoeuf()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BRAVO ! Endirait que vous avez un peu de chance aujourd'hui. J'ai bien dit un peu par ce que vous êtes quand meme bloqué ici ahaha. Repondit l'homme ");
            Console.WriteLine("Tu peux donc avancé dans la piéce superieur qui est LA SALLE DE BAIN AHAHAH. dit le jardinier ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Te voila maintenant dans la SALLE DE BAIN, tu peux fermé la porte derrière toi, si tu reponds juste à la question, une porte s'ouvrira à toi dans la salle de bain ");
            Console.WriteLine("Voici ma devinette !");
            Console.WriteLine("Question 3 : Je suis un mois où vous les êtres humains dormé moins, QUI SUIS JE ?");
            Console.WriteLine();
            Console.WriteLine("=============================================================================================================================================================================================================================================");
            
        } 

        public static void lemoisdecembre()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("En passant par le chemin boueux Jackson ne remmentra pas à la surface par ce que le terrain était trop profond avec du vide. VOUS EST MORT !! ");
            Environment.Exit(0);
        }

        public static void lemoisdefevrier()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("BRAVO ! Tu es très fort mais cela ne veut pas dire que tu vas reuissir mon petit gars hahahahahahaha");
            Console.WriteLine("Passe dans la piece d'accoter, je te laisse deviné ou c'est en tout juste pour information ce n'est pas dans cette tour haha. Tu n'est peut être pas au courant mais ou j'habite ^c'est a dire ou tu te trouves maintenant, il y a 2 tours, la tour principal et la tour secondaire. La tour secondaire est pire qu'ici, je ne suis pas sensé te dire ç mais bon ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("Te voila enfin arrivé dans la deuxieme tour, tu peux prendre place car tu es actuellement dans MON BUREAU. Tu touches à une seul chose je te tue sur le champ mon petit gars !");
            Console.WriteLine("Voici maintenant la devinette !");
            Console.WriteLine("Question 4 : Je suis un appareil électronique qui vibre et tourne, tu me mets dans ta bouche environ 3 fois par jour et je mesure environ 15 cm, QUI SUIS JE ?");
            Console.WriteLine("Un chewing-gum ?");
            Console.WriteLine("");
            Console.WriteLine("Une brosse à dent ?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("=============================================================================================================================================================================================================================================");
            
        }

        public static void confrontationaveclhomme()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("En continuant le chemin Jackson confronta l'homme, il était beaucoup trop puissant pour Jackson il était armé et deux fois plus grand que lui. L'homme le faucha le crâne avec sa hache. VOUS ÊTES MORT ! ");
            Environment.Exit(0);
        }

        public static void lahache()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("En prenant la fuite c'était déjà trop tard, les craquement qu'entendait Jackson tout à l'heure était bel et bien l'homme armé d'une hache entrain de coupé le bout de bois ou était accroché la corde du pont, le pont est entrain de s'effondre et Jackson est toujours dedans. La distance qu'il y avait entre le pont est la rivière était de au moins 10 mètres, il succomba de ses blessures.");
            Console.WriteLine("Le bus est finalement passé mais sans la présence de Jackson. QUI SUIVAIT LE COURANT DE LA RIVIÈRE TOUT ÉTANT MORT !");
            Environment.Exit(0);
        }

        public static void prendrelebus()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Jackson prit sa lampe et la pointa sur les yeux de l'homme en face de lui, l'homme était éblouit par la lumière et ne vit rien, en ce meme moment Jackson le frappa dans la partie intime de l'homme pour qu'il ne bouge plus. Jackson le frappa le frappe jusqu'a le laisser pour mort. En voyant l'homme allonger sur le sol, il prit la fuite, il coura de toutes ses forces sans s'arreter. Il parviendra à chopper son bus à temps, rentré à la maison Jackson regardais la TV et d'un coup FlashNews du pays passa, la presentatrice raconta qu'un tueur en serie a été retrouver mais pas en bon état dans la forêt de Chanston City c'est la ou habite les amies de Jackson et la tout ce qui c'était passé avant revenais dans les pensées de Jackson... VOUS AVEZ REUSSI à ARRETER UN TUEUR EN SERIE ET DE PRENDRE VOTRE BUS :)");
            
        }

        
    }
}
