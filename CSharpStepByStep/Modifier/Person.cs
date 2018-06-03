using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifier
{
    public class Person
    {
        public DateTime Birthday { get; private set; }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - Birthday;
                var year = timeSpan.Days / 365;

                return year;
            }
        }

        public Person(DateTime dt)
        {
            this.Birthday = dt;
        }
    }
}
