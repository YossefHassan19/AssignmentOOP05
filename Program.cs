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

        }
    }
}
