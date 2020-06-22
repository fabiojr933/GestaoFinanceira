namespace GestaoFinanceira.Visual
{
    partial class frmCadastro
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
            this.btnCliente = new MetroFramework.Controls.MetroButton();
            this.btnFormaPag = new MetroFramework.Controls.MetroButton();
            this.btnCadastroUsuario = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCliente.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_check_male3;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCliente.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCliente.Location = new System.Drawing.Point(151, 81);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(109, 112);
            this.btnCliente.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCliente.UseSelectable = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFormaPag
            // 
            this.btnFormaPag.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnFormaPag.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_pilha_de_dinheiro_751;
            this.btnFormaPag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFormaPag.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnFormaPag.Location = new System.Drawing.Point(23, 199);
            this.btnFormaPag.Name = "btnFormaPag";
            this.btnFormaPag.Size = new System.Drawing.Size(237, 112);
            this.btnFormaPag.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnFormaPag.TabIndex = 2;
            this.btnFormaPag.Text = "FORMA PAGAMENTO";
            this.btnFormaPag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFormaPag.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnFormaPag.UseSelectable = true;
            this.btnFormaPag.Click += new System.EventHandler(this.btnFormaPag_Click);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCadastroUsuario.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_adicionar_usuário_masculino_64;
            this.btnCadastroUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastroUsuario.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCadastroUsuario.Location = new System.Drawing.Point(23, 81);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(109, 112);
            this.btnCadastroUsuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCadastroUsuario.TabIndex = 1;
            this.btnCadastroUsuario.Text = "USUARIO";
            this.btnCadastroUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastroUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastroUsuario.UseSelectable = true;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.btnCadastroUsuario_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroButton3.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_desligar_100;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton3.Location = new System.Drawing.Point(722, 366);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(122, 127);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.TabIndex = 4;
            this.metroButton3.Text = "SAIR";
            this.metroButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnFormaPag);
            this.Controls.Add(this.btnCadastroUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastro";
            this.Resizable = false;
            this.Text = "Cadastros";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCadastroUsuario;
        private MetroFramework.Controls.MetroButton btnFormaPag;
        private MetroFramework.Controls.MetroButton btnCliente;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}