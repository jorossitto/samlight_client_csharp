using System;
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
    public partial class samlight_client_csharp : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        public samlight_client_csharp()
        {
            InitializeComponent();
            m_samlight = axScSamlightClientCtrl1;
        }

        //public samlight_client_csharp()
        //{
        //    InitializeComponent();
        //}
        //public text_frm(AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight)
        //{
        //    InitializeComponent();
        //    m_samlight = p_samlight;
        //}

        private void BUTTON_TEST_Click( object sender, EventArgs e )
        {
            if( axScSamlightClientCtrl1.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                EDIT_STATUS_CONNECTED.Text = "";
                return;
            }
            axScSamlightClientCtrl1.ScExecCommand( 1 );
            return;
        }

        private void BUTTON_STOP_Click( object sender, EventArgs e )
        {
            if( axScSamlightClientCtrl1.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                EDIT_STATUS_CONNECTED.Text = "";
                return;
            }
            axScSamlightClientCtrl1.ScStopMarking();
        }          
               
        private void BUTTON_CONNECT_ETHERNET_Click( object sender, EventArgs e )
        {
            long res;
            res = axScSamlightClientCtrl1.ScOpenTCPConnection( EDIT_IP_SAMLIGHT.Text, Convert.ToInt32( EDIT_PORT_SAMLIGHT.Text ) );
            if( res == 1 )
                EDIT_STATUS_CONNECTED.Text = "Connected";
            else
                EDIT_STATUS_CONNECTED.Text = "Connected";

            string testString = "";
            m_samlight.ScGetEntityStringData(EDIT_ENTITY_NAME.Text, 2, ref testString);
            //MessageBox.Show(testString);
            //MessageBox.Show(EDIT_ENTITY_NAME.Text);
            EDIT_TEXT_STRING.Text = testString;
            m_samlight.ScGetEntityStringData(HeatCodeText.Text, 2, ref testString);
            HeatCodeEdit.Text = testString;
            //MessageBox.Show(testString);
            //MessageBox.Show(EDIT_ENTITY_NAME.Text);
        }

        private void BUTTON_DISCONNECT_ETHERNET_Click( object sender, EventArgs e )
        {
            if( axScSamlightClientCtrl1.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                EDIT_STATUS_CONNECTED.Text = "";
                return;
            }
            axScSamlightClientCtrl1.ScCloseEthernetConnection();
            EDIT_STATUS_CONNECTED.Text = "NOT connected";
        }

         private void BUTTON_CLOSE_Click( object sender, EventArgs e )
        {
            this.Close();
        }     
   
        private void BUTTON_TEXT_Click( object sender, EventArgs e )
        {
           if( Application.OpenForms.OfType<text_frm>().Count() == 0)
            {
                text_frm text_form = new text_frm(axScSamlightClientCtrl1);
                text_form.Show();
            }           
        }

        private void BUTTON_LOAD_AND_SAVE_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<load_and_save_frm>().Count() == 0)
            {
                load_and_save_frm load_and_save_form = new load_and_save_frm(axScSamlightClientCtrl1);
                load_and_save_form.Show();
            }
        }

        private void BUTTON_ENTITY_INFO_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<entity_info_frm>().Count() == 0)
            {
                entity_info_frm entity_info_form = new entity_info_frm(axScSamlightClientCtrl1);
                entity_info_form.Show();
            }
        }

        private void BUTTON_SETTINGS_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<settings_frm>().Count() == 0)
            {
                settings_frm settings_form = new settings_frm(axScSamlightClientCtrl1);
                settings_form.Show();
            }
        }

        private void BUTTON_BITMAP_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<bitmap_frm>().Count() == 0)
            {
                bitmap_frm bitmap_form = new bitmap_frm(axScSamlightClientCtrl1);
                bitmap_form.Show();
            }
        }

        private void samlight_client_csharp_Load( object sender, EventArgs e )
        {

        }

        private void BUTTON_HATCH_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<hatch_frm>().Count() == 0)
            {
                hatch_frm hatch_form = new hatch_frm(axScSamlightClientCtrl1);
                hatch_form.Show();
            }
        }

        private void BUTTON_MARK_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<mark_frm>().Count() == 0)
            {
                mark_frm mark_form = new mark_frm(axScSamlightClientCtrl1);
                mark_form.Show();
            }
        }

        private void BUTTON_PENS_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<pens_frm>().Count() == 0)
            {
                pens_frm pens_form = new pens_frm(axScSamlightClientCtrl1);
                pens_form.Show();
            }
        }

        private void BUTTON_MOVE_ENTITIES_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<move_entities_frm>().Count() == 0)
            {
                move_entities_frm move_entities_form = new move_entities_frm(axScSamlightClientCtrl1);
                move_entities_form.Show();
            }
        }

        private void BUTTON_FLASH_CALLS_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<flash_calls_frm>().Count() == 0)
            {
                flash_calls_frm flash_calls_form = new flash_calls_frm(axScSamlightClientCtrl1);
                flash_calls_form.Show();
            }
        }

        private void BUTTON_ENTITIES_BY_ID_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<entities_by_id_frm>().Count() == 0)
            {
                entities_by_id_frm entities_by_id_form = new entities_by_id_frm(axScSamlightClientCtrl1);
                entities_by_id_form.Show();
            }
        }

        private void BUTTON_SCREEN_SHOTS_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<screen_shots_frm>().Count() == 0)
            {
                screen_shots_frm screen_shots_form = new screen_shots_frm(axScSamlightClientCtrl1);
                screen_shots_form.Show();
            }
        }

        private void BUTTON_INPUT_OUTPUT_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<input_output_frm>().Count() == 0)
            {
                input_output_frm input_output_form = new input_output_frm(axScSamlightClientCtrl1);
                input_output_form.Show();
            }
        }

        private void BUTTON_MOTION_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<motion_frm>().Count() == 0)
            {
                motion_frm motion_form = new motion_frm(axScSamlightClientCtrl1);
                motion_form.Show();
            }
        }

        private void BUTTON_OPTIMIZE_PERFORMANCE_Click( object sender, EventArgs e )
        {
            if (Application.OpenForms.OfType<optimize_performance_frm>().Count() == 0)
            {
                optimize_performance_frm motiooptimize_performance_form = new optimize_performance_frm(axScSamlightClientCtrl1);
                motiooptimize_performance_form.Show();
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        //private void BUTTON_CHANGE_TEXT_BY_NAME_Click(object sender, EventArgs e)
        //{

        //}

        

        private void BUTTON_CHANGE_TEXT_BY_NAME_Click(object sender, EventArgs e)
        {
            if (m_samlight.ScIsRunning() == 0)
            {
                MessageBox.Show("SAMLight not found", "Warning", MessageBoxButtons.OK);
                return;
            }

            m_samlight.ScChangeTextByName(EDIT_ENTITY_NAME.Text, EDIT_TEXT_STRING.Text);
            m_samlight.ScChangeTextByName(HeatCodeText.Text, HeatCodeEdit.Text);
            EDIT_TEXT_STRING.Text = (Convert.ToInt64(EDIT_TEXT_STRING.Text) + 1).ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (m_samlight.ScIsRunning() == 0)
            {
                MessageBox.Show("SAMLight not found", "Warning", MessageBoxButtons.OK);
                return;
            }

            m_samlight.ScChangeTextByName(HeatCodeText.Text, HeatCodeEdit.Text);
            
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}
