using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris_questionMark_
{
    internal class OShape : Shape
    {
        public override int[,] createShape()
        {
            Random random = new Random();
            coords[0, 0] = random.Next(0, 9);
            coords[0, 1] = 0;
            coords[1, 0] = coords[0, 0];
            coords[1, 1] = -1;
            coords[2, 0] = coords[0, 0]+1;
            coords[2, 1] = 0;
            coords[3, 0] = coords[0, 0] + 1;
            coords[3, 1] = -1;

            return coords;
        }

        public override int[,] rotateShape(int[,] coords, int[,] occupiedGrid)
        {
            return coords;
        }
    }
}
