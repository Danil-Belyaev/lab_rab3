using System;

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целый числитель первой дроби: ");
            double chisl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите целый знаменатель первой дроби: ");
            double znam1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите целый числитель второй дроби: ");
            double chisl2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nВведите целый знаменатель второй дроби: ");
            double znam2 = Convert.ToDouble(Console.ReadLine());
            double proiz = (chisl1 / znam1) * (chisl2 / znam2);
            double chisl3 = chisl1 * chisl2;
            double znam3 = znam1 * znam2;

            Console.WriteLine("\n" + chisl1 + "/" + znam1 + " * " + chisl2 + "/" + znam2 + " = " + chisl3 + "/" + znam3 + " = " + proiz);
        }
    }
}
