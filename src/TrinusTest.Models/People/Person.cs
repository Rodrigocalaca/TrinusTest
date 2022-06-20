using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinusTest.Models.People
{
    public class Person
    {
        public string? Name { get; set; }

        public int? Age { get; set; }

        public string? Ssn { get; set; }

        public AgeIndentifier AgeIndentifier { get; set; }
    }

    public enum AgeIndentifier
    {
        [Description("CRIANÇA")]
        Child = 0,
        [Description("JOVEM")]
        Young,
        [Description("ADULTO")]
        Adult,
        [Description("IDOSO")]
        Old
    }
}
