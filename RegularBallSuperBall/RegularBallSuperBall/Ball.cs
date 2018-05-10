using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularBallSuperBall
{
    public class Ball
    {
        public string ballType { get; set; }

        public Ball(string balltype)
        {
            ballType = balltype;
        }
    }
}
