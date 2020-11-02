using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion
{
    class TowerofHanoi
    {
		public void Hanoi(int n, char from_rod, char to_rod, char temp_rod)
		{
			if (n == 1)
			{
				Console.WriteLine("Move disk 1 from rod " + from_rod + " to rod " + to_rod);
				return;
			}
			Hanoi(n - 1, from_rod, temp_rod, to_rod);
			Console.WriteLine("Move disk " + n + " from rod " + from_rod + " to rod " + to_rod);
			Hanoi(n - 1, temp_rod, to_rod, from_rod);
		}
	}
}
