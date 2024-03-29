using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    internal class Condo : Residence
    {
        private int _unit;
        private int _floor;
        private String _parking;

        public int Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public int Floor
        {
            get { return _floor; }
            set { _floor = value; }
        }

        public String Parking
        {
            get { return _parking; }
            set { _parking = value; }
        }

        public Condo()
        {
            _unit = 0;
            _floor = 0;
            _parking = "No";
        }

        public Condo(int unit, int floor, String parking)
        {
            _unit = unit;
            _floor = floor;
            _parking = parking;
        }

        public override string ToString()
        {
            return $"Unit: {_unit}\nFloor: {_floor}\nParking:{_parking}";
        }

        public override double CalculateCommission()
        {
            return base.Price * .04;
        }
    }
}
