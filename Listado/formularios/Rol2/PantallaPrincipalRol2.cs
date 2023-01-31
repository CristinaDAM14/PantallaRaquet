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
        
       public int rolActual = 2;

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

            comboCIFP2.Text = (string)comboCIFP2.Items[0];
        }

        private void buttonGP_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoProductos").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoProductos GP = new ListadoProductos();
                GP.TextoCIFP.Text = comboCIFP2.GetItemText(comboCIFP2.SelectedItem);
                GP.Show();
            }

            

        }

        private void buttonGU_Click(object sender, EventArgs e)
        {

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "RaquetZoneUsuarios").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                RaquetZoneUsuarios LU1 = new RaquetZoneUsuarios();
                LU1.TextoCIFC.Text = comboCIFP2.GetItemText(comboCIFP2.SelectedItem);
                LU1.Show();
            }

            
        }

        private void buttonGC_Click(object sender, EventArgs e)
        {

            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoClientes").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoClientes GC = new ListadoClientes();
                GC.TextoCIFC.Text = comboCIFP2.GetItemText(comboCIFP2.SelectedItem);
                GC.Show();
            }
            

        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoComprasSolas").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoComprasSolas LC = new ListadoComprasSolas();
                LC.Show();
            }
            
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {

            Login LU1 = new Login();
            LU1.Show();
            this.Close();
        }

        private void Servicios_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoServicios").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoServicios GS = new ListadoServicios();
                GS.TextoCIFP.Text = comboCIFP2.GetItemText(comboCIFP2.SelectedItem);
                GS.Show();
            }

            
        }

        private void bReservas_Click(object sender, EventArgs e)
        {
            Form existe = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "ListadoReservas").SingleOrDefault<Form>();
            if (existe != null)

            {
                MessageBox.Show("Esa ventana ya está abierta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ListadoReservas LR = new ListadoReservas();
                LR.TextoCIFC.Text = comboCIFP2.GetItemText(comboCIFP2.SelectedItem);
                LR.Show();
            }
        }
    }
}



