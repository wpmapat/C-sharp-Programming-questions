using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularBallSuperBall
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball("super");
            Console.WriteLine("Balltype is {0}", ball.ballType);
        }

    }
}
