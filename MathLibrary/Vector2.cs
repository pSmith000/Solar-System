using System;

namespace MathLibrary
{
    public struct Vector2
    {
        public float X;
        public float Y;

        /// <summary>
        /// Adds the x value of the second vector to the first, and adds the y value of the second vector to the first.
        /// </summary>
        /// <param name="lhs">The vector that is increasing</param>
        /// <param name="rhs">The vector used to increase the 1st vector</param>
        /// <returns>The result of the vector additions</returns>
        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2 { X = lhs.X + rhs.X, Y = lhs.Y + rhs.Y };
        }

        /// <summary>
        /// Subtracts the x value of the second vector to the first, and subtracts the y value of the second vector to the first.
        /// </summary>
        /// <param name="lhs">The vector that is decreasing</param>
        /// <param name="rhs">The vector used to decrease the 1st vector</param>
        /// <returns>The result of the vector subtractionss</returns>
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2 { X = lhs.X - rhs.X, Y = lhs.Y - rhs.Y };
        }

        /// <summary>
        /// Multiplies the vectors x and y values by the scalar
        /// </summary>
        /// <param name="lhs">The vector that is being scaled</param>
        /// <param name="rhs">The value to scale the vector</param>
        /// <returns>The result of the vector scaling</returns>
        public static Vector2 operator *(Vector2 lhs, float rhs)
        {
            return new Vector2 { X = lhs.X * rhs, Y = lhs.Y * rhs };
        }

        /// <summary>
        /// Divides the vectors x and y values by the scalar
        /// </summary>
        /// <param name="lhs">The vector that is being scaled</param>
        /// <param name="rhs">The value to scale the vector</param>
        /// <returns>The result of the vector scaling</returns>
        public static Vector2 operator /(Vector2 lhs, float rhs)
        {
            return new Vector2 { X = lhs.X / rhs, Y = lhs.Y / rhs };
        }

        /// <summary>
        /// Compares the x and y values of two vectors
        /// </summary>
        /// <param name="lhs">The left side of the comparison</param>
        /// <param name="rhs">The right side of the comparison</param>
        /// <returns>True if the x and y values of both vectors are the same</returns>
        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            return (lhs.X == rhs.X && lhs.Y == rhs.Y);
        }

        /// <summary>
        /// Compares the x and y values of two vectors
        /// </summary>
        /// <param name="lhs">The left side of the comparison</param>
        /// <param name="rhs">The right side of the comparison</param>
        /// <returns>True if the x and y values of both vectors are the not the same</returns>
        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return (!(lhs.X == rhs.X && lhs.Y == rhs.Y));

        }
    }
}
