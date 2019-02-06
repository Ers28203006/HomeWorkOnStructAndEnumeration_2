using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOnStructAndEnumeration_2
{
    public enum Gender { mens, woman}
    public enum Educational { daytime, correspondence, externalStudy }
    public struct Student
    {
        public string FullName { get; set; }
        public string GroupName{ get; set; }
        public double AverageScore{ get; set; }
        public double EarningsPerFamily { get; set; }
        public Gender Gender { get; set; }
        public Educational Educational { get; set; }


    }
}
