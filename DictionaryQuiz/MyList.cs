using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryQuiz
{
    class MyList<T1,T2>
    {
        T1[] IdentifyNumber;
        T2[] name;

        public MyList()
        {
            IdentifyNumber = new T1[0];
            name = new T2[0];
        }
        public void Add(T1 Number, T2 Name)
        {
            T1[] tempNumber = IdentifyNumber;
            T2[] tempName = name;
            IdentifyNumber = new T1[IdentifyNumber.Length + 1];
            name = new T2[name.Length + 1];

            for (int i = 0; i < tempNumber.Length; i++)
            {
                IdentifyNumber[i] = tempNumber[i]; 
            }
            for (int i = 0; i < tempName.Length; i++)
            {
                name[i] = tempName[i];
            }

            IdentifyNumber[IdentifyNumber.Length - 1] = Number;
            name[name.Length - 1] = Name;

            Console.WriteLine(Number + " Numaralı " + Name + " Adlı kişi eklendi");

        }

    }
}
