using System;
namespace Figures{
    class Triangle : IFigure{

        private const double rectulungarConst = 0;
        double firstSideLength;
        
        double secondSideLength;

        double thirdSideLength;

        double FirstSideLength{
            get{
                return firstSideLength;
            }
            set{
                CheckNegativeAndThrowException(value);
                firstSideLength = value;
            }
        }
        double SecondSideLength{
            get{
                return secondSideLength;
            }
            set{
                CheckNegativeAndThrowException(value);
                secondSideLength = value;
            }
        }
        double ThirdSideLength{
            get{
                return thirdSideLength;
            }
            set{
                CheckNegativeAndThrowException(value);
                thirdSideLength = value;
            }
        }
        public Triangle(double firstSideLength , double secondSideLength, double thirdSideLength){ //проверка на нул
            FirstSideLength = firstSideLength;
            SecondSideLength = secondSideLength;
            ThirdSideLength = thirdSideLength;
        }
        public double CalculateSquare(){

            double halfSum = checked (FirstSideLength + SecondSideLength + ThirdSideLength) / 2;

            return Math.Sqrt(halfSum * (halfSum - FirstSideLength) * (halfSum - SecondSideLength) * (halfSum - ThirdSideLength));
        }

        public bool IsRectangular(){
            double firstAngle = (Math.Pow(FirstSideLength,2) + Math.Pow(SecondSideLength,2)- Math.Pow(ThirdSideLength,2)) 
                                /(2 * FirstSideLength * SecondSideLength);
            
            double secondAngle = (Math.Pow(FirstSideLength,2) + Math.Pow(ThirdSideLength,2)- Math.Pow(SecondSideLength,2))
                                /(2 * FirstSideLength * ThirdSideLength);

            double thirdAngle = (Math.Pow(SecondSideLength,2) + Math.Pow(ThirdSideLength,2) - Math.Pow(FirstSideLength,2))
                                /(2 * SecondSideLength * ThirdSideLength);
            return ((firstAngle == rectulungarConst) || (secondAngle == rectulungarConst) || (thirdAngle == rectulungarConst));
            ;
        }

        private bool CheckNegativeAndThrowException(double value){
            if(value <= 0){
                throw  new ArgumentException("Side must be > 0");
            }
            return false;
        }
    }
}