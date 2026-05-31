using System;
using System.Text;
using System.Threading.Tasks;

class TestQuest
{
    static Random rng = new Random();

    static bool monsterEvent()
    {
        Console.Clear();

        // Настройка консоли
        Console.OutputEncoding = Encoding.UTF8;

        // Стили текста
        string italic = "\x1b[3m";
        string bold = "\x1b[1m";
        string underline = "\x1b[4m";
        string reset = "\x1b[0m"; // Сброс всех стилей

        // Цвета
        string white = "\x1b[38;5;15m";
        string dark = "\x1b[38;5;236m";

        if (rng.Next(1, 3) == 1)
        {
            Console.Clear();

            string[] caveArt_Monster = new string[]
            {
                    $"{dark}████████████████████████████████████████████████████████{reset}",
                    $"{dark}██████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████████████████{reset}",
                    $"{dark}█████████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓█████████████████{reset}",
                    $"{dark}██████████▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░▒▒▓▓█████████████{reset}",
                    $"{dark}████████▓▓▒▒░░                            ░░▒▒▓▓██████{reset}",
                    $"{dark}██████▓▓▒▒░░          ▄▄▄▄▄▄▄▄            ░░▒▒▓▓██████{reset}",
                    $"{dark}█████▓▓▒▒░░        ▄█▓▓▓▓▓▓▓▓▓█▄          ░░▒▒▓▓█████{reset}",
                    $"{dark}████▓▓▒▒░░       █▓▓▓▓▓██▓▓▓▓▓▓█          ░░▒▒▓▓████{reset}",
                    $"{dark}████▓▓▒▒░░      █▓▓▓▓▓█  █▓▓▓▓▓█          ░░▒▒▓▓████{reset}",
                    $"{dark}████▓▓▒▒░░      █▓▓▓▓▓████▓▓▓▓▓█          ░░▒▒▓▓████{reset}",
                    $"{dark}████▓▓▒▒░░    ▄▄█▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▄▄        ░░▒▒▓▓████{reset}",
                    $"{dark}████▓▓▒▒░░  ▄█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▄      ░░▒▒▓▓████{reset}",
                    $"{dark}████▓▓▒▒░░ █▓▓▓▓▓█▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓█      ░░▒▒▓▓████{reset}",
                    $"{dark}████▓▓▒▒░░ █▓▓▓█    █▓▓▓▓█    █▓▓▓█      ░░▒▒▓▓████{reset}",
                    $"{dark}████▓▓▒▒░░  ▀▀      █▓▓▓▓█      ▀▀       ░░▒▒▓▓████{reset}",
                    $"{dark}█████▓▓▒▒░░         █▓▓▓▓█               ░░▒▒▓▓█████{reset}",
                    $"{dark}██████▓▓▒▒░░░      ██    ██            ░░░▒▒▓▓██████{reset}",
                    $"{dark}████████▓▓▒▒░░░░                      ░░░░▒▒▓▓██████{reset}",
                    $"{dark}██████████▓▓▒▒▒░░░░░░░░░░░░░░░░░░░░░▒▒▒▓▓██████████{reset}",
                    $"{dark}█████████████▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓████████████████{reset}",
                    $"{dark}██████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓████████████████████{reset}",
                    $"{dark}████████████████████████████████████████████████████████{reset}"
            };

            foreach (string line in caveArt_Monster)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"{italic}{bold}Внезапно из темноты вылезло мистическое существо и стремительно направилось в вашу сторону!{reset}");
            Console.WriteLine($"1.Спрятаться;");

            string chooseEscape = Console.ReadLine();

            if (chooseEscape == "1")
            {
                Console.WriteLine($"*{underline}{bold}Вам удалось спрятаться от чудовища.{reset}*");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine($"{italic}{bold}\nВы осторожно выходите из укрытия. Коридор снова пуст.\n{reset}");
            }
            else
            {
                Console.WriteLine($"{italic}{bold}Вы погибли в пещере от лап чудовища ...{reset}");
                return false;
            }
        }

