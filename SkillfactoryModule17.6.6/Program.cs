namespace SkillfactoryModule17._6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var salaryAccountExample = new SalaryAccount()
            {
                Balance = 3000
            };
            var regularAccountExample = new RegularAccount()
            {
                Balance = 900
            };
            Calculator.CalculateInterest(salaryAccountExample);
            Calculator.CalculateInterest(regularAccountExample);
        }
    }
}