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

        }
    }
}
