using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int> { 5, 2, 11, 43, 7, 15 };
            int temp = 0;

            //선택정렬
            //1번째 자리의 숫자와 나머지 숫자중 가장 작은 숫자를 찾아 비교하여 첫번째 자리의 숫자가 더 크면 교환한다.
            //두번째 i가 돌 때는 첫번째 i는 비교 대상에서 제외되어야 함
            for (int i = 0; i < Numbers.Count - 1; i++)
            {
                for (int j = i+1; j < Numbers.Count; j++)
                {
                    if (Numbers[i] > Numbers[j])
                    {
                        temp = Numbers[j];
                        Numbers[j] = Numbers[i];
                        Numbers[i] = temp;
                        //break;
                    }

                }
            }

            Console.WriteLine(string.Join('\t',Numbers));
           


        }
       
    }
}
