namespace SannaFer.CAI.Ej001
{
    partial class DatosForm
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
            DocLabel = new Label();
            DocText = new TextBox();
            NombreText = new TextBox();
            NombreLabel = new Label();
            ApellidoText = new TextBox();
            ApellidoLabel = new Label();
            FechaText = new TextBox();
            DateLabel = new Label();
            AceptBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // DocLabel
            // 
            DocLabel.AutoSize = true;
            DocLabel.Location = new Point(60, 39);
            DocLabel.Name = "DocLabel";
            DocLabel.Size = new Size(87, 20);
            DocLabel.TabIndex = 0;
            DocLabel.Text = "Documento";
            // 
            // DocText
            // 
            DocText.Location = new Point(60, 62);
            DocText.Name = "DocText";
            DocText.Size = new Size(197, 27);
            DocText.TabIndex = 1;
            // 
            // NombreText
            // 
            NombreText.Location = new Point(60, 126);
            NombreText.Name = "NombreText";
            NombreText.Size = new Size(197, 27);
            NombreText.TabIndex = 3;
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(60, 103);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(64, 20);
            NombreLabel.TabIndex = 2;
            NombreLabel.Text = "Nombre";
            // 
            // ApellidoText
            // 
            ApellidoText.Location = new Point(60, 191);
            ApellidoText.Name = "ApellidoText";
            ApellidoText.Size = new Size(197, 27);
            ApellidoText.TabIndex = 5;
            // 
            // ApellidoLabel
            // 
            ApellidoLabel.AutoSize = true;
            ApellidoLabel.Location = new Point(60, 168);
            ApellidoLabel.Name = "ApellidoLabel";
            ApellidoLabel.Size = new Size(66, 20);
            ApellidoLabel.TabIndex = 4;
            ApellidoLabel.Text = "Apellido";
            // 
            // FechaText
            // 
            FechaText.Location = new Point(60, 255);
            FechaText.Name = "FechaText";
            FechaText.Size = new Size(197, 27);
            FechaText.TabIndex = 7;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(60, 232);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(149, 20);
            DateLabel.TabIndex = 6;
            DateLabel.Text = "Fecha de Nacimiento";
            // 
            // AceptBtn
            // 
            AceptBtn.Location = new Point(60, 332);
            AceptBtn.Name = "AceptBtn";
            AceptBtn.Size = new Size(94, 29);
            AceptBtn.TabIndex = 8;
            AceptBtn.Text = "Aceptar";
            AceptBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(163, 332);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(94, 29);
            CancelBtn.TabIndex = 9;
            CancelBtn.Text = "Cancelar";
            CancelBtn.UseVisualStyleBackColor = true;
            // 
            // DatosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 450);
            Controls.Add(CancelBtn);
            Controls.Add(AceptBtn);
            Controls.Add(FechaText);
            Controls.Add(DateLabel);
            Controls.Add(ApellidoText);
            Controls.Add(ApellidoLabel);
            Controls.Add(NombreText);
            Controls.Add(NombreLabel);
            Controls.Add(DocText);
            Controls.Add(DocLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "DatosForm";
            Text = "Datos Personales";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DocLabel;
        private TextBox DocText;
        private TextBox NombreText;
        private Label NombreLabel;
        private TextBox ApellidoText;
        private Label ApellidoLabel;
        private TextBox FechaText;
        private Label DateLabel;
        private Button AceptBtn;
        private Button CancelBtn;
    }
}