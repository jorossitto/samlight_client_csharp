using System;
using System.IO;
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
    public partial class optimize_performance_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        public optimize_performance_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;

            LABEL_OPTIMIZE_PERFORMANCE.Text = "This example loads already prepared 20 barcode entities with entity names barcode1, barcode2, ..., barcode 20 in SAMLight.\nFor each barcode entity:\n\n\t- The text is changed\n\t- Hatch1 is enabled with 'wavy line without marking jumps'\n\t- Hatch2 is enabled with style 'zigzag'.\n\nIf we were to do it the common way, after every of the 60 CI calls the corresponding entity will get regenerated and the View2D\nof SAMLight will be updated. This needs a lot of time. This example demonstrates how the same goal can be reached by using\n3 CI calls instead of 60. Furthermore every entity will be regenerated only once and the View2D of SAMLight will only be\nupdated after the last entity change is complete. ";
            string current_dir = Directory.GetCurrentDirectory();
            string file_path = current_dir;
            file_path = string.Concat( file_path, "\\OptimizePerformanceSample.sjf" );
            EDIT_JOB_PATH.Text = file_path;
        }

        private void BUTTON_OPTIMIZE_PERFORMANCE_Click( object sender, EventArgs e )
        {
            //Generate one string 'all_entity_names' with all entity names separated by ";"
            //and generate one string 'all_entity_texts' with all entity textes separated by "\v"

            // Load job   

            m_samlight.ScLoadJob( EDIT_JOB_PATH.Text, 1, 0, 0 );

            string all_entity_names = "barcode1";
            string all_entity_texts = "This is the text of barcode 1";

            string temp;
            for( int i = 2; i <= 20; i++ )
            {
                temp = String.Format( ";barcode{0}", i );
                all_entity_names += temp;
                temp = String.Format( "\vThis is the text of barcode{0}", i );
                all_entity_texts += temp;
            }

            //enable entity name separated by semicolon mode
            //disable View2D
            //enable top level entities only

            m_samlight.ScSetMode( ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlModeFlagEntityNamesSeparatedBySemicolon |
                ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlModeFlagDontUpdateView |
                ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlModeFlagTopLevelOnly );

            //change all texts of all entities
            m_samlight.ScChangeTextByName( all_entity_names, all_entity_texts );

            //enable Hatching1 and Hatching2 for all entities, suppress entity update after enabling Hatching 1
            //so the entities will be updated after the enabling of Hatching 2 (second call)
            m_samlight.ScSetEntityLongData( all_entity_names,
                ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEnableHatching1 |
                ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlDoubleDataIdFlagDontUpdateEntity, 1 );

            m_samlight.ScSetEntityLongData( all_entity_names,
                ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEnableHatching2, 6 );

            //reset ScSetMode
            m_samlight.ScSetMode( 0 );

            //manually update View2D
            m_samlight.ScExecCommand( ( int )ScComSAMLightClientCtrlExecCommandConstants.scComSAMLightClientCtrlExecCommandUpdateViewNow );
        }
    }
}
