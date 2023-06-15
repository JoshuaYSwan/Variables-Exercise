namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string catName = "Finn";
            int age = 10;
            char lastInitial = 'S';
            bool isCute = true;
            double length = 26.5;
            decimal weight = 18.23m;

            Console.WriteLine($"My cat's name is {catName}. He is {age} years old, and his last name starts with {lastInitial}." +
                $" The fact that he's cute is definitely {isCute}, and his length and weight are " +
                $"{length} inches and {weight} pounds respectively");
        }
    }
}
