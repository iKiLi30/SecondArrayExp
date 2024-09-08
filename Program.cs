namespace SecondArrayExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friendName = { "First Friend", "Second Friend", "Third Friend" };
            
            Console.WriteLine($"Here are {friendName.Length} of my friends: \n");
            //for ( int i = 0; i < friendName.Length; i++)
            //{
            //    Console.WriteLine( friendName[i] );
            //}
            Array.Resize(ref friendName, 6);
            friendName[3] = "4 friend";
            friendName[4] = "5 friend";
            friendName[5] = "6 friend";
            foreach (string friend in friendName)
            {
                Console.WriteLine(friend);
            }
            Console.ReadLine();
        }
    }
}
