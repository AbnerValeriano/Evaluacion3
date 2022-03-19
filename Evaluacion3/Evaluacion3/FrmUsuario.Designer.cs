namespace Evaluacion3
{
    partial class FrmUsuario
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
            this.ListardataGridView = new System.Windows.Forms.DataGridView();
            this.ListarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListardataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListardataGridView
            // 
            this.ListardataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListardataGridView.Location = new System.Drawing.Point(25, 36);
            this.ListardataGridView.Name = "ListardataGridView";
            this.ListardataGridView.RowHeadersWidth = 51;
            this.ListardataGridView.RowTemplate.Height = 24;
            this.ListardataGridView.Size = new System.Drawing.Size(729, 222);
            this.ListardataGridView.TabIndex = 0;
            // 
            // ListarButton
            // 
            this.ListarButton.Location = new System.Drawing.Point(290, 277);
            this.ListarButton.Name = "ListarButton";
            this.ListarButton.Size = new System.Drawing.Size(157, 48);
            this.ListarButton.TabIndex = 1;
            this.ListarButton.Text = "Listar Usuarios";
            this.ListarButton.UseVisualStyleBackColor = true;
            this.ListarButton.Click += new System.EventHandler(this.ListarButton_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListarButton);
            this.Controls.Add(this.ListardataGridView);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.ListardataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListardataGridView;
        private System.Windows.Forms.Button ListarButton;
    }
}