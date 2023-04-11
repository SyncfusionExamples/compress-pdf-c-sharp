﻿namespace Compress_PDF_WF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.compressPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.compressImage = new System.Windows.Forms.CheckBox();
            this.optimizeFont = new System.Windows.Forms.CheckBox();
            this.compressPageContents = new System.Windows.Forms.CheckBox();
            this.imageQuality = new System.Windows.Forms.ComboBox();
            this.removeMetadata = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.incrementalUpdate = new System.Windows.Forms.CheckBox();
            this.removeFormFields = new System.Windows.Forms.CheckBox();
            this.removeAnnotation = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ods = new System.Windows.Forms.Label();
            this.cds = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // compressPDF
            // 
            this.compressPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.compressPDF.BackColor = System.Drawing.Color.Transparent;
            this.compressPDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.compressPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.compressPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.compressPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.compressPDF.Location = new System.Drawing.Point(260, 408);
            this.compressPDF.Name = "compressPDF";
            this.compressPDF.Size = new System.Drawing.Size(117, 24);
            this.compressPDF.TabIndex = 25;
            this.compressPDF.Text = "Compress PDF";
            this.compressPDF.UseVisualStyleBackColor = false;
            this.compressPDF.Click += new System.EventHandler(this.compressPDF_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-3, 92);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(382, 55);
            this.label1.TabIndex = 26;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 21);
            this.textBox1.TabIndex = 31;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 64);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose a PDF file to compress";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 22);
            this.button2.TabIndex = 33;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // compressImage
            // 
            this.compressImage.AutoSize = true;
            this.compressImage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressImage.Location = new System.Drawing.Point(6, 29);
            this.compressImage.Name = "compressImage";
            this.compressImage.Size = new System.Drawing.Size(131, 17);
            this.compressImage.TabIndex = 34;
            this.compressImage.Text = "Compress Images";
            this.compressImage.UseVisualStyleBackColor = true;
            this.compressImage.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // optimizeFont
            // 
            this.optimizeFont.AutoSize = true;
            this.optimizeFont.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizeFont.Location = new System.Drawing.Point(6, 102);
            this.optimizeFont.Name = "optimizeFont";
            this.optimizeFont.Size = new System.Drawing.Size(104, 17);
            this.optimizeFont.TabIndex = 35;
            this.optimizeFont.Text = "Optimize Font";
            this.optimizeFont.UseVisualStyleBackColor = true;
            // 
            // compressPageContents
            // 
            this.compressPageContents.AutoSize = true;
            this.compressPageContents.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compressPageContents.Location = new System.Drawing.Point(6, 66);
            this.compressPageContents.Name = "compressPageContents";
            this.compressPageContents.Size = new System.Drawing.Size(163, 17);
            this.compressPageContents.TabIndex = 36;
            this.compressPageContents.Text = "Optimize Page Contents";
            this.compressPageContents.UseVisualStyleBackColor = true;
            // 
            // imageQuality
            // 
            this.imageQuality.FormattingEnabled = true;
            this.imageQuality.Location = new System.Drawing.Point(289, 27);
            this.imageQuality.Name = "imageQuality";
            this.imageQuality.Size = new System.Drawing.Size(79, 21);
            this.imageQuality.TabIndex = 37;
            // 
            // removeMetadata
            // 
            this.removeMetadata.AutoSize = true;
            this.removeMetadata.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeMetadata.Location = new System.Drawing.Point(175, 66);
            this.removeMetadata.Name = "removeMetadata";
            this.removeMetadata.Size = new System.Drawing.Size(200, 17);
            this.removeMetadata.TabIndex = 38;
            this.removeMetadata.Text = "Remove Metadata Information";
            this.removeMetadata.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.incrementalUpdate);
            this.groupBox1.Controls.Add(this.removeFormFields);
            this.groupBox1.Controls.Add(this.removeAnnotation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.compressImage);
            this.groupBox1.Controls.Add(this.removeMetadata);
            this.groupBox1.Controls.Add(this.imageQuality);
            this.groupBox1.Controls.Add(this.compressPageContents);
            this.groupBox1.Controls.Add(this.optimizeFont);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 170);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compression Options";
            // 
            // incrementalUpdate
            // 
            this.incrementalUpdate.AutoSize = true;
            this.incrementalUpdate.Checked = true;
            this.incrementalUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.incrementalUpdate.Location = new System.Drawing.Point(175, 102);
            this.incrementalUpdate.Name = "incrementalUpdate";
            this.incrementalUpdate.Size = new System.Drawing.Size(183, 17);
            this.incrementalUpdate.TabIndex = 43;
            this.incrementalUpdate.Text = "Disable incremental Update";
            this.incrementalUpdate.UseVisualStyleBackColor = true;
            // 
            // removeFormFields
            // 
            this.removeFormFields.AutoSize = true;
            this.removeFormFields.Location = new System.Drawing.Point(175, 134);
            this.removeFormFields.Name = "removeFormFields";
            this.removeFormFields.Size = new System.Drawing.Size(142, 17);
            this.removeFormFields.TabIndex = 42;
            this.removeFormFields.Text = "Remove Form Fields";
            this.removeFormFields.UseVisualStyleBackColor = true;
            // 
            // removeAnnotation
            // 
            this.removeAnnotation.AutoSize = true;
            this.removeAnnotation.Location = new System.Drawing.Point(6, 134);
            this.removeAnnotation.Name = "removeAnnotation";
            this.removeAnnotation.Size = new System.Drawing.Size(144, 17);
            this.removeAnnotation.TabIndex = 41;
            this.removeAnnotation.Text = "Remove Annotations";
            this.removeAnnotation.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Image Quality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Original document size : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Compressed document size :";
            // 
            // ods
            // 
            this.ods.AutoSize = true;
            this.ods.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ods.Location = new System.Drawing.Point(205, 25);
            this.ods.Name = "ods";
            this.ods.Size = new System.Drawing.Size(41, 13);
            this.ods.TabIndex = 3;
            this.ods.Text = "label6";
            // 
            // cds
            // 
            this.cds.AutoSize = true;
            this.cds.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cds.Location = new System.Drawing.Point(205, 50);
            this.cds.Name = "cds";
            this.cds.Size = new System.Drawing.Size(41, 13);
            this.cds.TabIndex = 4;
            this.cds.Text = "label6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cds);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ods);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 81);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.compressPDF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compress Existing PDF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button compressPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox compressImage;
        private System.Windows.Forms.CheckBox optimizeFont;
        private System.Windows.Forms.CheckBox compressPageContents;
        private System.Windows.Forms.ComboBox imageQuality;
        private System.Windows.Forms.CheckBox removeMetadata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cds;
        private System.Windows.Forms.Label ods;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox removeFormFields;
        private System.Windows.Forms.CheckBox removeAnnotation;
        private System.Windows.Forms.CheckBox incrementalUpdate;
    }
}

