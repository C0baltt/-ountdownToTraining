using System;

namespace TimeCountdown
{
    class СountdownDay
    {
        private DayOfWeek _nextDayLearning;
        private DateTime _timeStartOfTraining;
        //.AddHours(double 19)
        private DateTime _today = DateTime.Now;

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

        private DayOfWeek NextDayLearningDayOfWeek
        { get => _nextDayLearning; set => _nextDayLearning = FindNextDayLearning(); }

        public СountdownDay()
        {
            //_nextDayLearning = FindNextDayLearning();
            NextDayLearningDayOfWeek = _nextDayLearning;
        }

        private DayOfWeek FindNextDayLearning()
        {
            if ((DateTime.Now.DayOfWeek <= DayOfWeek.Wednesday) &&
                (DateTime.Now.DayOfWeek != DayOfWeek.Monday))
            {
                
                return DayOfWeek.Wednesday;
            }
            else
            {
                return DayOfWeek.Monday;
            }
        }

        //private DateTime NextDayLearningDateTime = _today.AddDays(NextDayLearningDayOfWeek - DayOfWeek);

        //date1.Subtract(date2)

        /*
        public void CalculateDifference()
        {
           DateTime different = NextDayLearningDayOfWeek.Subtract(DateTime.Today);
                        if (different.CompareTo(0)) 
                        {
                            different += numderOfDaysOfTheWeek; 
                        }
        }*/
    }
}
