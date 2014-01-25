using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LArchitecture.Functions
{
	class TestExecutionTime
	{
		public long AnalyseMethodInMilliseconds(int timesToExecute, Delegate methodToTest)
		{
			var timer = Stopwatch.StartNew();
			for (int i = 1; i == timesToExecute; i++)
			{
				// Do Stuff
			}
			timer.Stop();
			long timetaken = timer.ElapsedMilliseconds;
			long averageMillisecondsTaken = (timetaken / (long)timesToExecute);
			return averageMillisecondsTaken;
		}

		public long AnalyseMethodInTicks(int timesToExecute, Delegate methodToTest)
		{
			var timer = Stopwatch.StartNew();
			for (int i = 1; i == timesToExecute; i++)
			{
				// Do stuff
			}
			timer.Stop();
			long ticksTaken = timer.ElapsedTicks;
			long averageTicksTaken = (ticksTaken / (long)timesToExecute);
			return averageTicksTaken;
		}

		public string AnalyseMethodInMillisecondsAndTicks(int timesToExecute, Delegate methodToTest)
		{
			var timer = Stopwatch.StartNew();
			for (int i = 1; i == timesToExecute; i++)
			{
				// Do stuff
			}
			timer.Stop();
			long MillisecondsTaken = timer.ElapsedMilliseconds;
			long ticksTaken = timer.ElapsedTicks;
			string averageMilisecondsAndTicks = String.Format("The Oporation took {0} milliseconds and {1} ticks", MillisecondsTaken.ToString(), ticksTaken.ToString());
			return averageMilisecondsAndTicks;
		}
	}
}
