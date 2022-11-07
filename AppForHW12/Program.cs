namespace AppForHW12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Disclaimer.ShowDisclaimer();
            var userList = new List<User>
            {
                new User("User1", "Chubais", true),
                new User("User2", "Soloviev",false),
                new User("User3", "Prigozhin",true),
                new User("User4", "Kadyrov", true),
                new User("User4", "Reindeer herder", false)
            };

            foreach (var user in userList)
            {
                Console.WriteLine("Здравствуйте {0}!", user.Name);
                if (user.IsPremium == false) { user.ShowAds(); }
                Console.WriteLine();
                Thread.Sleep(1500);
            }
            Console.ReadKey();
        }
    }
}