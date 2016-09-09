using System;

namespace Sphere{
    public class SphereTest{
        public static void Main(string[] args){
            Sphere testSphere = new Sphere();

            testSphere.Xcoordinate = 4;
            testSphere.Ycoordinate = 5;
            testSphere.Zcoordinate = 2;
            testSphere.Radius = 3.25;

            Console.WriteLine("This is a Sphere at center ({0}, {1}, {2}).", testSphere.Xcoordinate, testSphere.Ycoordinate, testSphere.Zcoordinate);
            Console.WriteLine("The Sphere has volumn of {0} and surface are of {1}", testSphere.CalculateVolume(), testSphere.CalculateSurface());
        }
    }
}
