namespace MethodsExercise
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is the name of your dog?");
            string userDogName = Console.ReadLine();

            Console.WriteLine("What color is your dog?");
            string userDogColor = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, he was {age} years old.");
            Console.WriteLine($"{userName} loved {userDogName} but he did not love being {age} years old!");
            Console.WriteLine($"He had a dog named {userDogColor} dog named {userDogName}");

            //Console.WriteLine("Give me a number to add");
            //int num1 = int.Parse(Console.ReadLine()); 

            //Console.WriteLine("Give me a number to add to the first one");
            //int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Multiply(1, 2));
           
        }
        public static int  Sum(int num1, int num2)
        {
            //code here            
        }


        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }


    }
}