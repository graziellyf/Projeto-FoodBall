
namespace Foodball
{
    partial class AdicionarPratos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.btnExclui = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(578, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(85, 135);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(205, 20);
            this.textNome.TabIndex = 3;
            // 
            // textPreco
            // 
            this.textPreco.Location = new System.Drawing.Point(367, 137);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(205, 20);
            this.textPreco.TabIndex = 4;
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(640, 136);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(205, 20);
            this.textTipo.TabIndex = 5;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirma.Location = new System.Drawing.Point(276, 270);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(287, 60);
            this.btnConfirma.TabIndex = 6;
            this.btnConfirma.Text = "Adicionar Prato";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExclui.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExclui.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExclui.Location = new System.Drawing.Point(276, 361);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(287, 60);
            this.btnExclui.TabIndex = 7;
            this.btnExclui.Text = "Cancelar";
            this.btnExclui.UseVisualStyleBackColor = false;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.adicionarPedidoToolStripMenuItem,
            this.buscarPratosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarClienteToolStripMenuItem
            // 
            this.adicionarClienteToolStripMenuItem.Name = "adicionarClienteToolStripMenuItem";
            this.adicionarClienteToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.adicionarClienteToolStripMenuItem.Text = "Inicio";
            this.adicionarClienteToolStripMenuItem.Click += new System.EventHandler(this.adicionarClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            // 
            // adicionarPedidoToolStripMenuItem
            // 
            this.adicionarPedidoToolStripMenuItem.Name = "adicionarPedidoToolStripMenuItem";
            this.adicionarPedidoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.adicionarPedidoToolStripMenuItem.Text = "Adicionar Cliente";
            this.adicionarPedidoToolStripMenuItem.Click += new System.EventHandler(this.adicionarPedidoToolStripMenuItem_Click);
            // 
            // buscarPratosToolStripMenuItem
            // 
            this.buscarPratosToolStripMenuItem.Name = "buscarPratosToolStripMenuItem";
            this.buscarPratosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.buscarPratosToolStripMenuItem.Text = "Buscar Pratos ";
            this.buscarPratosToolStripMenuItem.Click += new System.EventHandler(this.buscarPratosToolStripMenuItem_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(53, 73);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(39, 20);
            this.txtID.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "ID:";
            // 
            // AdicionarPratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.textPreco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdicionarPratos";
            this.Text = "AdicionarPratos";
            this.Load += new System.EventHandler(this.AdicionarPratos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPratosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
    }
}