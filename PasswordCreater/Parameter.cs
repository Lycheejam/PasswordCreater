using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreater {
    class Parameter {
        public int CharLen { get; set; }
        public int CrePass { get; set; }
        public Boolean Uppercase { get; set; }
        public Boolean Lowercase { get; set; }
        public Boolean Numbers { get; set; }
        public Boolean Symbols { get; set; }
    }
}
