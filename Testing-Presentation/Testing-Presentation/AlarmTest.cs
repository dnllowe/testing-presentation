using NUnit.Framework;
using System.Diagnostics;
using System.Threading;
using Moq;

namespace Testing_Presentation
{
    [TestFixture]
    public class AlarmTest
    {
        [Test]
        public void ShouldIWakeUp_SetForFiveSecondsUsingRealTime_AlarmGoesOffAfterFiveSeconds()
        {
            // Assemble
            IClock clock = new Clock();
            var alarm = new Alarm(clock);
            alarm.Set(5000);
            Thread.Sleep(5000);

            // Act
            var actual = alarm.ShouldIWakeUp();
            

            // Assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void ShouldIWakeUp_SetForFiveSecondsUsingMockTime_AlarmGoesOffAfterFiveSeconds()
        {
            // Assemble
            var mockClock = Mock.Of<IClock>(mc => mc.GetElapsedMilliseconds() == 5000);
            var alarm = new Alarm(mockClock);
            alarm.Set(5000);

            // Act
            var actual = alarm.ShouldIWakeUp();


            // Assert
            Assert.IsTrue(actual);
        }
    }

    public class Alarm
    {
        private long _endTime;

        private IClock _clock;

        public Alarm(IClock clock)
        {
            _clock = clock;
            _endTime = 0;
        }

        public void Set(long time)
        {
            _clock.Start();
            _endTime += time;
        }

        public bool ShouldIWakeUp()
        {
            return _clock.GetElapsedMilliseconds() >= _endTime;
        }
    }

    public interface IClock
    {
        long GetElapsedMilliseconds();
        void Start();
        void Stop();
    }

    public class Clock : IClock
    {
        private Stopwatch _stopwatch;

        public Clock()
        {
            _stopwatch = new Stopwatch();
        }

        public void Start()
        {
            if (!_stopwatch.IsRunning)
            {
                _stopwatch.Start();
            }
        }

        public void Stop()
        {
            _stopwatch.Stop();
        }

        public long GetElapsedMilliseconds()
        {
            return _stopwatch.ElapsedMilliseconds;
        }
    }
}

