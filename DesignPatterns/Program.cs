using DesignPatterns.Behavior.Strategy.ShoppingCart;
using DesignPatterns.Behaviour.Command;
using DesignPatterns.Behaviour.Mediator;
using DesignPatterns.Behaviour.Memento;
using DesignPatterns.Behaviour.State.ShoppingOrder;
using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.Builder.Classes;
using DesignPatterns.Creational.Builder.Classes.Classes;
using DesignPatterns.Creational.FactoryMethod.Factories;
using DesignPatterns.Creational.FactoryMethod.Main;
using DesignPatterns.Creational.FactoryMethod.Utils;
using DesignPatterns.Creational.Prototype.DeepCopy;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter.Validation;
using DesignPatterns.Structural.Bridge.Device;
using DesignPatterns.Structural.Bridge.RemoteControl;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator.Product;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight.Delivery;
using DesignPatterns.Structural.Proxy.SystemUser;
using System;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

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
            //var enterpriseFactory = new EnterpriseCustomerVehicleFactory();
            //var individualFactory = new IndividualCustomerVehicleFactory();

            //var car1 = enterpriseFactory.CreateVehicle("Fusca", "João");
            //var car2 = individualFactory.CreateVehicle("Celta", "Helena");

            //car1.PickUp();
            //car2.PickUp();
            #endregion


            #region Composite
            //var pen = new ProductLeaf("Pen", 1);
            //var smartphone = new ProductLeaf("Smartphone", 1000);
            //var tShirt = new ProductLeaf("Camiseta", 40);

            //var productBox = new ProductComposite();
            //productBox.Add(pen, smartphone, tShirt);

            //Console.WriteLine(productBox);
            //Console.WriteLine(productBox.GetPrice());
            //Console.WriteLine();

            //var tablet = new ProductLeaf("Tablet", 2000);
            //var kindle = new ProductLeaf("Kindle", 300);
            //var anotherBox = new ProductComposite();
            //anotherBox.Add(tablet, kindle);
            //productBox.Add(anotherBox);

            //Console.WriteLine(productBox);
            //Console.WriteLine(productBox.GetPrice());

            //var validateEmail = new ValidateEmail();
            //var validateNumber = new ValidateNumber();
            //var validateString = new ValidateString();
            //var validationComposite = new ValidationComposite();

            //validationComposite.Add(validateEmail);

            //Console.WriteLine(validationComposite.Validate("a@a"));
            #endregion


            #region Adapter
            //var email1 = "teste@teste.com";
            //var email2 = "teste.teste.com";

            //string[] emails = new string[2] { email1, email2 };

            //var validacao = new EmailValidatorAdapter();

            //foreach (var email in emails)
            //{
            //    if (validacao.EmailValidator(email))
            //    {
            //        Console.WriteLine($"O email {email} é válido.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"O email {email} é inválido.");
            //    }
            //}
            #endregion


            #region Bridge
            //Radio radio = new Radio();
            //Tv tv = new Tv();

            //RemoteControl radioRemoteControl = new RemoteControl(radio);
            //RemoteControlWithVolume tvRemoteControl = new RemoteControlWithVolume(tv);

            //radioRemoteControl.TogglePower();

            //Console.WriteLine();

            //tvRemoteControl.TogglePower();
            //tvRemoteControl.VolumeUp();
            #endregion


            #region Decorator
            //var tShirt = new TShirt();
            //var printedTShirt = new ProductStampDecorator{ Product = tShirt };
            //var customizedTShirt = new ProductCustomization { Product = tShirt };

            //Console.WriteLine(tShirt.GetPrice() + " | " + tShirt.GetName());
            //Console.WriteLine(printedTShirt.GetPrice() + " | " + printedTShirt.GetName());
            //Console.WriteLine(customizedTShirt.GetPrice() + " | " + customizedTShirt.GetName());
            #endregion


            #region Facade
            //var builderFacade = new BuilderFacade();
            //builderFacade.MakeMeal1();
            //builderFacade.MakeMeal2();
            #endregion


            #region Proxy
            //var user = new SystemUserProxy("Zé", "zedamanga");
            //Console.WriteLine("2 segundos:");
            //foreach (var address in user.GetAddress())
            //{
            //    Console.WriteLine(address);
            //}

            //Console.WriteLine();

            //Console.WriteLine("Cache:");
            //for (int i = 0; i < 5; i++)
            //{
            //    foreach (var address in user.GetAddress())
            //    {
            //        Console.WriteLine(address);
            //    }
            //}
            #endregion


            #region Flyweight
            //var factory = new DeliveryFactory();
            //DeliveryContext.DeliveryContextFn(factory, "Irineu", "20A", "Av. Brasil", "SP");
            //DeliveryContext.DeliveryContextFn(factory, "Helena", "20A", "Av Brasil", "SP");
            //DeliveryContext.DeliveryContextFn(factory, "Joana", "502", "Av Brasil", "SP");
            //DeliveryContext.DeliveryContextFn(factory, "Eliana", "2", "Rua A", "BH");
            //DeliveryContext.DeliveryContextFn(factory, "João", "501", "Rua B", "RJ");

            //Console.WriteLine();

            //Console.WriteLine(factory.GetLocations());
            #endregion


            #region Strategy
            ////var shoppingCart = new ECommerceShoppingCart(new DefaultDiscount());
            //var shoppingCart = new ECommerceShoppingCart(new DefaultDiscount());
            //shoppingCart.AddProduct( 
            //    new ECommerceProduct { Name = "Produto 1", Price = 50 },
            //    new ECommerceProduct { Name = "Produto 2", Price = 50 },
            //    new ECommerceProduct { Name = "Produto 3", Price = 50 }
            //);
            //shoppingCart.AddProduct();
            //shoppingCart.AddProduct();
            //Console.WriteLine(shoppingCart.GetTotal());
            //Console.WriteLine(shoppingCart.GetTotalWithDiscount());
            #endregion


            #region Command
            ////Receiver
            //var bedroomLight = new SmartHouseLight("Luz Quarto");
            //var bathroomLight = new SmartHouseLight("Luz Banheiro");

            ////Command
            //var bedroomLightPowerCommand = new LightPowerCommand(bedroomLight);
            //var bathroomLightPowerCommand = new LightPowerCommand(bathroomLight);
            //var bedroomIntensityCommand = new LightIntensityCommand(bedroomLight);

            ////Controle - Invoker
            //var smartHouseApp = new SmartHouseApp();
            //smartHouseApp.AddCommand("btn-1", bedroomLightPowerCommand);
            //smartHouseApp.ExecuteCommand("btn-1");
            //smartHouseApp.UndoCommand("btn-1");

            //smartHouseApp.AddCommand("btn-2", bathroomLightPowerCommand);
            //smartHouseApp.ExecuteCommand("btn-2");
            //smartHouseApp.UndoCommand("btn-2");

            //smartHouseApp.AddCommand("btn-3", bedroomIntensityCommand);
            //smartHouseApp.ExecuteCommand("btn-3");
            //smartHouseApp.UndoCommand("btn-3");
            #endregion


            #region Memento
            //var imageEditor = new ImageEditor(@"/media/image.png", "png");

            //var backupManager = new ImageEditorBackupManager(imageEditor);

            //backupManager.Backup();
            //imageEditor.ConvertFormatTo("gif");

            //backupManager.Backup();
            //imageEditor.ConvertFormatTo("jpeg");

            //backupManager.Backup();
            //imageEditor.ConvertFormatTo("icon");

            //Console.WriteLine(imageEditor);

            //backupManager.Undo();
            //Console.WriteLine(imageEditor);

            //backupManager.Undo();
            //Console.WriteLine(imageEditor);
            #endregion


            #region State
            //var order = new ShoppingOrder();
            //order.ApprovePayment(); // Aprovado
            //order.WaitPayment(); // Pendente
            //order.ShipOrder();
            //order.RejectPayment(); // A partir daqui o estado não se altera mais
            //order.ApprovePayment();
            //order.WaitPayment();
            //order.ApprovePayment();
            //order.ShipOrder();
            #endregion


            #region Mediator
            Mediator mediator = new Mediator();

            Seller seller1 = new Seller();
            SellerProduct seller1Product1 = new SellerProduct { Id = "1", Name = "Camiseta", Price = 49.90 };
            SellerProduct seller1Product2 = new SellerProduct { Id = "2", Name = "Caneta", Price = 9.90 };
            seller1.AddProduct(seller1Product1, seller1Product2);

            Seller seller2 = new Seller();
            SellerProduct seller2Product1 = new SellerProduct { Id = "3", Name = "Carro", Price = 49000.90 };
            SellerProduct seller2Product2 = new SellerProduct { Id = "4", Name = "Lápis", Price = 1.90 };
            seller2.AddProduct(seller2Product1, seller2Product2);

            mediator.AddSeller(seller1, seller2);
            mediator.ShowProducts();

            Console.WriteLine();

            Buyer buyer = new Buyer(mediator);
            buyer.Buy("2");
            buyer.Buy("3");
            Console.WriteLine();
            buyer.ViewProduct();

            #endregion
        }
    }
}