using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Square:Rectangle
    {
        public Square() { }
        public Square(int size):base(size,size) { }

        public override void setWidth(int value)
        {
            this.width = value;
            this.height = value;
        }

        public override void setHeight(int value)
        {
            this.width = value;
            this.height = value;
        }
    }
}
