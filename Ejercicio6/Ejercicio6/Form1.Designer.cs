namespace Ejercicio6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_principal = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_listbox = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.comboBox_operaciones = new System.Windows.Forms.ComboBox();
            this.btn_genenar = new System.Windows.Forms.Button();
            this.listBox_numeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_principal
            // 
            this.lbl_principal.AutoSize = true;
            this.lbl_principal.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_principal.Location = new System.Drawing.Point(283, 22);
            this.lbl_principal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_principal.Name = "lbl_principal";
            this.lbl_principal.Size = new System.Drawing.Size(269, 51);
            this.lbl_principal.TabIndex = 6;
            this.lbl_principal.Text = "PROGRAMA";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(33, 99);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(201, 26);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Ingrese Un Número:";
            // 
            // lbl_listbox
            // 
            this.lbl_listbox.AutoSize = true;
            this.lbl_listbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_listbox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_listbox.ForeColor = System.Drawing.Color.White;
            this.lbl_listbox.Location = new System.Drawing.Point(33, 141);
            this.lbl_listbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_listbox.Name = "lbl_listbox";
            this.lbl_listbox.Size = new System.Drawing.Size(178, 26);
            this.lbl_listbox.TabIndex = 8;
            this.lbl_listbox.Text = "Los numeros son:";
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(246, 96);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(2);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(76, 34);
            this.txt_numero.TabIndex = 9;
            // 
            // comboBox_operaciones
            // 
            this.comboBox_operaciones.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_operaciones.FormattingEnabled = true;
            this.comboBox_operaciones.Location = new System.Drawing.Point(396, 96);
            this.comboBox_operaciones.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_operaciones.Name = "comboBox_operaciones";
            this.comboBox_operaciones.Size = new System.Drawing.Size(224, 34);
            this.comboBox_operaciones.TabIndex = 10;
            this.comboBox_operaciones.SelectedIndexChanged += new System.EventHandler(this.comboBox_operaciones_SelectedIndexChanged);
            // 
            // btn_genenar
            // 
            this.btn_genenar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genenar.Location = new System.Drawing.Point(641, 85);
            this.btn_genenar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_genenar.Name = "btn_genenar";
            this.btn_genenar.Size = new System.Drawing.Size(118, 45);
            this.btn_genenar.TabIndex = 11;
            this.btn_genenar.Text = "Generar";
            this.btn_genenar.UseVisualStyleBackColor = true;
            this.btn_genenar.Click += new System.EventHandler(this.btn_genenar_Click_1);
            // 
            // listBox_numeros
            // 
            this.listBox_numeros.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_numeros.FormattingEnabled = true;
            this.listBox_numeros.ItemHeight = 26;
            this.listBox_numeros.Location = new System.Drawing.Point(83, 183);
            this.listBox_numeros.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_numeros.Name = "listBox_numeros";
            this.listBox_numeros.Size = new System.Drawing.Size(449, 238);
            this.listBox_numeros.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_numeros);
            this.Controls.Add(this.btn_genenar);
            this.Controls.Add(this.comboBox_operaciones);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbl_listbox);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.lbl_principal);
            this.Name = "Form1";
            this.Text = "Opercion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_principal;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_listbox;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.ComboBox comboBox_operaciones;
        private System.Windows.Forms.Button btn_genenar;
        private System.Windows.Forms.ListBox listBox_numeros;
    }
}

