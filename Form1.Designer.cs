namespace WinFormsCRUD
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNome = new TextBox();
            button1 = new Button();
            button8 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            list_contato = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            label4 = new Label();
            txt_buscar_contato = new TextBox();
            button2 = new Button();
            button3 = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.MenuText;
            txtNome.Location = new Point(15, 33);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(239, 23);
            txtNome.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 168);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button8
            // 
            button8.Location = new Point(174, 168);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "Deletar";
            button8.UseVisualStyleBackColor = true;
            button8.Visible = false;
            button8.Click += txt_delete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 120);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 63);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.ForeColor = SystemColors.MenuText;
            txtEmail.Location = new Point(15, 81);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.ForeColor = SystemColors.MenuText;
            txtTelefone.Location = new Point(15, 138);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(239, 23);
            txtTelefone.TabIndex = 3;
            // 
            // list_contato
            // 
            list_contato.ContextMenuStrip = contextMenuStrip1;
            list_contato.Location = new Point(260, 62);
            list_contato.MultiSelect = false;
            list_contato.Name = "list_contato";
            list_contato.Size = new Size(433, 331);
            list_contato.TabIndex = 8;
            list_contato.UseCompatibleStateImageBehavior = false;
            list_contato.ItemSelectionChanged += list_contato_ItemSelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(110, 26);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(109, 22);
            toolStripMenuItem1.Text = "Excluir";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 15);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Buscar Contato";
            // 
            // txt_buscar_contato
            // 
            txt_buscar_contato.Location = new Point(260, 33);
            txt_buscar_contato.Name = "txt_buscar_contato";
            txt_buscar_contato.Size = new Size(352, 23);
            txt_buscar_contato.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(618, 33);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(93, 168);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Novo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(708, 405);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txt_buscar_contato);
            Controls.Add(label4);
            Controls.Add(list_contato);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button8);
            Controls.Add(button1);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CRUD";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button button1;
        private Button button8;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private ListView list_contato;
        private Label label4;
        private TextBox txt_buscar_contato;
        private Button button2;
        private Button button3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}