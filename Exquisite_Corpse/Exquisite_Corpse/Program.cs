using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            string buildHead;
            string buildBody;
            string buildFeet;
            string choice;

            Console.WriteLine("*********\nEXQUISITECREATURE 1.0\n*********");

            while (true)
            {
                Console.WriteLine("How do you want to play?\n1. Generate a creature\n2. Randomize a creature\n0. Exit");

                choice = Console.ReadLine();
                while (choice != "1" && choice != "2" && choice != "0")
                {
                    Console.WriteLine("\n\nWrong input!! Try again:\n\n");
                    choice = Console.ReadLine();
                }

                if (choice == "1")
                {
                    Console.WriteLine("Let's get building our creature!\n");
                    Console.Write("Head: ");
                    buildHead = Console.ReadLine();
                    Console.Write("Body: ");
                    buildBody = Console.ReadLine();
                    Console.Write("Feet: ");
                    buildFeet = Console.ReadLine();
                    BuildACreature(buildHead, buildBody, buildFeet);
                }
                else if (choice == "2")
                {
                    RandomMode();
                }
                else
                {
                    Console.WriteLine("\nUntil next time then!\n");
                    return;
                }

                Console.WriteLine("\n\n");
            }
            return;
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }

        static void BuildACreature(string head = "ghost", string body = "ghost", string feet = "ghost")
        {
            head = head.ToLower();
            body = body.ToLower();
            feet = feet.ToLower();

            switch (head)
            {
                case "ghost":
                    GhostHead();
                    break;
                case "bug":
                    BugHead();
                    break;
                case "monster":
                    MonsterHead();
                    break;
                default:
                    GhostHead();
                    break;
            }

            switch (body)
            {
                case "ghost":
                    GhostBody();
                    break;
                case "bug":
                    BugBody();
                    break;
                case "monster":
                    MonsterBody();
                    break;
                default:
                    GhostBody();
                    break;
            }

            switch (feet)
            {
                case "ghost":
                    GhostFeet();
                    break;
                case "bug":
                    BugFeet();
                    break;
                case "monster":
                    MonsterFeet();
                    break;
                default:
                    GhostFeet();
                    break;
            }

            return;
        }

        static void RandomMode()
        {
            Random randomNumber = new Random();
            int num;

            num = randomNumber.Next(3);

            switch (num)
            {
                case 0:
                    GhostHead();
                    break;
                case 1:
                    BugHead();
                    break;
                case 2:
                    MonsterHead();
                    break;
                default:
                    GhostHead();
                    break;
            }

            num = randomNumber.Next(3);

            switch (num)
            {
                case 0:
                    GhostBody();
                    break;
                case 1:
                    BugBody();
                    break;
                case 2:
                    MonsterBody();
                    break;
                default:
                    GhostBody();
                    break;
            }

            switch (num)
            {
                case 0:
                    GhostFeet();
                    break;
                case 1:
                    BugFeet();
                    break;
                case 2:
                    MonsterFeet();
                    break;
                default:
                    GhostFeet();
                    break;
            }

            return;
        }

    }
}
