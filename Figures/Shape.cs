using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures
{
    abstract class Shape
    {
        #region Constructors
        public Shape() { }
        public Shape (int x, int y, double angle)
	    {
            CoordinateX = x = 0;
            CoordinateY = y = 0;
            Angle = angle = 0;
	    }
	    #endregion



        #region Property
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public double Angle 
        { get; 
            set
            {
                if(Angle<0 && Angle>360)
                    throw new ArgumentException("Angle is out of range"); 
            } 
        }
        #endregion



        #region Methods
        public abstract void ChangeSize();
        
        /// <summary>
        /// Changes size all figure
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public double ChangeAngle(double amount)
        {
            if (amount < 0)
                return Angle -= amount;
            if (amount > 0)
                return Angle += amount;
            else
                return Angle;
        }
        public void Up(int up)
        {
            CoordinateY += up;
        }
        public void Right(int right)
        {
            CoordinateX += right;
        }
        public void Bottom(int bottom)
        {
            CoordinateY -= bottom;
        }
        public void Left(int left)
        {
            CoordinateX -= left;
        }
       
        #endregion
    }
}
