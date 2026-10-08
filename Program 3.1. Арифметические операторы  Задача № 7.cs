using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = int.MaxValue; // 2_147_483_647
            try
            {
                int res = checked(max + 1); // Вызовет исключение
                Console.WriteLine("Не должно быть выведено");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Поймано OverflowException: " + ex.Message);
            }
        }
    }
}
