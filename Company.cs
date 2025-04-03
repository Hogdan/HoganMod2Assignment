namespace HoganMod2Assignment
{
    public class Company
    {
        private HrPerson hr;

        public Company()
        {
            hr = new HrPerson();
        }

        public void HireEmployee(string firstName, string lastName, string ssn)
        {
            hr.HireEmployee(firstName, lastName, ssn);
            hr.OutputReport(ssn);
        }

    }
}