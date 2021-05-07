using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BathMonitorSystem
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
            Timer mytimer = new Timer();
            mytimer.Interval = 100;
            mytimer.Tick += Mytimer_Tick;
            mytimer.Enabled = true;
        }

        private void Mytimer_Tick(object sender, EventArgs e)
        {
            foreach (Control item in this.tableLayoutPanel1.Controls)
            {
                if(item is Label)
                {
                    Label it = (Label)item;
                    if(it.Tag!=null)
                    {
                        string[] res = it.Tag.ToString().Split('_');
                        int index = Convert.ToInt32(res[1]);
                        if (CommonMethods.CurrentValue.Count>0&& CommonMethods.CurrentValue.ContainsKey(index))
                        {
                            FlowData objFlow = CommonMethods.CurrentValue[index];
                            switch (res[0])
                            {
                                case "Temp":it.Text = objFlow.Temp.ToString();break;
                                case "Pressure": it.Text = objFlow.Pressure.ToString(); break;
                                case "FlowInstant": it.Text = objFlow.FlowInstant.ToString(); break;
                                case "FlowTotal": it.Text = objFlow.FlowTotal.ToString(); break;
                            }
                        }
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           if(sender is Button)
            {
                Button btnClr = (Button)sender;
                if (btnClr.Tag!=null)
                {
                    int index = Convert.ToInt32(btnClr.Tag.ToString());
                    if (CommonMethods.CurrentModbusList.ContainsKey(index))
                    {
                        ModTCP objTCP = CommonMethods.CurrentModbusList[index];
                        if (objTCP.PreSetFloatReg(6,0.0f))
                        {
                            MessageBox.Show(index+"号流量计累计清零成功","清零提醒");
                        }
                        else
                        {
                            MessageBox.Show(index + "号流量计累计清零失败！", "清零提醒");
                        }
                    }
                }
            }
        }
    }
}