        return true;
    }

    enum Scene
    {
        StartCave,
        CaveLocationOne,
        CaveLocationTwo,
        CaveLocationExit,
        CaveFinal,
        End
    }
    static void Main()
    {
        Scene current = Scene.StartCave;

        while (current != Scene.End)
        {
            switch (current)
            {
                case Scene.StartCave:
                    current = StartCave();
                    break;
                case Scene.CaveLocationOne:
                    current = CaveLocationOne();
                    break;
                case Scene.CaveLocationTwo:
                    current = CaveLocationTwo();
                    break;
                case Scene.CaveLocationExit:
                    current = CaveLocationExit();
                    break;
                case Scene.CaveFinal:
                    current = CaveFinal();
                    break;
                case Scene.End:
                    current = End();
                    break;
            }
        }
        static Scene StartCave()
        {
            // Настройка консоли
            Console.OutputEncoding = Encoding.UTF8;

            // Стили текста
            string italic = "\x1b[3m";
            string bold = "\x1b[1m";
            string underline = "\x1b[4m";
            string reset = "\x1b[0m";

            // Цвета
            string white = "\x1b[38;5;15m";
            string dark = "\x1b[38;5;236m";

            // Логотип
            string[] logo =
    {
    "==========================================================",
    "       ____                 ___                  _   ",
    "      / ___|__ ___   _____ / _ \\ _   _  ___  ___| |_ ",
    "     | |   / _` \\ \\ / / _ \\ | | | | | |/ _ \\/ __| __|",
    "     | |__| (_| |\\ V /  __/ |_| | |_| |  __/\\__ \\ |_ ",
    "      \\____\\__,_| \\_/ \\___|\\__\\_\\\\__,_|\\___||___/\\__|",
    "                                                        ",
    "=========================================================="
};

            foreach (string line in logo)
            {
                Console.WriteLine(line);
            }

            string[] caveArt = new string[]
            {
            $"{dark}████████████████████████████████████████████████████████{reset}",
            $"{dark}██████████████████████▓▓▓▓▓▓▓▓▓▓▓▓██████████████████████{reset}",
            $"{dark}█████████████████▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓█████████████████{reset}",
            $"{dark}██████████████▓▓▒▒▒░░░░░░░░░░░░░░░░░░░░▒▒▓▓█████████████{reset}",
            $"{dark}████████████▓▓▒▒░░░░                        ░░░░▒▒▓▓███████{reset}",
            $"{dark}██████████▓▓▒▒░░░                              ░░░▒▒▓▓██████{reset}",
            $"{dark}█████████▓▓▒▒░░                                  ░░▒▒▓▓█████{reset}",
            $"{dark}█████████▓▓▒░░                                    ░░▒▓▓█████{reset}",
            $"{dark}█████████▓▓▒░░                                    ░░▒▓▓█████{reset}",
            $"{dark}█████████▓▓▒░░                                    ░░▒▓▓█████{reset}",
            $"{dark}█████████▓▓▒▒░░                                  ░░▒▒▓▓█████{reset}",
            $"{dark}██████████▓▓▒▒░░░                              ░░░▒▒▓▓██████{reset}",
            $"{dark}████████████▓▓▒▒░░░░                        ░░░░▒▒▓▓███████{reset}",
            $"{dark}██████████████▓▓▒▒▒░░░░░░░░░░░░░░░░░░░░░░░░░▒▒▒▓▓███████████{reset}",
            $"{dark}█████████████████▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓███████████████{reset}",
            $"{dark}██████████████████████▓▓▓▓▓▓▓▓▓▓▓▓██████████████████████{reset}",
            $"{dark}████████████████████████████████████████████████████████{reset}"
            };

            foreach (string line in caveArt)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"\n{italic}{bold}\"Вы очнулись в глубокой пещере. " +
                $"Вокруг темнота, и лишь звук капающей откуда-то воды и дующего ветра доносятся издалека ...\"{reset}\n");
            Console.WriteLine("1.Оглядеться;");

            string chooseOne = Console.ReadLine();
            string[] caveArt_light = new string[]
            {
                $"{dark}████████████████████████████████████████████████████████{reset}",
                $"{dark}██████████████████████▓▓▓▓▓▓▓▓▓▓▓▓██████████████████████{reset}",
                $"{dark}█████████████████▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓█████████████████{reset}",
                $"{dark}██████████████▓▓▒▒▒░░░░░░░░░░░░░░░░░░░░▒▒▓▓█████████████{reset}",
                $"{dark}████████████▓▓▒▒░░░░                        ░░░░▒▒▓▓███████{reset}",
                $"{dark}██████████▓▓▒▒░░░                              ░░░▒▒▓▓██████{reset}",
                $"{dark}█████████▓▓▒▒░░                                  ░░▒▒▓▓█████{reset}",
                $"{dark}█████████▓▓▒░░                       {white}(  ) ( ){dark}      ░░▒▓▓█████{reset}",
                $"{dark}█████████▓▓▒░░                      {white}(      ){dark}       ░░▒▓▓█████{reset}",
                $"{dark}█████████▓▓▒░░                      {white}(    ){dark}       ░░▒▓▓█████{reset}",
                $"{dark}█████████▓▓▒▒░░                      {white}[ ]{dark}        ░░▒▒▓▓█████{reset}",
                $"{dark}██████████▓▓▒▒░░░                   /{dark}               ░░░▒▒▓▓██████{reset}",
                $"{dark}████████████▓▓▒▒░░░░               /{dark}               ░░░░▒▒▓▓███████{reset}",
                $"{dark}██████████████▓▓▒▒▒░░░░░░░        /{dark}        ░░░░░░░░▒▒▒▓▓███████████{reset}",
                $"{dark}█████████████████▓▓▓▒▒▒▒▒▒▒      /{dark}▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓███████████████{reset}",
                $"{dark}██████████████████████▓▓▓▓▓▓▓▓▓▓/{dark}▓▓██████████████████████████████{reset}",
                $"{dark}████████████████████████████████████████████████████████{reset}"
            };

            foreach (string line in caveArt_light)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"\n{italic}{bold}\"Оглядываясь вокруг, вы видите почти потухший факел.\"{reset}\n");
            Console.WriteLine("1.Взять факел;");
            chooseOne = Console.ReadLine();

            switch (chooseOne)
            {
                case "1":
                    Console.WriteLine($"\n*{underline}{bold}Вы подняли факел. Стало куда светлее!{reset}*\n");
                    break;
            }

            string[] caveArt_twoWays = new string[]
            {
                $"{dark}████████████████████████████████████████████████████████████████{reset}",
                $"{dark}██████████▓▓▓▓▓▓▓▓▓▓████████████████▓▓▓▓▓▓▓▓▓▓████████████████{reset}",
                $"{dark}██████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓██████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▓▓█████████████{reset}",
                $"{dark}████▓▓▒▒░░░░░░░░░░░░▒▒▓▓██████▓▓▒▒░░░░░░░░░░░░▒▒▓▓███████████{reset}",
                $"{dark}██▓▓▒▒░░░░          ░░▒▒▓▓████▓▓▒▒░░          ░░▒▒▓▓██████████{reset}",
                $"{dark}██▓▓▒▒░░              ░░▒▒▓▓██▓▓▒▒░░              ░░▒▒▓▓██████{reset}",
                $"{dark}██▓▓▒▒░░              ░░▒▒▓▓██▓▓▒▒░░              ░░▒▒▓▓██████{reset}",
                $"{dark}██▓▓▒▒░░              ░░▒▒▓▓██▓▓▒▒░░              ░░▒▒▓▓██████{reset}",
                $"{dark}██▓▓▒▒░░              ░░▒▒▓▓██▓▓▒▒░░              ░░▒▒▓▓██████{reset}",
                $"{dark}██▓▓▒▒░░              ░░▒▒▓▓██▓▓▒▒░░              ░░▒▒▓▓██████{reset}",
                $"{dark}██▓▓▒▒░░              ░░▒▒▓▓██▓▓▒▒░░              ░░▒▒▓▓██████{reset}",
                $"{dark}██▓▓▒▒░░              ░░▒▒▓▓██▓▓▒▒░░              ░░▒▒▓▓██████{reset}",
                $"{dark}██▓▓▒▒░░░░          ░░▒▒▓▓████▓▓▒▒░░░░          ░░▒▒▓▓████████{reset}",
                $"{dark}████▓▓▒▒▒░░░░░░░░░░▒▒▓▓██████▓▓▒▒▒░░░░░░░░░░▒▒▓▓█████████████{reset}",
                $"{dark}██████▓▓▒▒▒▒▒▒▒▒▒▒▒▓▓██████████▓▓▒▒▒▒▒▒▒▒▒▒▒▓▓███████████████{reset}",
                $"{dark}██████████▓▓▓▓▓▓▓▓▓▓████████████████▓▓▓▓▓▓▓▓▓▓████████████████{reset}",
                $"{dark}████████████████████████████████████████████████████████████████{reset}"
            };

            foreach (string line in caveArt_twoWays)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"\n{italic}{bold}\"Свет озарил большое пространство и спереди вы заметили два прохода заполненные тьмой. " +
                $"С одной стороны, идет слабый порыв ветра, с другой непонятный запах сырости и гнили ...\"{reset}");
            Console.WriteLine("\n1.Выбрать левый проход; \n2.Выбрать правый проход;");

            string chooseTwo = Console.ReadLine();
            switch (chooseTwo)
            {
                case "1":
                    Console.WriteLine($"{italic}{bold}Выбрав левый путь, вы направились в сторону веяния ветра в надежде найти выход.{reset}");
                    return Scene.CaveLocationOne;
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine($"{italic}{bold}Выбрав правый, вы направились на странных запах.{reset}"
                    + $"{italic}{bold}Дойдя до конца, вы обнаружили мистических существ, от чьих лап вы и погибли.{reset}");
                    break;
                default:
                    Console.WriteLine($"{italic}{bold}Вы не решились выбрать и остались навсегда в пещере...{reset}");
                    break;
            }

            return Scene.End;
        }
        static Scene CaveLocationOne()
        {
            Console.Clear();
            // Настройка консоли
            Console.OutputEncoding = Encoding.UTF8;

            // Стили текста
            string italic = "\x1b[3m";
            string bold = "\x1b[1m";
            string underline = "\x1b[4m";
            string reset = "\x1b[0m";

            // Цвета
            string white = "\x1b[38;5;15m";
            string dark = "\x1b[38;5;236m";

            string[] caveArt_waterfall = new string[]
            {
                $"{dark}████████████████████████████████████████████████████████{reset}",
                $"{dark}████████████████████▓▓▓▓▓▓▓▓▓▓████████████████████████{reset}",
                $"{dark}██████████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓████████████████████{reset}",
                $"{dark}████████████▓▓▒▒░░░░░░░░║║░░░░░░░░▒▒▓▓████████████████{reset}",
                $"{dark}██████████▓▓▒▒░░░░░░░░░║║║║░░░░░░░░▒▒▓▓██████████████{reset}",
                $"{dark}█████████▓▓▒▒░░░░░░░░░║║║║║░░░░░░░░▒▒▓▓█████████████{reset}",
                $"{dark}████████▓▓▒▒░░░░░░░░░║║║║║║░░░░░░░░▒▒▓▓████████████{reset}",
                $"{dark}████████▓▓▒▒░░░░░░░░░║║║║║║░░░░░░░░▒▒▓▓████████████{reset}",
                $"{dark}████████▓▓▒▒░░░░░░░░░║║║║║║░░░░░░░░▒▒▓▓████████████{reset}",
                $"{dark}████████▓▓▒▒░░░░░░░░░║║║║║║░░░░░░░░▒▒▓▓████████████{reset}",
                $"{dark}████████▓▓▒▒░░░░░░░░░║║║║║║░░░░░░░░▒▒▓▓████████████{reset}",
                $"{dark}████████▓▓▒▒░░░░░░░░░║║║║║║░░░░░░░░▒▒▓▓████████████{reset}",
                $"{dark}█████████▓▓▒▒░░░░░░░░▓▓▓▓▓▓░░░░░░░▒▒▓▓█████████████{reset}",
                $"{dark}██████████▓▓▒▒░░░░░▒▒▒▒▒▒▒▒▒░░░░░▒▒▓▓██████████████{reset}",
                $"{dark}████████████▓▓▒▒░░▒▒▒░░░░░▒▒▒░░▒▒▓▓████████████████{reset}",
                $"{dark}██████████████▓▓▒▒▒▒░░░░░░▒▒▒▒▒▓▓██████████████████{reset}",
                $"{dark}████████████████▓▓▓▒▒▒▒▒▒▒▒▒▓▓▓████████████████████{reset}",
                $"{dark}████████████████████▓▓▓▓▓▓▓▓███████████████████████{reset}"
            };

            foreach (string line in caveArt_waterfall)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"{italic}{bold}\"Пройдя по длинному пути, вы вышли в комнату с огромным водопадом. " +
                $"Часть стен были исписаны на непонятном вам языке.\"{reset}");
            Console.WriteLine("\n1.Подойти к водопаду;");

            string chooseOne = Console.ReadLine();

            switch (chooseOne)
            {
                case "1":
                    Console.WriteLine($"{italic}{bold}\"Подойдя к водопаду,вы вновь учуяли веяние ветра, но уже выше, откуда течет вода.\"{reset}");
                    break;
            }

            bool exploredWaterfall = false;
            bool foundRope = false;

            while (true)
            {
                Console.WriteLine("\n1.Взглянуть на водопад;\n2.Осмотреться;");

                if (exploredWaterfall && foundRope)
                {
                    Console.WriteLine("3.Закинуть верёвку и выбраться через отверстие;");
                }

                string chooseTwo = Console.ReadLine();

                switch (chooseTwo)
                {
                    case "1":
                        if (!exploredWaterfall)
                        {
                            Console.WriteLine($"{italic}{bold}\"Вы посмотрели на водопад. Он выглядит красиво." +
                            $"Сверху виднеется отверстие, в которое вы смогли бы пролезть.\"{reset}");

                            exploredWaterfall = true;
                        }
                        else
                        {
                            Console.WriteLine($"\n*{underline}{bold}Вы уже осмотрели водопад.{reset}*\n");
                        }
                        break;
                    case "2":
                        if (!foundRope)
                        {
                            Console.WriteLine($"{italic}{bold}\"Осмотревшись вокруг, вы натнкулись на большой моток веревки и ржавое заостренное металлическое изделие. " +
                            $"Немного подумав, вы сделали крюк-кошку.\"{reset}");

                            foundRope = true;
                        }
                        else
                        {
                            Console.WriteLine($"\n*{underline}{bold}Вы уже осмотрели комнату.{reset}*\n");
                        }
                        break;
                    case "3":
                        if (exploredWaterfall && foundRope)
                        {
                            Console.WriteLine($"{italic}{bold}Вы закинули крюк-кошку, поднялись и покинули комнату через отверстие у водопада.{reset}");
                            return Scene.CaveLocationTwo;
                        }
                        break;
                }
            }
        }
        static Scene CaveLocationTwo()
        {
            Console.Clear();

            // Настройка консоли
            Console.OutputEncoding = Encoding.UTF8;

            // Стили текста
            string italic = "\x1b[3m";
            string bold = "\x1b[1m";
            string underline = "\x1b[4m";
            string reset = "\x1b[0m";

            // Цвета
            string white = "\x1b[38;5;15m";
            string dark = "\x1b[38;5;236m";

            string[] caveArt_Ruins = new string[]
            {
                $"{dark}████████████████████████████████████████████████████████{reset}",
                $"{dark}██████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████████████████{reset}",
                $"{dark}█████████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓█████████████████{reset}",
                $"{dark}██████████▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░▒▒▓▓█████████████{reset}",
                $"{dark}████████▓▓▒▒░░                         ░░▒▒▓▓██████{reset}",
                $"{dark}██████▓▓▒▒░░      ████        ████      ░░▒▒▓▓████████{reset}",
                $"{dark}█████▓▓▒▒░░       █  █        █  █       ░░▒▒▓▓███████{reset}",
                $"{dark}████▓▓▒▒░░        █  █  ▄▄▄▄  █  █        ░░▒▒▓▓██████{reset}",
                $"{dark}████▓▓▒▒░░        █  █ █    █ █  █        ░░▒▒▓▓██████{reset}",
                $"{dark}████▓▓▒▒░░        █  █ █    █ █  █        ░░▒▒▓▓██████{reset}",
                $"{dark}████▓▓▒▒░░        █  █ █____█ █  █        ░░▒▒▓▓██████{reset}",
                $"{dark}████▓▓▒▒░░        ████        ████        ░░▒▒▓▓██████{reset}",
                $"{dark}████▓▓▒▒░░            ▄▄▄▄▄▄▄▄            ░░▒▒▓▓██████{reset}",
                $"{dark}████▓▓▒▒░░          ▄█▓▓▓▓▓▓▓▓█▄          ░░▒▒▓▓██████{reset}",
                $"{dark}█████▓▓▒▒░░        █▓▓▓▓▓▓▓▓▓▓▓█        ░░▒▒▓▓███████{reset}",
                $"{dark}██████▓▓▒▒░░░                            ░░░▒▒▓▓██████{reset}",
                $"{dark}████████▓▓▒▒░░░░                      ░░░░▒▒▓▓████████{reset}",
                $"{dark}██████████▓▓▒▒▒░░░░░░░░░░░░░░░░░░░░░▒▒▒▓▓████████████{reset}",
                $"{dark}█████████████▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓█████████████████{reset}",
                $"{dark}██████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████████████████{reset}",
                $"{dark}████████████████████████████████████████████████████████{reset}"
            };

            foreach (string line in caveArt_Ruins)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"{italic}{bold}\"Поднявшись по веревке, вы натыкаетесь на большую комнату с древними руинами" +
                $", чьи стены исписаны на том же языке, который вы видели ранее.\"{reset}");
            Console.WriteLine("\n1.Осмотреть руины;");

            string chooseOne = Console.ReadLine();

            switch (chooseOne)
            {
                case "1":
                    Console.WriteLine($"{italic}{bold}\"Подойдя ближе к руинам, вы услышали громкий протяжный вой, который не был похож на что-либо ранее слыханное вами." +
                        $"Пройдя дальше в глубь, кто-то стремительно направился в вашу сторону, но вы успели спрятаться. За вами кто-то следит ...\"{reset}");
                    break;
            }

            Console.WriteLine($"{italic}{bold}\n\"Пройдя глубже, вы наткнулись на две двери. Какую выбрать?\"{reset}");
            Console.WriteLine("\n1.Первая дверь;\n2.Вторая дверь;");

            string chooseTwo = Console.ReadLine();

            switch (chooseTwo)
            {
                case "1":
                    Console.WriteLine($"{italic}{bold}\"Выбрав первую дверь, вы видите очень длинный коридор, ведущий куда-то вдаль.\"{reset}");

                    if (!monsterEvent())
                        return Scene.End;

                    break;

                case "2":
                    Console.WriteLine($"{italic}{bold}Выбрав вторую дверь, вы оказались в огромной комнате." +
                        $"На потолке были огромные трещины. Из одной бил слабый луч солнца, который внушал надежду на выход," +
                        $"но вдруг вам падает камень на голову и вы умираете.{reset}");
                    return Scene.End;
            }

            Console.WriteLine($"{italic}{bold}\"Продолжив свой путь, идя по коридору вы замечаете что-то странное впереди.\"{reset}");
            Console.WriteLine("\n1.Осмотреться;");

            string chooseThree = Console.ReadLine();

            switch (chooseThree)
            {
                case "1":
                    Console.WriteLine($"{italic}{bold}\"Вы замечаете слабый свет в конце тоннеля, после чего стремительно направляетесь к выходу.\"{reset}");

                    if (!monsterEvent())
                        return Scene.End;

                    return Scene.CaveLocationExit;
            }

            return Scene.End;
        }
        static Scene CaveLocationExit()
        {
            // Настройка консоли
            Console.OutputEncoding = Encoding.UTF8;

            // Стили текста
            string italic = "\x1b[3m";
            string bold = "\x1b[1m";
            string underline = "\x1b[4m";
            string reset = "\x1b[0m";

            // Цвета
            string white = "\x1b[38;5;15m";
            string dark = "\x1b[38;5;236m";

            string[] caveArt_Exit = new string[]
            {
                $"{dark}████████████████████████████████████████████████████████{reset}",
                $"{dark}██████████████████▓▓▓▓▓▓▓▓▓▓▓▓▓▓██████████████████████{reset}",
                $"{dark}█████████████▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓█████████████████{reset}",
                $"{dark}██████████▓▓▒▒░░░░░░░░░░░░░░░░░░░░░░▒▒▓▓█████████████{reset}",
                $"{dark}████████▓▓▒▒░░                            ░░▒▒▓▓██████{reset}",
                $"{dark}██████▓▓▒▒░░         ██████████         ░░▒▒▓▓████████{reset}",
                $"{dark}█████▓▓▒▒░░        ███▒▒▒▒▒▒▒███        ░░▒▒▓▓███████{reset}",
                $"{dark}████▓▓▒▒░░        ██▒████████▒██        ░░▒▒▓▓███████{reset}",
                $"{dark}████▓▓▒▒░░       ██▒█════════█▒██       ░░▒▒▓▓███████{reset}",
                $"{dark}████▓▓▒▒░░       ██▒█════════█▒██       ░░▒▒▓▓███████{reset}",
                $"{dark}████▓▓▒▒░░       ██▒█════════█▒██       ░░▒▒▓▓███████{reset}",
                $"{dark}████▓▓▒▒░░       ██▒█════════█▒██       ░░▒▒▓▓███████{reset}",
                $"{dark}████▓▓▒▒░░       ██▒█════════█▒██       ░░▒▒▓▓███████{reset}",
                $"{dark}████▓▓▒▒░░       ██▒█════════█▒██       ░░▒▒▓▓███████{reset}",
                $"{dark}████▓▓▒▒░░       ██▒█════════█▒██       ░░▒▒▓▓███████{reset}",
                $"{dark}█████▓▓▒▒░░       ██▒████████▒██       ░░▒▒▓▓████████{reset}",
                $"{dark}██████▓▓▒▒░░░      ████▓▓████         ░░░▒▒▓▓████████{reset}",
                $"{dark}████████▓▓▒▒░░░░                    ░░░░▒▒▓▓█████████{reset}",
                $"{dark}██████████▓▓▒▒▒░░░░░░░░░░░░░░░░░░▒▒▒▓▓██████████████{reset}",
                $"{dark}█████████████▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓███████████████████{reset}",
                $"{dark}██████████████████▓▓▓▓▓▓▓▓▓▓▓▓███████████████████████{reset}",
                $"{dark}████████████████████████████████████████████████████████{reset}"
            };

            foreach (string line in caveArt_Exit)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"{italic}{bold}\n\"Идя вперед, вы натыкаетесь на брежно заколоченную дверь, через щели которой пробиваются лучи света.\"{reset}");
            Console.WriteLine("1.Попытаться сорвать доски с дверь;");

            string chooseOne = Console.ReadLine();
            bool doorOpen = false;

            while (true)
            {
                switch (chooseOne)
                {
                    case "1":
                        if (rng.Next(2) == 0)
                        {
                            Console.Clear();

                            Console.WriteLine($"{italic}{bold}\n\"Вам удалось сорвать доски и выйти наружу!\"{reset}");
                            doorOpen = true;

                            System.Threading.Thread.Sleep(3000);

                            Console.Clear();

                            string[] mountainLandscape = new string[]
                                {
                                    $"{dark}████████████████████████████████████████████████████████{reset}",
                                    $"{dark}████████████████████████████████████████████████████████{reset}",
                                    $"{dark}███████████████████▲████████████████▲██████████████████{reset}",
                                    $"{dark}██████████████████▲▲▲██████████████▲▲▲█████████████████{reset}",
                                    $"{dark}█████████████████▲▲▲▲▲████████████▲▲▲▲▲████████████████{reset}",
                                    $"{dark}███████████████▲▲▲▲▲▲▲██████████▲▲▲▲▲▲▲███████████████{reset}",
                                    $"{dark}██████████████▲▲▲▲▲▲▲▲▲████████▲▲▲▲▲▲▲▲▲██████████████{reset}",
                                    $"{dark}████████████████████████████████████████████████████████{reset}",
                                    $"{dark}██████████████♠██████♠████♠██████♠██████♠██████████████{reset}",
                                    $"{dark}████████████♠♠♠████♠♠♠██♠♠♠██♠♠♠████♠♠♠███████████████{reset}",
                                    $"{dark}███████████♠♠♠♠♠██♠♠♠♠♠██♠♠♠♠♠██♠♠♠♠♠████████████████{reset}",
                                    $"{dark}█████████████║██████║████║██████║██████║███████████████{reset}",
                                    $"{dark}█████████████║██████║████║██████║██████║███████████████{reset}",
                                    $"{dark}████████████████████████████████████████████████████████{reset}",
                                    $"{dark}██████████≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈████████████████{reset}",
                                    $"{dark}████████████≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈███████████████████{reset}",
                                    $"{dark}██████████████≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈≈██████████████████████{reset}",
                                    $"{dark}████████████████████████████████████████████████████████{reset}"
                                };

                            foreach (string line in mountainLandscape)
                            {
                                Console.WriteLine(line);
                            }

                            Console.WriteLine($"{italic}{bold}\n\"Вам удалось выбраться из пещеры живым, поздравляю!\"{reset}");
                            return Scene.CaveFinal;
                        }
                        else
                        {
                            Console.WriteLine($"{italic}{bold}\n\"Продолжайте стараться!\"{reset}");

                            doorOpen = false;

                            if (!monsterEvent())
                                return Scene.End;
                        }
                        break;
                }
            }

            return Scene.End;
        }
        static Scene CaveFinal()
        {
            // Настройка консоли
            Console.OutputEncoding = Encoding.UTF8;

            // Стили текста
            string italic = "\x1b[3m";
            string bold = "\x1b[1m";
            string underline = "\x1b[4m";
            string reset = "\x1b[0m";

            // Цвета
            string white = "\x1b[38;5;15m";
            string dark = "\x1b[38;5;236m";

            string[] logoFinal =
            {
                "=================================================================================",
                "   ____                            _         _       _   _                 ",
                "  / ___|___  _ __   __ _ _ __ __ _| |_ _   _| | __ _| |_(_) ___  _ __  ___ ",
                " | |   / _ \\| '_ \\ / _` | '__/ _` | __| | | | |/ _` | __| |/ _ \\| '_ \\/ __|",
                " | |__| (_) | | | | (_| | | | (_| | |_| |_| | | (_| | |_| | (_) | | | \\__ \\",
                "  \\____\\___/|_| |_| \\__, |_|  \\__,_|\\__|\\__,_|_\\\\__,_|\\__|_|\\___/|_| |_|___/",
                "                   |___/                                                   ",
                "                                                        ",
                "================================================================================="
            };

            foreach (string line in logoFinal)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"{italic}{bold}\n\"Спасибо, что опробовали мою игру!\"{reset}");

            Console.ReadLine();
            System.Threading.Thread.Sleep(10000);
            return Scene.StartCave;
        }
        static Scene End()
        {
            // Настройка консоли
            Console.OutputEncoding = Encoding.UTF8;

            // Стили текста
            string italic = "\x1b[3m";
            string bold = "\x1b[1m";
            string underline = "\x1b[4m";
            string reset = "\x1b[0m";

            // Цвета
            string white = "\x1b[38;5;15m";
            string dark = "\x1b[38;5;236m";

            string[] logoEnd =
            {
                "====================================",
                "  ____             _   _     ",
                " |  _ \\  ___  __ _| |_| |__  ",
                " | | | |/ _ \\/ _` | __| '_ \\ ",
                " | |_| |  __/ (_| | |_| | | |",
                " |____/ \\___|\\__,_|\\__|_| |_|",
                "                              ",
                "===================================="
            };

            foreach(string line in logoEnd)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine($"{italic}{bold}\n\"Вы умерли и остались в пещере.\"{reset}");

            Console.ReadLine();
            System.Threading.Thread.Sleep(10000);
            return Scene.StartCave;
        }
    }
}