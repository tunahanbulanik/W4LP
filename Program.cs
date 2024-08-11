using System;

namespace W4LP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true; // For contuinuing the program

            while (continueRunning)
            {
                bool validChoice = false;
                while (!validChoice)
                {
                    Console.WriteLine("Telefon üretmek için 1'i, bilgisayar üretmek için 2'yi tuşlayınız:");
                    char userChoice = char.Parse(Console.ReadLine());

                    if (userChoice == '1')
                    {
                        Phone phone = new Phone(15748, "iPhone 15", "Smart phone", "iOS", "TR-15485845");
                        phone.Details();
                        validChoice = true; 
                    }
                    else if (userChoice == '2')
                    {
                        Computer computer = new Computer(14878, "Asus ST5656", "Handbook", "Windows", 4, true);
                        computer.Details();
                        validChoice = true; 
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir değer giriniz");
                    }
                }

                
                bool validSecondChoice = false;
                while (!validSecondChoice)
                {
                    Console.WriteLine("Başka bir ürün oluşturmak isterseniz 'evet', istemezseniz 'hayır' diyebilirsiniz:");
                    string userSecondChoice = Console.ReadLine().ToLower();

                    if (userSecondChoice == "evet")
                    {
                        validSecondChoice = true; 
                    }
                    else if (userSecondChoice == "hayır")
                    {
                        Console.WriteLine("İyi günler!");
                        continueRunning = false; 
                        validSecondChoice = true; 
                    }
                    else
                    {
                        Console.WriteLine("Geçerli bir değer giriniz");
                    }
                }
            }
        }
    }
}
