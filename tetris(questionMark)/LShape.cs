﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris_questionMark_
{
    internal class LShape : Shape
    {
        public override int[,] createShape()
        {
            Random random = new Random();
            coords[0, 0] = random.Next(0, 9);
            coords[0, 1] = 0;
            coords[1, 0] = coords[0, 0];
            coords[1, 1] = -1;
            coords[2, 0] = coords[0, 0];
            coords[2, 1] = -2;
            coords[3, 0] = coords[0, 0]+1;
            coords[3, 1] = 0;

            return coords;
        }

        public override int[,] rotateShape(int[,] coords, int[,] occupiedGrid)
        {
            int x = 0;
            int y = 1;
            int[,] timeVar = coords.Clone() as int[,];
            int[,] kostil = coords.Clone() as int[,];
            if (turn == 1 && coords[1,0] > 0 && Utils.CheckCollision(coords, occupiedGrid))
            {
                coords[3, x] -= 2;
                coords[3, y] -= 0;

                coords[2, x] += 1;
                coords[2, y] += 1;

                coords[1, x] -= 0;
                coords[1, y] += 0;

                coords[0, x] -= 1;
                coords[0, y] -= 1;
                coords = rotateCheck(coords, occupiedGrid, timeVar);
            }
            if (turn == 2 && Utils.CheckCollision(coords, occupiedGrid))
            {
                coords[0, x] += 1;
                coords[0, y] -= 1;

                coords[1, x] += 0;
                coords[1, y] -= 0;

                coords[2, x] -= 1;
                coords[2, y] += 1;

                coords[3, x] -= 0;
                coords[3, y] -= 2;


                coords = rotateCheck(coords, occupiedGrid, timeVar);
            }
            if (turn == 3 && Utils.CheckIfCloseToRightSide(coords))
            {

                coords[0, x] += 1;
                coords[0, y] += 1;

                coords[1, x] += 0;
                coords[1, y] -= 0;

                coords[2, x] -= 1;
                coords[2, y] -= 1;

                coords[3, x] += 2;
                coords[3, y] -= 0;
                coords = rotateCheck(coords, occupiedGrid, timeVar);


            }
            if (turn == 4 && Utils.CheckCollision(coords, occupiedGrid))
            {
                coords[0, x] -= 1;
                coords[0, y] += 1;

                coords[1, x] += 0;
                coords[1, y] += 0;

                coords[2, x] += 1;
                coords[2, y] -= 1;

                coords[3, x] += 0;
                coords[3, y] += 2;
                coords = rotateCheck(coords, occupiedGrid, timeVar);
            }
            if (Utils.Compare(kostil,coords))
            {
                
            } else
            {
                turn++;
                if (turn == 5)
                {
                    turn = 1;
                }
            }
            return coords;
        }
    }
}
