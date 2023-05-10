using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_inhoadonthanhtoan : Form
    {
        private double thanhtienphong;
        public frm_inhoadonthanhtoan(double thanhtienphong)
        {
            InitializeComponent();
            this.thanhtienphong = thanhtienphong;
        }

        private void frm_inhoadonthanhtoan_Load(object sender, EventArgs e)
        {
            // Create a list of parameters to pass to the report
            List<ReportParameter> parameters = new List<ReportParameter>();
            // Add a parameter to the list
            parameters.Add(new ReportParameter("p_thanhtienphong", thanhtienphong.ToString()));
            // Set the parameters for the report
            this.reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.DataTable1TableAdapter.Fill(this.DataSet1.DataTable1, 1101);
            // Refresh the report viewer
            this.reportViewer1.RefreshReport();
        }
    }
}
