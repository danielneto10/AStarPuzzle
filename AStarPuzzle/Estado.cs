using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AStarPuzzle
{
    public class Estado
    {
        public int Fscore { get; set; }
        public string Codigo { get; set; }

        public int level = 0;
        public int[,] valor;
        public Estado pai = null;
        public Estado(int[,] valor)
        {
            this.valor = valor;
            Codigo = GerarCodigo();
        }
        public List<Estado> GerarEstados(List<string> codigos)
        {
            int[] zeroIndex = AcharZero(this);
            int x = zeroIndex[0];
            int y = zeroIndex[1];
            List<Estado> listEstadosCandidatos = new List<Estado>();
            List<int[]> movimentos = new List<int[]> {
                new int[2] { x, y-1 }, //Movimento para esquerda
                new int[2] { x, y+1 }, //Movimento para direita
                new int[2] { x-1, y }, //Movimento para cima
                new int[2] { x+1, y } }; // Movimento para baixo

            foreach (int[] pos in movimentos)
            {
                Estado possivelEstado = ValidarMovimento(this.valor, x, y, pos[0], pos[1]);

                if (possivelEstado != null && !codigos.Contains(possivelEstado.Codigo))
                {
                    possivelEstado.pai = this;
                    possivelEstado.level = this.level + 1;
                    listEstadosCandidatos.Add(possivelEstado);
                }
            }
            return listEstadosCandidatos;
        }

        public Estado ValidarMovimento(int[,] puzzle, int zeroX, int zeroY, int x, int y)
        {
            if (x >= 0 && x < puzzle.GetLength(0) && y >= 0 && y < puzzle.GetLength(1))
            {
                int[,] tempPuzzle = (int[,])puzzle.Clone();
                tempPuzzle[zeroX, zeroY] = puzzle[x, y];
                tempPuzzle[x, y] = 0;
                return new Estado(tempPuzzle);
            }
            else
            {
                return null;
            }
        }

        public string GerarCodigo()
        {
            string c = "";
            for (int i = 0; i < valor.GetLength(0); i++)
            {
                for (int j = 0; j < valor.GetLength(1); j++)
                {
                    c += valor[i, j] + "+"; 
                }
            }
            return c;
        }

        public int[] AcharZero(Estado estado)
        {
            int[] zeroIndex = new int[2];
            for (int i = 0; i < estado.valor.GetLength(0); i++)
            {
                for (int j = 0; j < estado.valor.GetLength(1); j++)
                {
                    if (estado.valor[i, j] == 0)
                    {
                        zeroIndex[0] = i;
                        zeroIndex[1] = j;
                    }
                }
            }
            return zeroIndex;
        }
    }
}
