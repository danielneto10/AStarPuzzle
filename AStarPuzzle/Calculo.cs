using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarPuzzle
{
    class Calculo
    {
        public int CalcularDistanciaManhattan(Estado estado, Estado final)
        {
            int[] finalM = new int[final.valor.Length];
            int index = 0;
            int distManhatan = 0;
            for (int i = 0; i < estado.valor.GetLength(0); i++)
            {
                for (int j = 0; j < estado.valor.GetLength(1); j++)
                {
                    finalM[index] = final.valor[i, j];
                    index++;
                }
            }

            for (int i = 0; i < estado.valor.GetLength(0); i++)
            {
                for (int j = 0; j < estado.valor.GetLength(1); j++)
                {
                    if (estado.valor[i, j] != 0)
                    {
                        int x1, x2, y1, y2;
                        x1 = i;
                        x2 = Array.IndexOf(finalM, estado.valor[i, j]) / estado.valor.GetLength(0);
                        y1 = j;
                        y2 = Array.IndexOf(finalM, estado.valor[i, j]) % estado.valor.GetLength(0);
                        distManhatan += Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
                    }
                }
            }
            return distManhatan;
        }

        public int CalcularMisPlaceTiles(Estado estado, Estado final)
        {
            int distPlace = 0;
            for (int i = 0; i < estado.valor.GetLength(0); i++)
            {
                for (int j = 0; j < estado.valor.GetLength(1); j++)
                {
                    if (estado.valor[i, j] != final.valor[i, j] && estado.valor[i, j] != 0)
                    {
                        distPlace++;
                    }
                }
            }
            return distPlace;
        }

        public bool TestarParidade(int[,] puzzle)
        {
            int inv_count = 0;
            int[] nums = new int[puzzle.Length];
            int index = 0;
            for (int i = 0; i < puzzle.GetLength(0); i++)
            {
                for (int j = 0; j < puzzle.GetLength(1); j++)
                {
                    nums[index] = puzzle[i, j];
                    index++;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if ((i + j) >= nums.Length)
                    {
                        break;
                    }
                    if (nums[i] > nums[i + j] && nums[i + j] != 0 && nums[i] != 0)
                    {
                        inv_count++;
                    }
                }
            }
            if (inv_count % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
