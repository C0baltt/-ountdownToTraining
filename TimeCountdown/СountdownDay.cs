using System;

namespace TimeCountdown
{
    class СountdownDay
    {
        private DayOfWeek _nextDayLearning;
        private DateTime _timeStartOfTraining;
        //.AddHours(double 19)

        internal DateTime TimeStartOfTraining
        {
            get
            {
                return _timeStartOfTraining;
            }
            set
            {
                _timeStartOfTraining.AddHours(19);
            }
        }

        private DayOfWeek NextDayLearning { get => _nextDayLearning; set => _nextDayLearning = FindNextDayLearning(); }

        public СountdownDay()
        {
            //_nextDayLearning = FindNextDayLearning();
            NextDayLearning = _nextDayLearning;
        }

        private DayOfWeek FindNextDayLearning()
        {
            if ((DateTime.Now.DayOfWeek != DayOfWeek.Monday) &&
                (DateTime.Now.DayOfWeek <= DayOfWeek.Wednesday))
            {
                return DayOfWeek.Wednesday;
            }
            else
            {
                return DayOfWeek.Monday;
            }
        }

        //date1.Subtract(date2)
    }
}
