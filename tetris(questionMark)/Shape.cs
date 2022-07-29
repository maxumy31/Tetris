using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris_questionMark_
{
    abstract class Shape
    {
        public int[,] coords = new int[4, 2];
        public static bool moveRight = false;
        public static bool moveLeft = false;
        public static bool timer = false;
        public static bool isShapeDead = true;
        public static int turn = 1;

        public abstract int[,] createShape();
   
        public void Fall(int[,] coords, int[,] occupiedGrid)
        {
            coords[0, 1] += 1;
            coords[1, 1] += 1;
            coords[2, 1] += 1;
            coords[3, 1] += 1;

            /*for(int i = 0; i < 4; i ++)
            {
                if (coords[i,1] == 19)
                {
                    for(int I = 0; I < 4 ; I++)
                    {
                        occupiedGrid[coords[i, 0], coords[i, 1]] = 1;
                    }
                    break;
               }
            }*/
        }
        public static int[,] rotateCheck(int[,] coords, int[,] occupiedGrid, int[,] timeVar)
        {

            if (Utils.CheckCollision(coords, occupiedGrid))// Это должно предотвратить совпадение клеток падающих с уже посталвенными при повороте
            {
                return coords;
            }
            else
            {
                return timeVar;
            }
        }


        public int[,] ifFallen(int[,] coords, int[,] occupiedGrids)
        {
            for (int i = 0; i < 4; i++)
            {
                if (coords[i, 1] == 19)
                {
                    occupiedGrids[coords[0, 0], coords[0, 1]] = 1;
                    occupiedGrids[coords[1, 0], coords[1, 1]] = 1;
                    occupiedGrids[coords[2, 0], coords[2, 1]] = 1;
                    occupiedGrids[coords[3, 0], coords[3, 1]] = 1;
                    return occupiedGrids;
                }


                if (coords[i, 1] > 0 && coords[i, 1] < 19 && occupiedGrids[coords[i, 0], coords[i, 1] + 1] == 1)
                {
                    try
                    {
                        occupiedGrids[coords[0, 0], coords[0, 1]] = 1;
                        occupiedGrids[coords[1, 0], coords[1, 1]] = 1;
                        occupiedGrids[coords[2, 0], coords[2, 1]] = 1;
                        occupiedGrids[coords[3, 0], coords[3, 1]] = 1;
                        return occupiedGrids;
                    } catch (Exception)
                    {

                    }
                }
            }
            return occupiedGrids;
        }

        public bool ifDefeated(int[,] occupiedGrids)
        {
            for (int x = 0; x < 10; x++)
            {
                if (occupiedGrids[x, 0] == 1)
                {
                    Utils.defeat = true;
                    return true;
                }
            }
            return false;
        }

        public int[,] MoveRight(int[,] coords)
        {
            int[,] timeVar = coords.Clone() as int[,];
            for (int i = 0; i < 4; i++)
            {
                if (coords[i, 0] == 9)
                {
                    return coords;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                coords[i, 0] += 1;
            }
            

            if (Utils.CheckCollision(coords, Form1.occupiedGrid))
            {
                return coords;
            }
            else
            {
                coords = timeVar.Clone() as int[,];
                return coords;
            }
            Form1.activateTimer();
            return coords;
        }

        public int[,] MoveLeft(int[,] coords)
        {
            int[,] timeVar = coords.Clone() as int[,];
            for (int i = 0; i < 4; i++)
            {
                if (coords[i, 0] == 0)
                {
                    return coords;
                }

            }

            for (int i = 0; i < 4; i++)
            {
                coords[i, 0] -= 1;
            }


            if (Utils.CheckCollision(coords, Form1.occupiedGrid))
            {
                return coords;
            }
            else
            {                
                coords = timeVar.Clone() as int[,];
                return coords;
            }
            Form1.activateTimer();
            return coords;
        }
      

    public abstract int[,] rotateShape(int[,] coords, int[,] occupiedGrid);
    }
}
