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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEncoding = new System.Windows.Forms.TabPage();
            this.tabDecoding = new System.Windows.Forms.TabPage();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelDecoded = new System.Windows.Forms.Label();
            this.checkBoxCS = new System.Windows.Forms.CheckBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBoxDecoding = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabEncoding.SuspendLayout();
            this.tabDecoding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecoding)).BeginInit();
            this.SuspendLayout();
            // 
            // bEncode
            // 
            this.bEncode.Location = new System.Drawing.Point(6, 35);
            this.bEncode.Name = "bEncode";
            this.bEncode.Size = new System.Drawing.Size(100, 23);
            this.bEncode.TabIndex = 0;
            this.bEncode.Text = "Encode";
            this.bEncode.UseVisualStyleBackColor = true;
            this.bEncode.Click += new System.EventHandler(this.bEncode_Click);
            // 
            // bDecode
            // 
            this.bDecode.Location = new System.Drawing.Point(6, 6);
            this.bDecode.Name = "bDecode";
            this.bDecode.Size = new System.Drawing.Size(144, 23);
            this.bDecode.TabIndex = 1;
            this.bDecode.Text = "Decode from file";
            this.bDecode.UseVisualStyleBackColor = true;
            this.bDecode.Click += new System.EventHandler(this.bDecode_Click);
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(6, 6);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(100, 23);
            this.tbText.TabIndex = 3;
            this.tbText.Text = "MY CODE 39";
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBarcode.Location = new System.Drawing.Point(7, 65);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(600, 88);
            this.pictureBoxBarcode.TabIndex = 4;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // checkBoxControlSymbol
            // 
            this.checkBoxControlSymbol.AutoSize = true;
            this.checkBoxControlSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxControlSymbol.Location = new System.Drawing.Point(112, 8);
            this.checkBoxControlSymbol.Name = "checkBoxControlSymbol";
            this.checkBoxControlSymbol.Size = new System.Drawing.Size(150, 21);
            this.checkBoxControlSymbol.TabIndex = 5;
            this.checkBoxControlSymbol.Text = "With control symbol";
            this.checkBoxControlSymbol.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(613, 130);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(100, 23);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Save as PNG";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEncoding);
            this.tabControl1.Controls.Add(this.tabDecoding);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 200);
            this.tabControl1.TabIndex = 7;
            // 
            // tabEncoding
            // 
            this.tabEncoding.Controls.Add(this.labelInfo);
            this.tabEncoding.Controls.Add(this.tbText);
            this.tabEncoding.Controls.Add(this.bSave);
            this.tabEncoding.Controls.Add(this.bEncode);
            this.tabEncoding.Controls.Add(this.checkBoxControlSymbol);
            this.tabEncoding.Controls.Add(this.pictureBoxBarcode);
            this.tabEncoding.Location = new System.Drawing.Point(4, 22);
            this.tabEncoding.Name = "tabEncoding";
            this.tabEncoding.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncoding.Size = new System.Drawing.Size(741, 174);
            this.tabEncoding.TabIndex = 0;
            this.tabEncoding.Text = "Encoding";
            this.tabEncoding.UseVisualStyleBackColor = true;
            // 
            // tabDecoding
            // 
            this.tabDecoding.Controls.Add(this.pictureBoxDecoding);
            this.tabDecoding.Controls.Add(this.labelResult);
            this.tabDecoding.Controls.Add(this.checkBoxCS);
            this.tabDecoding.Controls.Add(this.labelDecoded);
            this.tabDecoding.Controls.Add(this.bDecode);
            this.tabDecoding.Location = new System.Drawing.Point(4, 22);
            this.tabDecoding.Name = "tabDecoding";
            this.tabDecoding.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecoding.Size = new System.Drawing.Size(741, 174);
            this.tabDecoding.TabIndex = 1;
            this.tabDecoding.Text = "Decoding";
            this.tabDecoding.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(618, 111);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 7;
            // 
            // labelDecoded
            // 
            this.labelDecoded.AutoSize = true;
            this.labelDecoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDecoded.Location = new System.Drawing.Point(312, 11);
            this.labelDecoded.Name = "labelDecoded";
            this.labelDecoded.Size = new System.Drawing.Size(0, 17);
            this.labelDecoded.TabIndex = 8;
            // 
            // checkBoxCS
            // 
            this.checkBoxCS.AutoSize = true;
            this.checkBoxCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCS.Location = new System.Drawing.Point(156, 8);
            this.checkBoxCS.Name = "checkBoxCS";
            this.checkBoxCS.Size = new System.Drawing.Size(150, 21);
            this.checkBoxCS.TabIndex = 9;
            this.checkBoxCS.Text = "With control symbol";
            this.checkBoxCS.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(9, 36);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 24);
            this.labelResult.TabIndex = 10;
            // 
            // pictureBoxDecoding
            // 
            this.pictureBoxDecoding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDecoding.Location = new System.Drawing.Point(8, 63);
            this.pictureBoxDecoding.Name = "pictureBoxDecoding";
            this.pictureBoxDecoding.Size = new System.Drawing.Size(600, 88);
            this.pictureBoxDecoding.TabIndex = 11;
            this.pictureBoxDecoding.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 200);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "BarcodeProcessor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabEncoding.ResumeLayout(false);
            this.tabEncoding.PerformLayout();
            this.tabDecoding.ResumeLayout(false);
            this.tabDecoding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecoding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bEncode;
        private System.Windows.Forms.Button bDecode;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.CheckBox checkBoxControlSymbol;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEncoding;
        private System.Windows.Forms.TabPage tabDecoding;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelDecoded;
        private System.Windows.Forms.CheckBox checkBoxCS;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBoxDecoding;
    }
}

