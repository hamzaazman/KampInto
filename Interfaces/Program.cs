using System;

namespace Interfaces
{
    class Program
    {
        //interface new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();
            ProjectManager projectManager = new ProjectManager();
            IPersonManager customerManager = new CustomerManager();
            IPersonManager employeeManager = new EmployeeManager();
            IPersonManager internManager = new InternManager();

            projectManager.Add(employeeManager);
            projectManager.Add(customerManager);
            projectManager.Add(internManager);

            projectManager.Update(employeeManager);
            projectManager.Update(customerManager);
            projectManager.Update(internManager);

        }
    }
    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları, simüle ettim.
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
}
