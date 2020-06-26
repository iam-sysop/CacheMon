using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CacheMon
{
    public class Program
    {
        public static StatusWin CacheMonWin;
        public static ApplicationContext CacheMonApp;



        public static void Main()
        {

            
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show(string.Concat(AppName, " is already running."));

                Application.Exit();
            }
            else
            {

                Permissions.ElevateUser();

                Runtime.dataThread = new System.Threading.Timer(Runtime.UpdateCountersHandler, null, 0, Runtime.Settings.PollInterval); ;
                
                Runtime.Var.FlushHistory = 0;
                Runtime.Var.LastFlush = new DateTime();

                Runtime.SystrayIcon.Visible = true;
                Runtime.SystrayIcon.ContextMenuStrip.Opening += Runtime.SystrayMenu_RightClick;
                Runtime.SystrayIcon.DoubleClick += ShowWin;

                CacheMonWin = new StatusWin();
                CacheMonWin.WindowState = FormWindowState.Minimized;
                CacheMonApp = new ApplicationContext();
                CacheMonApp.MainForm = CacheMonWin;

                Application.Run(CacheMonApp);

            }

        }

        public static void ExitHandler(object sender, EventArgs e)
        {
            Exit();
        }

        public static void HideWin(object sender, EventArgs e)
        {
            CacheMonWin.WindowState = FormWindowState.Minimized;            
            CacheMonWin.ShowInTaskbar = false;
                        
        }
        
        public static void ShowWin(object sender, EventArgs e)
        {
            
            CacheMonWin.WindowState = FormWindowState.Normal;
            CacheMonWin.ShowInTaskbar = true;
            CacheMonWin.BringToFront();          
            
        }

        private static void Exit()
        {
            Runtime.dataThread.Dispose();
            Runtime.uiThread.Stop();
            Runtime.uiThread.Dispose();
            Runtime.SystrayIcon.Dispose();
            Application.Exit();
        }



        public static string AppName
        {
            get
            {
                return Application.ProductName;
            }
        }

        public static string AppVersion
        {
            get
            {
                return Application.ProductVersion;
            }
        }
    }
}
