
namespace appVenta.Vista
{
    partial class FrmPadre
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.tablasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem1});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.ventasToolStripMenuItem1_Click);
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDProductoToolStripMenuItem,
            this.cRUDClienteToolStripMenuItem,
            this.cRUDToolStripMenuItem,
            this.cRUDDocumentoToolStripMenuItem});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // cRUDProductoToolStripMenuItem
            // 
            this.cRUDProductoToolStripMenuItem.Name = "cRUDProductoToolStripMenuItem";
            this.cRUDProductoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cRUDProductoToolStripMenuItem.Text = "CRUD Producto";
            this.cRUDProductoToolStripMenuItem.Click += new System.EventHandler(this.cRUDProductoToolStripMenuItem_Click);
            // 
            // cRUDClienteToolStripMenuItem
            // 
            this.cRUDClienteToolStripMenuItem.Name = "cRUDClienteToolStripMenuItem";
            this.cRUDClienteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cRUDClienteToolStripMenuItem.Text = "CRUD Cliente";
            this.cRUDClienteToolStripMenuItem.Click += new System.EventHandler(this.cRUDClienteToolStripMenuItem_Click);
            // 
            // cRUDToolStripMenuItem
            // 
            this.cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            this.cRUDToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cRUDToolStripMenuItem.Text = "CRUD Usuario";
            this.cRUDToolStripMenuItem.Click += new System.EventHandler(this.cRUDToolStripMenuItem_Click);
            // 
            // cRUDDocumentoToolStripMenuItem
            // 
            this.cRUDDocumentoToolStripMenuItem.Name = "cRUDDocumentoToolStripMenuItem";
            this.cRUDDocumentoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cRUDDocumentoToolStripMenuItem.Text = "CRUD Documento";
            this.cRUDDocumentoToolStripMenuItem.Click += new System.EventHandler(this.cRUDDocumentoToolStripMenuItem_Click);
            // 
            // FrmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmPadre_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDDocumentoToolStripMenuItem;
    }
}