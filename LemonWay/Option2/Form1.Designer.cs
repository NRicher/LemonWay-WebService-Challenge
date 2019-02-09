namespace Option2
{
    partial class Form_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.FibonacciButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // FibonacciButton
            // 
            this.FibonacciButton.Location = new System.Drawing.Point(72, 61);
            this.FibonacciButton.Name = "FibonacciButton";
            this.FibonacciButton.Size = new System.Drawing.Size(143, 23);
            this.FibonacciButton.TabIndex = 0;
            this.FibonacciButton.Text = "Compute Fibonancci(10)";
            this.FibonacciButton.UseVisualStyleBackColor = true;
            this.FibonacciButton.Click += new System.EventHandler(this.FibonacciButton_Clicked);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FibonacciButton);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FibonacciButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

