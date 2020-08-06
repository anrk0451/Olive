using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using olive.BaseObject;
using Oracle.ManagedDataAccess.Client;
using olive.Misc;

namespace olive.BusinessObject
{
	public partial class Report_TombStat : BaseBusiness
	{
		private DataTable dt_source = new DataTable();
		private OracleDataAdapter souAdapter = new OracleDataAdapter("select * from v_report_tombStat where to_char(ac049,'yyyy-mm-dd') between :begin and :end", SqlAssist.conn);

		private OracleParameter op_begin = new OracleParameter("begin", OracleDbType.Varchar2, 10);
		private OracleParameter op_end = new OracleParameter("end", OracleDbType.Varchar2, 10);

		public Report_TombStat()
		{
			InitializeComponent();
		}

		private void Report_TombStat_Load(object sender, EventArgs e)
		{
			bi_begin.EditValue = Tools.GetServerDate();
			bi_begin.EditValue = Convert.ToDateTime(bi_begin.EditValue.ToString()).AddMonths(-1).ToString("yyyy-MM-dd");

		}
	}
}
