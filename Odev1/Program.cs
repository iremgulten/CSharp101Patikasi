using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
/* *** Item1
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            Console.Write("Giris yapilacak sayi adedi:   ");
            int count = Int32.Parse(Console.ReadLine());
            int[] number_array = new int[count];
            Console.WriteLine(count + " Adet pozitif sayi giriniz ");
            for (int i = 0; i < count; i++)
            {
                number_array[i] = Int32.Parse(Console.ReadLine());
                if (number_array[i] < 0)
                {
                    Console.WriteLine("Pozitif sayi girilmeli ! Lutfen tekrar giris yapin !");
                    i--;
                    continue;
                }
            }
            Item1 item1 = new();
            item1.EvenNumber(number_array);
*/

/* *** Item2
//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("Iki dogal sayi giriniz: ");
            int count = Int32.Parse(Console.ReadLine());
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(count + " Adet pozitif sayi giriniz ");
            int[] number_array = new int[count];
            for (int i = 0; i < count; i++)
            {
                number_array[i] = Int32.Parse(Console.ReadLine());
                if (number_array[i] < 0)
                {
                    Console.WriteLine("Pozitif sayi girilmeli ! Lutfen tekrar giris yapin !");
                    i--;
                    continue;
                }
            }
            Item2 item2 = new();
            item2.Control(number_array,number);
*/
/* *** Item3
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.Write("Giris yapilacak kelime adedi:   ");
            int count = Int32.Parse(Console.ReadLine());
            string[] word_array = new string[count];
            Console.WriteLine(count + " Adet kelime giriniz ");
            for (int i = 0; i < count; i++)
            {
                word_array[i] = Console.ReadLine();
            }
            Item3 item3 = new();
            item3.ReverseArray(word_array);
*/
//Item 4
//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın
            Console.WriteLine("Cumle giriniz: ");
            string sentence = Console.ReadLine();
            
            Item4 item4 = new();
            item4.NumberOfCharacter(sentence);
            item4.NumberOfWord(sentence);


        }
    }

    public class Item1
    {
        public void EvenNumber(int[] param)
        {
            Console.WriteLine("\nCift Sayilar: ");
            foreach (int number in param)
            {
                if (number % 2 == 0)
                    Console.WriteLine(number);
            }
        }
    }
    public class Item2{

        public void Control(int[] param,int number)
        {
            Console.WriteLine(number + " Sayisina esit sayilar : ");
            foreach (int item in param)
            {
                if (item == number){
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine(number + " Sayisina tam bolunen sayilar : ");
            foreach (int item in param)
            {
                if (item%number == 0){
                    Console.WriteLine(item);
                }
            }
        }

    }
    public class Item3{

        public void ReverseArray(string[] array){
            Array.Reverse(array);
            Console.WriteLine("Kelimeler sondan basa dogru yaziliyor : ");
            foreach (var word in array)
            {
                Console.WriteLine(word);
            }

        }
    }
    public class Item4{
        public void NumberOfCharacter(string param){
            string[] words = param.Split(' ','.',':',',',';','!','?');
            string characters=null;
            foreach(string item in words){
                characters = characters+item;
            }
            Console.WriteLine("Harf sayisi : "+characters.Length);

        }
        public void NumberOfWord(string param){
            string[] words = param.Split(" ");
            Console.WriteLine("Kelime sayisi : "+words.Length);
        }
    }

}
