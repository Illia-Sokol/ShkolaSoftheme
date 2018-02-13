namespace StructsAndEnums
{
    //struct Date
    class Date
    {
        private int _year;
        private Month _month;
        private int _day;

        public Date(int year, Month mm, int dd)
        {
            _year = year - 1900;
            _month = mm;
            _day = dd - 1;
        }

        public override string ToString()
        {
            var data = string.Format("{0} {1} {2}", _month, _day + 1, _year + 1900); 
            return data; 
        }

        public void AdvanceMonth()
        {
            _month++;
            if (_month == Month.December + 1)
            {
                _month = Month.January;
                _year++;
            }
        }
    }
}