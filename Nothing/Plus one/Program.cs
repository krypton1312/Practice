using System;

namespace Plus_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 4, 1, 1, 9};
            var anInstanceofMyClass = new Program();
            int[] res1 = anInstanceofMyClass.PlusOne(num);
            for (int j = 0; j < res1.Length; j++) { Console.Write(res1[j] + " "); }

        }
        int[] PlusOne(int[] digits)
        {
            int n = digits.Length;

            // Переменная, которая отвечает за перенос единицы
            int carry = 1;

            // Идем с конца массива к началу
            for (int i = n - 1; i >= 0; i--)
            {
                int sum = digits[i] + carry;
                carry = sum / 10; // Вычисляем перенос

                // Записываем остаток от деления в текущую позицию
                digits[i] = sum % 10;
            }

            // Если остался перенос, добавляем новый элемент в начало массива
            if (carry > 0)
            {
                int[] result = new int[n + 1];
                result[0] = carry;
                Array.Copy(digits, 0, result, 1, n);
                return result;
            }

            return digits;
        }
    }
}