using System;

namespace Sphere{
    public class SphereTest{
        public static void Main(string[] args){
            Sphere testSphere = new Sphere();

            testSphere.Xcoordinate = 4;
            testSphere.Ycoordinate = 5;
            testSphere.Zcoordinate = 2;
            testSphere.Radius = 3.5;

            Console.WriteLine("This is a Sphere at center ({0}, {1}, {2}).", testSphere.Xcoordinate, testSphere.Ycoordinate, testSphere.Zcoordinate);
            Console.WriteLine("The Sphere has volumn of {0} and surface are of {1}.", testSphere.CalculateVolume(), testSphere.CalculateSurface());
        }
    }
}

/************************************TEST OUTPUT****************************************
➜  Sphere git:(master) ✗ dotnet run
Project Sphere (.NETCoreApp,Version=v1.0) will be compiled because inputs were modified
Compiling Sphere for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.2275011
 

This is a Sphere at center (4, 5, 2).
The Sphere has volumn of 179.594380030216 and surface are of 153.9380400259.
/********************************* END TEST OUTPUT**************************************