namespace NotApplication2.Screens
{
    partial class AddNewNote
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotaName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ContentText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryComBoks = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.numericIDNota = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.userIDnum = new System.Windows.Forms.NumericUpDown();
            this.AddNota = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIDnum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(305, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Nota";
            // 
            // txtNotaName
            // 
            this.txtNotaName.Location = new System.Drawing.Point(246, 154);
            this.txtNotaName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotaName.Name = "txtNotaName";
            this.txtNotaName.Size = new System.Drawing.Size(344, 27);
            this.txtNotaName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nota Content";
            // 
            // ContentText
            // 
            this.ContentText.Location = new System.Drawing.Point(246, 212);
            this.ContentText.Name = "ContentText";
            this.ContentText.Size = new System.Drawing.Size(344, 37);
            this.ContentText.TabIndex = 3;
            this.ContentText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Note Category";
            // 
            // categoryComBoks
            // 
            this.categoryComBoks.FormattingEnabled = true;
            this.categoryComBoks.Location = new System.Drawing.Point(246, 282);
            this.categoryComBoks.Name = "categoryComBoks";
            this.categoryComBoks.Size = new System.Drawing.Size(344, 28);
            this.categoryComBoks.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nota Reminder";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(246, 351);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(344, 27);
            this.dateTime.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nota ID";
            // 
            // numericIDNota
            // 
            this.numericIDNota.Location = new System.Drawing.Point(246, 95);
            this.numericIDNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericIDNota.Name = "numericIDNota";
            this.numericIDNota.Size = new System.Drawing.Size(344, 27);
            this.numericIDNota.TabIndex = 9;
            this.numericIDNota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "User ID";
            // 
            // userIDnum
            // 
            this.userIDnum.Location = new System.Drawing.Point(246, 410);
            this.userIDnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userIDnum.Name = "userIDnum";
            this.userIDnum.Size = new System.Drawing.Size(344, 27);
            this.userIDnum.TabIndex = 9;
            this.userIDnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddNota
            // 
            this.AddNota.BackColor = System.Drawing.Color.AliceBlue;
            this.AddNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNota.Location = new System.Drawing.Point(263, 476);
            this.AddNota.Name = "AddNota";
            this.AddNota.Size = new System.Drawing.Size(125, 49);
            this.AddNota.TabIndex = 10;
            this.AddNota.Text = "AddNota";
            this.AddNota.UseVisualStyleBackColor = false;
            this.AddNota.Click += new System.EventHandler(this.AddNota_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(493, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "ShowAll";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ShowAllNota);
            // 
            // AddNewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(774, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddNota);
            this.Controls.Add(this.userIDnum);
            this.Controls.Add(this.numericIDNota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryComBoks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContentText);
            this.Controls.Add(this.txtNotaName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewNote";
            this.Text = "AddNewNote";
            ((System.ComponentModel.ISupportInitialize)(this.numericIDNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIDnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotaName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ContentText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryComBoks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericIDNota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown userIDnum;
        private System.Windows.Forms.Button AddNota;
        private System.Windows.Forms.Button button1;
    }
}