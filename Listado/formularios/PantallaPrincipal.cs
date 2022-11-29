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

namespace RaquetZone.formularios
{
    public partial class PantallaPrincipal : MaterialForm
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            var skinmanager = MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new ColorScheme(Primary.Green500, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Orange100, TextShade.WHITE);

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

        private void buttonGU_Click(object sender, EventArgs e)
        {
            GestionUsuarios GU = new GestionUsuarios();
            GU.Show();

        }

        private void buttonGE_Click(object sender, EventArgs e)
        {
            GestionEmpresas GE = new GestionEmpresas();
            GE.Show();
        }

        private void noteButton_Click(object sender, EventArgs e)
        {
            Process p;
            p = Process.Start(ConfigurationManager.AppSettings["app1"]);
            Console.WriteLine("Name: {0}\nPID: {1}\nSubprocesses: {2}\nInit: {3}", p.ProcessName, p.Id, p.Threads.Count, p.StartTime);
            p.WaitForExit();
            Console.WriteLine("Aplication finished in date and time {0}", p.ExitTime);

        }

        private void loginBotton_Click_1(object sender, EventArgs e)
        {
            Login L1 = new Login();
            
            L1.Show();
            this.Close();
        }
    }
}
