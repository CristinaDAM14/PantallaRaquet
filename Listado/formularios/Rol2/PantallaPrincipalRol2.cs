using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using MaterialSkin.Controls;
using MaterialSkin;

namespace RaquetZone.formularios.Rol2
{
    public partial class PantallaPrincipalRol2 : MaterialForm
    {
        public PantallaPrincipalRol2()
        {
            InitializeComponent();
        }

        private void noteButton_Click(object sender, EventArgs e)
        {
            Process p;
            p = Process.Start(ConfigurationManager.AppSettings["app1"]);
            Console.WriteLine("Name: {0}\nPID: {1}\nSubprocesses: {2}\nInit: {3}", p.ProcessName, p.Id, p.Threads.Count, p.StartTime);
            p.WaitForExit();
            Console.WriteLine("Aplication finished in date and time {0}", p.ExitTime);
        }

        private void chromeButton_Click(object sender, EventArgs e)
        {
            Process p;
            p = Process.Start(ConfigurationManager.AppSettings["app2"]);
            Console.WriteLine("Name: {0}\nPID: {1}\nSubprocesses: {2}\nInit: {3}", p.ProcessName, p.Id, p.Threads.Count, p.StartTime);
            p.WaitForExit();
            Console.WriteLine("Aplication finished in date and time {0}", p.ExitTime);
        }

        private void edgeButton_Click(object sender, EventArgs e)
        {
            Process p;
            p = Process.Start(ConfigurationManager.AppSettings["app3"]);
            Console.WriteLine("Name: {0}\nPID: {1}\nSubprocesses: {2}\nInit: {3}", p.ProcessName, p.Id, p.Threads.Count, p.StartTime);
            p.WaitForExit();
            Console.WriteLine("Aplication finished in date and time {0}", p.ExitTime);

        }

        private void PantallaPrincipalRol2_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

        }

        private void buttonGP_Click(object sender, EventArgs e)
        {
            GestionProductos GP = new GestionProductos();
            GP.Show();
           
        }

        private void buttonGU_Click(object sender, EventArgs e)
        {
            var abrirGU = new GestionUsuarios();
            abrirGU.Show();
        }

        private void buttonGC_Click(object sender, EventArgs e)
        {
            GestionClientes GC = new GestionClientes();
            GC.Show();
           
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login LU1 = new Login();
            LU1.Show();
            this.Hide();
        }
    }
}
