using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaquetZone
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formularios.Login());
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("32302e342e30Alb/jqQbrcYwRCeeUkNK1cGaWwcVhdlas79ug6uVK6o=;Mgo DSMBaFt/QHRqVVhkVFpGaV5HQmFJfFBmR2lZd1RzfEUmHVdTRHRcQl9jQX9Xdk1gUX1bc3c=;Mgo DSMBMAY9C3t2VVhkQlFacldJX3xIe0x0RWFab1x6dF1MY1RBJAtUQF1hSn5Rdk1iXX9Wc3xXQ2Vf;Mgo DSMBPh8sVXJ0S0J XE9AflRAQmJMYVF2R2BJfVRwfF9FaEwxOX1dQl9gSXxTfkRnWXddeHZQQGM=;@32302e342e30MjEODtJgAUZ3TP6yxDCjDRexmwi4iHJRqgqmAPgymNc=;NRAiBiAaIQQuGjN/V0Z WE9EaFtKVmFWf1ZpR2NbfE5yflVOal9ZVBYiSV9jS31TdEVrWHteeHddRGZcUg==;NT8mJyc2IWhhY31nfWN9Z2toYXxiZnxhY2Fgc2FpY2tpYGtzAx5oMCE6IDQ5YmcTND4yOj99MDw ;ORg4AjUWIQA/Gnt2VVhkQlFacldJX3xIe0x0RWFab1x6dF1MY1RBJAtUQF1hSn5Rdk1iXX9Wc3xXQGNf;@32302e342e30GkDALGIajL MJd2H3k5riQt0kfWlQez0s1DTexN bu0=;@32302e342e30DplLlg72J9pnnXrmB0PE47Uqa7Q88MzhBFcq9i9URtc=;@32302e342e30aFsKw4DXP7tgldXQfOqbM VSW2/pHdgzMzVeFO6HaGg=;@32302e342e30g3ujle81LgGoxOjeSq0LWGA0wPI1MrdXcNpgRhANxy0=;@32302e342e30Alb/jqQbrcYwRCeeUkNK1cGaWwcVhdlas79ug6uVK6o=");

        }
    }
}
