using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BathMonitorSystem
{
    //【1】创建委托
    delegate byte[] CommDelegate(ModTCP objTCP);
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
            //【3】绑定方法
            MyDelegate += GetData;
            this.btnView_Click(null, null);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           if(modbus1.Connect("127.0.0.1","502"))
            {
                //【4】激活委托1
                MyDelegate.BeginInvoke(modbus1,  MyAsyncCallback, modbus1);
                CommonMethods.CurrentModbusList[1] = modbus1;
            }
            if (modbus2.Connect("127.0.0.1", "503"))
            {
                //【4】激活委托2
                MyDelegate.BeginInvoke(modbus2, MyAsyncCallback, modbus2);
                CommonMethods.CurrentModbusList[2] = modbus2;
            }
            if (modbus3.Connect("127.0.0.1", "504"))
            {
                //【4】激活委托3
                MyDelegate.BeginInvoke(modbus3, MyAsyncCallback, modbus3);
                CommonMethods.CurrentModbusList[3] = modbus3;
            }
            if (modbus4.Connect("127.0.0.1", "505"))
            {
                //【4】激活委托4
                MyDelegate.BeginInvoke(modbus4, MyAsyncCallback, modbus4);
                CommonMethods.CurrentModbusList[4] = modbus4;
            }
            if (modbus5.Connect("127.0.0.1", "506"))
            {
                //【4】激活委托5
                MyDelegate.BeginInvoke(modbus5, MyAsyncCallback, modbus5);
                CommonMethods.CurrentModbusList[5] = modbus5;
            }
            if (modbus6.Connect("127.0.0.1", "507"))
            {
                //【4】激活委托6
                MyDelegate.BeginInvoke(modbus6, MyAsyncCallback, modbus6);
                CommonMethods.CurrentModbusList[6] = modbus6;
            }
            if (modbus7.Connect("127.0.0.1", "508"))
            {
                //【4】激活委托7
                MyDelegate.BeginInvoke(modbus7, MyAsyncCallback, modbus7);
                CommonMethods.CurrentModbusList[7] = modbus7;
            }
            if (modbus8.Connect("127.0.0.1", "509"))
            {
                //【4】激活委托8
                MyDelegate.BeginInvoke(modbus8, MyAsyncCallback, modbus8);
                CommonMethods.CurrentModbusList[8] = modbus8;
            }
        }

        //【5】编写回调函数
        private void MyAsyncCallback(IAsyncResult ar)
        {
            //获取返回值
            byte[] Res = MyDelegate.EndInvoke(ar);

            //获取Modbus实例
            ModTCP objModbus = (ModTCP)ar.AsyncState;

            //解析返回值
            FlowData objFlow = Analyse(Res);

            var Query = from d in CommonMethods.CurrentModbusList where d.Value == objModbus select d.Key;
            int index = Query.FirstOrDefault();
            if (objFlow!=null)
            {
                CommonMethods.CurrentValue[index] = objFlow;
            }
            

            //【6】继续激活委托
            MyDelegate.BeginInvoke(objModbus, MyAsyncCallback, objModbus);
        }

        CommDelegate MyDelegate;
        ModTCP modbus1 = new ModTCP();
        ModTCP modbus2 = new ModTCP();
        ModTCP modbus3 = new ModTCP();
        ModTCP modbus4 = new ModTCP();
        ModTCP modbus5 = new ModTCP();
        ModTCP modbus6 = new ModTCP();
        ModTCP modbus7 = new ModTCP();
        ModTCP modbus8 = new ModTCP();
        //【2】编写委托方法
        private byte[] GetData(ModTCP objTCP)
        {
            try
            {
                return objTCP.ReadKeepReg(0, 8);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private FlowData Analyse(byte[] bytearray)
        {
            if (bytearray!=null&&bytearray.Length==16)
            {
                FlowData objFlow = new FlowData();
                objFlow.Temp = ByteFloatByPoint(new byte[] { bytearray[0], bytearray[1], bytearray[2], bytearray[3] });
                objFlow.Pressure = ByteFloatByPoint(new byte[] { bytearray[4], bytearray[5], bytearray[6], bytearray[7] });
                objFlow.FlowInstant = ByteFloatByPoint(new byte[] { bytearray[8], bytearray[9], bytearray[10], bytearray[11] });
                objFlow.FlowTotal = ByteFloatByPoint(new byte[] { bytearray[12], bytearray[13], bytearray[14], bytearray[15] });
                return objFlow;
            }
            else
            {
                return null;
            }
        }

        private float ByteFloatByPoint(byte[] bResponse)
        {
            float fValue = 0f;
            uint nRest = ((uint)bResponse[2]) * 256 + ((uint)bResponse[3]) + 65536 * (((uint)bResponse[0]) * 256 + ((uint)bResponse[1]));
            //用指针将整形强制转换成float
            unsafe
            {
                float* ptemp;
                ptemp = (float*)(&nRest);
                fValue = *ptemp;
            }
            return fValue;
        }

        #region 窗体操作
        /// <summary>
        /// 打开窗体
        /// </summary>
        /// <param name="objFrm"></param>
        private void OpenWindows(Form objFrm)
        {
            objFrm.TopLevel = false;
            objFrm.FormBorderStyle = FormBorderStyle.None;
            objFrm.Dock = DockStyle.Fill;
            objFrm.Parent = this.pl_Right;
            objFrm.Show();
        }

        /// <summary>
        /// 关闭窗体通用方法
        /// </summary>
        /// <param name="FrmName"></param>
        /// <returns></returns>
        private bool CloseWindows(string FrmName)
        {
            bool res = false;
            foreach (Control item in this.pl_Right.Controls)
            {
                if (item is Form)
                {
                    Form Frm = (Form)item;
                    if (Frm.Name == FrmName)
                    {
                        res = true;
                        break;
                    }
                    else
                    {
                        Frm.Close();
                    }
                }
            }
            return res;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (CloseWindows("frmView") == false)
            {
                OpenWindows(new frmView());
            }
            BackColorSet(0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (CloseWindows("frmProcess") == false)
            {
                OpenWindows(new frmProcess());
            }
            BackColorSet(1);
        }

        private void btnParamSet_Click(object sender, EventArgs e)
        {
            if (CloseWindows("frmParaSet") == false)
            {
                OpenWindows(new frmParaSet());
            }
            BackColorSet(2);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            if (CloseWindows("frmAlarm") == false)
            {
                OpenWindows(new frmAlarm());
            }
            BackColorSet(3);
        }

        private void btnTrend_Click(object sender, EventArgs e)
        {
            if (CloseWindows("frmTrend") == false)
            {
                OpenWindows(new frmTrend());
            }
            BackColorSet(4);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (CloseWindows("frmReport") == false)
            {
                OpenWindows(new frmReport());
            }
            BackColorSet(5);
        }

        /// <summary>
        /// 根据锁定改变背景颜色
        /// </summary>
        /// <param name="index"></param>
        private void BackColorSet(int index)
        {
            this.lblView.BackColor = Color.FromArgb(0, 84, 128);
            this.lblProcess.BackColor = Color.FromArgb(0, 84, 128);
            this.lblParamSet.BackColor = Color.FromArgb(0, 84, 128);
            this.lblAlarm.BackColor = Color.FromArgb(0, 84, 128);
            this.lblTrend.BackColor = Color.FromArgb(0, 84, 128);
            this.lblReport.BackColor = Color.FromArgb(0, 84, 128);
            switch (index)
            {
                case 0: this.lblView.BackColor = Color.Green; break;
                case 1: this.lblProcess.BackColor = Color.Green; break;
                case 2: this.lblParamSet.BackColor = Color.Green; break;
                case 3: this.lblAlarm.BackColor = Color.Green; break;
                case 4: this.lblTrend.BackColor = Color.Green; break;
                case 5: this.lblReport.BackColor = Color.Green; break;
                default:
                    this.lblView.BackColor = Color.Green; break;
            }

        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定退出吗？", "退出询问",

MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)

            {

                Application.Exit();

            }
           
        }
    }
}
