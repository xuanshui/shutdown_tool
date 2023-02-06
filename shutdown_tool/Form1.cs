using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//添加命名空间
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace shutdown_tool
{
    public partial class ShutdownTool : Form
    {
        //是否选择过时间
        bool chooseTime = false;
        //倒计时是否有效
        bool countDown = true;
        //倒计时时间，单位：分钟
        int countDownTime = 0;
        //Delay函数调整参数，表示1分钟(有6万秒)
        int delayArg = 1000 * 60;
        //引入函数，实现休眠和睡眠功能
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);
        //电脑休眠
        private void sleepFun()
        {
            Console.WriteLine("sleep.\n");
            SetSuspendState(true, true, true);
        }
        //电脑关机
        private void shutdownFun()
        {
            Console.WriteLine("shutdown.\n");
            Process.Start("shutdown", "/s /t 0");
        }
        //电脑重启
        private void reloadFun()
        {
            Console.WriteLine("reload.\n");
            Process.Start("shutdown", "/r /t 0");
        }
        //电脑睡眠
        private void sleepFun1()
        {
            Console.WriteLine("sleep1.\n");
            SetSuspendState(false, true, true);
        }
        //毫秒延时 界面不会卡死
        public bool Delay(int mm)
        {
            DateTime timeStart = DateTime.Now;
            while (timeStart.AddMilliseconds(mm) > DateTime.Now)
            {
                Console.WriteLine(DateTime.Now);
                //下拉菜单显示倒计时
                this.comboBox_select_time.Text = DateDiff(timeStart.AddMilliseconds(mm), DateTime.Now);
                if (!this.countDown)
                {
                    this.comboBox_select_time.Text = "请重选时间（分钟）";
                    return false;//未等待足够时间
                }
                Application.DoEvents();
            }
            return true;//等待了足够时间
        }
        private string DateDiff(DateTime DateTime1, DateTime DateTime2)
        {
            string dateDiff = null;
            try
            {
                TimeSpan ts1 = new TimeSpan(DateTime1.Ticks);
                TimeSpan ts2 = new TimeSpan(DateTime2.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                dateDiff = ts.ToString();
                //dateDiff = ts.Days.ToString() + "天"
               // + ts.Hours.ToString() + "小时"
                //+ ts.Minutes.ToString() + "分钟"
                //+ ts.Seconds.ToString() + "秒";
            }
            catch
            { }
            return dateDiff;
        }

        public ShutdownTool()
        {
            InitializeComponent();
        }
        private void comboBox_select_time_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chooseTime = true;
            int temp;
            int.TryParse(comboBox_select_time.Text, out temp);
            this.countDownTime = temp;
            Console.WriteLine("获取输入：倒计时 = {0}\n", this.countDownTime);
            this.comboBox_select_time.Enabled = false;
        }

        //btn_sleep
        private void button1_Click(object sender, EventArgs e)
        {
            this.btn_sleep.Text = "已休眠";
            this.btn_sleep.Enabled = false;
            this.sleepFun();
        }
        //btn_shutdown
        private void button2_Click(object sender, EventArgs e)
        {
            this.btn_shutdown.Text = "已关机";
            this.btn_shutdown.Enabled = false;
            this.shutdownFun();
        }
        //btn_reload
        private void btn_reload_Click(object sender, EventArgs e)
        {
            this.btn_reload.Text = "已重启";
            this.btn_reload.Enabled = false;
            this.reloadFun();
        }
        //btn_sleep_count_down
        private void button4_Click(object sender, EventArgs e)
        {
            this.btn_sleep_count_down.Text = "休眠倒计时...";
            this.btn_sleep_count_down.Enabled = false;
            countDown = true;

            if (!chooseTime)
            {
                MessageBox.Show("请先选择倒计时的时间！");
                this.btn_sleep_count_down.Enabled = true;
                this.btn_sleep_count_down.Text = "倒计时休眠";
            }
            else
            {
                this.btn_sleep_1_count_down.Enabled = false;
                this.btn_reload_count_down.Enabled = false;
                this.btn_shutdown_count_down.Enabled = false;

                if(Delay(this.countDownTime * delayArg))
                {
                    sleepFun();
                }
                
            }
        }
        //btn_shutdown_count_down
        private void button5_Click(object sender, EventArgs e)
        {
            this.btn_shutdown_count_down.Text = "关机倒计时...";
            this.btn_shutdown_count_down.Enabled = false;
            countDown = true;

            if (!chooseTime)
            {
                MessageBox.Show("请先选择倒计时的时间！");
                this.btn_shutdown_count_down.Enabled = true;
                this.btn_shutdown_count_down.Text = "倒计时关机";
            }
            else
            {
                this.btn_reload_count_down.Enabled = false;
                this.btn_sleep_count_down.Enabled = false;
                this.btn_sleep_1_count_down.Enabled = false;

                if (Delay(this.countDownTime * delayArg))
                {
                    shutdownFun();
                }

            }
        }

        //btn_reload_count_down
        private void btn_reload_count_down_Click(object sender, EventArgs e)
        {
            this.btn_reload_count_down.Text = "重启倒计时...";
            this.btn_reload_count_down.Enabled = false;
            countDown = true;

            if (!chooseTime)
            {
                MessageBox.Show("请先选择倒计时的时间！");
                this.btn_reload_count_down.Enabled = true;
                this.btn_reload_count_down.Text = "倒计时重启";
            }
            else
            {
                this.btn_sleep_1_count_down.Enabled = false;
                this.btn_sleep_count_down.Enabled = false;
                this.btn_shutdown_count_down.Enabled = false;

                if (Delay(this.countDownTime * delayArg))
                {
                    reloadFun();
                }
            }
        }
        //重置
        private void button3_Click(object sender, EventArgs e)
        {
            this.btn_sleep.Enabled = true;
            this.btn_sleep.Text = "休眠";

            //this.btn_sleep_1.Enabled = true;
            //this.btn_sleep_1.Text = "睡眠";

            this.btn_shutdown.Enabled = true;
            this.btn_shutdown.Text = "关机";

            this.btn_reload.Enabled = true;
            this.btn_reload.Text = "重启";

            countDown = false;
            this.chooseTime = false;

           this.btn_sleep_count_down.Enabled = true;
            this.btn_sleep_count_down.Text = "倒计时休眠";

            //this.btn_sleep_1_count_down.Enabled = true;
            //this.btn_sleep_1_count_down.Text = "倒计时睡眠";

            this.btn_shutdown_count_down.Enabled = true;
            this.btn_shutdown_count_down.Text = "倒计时关机";

            this.btn_reload_count_down.Enabled = true;
            this.btn_reload_count_down.Text = "倒计时重启";

            this.comboBox_select_time.Enabled = true;
            this.comboBox_select_time.Text = "请重选时间（分钟）";

            this.countDownTime = 0;
        }
        //btn_sleep_1
        private void btn_sleep_1_Click(object sender, EventArgs e)
        {
            this.btn_sleep_1.Text = "已睡眠";
            this.btn_sleep_1.Enabled = false;
            this.sleepFun1();
        }
        //btn_sleep_1_count_down
        private void btn_sleep_1_count_down_Click(object sender, EventArgs e)
        {
            this.btn_sleep_1_count_down.Text = "倒计时睡眠中...";
            this.btn_sleep_1_count_down.Enabled = false;

            if (!chooseTime)
            {
                MessageBox.Show("请先选择倒计时的时间！");
                this.btn_sleep_1_count_down.Enabled = true;
            }
            else
            {
                this.btn_reload_count_down.Enabled = false;
                this.btn_sleep_count_down.Enabled = false;
                this.btn_shutdown_count_down.Enabled = false;

                Delay(this.countDownTime * delayArg);
                sleepFun1();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btn_sleep_1.Enabled = false;
            this.btn_sleep_1_count_down.Enabled = false;
            this.textBox1.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 终止此进程，并将退出代码返回到操作系统。将强制退出所有正在运行的线程，彻底退出。
            System.Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
