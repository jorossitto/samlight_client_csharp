using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAMLIGHT_CLIENT_CTRL_OCXLib;

namespace samlight_client_csharp
{
    public partial class input_output_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        int m_selected_opto_bit = 1;
        public input_output_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
            for( int i = 0; i < 16; i++ )
            {
                string s = String.Format( "{0}", i );
                COMBO_BIT.Items.Add( s );
            }
            COMBO_BIT.SelectedIndex = 0;
        }

        private void COMBO_BIT_SelectedIndexChanged( object sender, EventArgs e )
        {
            m_selected_opto_bit = ( int )Math.Pow( 2.0, ( double )COMBO_BIT.SelectedIndex );
        }

        private void BUTTON_CHANGE_OPTO_OUT_Click( object sender, EventArgs e )
        {
            // Setting opto out bits
            int flag;
            int mask = ~m_selected_opto_bit;
            mask = mask << 16;

            if( CHECK_OPTO_OUT.Checked )
                flag = m_selected_opto_bit;
            else
                flag = 0;
            int value_to_be_set = mask | flag;
            m_samlight.ScSetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeOptoIO, value_to_be_set );
        }

        private void BUTTON_READ_OPTO_OUT_Click( object sender, EventArgs e )
        {
            // Reading opto out bits
            long flags = m_samlight.ScGetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeGetOptoOut );
            if( ( flags & m_selected_opto_bit ) == m_selected_opto_bit )
                CHECK_OPTO_OUT.Checked = true;
            else
                CHECK_OPTO_OUT.Checked = false;
        }

        private void BUTTON_READ_OPTO_IN_Click( object sender, EventArgs e )
        {
            // Reading opto in bits
            long flags = m_samlight.ScGetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeOptoIO );
            if( ( flags & m_selected_opto_bit ) == m_selected_opto_bit )
                CHECK_OPTO_IN.Checked = true;
            else
                CHECK_OPTO_IN.Checked = false;

        }
    }
}
