
namespace Calculadora
{
    partial class Calculadora
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
            this.label1 = new System.Windows.Forms.Label();
            this.numero1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numero2TextBox = new System.Windows.Forms.TextBox();
            this.somarButton = new System.Windows.Forms.Button();
            this.subtrairButton = new System.Windows.Forms.Button();
            this.multiplicarButton = new System.Windows.Forms.Button();
            this.dividirButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.respostaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numero1TextBox
            // 
            this.numero1TextBox.Location = new System.Drawing.Point(124, 18);
            this.numero1TextBox.Name = "numero1TextBox";
            this.numero1TextBox.Size = new System.Drawing.Size(100, 23);
            this.numero1TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número 2";
            // 
            // numero2TextBox
            // 
            this.numero2TextBox.Location = new System.Drawing.Point(124, 70);
            this.numero2TextBox.Name = "numero2TextBox";
            this.numero2TextBox.Size = new System.Drawing.Size(100, 23);
            this.numero2TextBox.TabIndex = 3;
            // 
            // somarButton
            // 
            this.somarButton.Location = new System.Drawing.Point(58, 122);
            this.somarButton.Name = "somarButton";
            this.somarButton.Size = new System.Drawing.Size(100, 23);
            this.somarButton.TabIndex = 4;
            this.somarButton.Text = "Somar";
            this.somarButton.UseVisualStyleBackColor = true;
            this.somarButton.Click += new System.EventHandler(this.somarButton_Click);
            // 
            // subtrairButton
            // 
            this.subtrairButton.Location = new System.Drawing.Point(164, 122);
            this.subtrairButton.Name = "subtrairButton";
            this.subtrairButton.Size = new System.Drawing.Size(100, 23);
            this.subtrairButton.TabIndex = 5;
            this.subtrairButton.Text = "Subtrair";
            this.subtrairButton.UseVisualStyleBackColor = true;
            this.subtrairButton.Click += new System.EventHandler(this.subtrairButton_Click);
            // 
            // multiplicarButton
            // 
            this.multiplicarButton.Location = new System.Drawing.Point(270, 122);
            this.multiplicarButton.Name = "multiplicarButton";
            this.multiplicarButton.Size = new System.Drawing.Size(100, 23);
            this.multiplicarButton.TabIndex = 6;
            this.multiplicarButton.Text = "Multiplicar";
            this.multiplicarButton.UseVisualStyleBackColor = true;
            this.multiplicarButton.Click += new System.EventHandler(this.multiplicarButton_Click);
            // 
            // dividirButton
            // 
            this.dividirButton.Location = new System.Drawing.Point(376, 122);
            this.dividirButton.Name = "dividirButton";
            this.dividirButton.Size = new System.Drawing.Size(100, 23);
            this.dividirButton.TabIndex = 7;
            this.dividirButton.Text = "Dividir";
            this.dividirButton.UseVisualStyleBackColor = true;
            this.dividirButton.Click += new System.EventHandler(this.dividirButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resposta:";
            // 
            // respostaLabel
            // 
            this.respostaLabel.AutoSize = true;
            this.respostaLabel.Location = new System.Drawing.Point(120, 179);
            this.respostaLabel.Name = "respostaLabel";
            this.respostaLabel.Size = new System.Drawing.Size(13, 15);
            this.respostaLabel.TabIndex = 9;
            this.respostaLabel.Text = "0";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 219);
            this.Controls.Add(this.respostaLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dividirButton);
            this.Controls.Add(this.multiplicarButton);
            this.Controls.Add(this.subtrairButton);
            this.Controls.Add(this.somarButton);
            this.Controls.Add(this.numero2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numero1TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numero2TextBox;
        private System.Windows.Forms.Button somarButton;
        private System.Windows.Forms.Button subtrairButton;
        private System.Windows.Forms.Button multiplicarButton;
        private System.Windows.Forms.Button dividirButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label respostaLabel;
    }
}

