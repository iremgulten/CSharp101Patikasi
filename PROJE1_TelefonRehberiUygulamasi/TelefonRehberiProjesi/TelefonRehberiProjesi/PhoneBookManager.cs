using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiProjesi
{
    class PhoneBookManager  //Telefon rehberindeki yapilacak tüm islemler burada gerceklesmektedir.
    {
        public void SaveNumber(Person newPerson)    //Yeni kisi ekleme metodu
        {
            PhoneBook.phoneBook.Add(newPerson); //Yeni kisi ekleniyor
            Console.WriteLine("Kişi başarıyla eklendi..\n");
        }
        public void DeleteNumber(string nameSurname)    //Rehberden kisi silme metodu
        {
            Console.WriteLine();
            int temp = 0; 
            foreach (var item in PhoneBook.phoneBook)
            {
                if (nameSurname.ToLower() == item.Name.ToLower() || nameSurname.ToLower() == item.Surname.ToLower())
                {   
                    temp++;
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ? (Y/N)", item.Name);
                    string select1 = Console.ReadLine();
                    select1.ToUpper();
                    if (select1 == "Y") //Numara siliniyor
                    {
                        PhoneBook.phoneBook.Remove(item);
                        Console.WriteLine("Silme işlemi başarıyla tamamlandı.");
                        break;
                    }
                    else if (select1 == "N")
                    {
                        break;
                    }
                }
            }
            if(temp == 0)   //Eger girilen kisi rehberde bulunamazsa
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                int select = int.Parse(Console.ReadLine());
                if (select == 2)
                {
                    Program.DeleteNumber();
                }
            }
        }
        public void UpdateNumber(string nameSurname)    //Rehberde numara guncelleme metodu 
        {
            Console.WriteLine();
            int temp = 0;
            foreach (var item in PhoneBook.phoneBook)
            {
                if (nameSurname.ToLower() == item.Name.ToLower() || nameSurname.ToLower() == item.Surname.ToLower())
                {   //Numara guncelleniyor
                    temp++;
                    Console.WriteLine("Lütfen yeni telefon numarasını giriniz.");
                    string newNumber = Console.ReadLine();
                    item.GsmNumber = newNumber;
                    break;
                }
            }
            if (temp == 0) //Eger girilen kisi rehberde bulunamazsa
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                int select = int.Parse(Console.ReadLine());
                if (select == 2)
                {
                    Program.UpdateNumber();
                }
            }
        }
        public void ShowPhoneBook(int selected)     //Rehber listeleme metodu
        {
            Console.WriteLine();
            if (selected == 1)  //A-Z Listeleme
            {
                PhoneBook.phoneBook.Sort((o1, o2) => o1.Name.CompareTo(o2.Name));
            }
            else if (selected == 2) //Z-A Listeleme
            {
                PhoneBook.phoneBook.Sort((o1, o2) => o1.Name.CompareTo(o2.Name));
                PhoneBook.phoneBook.Reverse();
            }

            foreach (var item in PhoneBook.phoneBook)   //Listeleme gerceklestiriliyor
            {
                Console.WriteLine("İsim : {0}", item.Name);
                Console.WriteLine("Soyisim : {0}", item.Surname);
                Console.WriteLine("Telefon Numarası : {0}", item.GsmNumber);
                Console.WriteLine("-");
            }
        }
        public void SearcInPhoneBook(int selected)  //Rehberde arama yapma metodu
        {
            Console.WriteLine();
            if (selected == 1)  //isim veya soyisime göre arama
            {
                Console.Write("İsim veya soyisim giriniz: ");
                string nameSurname = Console.ReadLine();


                Console.WriteLine("Arama sonuçlarınız:");
                Console.WriteLine("**********************************************\n");
                foreach (var item in PhoneBook.phoneBook)   //Arama sonucu listeleniyor
                {
                    if (item.Name.ToLower() == nameSurname.ToLower() || item.Surname.ToLower() == nameSurname.ToLower())
                    {
                        Console.WriteLine("İsim : {0}", item.Name);
                        Console.WriteLine("Soyisim : {0}", item.Surname);
                        Console.WriteLine("Telefon : {0}", item.GsmNumber);
                    }
                }
            }
            else if (selected == 2) //telefon numarasina göre arama
            {
                Console.Write("Telefon numarası giriniz: ");
                string gsmNumber = Console.ReadLine();

                Console.WriteLine("Arama sonuçlarınız:");
                Console.WriteLine("**********************************************\n");
                foreach (var item in PhoneBook.phoneBook)   //Arama sonucu listeleniyor
                {
                    if (item.GsmNumber == gsmNumber)
                    {
                        Console.WriteLine("İsim : {0}", item.Name);
                        Console.WriteLine("Soyisim : {0}", item.Surname);
                        Console.WriteLine("Telefon : {0}", item.GsmNumber);
                    }
                }
            }
        }
    }
}
