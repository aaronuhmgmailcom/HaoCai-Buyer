﻿namespace Emedchina.TradeAssistant.Client.Order.OrderSaler
{
    partial class OrderNoConfirmPrint
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderNoConfirmPrint));
            this.SalerOrderItemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SalerOrderItemModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SalerOrderItemModelBindingSource
            // 
            this.SalerOrderItemModelBindingSource.DataSource = typeof(Emedchina.TradeAssistant.Model.Order.SalerOrder.SalerOrderItemModel);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Emedchina_TradeAssistantSaler_Model_Order_SalerOrder_SalerOrderItemModel";
            reportDataSource1.Value = this.SalerOrderItemModelBindingSource;
            reportDataSource2.Name = "SalerReturnPrint_dtSalerReturnPrint";
            reportDataSource2.Value = this.SalerOrderItemModelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Emedchina.TradeAssistant.Client.Print.ReportNoConfirmList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 507);
            this.reportViewer1.TabIndex = 0;
            // 
            // OrderNoConfirmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 507);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderNoConfirmPrint";
            this.Text = "打印";
            this.Load += new System.EventHandler(this.OrderNoConfirmPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalerOrderItemModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalerOrderItemModelBindingSource;
    }
}