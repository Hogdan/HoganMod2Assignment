namespace HoganMod2Assignment
{
    using System.Collections.Generic;
    public class HrPerson
    {

        private List<Employee> employees = new List<Employee>();

        public HrPerson()
        {
        }

        public void HireEmployee(string firstName, string lastName, string ssn)
        {
            Employee emp = new Employee(firstName, lastName, ssn);
            employees.Add(emp);
            OrientEmployee(emp);
        }

        public void OrientEmployee(Employee emp)
        {
            emp.DoFirstTimeOrientation("B101");
        }

        public void OutputReport(string ssn)
        {
            foreach (Employee emp in employees)
            {
                if (emp.GetSsn() == ssn)
                {
                    if (emp.HasMetWithHr() && emp.HasMetWithDeptStaff() && emp.HasReviewedDeptPolicies() && emp.HasMovedIn())
                    {
                        emp.PrintReport();
                        return;
                    }
                    return;
                }
            }
        }
    }
}