using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris_questionMark_
{
    static class Utils
    {
        public static bool defeat = false;

        public static bool Compare(int[,] arr1, int[,] arr2)
        {
            for(int i = 0; i < arr1.GetUpperBound(0) + 1;i++)
            {
                for (int x = 0; x < arr2.GetUpperBound(1) + 1; x++)
                {
                    if (arr1[i,x] == arr2[i,x])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool CheckIfCloseToRightSide(int[,] coords)
        {
            for (int i = 0; i < 4; i++)
            {
                if (coords[i, 0] >= 9)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckIfCloseToLeftSide(int[,] coords)
        {
            for (int i = 0; i < 4; i++)
            {
                if (coords[i, 0] <= 1)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckCollision(int[,] coords, int[,] occupiedGrid)//Проверяет совпадение клуток из координат и из общей сетки
        {
            for(int i = 0; i < 4; i ++)
            {
                if (coords[i,1] < 0 || coords[i,0] > 9 || coords[i,1] > 19)
                {
                    return true;}
                if (occupiedGrid[coords[i, 0], coords[i,1]] == 1)
                {
                    return false;
                }
                
            }
            return true;
        }

    }

    



    
}
