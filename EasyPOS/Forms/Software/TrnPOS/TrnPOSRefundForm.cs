using EasyPOS.Forms.Software.TrnDisbursement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPOS.Forms.Software.TrnPOS
{
    public partial class TrnPOSRefundForm : Form
    {

        public Entities.TrnDisbursementEntity trnDisbursementEntity;

        public TrnPOSRefundForm(Entities.TrnDisbursementEntity disbursementEntity)
        {
            InitializeComponent();
            trnDisbursementEntity = disbursementEntity;

            GetRemittanceDetail();
        }

        public void GetRemittanceDetail()
        {
            textBoxDisbursementNo.Text = trnDisbursementEntity.DisbursementNumber;
            textBoxPeriodId.Text = Convert.ToString(trnDisbursementEntity.PeriodId);
            textBoxTerminal.Text = Convert.ToString(trnDisbursementEntity.TerminalId);
            textBoxDisbursementDate.Text = trnDisbursementEntity.DisbursementDate;
            textBoxType.Text = trnDisbursementEntity.DisbursementType;
            textBoxPayType.Text = Convert.ToString(trnDisbursementEntity.PayTypeId);
            textBoxAccount.Text = Convert.ToString(trnDisbursementEntity.AccountId);
            textBoxAmount.Text = trnDisbursementEntity.Amount.ToString("#,##0.00");
            textBoxRemarks.Text = trnDisbursementEntity.Remarks;
            checkBoxIsRefund.Checked = trnDisbursementEntity.IsRefund;
            textBoxStockInNo.Text = Convert.ToString(trnDisbursementEntity.StockInId);
            textBoxPreparedBy.Text = Convert.ToString(trnDisbursementEntity.PreparedBy);
            textBoxCheckedBy.Text = Convert.ToString(trnDisbursementEntity.CheckedBy);
            textBoxApprovedBy.Text = Convert.ToString(trnDisbursementEntity.ApprovedBy);
        }

        private void buttonRefund_Click(object sender, EventArgs e)
        {
            new TrnPrintDisbursementForm(trnDisbursementEntity.Id);
        }
    }
}
