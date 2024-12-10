namespace AccountTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account [] account = new Account[] { 
            new FixedDepositAccount() { balance =1000 , years = 3}
            , new SavingsAccount () { balance =1000 , years = 3}
            };

            account[0].PrintIntrest ();
            account[1].PrintIntrest();




        }
    }
}