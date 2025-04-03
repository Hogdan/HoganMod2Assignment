namespace HoganMod2Assignment
{    
    using System.Globalization;
    public class Employee
    {
        private const string REQURED_MSG = " is mandatory ";
        private const string NEW_LINE = "\n";

        private string firstName;
        private string lastName;
        private string ssn;
        private bool metWithHr;
        private bool metDeptStaff;
        private bool reviewedDeptPolicies;
        private bool movedIn;
        private string cubeId;
        private DateTime orientationDate;
        private EmployeeReportService reportService = new EmployeeReportService();

        public Employee(string firstName, string lastName, string ssn)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            SetSsn(ssn);
        }

        private string GetFormattedDate()
        {
            return orientationDate.ToString("M/d/yy", CultureInfo.InvariantCulture);
        }

        public void DoFirstTimeOrientation(string cubeId)
        {
            orientationDate = DateTime.Now;
            MeetWithHrForBenefitAndSalaryInfo();
            MeetDepartmentStaff();
            ReviewDeptPolicies();
            MoveIntoCubicle(cubeId);
        }

        public void MeetWithHrForBenefitAndSalaryInfo()
        {
            metWithHr = true;
            reportService.AddData(firstName + " " + lastName + " met with HR on " + GetFormattedDate() + NEW_LINE);
        }

        public void MeetDepartmentStaff()
        {
            metDeptStaff = true;
            reportService.AddData(firstName + " " + lastName + " met with dept staff on " + GetFormattedDate() + NEW_LINE);
        }

        public void ReviewDeptPolicies()
        {
            reviewedDeptPolicies = true;
            reportService.AddData(firstName + " " + lastName + " reviewed dept policies on " + GetFormattedDate() + NEW_LINE);
        }

        public void MoveIntoCubicle(string cubeId)
        {
            movedIn = true;
            this.cubeId = cubeId;
            reportService.AddData(firstName + " " + lastName + " moved into cubicle " + cubeId + " on " + GetFormattedDate() + NEW_LINE);
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string firstName)
        {
            if (firstName == null || firstName.Length == 0)
            {
                throw new ArgumentException("First name" + REQURED_MSG);
            }
            this.firstName = firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string lastName)
        {
            if (lastName == null || lastName.Length == 0)
            {
                throw new ArgumentException("Last name" + REQURED_MSG);
            }
            this.lastName = lastName;
        }

        public string GetSsn()
        {
            return ssn;
        }

        public void SetSsn(string ssn)
        {
            if (ssn == null || ssn.Length < 9 || ssn.Length > 11)
            {
                throw new ArgumentException("SSN" + REQURED_MSG + "and must be between 9 and 11 characters long (if hyphenated)");
            }
            this.ssn = ssn;
        }

        public bool HasMetWithHr()
        {
            return metWithHr;
        }

        public bool HasMetWithDeptStaff()
        {
            return metDeptStaff;
        }

        public bool HasReviewedDeptPolicies()
        {
            return reviewedDeptPolicies;
        }

        public bool HasMovedIn()
        {
            return movedIn;
        }

        public string GetCubeId()
        {
            return cubeId;
        }

        public void SetCubeId(string cubeId)
        {
            if (cubeId == null || cubeId.Length == 0)
            {
                throw new ArgumentException("Cube ID" + REQURED_MSG);
            }
            this.cubeId = cubeId;
        }

        public DateTime GetOrientationDate()
        {
            return orientationDate;
        }

        public void PrintReport()
        {
            reportService.OutputReport();
        }

        override
        public string ToString()
        {
            return "Employee{" + "FirstName=" + firstName + ", LastName=" + lastName + ", SSN=" + ssn + "}";
        }

    }
}