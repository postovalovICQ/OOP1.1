using System;

namespace oop1._1_ho4u_tri
{
    class Program
    {
        class Buyerdetails
        {
            public string Name;
            public string Surname;
            public string Patronymic;
            internal string Creditcard;
            internal string Bankaccount;
        }
        static void Main(string[] args)
        {
            Buyerdetails Buyer = new Buyerdetails();

            Console.Write("Введите фамилию: ");
            Buyer.Surname = Convert.ToString(Console.ReadLine());

            Console.Write("Введите имя: ");
            Buyer.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Введите отчество: ");
            Buyer.Patronymic = Convert.ToString(Console.ReadLine());

            Console.Write("Номер кредитной карточки: ");
            Buyer.Creditcard = Convert.ToString(Console.ReadLine());

            Console.Write("Номер банковского счета: ");
            Buyer.Bankaccount = Convert.ToString(Console.ReadLine());

            Console.WriteLine("------------------------");
            Console.WriteLine("------------------------");
            Console.WriteLine(Buyer.Surname);
            Console.WriteLine(Buyer.Name);
            Console.WriteLine(Buyer.Patronymic);
            Console.WriteLine(Buyer.Creditcard);
            Console.WriteLine(Buyer.Bankaccount);
            Console.WriteLine("------------------------");
            Console.ReadLine();
        }
    }
}
