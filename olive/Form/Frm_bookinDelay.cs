using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using olive.BaseObject;
using Oracle.ManagedDataAccess.Client;
using olive.Misc;
using olive.Action;

namespace olive.Form
{
	public partial class Frm_bookinDelay : MyDialog
	{
		private string s_bk001 = string.Empty;
		public Frm_bookinDelay()
		{
			InitializeComponent();
		}

		private void Frm_bookinDelay_Load(object sender, EventArgs e)
		{
			s_bk001 = this.swapdata["bk001"].ToString();
			using (OracleDataReader reader = SqlAssist.ExecuteReader("select * from bk01 where bk001='" + s_bk001 + "'"))
			{
				if (reader.Read())
				{
					be_position.Text = MiscAction.GetTombPosition(reader["BI001"].ToString());
				}
			}
			
		}
	}
}