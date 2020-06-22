namespace GestaoFinanceira.Visual
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.btnCalcular = new MetroFramework.Controls.MetroButton();
            this.txtValorPagar = new MetroFramework.Controls.MetroTextBox();
            this.txtDiasAtraso = new MetroFramework.Controls.MetroTextBox();
            this.txtTaxaJuro = new MetroFramework.Controls.MetroTextBox();
            this.btnLimpar = new MetroFramework.Controls.MetroButton();
            this.txtValorParcela = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(24, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Valor Parcela";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(24, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Taxa Juros (A.M)";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(24, 160);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Dias Atrasos";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(24, 201);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel4.TabIndex = 13;
            this.metroLabel4.Text = "Valor a Pagar";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVoltar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_duplo_para_a_esquerda_321;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVoltar.Location = new System.Drawing.Point(238, 278);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(100, 36);
            this.btnVoltar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "   Voltar";
            this.btnVoltar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalcular.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_selecionado_32;
            this.btnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCalcular.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCalcular.Location = new System.Drawing.Point(23, 278);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 36);
            this.btnCalcular.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "     Calcular";
            this.btnCalcular.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnCalcular.UseSelectable = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtValorPagar.CustomButton.Image = null;
            this.txtValorPagar.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtValorPagar.CustomButton.Name = "";
            this.txtValorPagar.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtValorPagar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorPagar.CustomButton.TabIndex = 1;
            this.txtValorPagar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorPagar.CustomButton.UseSelectable = true;
            this.txtValorPagar.CustomButton.Visible = false;
            this.txtValorPagar.DisplayIcon = true;
            this.txtValorPagar.Enabled = false;
            this.txtValorPagar.Icon = ((System.Drawing.Image)(resources.GetObject("txtValorPagar.Icon")));
            this.txtValorPagar.Lines = new string[0];
            this.txtValorPagar.Location = new System.Drawing.Point(139, 195);
            this.txtValorPagar.MaxLength = 32767;
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.PasswordChar = '\0';
            this.txtValorPagar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorPagar.SelectedText = "";
            this.txtValorPagar.SelectionLength = 0;
            this.txtValorPagar.SelectionStart = 0;
            this.txtValorPagar.ShortcutsEnabled = true;
            this.txtValorPagar.Size = new System.Drawing.Size(175, 25);
            this.txtValorPagar.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorPagar.TabIndex = 4;
            this.txtValorPagar.UseSelectable = true;
            this.txtValorPagar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorPagar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPagar_KeyPress);
            this.txtValorPagar.Leave += new System.EventHandler(this.txtValorPagar_Leave);
            // 
            // txtDiasAtraso
            // 
            this.txtDiasAtraso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtDiasAtraso.CustomButton.Image = null;
            this.txtDiasAtraso.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtDiasAtraso.CustomButton.Name = "";
            this.txtDiasAtraso.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtDiasAtraso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiasAtraso.CustomButton.TabIndex = 1;
            this.txtDiasAtraso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiasAtraso.CustomButton.UseSelectable = true;
            this.txtDiasAtraso.CustomButton.Visible = false;
            this.txtDiasAtraso.DisplayIcon = true;
            this.txtDiasAtraso.Icon = ((System.Drawing.Image)(resources.GetObject("txtDiasAtraso.Icon")));
            this.txtDiasAtraso.Lines = new string[0];
            this.txtDiasAtraso.Location = new System.Drawing.Point(139, 154);
            this.txtDiasAtraso.MaxLength = 32767;
            this.txtDiasAtraso.Name = "txtDiasAtraso";
            this.txtDiasAtraso.PasswordChar = '\0';
            this.txtDiasAtraso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiasAtraso.SelectedText = "";
            this.txtDiasAtraso.SelectionLength = 0;
            this.txtDiasAtraso.SelectionStart = 0;
            this.txtDiasAtraso.ShortcutsEnabled = true;
            this.txtDiasAtraso.Size = new System.Drawing.Size(175, 25);
            this.txtDiasAtraso.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiasAtraso.TabIndex = 3;
            this.txtDiasAtraso.UseSelectable = true;
            this.txtDiasAtraso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiasAtraso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTaxaJuro
            // 
            this.txtTaxaJuro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtTaxaJuro.CustomButton.Image = null;
            this.txtTaxaJuro.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtTaxaJuro.CustomButton.Name = "";
            this.txtTaxaJuro.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTaxaJuro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTaxaJuro.CustomButton.TabIndex = 1;
            this.txtTaxaJuro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTaxaJuro.CustomButton.UseSelectable = true;
            this.txtTaxaJuro.CustomButton.Visible = false;
            this.txtTaxaJuro.DisplayIcon = true;
            this.txtTaxaJuro.Icon = global::GestaoFinanceira.Properties.Resources.icons8_real_16;
            this.txtTaxaJuro.Lines = new string[0];
            this.txtTaxaJuro.Location = new System.Drawing.Point(139, 111);
            this.txtTaxaJuro.MaxLength = 32767;
            this.txtTaxaJuro.Name = "txtTaxaJuro";
            this.txtTaxaJuro.PasswordChar = '\0';
            this.txtTaxaJuro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTaxaJuro.SelectedText = "";
            this.txtTaxaJuro.SelectionLength = 0;
            this.txtTaxaJuro.SelectionStart = 0;
            this.txtTaxaJuro.ShortcutsEnabled = true;
            this.txtTaxaJuro.Size = new System.Drawing.Size(175, 25);
            this.txtTaxaJuro.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTaxaJuro.TabIndex = 2;
            this.txtTaxaJuro.UseSelectable = true;
            this.txtTaxaJuro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTaxaJuro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpar.BackgroundImage = global::GestaoFinanceira.Properties.Resources.icons8_voltar_32;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnLimpar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLimpar.Location = new System.Drawing.Point(131, 278);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 36);
            this.btnLimpar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "   Limpar";
            this.btnLimpar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLimpar.UseSelectable = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtValorParcela.CustomButton.Image = null;
            this.txtValorParcela.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtValorParcela.CustomButton.Name = "";
            this.txtValorParcela.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtValorParcela.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorParcela.CustomButton.TabIndex = 1;
            this.txtValorParcela.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorParcela.CustomButton.UseSelectable = true;
            this.txtValorParcela.CustomButton.Visible = false;
            this.txtValorParcela.DisplayIcon = true;
            this.txtValorParcela.Icon = global::GestaoFinanceira.Properties.Resources.icons8_real_16;
            this.txtValorParcela.Lines = new string[0];
            this.txtValorParcela.Location = new System.Drawing.Point(139, 68);
            this.txtValorParcela.MaxLength = 32767;
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.PasswordChar = '\0';
            this.txtValorParcela.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorParcela.SelectedText = "";
            this.txtValorParcela.SelectionLength = 0;
            this.txtValorParcela.SelectionStart = 0;
            this.txtValorParcela.ShortcutsEnabled = true;
            this.txtValorParcela.Size = new System.Drawing.Size(175, 25);
            this.txtValorParcela.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorParcela.TabIndex = 1;
            this.txtValorParcela.UseSelectable = true;
            this.txtValorParcela.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorParcela.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorParcela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorParcela_KeyPress);
            this.txtValorParcela.Leave += new System.EventHandler(this.txtValorParcela_Leave_1);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 337);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtDiasAtraso);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtTaxaJuro);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtValorParcela);
            this.Controls.Add(this.metroLabel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalculadora";
            this.Resizable = false;
            this.Text = "Calculadora de Juros";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLimpar;
        private MetroFramework.Controls.MetroTextBox txtValorParcela;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTaxaJuro;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtDiasAtraso;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtValorPagar;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnCalcular;
        private MetroFramework.Controls.MetroButton btnVoltar;
    }
}