using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome Traveler! I will direct you to the fastest route where ever your heart desires!");
            Console.Write("Enter Your X Coordinate Location in feet: ");
            float user_pos_x = float.Parse(Console.ReadLine()); //User X input
            Console.Write("Enter Your Y Coordinate Location in feet: ");
            float user_pos_y = float.Parse(Console.ReadLine()); //User Y input
            Console.WriteLine("You are here at x: {0:F3} ft, y: {1:F3} ft", user_pos_x, user_pos_y);

            Console.Write("Where does business take you? Enter X Coordinate: "); //Destination X input
            float next_pos_x = float.Parse(Console.ReadLine());
            Console.Write("Enter Y Coordinate: "); //Destination Y input
            float next_pos_y = float.Parse(Console.ReadLine());
            Console.WriteLine("You seek to go to position x: {0:F3} ft, y: {1:F3} ft?", next_pos_x, next_pos_y);

            float distance = Distance(user_pos_x, next_pos_x, user_pos_y, next_pos_y); //Calculate distance based on user arguments
            float angle = Angle(user_pos_x, next_pos_x, user_pos_y, next_pos_y);    //Calculate angle based on user arguments
            Console.WriteLine("You must travel onward for {0:F3} ft with an angle of {1:F3} degrees.", distance, angle);
            Console.WriteLine("Stay safe my friend...for the night is dark and full of terrors.");
            Console.ReadKey();
        }
        //Calculate Delta X of input coordinates
        static float DeltaX(float x1, float x2) {
            float x = (x2-x1);
            return x;
        }
        //Calculate Delta Y of input coordinates
        static float DeltaY(float y1, float y2) {
            float y = (y2 - y1);
            return y;
        }
        //Calculate the distance between 2 points in a cartesian plane
        static float Distance(float x1, float x2, float y1, float y2) {
            float result = (float) Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }
        //Calculate the angle between 2 points in a cartesian points.
        static float Angle(float x1, float x2, float y1, float y2) {
            float dX = DeltaX(x1, x2);
            float dY = DeltaY(y1, y2);
            float radians = (float) Math.Atan2(dY,dX);
            float angle = (float) (radians * (180 / Math.PI));
            return angle;
        }
        
    }
}
