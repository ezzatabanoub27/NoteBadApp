namespace NotApplication2.Data
{
    partial class DisplayAllNotas
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
            this.dataGridAllNota = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllNota)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAllNota
            // 
            this.dataGridAllNota.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridAllNota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllNota.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridAllNota.Location = new System.Drawing.Point(1, 1);
            this.dataGridAllNota.Name = "dataGridAllNota";
            this.dataGridAllNota.RowHeadersWidth = 51;
            this.dataGridAllNota.RowTemplate.Height = 24;
            this.dataGridAllNota.Size = new System.Drawing.Size(1011, 437);
            this.dataGridAllNota.TabIndex = 0;
            // 
            // DisplayAllNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.dataGridAllNota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DisplayAllNotas";
            this.Text = "DisplayAllNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAllNota;
    }
}