namespace Lab17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount<string> account1 = new BankAccount<string>();
            BankAccount<int> account2 = new BankAccount<int>();
            account1.Input();
            account2.Input();
            account1.GetInfo();
            account2.GetInfo();
            Console.ReadKey();
        }
    }
}
