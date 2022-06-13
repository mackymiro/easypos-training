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

namespace EasyPOS.Forms.Software.TrnStockCount
{
    public partial class TrnStockCountLineDetailImportForm : Form
    {
        TrnStockCountDetailForm _trnStockCountDetailForm = null;
        public TrnStockCountLineDetailImportForm(TrnStockCountDetailForm stockCountDetailForm)
        {
            _trnStockCountDetailForm = stockCountDetailForm;
            InitializeComponent();
        }
        public List<Entities.TrnStockCountLineEntity> stockCountItemList = new List<Entities.TrnStockCountLineEntity>();
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

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

                            stockCountItemList.Add(new Entities.TrnStockCountLineEntity()
                            {
                                Id = 0,
                                StockCountId = _trnStockCountDetailForm.trnStockCountEntity.Id,
                                ItemBarcode = dataWords[0],
                                ItemDescription = dataWords[1],
                                Unit = dataWords[2],
                                Quantity = Convert.ToDecimal(dataWords[3]),
                                Cost = Convert.ToDecimal(dataWords[4]),
                                Amount = Convert.ToDecimal(dataWords[5]),
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
                Controllers.TrnStockCountLineController trnPOSStockCountLineController = new Controllers.TrnStockCountLineController();
                String[] addStockCountLine = trnPOSStockCountLineController.ImportStockCountLine(stockCountItemList);
                if (addStockCountLine[1].Equals("0") == false)
                {
                    _trnStockCountDetailForm.UpdateStockCountLineListDataSource();
                    Close();
                }
                else
                {
                    MessageBox.Show(addStockCountLine[0], "Easy POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
