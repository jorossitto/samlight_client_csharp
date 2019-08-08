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
    public partial class motion_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        public motion_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
        }

        private void BUTTON_HOME_Click( object sender, EventArgs e )
        {
            // Homing of all three axes
            m_samlight.ScSetLongValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeMotionWaitForEnd, 0);
            m_samlight.ScSetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeMotionAxis, -1 );
            m_samlight.ScExecCommand((int)ScComSAMLightClientCtrlExecCommandConstants.scComSAMLightClientCtrlExecCommandMotionHome);
        }

        private void BUTTON_MOVE_RELATIVE_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeMotionAxis, Convert.ToInt32( EDIT_AXIS.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeMotionAxisPositionRelative, Convert.ToDouble( EDIT_DISTANCE.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeMotionAxisSpeed, Convert.ToDouble( EDIT_SPEED.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetLongValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeMotionWaitForEnd, 0);
            m_samlight.ScExecCommand( ( int )ScComSAMLightClientCtrlExecCommandConstants.scComSAMLightClientCtrlExecCommandMotionGo );
        }

        private void BUTTON_MOVE_ABSOLUTE_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeMotionAxis, Convert.ToInt32( EDIT_AXIS.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeMotionAxisPosition, Convert.ToDouble( EDIT_DISTANCE.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeMotionAxisSpeed, Convert.ToDouble( EDIT_SPEED.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetLongValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeMotionWaitForEnd, 0);
            m_samlight.ScExecCommand( ( int )ScComSAMLightClientCtrlExecCommandConstants.scComSAMLightClientCtrlExecCommandMotionGo );
        }

        private void BUTTON_STOP_Click( object sender, EventArgs e )
        {
            m_samlight.ScExecCommand( ( int )ScComSAMLightClientCtrlExecCommandConstants.scComSAMLightClientCtrlExecCommandMotionStopMove );
        }
    }
}
