using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Travel_Tours
{
    public class WinForms
    {
        private static Form loginForm;
        public static Form LF
        {
            get
            {
                if (loginForm == null)
                {
                    loginForm = new LoginForm();
                }
                return loginForm;
            }
        }

        private static Form commandLine;
        public static Form CL
        {
            get
            {
                if (commandLine == null)
                {
                    commandLine = new frmCLI();
                }
                return commandLine;
            }
        }

        private static Form controlPanel;
        public static Form CP
        {
            get
            {
                if (controlPanel == null)
                {
                    controlPanel = new frmCLI();
                }
                return controlPanel;
            }
        }
    }
}
