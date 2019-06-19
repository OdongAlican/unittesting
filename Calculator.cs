namespace MyCalculator
{
    class Calculator
    {
        public int Add(int number1, int number2)
        {
            return number1 - number2;
        }

        public string[] GetUserDetails(string usersdetails)
        {
            return usersdetails.Split(',');
        }
    }
}