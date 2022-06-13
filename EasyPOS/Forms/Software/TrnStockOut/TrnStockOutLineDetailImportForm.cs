﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnStockOut
{
    public partial class TrnStockOutLineDetailImportForm : Form
    {
        TrnStockOutDetailForm _trnStockOutDetailForm = null;
        public TrnStockOutLineDetailImportForm(TrnStockOutDetailForm stockOutDetailForm)
        {
            InitializeComponent();
            _trnStockOutDetailForm = stockOutDetailForm;
        }
        public List<Entities.TrnStockOutLineEntity> stockOutItemList = new List<Entities.TrnStockOutLineEntity>();
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult openFileDialogImportCSVResult = openFileDialogImportCSV.ShowDialog();
                if (openFileDialogImportCSVResult == DialogResult.OK)
                {
                    textBoxFileName.Text = openFileDialogImportCSV.FileName;

                    string[] lines = File.ReadAllLines(textBoxFileName.Text);
                    if (lines.Length > 0)
                    {
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] dataWords = lines[i].Split(',');

                            stockOutItemList.Add(new Entities.TrnStockOutLineEntity()
                            {
                                Id = 0,
                                StockOutId = _trnStockOutDetailForm.trnStockOutEntity.Id,
                                ItemBarcode = dataWords[0],
                                ItemDescription = dataWords[1],
                                Unit = dataWords[2],
                                Quantity = Convert.ToDecimal(dataWords[3]),
                                Cost = Convert.ToDecimal(dataWords[4]),
                                Price = Convert.ToDecimal(dataWords[5]),
                                Amount = Convert.ToDecimal(dataWords[6])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                Controllers.TrnStockOutLineController trnPOSStockOutLineController = new Controllers.TrnStockOutLineController();
                String[] addStockInLine = trnPOSStockOutLineController.ImportStockOutLine(stockOutItemList);
                if (addStockInLine[1].Equals("0") == false)
                {
                    _trnStockOutDetailForm.UpdateStockOutLineListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(addStockInLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
