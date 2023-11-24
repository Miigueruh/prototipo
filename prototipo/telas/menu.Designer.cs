namespace prototipo
{
    partial class menu
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
            this.bt_funcionario = new System.Windows.Forms.Button();
            this.bt_empresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_funcionario
            // 
            this.bt_funcionario.Location = new System.Drawing.Point(335, 172);
            this.bt_funcionario.Name = "bt_funcionario";
            this.bt_funcionario.Size = new System.Drawing.Size(75, 23);
            this.bt_funcionario.TabIndex = 0;
            this.bt_funcionario.Text = "Funcionários";
            this.bt_funcionario.UseVisualStyleBackColor = true;
            // 
            // bt_empresa
            // 
            this.bt_empresa.Location = new System.Drawing.Point(335, 287);
            this.bt_empresa.Name = "bt_empresa";
            this.bt_empresa.Size = new System.Drawing.Size(75, 23);
            this.bt_empresa.TabIndex = 1;
            this.bt_empresa.Text = "Empresas";
            this.bt_empresa.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_empresa);
            this.Controls.Add(this.bt_funcionario);
            this.Name = "menu";
            this.Text = "menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_funcionario;
        private System.Windows.Forms.Button bt_empresa;
    }
}