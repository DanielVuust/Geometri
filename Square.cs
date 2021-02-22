using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
    public class Square
    {
        private int side;
        public int Side { 
            get {
                return this.side;
            } 
            set {
                this.side = value;
            } 
        }
        
        public int omkres()
        {
            return 4* this.side;
        }
        public int areal()
        {
            return this.side * this.side;
        }
    }
}
