using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KushnerovIA.Sprint7.Project.V13.Lib;
using Guna;
using FontAwesome.Sharp;

namespace Tyuiu.KushnerovIA.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private DataTable ReadCSVFile(string pathToCsvFile)
        {
            //создаём таблицу
            DataTable dt = new DataTable("countries");
            //создаём колонки
            DataColumn country;
            country = new DataColumn("Страна", typeof(String));
            DataColumn capital;
            capital = new DataColumn("Столица", typeof(String));
            DataColumn population;
            population = new DataColumn("Население(млн)", typeof(Int32));
            DataColumn square;
            square = new DataColumn("Площадь(км^2)", typeof(Int32));
            DataColumn currency;
            currency = new DataColumn("Валюта", typeof(String));
            DataColumn nationality;
            nationality = new DataColumn("Национальность");

            //добавляем колонки в таблицу
            dt.Columns.AddRange(new DataColumn[] { country, capital, population, square, currency, nationality });
            try
            {
                DataRow dr = null;
                string[] value = null;
                string[] countries = File.ReadAllLines(pathToCsvFile);
                for (int i = 0; i < countries.Length; i++)
                {
                    if (!String.IsNullOrEmpty(countries[i]))
                    {
                        value = countries[i].Split(',');
                        //создаём новую строку
                        dr = dt.NewRow();
                        dr["Страна"] = value[0];
                        dr["Столица"] = value[1];
                        dr["Население(млн)"] = Int32.Parse(value[2]);
                        dr["Площадь(км^2)"] = Int32.Parse(value[3]);
                        dr["Валюта"] = (value[4]);
                        dr["Национальность"] = (value[5]);
                        //добавляем строку в таблицу
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        private void buttonOpenFile_KIA_Click(object sender, EventArgs e)
        {
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
        }

        private void iconButtonOpenFile_Click(object sender, EventArgs e)
        {
            dataGridViewMain_KIA.DataSource = ReadCSVFile($@"{Directory.GetCurrentDirectory()}\DataBase.csv");
            dataGridViewMain_KIA.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void guna2GroupBoxMain_KIA_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonInfo_KIA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void iconButtonSaveFile_KIA_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMain_KIA.FileName = "DataBase.csv";
                saveFileDialogMain_KIA.InitialDirectory = @":C";
                if (saveFileDialogMain_KIA.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialogMain_KIA.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewMain_KIA.RowCount;
                    int columns = dataGridViewMain_KIA.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewMain_KIA.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(",");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFileDialogMain_KIA_FileOk(object sender, CancelEventArgs e)
        {

        }

        

        private void iconButtonSearch_KIA_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewMain_KIA.RowCount; i++)
            {
                dataGridViewMain_KIA.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewMain_KIA.ColumnCount; j++)
                    if (dataGridViewMain_KIA.Rows[i].Cells[j].Value != null)
                        if (dataGridViewMain_KIA.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_KIA.Text))
                        {
                            dataGridViewMain_KIA.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void iconButtonAverage_KIA_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < dataGridViewMain_KIA.Rows.Count; i++)
            {
                c += Convert.ToInt32(dataGridViewMain_KIA.Rows[i].Cells[2].Value);
            }
            int rows = dataGridViewMain_KIA.Rows.Count - 1;
            double avg = c / rows;
            avg = Math.Round(avg, 2);
            dataGridViewMain_KIA.Text = avg.ToString();
        }


        private void iconButtonGraf_KIA_Click(object sender, EventArgs e)
        {
            chartMain_KIA.Series[0].Points.Clear();

            foreach (DataGridViewRow row in dataGridViewMain_KIA.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string xValue = row.Cells[0].Value.ToString();
                    double yValue = Convert.ToDouble(row.Cells[2].Value);

                    chartMain_KIA.Series["Series1"].Points.AddXY(xValue, yValue);
                }
            }
        }

        private void iconButtonHelp_KIA_Click(object sender, EventArgs e)
        {
            FormGuide formInfo = new FormGuide();
            formInfo.ShowDialog();
        }


    }
}
