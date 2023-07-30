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
            label1 = new Label();
            txt_nome = new TextBox();
            button1 = new Button();
            txt_delete = new Button();
            label2 = new Label();
            label3 = new Label();
            txt_Telefone = new TextBox();
            txt_Email = new TextBox();
            list_contato = new ListView();
            label4 = new Label();
            txt_buscar_contato = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            txt_nome.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nome.ForeColor = SystemColors.MenuText;
            txt_nome.Location = new Point(15, 33);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(239, 23);
            txt_nome.TabIndex = 1;
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
            // txt_delete
            // 
            txt_delete.Location = new Point(93, 168);
            txt_delete.Name = "txt_delete";
            txt_delete.Size = new Size(75, 23);
            txt_delete.TabIndex = 7;
            txt_delete.Text = "Deletar";
            txt_delete.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "E-mail:";
            // 
            // txt_Telefone
            // 
            txt_Telefone.ForeColor = SystemColors.MenuText;
            txt_Telefone.Location = new Point(15, 81);
            txt_Telefone.Name = "txt_Telefone";
            txt_Telefone.Size = new Size(239, 23);
            txt_Telefone.TabIndex = 2;
            // 
            // txt_Email
            // 
            txt_Email.ForeColor = SystemColors.MenuText;
            txt_Email.Location = new Point(15, 138);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(239, 23);
            txt_Email.TabIndex = 3;
            // 
            // list_contato
            // 
            list_contato.Location = new Point(260, 62);
            list_contato.Name = "list_contato";
            list_contato.Size = new Size(431, 146);
            list_contato.TabIndex = 8;
            list_contato.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(260, 11);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Buscar Contato";
            // 
            // txt_buscar_contato
            // 
            txt_buscar_contato.Location = new Point(260, 33);
            txt_buscar_contato.Name = "txt_buscar_contato";
            txt_buscar_contato.Size = new Size(277, 23);
            txt_buscar_contato.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(543, 33);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 221);
            Controls.Add(button2);
            Controls.Add(txt_buscar_contato);
            Controls.Add(label4);
            Controls.Add(list_contato);
            Controls.Add(txt_Email);
            Controls.Add(txt_Telefone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_delete);
            Controls.Add(button1);
            Controls.Add(txt_nome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "CRUD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_nome;
        private Button button1;
        private Button txt_delete;
        private Label label2;
        private Label label3;
        private TextBox txt_Telefone;
        private TextBox txt_Email;
        private ListView list_contato;
        private Label label4;
        private TextBox txt_buscar_contato;
        private Button button2;
    }
}