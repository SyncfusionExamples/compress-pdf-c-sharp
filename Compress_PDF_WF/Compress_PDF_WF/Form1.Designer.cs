namespace Compress_PDF_WF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            browseButton = new Button();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            imageQuality = new ComboBox();
            label1 = new Label();
            removeFormFields = new CheckBox();
            disableIncrementalUpdates = new CheckBox();
            removeMetadata = new CheckBox();
            removeAttachments = new CheckBox();
            removeAnnotations = new CheckBox();
            optimizeFont = new CheckBox();
            optimizePageContents = new CheckBox();
            compressImage = new CheckBox();
            compressPdf = new Button();
            groupBox3 = new GroupBox();
            cds = new Label();
            ods = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(509, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(browseButton);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 194);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(484, 82);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose a PDF file to compress";
            // 
            // browseButton
            // 
            browseButton.Location = new Point(420, 38);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(49, 23);
            browseButton.TabIndex = 1;
            browseButton.Text = "...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(408, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(imageQuality);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(removeFormFields);
            groupBox2.Controls.Add(disableIncrementalUpdates);
            groupBox2.Controls.Add(removeMetadata);
            groupBox2.Controls.Add(removeAttachments);
            groupBox2.Controls.Add(removeAnnotations);
            groupBox2.Controls.Add(optimizeFont);
            groupBox2.Controls.Add(optimizePageContents);
            groupBox2.Controls.Add(compressImage);
            groupBox2.Location = new Point(12, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(484, 228);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Compression Options";
            // 
            // imageQuality
            // 
            imageQuality.FormattingEnabled = true;
            imageQuality.Location = new Point(373, 21);
            imageQuality.Name = "imageQuality";
            imageQuality.Size = new Size(98, 23);
            imageQuality.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 29);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 8;
            label1.Text = "Image Quality";
            // 
            // removeFormFields
            // 
            removeFormFields.AutoSize = true;
            removeFormFields.Location = new Point(268, 153);
            removeFormFields.Name = "removeFormFields";
            removeFormFields.Size = new Size(133, 19);
            removeFormFields.TabIndex = 7;
            removeFormFields.Text = "Remove Form Fields";
            removeFormFields.UseVisualStyleBackColor = true;
            // 
            // disableIncrementalUpdates
            // 
            disableIncrementalUpdates.AutoSize = true;
            disableIncrementalUpdates.Location = new Point(268, 110);
            disableIncrementalUpdates.Name = "disableIncrementalUpdates";
            disableIncrementalUpdates.Size = new Size(176, 19);
            disableIncrementalUpdates.TabIndex = 6;
            disableIncrementalUpdates.Text = "Disable Incremental Updates";
            disableIncrementalUpdates.UseVisualStyleBackColor = true;
            // 
            // removeMetadata
            // 
            removeMetadata.AutoSize = true;
            removeMetadata.Location = new Point(268, 69);
            removeMetadata.Name = "removeMetadata";
            removeMetadata.Size = new Size(188, 19);
            removeMetadata.TabIndex = 5;
            removeMetadata.Text = "Remove Metadata Information";
            removeMetadata.UseVisualStyleBackColor = true;
            // 
            // removeAttachments
            // 
            removeAttachments.AutoSize = true;
            removeAttachments.Location = new Point(13, 198);
            removeAttachments.Name = "removeAttachments";
            removeAttachments.Size = new Size(140, 19);
            removeAttachments.TabIndex = 4;
            removeAttachments.Text = "Remove Attachments";
            removeAttachments.UseVisualStyleBackColor = true;
            // 
            // removeAnnotations
            // 
            removeAnnotations.AutoSize = true;
            removeAnnotations.Location = new Point(12, 153);
            removeAnnotations.Name = "removeAnnotations";
            removeAnnotations.Size = new Size(137, 19);
            removeAnnotations.TabIndex = 3;
            removeAnnotations.Text = "Remove Annotations";
            removeAnnotations.UseVisualStyleBackColor = true;
            // 
            // optimizeFont
            // 
            optimizeFont.AutoSize = true;
            optimizeFont.Location = new Point(12, 110);
            optimizeFont.Name = "optimizeFont";
            optimizeFont.Size = new Size(101, 19);
            optimizeFont.TabIndex = 2;
            optimizeFont.Text = "Optimize Font";
            optimizeFont.UseVisualStyleBackColor = true;
            // 
            // optimizePageContents
            // 
            optimizePageContents.AutoSize = true;
            optimizePageContents.Location = new Point(12, 69);
            optimizePageContents.Name = "optimizePageContents";
            optimizePageContents.Size = new Size(154, 19);
            optimizePageContents.TabIndex = 1;
            optimizePageContents.Text = "Optimize Page Contents";
            optimizePageContents.UseVisualStyleBackColor = true;
            // 
            // compressImage
            // 
            compressImage.AutoSize = true;
            compressImage.Location = new Point(13, 30);
            compressImage.Name = "compressImage";
            compressImage.Size = new Size(120, 19);
            compressImage.TabIndex = 0;
            compressImage.Text = "Compress Images";
            compressImage.UseVisualStyleBackColor = true;
            compressImage.CheckedChanged += compressImage_CheckedChanged;
            // 
            // compressPdf
            // 
            compressPdf.Location = new Point(359, 553);
            compressPdf.Name = "compressPdf";
            compressPdf.Size = new Size(137, 28);
            compressPdf.TabIndex = 3;
            compressPdf.Text = "Compress PDF";
            compressPdf.UseVisualStyleBackColor = true;
            compressPdf.Click += compressPdf_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cds);
            groupBox3.Controls.Add(ods);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 596);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(484, 94);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Result";
            // 
            // cds
            // 
            cds.AutoSize = true;
            cds.Location = new Point(234, 65);
            cds.Name = "cds";
            cds.Size = new Size(38, 15);
            cds.TabIndex = 3;
            cds.Text = "label6";
            // 
            // ods
            // 
            ods.AutoSize = true;
            ods.Location = new Point(234, 34);
            ods.Name = "ods";
            ods.Size = new Size(38, 15);
            ods.TabIndex = 2;
            ods.Text = "lable6";
            ods.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 65);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 1;
            label3.Text = "Compressed document size:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 0;
            label2.Text = "Original document size: ";
            // 
            // label4
            // 
            label4.Location = new Point(12, 122);
            label4.Name = "label4";
            label4.Size = new Size(484, 55);
            label4.TabIndex = 5;
            label4.Text = resources.GetString("label4.Text");
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(508, 702);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(compressPdf);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Compress Existing PDF";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button browseButton;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private ComboBox imageQuality;
        private Label label1;
        private CheckBox removeFormFields;
        private CheckBox disableIncrementalUpdates;
        private CheckBox removeMetadata;
        private CheckBox removeAttachments;
        private CheckBox removeAnnotations;
        private CheckBox optimizeFont;
        private CheckBox optimizePageContents;
        private CheckBox compressImage;
        private Button compressPdf;
        private GroupBox groupBox3;
        private Label label3;
        private Label label2;
        private Label label4;
        private OpenFileDialog openFileDialog1;
        private Label cds;
        private Label ods;
    }
}
