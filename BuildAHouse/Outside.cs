using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAHouse
{
    class Outside: Location
    {
        private bool hot;
        public Outside(string name, bool hot):
            base(name)
        {
            this.hot = hot;
        }
    }
}
