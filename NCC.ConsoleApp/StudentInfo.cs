namespace NCC.ConsoleApp
{
    public class MarksInfo
    {
        public MarksInfo()
        {

        }
        public MarksInfo(double full, double pass, double min)
        {
            _fullMarks = full;
            _passMarks = pass;
            _minMarks = min;
        }
        private double _fullMarks = 100;
        private double _passMarks = 32;
        private double _minMarks = 0;
        private double _scienceMarks;

        public double ScienceMarks
        {
            get { return _scienceMarks; }
            set
            {
                if (value > _fullMarks)
                {
                    _scienceMarks = _fullMarks;
                }
                else if (value < _minMarks)
                {
                    _scienceMarks = _minMarks;
                }
                else
                {
                    _scienceMarks = value;
                }
            }
        }

        private double _mathMarks;

        public double MathMarks
        {
            get => _mathMarks;
            set
            {
                _mathMarks = (value > _fullMarks) ? _fullMarks : (value < _minMarks) ? _minMarks : value;
            }
        }

        public double Total
        {
            get
            {
                return ScienceMarks + MathMarks;
            }
        }

        public double Percentage
        {
            get
            {
                return (Total / (2 * _fullMarks)) * 100;
            }
        }

        public string Division
        {
            get
            {
                if (Percentage >= 80) return "Distinction";
                else if (Percentage >= 60) return "First Division";
                else if (Percentage >= 45) return "Second Division";
                else if (Percentage >= 32) return "Third Division";
                else return "Fail";
            }
        }
    }
}