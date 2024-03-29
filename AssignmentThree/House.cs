//Name: Rupesh Shrestha(C0908441)
//Date: 2024 - 03 - 29

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

        public House(double price, double squareFeet, int yearBuilt, Address address, String garage, String type, String condition)
            : base(price, squareFeet, yearBuilt, address)
        {
            _garage = garage;
            _type = type;   
            _condition = condition;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nGarage: {_garage}\nType: {_type}\nCondition: {_condition}\nTotal Commission: ${CalculateCommission():F2}";
        }

        public override double CalculateCommission()
        {
            return base.Price * .035;
        }
    }
}
