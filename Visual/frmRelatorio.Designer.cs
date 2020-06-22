namespace GestaoFinanceira.Visual
{
    partial class frmRelatorio
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
            this.btnRelatorioUsuario = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnRelatorioUsuario
            // 
            this.btnRelatorioUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnRelatorioUsuario.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_arquivo_75;
            this.btnRelatorioUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRelatorioUsuario.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRelatorioUsuario.Location = new System.Drawing.Point(23, 83);
            this.btnRelatorioUsuario.Name = "btnRelatorioUsuario";
            this.btnRelatorioUsuario.Size = new System.Drawing.Size(125, 125);
            this.btnRelatorioUsuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnRelatorioUsuario.TabIndex = 2;
            this.btnRelatorioUsuario.Text = "USUARIO";
            this.btnRelatorioUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorioUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRelatorioUsuario.UseSelectable = true;
            this.btnRelatorioUsuario.Click += new System.EventHandler(this.btnRelatorioUsuario_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Silver;
            this.metroButton1.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_arquivo_75;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(168, 83);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(151, 125);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "FORMA PAGAMENTO";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Silver;
            this.metroButton2.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_arquivo_75;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(23, 214);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(296, 125);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "CLIENTE";
            this.metroButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroButton3.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_desligar_100;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton3.Location = new System.Drawing.Point(705, 350);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(122, 127);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "SAIR";
            this.metroButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnRelatorioUsuario);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRelatorio";
            this.Resizable = false;
            this.Text = "Relatorios";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRelatorioUsuario;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}