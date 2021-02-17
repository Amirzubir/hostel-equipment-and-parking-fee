using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgmnttttt_oop
{
    class student
    {
        private string _studentID;
        private string _studentName;
        private string _course;
        private string _password;

        public string StudentID
        {
            get{return _studentID;}
            set{_studentID = value;}
        }

        public string StudentName
        {
            get{return _studentName;}
            set{_studentName = value;}
        }

        public string Course
        {
            get{return _course;}
            set{_course = value;}
        }

        public string Password
        {
            get{return _password;}
            set{_password = value;}
        }
    }
}
