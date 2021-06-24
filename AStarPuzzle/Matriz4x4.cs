using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStarPuzzle
{
    public partial class Matriz4x4 : UserControl
    {
        public int[,] inicial;
        public int[,] final;
        List<TextBox> matrizInicial;
        List<TextBox> matrizFinal;
        public Matriz4x4()
        {
            InitializeComponent();
        }

        private void btnInserirInicial_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr = TransformarEmArray(txtInicial.Text);
                Verificar(arr);
                PreencherTxtBox(arr, matrizInicial);
                txtInicial.Text = String.Empty;
                inicial = TranformarEm2DArray(arr);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInserirFinal_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arr = TransformarEmArray(txtFinal.Text);
                Verificar(arr);
                PreencherTxtBox(arr, matrizFinal);
                txtFinal.Text = String.Empty;
                final = TranformarEm2DArray(arr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int[] TransformarEmArray(string text)
        {
            string[] matrizString = text.Split(",");
            foreach (string valor in matrizString)
            {
                if (!int.TryParse(valor, out int numero))
                {
                    throw new Exception("Digite apenas numeros e virgulas");
                }
            }
            int[] arr = matrizString.Select(x => int.Parse(x.ToString())).ToArray();
            return arr;
        }
        private bool Verificar(int[] matriz)
        {
            HashSet<int> unique = new HashSet<int>();
            if (matriz.Length < 16)
            {
                throw new Exception("Todos os campos da matriz devem estar preenchidos");
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                if (matriz[i] >= 16 || matriz[i] < 0)
                {
                    throw new Exception("Preencher a matriz apenas com numeros entre 0 e 8");
                }
            }
            foreach (int valor in matriz)
            {
                if (!unique.Add(valor))
                {
                    throw new Exception("Preencher apenas com numeros não repetidos entre 0 e 8");
                }
            }
            return true;
        }
        private void PreencherTxtBox(int[] matriz, List<TextBox> lista)
        {
            int index = 0;
            foreach (TextBox txt in lista)
            {
                txt.Text = matriz[index].ToString();
                index++;
            }
        }
        private int[,] TranformarEm2DArray(int[] matriz)
        {
            int[,] arr = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = matriz[i * 4 + j];
                }
            }
            return arr;
        }

        private void Matriz4x4_Load(object sender, EventArgs e)
        {
            matrizInicial = new List<TextBox>() {
                txtInicial1, txtInicial2, txtInicial3, txtInicial4, 
                txtInicial5, txtInicial6, txtInicial7, txtInicial8,
                txtInicial9, txtInicial10, txtInicial11, txtInicial12,
                txtInicial13, txtInicial14, txtInicial15, txtInicial16
            };

            matrizFinal = new List<TextBox>() {
                txtFinal1, txtFinal2, txtFinal3, txtFinal4,
                txtFinal5, txtFinal6, txtFinal7, txtFinal8,
                txtFinal9, txtFinal10, txtFinal11, txtFinal12,
                txtFinal13, txtFinal14, txtFinal15, txtFinal16
            };
        }
    }
}
