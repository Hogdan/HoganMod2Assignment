namespace HoganMod2Assignment
{
    using System.Collections.Generic;
    public class HrPerson
    {
        // This replaces the hardcoded cubeId from the original code
        private const string DEMO_CUBEID = "B101";
        private List<Employee> employees = [];

        public HrPerson()
        {
        }

        public void HireEmployee(string firstName, string lastName, string ssn)
        {
            Employee emp = new(firstName, lastName, ssn);
            employees.Add(emp);
            OrientEmployee(emp, DEMO_CUBEID);
        }

        // I added cubeId as a parameter to this method to remove the magic number
        public static void OrientEmployee(Employee emp, string cubeId)
        {
            emp.DoFirstTimeOrientation(cubeId);
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