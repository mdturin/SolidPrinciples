using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Rectangle
    {
        public int width, height;

        public Rectangle(){}
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int getArea()
        {
            return width * height;
        }
        public int getWidth() { return width; }
        public int getHeight() { return height; }
        public virtual void setWidth(int width) { this.width = width;}
        public virtual void setHeight(int height) { this.height = height;} 
    }
}
