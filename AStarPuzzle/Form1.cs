using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStarPuzzle
{
    public partial class Form1 : Form
    {
        public delegate void AtualizarLog(Estado estado);
        public delegate void AtulizarLabelsEstado(int gerado, int explorado, int caminho);
        public AtualizarLog delegateAtualizar;
        public AtulizarLabelsEstado delegateLabelsEstado;
        int[,] inicial;
        int[,] final;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            delegateAtualizar = new AtualizarLog(AtulizarLogEstado);
            delegateLabelsEstado = new AtulizarLabelsEstado(LogEstadosSendoGerados);
        }

        public void AtulizarLogEstado(Estado estado)
        {
            for (int i = 0; i < estado.valor.GetLength(0); i++)
            {
                for (int j = 0; j < estado.valor.GetLength(1); j++)
                {
                    richTextBox1.AppendText(estado.valor[i, j] + " ");
                }
                richTextBox1.AppendText(Environment.NewLine);
            }
            richTextBox1.AppendText("==================================" + Environment.NewLine);
        }

        public void LogEstadosSendoGerados(int gerado, int explorado, int caminho)
        {
            lblEstadosGerados.Text = "Estados Gerados: " + gerado;
            lblEstadosVisitados.Text = "Estados Visitados: " + explorado;
            lblEstadoLevel.Text = "Custo Caminho: " + caminho;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (matriz3x3.Visible == true)
                {
                    inicial = matriz3x3.inicial;
                    final = matriz3x3.final;
                }
                else
                {
                    inicial = matriz4x4.inicial;
                    final = matriz4x4.final;
                }
                if (inicial != null && final != null)
                {
                    Calculo teste = new Calculo();
                    if (teste.TestarParidade(inicial) == teste.TestarParidade(final))
                    {
                        richTextBox1.Clear();
                        Puzzle puzzle = new Puzzle(inicial, final, this);
                        Thread solverThread = new Thread(() => puzzle.Solver());
                        solverThread.IsBackground = true;
                        solverThread.Start();
                    }
                    else
                    {
                        throw new Exception("O problema não possui solução");
                    }
                }
                else
                {
                    throw new Exception("Verifique que a matriz foi preenchida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tresModo_Click(object sender, EventArgs e)
        {
            matriz3x3.Visible = true;
            matriz4x4.Visible = false;
            inicial = null;
            final = null;
        }

        private void quatroModo_Click(object sender, EventArgs e)
        {
            matriz3x3.Visible = false;
            matriz4x4.Visible = true;
            inicial = null;
            final = null;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
