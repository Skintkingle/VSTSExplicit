namespace MyFirstCode
{
    public class MyFirstClass
    {
        public int AddSomeNumbers(int first, int second)
        {
            return first + second;
        }

        public int DoAlotOfAdding(int limit)
        {
            int total = 0;

            for (int x = 0; x < limit; x++)
            {
                total += AddSomeNumbers(x, x + 1);
            }

            return total;
        }

        public int Multiplier { get; set; } = 2;

        public int MultiplyANumber(int number)
        {
            return number * Multiplier;
        }
    }
}
