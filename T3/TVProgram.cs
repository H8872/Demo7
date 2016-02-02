using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    [Serializable]
    class TVProgram
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string Begins { get; set; }
        public string Ends { get; set; }
        public string Info { get; set; }

        public override string ToString()
        {
            return "\n  - Name: " + Name + " Channel: " + Channel + " Air time: " + Begins + "-" + Ends + "\n    + Info: " + Info;
        }
    }
}
