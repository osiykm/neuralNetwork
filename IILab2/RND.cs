using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IILab2 {
    class RND {
        private static Random _rnd = new Random();
        public static int getInt(int i) {
            return _rnd.Next(-i, i);
        }
    }
}
