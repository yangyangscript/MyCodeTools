using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace MyCodeTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 模板操作

        /// <summary>
        /// 公共调用
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private void DoTransformText<T>()
        {
            var str = tbxInput.Text;
            if(string.IsNullOrWhiteSpace(str)) return;
            var tType = typeof(T);
            var newT = (T)Activator.CreateInstance(typeof(T), str);
            var method = tType.GetMethod("TransformText");
            if(method==null) return;
            var ret =(string) method.Invoke(newT, null);
            tbxShow.Text = ret;
            if (cbCopy.Checked)
            {
                Clipboard.SetDataObject(ret);
            }
        }


        private void btnClass_Click(object sender, EventArgs e)
        {
            DoTransformText<TClass>();
        }

        private void StringIn_Click(object sender, EventArgs e)
        {
            DoTransformText<TStringIn>();
        }


        private void DDateSet_Click(object sender, EventArgs e)
        {
            DoTransformText<TDateSet>();
        }
        #endregion

        #region Form1操作
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //判断是否选择的是最小化按钮
            if (WindowState == FormWindowState.Minimized)
            {
                //隐藏任务栏区图标
                this.ShowInTaskbar = false;
                //图标显示在托盘区
                notifyIcon1.Visible = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion


        #region 托盘
        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认退出程序？", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
        }

        #endregion

        #region 注册表操作
        /// <summary>
        /// 开机启动项Key
        /// </summary>
        private const string _reKey = @"Software\Microsoft\Windows\CurrentVersion\Run\";


        /// <summary>
        /// 适应32和64系统得到CurrentUser RegistryKey
        /// </summary>
        /// <returns></returns>
        private RegistryKey GetCurrentUserRegistry()
        {
            return RegistryKey.OpenBaseKey(RegistryHive.CurrentUser,
                Environment.Is64BitOperatingSystem
                    ? RegistryView.Registry64
                    : RegistryView.Registry32);
        }

        private Microsoft.Win32.RegistryKey GetRegistryKey()
        {
            var resKeys = GetCurrentUserRegistry();
            //一般开机都有启动项，不用主动创建这个key
            var resKeyValue = resKeys.OpenSubKey(_reKey, true);
            return resKeyValue;
            //创建key方法
            //resKeys.CreateSubKey(_reKey);
        }

        private void btnRegedit_Click(object sender, EventArgs e)
        {
            try
            {
                var fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyCodeTools.exe");
                var resKey = GetRegistryKey();
                if(resKey==null) return;
                resKey.SetValue("MyCodeTools", fullPath);
                resKey.Close();
                MessageBox.Show("设置成功!","设置状态",MessageBoxButtons.OKCancel);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"异常",MessageBoxButtons.OKCancel);
            }
        }

        private void btnRegeditCancel_Click(object sender, EventArgs e)
        {
            try
            {
                var resKey = GetRegistryKey();
                if (resKey == null) return;
                //注意删除key和删除value的区别
                resKey.DeleteValue("MyCodeTools",true);
                resKey.Close();
                MessageBox.Show("设置成功!", "设置状态", MessageBoxButtons.OKCancel);

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"异常", MessageBoxButtons.OKCancel);
            }
        }
        #endregion
    }
}
