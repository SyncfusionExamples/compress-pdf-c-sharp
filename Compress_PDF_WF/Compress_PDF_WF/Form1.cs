using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf;

namespace Compress_PDF_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.openFileDialog1.Filter = "PDF files (*.pdf)|*.pdf";
            this.pictureBox1.Image = System.Drawing.Image.FromFile("../../../Data/pdf_header.png");
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon("../../../Data/syncfusion.ico");
            this.MinimizeBox = true;
            for (int i = 1; i <= 100; i++)
                this.imageQuality.Items.Add(i);
            this.imageQuality.SelectedIndex = 49;
            this.optimizeFont.Checked = true;
            this.compressPageContents.Checked = true;
            this.removeMetadata.Checked = true;
            this.compressImage.Checked = true;
            this.Height = 1500;
            textBox1.Tag = @"..\..\..\Data\jQuery_Succinctly.pdf";
            textBox1.Text = "jQuery_Succinctly.Pdf";
        }

        private void compressPDF_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != string.Empty)
            {
                string ex = Path.GetExtension(textBox1.Tag.ToString());

                if (ex == ".pdf" || ex == ".PDF")
                {
                    byte[] inputFile = File.ReadAllBytes(textBox1.Tag.ToString());

                    //Load a existing PDF document
                    PdfLoadedDocument ldoc = new PdfLoadedDocument(inputFile);

                    //Create a new PDF compression options
                    PdfCompressionOptions options = new PdfCompressionOptions();

                    if (compressImage.Checked)
                    {
                        //Compress image.
                        options.CompressImages = true;
                        options.ImageQuality = int.Parse((imageQuality.SelectedIndex + 1).ToString());
                    }
                    else
                        options.CompressImages = false;

                    //Compress the font data
                    if (optimizeFont.Checked)
                        options.OptimizeFont = true;
                    else
                        options.OptimizeFont = false;

                    //Compress the page contents
                    if (compressPageContents.Checked)
                        options.OptimizePageContents = true;
                    else
                        options.OptimizePageContents = false;

                    //Remove the metadata information.
                    if (removeMetadata.Checked)
                        options.RemoveMetadata = true;
                    else
                        options.RemoveMetadata = false;

                    //Set the options to loaded PDF document
                    ldoc.CompressionOptions = options;


                    //Restructure the document
                    if (incrementalUpdate.Checked)
                        ldoc.FileStructure.IncrementalUpdate = false;
                    else
                        ldoc.FileStructure.IncrementalUpdate = true;
                    //Remove form fields and its data.
                    if (removeFormFields.Checked)
                        RemoveFormFields(ldoc, false);

                    //Remove annotation and its data.
                    if (removeAnnotation.Checked)
                        RemoveAnnotations(ldoc, false);

                    //Save the document 
                    MemoryStream ms = new MemoryStream();
                    ldoc.Save(ms);

                    this.ods.Text = (inputFile.Length / 1024).ToString() + " KB";
                    this.cds.Text = (ms.Length / 1024).ToString() + " KB ";
                    this.Height = 580;

                    if (MessageBox.Show("Do you want to view the PDF file?", "PDF File Created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
                    {
                        File.WriteAllBytes("Sample.pdf", ms.ToArray());
                        ms.Dispose();
                        //Launching the PDF file using the default Application.[Acrobat Reader]
                        //System.Diagnostics.Process.Start("Sample.pdf");
                        this.Close();
                    }
                    else
                    {
                        ms.Dispose();
                        // Exit
                        //this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please select the valid PDF file.");
                }
            }
            else
            {
                MessageBox.Show("Please select the valid PDF file.");
            }
        }
        #region Helper methods
        public void RemoveFormFields(PdfLoadedDocument ldoc, bool flatten)
        {
            if (ldoc.Form != null)
            {
                if (flatten)
                {
                    ldoc.Form.Flatten = true;
                }
                else
                {
                    int count = ldoc.Form.Fields.Count;
                    for (int i = count - 1; i >= 0; i--)
                    {
                        ldoc.Form.Fields.RemoveAt(i);
                    }
                }
            }
        }

        public void RemoveAnnotations(PdfLoadedDocument ldoc, bool flatten)
        {
            foreach (PdfPageBase page in ldoc.Pages)
            {
                if (flatten)
                {
                    int count = page.Annotations.Count;
                    for (int i = count - 1; i >= 0; i--)
                    {
                        page.Annotations[i].Flatten = true;
                    }
                }
                else
                {
                    int count = page.Annotations.Count;
                    for (int i = count - 1; i >= 0; i--)
                    {
                        page.Annotations.RemoveAt(i);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.SafeFileName;
                textBox1.Tag = openFileDialog1.FileName;
                this.ods.Text = this.cds.Text = "";
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (compressImage.Checked)
                this.imageQuality.Enabled = true;
            else
                this.imageQuality.Enabled = false;
        }

        #endregion
    }
}
