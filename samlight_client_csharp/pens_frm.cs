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
    public partial class pens_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        int m_current_pen = 0;
        public pens_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;

            for( int i = 1; i < 257; i++ )
            {
                string s = String.Format( "{0}", i );
                COMBO_PEN.Items.Add( s );
            }
            COMBO_PEN.SelectedIndex = 0;
        }

        private void COMBO_PEN_SelectedIndexChanged( object sender, EventArgs e )
        {
            m_current_pen = COMBO_PEN.SelectedIndex + 1;
        }

        private void BUTTON_GET_LASER_POWER_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetPen( m_current_pen );
            EDIT_LASER_POWER.Text = Convert.ToString( m_samlight.ScGetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeLaserPower ), CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_LASER_POWER_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetPen( m_current_pen );
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeLaserPower, Convert.ToDouble( EDIT_LASER_POWER.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_GET_LASER_SPEED_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetPen( m_current_pen );
            EDIT_LASER_SPEED.Text = Convert.ToString( m_samlight.ScGetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeMarkSpeed ), CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_LASER_SPEED_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetPen( m_current_pen );
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeMarkSpeed, Convert.ToDouble( EDIT_LASER_SPEED.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_GET_OVERRIDE_POWER_Click( object sender, EventArgs e )
        {
            EDIT_OVERRIDE_POWER.Text = Convert.ToString( m_samlight.ScGetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeOverridePower ), CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_OVERRIDE_POWER_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeOverridePower, Convert.ToDouble( EDIT_OVERRIDE_POWER.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_GET_OVERRIDE_SPEED_Click( object sender, EventArgs e )
        {
            EDIT_OVERRIDE_SPEED.Text = Convert.ToString( m_samlight.ScGetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeOverrideSpeed ), CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_OVERRIDE_SPEED_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeOverrideSpeed, Convert.ToDouble( EDIT_OVERRIDE_SPEED.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_GET_OVERRIDE_FREQ_Click( object sender, EventArgs e )
        {
            EDIT_OVERRIDE_FREQ.Text = Convert.ToString( m_samlight.ScGetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeOverrideFrequ ), CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_OVERRIDE_FREQ_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeOverrideFrequ, Convert.ToDouble( EDIT_OVERRIDE_FREQ.Text, CultureInfo.InvariantCulture ) );
        }
    }
}
