namespace BarcodeProcessor
{
    partial class Form1
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
            this.bEncode = new System.Windows.Forms.Button();
            this.bDecode = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.checkBoxControlSymbol = new System.Windows.Forms.CheckBox();
            this.bSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // bEncode
            // 
            this.bEncode.Location = new System.Drawing.Point(12, 42);
            this.bEncode.Name = "bEncode";
            this.bEncode.Size = new System.Drawing.Size(100, 23);
            this.bEncode.TabIndex = 0;
            this.bEncode.Text = "Encode";
            this.bEncode.UseVisualStyleBackColor = true;
            this.bEncode.Click += new System.EventHandler(this.bEncode_Click);
            // 
            // bDecode
            // 
            this.bDecode.Location = new System.Drawing.Point(713, 13);
            this.bDecode.Name = "bDecode";
            this.bDecode.Size = new System.Drawing.Size(75, 23);
            this.bDecode.TabIndex = 1;
            this.bDecode.Text = "Decode";
            this.bDecode.UseVisualStyleBackColor = true;
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(12, 13);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(100, 23);
            this.tbText.TabIndex = 3;
            this.tbText.Text = "MY CODE 39";
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBarcode.Location = new System.Drawing.Point(13, 72);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(600, 88);
            this.pictureBoxBarcode.TabIndex = 4;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // checkBoxControlSymbol
            // 
            this.checkBoxControlSymbol.AutoSize = true;
            this.checkBoxControlSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxControlSymbol.Location = new System.Drawing.Point(118, 15);
            this.checkBoxControlSymbol.Name = "checkBoxControlSymbol";
            this.checkBoxControlSymbol.Size = new System.Drawing.Size(150, 21);
            this.checkBoxControlSymbol.TabIndex = 5;
            this.checkBoxControlSymbol.Text = "With control symbol";
            this.checkBoxControlSymbol.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(619, 137);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(100, 23);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Save as PNG";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.checkBoxControlSymbol);
            this.Controls.Add(this.pictureBoxBarcode);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.bDecode);
            this.Controls.Add(this.bEncode);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEncode;
        private System.Windows.Forms.Button bDecode;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.CheckBox checkBoxControlSymbol;
        private System.Windows.Forms.Button bSave;
    }
}

