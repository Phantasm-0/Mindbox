using System;
namespace Figures{

    class Circle : IFigure{
        
        private double radius;
        
        public double Radius{
            set{
                if(value <= 0){
                    throw new ArgumentException("Radius must be > 0");
                }
                radius = value;
            }
            get{
                return radius;
            }
        }

        public Circle(double _radius){
            Radius = _radius;
        }
        public double CalculateSquare(){
            return checked (Math.PI * (Radius * Radius));
        }
    }
}
