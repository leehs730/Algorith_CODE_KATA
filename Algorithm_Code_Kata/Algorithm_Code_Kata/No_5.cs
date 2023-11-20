using System;
namespace Algorithm_Code_Kata
{
	public class No_5
	{
		public No_5()
		{
		}

        public class Solution
        {
            public int solution(int num1, int num2)
            {
                int answer = 0;
                answer = (num1 == num2) ? 1 : -1;
                return answer;
            }
        }
    }
}

