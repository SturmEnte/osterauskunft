namespace Osterauskunft
{
    partial class OsterauskunftForm
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
            Osterauskunft = new Label();
            Geben_Sie_ein_Jahr_ein = new Label();
            easterEggPicture = new PictureBox();
            yearInput = new TextBox();
            monthOutput = new Label();
            dayOutput = new Label();
            calcButton = new Button();
            ((System.ComponentModel.ISupportInitialize)easterEggPicture).BeginInit();
            SuspendLayout();
            // 
            // Osterauskunft
            // 
            Osterauskunft.Anchor = AnchorStyles.None;
            Osterauskunft.AutoSize = true;
            Osterauskunft.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Osterauskunft.Location = new Point(65, 28);
            Osterauskunft.Name = "Osterauskunft";
            Osterauskunft.Size = new Size(252, 39);
            Osterauskunft.TabIndex = 0;
            Osterauskunft.Text = "Osterauskunft";
            Osterauskunft.TextAlign = ContentAlignment.TopCenter;
            // 
            // Geben_Sie_ein_Jahr_ein
            // 
            Geben_Sie_ein_Jahr_ein.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Geben_Sie_ein_Jahr_ein.AutoSize = true;
            Geben_Sie_ein_Jahr_ein.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Geben_Sie_ein_Jahr_ein.ImageAlign = ContentAlignment.TopCenter;
            Geben_Sie_ein_Jahr_ein.Location = new Point(75, 112);
            Geben_Sie_ein_Jahr_ein.Name = "Geben_Sie_ein_Jahr_ein";
            Geben_Sie_ein_Jahr_ein.Size = new Size(233, 23);
            Geben_Sie_ein_Jahr_ein.TabIndex = 1;
            Geben_Sie_ein_Jahr_ein.Text = "Geben Sie ein Jahr ein.";
            // 
            // easterEggPicture
            // 
            easterEggPicture.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            easterEggPicture.BackgroundImageLayout = ImageLayout.Center;
            easterEggPicture.Location = new Point(27, 330);
            easterEggPicture.Name = "easterEggPicture";
            easterEggPicture.Size = new Size(328, 148);
            easterEggPicture.SizeMode = PictureBoxSizeMode.Zoom;
            easterEggPicture.TabIndex = 2;
            easterEggPicture.TabStop = false;
            // 
            // yearInput
            // 
            yearInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yearInput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearInput.Location = new Point(161, 148);
            yearInput.MaxLength = 4;
            yearInput.Name = "yearInput";
            yearInput.Size = new Size(60, 31);
            yearInput.TabIndex = 3;
            yearInput.TextAlign = HorizontalAlignment.Center;
            // 
            // monthOutput
            // 
            monthOutput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            monthOutput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthOutput.Location = new Point(113, 289);
            monthOutput.Name = "monthOutput";
            monthOutput.Size = new Size(157, 23);
            monthOutput.TabIndex = 4;
            monthOutput.Text = "...";
            monthOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dayOutput
            // 
            dayOutput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dayOutput.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dayOutput.Location = new Point(113, 251);
            dayOutput.Name = "dayOutput";
            dayOutput.Size = new Size(157, 23);
            dayOutput.TabIndex = 5;
            dayOutput.Text = "...";
            dayOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // calcButton
            // 
            calcButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            calcButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calcButton.Location = new Point(121, 185);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(140, 38);
            calcButton.TabIndex = 6;
            calcButton.Text = "Berechnen";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 503);
            Controls.Add(Geben_Sie_ein_Jahr_ein);
            Controls.Add(calcButton);
            Controls.Add(dayOutput);
            Controls.Add(monthOutput);
            Controls.Add(yearInput);
            Controls.Add(easterEggPicture);
            Controls.Add(Osterauskunft);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Osterauskunft";
            ((System.ComponentModel.ISupportInitialize)easterEggPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Osterauskunft;
        private Label Geben_Sie_ein_Jahr_ein;
        private PictureBox easterEggPicture;
        private TextBox yearInput;
        private Label monthOutput;
        private Label dayOutput;
        private Button calcButton;
    }
}
