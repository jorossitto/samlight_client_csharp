using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using SAMLIGHT_CLIENT_CTRL_OCXLib;

namespace samlight_client_csharp
{
    public partial class flash_calls_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;

        public flash_calls_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
        }

        private void CHECK_WAIT_FOR_EXTERNAL_TRIGGER_CheckedChanged( object sender, EventArgs e )
        {
            string Command = "";
            int flags = 0;
            string Return = "";
            if( CHECK_WAIT_FOR_EXTERNAL_TRIGGER.Checked )
                Command = "et 1\r\n";
            else
                Command = "et 0\r\n";
            m_samlight.ScFlashCommand( Command, flags, ref Return );
        }

        private void BUTTON_DOWNLOAD_Click( object sender, EventArgs e )
        {
            int flags = 0;
            m_samlight.ScProcessFlashJob( EDIT_ENTITY_NAME.Text, Convert.ToInt32( EDIT_JOB_NUMBER.Text, CultureInfo.InvariantCulture ), ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlProcessFlashJobModeStoreCurrentToFlash, flags );
        }

        private void BUTTON_UPLOAD_Click( object sender, EventArgs e )
        {
            int flags = 0;
            m_samlight.ScProcessFlashJob( EDIT_ENTITY_NAME.Text, Convert.ToInt32( EDIT_JOB_NUMBER.Text, CultureInfo.InvariantCulture ), ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlProcessFlashJobModeLoadFromFlash, flags );
        }

        private void BUTTON_MARK_Click( object sender, EventArgs e )
        {
            //start to mark the selected job in the flash
            int flags = 0;
            string Return = "";
            string Command = "m 1\r\n";
            m_samlight.ScFlashCommand( Command, flags, ref Return );
        }

        private void BUTTON_STOP_MARK_Click( object sender, EventArgs e )
        {
            //stop marking a flash job
            int flags = 0;
            string Command = "m 0\r\n";
            string Return = "";
            m_samlight.ScFlashCommand( Command, flags, ref Return );
        }

        private void BUTTON_SELECT_Click( object sender, EventArgs e )
        {
            //Select a job in the flash

            string Command = "";
            int flags = 0;
            string Return = "";
            Command = String.Format( "jn{0}\r\n", Convert.ToInt32( EDIT_JOB_NUMBER.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScFlashCommand( Command, flags, ref Return );
        }
    }
}
