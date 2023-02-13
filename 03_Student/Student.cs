using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Student
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string email;

        public Student()
        {

        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get => firstName; }

        public string LastName { get => lastName; }

        public string FullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }

        public Course Course { get; set; }

        public List<Subject> Subjects { get; set; }

        public string Email { 
            get 
            {
                if (string.IsNullOrEmpty(email))
                {
                    return "n/a";
                }
                return email;

            }
            set => email = value; }

        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Full Name: {FullName} E-mail: {Email} Phone: {PhoneNumber}...";
        }
    }
}
