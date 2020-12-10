using BarcodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Barcode b = new Barcode();
        bool encoded = false;

        private void bEncode_Click(object sender, EventArgs e)
        {
            encoded = false;

            tbText.Text = tbText.Text.Trim().ToUpper();
            string textToCode = tbText.Text.Trim();
            TYPE type = checkBoxControlSymbol.Checked ? TYPE.CODE39_Mod43 : TYPE.CODE39;

            try
            {
                b.Alignment = AlignmentPositions.CENTER;
                b.AspectRatio = 6.66667;
                b.IncludeLabel = true;
                b.RotateFlipType = RotateFlipType.RotateNoneFlipNone;
                b.AlternateLabel = textToCode;
                b.LabelPosition = LabelPositions.BOTTOMCENTER;

                Image barcode = b.Encode(type, textToCode);
                Image resized = new Bitmap(barcode, new Size(barcode.Width*2, barcode.Height*2));
                pictureBoxBarcode.Size = resized.Size;
                pictureBoxBarcode.Image = resized;
                encoded = true;

                Console.WriteLine(b.EncodedValue);
                Console.WriteLine("Encoding Type: " + b.EncodedType.ToString());
                if (b.BarWidth.HasValue)
                    Console.WriteLine(b.Width.ToString());
                if (b.AspectRatio.HasValue)
                    Console.WriteLine(b.AspectRatio.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (encoded)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PNG (*.png)|*.png",
                    AddExtension = true
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    b.SaveImage(sfd.FileName, SaveTypes.PNG);
                }
            }
            else
            {
                Console.WriteLine("Encode first");
            }
        }
    }
}
