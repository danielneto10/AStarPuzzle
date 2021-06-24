using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AStarPuzzle
{
    class LogCaminho
    {
        public void AtualizarLogSolver(Estado estado, Form1 myFormControl)
        {
            myFormControl.Invoke(myFormControl.delegateAtualizar, new object[] { estado });
        }

        public void AtualizarEstadosInfo(int gerado, int explorado, int caminho, Form1 myFormControl)
        {
            myFormControl.Invoke(myFormControl.delegateLabelsEstado, new object[] { gerado, explorado, caminho });
        }
    }
}
