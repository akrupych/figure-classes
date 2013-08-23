using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    class Triangle : Shape
    {
        #region Property
        private int X { get; set; }
        private int Y { get; set; }
        private int Z { get; set; }
        private int AB { get; set; }
        private int BC { get; set; }
        private int CA { get; set; }
        private int AnlgeA { get; set; }
        private int AngleB { get; set; }
        private int AngleC { get; set; }
        #endregion



        #region Constructors
        public Triangle() { }
        public Triangle(int x,int y, int z) : base(0,0,0)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Triangle(int side) : base(0,0,0)
        {
            AB = BC = CA = side;
        }
        public Triangle()
        {

        }
        #endregion
    }
}
