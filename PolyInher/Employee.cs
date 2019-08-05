namespace PolyInher
{
    public class Employee
    {
        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        // prop
        // AUTO-PROPERTY, the field is abstracted away
        public string Name { get; set; }
        
        // propfull
        // NORMAL RUN OF THE MILL PROPERTY, NOTICE WE ARE EXPLICITLY WORKING WITH THE 
        // PRIVATE FIELD
        private int _salary;
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }

        public string GetEmployeeID()
        {
            return "ADER-2234";
        }
    }
}
