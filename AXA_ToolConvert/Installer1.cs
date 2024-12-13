using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AXA_ToolConvert
{
    [RunInstaller(true)]
    public partial class Installer1 : System.Configuration.Install.Installer
    {
        public Installer1() : base()
        {
            this.Committed += new InstallEventHandler(Installer1_Committed);
        }

        private void Installer1_Committed(object sender, InstallEventArgs e)
        {
            try
            {
                Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                var applicationPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AXA_ToolConvert.exe");

                // Global.CreateStartupFolderShortcut(applicationPath, "background");

                var startInfo = new ProcessStartInfo(applicationPath, "background");
                //startInfo.Verb = "runas";
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {

                // Do nothing... 
            }
        }
    }
}
