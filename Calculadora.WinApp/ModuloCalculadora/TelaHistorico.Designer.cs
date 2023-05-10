namespace Calculadora.WinApp.ModuloCalculadora
{
    partial class TelaHistorico
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
            btnSairTelaHistorico = new Button();
            hisotricoListBox = new ListBox();
            SuspendLayout();
            // 
            // btnSairTelaHistorico
            // 
            btnSairTelaHistorico.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSairTelaHistorico.BackColor = SystemColors.InactiveCaption;
            btnSairTelaHistorico.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnSairTelaHistorico.FlatStyle = FlatStyle.System;
            btnSairTelaHistorico.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSairTelaHistorico.ForeColor = SystemColors.ActiveCaptionText;
            btnSairTelaHistorico.Location = new Point(26, 378);
            btnSairTelaHistorico.Name = "btnSairTelaHistorico";
            btnSairTelaHistorico.Size = new Size(83, 32);
            btnSairTelaHistorico.TabIndex = 0;
            btnSairTelaHistorico.Text = "SAIR";
            btnSairTelaHistorico.UseVisualStyleBackColor = false;
            btnSairTelaHistorico.Click += btnSairTelaHistorico_Click;
            // 
            // hisotricoListBox
            // 
            hisotricoListBox.BackColor = SystemColors.ScrollBar;
            hisotricoListBox.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            hisotricoListBox.FormattingEnabled = true;
            hisotricoListBox.ItemHeight = 18;
            hisotricoListBox.Location = new Point(26, 10);
            hisotricoListBox.Name = "hisotricoListBox";
            hisotricoListBox.Size = new Size(390, 328);
            hisotricoListBox.TabIndex = 2;
            hisotricoListBox.SelectedIndexChanged += hisotricoListBox_SelectedIndexChanged;
            // 
            // TelaHistorico
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(449, 422);
            Controls.Add(hisotricoListBox);
            Controls.Add(btnSairTelaHistorico);
            Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TelaHistorico";
            Text = "Historico";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSairTelaHistorico;
        public ListBox hisotricoListBox;
    }
}