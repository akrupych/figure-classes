using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    class Circle : Shape
    {
        #region Property
        public int Radius { get; set; }
        #endregion


        #region Constructors
        public Circle() { }
        public Circle(int radius) : base(0,0,0)
        {
            Radius = radius;
        }
        #endregion



        #region Methods
        public override int ChangeSize(int amount)
        {
            if (amount < 0)
                return Radius -= amount;
            if (amount > 0)
                return Radius += amount;
            else
                return Radius;
        }
        #endregion
    }
}
