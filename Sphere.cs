using System;

namespace Sphere {
  public class Sphere {
    public int Xcoordinate {get; set;}
    public int Ycoordinate {get; set;}
    public int Zcoordinate {get; set;}
    public double Radius {get; set;}
    public double CalculateVolume() {
      return (4.0 / 3) * (Math.PI) * (Math.Pow(Radius, 3));
    }
    public double CalculateSurface() {
      return 4 * (Math.PI) * (Math.Pow(Radius, 2));
    }
  }
}