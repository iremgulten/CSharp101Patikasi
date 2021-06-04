using System;
using System.Collections.Generic;
using System.Text;

namespace PROJE2_ToDo
{
    class CardManager
    {
        /*
        Kart Ekle   
        Kart Güncelle
        Kart Sil
        Kart Taşı
        Board Listeleme  İşlemleri bu classta yer alacak
        */
        public void ListBoard() // Board Listeleme Metodu
        {

            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            if (Board.ToDo.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in Board.ToDo)
                {
                    Console.WriteLine("Başlık      :{0}", item.Title);
                    Console.WriteLine("İçerik      :{0}", item.Content);
                    Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                    Console.WriteLine("Büyüklük    :{0}", item.Size);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine();

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            if (Board.InProgress.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in Board.InProgress)
                {
                    Console.WriteLine("Başlık      :{0}", item.Title);
                    Console.WriteLine("İçerik      :{0}", item.Content);
                    Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                    Console.WriteLine("Büyüklük    :{0}", item.Size);
                    Console.WriteLine("-");
                }
            }
            Console.WriteLine();

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            if (Board.Done.Count == 0)
            {
                Console.WriteLine("~ BOŞ ~");
            }
            else
            {
                foreach (var item in Board.Done)
                {
                    Console.WriteLine("Başlık      :{0}", item.Title);
                    Console.WriteLine("İçerik      :{0}", item.Content);
                    Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                    Console.WriteLine("Büyüklük    :{0}", item.Size);
                    Console.WriteLine("-");
                }
            }


        }
        public void AddCard()   // Kart Ekleme Metodu
        {
            Card card = new Card();

            Console.WriteLine("Başlık Giriniz                                  :");
            card.Title = Console.ReadLine();

            Console.WriteLine("İçerik Giriniz                                  :");
            card.Content = Console.ReadLine();

            Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            card.Size = (Size)int.Parse(Console.ReadLine());

            Console.WriteLine("Kişi ID Giriniz                                  :");
            card.MemberID = int.Parse(Console.ReadLine());
            int temp = 0;

            foreach (var item in MemberManager.Members)
            {
                if (item.ID == card.MemberID)
                {
                    temp++;
                    Board.ToDo.Add(card);
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Hatalı giriş yaptınız! Girilen ID'ye ait bir kullanıcı bulunamadı.");
            }
            else
            {
                Console.WriteLine("KART BAŞARILI BİR ŞEKİLDE EKLENDİ");
            }
        }
        public void DeleteCard()    // Kart Silme Metodu
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();

            int temp = 0;

            foreach (var item in Board.ToDo)
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    temp++;
                    Board.ToDo.Remove(item);
                    Console.WriteLine("SİLME İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                    break;
                }
            }
            foreach (var item in Board.InProgress)
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    temp++;
                    Board.InProgress.Remove(item);
                    Console.WriteLine("SİLME İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                    break;
                }
            }
            foreach (var item in Board.Done)
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    temp++;
                    Board.Done.Remove(item);
                    Console.WriteLine("SİLME İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                    break;
                }
            }

            if (temp == 0)
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");

                int selected = int.Parse(Console.ReadLine());
                if (selected == 1)
                {
                }
                else if (selected == 2)
                {
                    DeleteCard();
                }
            }
        }
        public void CarryCard() //Kart Taşıma Metodu
        {
            Console.WriteLine("Öncelikle güncellemek istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız:");
            string title = Console.ReadLine();

            Console.WriteLine("Bulunan Kart Bilgileri: ");
            Console.WriteLine("**************************************");

            int temp = 0;
            if (temp == 0)
            {
                foreach (var item in Board.ToDo)
                {
                    if (item.Title.ToLower() == title.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Başlık      :{0}", item.Title);
                        Console.WriteLine("İçerik      :{0}", item.Content);
                        Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                        Console.WriteLine("Büyüklük    :{0}", item.Size);
                        Console.WriteLine("Line        :ToDo");

                        ChooseLine();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                        }
                        else if (selected == 2)
                        {
                            Board.InProgress.Add(item);
                            Board.ToDo.Remove(item);
                        }
                        else if (selected == 3)
                        {
                            Board.Done.Add(item);
                            Board.ToDo.Remove(item);
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
            if (temp == 0)
            {
                foreach (var item in Board.InProgress)
                {
                    if (item.Title.ToLower() == title.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Başlık      :{0}", item.Title);
                        Console.WriteLine("İçerik      :{0}", item.Content);
                        Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                        Console.WriteLine("Büyüklük    :{0}", item.Size);
                        Console.WriteLine("Line        :InProgress");

                        ChooseLine();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                            Board.ToDo.Add(item);
                            Board.InProgress.Remove(item);
                        }
                        else if (selected == 2)
                        {

                        }
                        else if (selected == 3)
                        {
                            Board.Done.Add(item);
                            Board.InProgress.Remove(item);
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
            if (temp == 0)
            {
                foreach (var item in Board.Done)
                {
                    if (item.Title.ToLower() == title.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Başlık      :{0}", item.Title);
                        Console.WriteLine("İçerik      :{0}", item.Content);
                        Console.WriteLine("Atanan Kişi :{0}", item.MemberID);
                        Console.WriteLine("Büyüklük    :{0}", item.Size);
                        Console.WriteLine("Line        :ToDo");

                        ChooseLine();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                            Board.ToDo.Add(item);
                            Board.Done.Remove(item);
                        }
                        else if (selected == 2)
                        {
                            Board.InProgress.Add(item);
                            Board.Done.Remove(item);
                        }
                        else if (selected == 3)
                        {
                        }
                        Console.WriteLine("TAŞIMA İŞLEMİ GERÇEKLEŞTİRİLDİ.");
                        break;
                    }
                }
            }
        }
        public void ChooseLine()
        {
            Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");
        }
    }
}
