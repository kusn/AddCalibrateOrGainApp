using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddCalibrateOrGainApp
{
    public partial class Form1 : Form
    {
        private SortedList<double, double> _listInitData = new SortedList<double, double>();
        private SortedList<double, double> _listCalData = new SortedList<double, double>();
        private SortedList<double, double> _listResultData = new SortedList<double, double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddInitialData_Click(object sender, EventArgs e)
        {
            OpenDataFile(dgvInitialData, out _listInitData);
        }

        private void btnAddCalibrateData_Click(object sender, EventArgs e)
        {
            OpenDataFile(dgvCalibrateData, out _listCalData);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            dgvResult.Rows.Clear();
            _listResultData.Clear();

            foreach(var initItem in _listInitData)
            {
                double cal = 0.0;

                for(int i = 0; i < _listCalData.Count; i++)
                {
                    if (initItem.Key < _listCalData.Keys[0] || initItem.Key > _listCalData.Keys[_listCalData.Count - 1])
                    {
                        MessageBox.Show("Не хватает данных коэффициента калибровки или коэффициента усиления");
                        return;
                    }
                    else if (initItem.Key == _listCalData.Keys[i])
                        cal = _listCalData.Values[i];
                    else if (initItem.Key > _listCalData.Keys[i] && initItem.Key < _listCalData.Keys[i + 1])
                        cal = _listCalData.Values[i] + (_listCalData.Values[i + 1] - _listCalData.Values[i]) * Math.Log10(initItem.Key / _listCalData.Keys[i]) / Math.Log10(_listCalData.Keys[i + 1] / _listCalData.Keys[i]);                    
                }

                _listResultData.Add(initItem.Key, initItem.Value + cal);
                dgvResult.Rows.Add(initItem.Key, initItem.Value + cal);
            }
        }

        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            if(_listResultData.Count != 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Файлы таблиц MS-DOS (*.csv)|*.csv|Все файлы (*.*)|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (var dataItem in _listResultData)
                        {
                            sw.WriteLine(dataItem.Key + ";" + dataItem.Value);
                        }
                    }
                }
                
            }
        }

        private void OpenDataFile(DataGridView dgv, out SortedList<double, double> listData)
        {
            listData = new SortedList<double, double>();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Файлы таблиц MS-DOS (*.csv)|*.csv|Все файлы (*.*)|*.*";
            ofd.Multiselect = false;
            ofd.Title = "Выбрать исходные данные";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                StreamReader sr = File.OpenText(filePath);

                string? s = "";

                while ((s = sr.ReadLine()) != null)
                {
                    try
                    {
                        var data = s.Split(';');
                        listData.Add(Convert.ToDouble(data[0]), Convert.ToDouble(data[1]));
                        dgv.Rows.Add(data);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Неверный формат данных");
                    }
                }
                sr.Close();
            }
        }
    }
}
