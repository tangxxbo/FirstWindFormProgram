using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindFormProgram
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]//com线程模型-单线程单元，没有它，无法工作
        static void Main()
        {
            //System.Window.Form.Application 提供一系列静态方法和属性，来管理应用程序
            //EnableVisualStyles()，启用程序的样式
            Application.EnableVisualStyles();
            //将CompatibleTextRendering设置为false
            Application.SetCompatibleTextRenderingDefault(false);
            //要启用的窗体
            Application.Run(new NewForm());
        }
    }
}
