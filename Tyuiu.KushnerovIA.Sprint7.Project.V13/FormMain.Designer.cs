
namespace Tyuiu.KushnerovIA.Sprint7.Project.V13
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialogMain_KIA = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMain_KIA = new System.Windows.Forms.SaveFileDialog();
            this.toolTipMain_KIA = new System.Windows.Forms.ToolTip(this.components);
            this.iconButtonOpenFile = new FontAwesome.Sharp.IconButton();
            this.iconButtonSaveFile_KIA = new FontAwesome.Sharp.IconButton();
            this.iconButtonInfo_KIA = new FontAwesome.Sharp.IconButton();
            this.iconButtonHelp_KIA = new FontAwesome.Sharp.IconButton();
            this.iconButtonSearch_KIA = new FontAwesome.Sharp.IconButton();
            this.iconButtonAverage_KIA = new FontAwesome.Sharp.IconButton();
            this.iconButtonGraf_KIA = new FontAwesome.Sharp.IconButton();
            this.iconButtonAvgArea_KIA = new FontAwesome.Sharp.IconButton();
            this.guna2GroupBoxMain_KIA = new Guna.UI2.WinForms.Guna2GroupBox();
            this.textBoxAvgArea_KIA = new System.Windows.Forms.TextBox();
            this.textBoxResultAver_KIA = new System.Windows.Forms.TextBox();
            this.textBoxSearch_KIA = new System.Windows.Forms.TextBox();
            this.guna2GroupBoxResult_KIA = new Guna.UI2.WinForms.Guna2GroupBox();
            this.chartMain_KIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewMain_KIA = new System.Windows.Forms.DataGridView();
            this.guna2GroupBoxMain_KIA.SuspendLayout();
            this.guna2GroupBoxResult_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain_KIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain_KIA)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogMain_KIA
            // 
            this.openFileDialogMain_KIA.Title = "\'\'Выберите файл сsv\"";
            // 
            // saveFileDialogMain_KIA
            // 
            this.saveFileDialogMain_KIA.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogMain_KIA_FileOk);
            // 
            // toolTipMain_KIA
            // 
            this.toolTipMain_KIA.ToolTipTitle = "Подсказка";
            // 
            // iconButtonOpenFile
            // 
            this.iconButtonOpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOpenFile.ForeColor = System.Drawing.Color.White;
            this.iconButtonOpenFile.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconButtonOpenFile.IconColor = System.Drawing.Color.White;
            this.iconButtonOpenFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonOpenFile.IconSize = 44;
            this.iconButtonOpenFile.Location = new System.Drawing.Point(12, 75);
            this.iconButtonOpenFile.Name = "iconButtonOpenFile";
            this.iconButtonOpenFile.Size = new System.Drawing.Size(63, 57);
            this.iconButtonOpenFile.TabIndex = 0;
            this.toolTipMain_KIA.SetToolTip(this.iconButtonOpenFile, "Открыть файл");
            this.iconButtonOpenFile.UseVisualStyleBackColor = true;
            this.iconButtonOpenFile.Click += new System.EventHandler(this.iconButtonOpenFile_Click);
            // 
            // iconButtonSaveFile_KIA
            // 
            this.iconButtonSaveFile_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSaveFile_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSaveFile_KIA.ForeColor = System.Drawing.Color.White;
            this.iconButtonSaveFile_KIA.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
            this.iconButtonSaveFile_KIA.IconColor = System.Drawing.Color.White;
            this.iconButtonSaveFile_KIA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSaveFile_KIA.IconSize = 44;
            this.iconButtonSaveFile_KIA.Location = new System.Drawing.Point(81, 75);
            this.iconButtonSaveFile_KIA.Name = "iconButtonSaveFile_KIA";
            this.iconButtonSaveFile_KIA.Size = new System.Drawing.Size(63, 57);
            this.iconButtonSaveFile_KIA.TabIndex = 1;
            this.toolTipMain_KIA.SetToolTip(this.iconButtonSaveFile_KIA, "Сохранить файл");
            this.iconButtonSaveFile_KIA.UseVisualStyleBackColor = true;
            this.iconButtonSaveFile_KIA.Click += new System.EventHandler(this.iconButtonSaveFile_KIA_Click);
            // 
            // iconButtonInfo_KIA
            // 
            this.iconButtonInfo_KIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonInfo_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonInfo_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonInfo_KIA.ForeColor = System.Drawing.Color.White;
            this.iconButtonInfo_KIA.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.iconButtonInfo_KIA.IconColor = System.Drawing.Color.White;
            this.iconButtonInfo_KIA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInfo_KIA.IconSize = 44;
            this.iconButtonInfo_KIA.Location = new System.Drawing.Point(202, 623);
            this.iconButtonInfo_KIA.Name = "iconButtonInfo_KIA";
            this.iconButtonInfo_KIA.Size = new System.Drawing.Size(63, 57);
            this.iconButtonInfo_KIA.TabIndex = 3;
            this.toolTipMain_KIA.SetToolTip(this.iconButtonInfo_KIA, "Открыть файл");
            this.iconButtonInfo_KIA.UseVisualStyleBackColor = true;
            this.iconButtonInfo_KIA.Click += new System.EventHandler(this.iconButtonInfo_KIA_Click);
            // 
            // iconButtonHelp_KIA
            // 
            this.iconButtonHelp_KIA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonHelp_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonHelp_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHelp_KIA.ForeColor = System.Drawing.Color.White;
            this.iconButtonHelp_KIA.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconButtonHelp_KIA.IconColor = System.Drawing.Color.White;
            this.iconButtonHelp_KIA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHelp_KIA.IconSize = 44;
            this.iconButtonHelp_KIA.Location = new System.Drawing.Point(271, 623);
            this.iconButtonHelp_KIA.Name = "iconButtonHelp_KIA";
            this.iconButtonHelp_KIA.Size = new System.Drawing.Size(63, 57);
            this.iconButtonHelp_KIA.TabIndex = 4;
            this.toolTipMain_KIA.SetToolTip(this.iconButtonHelp_KIA, "Руководство пользователя");
            this.iconButtonHelp_KIA.UseVisualStyleBackColor = true;
            this.iconButtonHelp_KIA.Click += new System.EventHandler(this.iconButtonHelp_KIA_Click);
            // 
            // iconButtonSearch_KIA
            // 
            this.iconButtonSearch_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSearch_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch_KIA.ForeColor = System.Drawing.Color.White;
            this.iconButtonSearch_KIA.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButtonSearch_KIA.IconColor = System.Drawing.Color.White;
            this.iconButtonSearch_KIA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch_KIA.IconSize = 44;
            this.iconButtonSearch_KIA.Location = new System.Drawing.Point(12, 153);
            this.iconButtonSearch_KIA.Name = "iconButtonSearch_KIA";
            this.iconButtonSearch_KIA.Size = new System.Drawing.Size(63, 57);
            this.iconButtonSearch_KIA.TabIndex = 5;
            this.toolTipMain_KIA.SetToolTip(this.iconButtonSearch_KIA, "Поиск");
            this.iconButtonSearch_KIA.UseVisualStyleBackColor = true;
            this.iconButtonSearch_KIA.Click += new System.EventHandler(this.iconButtonSearch_KIA_Click);
            // 
            // iconButtonAverage_KIA
            // 
            this.iconButtonAverage_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonAverage_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAverage_KIA.ForeColor = System.Drawing.Color.White;
            this.iconButtonAverage_KIA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAverage_KIA.IconColor = System.Drawing.Color.White;
            this.iconButtonAverage_KIA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAverage_KIA.IconSize = 44;
            this.iconButtonAverage_KIA.Location = new System.Drawing.Point(12, 232);
            this.iconButtonAverage_KIA.Name = "iconButtonAverage_KIA";
            this.iconButtonAverage_KIA.Size = new System.Drawing.Size(328, 74);
            this.iconButtonAverage_KIA.TabIndex = 7;
            this.iconButtonAverage_KIA.Text = "Найти общее среднее значение населения";
            this.toolTipMain_KIA.SetToolTip(this.iconButtonAverage_KIA, "Поиск");
            this.iconButtonAverage_KIA.UseVisualStyleBackColor = true;
            this.iconButtonAverage_KIA.Click += new System.EventHandler(this.iconButtonAverage_KIA_Click);
            // 
            // iconButtonGraf_KIA
            // 
            this.iconButtonGraf_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonGraf_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonGraf_KIA.ForeColor = System.Drawing.Color.White;
            this.iconButtonGraf_KIA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonGraf_KIA.IconColor = System.Drawing.Color.White;
            this.iconButtonGraf_KIA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonGraf_KIA.IconSize = 44;
            this.iconButtonGraf_KIA.Location = new System.Drawing.Point(12, 526);
            this.iconButtonGraf_KIA.Name = "iconButtonGraf_KIA";
            this.iconButtonGraf_KIA.Size = new System.Drawing.Size(328, 74);
            this.iconButtonGraf_KIA.TabIndex = 9;
            this.iconButtonGraf_KIA.Text = "Построить график населения стран";
            this.toolTipMain_KIA.SetToolTip(this.iconButtonGraf_KIA, "Поиск");
            this.iconButtonGraf_KIA.UseVisualStyleBackColor = true;
            this.iconButtonGraf_KIA.Click += new System.EventHandler(this.iconButtonGraf_KIA_Click);
            // 
            // iconButtonAvgArea_KIA
            // 
            this.iconButtonAvgArea_KIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonAvgArea_KIA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAvgArea_KIA.ForeColor = System.Drawing.Color.White;
            this.iconButtonAvgArea_KIA.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAvgArea_KIA.IconColor = System.Drawing.Color.White;
            this.iconButtonAvgArea_KIA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAvgArea_KIA.IconSize = 44;
            this.iconButtonAvgArea_KIA.Location = new System.Drawing.Point(12, 378);
            this.iconButtonAvgArea_KIA.Name = "iconButtonAvgArea_KIA";
            this.iconButtonAvgArea_KIA.Size = new System.Drawing.Size(328, 74);
            this.iconButtonAvgArea_KIA.TabIndex = 10;
            this.iconButtonAvgArea_KIA.Text = "Найти общее среднее значение площади";
            this.toolTipMain_KIA.SetToolTip(this.iconButtonAvgArea_KIA, "Поиск");
            this.iconButtonAvgArea_KIA.UseVisualStyleBackColor = true;
            this.iconButtonAvgArea_KIA.Click += new System.EventHandler(this.iconButtonAvgArea_KIA_Click);
            // 
            // guna2GroupBoxMain_KIA
            // 
            this.guna2GroupBoxMain_KIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2GroupBoxMain_KIA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.guna2GroupBoxMain_KIA.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBoxMain_KIA.Controls.Add(this.textBoxAvgArea_KIA);
            this.guna2GroupBoxMain_KIA.Controls.Add(this.iconButtonAvgArea_KIA);
            this.guna2GroupBoxMain_KIA.Controls.Add(this.iconButtonGraf_KIA);
            this.guna2GroupBoxMain_KIA.Controls.Add(this.textBoxResultAver_KIA);
            this.guna2GroupBoxMain_KIA.Controls.Add(this.iconButtonAverage_KIA);
            this.guna2GroupBoxMain_KIA.Controls.Add(this.textBoxSearch_KIA);
            this.guna2GroupBoxMain_KIA.Controls.Add(this.iconButtonSearch_KIA);
            this.guna2GroupBoxMain_KIA.Controls.Add(this.iconButtonHelp_KIA);
            this.guna2GroupBoxMain_KIA.Controls.Add(this.iconButtonInfo_KIA);
            this.guna2GroupBoxMain_KIA.Controls.Add(this.iconButtonSaveFile_KIA);
            this.guna2GroupBoxMain_KIA.Controls.Add(this.iconButtonOpenFile);
            this.guna2GroupBoxMain_KIA.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2GroupBoxMain_KIA.CustomBorderThickness = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.guna2GroupBoxMain_KIA.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GroupBoxMain_KIA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2GroupBoxMain_KIA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GroupBoxMain_KIA.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBoxMain_KIA.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBoxMain_KIA.Name = "guna2GroupBoxMain_KIA";
            this.guna2GroupBoxMain_KIA.Size = new System.Drawing.Size(346, 692);
            this.guna2GroupBoxMain_KIA.TabIndex = 0;
            this.guna2GroupBoxMain_KIA.Text = "Панель управления";
            this.guna2GroupBoxMain_KIA.TextOffset = new System.Drawing.Point(0, 10);
            this.guna2GroupBoxMain_KIA.Click += new System.EventHandler(this.guna2GroupBoxMain_KIA_Click);
            // 
            // textBoxAvgArea_KIA
            // 
            this.textBoxAvgArea_KIA.Location = new System.Drawing.Point(12, 472);
            this.textBoxAvgArea_KIA.Name = "textBoxAvgArea_KIA";
            this.textBoxAvgArea_KIA.ReadOnly = true;
            this.textBoxAvgArea_KIA.Size = new System.Drawing.Size(328, 34);
            this.textBoxAvgArea_KIA.TabIndex = 11;
            // 
            // textBoxResultAver_KIA
            // 
            this.textBoxResultAver_KIA.Location = new System.Drawing.Point(12, 326);
            this.textBoxResultAver_KIA.Name = "textBoxResultAver_KIA";
            this.textBoxResultAver_KIA.ReadOnly = true;
            this.textBoxResultAver_KIA.Size = new System.Drawing.Size(328, 34);
            this.textBoxResultAver_KIA.TabIndex = 8;
            // 
            // textBoxSearch_KIA
            // 
            this.textBoxSearch_KIA.Location = new System.Drawing.Point(81, 164);
            this.textBoxSearch_KIA.Name = "textBoxSearch_KIA";
            this.textBoxSearch_KIA.Size = new System.Drawing.Size(252, 34);
            this.textBoxSearch_KIA.TabIndex = 6;
            // 
            // guna2GroupBoxResult_KIA
            // 
            this.guna2GroupBoxResult_KIA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2GroupBoxResult_KIA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.guna2GroupBoxResult_KIA.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GroupBoxResult_KIA.Controls.Add(this.chartMain_KIA);
            this.guna2GroupBoxResult_KIA.Controls.Add(this.dataGridViewMain_KIA);
            this.guna2GroupBoxResult_KIA.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.guna2GroupBoxResult_KIA.CustomBorderThickness = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.guna2GroupBoxResult_KIA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBoxResult_KIA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.guna2GroupBoxResult_KIA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2GroupBoxResult_KIA.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBoxResult_KIA.Location = new System.Drawing.Point(346, 0);
            this.guna2GroupBoxResult_KIA.Name = "guna2GroupBoxResult_KIA";
            this.guna2GroupBoxResult_KIA.Size = new System.Drawing.Size(756, 692);
            this.guna2GroupBoxResult_KIA.TabIndex = 1;
            this.guna2GroupBoxResult_KIA.Text = "Вывод данных";
            this.guna2GroupBoxResult_KIA.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // chartMain_KIA
            // 
            this.chartMain_KIA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartMain_KIA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMain_KIA.Legends.Add(legend1);
            this.chartMain_KIA.Location = new System.Drawing.Point(7, 357);
            this.chartMain_KIA.Name = "chartMain_KIA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMain_KIA.Series.Add(series1);
            this.chartMain_KIA.Size = new System.Drawing.Size(737, 323);
            this.chartMain_KIA.TabIndex = 1;
            this.chartMain_KIA.Text = "chart1";
            // 
            // dataGridViewMain_KIA
            // 
            this.dataGridViewMain_KIA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain_KIA.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMain_KIA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain_KIA.Location = new System.Drawing.Point(7, 64);
            this.dataGridViewMain_KIA.Name = "dataGridViewMain_KIA";
            this.dataGridViewMain_KIA.RowHeadersWidth = 51;
            this.dataGridViewMain_KIA.RowTemplate.Height = 24;
            this.dataGridViewMain_KIA.Size = new System.Drawing.Size(737, 273);
            this.dataGridViewMain_KIA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1102, 692);
            this.Controls.Add(this.guna2GroupBoxResult_KIA);
            this.Controls.Add(this.guna2GroupBoxMain_KIA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1120, 739);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CG - Country Guid";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.guna2GroupBoxMain_KIA.ResumeLayout(false);
            this.guna2GroupBoxMain_KIA.PerformLayout();
            this.guna2GroupBoxResult_KIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain_KIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain_KIA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogMain_KIA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain_KIA;
        private System.Windows.Forms.ToolTip toolTipMain_KIA;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBoxMain_KIA;
        private FontAwesome.Sharp.IconButton iconButtonSaveFile_KIA;
        private FontAwesome.Sharp.IconButton iconButtonOpenFile;
        private FontAwesome.Sharp.IconButton iconButtonHelp_KIA;
        private FontAwesome.Sharp.IconButton iconButtonInfo_KIA;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBoxResult_KIA;
        private System.Windows.Forms.DataGridView dataGridViewMain_KIA;
        private FontAwesome.Sharp.IconButton iconButtonSearch_KIA;
        private System.Windows.Forms.TextBox textBoxSearch_KIA;
        private System.Windows.Forms.TextBox textBoxResultAver_KIA;
        private FontAwesome.Sharp.IconButton iconButtonAverage_KIA;
        private FontAwesome.Sharp.IconButton iconButtonGraf_KIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain_KIA;
        private System.Windows.Forms.TextBox textBoxAvgArea_KIA;
        private FontAwesome.Sharp.IconButton iconButtonAvgArea_KIA;
    }
}

