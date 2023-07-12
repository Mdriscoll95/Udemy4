namespace Udemy4;

class Program
{
    static void Main(string[] args)
    {
        //string manipulation


        //define a few variables
        int age = 28;
        string name = "Mike";
        string job = "developer";

        //1.string concatination
        Console.WriteLine("string concatination");
        Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");
       

        //2. string formatting
        //string formatting uses index
        Console.WriteLine("String Formatting");
        Console.WriteLine("Hello my name is {0} , I am {1} years old. I am a {2}", name, age, job);
        

        //3. string interpolation
        //uses $ in front of code
        //variables like this {VariableName}
        Console.WriteLine("String Interpolation");
        Console.WriteLine($"Hello my name is {name}, I am {age} years old. I am a {job}");
        

        //4. Verbatim strings
        //uses @ Symbol in front
        //writes texts literally and ignores other stuff like /n
        Console.WriteLine("Verbatim String");
        Console.WriteLine(@"Hello Doctore wallowitze has orders your prescription for 124565434. please refill at your earliest convienience. thank you       tim");

        //can be used for writing links for example
        Console.WriteLine(@"C:user/Desktop/programs/files/cooldogpic.png");
        Console.ReadLine();
        //errors would've occured without the @ symbol because it would interperate it as a /n
    }
}

