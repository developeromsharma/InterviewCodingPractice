namespace PractiseQuestions
{
    class SecondHighestElement
    {
        static void Main()
        {
            int[] arr = { 12, 5, 7, 9, 15, 6, 20 };

            int first = int.MinValue;
            int second = int.MinValue;

            foreach (int num in arr)
            {
                if (num > first)
                {
                    second = first;
                    first = num;
                }
                else if (num > second && num != first)
                {
                    second = num;
                }
            }

            if (second == int.MinValue)
            {
                Console.WriteLine("No second largest element found.");
            }
            else
            {
                Console.WriteLine("Second largest element is: " + second);
            }
        }
    }
}
