using System;

namespace Sphere {
  public class Sphere {
    public double Xcoordinate {get; set;}
    public double Ycoordinate {get; set;}
    public double Zcoordinate {get; set;}
    public double Radius {get; set;}
    public Sphere (double x, double y, double z) {
      Xcoordinate = x;
      Ycoordinate = y;
      Zcoordinate = z;
    }
    public double CalculateVolume() {
      return (4.0 / 3) * (Math.PI) * (Math.Pow(Radius, 3));
    }
    public double CalculateSurface() {
      return 4 * (Math.PI) * (Math.Pow(Radius, 2));
    }
    public override string ToString() {
      return  String.Format("This is a Sphere at center ({0}, {1}, {2}).\n" +
                            "The Sphere has volumn of {3:f} and surface are of {4:f}.", 
                            Xcoordinate, Ycoordinate, Zcoordinate, this.CalculateVolume(), this.CalculateSurface());
    }
  }
}