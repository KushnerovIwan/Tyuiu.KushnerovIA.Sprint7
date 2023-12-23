
namespace Tyuiu.KushnerovIA.Sprint7.Project.V13
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.textBoxGuide_KIA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxGuide_KIA
            // 
            this.textBoxGuide_KIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBoxGuide_KIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGuide_KIA.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGuide_KIA.ForeColor = System.Drawing.Color.White;
            this.textBoxGuide_KIA.Location = new System.Drawing.Point(13, 13);
            this.textBoxGuide_KIA.Multiline = true;
            this.textBoxGuide_KIA.Name = "textBoxGuide_KIA";
            this.textBoxGuide_KIA.ReadOnly = true;
            this.textBoxGuide_KIA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGuide_KIA.Size = new System.Drawing.Size(775, 425);
            this.textBoxGuide_KIA.TabIndex = 0;
            this.textBoxGuide_KIA.Text = resources.GetString("textBoxGuide_KIA.Text");
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxGuide_KIA);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormGuide";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGuide_KIA;
    }
}