using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Structurydanychprojekt2
{
    public class UsedList : Lista<int>
    {
        public UsedList Next { get; set; }
        public int Number { get; set; }
        public int weight { get; set; }
    }
}
