using DevExpress.XtraPrinting;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonaire_Report.Reports;
using Tonaire_Report.Services;
namespace Tonaire_Report
{
    public partial class SaleReportForm : Form
    {
        private readonly SaleService _saleService;
        public SaleReportForm()
        {
            InitializeComponent();
            _saleService = new SaleService();
            startDateVal.Value = DateTime.Today.AddDays(-30);
            endDateVal.Value = DateTime.Today;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void generateReportBtn_Click(object sender, EventArgs e)
        {
            if (startDateVal.Value > endDateVal.Value)
            {
                MessageBox.Show("End date must be greater than or equal to start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {

                string? productName = productNameFilterField.Text ?? null;
                var salesData = await _saleService.GetSaleDataFilterByDatesAndNameAsync(
                    startDateVal.Value, endDateVal.Value, productName);

                if (salesData == null || !salesData.Any())
                {
                    MessageBox.Show(
                 productName == null
                     ? "No results found for the selected date range."
                     : $"No results found for the selected date range and product name : {productName}.",
                 "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                var saleReport = new SaleReport();
                saleReport.DataSource = salesData;
                saleReport.Parameters["StartDate"].Value = startDateVal.Value;
                saleReport.Parameters["EndDate"].Value = endDateVal.Value;
                ReportPrintTool printTool = new ReportPrintTool(saleReport);
                printTool.ShowPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void exportPdfBtn_Click(object sender, EventArgs e)
        {
            if (startDateVal.Value > endDateVal.Value)
            {
                MessageBox.Show("End date must be greater than or equal to start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string? productName = productNameFilterField.Text ?? null;
                var salesData = await _saleService.GetSaleDataFilterByDatesAndNameAsync(
                    startDateVal.Value, endDateVal.Value, productName);
                if (salesData == null || !salesData.Any())
                {
                    MessageBox.Show(
                        productName == null
                            ? "No results found for the selected date range."
                            : $"No results found for the selected date range and product name : {productName}.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var saleReport = new SaleReport();
                saleReport.DataSource = salesData;
                saleReport.Parameters["StartDate"].Value = startDateVal.Value;
                saleReport.Parameters["EndDate"].Value = endDateVal.Value;

                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveDialog.FileName = $"SalesReport_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        saleReport.ExportToPdf(saveDialog.FileName);
                        MessageBox.Show($"Report exported to {saveDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
