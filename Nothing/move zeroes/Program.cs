namespace move_zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 0, 1, 0, 3, 12 };
            var anInstanceofMyClass = new Program();
            int[] res1 = anInstanceofMyClass.MoveZeroes(ints);
            for (int j = 0; j < res1.Length; j++) { Console.Write(res1[j] + " "); }
        }
        int[] MoveZeroes(int[] nums)
        {
            int[] result = new int[nums.Length];
            int b = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    result[b] = nums[i];
                    b++;
                }
            }
            for (int i = b; i < result.Length; i++)
            {
                result[i] = 0;
            }

            return result;
        }
    }
}