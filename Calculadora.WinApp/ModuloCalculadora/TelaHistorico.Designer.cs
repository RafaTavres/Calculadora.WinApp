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
            btnSairTelaHistorico.BackColor = SystemColors.Info;
            btnSairTelaHistorico.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            btnSairTelaHistorico.FlatStyle = FlatStyle.System;
            btnSairTelaHistorico.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSairTelaHistorico.ForeColor = SystemColors.ActiveCaptionText;
            btnSairTelaHistorico.Location = new Point(26, 328);
            btnSairTelaHistorico.Name = "btnSairTelaHistorico";
            btnSairTelaHistorico.Size = new Size(83, 32);
            btnSairTelaHistorico.TabIndex = 0;
            btnSairTelaHistorico.Text = "SAIR";
            btnSairTelaHistorico.UseVisualStyleBackColor = false;
            btnSairTelaHistorico.Click += btnSairTelaHistorico_Click;
            // 
            // hisotricoListBox
            // 
            hisotricoListBox.BackColor = SystemColors.Info;
            hisotricoListBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            hisotricoListBox.FormattingEnabled = true;
            hisotricoListBox.ItemHeight = 22;
            hisotricoListBox.Location = new Point(26, 10);
            hisotricoListBox.Name = "hisotricoListBox";
            hisotricoListBox.Size = new Size(289, 312);
            hisotricoListBox.TabIndex = 2;
            hisotricoListBox.SelectedIndexChanged += hisotricoListBox_SelectedIndexChanged;
            // 
            // TelaHistorico
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(339, 385);
            Controls.Add(hisotricoListBox);
            Controls.Add(btnSairTelaHistorico);
            Font = new Font("Stencil", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
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