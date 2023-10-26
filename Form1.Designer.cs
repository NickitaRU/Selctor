namespace Selctor
{
    partial class FrVis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrVis));
            picVis = new PictureBox();
            txtText = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picVis).BeginInit();
            SuspendLayout();
            // 
            // picVis
            // 
            picVis.Location = new Point(436, 12);
            picVis.Name = "picVis";
            picVis.Size = new Size(352, 416);
            picVis.SizeMode = PictureBoxSizeMode.StretchImage;
            picVis.TabIndex = 0;
            picVis.TabStop = false;
            // 
            // txtText
            // 
            txtText.Location = new Point(11, 36);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.ReadOnly = true;
            txtText.Size = new Size(390, 394);
            txtText.TabIndex = 1;
            txtText.Text = resources.GetString("txtText.Text");
            txtText.Click += txtText_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(350, 20);
            label1.TabIndex = 2;
            label1.Text = "Выбери слово которое хочешь визуализировать";
            // 
            // FrVis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtText);
            Controls.Add(picVis);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrVis";
            Text = "Визуализатор существительных";
            ((System.ComponentModel.ISupportInitialize)picVis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picVis;
        private TextBox txtText;
        private Label label1;
    }
}