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
    public partial class bitmap_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        public bitmap_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
        }

        private void BUTTON_GET_BITMAP_INTENSITY_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            double m_bitmap_intensity = Convert.ToDouble( EDIT_BITMAP_INTENSITY.Text, CultureInfo.InvariantCulture );

            m_samlight.ScGetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdBitmapIntensity, ref m_bitmap_intensity );
            EDIT_BITMAP_INTENSITY.Text = Convert.ToString( m_bitmap_intensity, CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_BITMAP_INTENSITY_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScSetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdBitmapIntensity, Convert.ToDouble( EDIT_BITMAP_INTENSITY.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_GET_BITMAP_BRIGHTNESS_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            double m_bitmap_brightness = Convert.ToDouble( EDIT_BITMAP_BRIGHTNESS.Text, CultureInfo.InvariantCulture );
            m_samlight.ScGetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdBitmapBrightness, ref m_bitmap_brightness );

            EDIT_BITMAP_BRIGHTNESS.Text = Convert.ToString( m_bitmap_brightness, CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_BITMAP_BRIGHTNESS_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScSetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdBitmapBrightness, Convert.ToDouble( EDIT_BITMAP_BRIGHTNESS.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_GET_BITMAP_DITHERSTEP_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            double m_bitmap_ditherstep = Convert.ToDouble( EDIT_BITMAP_DITHERSTEP.Text, CultureInfo.InvariantCulture );
            m_samlight.ScGetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdBitmapDitherstep, ref m_bitmap_ditherstep );

            EDIT_BITMAP_DITHERSTEP.Text = Convert.ToString( m_bitmap_ditherstep, CultureInfo.InvariantCulture );
        }

        private void BUTTON_CHANGE_BITMAP_DITHERSTEP_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScSetEntityDoubleData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdBitmapDitherstep, Convert.ToDouble( EDIT_BITMAP_DITHERSTEP.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_REIMPORT_Click( object sender, EventArgs e )
        {
            int flags = ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlImportFlagBitmapReimport;
            m_samlight.ScImport( EDIT_ENTITY_NAME.Text, EDIT_FILE_NAME.Text, "png", 0.01, flags );
        }

        private void CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL_CheckedChanged( object sender, EventArgs e )
        {
            int flags = 0;
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            if( CHECK_SCANNER_BITMAP_AND_BIDIRECTIONAL.Checked )
            {
                flags = m_samlight.ScGetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdBitmapMode );
                flags |= ( ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdBitmapModeBidirectional );
                m_samlight.ScSetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdBitmapMode, flags );
            }
            else
            {
                flags = m_samlight.ScGetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdBitmapMode );
                flags &= ~( ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdBitmapModeBidirectional );
                m_samlight.ScSetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdBitmapMode, flags );
            }
        }
        
        private void button_change_path_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                EDIT_FILE_NAME.Text = openFileDialog1.FileName;
            }
         }
    }
}
 