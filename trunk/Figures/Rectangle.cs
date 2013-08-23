using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    class Rectangle : Shape
    {
        #region Constructors
        public Rectangle() { }
        public Rectangle(int x1, int x2, int y1, int y2) 
            :base(0,0,0)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
            Height = y1 - x1;
            Width = y2 - x2;

        }
        public Rectangle(int width, int height) : base(0,0,0)
        {
            Height = height;
            Width = width;
        }
        public Rectangle(int side) : base(0,0,0)
        {
            Width = Height = side;
        }
        
        #endregion


        #region Property
        private int X1 { get; set; }
        private int X2 { get; set; }
        private int Y1 { get; set; }
        private int Y2 { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        #endregion


        #region Methods
        public override void ChangeSize( int amountHeight, int amountWidth)
        {
            if (amountHeight > 0)
                Height += amountHeight;
            else
                Height -= amountHeight;
            if (amountWidth > 0)
                Width += amountWidth;
            else
                Width -= amountWidth;
            
        }
        #endregion
    }
}
