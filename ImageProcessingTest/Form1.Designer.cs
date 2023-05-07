namespace ImageProcessingTest
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
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.tbxPicture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.pbxRed = new System.Windows.Forms.PictureBox();
            this.pbxGreen = new System.Windows.Forms.PictureBox();
            this.pbxBlue = new System.Windows.Forms.PictureBox();
            this.pbxBordes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBordes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMain
            // 
            this.pbxMain.Location = new System.Drawing.Point(882, 20);
            this.pbxMain.Margin = new System.Windows.Forms.Padding(5);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(360, 420);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMain.TabIndex = 0;
            this.pbxMain.TabStop = false;
            // 
            // tbxPicture
            // 
            this.tbxPicture.Location = new System.Drawing.Point(14, 51);
            this.tbxPicture.Margin = new System.Windows.Forms.Padding(5);
            this.tbxPicture.Name = "tbxPicture";
            this.tbxPicture.Size = new System.Drawing.Size(603, 32);
            this.tbxPicture.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(625, 51);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(117, 32);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(748, 51);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(117, 32);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // pbxRed
            // 
            this.pbxRed.Location = new System.Drawing.Point(37, 166);
            this.pbxRed.Name = "pbxRed";
            this.pbxRed.Size = new System.Drawing.Size(180, 210);
            this.pbxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRed.TabIndex = 5;
            this.pbxRed.TabStop = false;
            // 
            // pbxGreen
            // 
            this.pbxGreen.Location = new System.Drawing.Point(293, 166);
            this.pbxGreen.Name = "pbxGreen";
            this.pbxGreen.Size = new System.Drawing.Size(180, 210);
            this.pbxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGreen.TabIndex = 6;
            this.pbxGreen.TabStop = false;
            // 
            // pbxBlue
            // 
            this.pbxBlue.Location = new System.Drawing.Point(549, 166);
            this.pbxBlue.Name = "pbxBlue";
            this.pbxBlue.Size = new System.Drawing.Size(180, 210);
            this.pbxBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBlue.TabIndex = 7;
            this.pbxBlue.TabStop = false;
            // 
            // pbxBordes
            // 
            this.pbxBordes.Location = new System.Drawing.Point(37, 453);
            this.pbxBordes.Name = "pbxBordes";
            this.pbxBordes.Size = new System.Drawing.Size(180, 210);
            this.pbxBordes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBordes.TabIndex = 8;
            this.pbxBordes.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 744);
            this.Controls.Add(this.pbxBordes);
            this.Controls.Add(this.pbxBlue);
            this.Controls.Add(this.pbxGreen);
            this.Controls.Add(this.pbxRed);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPicture);
            this.Controls.Add(this.pbxMain);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Image Testing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBordes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbxMain;
        private TextBox tbxPicture;
        private Label label1;
        private Button btnSelect;
        private Button btnProcess;
        private PictureBox pbxRed;
        private PictureBox pbxGreen;
        private PictureBox pbxBlue;
        private PictureBox pbxBordes;
    }
}