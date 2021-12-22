using _1._1._1_Rectangle;
using System;


namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            int EnterArrowIndex = 0;
            int StaticMenuIndex = 0;
            char EnterArrow = (char)0017;

            int MenuLength = 0;
            int MenuLogicCase = 0;

            MainMenu(ref EnterArrowIndex, EnterArrow, ref MenuLength, ref MenuLogicCase, ref StaticMenuIndex);
            MenuEventListner(ref EnterArrowIndex, EnterArrow, MenuLength, ref MenuLogicCase, StaticMenuIndex);
        }

        public static void MainMenu(ref int EnterArrowIndex, char EnterArrow, ref int MenuLength, ref int MenuLogicCase, ref int StaticMenuIndex)
        {
            string[] MenuItems = {
            "1.1 The magnificent ten (0/10) ",
            "1.2 String, not sting (0/4) ",
            "1.3 unknown (empty) ",
            "1.4 unknown (empty) ",
            "1.5 unknown (empty) "
            };


            string[] MenuItemsTemp = MenuItems;
          

            switch (MenuLogicCase)
            {            
                case 1:
                    StaticMenuIndex = EnterArrowIndex;
                    MenuLogicCase = 2;
                    EnterArrowIndex = 0;
                    MainMenu(ref EnterArrowIndex, EnterArrow, ref MenuLength, ref MenuLogicCase, ref StaticMenuIndex);
                    break;
                case 2:                
                    SubMenu sub = new SubMenu();
                    string[] SubMenuTemp = sub.SubMenuStorage(StaticMenuIndex);
                    MenuLength = SubMenuTemp.Length;
                    SubMenuTemp[EnterArrowIndex] = SubMenuTemp[EnterArrowIndex] + EnterArrow;
                    foreach (var item in MenuItemsTemp[0..(StaticMenuIndex + 1)])
                    {
                        Console.WriteLine(item);
                    }

                    foreach (var item in SubMenuTemp)
                    {
                        Console.WriteLine("     -" + item);
                    }
                    foreach (var item in MenuItemsTemp[(StaticMenuIndex + 1)..^0])
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    MenuLength = MenuItems.Length;
                    MenuItemsTemp[EnterArrowIndex] = MenuItemsTemp[EnterArrowIndex] + EnterArrow;

                    foreach (var item in MenuItemsTemp[0..^0])
                    {
                        Console.WriteLine(item);
                    }
                    break;
            }
   
        }
        public static void MenuEventListner(ref int EnterArrowIndex, char EnterArrow, int MenuLength, ref int MenuLogicCase, int StaticMenuIndex)
        {
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.DownArrow)
                 {
                    EnterArrowIndex = EnterArrowIndex < MenuLength - 1 ? EnterArrowIndex + 1 : 0;
                    Console.Clear();
                    MainMenu(ref EnterArrowIndex, EnterArrow, ref MenuLength, ref MenuLogicCase, ref StaticMenuIndex);
                 } 
                else if (cki.Key == ConsoleKey.UpArrow)
                 {
                    EnterArrowIndex = EnterArrowIndex > 0 ? EnterArrowIndex - 1 : MenuLength - 1;
                    Console.Clear();
                    MainMenu(ref EnterArrowIndex, EnterArrow, ref MenuLength, ref MenuLogicCase, ref StaticMenuIndex);
                 } 
                else if (cki.Key == ConsoleKey.Enter)
                 {

                    switch (MenuLogicCase)
                    {
                        case 2:
                            Console.Clear();
                        
                            SubMenu SubCall = new SubMenu();
                            SubCall.ClassCall(StaticMenuIndex, EnterArrowIndex);
                            break;
                        default:
                            Console.Clear();
                            MenuLogicCase = 1;
                            MainMenu(ref EnterArrowIndex, EnterArrow, ref MenuLength, ref MenuLogicCase, ref StaticMenuIndex);
                    break;
                    }
                }
                else if (cki.Key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    MenuLogicCase = 0;
                    EnterArrowIndex = 0;
                    MainMenu(ref EnterArrowIndex, EnterArrow, ref MenuLength, ref MenuLogicCase, ref StaticMenuIndex);
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

    }
    public class SubMenu
    {
        public string[] SubMenuStorage(int EnterArrowIndex)
        {
            string[] TheMagnificentTenMenu = {
            "1.1.1 Rectangle ",
            "1.1.2 Triangle ",
            "1.1.3 Another triangle ",
            "1.1.4 X-max tree ",
            "1.1.5 Sum of numbers ",
            "1.1.6 Font adjusment ",
            "1.1.7 Array processing ",
            "1.1.8 No positive ",
            "1.1.9 Non-negative sum ",
            "1.1.10 2D array "
            };
            string[] StringNotSting = {
            "1.2.1 Averages ",
            "1.2.2 Doubler ",
            "1.2.3 Lowercase ",
            "1.2.4 Validator ",
            };
   
            string[] ErrorCatch = { 
            "menu is nonexistent",
            "menu is nonexistent",
            "menu is nonexistent",
            "menu is nonexistent",
            "menu is nonexistent",
            "menu is nonexistent",
            "menu is nonexistent",
            "menu is nonexistent"
            };
            
            string[][] SubMenuItems = new string[2][];
            SubMenuItems[0] = TheMagnificentTenMenu;
            SubMenuItems[1] = StringNotSting;

            string[] rtn = EnterArrowIndex < SubMenuItems.Length ? SubMenuItems[EnterArrowIndex] : ErrorCatch;
            return rtn;
        }

        public void GetPosition(int EnterArrowIndex)
        {
            Console.WriteLine(EnterArrowIndex);
        }

        
        public void ClassCall(int StaticMenuIndex, int EnterArrowIndex)
        {
            switch (StaticMenuIndex)
            {
                case 0:
                {
                        TheMagnificentTenSwitch(EnterArrowIndex);
                        break;
                }
                 default:
                    {
                        Console.WriteLine("the task does not exist or is not ready");
                        break;
                    }
            }
        }

        public void TheMagnificentTenSwitch(int EnterArrowIndex)
        {
            switch (EnterArrowIndex)
            {
                case 0:
                    {
                        Rectangle.Main();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("the subtask does not exist or is not ready");
                        break;
                    }
            }
        }

    }
}

