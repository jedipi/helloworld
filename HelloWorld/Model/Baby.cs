using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Enum;

namespace HelloWorld.Model
{
    /// <summary>
    /// Baby model.
    /// </summary>
    public class Baby
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Sex { get; set; }
        public DateTime Bod { get; set; }
        public DateTime DueDate { get; set; }

        // use fluent 
        public Baby SetFirstName(string firstName)
        {
            FirstName = firstName;
            return this;
        }

        public Baby SetLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public Baby SetGender(Gender sex)
        {
            Sex = sex;
            return this;
        }

        public Baby SetBod(DateTime bod)
        {
            Bod = bod;
            return this;
        }

        public Baby SetDueDate(DateTime dueDate)
        {
            DueDate = dueDate;
            return this;
        }
    }
}
