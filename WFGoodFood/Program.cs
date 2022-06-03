using System;
using System.Windows.Forms;
using WFGoodFood.GUI;

namespace WFGoodFood
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            // Application.Run(new LoginForm());
             Application.Run(new FormLoading());
            // Application.Run(new ProductForm());
            //  Application.Run(new Sign_Up());
            //Application.Run(new FormShopping_cart());
        }
    }
}
