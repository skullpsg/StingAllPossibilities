using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationAndCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "wxyz";
            char[] _charArray = Name.ToArray();
            for (int i = 1; i <= _charArray.Length; i++)
                Permutaionandcombination(_charArray, 0, i);
        }
        private static void Permutaionandcombination(char[] charArray, int index, int Combinationremain, string _result = null)
        {
            if (charArray.Length < Combinationremain)
                Console.WriteLine("Error....");
            if ((Combinationremain) == 0)
            {
                Console.WriteLine($"{_result}");
                return;
            }

            for (int i = index; i <= charArray.Length - 1; i++)
            {
                Permutaionandcombination(charArray, i + 1, Combinationremain - 1, _result+charArray[i]);
            }
        }
    }
}
