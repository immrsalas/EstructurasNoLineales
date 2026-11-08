namespace EstructurasNoLineales
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
            txtValor = new TextBox();
            btnInsertar = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnRecorridos = new Button();
            lstResultados = new ListBox();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 30);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(175, 35);
            txtValor.TabIndex = 0;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(12, 112);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(131, 40);
            btnInsertar.TabIndex = 1;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(160, 112);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(131, 40);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 171);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnRecorridos
            // 
            btnRecorridos.Location = new Point(160, 171);
            btnRecorridos.Name = "btnRecorridos";
            btnRecorridos.Size = new Size(201, 40);
            btnRecorridos.TabIndex = 4;
            btnRecorridos.Text = "Mostrar Recorridos";
            btnRecorridos.UseVisualStyleBackColor = true;
            btnRecorridos.Click += btnRecorridos_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(631, 112);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(620, 244);
            lstResultados.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 761);
            Controls.Add(lstResultados);
            Controls.Add(btnRecorridos);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnInsertar);
            Controls.Add(txtValor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private Button btnInsertar;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnRecorridos;
        private ListBox lstResultados;
    }
}
