using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentParser
{
    public class Option
    {
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public string LongCode { get; set; }
        public string Details { get; set; }
        public bool HasData { get; set; }
    }
}
