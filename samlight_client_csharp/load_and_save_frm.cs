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
    public partial class load_and_save_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        public load_and_save_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
        }

        private void BUTTON_SAVE_JOB_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            int flags = 1;
            m_samlight.ScSaveJob( EDIT_JOB_FILE_NAME.Text, flags );
        }

        private void BUTTON_IMPORT_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            int flags = ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlImportFlagKeepOrder |
            ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlImportFlagReadPenInfo |
            ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlImportFlagCenterToField |
            ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlImportFlagCreateOneGroup;

            m_samlight.ScImport( EDIT_JOB_FILE_NAME.Text, EDIT_JOB_FILE_NAME.Text, "dxf", 0.01, flags );
        }

        private void BUTTON_NEW_JOB_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScExecCommand( 3 );
        }

        private void BUTTON_LOAD_JOB_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            int load_entities = 0;
            int overwrite_entities = 0;
            int load_materials = 0;

            if( CHECK_ENTITIES.Checked == true )
                load_entities = 1;
            if( CHECK_OVERWRITE_ENTITIES.Checked == true )
                overwrite_entities = 1;
            if( CHECK_MATERIALS.Checked == true )
                load_materials = 1;

            m_samlight.ScLoadJob( EDIT_JOB_FILE_NAME.Text, load_entities, overwrite_entities, load_materials );
        }

        private void button_change_path_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "sjf files (*.sjf)|*.sjf|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                EDIT_JOB_FILE_NAME.Text = openFileDialog1.FileName;
            }
        }
    }
}
