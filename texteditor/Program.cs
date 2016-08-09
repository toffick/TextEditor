using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using texteditor.Properties;
using texteditor.BL;



namespace texteditor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();
            DfEditor.MessageService service = new DfEditor.MessageService();
            texteditor.BL.manager maneg = new texteditor.BL.manager();

            texteditor.BL.MainPresenter presenter = new texteditor.BL.MainPresenter(form, maneg, service);
            Application.Run(form);
        }
    }
}
