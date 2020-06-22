namespace GestaoFinanceira
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroLabel();
            this.txtHora = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnCadastro = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(651, 99);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(87, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "USUARIO:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txtUsuario.Location = new System.Drawing.Point(735, 99);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(0, 0);
            this.txtUsuario.TabIndex = 8;
            // 
            // txtHora
            // 
            this.txtHora.AutoSize = true;
            this.txtHora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.txtHora.Location = new System.Drawing.Point(531, 512);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(106, 25);
            this.txtHora.TabIndex = 9;
            this.txtHora.Text = "metroLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroButton7
            // 
            this.metroButton7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroButton7.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_arquivo_751;
            this.metroButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton7.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton7.Location = new System.Drawing.Point(241, 296);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(207, 103);
            this.metroButton7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton7.TabIndex = 10;
            this.metroButton7.Text = "IMPRESSÃO";
            this.metroButton7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton7.UseSelectable = true;
            this.metroButton7.Click += new System.EventHandler(this.metroButton7_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroButton6.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_calculadora_751;
            this.metroButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton6.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton6.Location = new System.Drawing.Point(11, 405);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(224, 103);
            this.metroButton6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton6.TabIndex = 6;
            this.metroButton6.Text = "CALCULADORA";
            this.metroButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroButton5.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_ms_word_75;
            this.metroButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton5.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton5.Location = new System.Drawing.Point(126, 296);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(109, 103);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton5.TabIndex = 5;
            this.metroButton5.Text = "WORD";
            this.metroButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroButton4.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_ms_excel_751;
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton4.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton4.Location = new System.Drawing.Point(11, 296);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(109, 103);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton4.TabIndex = 4;
            this.metroButton4.Text = "EXCEL";
            this.metroButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroButton3.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_desligar_100;
            this.metroButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton3.Location = new System.Drawing.Point(765, 410);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(122, 127);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "SAIR";
            this.metroButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroButton2.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_pilha_de_dinheiro_75;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton2.Location = new System.Drawing.Point(11, 187);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(224, 103);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "CALCULADORA FINANCEIRA";
            this.metroButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroButton1.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_copiar_75__1_;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButton1.Location = new System.Drawing.Point(126, 78);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(109, 103);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "RELATORIO";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCadastro.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_pessoa_do_sexo_masculino_75;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastro.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastro.Location = new System.Drawing.Point(11, 78);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(109, 103);
            this.btnCadastro.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "CADASTRO";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCadastro.UseSelectable = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.metroButton7);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnCadastro);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Resizable = false;
            this.Text = "Software Gestão Financeira";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCadastro;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel txtUsuario;
        private MetroFramework.Controls.MetroLabel txtHora;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroButton metroButton7;
    }
}

