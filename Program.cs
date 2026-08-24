using AssignmentOOP05.Classes;

namespace AssignmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 Question01

            //a)What happens when you assign one object variable to another object variable?
            //Copy only the refrence on stack and both variable point to same instance in memory

            //b)Does assigning one object to another create a new object? Explain.
            //No, it points to the the existing heap allocation

            //c)What is the difference between copying an object and copying its reference?
            //Copying refrence duplicates the memory address pointing to object 
            //Copying an object allocates a new instance in heap memory with duplicate values

            #endregion

            #region Part01 Question02

            //a)What is a Shallow Copy?
            //Shallow copy creates a new object and copies all value type fields, for refrence type fields only the refrence are copied

            //b)What is a Deep Copy?
            //Deep copy creates new object and copies all nested objects, the original and the copy are completely independent

            //c)What happens to reference-type members when a Shallow Copy is created?
            //Refrence type fields only the refrence are copied, both objects point to the same nested objects

            //d)What happens to reference-type members when a Deep Copy is created?
            //Refrence type fields creates new object and the original and the copy are completely independent

            //e)Give one situation where Deep Copy would be safer than Shallow Copy.
            //Deep copy better when managing senstive refrence objects

            #endregion

            #region Part01 Question03

            //a)What is a static field, and how is it different from an instance field?
            //Static field belongs to the class, one copy shared by all objects, accessed using class name, created once
            //Instance field belongs to an object, each object has his own copy, accessed using object refrence, created for each object

            //b)What is a static method? Can a static method directly access instance members?
            //Static method belongs to the class and can be called without creating object, it cannot directly access instance members because it lacks a this reference  

            //c)What is a static constructor, and when is it executed?
            //Runs automatically before any static mamber is used

            //d)What is a static class? Can you create an object from a static class?
            //A class declared as static can't be instantiated

            #endregion

            #region Part01 Question04

            //a)What is an Extension Method?
            //Extension Method let you add new methods to existing types without modifying the original type or creating new derived type

            //b)What keyword must be used in the first parameter of an extension method?
            //First parameter must use this

            //c)Where must an extension method be declared?
            //In a stetic class

            //d)Can an extension method access private members of the class it extends?
            //No, because they are not actually part of the type

            #endregion

            #region Part01 Question05

            //a)What is a Partial Class?
            //Partial Class allows you to split the definition of a class into multiple files all parts are combined by the compiler into a signal class

            //b)Why would a developer split one class into multiple files?
            //To separate auto genrated code from custom code, to allow different team member to extend a class without modifying the original file 

            //c)What is a Partial Method?
            //Partial Method is a method declaration without an implementation in the class 

            //d)What happens if a declared partial method has no implementation?
            //The compiler removes the method declaration 

            #endregion

            #region Part02 1-Object Copying

            //1-Object Copying

            //Shipment shipment1 = new StandardShipment("del","laptop", 20m, 50m, new DeliveryAddress("cairo", "tahrir", 25));
            //Shipment shipment2 = shipment1;
            //Console.WriteLine(shipment1.TrackingCode.Equals(shipment2.TrackingCode));

            #endregion

            #region Part02 2-Shallow Copy

            //2-Shallow Copy

            //Shipment shipment1 = new StandardShipment("del", "laptop", 20m, 50m, new DeliveryAddress("cairo", "tahrir", 25));
            //Shipment shipment2 = shipment1.ShallowCopy();

            //shipment1.PrintShipment();
            //shipment2.PrintShipment();

            //shipment2.Weight = 100m;
            //shipment2.Destination.city = "Giza";

            //shipment1.PrintShipment();
            //shipment2.PrintShipment();

            #endregion

            #region Part02 3-Deep Copy

            //3-Deep Copy

            //Shipment shipment1 = new StandardShipment("del", "laptop", 20m, 50m, new DeliveryAddress("cairo", "tahrir", 25));
            //Shipment shipment2 = shipment1.DeepCopy();

            //shipment1.PrintShipment();
            //shipment2.PrintShipment();

            //shipment2.Weight = 100m;
            //shipment2.Destination.city = "Giza";

            //shipment1.PrintShipment();
            //shipment2.PrintShipment();

            //Console.WriteLine(ReferenceEquals(shipment2.Destination.city,shipment1.Destination.city));

            #endregion

        }
    }
}
