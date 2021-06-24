
namespace AStarPuzzle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tresModo = new System.Windows.Forms.ToolStripMenuItem();
            this.quatroModo = new System.Windows.Forms.ToolStripMenuItem();
            this.matriz3x3 = new AStarPuzzle.Matriz3x3();
            this.matriz4x4 = new AStarPuzzle.Matriz4x4();
            this.lblEstadosGerados = new System.Windows.Forms.Label();
            this.lblEstadosVisitados = new System.Windows.Forms.Label();
            this.lblEstadoLevel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resolver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(358, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(381, 517);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modoMenu
            // 
            this.modoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tresModo,
            this.quatroModo});
            this.modoMenu.Name = "modoMenu";
            this.modoMenu.Size = new System.Drawing.Size(51, 20);
            this.modoMenu.Text = "Modo";
            // 
            // tresModo
            // 
            this.tresModo.Name = "tresModo";
            this.tresModo.Size = new System.Drawing.Size(92, 22);
            this.tresModo.Text = "3x3";
            this.tresModo.Click += new System.EventHandler(this.tresModo_Click);
            // 
            // quatroModo
            // 
            this.quatroModo.Name = "quatroModo";
            this.quatroModo.Size = new System.Drawing.Size(92, 22);
            this.quatroModo.Text = "4x4";
            this.quatroModo.Click += new System.EventHandler(this.quatroModo_Click);
            // 
            // matriz3x3
            // 
            this.matriz3x3.Location = new System.Drawing.Point(12, 27);
            this.matriz3x3.Name = "matriz3x3";
            this.matriz3x3.Size = new System.Drawing.Size(311, 196);
            this.matriz3x3.TabIndex = 39;
            // 
            // matriz4x4
            // 
            this.matriz4x4.Location = new System.Drawing.Point(12, 27);
            this.matriz4x4.Name = "matriz4x4";
            this.matriz4x4.Size = new System.Drawing.Size(340, 250);
            this.matriz4x4.TabIndex = 40;
            this.matriz4x4.Visible = false;
            // 
            // lblEstadosGerados
            // 
            this.lblEstadosGerados.AutoSize = true;
            this.lblEstadosGerados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadosGerados.Location = new System.Drawing.Point(22, 358);
            this.lblEstadosGerados.Name = "lblEstadosGerados";
            this.lblEstadosGerados.Size = new System.Drawing.Size(155, 25);
            this.lblEstadosGerados.TabIndex = 41;
            this.lblEstadosGerados.Text = "Estados Gerados:";
            // 
            // lblEstadosVisitados
            // 
            this.lblEstadosVisitados.AutoSize = true;
            this.lblEstadosVisitados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadosVisitados.Location = new System.Drawing.Point(22, 396);
            this.lblEstadosVisitados.Name = "lblEstadosVisitados";
            this.lblEstadosVisitados.Size = new System.Drawing.Size(161, 25);
            this.lblEstadosVisitados.TabIndex = 42;
            this.lblEstadosVisitados.Text = "Estados Visitados:";
            // 
            // lblEstadoLevel
            // 
            this.lblEstadoLevel.AutoSize = true;
            this.lblEstadoLevel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoLevel.Location = new System.Drawing.Point(22, 432);
            this.lblEstadoLevel.Name = "lblEstadoLevel";
            this.lblEstadoLevel.Size = new System.Drawing.Size(145, 25);
            this.lblEstadoLevel.TabIndex = 43;
            this.lblEstadoLevel.Text = "Caminho Custo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 541);
            this.Controls.Add(this.lblEstadoLevel);
            this.Controls.Add(this.lblEstadosVisitados);
            this.Controls.Add(this.lblEstadosGerados);
            this.Controls.Add(this.matriz4x4);
            this.Controls.Add(this.matriz3x3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoMenu;
        private System.Windows.Forms.ToolStripMenuItem tresModo;
        private System.Windows.Forms.ToolStripMenuItem quatroModo;
        private Matriz3x3 matriz3x3;
        private Matriz4x4 matriz4x4;
        private System.Windows.Forms.Label lblEstadosGerados;
        private System.Windows.Forms.Label lblEstadosVisitados;
        private System.Windows.Forms.Label lblEstadoLevel;
    }
}

