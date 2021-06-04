using System;

namespace PROJE2_ToDo
{
    class Program
    {
        static Board board = new Board();
        
        public static int selection = 0;
        static void Main(string[] args)
        {
            while(selection != 5)
            {
                Menu();
                if (selection < 0 && selection > 5)
                {
                    Console.WriteLine("Lütfen geçerli bir işlem seçiniz..");
                    selection = int.Parse(Console.ReadLine());
                }

                switch (selection)
                {
                    case 1:
                        ListBoard();
                        break;
                    case 2:
                        AddCard();
                        break;
                    case 3:
                        DeleteCard();      
                        break;
                    case 4:
                        CarryCard();
                        break;
                }
            }
        }

        static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(5) Çıkış");

            selection = int.Parse(Console.ReadLine());
        }
        public static void ListBoard()
        {
            CardManager manager = new CardManager();
            manager.ListBoard();

        }
        public static void AddCard()
        {
            CardManager manager = new CardManager();
            manager.AddCard();
        }
        public static void DeleteCard()
        {
            CardManager manager = new CardManager();
            manager.DeleteCard();
        }
        public static void CarryCard()
        {
            CardManager manager = new CardManager();
            manager.CarryCard();
        }

    }
}
