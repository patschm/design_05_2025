
using System.Threading.Channels;

partial class Person
{
    public  void Introduce()
    {
        Console.WriteLine($"Hello, I'm {FirstName} {LastName} ({Age})");
    }
    //partial void DoeIets()
    //{
    //    Console.WriteLine("Init...");
    //}
}


