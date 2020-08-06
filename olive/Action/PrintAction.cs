using DevExpress.XtraEditors;
using olive.Misc;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olive.Action
{
    class PrintAction
    {
		private static string PADSTR = "!@#";
		///private static string PADSTR2 = "$$$";

		class Send_PrintData
		{
			public string command { get; set; }
			public string data { get; set; }
			public string extra1 { get; set; }   //附加信息1
			public string extra2 { get; set; }   //附加信息2
			public string extra3 { get; set; }   //附加信息3
			public string extra4 { get; set; }   //附加信息4
			public string extra5 { get; set; }   //附加信息5

		}

		/// <summary>
		/// 打印墓位证书
		/// </summary>
		/// <param name="ac001"></param>
		/// <param name="orderId"></param>
		public static void PrintCert(string ac001,int orderId)
        {
			string s_certId = string.Empty;
			string s_position = string.Empty;
			StringBuilder sb_1 = new StringBuilder(200);

			OracleCommand oc_command = new OracleCommand("select * from v_print_cert where ac001 = :ac001", SqlAssist.conn);
			OracleParameter op_ac001 = new OracleParameter("ac001", OracleDbType.Varchar2, 10);
			op_ac001.Direction = ParameterDirection.Input;
			op_ac001.Value = ac001;
			oc_command.Parameters.Add(op_ac001);

			OracleDataReader reader = oc_command.ExecuteReader();
			if (reader.HasRows && reader.Read())
			{
				sb_1.Append(reader["AC001"].ToString() + PADSTR);


				if (reader["PNAME"] == null || reader["PNAME"] is DBNull)
					sb_1.Append("" + PADSTR);								//安葬逝者姓名
				else
					sb_1.Append(reader["PNAME"].ToString() + PADSTR);

				if (reader["PNAME2"] == null || reader["PNAME2"] is DBNull)
					sb_1.Append("" + PADSTR);                               //安葬逝者姓名2
				else
					sb_1.Append(reader["PNAME2"].ToString() + PADSTR);

				if (reader["AC049"] == null || reader["AC049"] is DBNull)
					sb_1.Append("" + PADSTR);                               //购墓日期
				else
					sb_1.Append(string.Format("{0:yyyy-MM-dd}", reader["AC049"]) + PADSTR);

				if (reader["BURYTIME"] == null || reader["BURYTIME"] is DBNull)
					sb_1.Append("" + PADSTR);                               //安葬日期
				else
					sb_1.Append(string.Format("{0:yyyy-MM-dd}", reader["BURYTIME"]) + PADSTR);

				sb_1.Append(reader["AC022"].ToString() + PADSTR);           //墓位售价
				sb_1.Append(reader["AC003"].ToString() + PADSTR);           //购墓人

				if (reader["AC005"] == null || reader["AC005"] is DBNull)
					sb_1.Append("" + PADSTR);                               //联系地址
				else
					sb_1.Append(reader["AC005"].ToString() + PADSTR);

				if (reader["AC050"] == null || reader["AC050"] is DBNull)
					sb_1.Append("" + PADSTR);                               //证书编号
				else
					sb_1.Append(reader["AC050"].ToString() + PADSTR);

				sb_1.Append(reader["HANDLER"].ToString() + PADSTR);			//经办人
				sb_1.Append(reader["POSITION"].ToString() + PADSTR);        //墓穴位置
				sb_1.Append(reader["AC020"].ToString() + PADSTR);			//墓位定价
 
				Send_PrintData printData = new Send_PrintData();
				printData.command = "print_cert";
				printData.data = sb_1.ToString();
				if(orderId > 0)
				{
					printData.extra1 = orderId.ToString();
					printData.extra2 = GetPayRecordPrintData(ac001, orderId);
				}				 
				Frm_main.socket.sendMsg(Tools.ConvertObjectToJson(printData));
			}
			else
			{
				XtraMessageBox.Show("未找到数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			reader.Dispose();
			oc_command.Dispose();
		}
 

        /// <summary>
        /// 打印管理费缴纳记录
        /// </summary>
        /// <param name="fa001"></param>
        public static void PrintPayRecord(string ac001,int orderId)
        {
			Send_PrintData printData = new Send_PrintData();
			printData.command = "payrecord";
			printData.data = "";
 
		    printData.extra1 = orderId.ToString();
			printData.extra2 = GetPayRecordPrintData(ac001, orderId);			 
			Frm_main.socket.sendMsg(Tools.ConvertObjectToJson(printData));			 
		}
		/// <summary>
		/// 打印管理费缴费记录
		/// </summary>
		/// <param name="fa001"></param>
		public static void PrintPayRecord(string fa001)
		{
			string s_ac001 = SqlAssist.ExecuteScalar("select ac001 from fa01 where fa001='" + fa001 + "'").ToString();
			int i_orderId = Convert.ToInt32(SqlAssist.ExecuteScalar("select count(*) from pr01 where ac001 = '" + s_ac001 + "' and pr002 < (select pr002 from pr01 where pr001='" + fa001 + "')"));
			PrintPayRecord(s_ac001, i_orderId + 1);
		}

        /// <summary>
        /// 打印购墓协议
        /// </summary>
        /// <param name="ac001"></param>
        public static void PrintProtocol(string ac001)
        {
			OracleCommand oc_command = new OracleCommand("select * from v_print_protocol where ac001 = :ac001", SqlAssist.conn);
			OracleParameter op_ac001 = new OracleParameter("ac001", OracleDbType.Varchar2, 10);
			op_ac001.Direction = ParameterDirection.Input;
			op_ac001.Value = ac001;
			oc_command.Parameters.Add(op_ac001);

			OracleDataReader reader = oc_command.ExecuteReader();
			if (reader.HasRows && reader.Read())
			{
				string s_szxm = string.Empty;
				StringBuilder sb_1 = new StringBuilder(100);

				sb_1.Append(reader["GUYNAME"].ToString() + PADSTR);     //安葬逝者姓名
				sb_1.Append(reader["AC005"].ToString() + PADSTR );      //联系地址
				//sb_1.Append(" " + PADSTR);                              //bitid
				sb_1.Append(reader["SALEPRICE"].ToString() + PADSTR);   //售价
				sb_1.Append(reader["AC003"].ToString() + PADSTR);       //购墓人
				sb_1.Append(reader["RELATION"].ToString() + PADSTR);    //与购墓人关系
				sb_1.Append(reader["REGION_NAME"].ToString() + PADSTR); //墓区
				sb_1.Append(reader["ROWER_NAME"].ToString() + PADSTR);  //墓区排
				sb_1.Append(reader["BITDESC"].ToString() + PADSTR);     //号位描述				 

				Send_PrintData printData = new Send_PrintData();
				printData.command = "procotol";
				printData.data = sb_1.ToString();
				Frm_main.socket.sendMsg(Tools.ConvertObjectToJson(printData));
			}
			else
			{
				XtraMessageBox.Show("未找到数据!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			reader.Dispose();
			oc_command.Dispose();
		}
		/// <summary>
		/// 获取指定顺序号的缴费打印数据
		/// </summary>
		/// <param name="ac001"></param>
		/// <param name="iorder"></param>
		/// <returns></returns>
		public static string GetPayRecordPrintData(string ac001,int iorder)
		{
			OracleParameter op_ac001 = new OracleParameter("ic_ac001", OracleDbType.Varchar2, 10);
			op_ac001.Direction = ParameterDirection.Input;
			op_ac001.Value = ac001;

			OracleParameter op_order = new OracleParameter("in_order", OracleDbType.Int32);
			op_order.Direction = ParameterDirection.Input;
			op_order.Value = iorder;

			Object re = SqlAssist.ExecuteFunction("pkg_report.fun_GetPayRecordPrintData", new OracleParameter[] { op_ac001, op_order });
			return re.ToString();
		}
		/// <summary>
		/// 获取指定结算流水号的缴费打印数据
		/// </summary>
		/// <param name="fa001"></param>
		/// <returns></returns>
		public static string GetPayRecordPrintData(string fa001)
		{
			OracleParameter op_fa001 = new OracleParameter("ic_fa001", OracleDbType.Varchar2, 10);
			op_fa001.Direction = ParameterDirection.Input;
			op_fa001.Value = fa001; 

			Object re = SqlAssist.ExecuteFunction("pkg_report.fun_GetPayRecordPrintData", new OracleParameter[] { op_fa001 });
			return re.ToString();
		}


	}
}
