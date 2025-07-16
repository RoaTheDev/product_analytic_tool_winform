namespace Tonaire_Report
{
    partial class SaleReportForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startDateVal = new DateTimePicker();
            endDateVal = new DateTimePicker();
            startDateLb = new Label();
            label1 = new Label();
            productNameVal = new Panel();
            exportPdfBtn = new Button();
            generateReportBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            productNameFilterField = new TextBox();
            productNameVal.SuspendLayout();
            SuspendLayout();
            // 
            // startDateVal
            // 
            startDateVal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDateVal.Location = new Point(52, 169);
            startDateVal.Name = "startDateVal";
            startDateVal.Size = new Size(315, 34);
            startDateVal.TabIndex = 0;
            // 
            // endDateVal
            // 
            endDateVal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            endDateVal.Location = new Point(398, 169);
            endDateVal.Name = "endDateVal";
            endDateVal.Size = new Size(315, 34);
            endDateVal.TabIndex = 1;
            // 
            // startDateLb
            // 
            startDateLb.AutoSize = true;
            startDateLb.BackColor = SystemColors.MenuHighlight;
            startDateLb.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startDateLb.ForeColor = Color.White;
            startDateLb.Location = new Point(145, 119);
            startDateLb.Name = "startDateLb";
            startDateLb.Size = new Size(125, 31);
            startDateLb.TabIndex = 2;
            startDateLb.Text = "Start Date ";
            startDateLb.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(497, 119);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 3;
            label1.Text = "End Date";
            // 
            // productNameVal
            // 
            productNameVal.BackColor = SystemColors.MenuHighlight;
            productNameVal.Controls.Add(exportPdfBtn);
            productNameVal.Controls.Add(generateReportBtn);
            productNameVal.Controls.Add(label4);
            productNameVal.Controls.Add(startDateLb);
            productNameVal.Controls.Add(label1);
            productNameVal.Controls.Add(label3);
            productNameVal.Controls.Add(label2);
            productNameVal.Controls.Add(endDateVal);
            productNameVal.Controls.Add(productNameFilterField);
            productNameVal.Controls.Add(startDateVal);
            productNameVal.Location = new Point(-4, 2);
            productNameVal.Name = "productNameVal";
            productNameVal.Size = new Size(799, 448);
            productNameVal.TabIndex = 4;
            productNameVal.Paint += panel1_Paint;
            // 
            // exportPdfBtn
            // 
            exportPdfBtn.BackColor = Color.Turquoise;
            exportPdfBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            exportPdfBtn.FlatStyle = FlatStyle.Popup;
            exportPdfBtn.Font = new Font("20th Century Font", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportPdfBtn.ForeColor = Color.White;
            exportPdfBtn.Location = new Point(398, 328);
            exportPdfBtn.Name = "exportPdfBtn";
            exportPdfBtn.Size = new Size(154, 49);
            exportPdfBtn.TabIndex = 9;
            exportPdfBtn.Text = "Export";
            exportPdfBtn.UseVisualStyleBackColor = false;
            exportPdfBtn.Click += exportPdfBtn_Click;
            // 
            // generateReportBtn
            // 
            generateReportBtn.BackColor = Color.Lime;
            generateReportBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            generateReportBtn.FlatStyle = FlatStyle.Popup;
            generateReportBtn.Font = new Font("20th Century Font", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generateReportBtn.ForeColor = Color.White;
            generateReportBtn.Location = new Point(213, 328);
            generateReportBtn.Name = "generateReportBtn";
            generateReportBtn.Size = new Size(154, 49);
            generateReportBtn.TabIndex = 8;
            generateReportBtn.Text = "Generate";
            generateReportBtn.UseVisualStyleBackColor = false;
            generateReportBtn.Click += generateReportBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.MenuHighlight;
            label4.Font = new Font("Zurich Condensed", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(269, 60);
            label4.Name = "label4";
            label4.Size = new Size(229, 32);
            label4.TabIndex = 7;
            label4.Text = "Product Sale Report";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.MenuHighlight;
            label3.Font = new Font("Zurich Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(294, 7);
            label3.Name = "label3";
            label3.Size = new Size(184, 53);
            label3.TabIndex = 6;
            label3.Text = "TONAIRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.MenuHighlight;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 262);
            label2.Name = "label2";
            label2.Size = new Size(235, 31);
            label2.TabIndex = 5;
            label2.Text = "Product Name Filter :";
            // 
            // productNameFilterField
            // 
            productNameFilterField.Location = new Point(337, 259);
            productNameFilterField.Multiline = true;
            productNameFilterField.Name = "productNameFilterField";
            productNameFilterField.Size = new Size(310, 34);
            productNameFilterField.TabIndex = 0;
            // 
            // SaleReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productNameVal);
            Name = "SaleReportForm";
            Text = "Form1";
            productNameVal.ResumeLayout(false);
            productNameVal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker startDateVal;
        private DateTimePicker endDateVal;
        private Label startDateLb;
        private Label label1;
        private Panel productNameVal;
        private Label label2;
        private TextBox productNameFilterField;
        private Label label4;
        private Label label3;
        private Button generateReportBtn;
        private Button exportPdfBtn;
    }
}
