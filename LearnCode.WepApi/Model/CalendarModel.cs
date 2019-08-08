using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnCode.WepApi.Model
{
    public class CalendarModel
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string State { get; set; } = "Unchanged";

    }
}
