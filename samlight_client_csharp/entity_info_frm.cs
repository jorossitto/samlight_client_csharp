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
    public partial class entity_info_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        public entity_info_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
        }

        private void BUTTON_GET_OUTLINE_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            // here we calc the outline
            EDIT_OUTLINE_MIN_X.Text = Convert.ToString( m_samlight.ScGetEntityOutline( EDIT_ENTITY_NAME.Text, 0 ), CultureInfo.InvariantCulture );
            EDIT_OUTLINE_MIN_Y.Text = Convert.ToString( m_samlight.ScGetEntityOutline( EDIT_ENTITY_NAME.Text, 1 ), CultureInfo.InvariantCulture );
            EDIT_OUTLINE_MIN_Z.Text = Convert.ToString( m_samlight.ScGetEntityOutline( EDIT_ENTITY_NAME.Text, 2 ), CultureInfo.InvariantCulture );
            EDIT_OUTLINE_MAX_X.Text = Convert.ToString( m_samlight.ScGetEntityOutline( EDIT_ENTITY_NAME.Text, 3 ), CultureInfo.InvariantCulture );
            EDIT_OUTLINE_MAX_Y.Text = Convert.ToString( m_samlight.ScGetEntityOutline( EDIT_ENTITY_NAME.Text, 4 ), CultureInfo.InvariantCulture );
            EDIT_OUTLINE_MAX_Z.Text = Convert.ToString( m_samlight.ScGetEntityOutline( EDIT_ENTITY_NAME.Text, 5 ), CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_MARK_LOOP_COUNT_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkLoopCount, Convert.ToInt32(EDIT_MARK_LOOP_COUNT.Text) );
        }

        private void BUTTON_GET_MARK_LOOP_COUNT_Click( object sender, EventArgs e )
        {
            EDIT_MARK_LOOP_COUNT.Text = Convert.ToString( m_samlight.ScGetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkLoopCount ), CultureInfo.InvariantCulture );
        }

        private void BUTTON_GET_MARK_BEAT_COUNT_Click( object sender, EventArgs e )
        {
            EDIT_MARK_BEAT_COUNT.Text = Convert.ToString( m_samlight.ScGetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkBeatCount ), CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_MARK_BEAT_COUNT_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkBeatCount, Convert.ToInt32(EDIT_MARK_BEAT_COUNT.Text) );
        }

        private void BUTTON_GET_MARK_BEAT_OFFSET_Click( object sender, EventArgs e )
        {
            EDIT_MARK_BEAT_OFFSET.Text = Convert.ToString( m_samlight.ScGetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkStartCount ), CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_MARK_BEAT_OFFSET_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkStartCount, Convert.ToInt32(EDIT_MARK_BEAT_OFFSET.Text ));
        }
    }
}
