using System;
namespace Figures{
    /*Стандартный вариант, была идеа реализация через перечисляемые параметры(глянуть книгу), но как мне недостаточно безопасно*/
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