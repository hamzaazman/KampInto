using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone();
            Phone phone2 = new Phone();
            Phone phone3 = new Phone();

            phone1.phoneId = 1;
            phone1.phoneName = "Samsung Galaxy S21";
            phone1.phonePrice = 9999;
            phone2.phoneId = 2;
            phone2.phoneName = "iPhone 12";
            phone2.phonePrice = 10538;
            phone3.phoneId = 3;
            phone3.phoneName = "Xiaomi Redmi Note 9 Pro";
            phone3.phonePrice = 3169;

            Phone[] mobile = new Phone[] {phone1,phone2,phone3};


            for (int i = 0; i < mobile.Length; i++)
            {
                Console.WriteLine(mobile[i].phoneId +" "+ mobile[i].phoneName +" "+ mobile[i].phonePrice);
            }

            Console.WriteLine("***");

            foreach (var phone in mobile)
            {
                Console.WriteLine(phone.phoneId + " " + phone.phoneName + " " + phone.phonePrice);
            }

            Console.WriteLine("***");

            int s = 0;
            while (s < mobile.Length)
            {
                Console.WriteLine(mobile[s].phoneId + " " + mobile[s].phoneName + " " + mobile[s].phonePrice);
                s++;
            }

        }

        class Phone
        {
            public int phoneId { get; set; }
            public string phoneName { get; set; }
            public int phonePrice { get; set; }
        }

    }
}
