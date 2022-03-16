namespace PhysicsCalculator.Formulas
{
    public class Kinematics
    {
        /// <summary>
        /// Average velocity v can be calculated by dividing change in position vector 
        /// <paramref name="r"/> during the time interval <paramref name="t"/>: v = r / t.
        /// </summary>
        /// <param name="r"> Change in the position vector (in metres) </param>
        /// <param name="t"> Time interval (in seconds) </param>
        /// <returns> If calculations went well, returns average velocity, otherwise - 0. 
        /// Units: m/s </returns>
        public static double AverageVelocity(double r, double t)
        {
            return r / t;
        }

        /// <summary>
        /// Average acceleration of the particle over time is defined by the ratio of
        /// the velocity vector <paramref name="v"/> and time interval
        /// <paramref name="t"/>: a = v / t.
        /// </summary>
        /// <param name="v"> Difference in the velocity vector (in m/s) </param>
        /// <param name="t"> Time interval (in seconds) </param>
        /// <returns> If calculations went well, returns average acceleration, otherwise - 0. 
        /// Units: m/s^2 </returns>
        public static double AverageAcceleration(double v, double t)
        {
            return v / t;
        }

        /// <summary>
        /// Time from average acceleration formula can be found by difference of
        /// velocities (<paramref name="v"/> and <paramref name="v0"/>) divided by 
        /// acceleration <paramref name="a"/> : t = (v- v0) / a.
        /// </summary>
        /// <param name="v"> Velocity (in m/s) </param>
        /// <param name="v0"> Velocity (in m/s) </param>
        /// <param name="a"> Average acceleration (in m/s^2) </param>
        /// <returns> If calculations went well, returns time, otherwise - 0. 
        /// Units: s </returns>
        public static double TimeFromAverageAcceleration(double v, double v0, double a)
        {
            return (v - v0) / a;
        }

        /// <summary>
        /// Angular velocity (Greek letter omega) can be calculated by angular
        /// rotation <paramref name="angularRotation"/> (Greek letter theta) divided by 
        /// time <paramref name="t"/>: omega = theta / t.
        /// </summary>
        /// <param name="angularRotation"> Angular rotation </param>
        /// <param name="t"> Time </param>
        /// <returns> If calculations went well, returns angular velocity, otherwise - 0. 
        /// Units: 1/s or s-1 (radians per second) </returns>
        public static double AngularVelocity(double angularRotation, double t)
        {
            return angularRotation / t;
        }
    }
}
