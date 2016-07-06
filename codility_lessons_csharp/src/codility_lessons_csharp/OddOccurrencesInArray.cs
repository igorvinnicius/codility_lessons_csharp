using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codility_lessons_csharp
{
	public class OddOccurrencesInArray
	{
		public int solution(int[] A)
		{
			var unpaired = 0;

			for (int i = 0; i < A.Length; i++)
				unpaired ^= A[i];

			return unpaired;

		}
	}
}
