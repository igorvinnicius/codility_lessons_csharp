using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codility_lessons_csharp
{
    public class CyclicRotation
    {
		public int[] solution(int[] A, int K)
		{
			int N = A.Length;

			if (N == 0)
				return A;

			int[] B = new int[N];

			if (K >= N)
				K %= N;

			if (K == 0)
				return A;

			for (int i = 0; i < N; i++)
			{
				B[i] = i < K ? A[N + i - K] : A[i - K];
			}

			return B;

		}

	}
}
