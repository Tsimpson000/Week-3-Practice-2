namespace Lecture_5_Virtual_override;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        List<BankAccount> accounts = new List<BankAccount>();

        Saving sa = new Saving("Tyler", rand.Next().ToString(), 0);
        Checking ca = new Checking("Tyler", rand.Next().ToString(), 0);
        RetirementAccount ra = new RetirementAccount("Tyler", rand.Next().ToString(), 0);
        accounts.Add(sa);
        accounts.Add(ca);
        accounts.Add(ra);

        //for (int i = 0; i <= accounts.Count; i++)
        //{
            sa.Deposit(500);
            ca.Deposit(500);
            ra.Deposit(500);
            Console.WriteLine($"{sa.ToString()} - {ca.ToString()} - {ra.ToString()}");
            sa.Deposit(-50000);
            ca.Deposit(-50000);
            ra.Deposit(-50000);
            Console.WriteLine($"{sa.ToString()} - {ca.ToString()} - {ra.ToString()}");
            sa.Withdraw(200);
            ca.Withdraw(200);
            ra.Withdraw(200);
            Console.WriteLine($"{sa.ToString()} - {ca.ToString()} - {ra.ToString()}");
            sa.Withdraw(-200000);
            ca.Withdraw(-200000);
            ra.Withdraw(-200000);
            Console.WriteLine($"{sa.ToString()} - {ca.ToString()} - {ra.ToString()}");
            sa.Withdraw(10000);
            ca.Withdraw(10000);
            ra.Withdraw(10000);
            Console.WriteLine($"{sa.ToString()} - {ca.ToString()} - {ra.ToString()}");
        //}

    }

}
