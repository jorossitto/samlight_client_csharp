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
    public partial class settings_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        public settings_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
        }

        private void BUTTON_GET_HOME_POS_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            EDIT_HOME_POS_X.Text = Convert.ToString( m_samlight.ScGetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeHomePosX ), CultureInfo.InvariantCulture );
            EDIT_HOME_POS_Y.Text = Convert.ToString( m_samlight.ScGetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeHomePosY ), CultureInfo.InvariantCulture );
            EDIT_HOME_POS_Z.Text = Convert.ToString( m_samlight.ScGetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeHomePosZ ), CultureInfo.InvariantCulture );
        }

        private void BUTTON_SET_HOME_POS_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeHomePosX, Convert.ToDouble( EDIT_HOME_POS_X.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeHomePosY, Convert.ToDouble( EDIT_HOME_POS_Y.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeHomePosZ, Convert.ToDouble( EDIT_HOME_POS_Z.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_GET_FILE_PATH_Click( object sender, EventArgs e )
        {
            string file_path = "";
             m_samlight.ScGetStringValue(( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeCorrectionFile, ref file_path);
             EDIT_FILE_PATH.Text = file_path;
        }

        private void BUTTON_CHANGE_FILE_PATH_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetStringValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeCorrectionFile, EDIT_FILE_PATH.Text );
        }

        private void button_change_path_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "usc files (*.usc) | *.usc | All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = "D:\\corr_table\\Correction files";
            openFileDialog1.FileName = "cor_neutral.ucf";

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                EDIT_FILE_PATH.Text = openFileDialog1.FileName;
            }
        }
    }
}
