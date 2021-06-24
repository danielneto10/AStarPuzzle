using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStarPuzzle
{
    class Puzzle
    {
        public Estado inicial;
        public Estado atual;
        public Estado final;
        List<string> explorado;
        List<Estado> listAberta;
        List<Estado> listFechada;
        private Form1 myFormControl;
        public Puzzle(int[,] inicial, int[,] final, Form1 myForm)
        {
            myFormControl = myForm;

            this.inicial = new Estado(inicial);
            this.final = new Estado(final);

            explorado = new List<string>();
            listAberta = new List<Estado>();
            listFechada = new List<Estado>();
        }

        public void Solver()
        {
            //while (inicial.Codigo != final.Codigo)
            //{
            //    int maiorfScore = 0;
            //    listAberta.AddRange(inicial.GerarEstados());
            //    foreach (Estado estado in listAberta)
            //    {
            //        if (!explorado.Contains(estado.Codigo) && (CalcularFscore(estado, final) < maiorfScore || maiorfScore == 0))
            //        {
            //            maiorfScore = estado.Fscore;
            //            inicial = estado;
            //        }
            //    }
            //    explorado.Add(inicial.Codigo);
            //    listAberta.Remove(inicial);
            //    listFechada.Add(inicial);
            //    listFechada.Sort((x, y) => x.Fscore.CompareTo(y.Fscore));
            //    new LogCaminho().AtualizarLogSolver(inicial, myFormControl);
            //}
            int qtdNosGerados = 0;
            listAberta.Add(inicial);
            atual = listAberta[0];

            while (atual.Codigo != final.Codigo)
            {
                atual = listAberta[0];

                new LogCaminho().AtualizarEstadosInfo(qtdNosGerados, listFechada.Count, atual.level, myFormControl);

                foreach (Estado estado in atual.GerarEstados(explorado))
                {
                    qtdNosGerados++;
                    estado.Fscore = CalcularFscore(estado, final);
                    listAberta.Add(estado);
                }

                listFechada.Add(atual);
                explorado.Add(atual.Codigo);
                listAberta.RemoveAt(0);
                listAberta = listAberta.OrderBy(x => x.Fscore).ThenByDescending(x => x.level).ToList();
                //listAberta.Sort((x, y) => x.Fscore.CompareTo(y.Fscore));
            }

            PegarCaminho(atual);
        }

        private void PegarCaminho(Estado estado)
        {
            Stack<Estado> path = new Stack<Estado>();

            while(estado != null)
            {
                path.Push(estado);
                estado = estado.pai;
            }

            Console.WriteLine();

            while(path.Count > 0)
            {
                new LogCaminho().AtualizarLogSolver(path.Pop(), myFormControl);
            }
        }

        public int CalcularFscore(Estado estado, Estado final)
        {
            Calculo calcular = new Calculo();
            //int h;
            //if(estado.valor.GetLength(0) == 3)
            //{
            //    h = calcular.CalcularDistanciaManhattan(estado, final);
            //}
            //else
            //{
            //    h = calcular.CalcularMisPlaceTiles(estado, final);
            //}
            int h = calcular.CalcularDistanciaManhattan(estado, final);
            int g = estado.level;
            int fScore = h + g;
            return fScore;
        }
    }
}
