//Name: Rupesh Shrestha(C0908441)
//Date: 2024 - 03 - 29

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

        public Condo(double price, double squareFeet, int yearBuilt, Address address, int unit, int floor, String parking)
            : base(price, squareFeet, yearBuilt, address)
        {
            _unit = unit;
            _floor = floor;
            _parking = parking;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nUnit: {_unit}\nFloor: {_floor}\nParking:{_parking}\nTotal Commission: ${CalculateCommission():F2}";
        }

        public override double CalculateCommission()
        {
            return base.Price * .04;
        }
    }
}
