#region Header
/*****************************************************************************
 * Copyright (c)  Emedchina 2006
 * $Header: /TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order/SyncForm.cs 27    06-10-31 16:54 Liangxy $ 
 * $Author: Liangxy $ <a href="mailto:sunhongliang@hotmail.com">孙洪亮(sunhl)</a>
 * $Revision: 27 $
 * $Date: 06-10-31 16:54 $
 * $History: SyncForm.cs $
 * 
 * *****************  Version 27  *****************
 * User: Liangxy      Date: 06-10-31   Time: 16:54
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 26  *****************
 * User: Caojie       Date: 06-10-19   Time: 10:28
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 25  *****************
 * User: Caojie       Date: 06-10-19   Time: 10:27
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 24  *****************
 * User: Caojie       Date: 06-10-18   Time: 17:09
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 23  *****************
 * User: Caojie       Date: 06-10-18   Time: 15:04
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 22  *****************
 * User: Liangxy      Date: 06-09-25   Time: 10:41
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 21  *****************
 * User: Liangxy      Date: 06-09-21   Time: 17:13
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 20  *****************
 * User: Liangxy      Date: 06-09-20   Time: 17:09
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 19  *****************
 * User: Caojie       Date: 06-09-18   Time: 14:10
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 18  *****************
 * User: Caojie       Date: 06-09-18   Time: 13:15
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 17  *****************
 * User: Caojie       Date: 06-09-15   Time: 17:39
 * Updated in $/TradeAssistant1.2.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 15  *****************
 * User: Sunhl        Date: 06-09-04   Time: 15:53
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 14  *****************
 * User: Sunhl        Date: 06-09-04   Time: 10:07
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 修改增量缓存
 * 
 * *****************  Version 13  *****************
 * User: Panyj        Date: 06-07-28   Time: 14:30
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 12  *****************
 * User: Panyj        Date: 06-07-28   Time: 10:12
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 11  *****************
 * User: Shangfu      Date: 06-07-04   Time: 17:17
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 10  *****************
 * User: Shangfu      Date: 06-07-04   Time: 16:19
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 9  *****************
 * User: Liangxy      Date: 06-07-04   Time: 16:19
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 8  *****************
 * User: Tangsj       Date: 06-06-29   Time: 18:24
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 7  *****************
 * User: Liangxy      Date: 06-06-29   Time: 16:50
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 6  *****************
 * User: Sunhl        Date: 06-06-28   Time: 17:27
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 同步完成后，自动关闭。
 * 
 * *****************  Version 5  *****************
 * User: Sunhl        Date: 06-06-28   Time: 15:57
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 4  *****************
 * User: Sunhl        Date: 06-06-28   Time: 10:34
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 3  *****************
 * User: Sunhl        Date: 06-06-27   Time: 16:49
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 2  *****************
 * User: Sunhl        Date: 06-06-27   Time: 15:26
 * Updated in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 * 
 * *****************  Version 1  *****************
 * User: Sunhl        Date: 06-06-27   Time: 15:06
 * Created in $/TradeAssistant.root/TradeAssistant/TradeAssistant/Order
 ********************************************************************************/
#endregion

#region using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using Emedchina.Commons.Data;
using Emedchina.TradeAssistant.Client;

using Emedchina.TradeAssistant.Client.Common;
using Emedchina.TradeAssistant.Client.DAL.Sync;
using Emedchina.Commons;
using Emedchina.TradeAssistant.Model.User;
using System.Xml;
using System.ServiceProcess;
using Emedchina.TradeAssistant.Client.Base;
using DevExpress.XtraEditors;
using Emedchina.TradeAssistant.Client.DAL.Order.BuyerOrder;
using Emedchina.TradeAssistant.Model.User;
using Emedchina.TradeAssistant.Client.BLL.Sync;
#endregion

//8月底修改了DoSyncAync方法,添加了Increment和Sync方法.用于改变缓存策略.
namespace Emedchina.TradeAssistant.Client.UI.PublicModule
{
    /// <summary>
    /// 缓存同步界面
    /// </summary>
    public partial class SyncForm : BaseForm
    {
        private int progressNum = 0;
        private DateTime dateTime0, dateTime1;
        private static bool isStart = true;
        private bool flag;
        private bool compressFlg = true;
        public delegate void treeinvoke();
        private bool TimeContinue = true;
        private int Selected;            //此同步项目是否被选定
        private string Pub_tablename;       //在工作状态中显示当前同步项目表名
        private string ReadFlag;            //读分离标志
        Boolean IsCvsSync;                  //是否使用cvs方法同步
        private int curr_rows;              //当前同步项目被更新的行数
        private string curr_time;           //每个同步项目用时
        private string logFlag;
        private int Total_rows;             //更新总行数
        private int Total_time;　           //总用时
        private int curr_row;               //当前同步项目所在的行
        private bool overFlag;               //同步完成标志
        /// <summary>
        /// Initializes a new instance of the <see cref="T:SyncForm"/> class.
        /// </summary>
        public SyncForm()
        {
            InitializeComponent();
        }
        public SyncForm(bool flg)
        {
            InitializeComponent();
            compressFlg = flg;
        }

