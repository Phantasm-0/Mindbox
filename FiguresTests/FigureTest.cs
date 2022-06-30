using System;
namespace Figures{
    public static class FigureTest
    {
        static public void TestAll(){
            TestTriangleRectangular();
            TryCreateBadObjects();
        }
        static public bool TestTriangleRectangular(){
            Triangle trg1 =  new (6,8,10);
            Triangle trg2 =  new (10,6,8);
            Triangle trg3 =  new (8,10,6);

            Console.WriteLine(trg1.IsRectangular());
            Console.WriteLine(trg2.IsRectangular());
            Console.WriteLine(trg3.IsRectangular());
            return true;
        }
        static public bool TryCreateBadObjects(){
            try{
                Triangle test1 = new(-1,-2,4);
            }
            catch(Exception Exception){
                Console.WriteLine(Exception.Message);
            }
            try{
                Triangle test2 = new(0,0,0);
            }
            catch(Exception Exception){
                Console.WriteLine(Exception.Message);
            }
            try{
                Circle test3 = new(0);
            }
            catch(Exception Exception){
                Console.WriteLine(Exception.Message);
            }
            try{
                Circle test4 = new (-5);
            }
            catch(Exception Exception){
                Console.WriteLine(Exception.Message);
            }
            return true;
        }
    }
}