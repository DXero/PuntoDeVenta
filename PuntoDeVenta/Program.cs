using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PuntoDeVenta
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

            //String pass = "Cri.2018";
            //String cadena = $"metadata=res://*/ModelDB.ConfigApp.csdl|res://*/ModelDB.ConfigApp.ssdl|res://*/ModelDB.ConfigApp.msl;provider=System.Data.SqlClient;provider connection string=;data source=herrera.database.windows.net;initial catalog=sistema;user id=usuario;password={pass};encrypt=True;MultipleActiveResultSets=True;App=EntityFramework;";

            //connectionStringsSection.ConnectionStrings["ModelConfigApp"].ConnectionString = cadena;
            //config.Save();
            //ConfigurationManager.RefreshSection("connectionStrings");

            //MessageBox.Show(connectionStringsSection.ConnectionStrings["ModelConfigApp"].ConnectionString);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Usuarios.Principal_Usuarios());
        }
    }
}
