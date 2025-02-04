namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found

            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names

            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
            Console.WriteLine("enter the name of the fruit you would like to find");
            string findFruit = /*Convert.ToLower(*/Console.ReadLine()/*)*/;
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == findFruit) 
                {
                    Console.WriteLine("True");
                    System.Environment.Exit(0);
                }
            }
            Console.WriteLine("False");
        }
    }
}
