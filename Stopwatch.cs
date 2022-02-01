using System;
namespace StopWatch
{
	public class Stopwatch
	{
	
		private DateTime _startTime;
		private DateTime _finishTime;
		private TimeSpan _lapDuration;
		private TimeSpan _totalDuration;
		private bool _isStopWatchRunning;
		private int _lapCounter;

        public void Start()
         {
            if (!_isStopWatchRunning)
            {
				_isStopWatchRunning = true;
				_startTime = DateTime.Now;
			}
            else
            {
				throw new InvalidOperationException("Stop Watch already running.");
               
            }
			
         }

		public void Stop()
        {
            if (_isStopWatchRunning)
            {
				_isStopWatchRunning = false;

				_finishTime = DateTime.Now;

				_lapDuration = _finishTime - _startTime;

				_totalDuration += _lapDuration;
				

				_lapCounter++;

				Console.WriteLine("Time stopped at: {0}", _finishTime.ToString("HH:mm:ss"));
				Console.WriteLine("Lap {0}'s duration time: {1}",_lapCounter,_lapDuration.ToString(@"hh\:mm\:ss\.fff"));
                Console.WriteLine("Total Duration time: {0}",_totalDuration.ToString(@"hh\:mm\:ss\.fff"));
			}
            else
            {
				throw new InvalidOperationException("Stop Watch is already stand by mode.");
            }

        }

		public void ResetStopWatch()
        {
			_isStopWatchRunning = false;
			_lapCounter = 0;
			_lapDuration = TimeSpan.Zero;
			_totalDuration = TimeSpan.Zero;
        }


		
	}
}

