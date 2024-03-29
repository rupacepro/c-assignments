using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    internal class House : Residence
    {
        private String _garage;
        private String _type;
        private String _condition;

        public String Garage
        {
            get { return _garage; }
            set { _garage = value; }
        }

        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public String Condition
        {
            get { return _condition; }
            set { _condition = value; }
        }

        public House() { }

        public House(String garage, String type, String condition)
        {
            _garage = garage;
            _type = type;   
            _condition = condition;
        }

        public override string ToString()
        {
            return $"Garage: {_garage}\nType: {_type}\nCondition: {_condition}";
        }

        public override double CalculateCommission()
        {
            return base.Price * .035;
        }
    }
}
