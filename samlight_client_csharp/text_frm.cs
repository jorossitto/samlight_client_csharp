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
    public partial class text_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        int m_alignment_flags;
        public text_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent( );
            m_samlight = p_samlight;
        }

        private void BUTTON_CHANGE_TEXT_BY_NAME_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            m_samlight.ScChangeTextByName( EDIT_ENTITY_NAME.Text, EDIT_TEXT_STRING.Text );
        }

        private void BUTTON_CHANGE_TEXT_ALIGNMENT_GET_Click(object sender, EventArgs e)
        {
            m_alignment_flags = m_samlight.ScGetEntityLongData(EDIT_ENTITY_NAME.Text, (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdTextAlignment);
            members_to_radial_state();
        }

        private void BUTTON_CHANGE_TEXT_ALIGNMENT_SET_Click(object sender, EventArgs e)
        {
            m_samlight.ScSetEntityLongData(EDIT_ENTITY_NAME.Text, (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdTextAlignment, m_alignment_flags);
        }

        private void BUTTON_CHANGE_TEXT_ORIENTATION_Click(object sender, EventArgs e)
        {
            m_samlight.ScSetEntityDoubleData(EDIT_ENTITY_NAME.Text, (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdTextOrientation, Convert.ToDouble(EDIT_TEXT_ORIENTATION.Text, CultureInfo.InvariantCulture));
        }

        private void BUTTON_CHANGE_TEXT_WEIGHT_Click(object sender, EventArgs e)
        {
            m_samlight.ScSetEntityLongData(EDIT_ENTITY_NAME.Text, (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdTextWeight, Convert.ToInt32(EDIT_TEXT_WEIGHT.Text, CultureInfo.InvariantCulture));
        }

        private void RADIO_LEFT_CheckedChanged(object sender, EventArgs e)
        {
            m_alignment_flags = (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlTextAlignmentLeft;
        }

        private void RADIO_CENTER_CheckedChanged(object sender, EventArgs e)
        {
            m_alignment_flags = (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlTextAlignmentCenter;
        }

        private void RADIO_RIGHT_CheckedChanged(object sender, EventArgs e)
        {
            m_alignment_flags = (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlTextAlignmentRight;
        }

        private void members_to_radial_state()
        {
            if ((m_alignment_flags & (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlTextAlignmentCenter) == (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlTextAlignmentCenter)
                RADIO_CENTER.Checked = true;
            else
                RADIO_CENTER.Checked = false;
            if ((m_alignment_flags & (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlTextAlignmentLeft) == (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlTextAlignmentLeft)
                RADIO_LEFT.Checked = true;
            else
                RADIO_LEFT.Checked = false;
            if ((m_alignment_flags & (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlTextAlignmentRight) == (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlTextAlignmentRight)
                RADIO_RIGHT.Checked = true;
            else
                RADIO_RIGHT.Checked = false;
        }
    }
}
