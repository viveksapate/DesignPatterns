namespace AbstractFactoryDesignPattern
{
        // The AbstractProductA interface
        // Each distinct product of the Bike product family should have a base interface.
        // All variants of Bike products must implement this IBike interface.
        public interface IBike
        {
            void GetDetails();
        }
        

        // The 'AbstractProductB' interface
        // Each distinct product of the Car product family should have a base interface.
        // All variants of the Car products must implement this ICar interface.
        public interface ICar
        {
            void GetDetails();
        }


    // The ProductA1 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following RegularBike Product Belongs to the Bike product family
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularBike Details..");
        }
    }


    // The ProductB1 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following SportsBike Product Belongs to the Bike product family
    public class SportsBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsBike Details..");
        }
    }

    // The ProductA2 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following RegularCar Product Belongs to the Car product family
    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching RegularCar Details..");
        }
    }


    // The ProductB2 class
    // Concrete Products are going to be created by corresponding Concrete Factories.
    // The following SportsCar Product Belongs to the Car product family
    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching SportsCar Details..");
        }
    }

    // The AbstractFactory interface
    // The Abstract Factory interface declares a set of methods that return different abstract products. 
    // These products are called a family. 
    // A family of products may have several variants
    public interface IVehicleFactory
    {
        //Abstract Product A
        IBike CreateBike();
        //Abstract Product B
        ICar CreateCar();
    }



    // The ConcreteFactory1 class
    // Concrete Factories produce a family of products that belong to a single variant. 
    // The following Concrete Factory Produces Regular Bike and Car which are compatible
    // The signatures of the Concrete Factory's methods return an abstract product (IBike) and (ICar) 
    // while inside the method a concrete product (new RegularBike and new RegularCar) is instantiated.
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }
        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }


    // The ConcreteFactory2 class
    // Concrete Factories produce a family of products that belong to a single variant. 
    // The following Concrete Factory Produces Sports Bike and Sports Car which are compatible
    // The signatures of the Concrete Factory's methods return an abstract product (IBike) and (ICar) 
    // while inside the method a concrete product (new SportsBike and new SportsCar) is instantiated.
    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportsBike();
        }
        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }

}