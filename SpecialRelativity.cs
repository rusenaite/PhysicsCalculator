using System;

namespace PhysicsCalculator
{
    public class SpecialRelativity
    {
        /// <summary>
        /// Lenght invariant in Galilean transformation in is distance between points 
        /// (x1, y1, z1) and (x2, y2, z2).
        /// </summary>
        /// <param name="x1"> x1-coordinate </param>
        /// <param name="y1"> y1-coordinate </param>
        /// <param name="z1"> z1-coordinate </param>
        /// <param name="x2"> x2-coordinate </param>
        /// <param name="y2"> y2-coordinate </param>
        /// <param name="z2"> z2-coordinate </param>
        /// <returns></returns>
        public static double LenghtInvariant(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
        }

        /// <summary>
        /// Time interval invariant under Galilean transformation is difference between 
        /// t2 <paramref name="t2"/> and t1 <paramref name="t1"/>.
        /// </summary>
        /// <param name="t1"> Time in s </param>
        /// <param name="t2"> Time in s </param>
        /// <returns></returns>
        public static double TimeIntervalInvariant(double t1, double t2)
        {
            return t2 - t1;
        }

        /// <summary>
        /// The Lorentz factor (lowercase Greek letter gamma) is 1 / (1 - v^2/c^2)^1/2.
        /// </summary>
        /// <param name="v"> Relative velocity between frames in the x-direction </param>
        /// <returns></returns>
        public static double LorentzFactor(double v)
        {
            return 1 / Math.Sqrt(1 - (Math.Pow(v, 2) / Math.Pow(Constants.SpeedOfLight, 2)));
        }

        /// <summary>
        /// Time dilation is the difference in the elapsed time as measured by two clocks
        /// (time observed in the other reference frame). Equation for calculating time 
        /// dilation is t = t0/(1-v^2/c^2)^1/2.
        /// </summary>
        /// <param name="t"> Time in observers own frame of reference (rest time) </param>
        /// <param name="v"> Speed of the moving object </param>
        /// <returns></returns>
        public static double TimeDilation(double t, double v)
        {
            return t / (Math.Sqrt(1 - (Math.Pow(v, 2) / Math.Pow(Constants.SpeedOfLight, 2))));
        }

        /// <summary>
        /// Length contraction is the shortening of the measured length of an object 
        /// moving relative to the observer's frame: L = L0((1 - v^2/c^2))^1/2.
        /// </summary>
        /// <param name="l0"> Length measured by the observers on reference frame </param>
        /// <param name="v"> Speed of the object </param>
        /// <returns></returns>
        public static double LengthContraction(double l0, double v)
        {
            return l0 / (Math.Sqrt(1 - (Math.Pow(v, 2) / Math.Pow(Constants.SpeedOfLight, 2))));
        }
    }
}
