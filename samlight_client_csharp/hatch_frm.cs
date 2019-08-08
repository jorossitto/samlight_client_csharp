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
    public partial class hatch_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        int m_hatching_mode = 0;
        int m_current_pair = 0;
        string[] m_hatch_styles = new string[]
        {
            "None",
            "Style 1",
            "Style 2",
            "Style 3",
            "Style 4",
            "Style 5",
            "Style 6"
        };
        public hatch_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
         
            char pair = 'A';
            for( int i = 0; i < 5; i++ )
            {
                string s = String.Format( "Pair {0}", pair );
                COMBO_HATCH_PAIRS.Items.Add( s );
                pair++;
            }
            COMBO_HATCH_PAIRS.SelectedIndex = 0;
        }

        private void BUTTON_GET_HATCH1_Click( object sender, EventArgs e )
        {
            double dbl = 0.0;

            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScSetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeSelectHatchPair, m_current_pair );
            m_samlight.ScGetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdHatchAngle1, ref dbl );
            EDIT_HATCH_ANGLE1.Text = Convert.ToString( dbl, CultureInfo.InvariantCulture );

            m_samlight.ScGetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdHatchDistance1, ref dbl );
            EDIT_HATCH_DISTANCE1.Text = Convert.ToString( dbl, CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_HATCH1_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScSetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeSelectHatchPair, m_current_pair );
            m_samlight.ScSetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdHatchAngle1, Convert.ToDouble( EDIT_HATCH_ANGLE1.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdHatchDistance1, Convert.ToDouble( EDIT_HATCH_DISTANCE1.Text ) );
        }

        private void BUTTON_GET_HATCH2_Click( object sender, EventArgs e )
        {
            double dbl = 0.0;

            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScSetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeSelectHatchPair, m_current_pair );
            m_samlight.ScGetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdHatchAngle2, ref dbl );
            EDIT_HATCH_ANGLE2.Text = Convert.ToString( dbl, CultureInfo.InvariantCulture );

            m_samlight.ScGetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdHatchDistance2, ref dbl );
            EDIT_HATCH_DISTANCE2.Text = Convert.ToString( dbl, CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_HATCH2_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScSetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeSelectHatchPair, m_current_pair );
            m_samlight.ScSetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdHatchAngle2, Convert.ToDouble( EDIT_HATCH_ANGLE2.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdHatchDistance2, Convert.ToDouble( EDIT_HATCH_DISTANCE2.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_ENABLE_HATCHING1_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            m_hatching_mode++;
            if( m_hatching_mode > 6 )
                m_hatching_mode = 0;
            m_samlight.ScSetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEnableHatching1, m_hatching_mode );
            BUTTON_ENABLE_HATCHING1.Text = m_hatch_styles[m_hatching_mode];
        }

        private void BUTTON_ENABLE_HATCHING2_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            m_hatching_mode++;
            if( m_hatching_mode > 6 )
                m_hatching_mode = 0;
            m_samlight.ScSetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEnableHatching2, m_hatching_mode );
            BUTTON_ENABLE_HATCHING2.Text = m_hatch_styles[m_hatching_mode];
        }

        private void COMBO_HATCH_PAIRS_SelectedIndexChanged( object sender, EventArgs e )
        {
            m_current_pair = COMBO_HATCH_PAIRS.SelectedIndex ;
        }
    }
}
