using Shopping.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Shopping
{
    class Program
    {
        public static object ToInt32 { get; private set; }

        static void Main(string[] args)
        {
            Regex regex1 = new Regex(@"^[a-zA-Z]+$");
            Regex numbers = new Regex(@"^[d]+$");

            Person person1 = new Person();
            Employee employee1 = new Employee();
            Client client1 = new Client();
            Product product1 = new Product();
            Order order1 = new Order();


            Console.WriteLine("Secim edin");
            Console.WriteLine("I - ishci yaratmaq");
            Console.WriteLine("M - mushteri yaratmaq");
            Console.WriteLine("P - mehsul yaratmaq");
            Console.WriteLine("O - sifarish yaratmaq");

            string Choice;
            string Choice2;
            string Choice3;
            string Choice4;

            int EmployeeCardId = employee1.CardId;

            Console.WriteLine("Seciminiz: ");
            do
            {
                Choice = Console.ReadLine().ToLower();

                if (Choice != "i")
                {
                    Console.WriteLine("Bu seviyyede yalniz i kecerlidir");

                }
                //Name
                if (Choice == "i")
                {
                    do
                    {
                        Console.Write("Ishci adinizi daxil edin: ");
                        employee1.Name = Console.ReadLine();

                        if (regex1.IsMatch(employee1.Name) != true)
                        {
                            Console.WriteLine("Adinizi duzgun daxil edin!");
                        };
                    } while (!regex1.IsMatch(employee1.Name) == true);
                    //Surname
                    do
                    {
                        Console.Write("Soyadinizi daxil edin: ");
                        employee1.Surname = Console.ReadLine();

                        if (regex1.IsMatch(employee1.Surname) != true)
                        {
                            Console.WriteLine("Soyadinzi duzgun daxil edin!");
                        };
                    } while (!regex1.IsMatch(employee1.Surname) == true);

                    //Age


                    try
                    {
                        Console.Write("Doguldugunuz ili daxil edin: ");
                        employee1.Birthday = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Write("Doguldugunuz ili duzgun daxil edin: ");
                        employee1.Birthday = Convert.ToInt32(Console.ReadLine());
                    };


                    //Card ID

                    try
                    {
                        Console.Write("Card Id ili daxil edin: ");
                        employee1.CardId = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Write("Card id duzgun daxil edin: ");
                        employee1.CardId = Convert.ToInt32(Console.ReadLine());
                    };

                    //Position
                    Console.Write("Vezifenizi daxil edin: ");
                    employee1.Position = Console.ReadLine();

                    //Salary
                    try
                    {
                        Console.Write("Maas daxil edin: ");
                        employee1.Salary = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Write("Maasi duzgun daxil edin: ");
                        employee1.Salary = Convert.ToInt32(Console.ReadLine());
                    };


                    Console.WriteLine($"Ishci yaradildi.Id {employee1.IdInc()}, Adi: {employee1.Name}, " +
                        $"Soyadi: {employee1.Surname}, ili: {employee1.Birthday}, " +
                        $"card id: {employee1.CardId}, vezifesi: {employee1.Position}," +
                        $"maasi : {employee1.Salary}AZN");

                    Console.WriteLine("========================================================================");
                }
            }
            while (Choice != "i");


            Console.WriteLine("Secim edin");
            Console.WriteLine("I - ishci yaratmaq");
            Console.WriteLine("M - mushteri yaratmaq");
            Console.WriteLine("P - mehsul yaratmaq");
            Console.WriteLine("O - sifarish yaratmaq");


            Console.WriteLine("Seciminiz: ");
            do
            {
                Choice2 = Console.ReadLine().ToLower();

                if (Choice2 != "m")
                {
                    Console.WriteLine("Bu seviyyede yalniz m kecerlidir");

                }
                if (Choice2 == "m")
                {
                    //Name
                    do
                    {
                        Console.Write("Musteri adinizi daxil edin: ");
                        client1.Name = Console.ReadLine();

                        if (regex1.IsMatch(client1.Name) != true)
                        {
                            Console.WriteLine("Adinizi duzgun daxil edin!");
                        };
                    } while (!regex1.IsMatch(client1.Name) == true);
                    //Surname
                    do
                    {
                        Console.Write("Soyadinizi daxil edin: ");
                        client1.Surname = Console.ReadLine();

                        if (regex1.IsMatch(client1.Surname) != true)
                        {
                            Console.WriteLine("Soyadinzi duzgun daxil edin!");
                        };
                    } while (!regex1.IsMatch(client1.Surname) == true);

                    //Age

                        try
                        {
                            Console.Write("Doguldugunuz ili daxil edin: ");
                            client1.Birthday = Convert.ToInt32(Console.ReadLine());
                        }
                        catch(Exception)
                        {
                            Console.Write("Doguldugunuz ili duzgun daxil edin: ");
                            client1.Birthday = Convert.ToInt32(Console.ReadLine());
                        };



                    //Card ID

                    try
                    {
                        Console.Write("Card Id daxil edin: ");
                        client1.CardId = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Write("Card idsini duzgun daxil edin: ");
                        client1.CardId = Convert.ToInt32(Console.ReadLine());
                    };

                    //CLient Id 
                    do
                    {
                        Console.Write("Musteri kodunuzu daxil edin(Yalniz herfler): ");
                        client1.ClientId = Console.ReadLine();

                        if (regex1.IsMatch(client1.ClientId) != true)
                        {
                            Console.WriteLine("Musteri kodunuzu duzgun daxil edin!");
                        };
                    } while (!regex1.IsMatch(client1.ClientId) == true);
                    //Client adress 
                    do
                    {
                        Console.Write("Adress daxil edin(Yalniz herfler): ");
                        client1.Adress = Console.ReadLine();

                        if (regex1.IsMatch(client1.Adress) != true)
                        {
                            Console.WriteLine("Adressinizi duzgun daxil edin!");
                        };
                    } while (!regex1.IsMatch(client1.Adress) == true);
                    //CLIENT phone number
                    Console.Write("Telefon nomrenizi daxil edin: ");
                    client1.Phone = Convert.ToInt64(Console.ReadLine());


                    Console.WriteLine($"Musteri yaradildi.Id {client1.IdInc()}, Adi: {client1.Name}, " +
                        $"Soyadi: {client1.Surname}, ili: {client1.Birthday}, " +
                        $"card id: {client1.CardId}, musteri kodu: {client1.ClientId}," +
                        $"adressi : {client1.Adress}, mobil : {client1.Phone}");
                    Console.WriteLine("=============================================================");
                }
                
            }
            while (Choice2 != "m");

            Console.WriteLine("Secim edin");
            Console.WriteLine("I - ishci yaratmaq");
            Console.WriteLine("M - mushteri yaratmaq");
            Console.WriteLine("P - mehsul yaratmaq");
            Console.WriteLine("O - sifarish yaratmaq");

            Console.WriteLine("Seciminiz: ");
            do
            {
                Choice3 = Console.ReadLine().ToLower();

                if (Choice3 != "p")
                {
                    Console.WriteLine("Bu seviyyede yalniz p kecerlidir");
                }
                if (Choice3 == "p")
                {
                    //Mehsul adi 
                    Console.WriteLine("Mehsul adi daxil edin: ");
                    product1.ProName = Console.ReadLine();

                    //Mehsul rengi
                    Console.WriteLine("Mehsulun rengini daxil edin: ");
                    product1.Color = Console.ReadLine();
                    //Mehsul qiymeti
                    try
                    {
                        Console.Write("Qiymetini daxil edin: ");
                        product1.Price = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Write("Qiymetini duzgun daxil edin: ");
                        product1.Price = Convert.ToInt32(Console.ReadLine());
                    };


                    Console.WriteLine($"Mehsul yaradildi.Id {product1.IdInc()}, Adi: {product1.ProName}, " +
                        $"rengi: {product1.Color}, qiymeti: {product1.Price}AZN");
                    Console.WriteLine("==================================================");
                }

            }
            while (Choice3 != "p");

            //SIFARIS

            Console.WriteLine("Secim edin");
            Console.WriteLine("I - ishci yaratmaq");
            Console.WriteLine("M - mushteri yaratmaq");
            Console.WriteLine("P - mehsul yaratmaq");
            Console.WriteLine("O - sifarish yaratmaq");

            Client client2 = new Client();
            Product product2 = new Product();

            Console.WriteLine("Seciminiz: ");
            do
            {
                Choice4 = Console.ReadLine().ToLower();

                if (Choice4 != "o")
                {
                    Console.WriteLine("Bu seviyyede yalniz o kecerlidir");

                }
                if (Choice4 == "o")
                {
                    //Sifaris sahibi
                    do
                    {
                        Console.Write("Musteri adinizi daxil edin: ");
                        client2.Name = Console.ReadLine();

                        if (regex1.IsMatch(client2.Name) != true)
                        {
                            Console.WriteLine("Adinizi duzgun daxil edin!");
                        };
                    } while (!regex1.IsMatch(client2.Name) == true);

                    //Siafris adi
                    do
                    {
                        Console.Write("Sifarisi daxil edin: ");
                        product2.ProName = Console.ReadLine();

                        if (regex1.IsMatch(product2.ProName) != true)
                        {
                            Console.WriteLine("Sifarisi duzgun daxil edin!");
                        };
                    } while (!regex1.IsMatch(product2.ProName) == true);
                    //Mehsul sayi
                    try
                    {
                        Console.Write("Sayi teqdim edin: ");
                        order1.Count = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.Write("Sayi duzgun daxil edin: ");
                        order1.Count = Convert.ToInt32(Console.ReadLine());
                    };


                    Console.WriteLine($"Sifarish yaradildi.Id {order1.IdInc()}, Mehsul adi: {product2.ProName}, " +
                        $"{client2.Name} terefinden siafris edildi.Sayi: {order1.Count},qiymeti: " +
                        $"{order1.Count * product1.Price}AZN.Sifarisi qebul eden: {employee1.FullName()}, {employee1.Position}");
                }

            }
            while (Choice4 != "o");

            Console.ReadLine();


        }

    }
}









