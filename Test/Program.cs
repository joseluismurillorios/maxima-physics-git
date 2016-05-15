using MaximaSharp;
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Test
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [STAThread]
        static void Main(string[] args)
        {
            Console.Title = "Program";

            IntPtr h = FindWindow(null, "Program");

            ShowWindow(h, 0); // 0 = hide

            Form1 f = new Form1();

            f.ShowDialog();
            //f.Show();

            ShowWindow(h, 1); // 1 = show
            f.Focus();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //Expression<Func<double, double>> f = x => 3 * Math.Pow(x, 2) + 2 * x + Math.Pow(Math.Cos(x), 2) + Math.Pow(Math.Sin(x), 2);
            //Expression<Func<double, double>> g = x => 2 * x + 20 * 2;
            //Expression<Func<double, double, double>> h = (y, z) => y + z;

            //MessageBox.Show(string.Format("{0}", ResolveA()));
        }

        public static string ResolveA()
        {
            Expression<Func<double, double>> f = x => 3 * Math.Pow(x, 2) + 2 * x + Math.Pow(Math.Cos(x), 2) + Math.Pow(Math.Sin(x), 2);
            Expression<Func<double, double>> g = x => 2 * x + 20 * 2;
            Expression<Func<double, double, double>> h = (y, z) => y + z;

            return string.Format("{0}", g.Simplify());
        }
    }
}
