namespace Sign_of_the_Product_of_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 41, 65, 14, 80, 20, 10, 55, 58, 24, 56, 28, 86, 96, 10, 3, 84, 4, 41, 13, 32, 42, 43, 83, 78, 82, 70, 15, -41 };
            long res = nums[0];
            for (int i = 1;i < nums.Length; i++)
            {
                res = res * nums[i];
            }
            if (res == 0)
            {
                Console.WriteLine(0);
            }
            else if (res < 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(1);
            }
            Console.WriteLine(res);

        }
    }
}