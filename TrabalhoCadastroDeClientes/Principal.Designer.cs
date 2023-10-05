namespace TrabalhoCadastroDeClientes
{
    partial class Principal
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
            GridData = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            AdicionarClienteBtn = new Button();
            VisualizacãoAvanCadaBtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)GridData).BeginInit();
            SuspendLayout();
            // 
            // GridData
            // 
            GridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridData.Columns.AddRange(new DataGridViewColumn[] { Nome, Email, Telefone, Id });
            GridData.Location = new Point(12, 12);
            GridData.Name = "GridData";
            GridData.RowTemplate.Height = 25;
            GridData.Size = new Size(776, 342);
            GridData.TabIndex = 0;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Resizable = DataGridViewTriState.False;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Resizable = DataGridViewTriState.False;
            // 
            // Telefone
            // 
            Telefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Resizable = DataGridViewTriState.False;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // AdicionarClienteBtn
            // 
            AdicionarClienteBtn.Location = new Point(12, 377);
            AdicionarClienteBtn.Name = "AdicionarClienteBtn";
            AdicionarClienteBtn.Size = new Size(142, 61);
            AdicionarClienteBtn.TabIndex = 1;
            AdicionarClienteBtn.Text = "Adicionar Cliente";
            AdicionarClienteBtn.UseVisualStyleBackColor = true;
            AdicionarClienteBtn.Click += AdicionarClienteBtn_Click;
            // 
            // VisualizacãoAvanCadaBtn
            // 
            VisualizacãoAvanCadaBtn.Location = new Point(646, 377);
            VisualizacãoAvanCadaBtn.Name = "VisualizacãoAvanCadaBtn";
            VisualizacãoAvanCadaBtn.Size = new Size(142, 61);
            VisualizacãoAvanCadaBtn.TabIndex = 2;
            VisualizacãoAvanCadaBtn.Text = "Editar Linha Selecionada";
            VisualizacãoAvanCadaBtn.UseVisualStyleBackColor = true;
            VisualizacãoAvanCadaBtn.Click += VisualizacãoAvanCadaBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(333, 377);
            button1.Name = "button1";
            button1.Size = new Size(124, 61);
            button1.TabIndex = 3;
            button1.Text = "Recarregar Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(VisualizacãoAvanCadaBtn);
            Controls.Add(AdicionarClienteBtn);
            Controls.Add(GridData);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Principal";
            Text = "Clientes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GridData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridData;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefone;
        private Button AdicionarClienteBtn;
        private Button VisualizacãoAvanCadaBtn;
        private DataGridViewTextBoxColumn Id;
        private Button button1;
    }
}