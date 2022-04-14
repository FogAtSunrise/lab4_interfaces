using System;
using System.Collections.Generic;
using System.ComponentModel;
using SD = System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace OP_13
{
    public partial class Calculation : Form
    {

        Worker worker = new Worker();
        public Calculation()
        {
            InitializeComponent();
            result.Rows.Add();//////////////////////
         
            result.Rows[0].Cells[0].Value = "Итого";///////////////////////////
            // Нумерация строк в таблице
            for (int i = 0; i < dGV_Calculation.RowCount; i++)
            {
                dGV_Calculation.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }

            // Добавление строк в таблицу
         
            for (int i = 0; i < 3; i++)
            { resultSpravka.Rows.Add(); }//############
            // Запрещаем изменять определенные ячейки в основной форме
          //  dGV_Calculation.Rows[7].ReadOnly = true;
            result.Rows[0].ReadOnly = true;
           
            // Запрещаем изменять определенные ячейки в справке
            /*for (int i = 2; i < dGV_Spravka.RowCount; i++)
            {
                dGV_Spravka.Rows[i].Cells[2].ReadOnly = true;
            }*/


            resultSpravka.Rows[0].Cells[0].Style.BackColor = Color.LightGray;//##############
            resultSpravka.Rows[1].Cells[0].Style.BackColor = Color.LightGray;
            resultSpravka.Rows[2].Cells[0].Style.BackColor = Color.LightGray;

          
          
            resultSpravka.Rows[0].Cells[0].Value = "Итого"; //#####################
            resultSpravka.Rows[1].Cells[0].Value = "Израсходовано согласно контрольному расчету";
            resultSpravka.Rows[2].Cells[0].Value = "Сумма недорасхода";

            // summ();   
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\" + "time_op13_new" + ".xlsx";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
            this.Close();
        }


        private void linkLabelSignatures_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            worker.Show();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            // Если какие-то строки заполнены частично, то пустые ячейки этих строк заполняем нулём
            int i = 0;
            for (i = 0; i < dGV_Calculation.Rows.Count - 1; i++)
            {
                if (dGV_Calculation.Rows[i].Cells[0].Value == null)
                {
                    for (int k = 0; k <= 5; k++)
                        dGV_Calculation.Rows[i].Cells[k].Value = null;
                }
                else
                {
                    for (int k = 2; k <= 5; k++)
                        if (dGV_Calculation.Rows[i].Cells[k].Value == null)
                        {
                            dGV_Calculation.Rows[i].Cells[k].Value = "0";
                        }

                }
            }

            // summ();


            // Заполняем справку

            raschetForSpravka();


            // summ_spravka(sender, e);
        }

        private void raschetForSpravka()
        {
            for (int i = 0; i < dGV_Spravka.Rows.Count-1; i++)
                for (int j = 1; j < dGV_Spravka.Columns.Count; j++)
                {
                    if (Convert.ToString(dGV_Spravka.Rows[i].Cells[j].Value) == "") dGV_Spravka.Rows[i].Cells[j].Value = "0";
                }
            
            // Израсходовано согласно контр. расчёта берем из первой таблицы
            //  dGV_Spravka.Rows[4].Cells[3].Value = result.Rows[0].Cells[4].Value;////////6/6/6/6/6

            resultSpravka.Rows[1].Cells[1].Value = result.Rows[0].Cells[4].Value;////////6/6/6/6/6

            // Сумма = количество * на цену
            /*  dGV_Spravka.Rows[0].Cells[3].Value = Convert.ToSingle(dGV_Spravka.Rows[0].Cells[2].Value) * Convert.ToSingle(dGV_Spravka.Rows[0].Cells[1].Value);
              dGV_Spravka.Rows[1].Cells[3].Value = Convert.ToSingle(dGV_Spravka.Rows[1].Cells[2].Value) * Convert.ToSingle(dGV_Spravka.Rows[1].Cells[1].Value);
              dGV_Spravka.Rows[2].Cells[3].Value = Convert.ToSingle(dGV_Spravka.Rows[2].Cells[2].Value) * Convert.ToSingle(dGV_Spravka.Rows[2].Cells[1].Value);
            */
            double summ = 0;
            for (int i = 0; i < dGV_Spravka.Rows.Count-1; i++)
            { dGV_Spravka.Rows[i].Cells[3].Value = Convert.ToSingle(dGV_Spravka.Rows[i].Cells[2].Value) * Convert.ToSingle(dGV_Spravka.Rows[i].Cells[1].Value);
                summ += Convert.ToSingle(dGV_Spravka.Rows[i].Cells[3].Value);
            }
            /*
            // Итого
            dGV_Spravka.Rows[3].Cells[3].Value = Convert.ToSingle(dGV_Spravka.Rows[0].Cells[3].Value) +
               Convert.ToSingle(dGV_Spravka.Rows[1].Cells[3].Value) +
               Convert.ToSingle(dGV_Spravka.Rows[2].Cells[3].Value);*/

            resultSpravka.Rows[0].Cells[1].Value = summ;

            for (int i = 0; i < 3; i++)
                if (Convert.ToString(resultSpravka.Rows[i].Cells[1].Value) == "") resultSpravka.Rows[i].Cells[1].Value = "0";

            resultSpravka.Rows[2].Cells[1].Value = Convert.ToSingle(resultSpravka.Rows[0].Cells[1].Value) - Convert.ToSingle(resultSpravka.Rows[1].Cells[1].Value);
           
            

        }
        private void numb_org(object sender, EventArgs e)
        {

           // textBoxOKDP.Text = (comboBoxOrganization.SelectedIndex + 1).ToString();
            //textBoxOKPO.Text = (comboBoxOrganization.SelectedIndex + 1).ToString() + "." + (comboBoxStructSubdivision.SelectedIndex + 1).ToString();
        
            string change = (comboBoxOrganization.SelectedIndex + 1).ToString();
            if (change == "1")
                textBoxOKPO.Text = "1004323";
            else if (change == "2")
                textBoxOKPO.Text = "2094032";
            else if (change == "3")
                textBoxOKPO.Text = "3129867";
            else if (change == "4")
                textBoxOKPO.Text = "4728586";
            /*  if (textBoxOKDP.Text == "1")
                  textBoxTYPEoPERATION.Text = "304";
              if (textBoxOKDP.Text == "2")
                  textBoxTYPEoPERATION.Text = "504";
            */
        }

        private void numb_org1(object sender, EventArgs e)
        {
          
        }


        
        private void summ_spravka(object sender, DataGridViewCellEventArgs e)
        {

            raschetForSpravka();

            //
        }

        private void summ_izr(object sender, DataGridViewCellEventArgs e)
        {
            //Считаем сколько израсходовано
            int i;

            for (int j = 0; j < dGV_Calculation.Rows.Count - 5; j++)
            {
                float summa = 0;

                for (i = 2; i < dGV_Calculation.ColumnCount - 1; i++)
                    if (dGV_Calculation.Rows[j].Cells[i].Value != null)
                    {
                        float value = Convert.ToSingle(dGV_Calculation.Rows[j].Cells[i].Value);
                        summa += value;
                    }
                dGV_Calculation.Rows[j].Cells[i].Value = summa;
                
            }


        }

        private void summ(object sender, DataGridViewCellEventArgs e)
        {
            // Считаем ИТОГО 
            int i;
            for (int j = 2; j < dGV_Calculation.ColumnCount; j++)
            {
                float summa = 0;

                for (i = 0; i < dGV_Calculation.Rows.Count - 1; i++)
                    if (dGV_Calculation.Rows[i].Cells[j].Value != null)
                    {
                        float value = Convert.ToSingle(dGV_Calculation.Rows[i].Cells[j].Value);
                        summa += value;
                    }
               // dGV_Calculation.Rows[i].Cells[j].Value = summa;
                result.Rows[0].Cells[j-1].Value = summa;
            }
        }
        private void ExportToExcel()
        {
            Excel.Application exApp = new Excel.Application();

            //Если временный файл существует, открываем его, если нет, то сразу сохранянем в новую справку
            string fileName = Application.StartupPath + "\\" + "time_op13_new" + ".xlsx";
            //fileName_new = Application.StartupPath + "\\" + "op13_new" + ".xlsx";
            FileInfo fileInf = new FileInfo(fileName);
            if (!fileInf.Exists)
            {
                fileName = Application.StartupPath + "\\" + "op13" + ".xlsx";
            }

            //Получаем набор ссылок на объекты Workbook
            Excel.Workbook excelappworkbooks = exApp.Workbooks.Open(fileName,
              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
              Type.Missing, Type.Missing, Type.Missing, Type.Missing,
              Type.Missing, Type.Missing);

            // Получить первый рабочий лист.
            Excel.Worksheet excelsheets = (Excel.Worksheet)excelappworkbooks.Sheets[1];

            //заполняем шапку
            excelsheets.Cells[16, "Q"] = textBoxNumberDoc.Text;
            excelsheets.Cells[16, "AC"] = dateTimePicker2.Text;
            excelsheets.Cells[16, "AG"] = dateTimePicker3.Text;
            excelsheets.Cells[16, "W"] = dateTimePicker1.Text;
            excelsheets.Cells[6, "A"] = comboBoxOrganization.Text;
            excelsheets.Cells[8, "A"] = comboBoxStructSubdivision.Text;

     
                excelsheets.Cells[6, "AQ"] = textBoxOKPO.Text;

                excelsheets.Cells[9, "AQ"] = textBoxOKDP.Text;
           
                excelsheets.Cells[10, "AQ"] = textBoxTYPEoPERATION.Text;
            
            // заполняем данные из datagridview
            for (int i = 0, k = 25; i < dGV_Calculation.Rows.Count-1; i++, k++)
            {
                if (dGV_Calculation.Rows[i].Cells[0].Value != null)
                {
                    excelsheets.Cells[k, "A"] = i+1;
                    excelsheets.Cells[k, "E"] = dGV_Calculation.Rows[i].Cells[0].Value;
                    excelsheets.Cells[k, "S"] = dGV_Calculation.Rows[i].Cells[1].Value;
                    excelsheets.Cells[k, "W"] = dGV_Calculation.Rows[i].Cells[2].Value;
                    excelsheets.Cells[k, "AD"] = dGV_Calculation.Rows[i].Cells[3].Value;
                    excelsheets.Cells[k, "AK"] = dGV_Calculation.Rows[i].Cells[4].Value;
                    excelsheets.Cells[k, "AS"] = dGV_Calculation.Rows[i].Cells[5].Value;
                }
            }
            excelsheets.Cells[32, "W"] = result.Rows[0].Cells[1].Value;
            excelsheets.Cells[32, "AD"] = result.Rows[0].Cells[2].Value;
            excelsheets.Cells[32, "AK"] = result.Rows[0].Cells[3].Value;
            excelsheets.Cells[32, "AS"] = result.Rows[0].Cells[4].Value;

            // заполняем справку из datagridview и textBox
            //  excelsheets.Cells[40, "C"] = textBoxRubl1.Text;
            // excelsheets.Cells[40, "T"] = textBoxCopeica1.Text;

            string str1 = " Продано блюд, в которые включено ",
                str2 = ", стоимостью ",
                str3 = "руб. на блюдо";

            for (int i = 0, k=39; i < dGV_Spravka.Rows.Count - 1; i++, k++)
                {

                excelsheets.Cells[k, "A"] = str1 + dGV_Spravka.Rows[i].Cells[0].Value
                                           + str2 + dGV_Spravka.Rows[i].Cells[1].Value + str3;

                excelsheets.Cells[k, "AE"] = dGV_Spravka.Rows[i].Cells[2].Value;
                excelsheets.Cells[k, "AL"] = dGV_Spravka.Rows[i].Cells[3].Value;
            }
           /* excelsheets.Cells[40, "C"] = dGV_Spravka.Rows[0].Cells[1].Value;
            excelsheets.Cells[43, "C"] = dGV_Spravka.Rows[1].Cells[1].Value;
            excelsheets.Cells[46, "C"] = dGV_Spravka.Rows[2].Cells[1].Value;

            excelsheets.Cells[39, "T"] = dGV_Spravka.Rows[0].Cells[0].Value;
            excelsheets.Cells[42, "T"] = dGV_Spravka.Rows[1].Cells[0].Value;
            excelsheets.Cells[45, "T"] = dGV_Spravka.Rows[2].Cells[0].Value;
           

            excelsheets.Cells[39, "AE"] = dGV_Spravka.Rows[0].Cells[2].Value;
              excelsheets.Cells[39, "AL"] = dGV_Spravka.Rows[0].Cells[3].Value;

              excelsheets.Cells[42, "AE"] = dGV_Spravka.Rows[1].Cells[2].Value;
              excelsheets.Cells[42, "AL"] = dGV_Spravka.Rows[1].Cells[3].Value;

            excelsheets.Cells[45, "AE"] = dGV_Spravka.Rows[2].Cells[2].Value;
            excelsheets.Cells[45, "AL"] = dGV_Spravka.Rows[2].Cells[3].Value;
*/
           
              excelsheets.Cells[48, "AL"] = resultSpravka.Rows[0].Cells[1].Value;
              excelsheets.Cells[49, "AL"] = resultSpravka.Rows[1].Cells[1].Value;
              excelsheets.Cells[50, "AL"] = resultSpravka.Rows[2].Cells[1].Value;

             
            string fileName_new = String.Empty;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName_new = saveFileDialog1.FileName;
            }
            else
                return;

            //сохраняем Workbook
            fileInf = new FileInfo(fileName_new);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
            excelappworkbooks.SaveAs(fileName_new, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            saveFileDialog1.Dispose();

            exApp.Quit();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            calculate_Click(sender, e);
            ExportToExcel();
            string path = Application.StartupPath + "\\" + "time_op13_new" + ".xlsx";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGV_Calculation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGV_Calculation_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                
               
                  //  (e.Control as ComboBox).DropDownStyle = ComboBoxStyle.DropDown;
                 //   (e.Control as ComboBox).AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                
            

                (e.Control as ComboBox).SelectedIndexChanged -= new EventHandler(cmb_SelectedIndexChanged);
                (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);
            }
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 0;

            if ((sender as ComboBox).SelectedItem.ToString() == "Соль")
                value = 1;
            else
            if ((sender as ComboBox).SelectedItem.ToString() == "Специи")
                value = 3;
            else
            if ((sender as ComboBox).SelectedItem.ToString() == "Горчица")
                value = 4;
            dGV_Calculation[1, dGV_Calculation.CurrentCellAddress.Y].Value = value;
      
        }
    }
}