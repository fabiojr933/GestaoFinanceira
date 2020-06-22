namespace GestaoFinanceira.Visual
{
    partial class frmFormaPag
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnNovo = new MetroFramework.Controls.MetroButton();
            this.btnPesquisar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnEditar = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnGravar = new MetroFramework.Controls.MetroButton();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.txtFormaPag = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(137, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(198, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Descrição Forma de Pagamento";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Código";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnNovo.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_selecionado_32;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnNovo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNovo.Location = new System.Drawing.Point(10, 391);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 36);
            this.btnNovo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "   Novo";
            this.btnNovo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnNovo.UseSelectable = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPesquisar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_pesquisar_32;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnPesquisar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPesquisar.Location = new System.Drawing.Point(116, 391);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 36);
            this.btnPesquisar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "      Pesquisar";
            this.btnPesquisar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPesquisar.UseSelectable = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCancelar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons81_excluir_32;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCancelar.Location = new System.Drawing.Point(222, 391);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 36);
            this.btnCancelar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "    Cancelar";
            this.btnCancelar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEditar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_editar_321;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEditar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnEditar.Location = new System.Drawing.Point(328, 391);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 36);
            this.btnEditar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "    Editar";
            this.btnEditar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnEditar.UseSelectable = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExcluir.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_excluir_32;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnExcluir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExcluir.Location = new System.Drawing.Point(434, 391);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 36);
            this.btnExcluir.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "    Excluir";
            this.btnExcluir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGravar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_salvar_321;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGravar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGravar.Location = new System.Drawing.Point(540, 391);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 36);
            this.btnGravar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGravar.TabIndex = 22;
            this.btnGravar.Text = "    Gravar";
            this.btnGravar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGravar.UseSelectable = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVoltar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_duplo_para_a_esquerda_32;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVoltar.Location = new System.Drawing.Point(646, 391);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 36);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "    Voltar";
            this.btnVoltar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnVoltar.UseSelectable = true;
            // 
            // txtFormaPag
            // 
            this.txtFormaPag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtFormaPag.CustomButton.Image = null;
            this.txtFormaPag.CustomButton.Location = new System.Drawing.Point(341, 1);
            this.txtFormaPag.CustomButton.Name = "";
            this.txtFormaPag.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtFormaPag.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFormaPag.CustomButton.TabIndex = 1;
            this.txtFormaPag.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFormaPag.CustomButton.UseSelectable = true;
            this.txtFormaPag.CustomButton.Visible = false;
            this.txtFormaPag.DisplayIcon = true;
            this.txtFormaPag.Icon = global::GestaoFinanceira.Properties.Resources.icons8_estrutura_em_árvore_16;
            this.txtFormaPag.Lines = new string[0];
            this.txtFormaPag.Location = new System.Drawing.Point(137, 79);
            this.txtFormaPag.MaxLength = 32767;
            this.txtFormaPag.Name = "txtFormaPag";
            this.txtFormaPag.PasswordChar = '\0';
            this.txtFormaPag.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFormaPag.SelectedText = "";
            this.txtFormaPag.SelectionLength = 0;
            this.txtFormaPag.SelectionStart = 0;
            this.txtFormaPag.ShortcutsEnabled = true;
            this.txtFormaPag.Size = new System.Drawing.Size(365, 25);
            this.txtFormaPag.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFormaPag.TabIndex = 13;
            this.txtFormaPag.UseSelectable = true;
            this.txtFormaPag.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFormaPag.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DisplayIcon = true;
            this.txtId.Enabled = false;
            this.txtId.Icon = global::GestaoFinanceira.Properties.Resources.icons8_cardápio_16;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(41, 79);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(80, 25);
            this.txtId.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.TabIndex = 12;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmFormaPag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtFormaPag);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormaPag";
            this.Resizable = false;
            this.Text = "Cadastro Forma de Pagamento";
            this.Load += new System.EventHandler(this.frmFormaPag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnNovo;
        private MetroFramework.Controls.MetroButton btnPesquisar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnEditar;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnGravar;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroTextBox txtFormaPag;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}