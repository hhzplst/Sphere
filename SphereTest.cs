using System;

namespace Sphere{
    public class SphereTest{
        public static void Main(string[] args){
            Sphere testSphere = new Sphere(4,5,2);
            testSphere.Radius = 3.5;

            Console.WriteLine(testSphere);
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
The Sphere has volumn of 179.59 and surface are of 153.94.
********************************* END TEST OUTPUT***************************************/