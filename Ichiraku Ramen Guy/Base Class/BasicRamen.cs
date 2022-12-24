using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ichiraku_Ramen_Guy.Base_Class
{
    public class BasicRamen : BoundProperties
    {
        private int _RamenBroth;
        private int _RamenNoodles;



        public int RamenBroth
        {
            get { return _RamenBroth; }

            set { _RamenBroth = value; }
        }

        public int RamenNoodles
        {
            get { return _RamenNoodles; }

            set 
            { 
                _RamenNoodles = value;
            }
        }

    }
}
