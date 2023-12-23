
namespace Tyuiu.KushnerovIA.Sprint7.Project.V13
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxFoto_KIA = new System.Windows.Forms.PictureBox();
            this.labelInfoProgram_KIA = new System.Windows.Forms.Label();
            this.iconButtonInfoOK_KIA = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto_KIA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFoto_KIA
            // 
            this.pictureBoxFoto_KIA.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFoto_KIA.Image")));
            this.pictureBoxFoto_KIA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFoto_KIA.Name = "pictureBoxFoto_KIA";
            this.pictureBoxFoto_KIA.Size = new System.Drawing.Size(226, 289);
            this.pictureBoxFoto_KIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFoto_KIA.TabIndex = 0;
            this.pictureBoxFoto_KIA.TabStop = false;
            // 
            // labelInfoProgram_KIA
            // 
            this.labelInfoProgram_KIA.AutoSize = true;
            this.labelInfoProgram_KIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoProgram_KIA.Location = new System.Drawing.Point(244, 21);
            this.labelInfoProgram_KIA.Name = "labelInfoProgram_KIA";
            this.labelInfoProgram_KIA.Size = new System.Drawing.Size(488, 144);
            this.labelInfoProgram_KIA.TabIndex = 2;
            this.labelInfoProgram_KIA.Text = resources.GetString("labelInfoProgram_KIA.Text");
            // 
            // iconButtonInfoOK_KIA
            // 
            this.iconButtonInfoOK_KIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonInfoOK_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonInfoOK_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonInfoOK_KIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonInfoOK_KIA.ForeColor = System.Drawing.Color.White;
            this.iconButtonInfoOK_KIA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonInfoOK_KIA.IconColor = System.Drawing.Color.White;
            this.iconButtonInfoOK_KIA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInfoOK_KIA.IconSize = 44;
            this.iconButtonInfoOK_KIA.Location = new System.Drawing.Point(669, 249);
            this.iconButtonInfoOK_KIA.Name = "iconButtonInfoOK_KIA";
            this.iconButtonInfoOK_KIA.Size = new System.Drawing.Size(63, 57);
            this.iconButtonInfoOK_KIA.TabIndex = 4;
            this.iconButtonInfoOK_KIA.Text = "OK";
            this.iconButtonInfoOK_KIA.UseVisualStyleBackColor = true;
            this.iconButtonInfoOK_KIA.Click += new System.EventHandler(this.iconButtonInfoOK_KIA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(746, 318);
            this.Controls.Add(this.iconButtonInfoOK_KIA);
            this.Controls.Add(this.labelInfoProgram_KIA);
            this.Controls.Add(this.pictureBoxFoto_KIA);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAbout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto_KIA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFoto_KIA;
        private System.Windows.Forms.Label labelInfoProgram_KIA;
        private FontAwesome.Sharp.IconButton iconButtonInfoOK_KIA;
    }
}