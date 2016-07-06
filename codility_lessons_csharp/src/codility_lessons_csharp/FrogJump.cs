using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codility_lessons_csharp
{
    public class FrogJump
    {
		public int solution(int X, int Y, int D)
		{
			int distance = Y - X;
			int calc = (int)((Y - X) / D);
			return distance % D == 0 ? calc : calc + 1;
		}

	}
}
