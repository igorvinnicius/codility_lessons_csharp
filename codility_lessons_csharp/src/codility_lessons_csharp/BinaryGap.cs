using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codility_lessons_csharp
{
    public class BinaryGap
    {
		public int solution(int N)
		{

			string binary = Convert.ToString(N, 2);

			int gapTemp = 0;
			int gapSum = 0;

			for (int i = 0; i <= binary.Length - 1; i++)
			{
				gapSum += binary[i] == '0' ? 1 : 0;

				if (binary[i] == '1')
				{
					if (gapTemp < gapSum)
						gapTemp = gapSum;
					gapSum = 0;
				}
			}

			return gapTemp;

		}

    }
}
