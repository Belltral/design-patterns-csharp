using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.Builder.Classes;
using DesignPatterns.Creational.Builder.Classes.Classes;
using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Creational.FactoryMethod.Main;
using DesignPatterns.Creational.FactoryMethod.Utils;
using DesignPatterns.Creational.Prototype.DeepCopy;
using DesignPatterns.Creational.Singleton;
using System.Runtime;

namespace DesignPatterns
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var singleton = Singleton.GetInstance();
            //singleton.SetNome("Singleton");
            //Console.WriteLine(singleton.GetNome());

            //var mainDishBuilder = new MainDishBuilder();
            //mainDishBuilder.MakeMeal();
            //Console.WriteLine(mainDishBuilder);

            #region Prototype
            ////Shallow Copy
            ////Cria objeto do tipo Person
            //Person person = new Person { Name = "Zé", Age = 55 };
            ////Clona o objeto
            //Person person_clone = (Person)person.Clone();
            ////Valores de person
            //Console.WriteLine("Person: ");
            //Console.WriteLine("  " + person.Name + " " + person.Age);
            ////Valores de person_clone
            //Console.WriteLine("Person Clone:");
            //Console.WriteLine("  " + person_clone.Name + " " + person_clone.Age);

            ////Deep Copy
            //PersonDeep p1 = new PersonDeep();
            //p1.Age = 42;
            //p1.Name = "Sam";
            //p1.Address = new Address("Rua Tal", 999, "12345678");

            //PersonDeep p2 = p1.DeepCopy();
            //p2.Name = "Paul";
            //p2.Age = 20;

            //Console.WriteLine("Person 1:");
            //Console.WriteLine(
            //    $"  Name {p1.Name}, age {p1.Age}\n" +
            //    $"  Address: {p1.Address.AddressName}, number {p1.Address.Number}\n" +
            //    $"  Postal: {p1.Address.Postal}"
            //);

            //Console.WriteLine("Person 2:");
            //Console.WriteLine(
            //    $"  Name {p2.Name}, age {p2.Age}\n" +
            //    $"  Address: {p2.Address.AddressName}, number {p2.Address.Number}\n" +
            //    $"  Postal: {p2.Address.Postal}"
            //);
            #endregion


            #region Factory Method
            //var carFactory = new CarFactory();
            //var fusca = carFactory.GetVehicle("Fusca");
            //fusca.PickUp("Joana");
            //fusca.Stop();

            //string[] customerNames = new string[4] { "Ana", "Joana", "Helena", "João" };

            //for (int i = 0; i < 10; i++)
            //{
            //    var vehicle = RandomVehicle.RandomCarAlgorithm();
            //    var name = customerNames[RandomNumber.RandomNumbers(customerNames.Length)];

            //    vehicle.PickUp(name);
            //    vehicle.Stop();
            //    Console.WriteLine("===============");
            //}
            #endregion


            #region Abstract Factory
            var enterpriseFactory = new EnterpriseCustomerVehicleFactory();
            var individualFactory = new IndividualCustomerVehicleFactory();

            var car1 = enterpriseFactory.CreateVehicle("Fusca", "João");
            var car2 = individualFactory.CreateVehicle("Celta", "Helena");

            car1.PickUp();
            car2.PickUp();

            #endregion
        }
    }
}