        /// <summary>
        /// Handles the DoWork event of the SyncBackgroundWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
        private void SyncBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            dateTime0 = DateTime.Now;
            BackgroundWorker worker = sender as BackgroundWorker;
            flag = DoSyncAync(worker, e);
            
        }

        //not used
        /// <summary>
        /// Handles the ProgressChanged event of the SyncBackgroundWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.ComponentModel.ProgressChangedEventArgs"/> instance containing the event data.</param>
        private void SyncBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.SyncProgressBar.Text = e.ProgressPercentage.ToString();
        }

        /// <summary>
        /// Handles the RunWorkerCompleted event of the SyncBackgroundWorker control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.ComponentModel.RunWorkerCompletedEventArgs"/> instance containing the event data.</param>
        private void SyncBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!flag)
            {
                XtraMessageBox.Show("同步数据出错，请重新同步！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                curr_rows = -1;
                listView1.Invoke(new treeinvoke(UpdatelistView2));
            }
            this.progressTimer.Enabled = false;
            this.progressNum = 100;
            this.SyncProgressBar.Text = "100";


            //按钮
            WorkDoneStatus(flag);
            //this.Close();
            //MessageBox.Show(string.Format("{0} tables.",e.Result));

        }

        /// <summary>
        /// Does the sync aync.
        /// 通过调用CacheControl中设置缓存的方法实现。具体的缓存获取在CacheControl中维护。
        /// </summary>
        /// <param name="worker">The worker.</param>
        /// <param name="e">The <see cref="T:System.ComponentModel.DoWorkEventArgs"/> instance containing the event data.</param>
        /// <returns>缓存中的Table个数</returns>
        /// <remarks>没有考虑只在本地序列化但不进行增量更新的情况,没有意义</remarks>
        private bool DoSyncAync(BackgroundWorker worker, DoWorkEventArgs e)
        {
            return Sync();

        }

        //复制模板库文件,生成临时文件
        public static void CopyDB(string TemplateFileName, string TempFileName)
        {
            try
            {
                //ServiceController[] sl = ServiceController.GetServices();
                //string[] sln = new string[sl.Length];
                //int i = 0;
                //foreach (ServiceController sc in sl)
                //{
                //    sln[i] = sc.ServiceName;
                //    i++;
                //}
                //ServiceController serviceController1 = new ServiceController();

                //serviceController1.ServiceName = "MSSQL$SQLEXPRESS";
                //serviceController1.MachineName = ".";

                //if (serviceController1.Status == ServiceControllerStatus.Running)
                //{
                //    serviceController1.Stop();
                //}

                //如果临时库文件存在，作删除
                if (File.Exists(TempFileName))
                {
                    System.IO.File.Delete(TempFileName);
                }
                System.Threading.Thread.Sleep(2000);
                System.IO.File.Copy(TemplateFileName, TempFileName,true);
                System.IO.File.Copy(TemplateFileName.Replace(".mdf", "_log.LDF"), TempFileName.Replace(".mdf", "_log.LDF"), true);
                //ClientSyncDataDAO syncDao = ClientSyncDataDAO.GetInstance("ClientTempDB");
                //syncDao.CopyDB(TemplateFileName, TempFileName);
                //syncDao.CloseConntion();
                //System.Threading.Thread.Sleep(1000);

                //if (serviceController1.Status == ServiceControllerStatus.Stopped)
                //{
                //    serviceController1.Start();
                //}
                try
                {
                    //FileControl.CompactAccessDB(ClientConfiguration.LocalDBFile);
                    //ClientSession.GetInstance()["CompressFlg"] = false;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("此操作系统不支持压缩数据库", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region 同步操作时更新
        /// <summary>
        /// 更新状态
        /// </summary>
        private void UpdateStart()
        {
            DataRow dr = gridView1.GetDataRow(0);
            gridView1.SelectRow(0);
            Selected = gridView1.FocusedRowHandle;
            if (Selected==0)
            {                
                msgLabel.Text = "正在上传本地数据......";
                dr[0] = "1";
                TimeContinue = true;
            }
            else
            {
                TimeContinue = false;
            }
        }

        /// <summary>
        /// 同步每表前时更新显示
        /// </summary>
        private void UpdatelistView1()
        {
            gridView1.SelectRow(curr_row);
            gridView1.FocusedRowHandle = curr_row;
            DataRow dr = gridView1.GetDataRow(curr_row);
            Pub_tablename = dr[4].ToString();
            ReadFlag = dr[6].ToString();
            logFlag = dr[5].ToString();
            Selected = gridView1.FocusedRowHandle;
            if (Selected > -1)
            {
                dr[0] = "1";
                msgLabel.Text = "正在" + dr[1].ToString() + "......";
            }
        }

        /// <summary>
        /// 同步每表后时更新显示
        /// </summary>
        private void UpdatelistView2()
        {
            DataRow dr = gridView1.GetDataRow(curr_row);
            dr[2] = curr_rows.ToString();
            dr[3] = curr_time;
            if (curr_rows == -1)
                dr[0] = "3";
            else
                dr[0] = "2";
            
        }



        #endregion

        #region 同步
        /// <summary>
        /// Syncs this instance.
        /// </summary>
        private bool Sync()
        {

            bool returnvalue = true;
            string filePath;
            //FileControl.CompactAccessDB(ClientConfiguration.TmpDBFile);

            //删除的记录数
            int rows = 0;
            //上传数据操作---------------------------------------------------------
            listView1.Invoke(new treeinvoke(UpdateStart));
            if (this.chkUpload.Checked && chkUpload.Enabled)
            {
                List<string> InvalidList = null;

                if (EmedFunc.GetLocalPersonCfgPath().EndsWith("\\"))
                    filePath = EmedFunc.GetLocalPersonCfgPath() + "db\\TradeAssistant.mdf";
                else
                    filePath = EmedFunc.GetLocalPersonCfgPath() + "\\db\\TradeAssistant.mdf";
                if (File.Exists(filePath))
                {
                    bool flag = new ClientUploadBLL().UploadData(false,out InvalidList, out rows);
                    if (!flag)
                    {
                        //XtraMessageBox.Show("本地数据上传失败，请重试", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rows = -1;
                        return false;
                    }
                }
            }
            curr_rows = rows;
            listView1.Invoke(new treeinvoke(UpdatelistView2));
            //---------------------------------------------------------------------
            DateTime Time_Star, Time_End;
            //获取买方ID
            //string buyerId = ClientSession.GetInstance().CurrentUser.UserOrg.Reg_org_id;
            //获取用户ID
            //string userId = ClientSession.GetInstance().CurrentUser.UserInfo.Id;

            //获取当前用户对象
            LogedInUser CurrentUser = base.CurrentUser;

            string userId = base.CurrentUserId;
            string orgId = base.CurrentUserOrgId;
            int highId = base.CurrentUserHighID;

            //建立同步dao对象，在整个同步过程中只建立一次数据库连接
            ClientSyncDataDAO syncDao = ClientSyncDataDAO.GetInstance("ClientTempDB");
            Total_rows = Total_rows + curr_rows;
            //if (!this.rbAdd.Checked && csvFlag.Checked)
                //syncDao.OpenADShell();
            for (int i = 1; i < gridView1.RowCount; i++)
            {
                //timer_num = 0;
                curr_row = i;
                progressNum = 0;
                Time_Star = DateTime.Now;
                listView1.Invoke(new treeinvoke(UpdatelistView1));

                curr_rows = 0;
                try
                {
                    if (Selected > -1 && i != gridView1.RowCount - 1)
                    {
                        if (this.radioGroupSyncType.EditValue.Equals("2"))
                        {
                            //增量同步
                            curr_rows = syncDao.AllIncrementOneSync(CurrentUser, Pub_tablename, logFlag);
                        }
                        else
                        {
                            //全同步
                            curr_rows = syncDao.AllSyncOneData(CurrentUser, Pub_tablename);
                            
                        }
                        //System.Threading.Thread.Sleep(1000);
                    }

                    if (i == gridView1.RowCount - 1)
                    {
                        syncDao.OpenADShell();
                        syncDao.CompressDB(ClientConfiguration.TmpDBFile);
                        syncDao.CloseADShell();
                    }
                    
                }
                catch (Exception ex)
                {
                    returnvalue = false;
                }

                Time_End = DateTime.Now;
                TimeSpan timeSpan = Time_End.Subtract(Time_Star);
                int seconds = Convert.ToInt16(timeSpan.TotalSeconds);
                curr_time = new ClientSyncBLL().SecondToTimeStr(seconds);
                listView1.Invoke(new treeinvoke(UpdatelistView2));
                if (curr_rows != -1)
                    Total_rows = Total_rows + curr_rows;
                Total_time = Total_time + seconds;
            }
            //if (!this.rbAdd.Checked && csvFlag.Checked)
                //syncDao.CloseADShell();
            
            //同步完成，关闭数据库连接
            syncDao.CloseConntion();

            if (Total_rows != 0)
            {
                try
                {
                    //FileControl.CompactAccessDB(ClientConfiguration.TmpDBFile);
                    CopyDB(ClientConfiguration.TmpDBFile, ClientConfiguration.LocalDBFile);
                }
                catch (Exception ex)
                {
                    if (XtraMessageBox.Show("复制压缩库文件异常，请检查磁盘空间，现在是否退出？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return false;
                    }
                }
            }
            
            return returnvalue;
        }
        #endregion

        /// <summary>
        /// In the work status.
        /// 控制按钮和鼠标状态        
        /// </summary>
        private void InWorkingStatus()
        {
            this.UseWaitCursor = true;
            this.okButton.Enabled = false;
            this.Bt_exit.Enabled = false;
        }

        /// <summary>
        /// Works the done status.
        /// </summary>
        private void WorkDoneStatus(bool okFlag)
        {
            
            this.UseWaitCursor = false;
            this.okButton.Enabled = true;
            this.Bt_exit.Enabled = true;
            if (okFlag)
            {
                this.lbrec.Text = "共同步 " + Total_rows.ToString() + " 条记录　用时 " + this.lblTime.Text;
                this.Bt_exit.Text = "完成";
                this.okButton.Enabled = false;
                this.msgLabel.Text = "数据项目同步成功！";
            }
            else
            {
                this.lbrec.Text = "";
                this.Bt_exit.Text = "关闭";
                this.okButton.Enabled = false;
                this.msgLabel.Text = "数据项目同步失败！";
            }
            this.lbrec.Visible = true;
            this.lblTime.Visible = false;
            overFlag = true;
        }

        /// <summary>
        /// Handles the Tick event of the progressTimer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if (progressNum++ < 100)
                this.SyncProgressBar.Text = progressNum.ToString();
            else
            {
                progressNum = 1;
                this.SyncProgressBar.Text = progressNum.ToString();
            }
            dateTime1 = DateTime.Now;
            TimeSpan timeSpan = dateTime1 - dateTime0;
            this.lblTime.Text = Math.Round(timeSpan.TotalSeconds, 2).ToString() + "秒";
        }

        /// <summary>
        /// Starts the sycn.
        /// </summary>
        private void StartSycn()
        {
            InWorkingStatus();
            SyncBackgroundWorker.RunWorkerAsync();
            this.progressTimer.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the okButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            //this.progressTimer.Enabled = false;
            //this.progressTimer.Dispose();
            //this.Close();
            if (!this.chkUpload.Checked)
                if (XtraMessageBox.Show("此操作将不上传本地数据,是否继续？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
            this.lblTime.Visible = true;
            this.msgLabel.Visible = true;
            this.SyncProgressBar.Visible = true;
            StartSycn();
        }

        /// <summary>
        /// Handles the Load event of the SyncForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="T:System.EventArgs"/> instance containing the event data.</param>
        private void SyncForm_Load(object sender, EventArgs e)
        {
          
            //StartSycn();
            InitializeListView();

            this.lblTime.Visible = false;
            this.msgLabel.Visible = false;
            //this.SyncProgressBar.Visible = false;
            string filePath;
            //判断主库文件是否存在，不存在，只能全同步  2007-6-28
            if (EmedFunc.GetLocalPersonCfgPath().EndsWith("\\"))
                filePath = EmedFunc.GetLocalPersonCfgPath() + "db\\TradeAssistant.mdf";
            else
                filePath = EmedFunc.GetLocalPersonCfgPath() + "\\db\\TradeAssistant.mdf";
            if (!File.Exists(filePath))
            {
                this.radioGroupSyncType.SelectedIndex = 0;
                //this.radioGroupSyncType.EditValue = 1;
                this.chkUpload.Enabled = false;

            }
            else
            {
                this.radioGroupSyncType.SelectedIndex = 1;
                this.chkUpload.Enabled = true;
            }
            overFlag = false;
            if (!string.IsNullOrEmpty(ClientConfiguration.Skin))
                this.LookAndFeel.SetSkinStyle(ClientConfiguration.Skin);
            else
                this.LookAndFeel.SetSkinStyle("Money Twins"); 
        }

        #region 初始化显示列表
        /// <summary>
        /// 初始ListView
        /// </summary>
        private void InitializeListView()
        {
            string Parameter, TableName, TableDesc, SyncType, readFlag, logFlag;

            //listView1.Columns.Add("", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("同步项目", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("数据量", -2, HorizontalAlignment.Right);
            //listView1.Columns.Add("耗时", -2, HorizontalAlignment.Right);
            //listView1.Columns.Add("表名", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("log", -2, HorizontalAlignment.Left);
            //listView1.Columns.Add("read", -2, HorizontalAlignment.Left);

            //listView1.Columns[0].Width = 50;
            //listView1.Columns[1].Width = 252;
            //listView1.Columns[2].Width = 68;
            //listView1.Columns[3].Width = 0;
            //listView1.Columns[4].Width = 0;
            //listView1.Columns[5].Width = 0;
            //listView1.Columns[6].Width = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();
            
            dt.Columns[0].ColumnName = "image";
            dt.Columns[1].ColumnName = "item";
            dt.Columns[2].ColumnName = "count";
            dt.Columns[3].ColumnName = "time";
            dt.Columns[4].ColumnName = "table";
            dt.Columns[5].ColumnName = "log";
            dt.Columns[6].ColumnName = "read";



            DataRow item = dt.NewRow();

            item[0] = "0";
            item[1] = "上传本地数据";
            item[2] = "";
            item[3] = "";
            item[4] = "";
            item[5] = "";
            item[6] = "";
            dt.Rows.Add(item);

            //ArrayList results = new ClientSyncBLL().GetTableParameter();
            ArrayList results = ClientSyncBLL.GetTableParameter();

            for (int i = 0; i < results.Count; i++)
            {

                Parameter = (string)results[i];
                string[] ParameterField = Parameter.Split(new char[] { ',' });
                TableName = ParameterField[0];
                TableDesc = ParameterField[1];
                SyncType = ParameterField[2];
                logFlag = ParameterField[3];
                readFlag = ParameterField[4];

                item = dt.NewRow();

                item[0] = "0";
                item[1] = SyncType + TableDesc;
                item[2] = "";
                item[3] = "";
                item[4] = TableName;
                item[5] = logFlag;
                item[6] = readFlag;

                dt.Rows.Add(item);

            }

            item = dt.NewRow();
            item[0] = "0";
            item[1] = "压缩临时库替换本地库";
            item[2] = "";
            item[3] = "";
            item[4] = "";
            item[5] = "";
            item[6] = "";
            dt.Rows.Add(item);
            listView1.DataSource = dt;
        }
        #endregion

        /// <summary>
        /// 是否超时
        /// </summary>
        /// <returns></returns>
        private bool notTimeOut()
        {

            bool syncLimit = Emedchina.TradeAssistant.Client.Properties.Settings.Default.SyncLimit;

            if (!syncLimit) //同步是否受到时间限制? 缺省是false
            {
                return true;
            }
            dateTime1 = DateTime.Now;
            TimeSpan timeSpan = dateTime1 - dateTime0;
            if (timeSpan.TotalSeconds > 180)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Determines whether this instance is increment.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if this instance is increment; otherwise, <c>false</c>.
        /// </returns>
        private bool IsIncrement
        {
            get { return "1".Equals(ClientConfiguration.SyncPolicy); }
        }


        private void Bt_exit_Click(object sender, EventArgs e)
        {
            //if (Total_rows != 0)
            //{
            //    try
            //    {
            //        //FileControl.CompactAccessDB(ClientConfiguration.TmpDBFile);
            //        CopyDB(ClientConfiguration.TmpDBFile, ClientConfiguration.LocalDBFile);
            //    }
            //    catch (Exception ex)
            //    {
            //        if (MessageBox.Show("复制压缩库文件异常，请检查磁盘空间，现在是否退出交易助手？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //        {
            //            return;
            //        }
            //    }
            //}
            if (!File.Exists(ClientConfiguration.LocalDBFile))
                CopyDB(ClientConfiguration.TmpDBFile, ClientConfiguration.LocalDBFile);

            this.Close();
        }

        private void SyncForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ClientConfiguration.IfCompelSync && !overFlag)
            {
                e.Cancel = true;
                XtraMessageBox.Show("请同步数据！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}