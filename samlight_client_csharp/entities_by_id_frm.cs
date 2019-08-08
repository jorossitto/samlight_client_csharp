using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using SAMLIGHT_CLIENT_CTRL_OCXLib;

namespace samlight_client_csharp
{
    public partial class entities_by_id_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;

        public entities_by_id_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
            label_access_by_id.Text = "Iterating through the job loaded and saving the tree structure of entities (name and type) to a *.txt file";
            EDIT_FILE_PATH.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\Job_Tree.txt";
        }

        private void BUTTON_GET_MARK_BEAT_COUNT_Click( object sender, EventArgs e )
        {
             string name = "";
            
            m_samlight.ScGetIDStringData( ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdGetToplevelEntity, Convert.ToInt32( EDIT_ID.Text, CultureInfo.InvariantCulture ), ref name );
            m_samlight.ScSetIDStringData( ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdSetToplevelEntity, Convert.ToInt32( EDIT_ID.Text, CultureInfo.InvariantCulture ), "temp_name" );
            EDIT_MARK_BEAT_COUNT.Text = Convert.ToString( m_samlight.ScGetEntityLongData( "temp_name", ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkBeatCount ), CultureInfo.InvariantCulture );
            m_samlight.ScSetIDStringData( ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdSetToplevelEntity, Convert.ToInt32( EDIT_ID.Text, CultureInfo.InvariantCulture ), name );
        }

        private void BUTTON_CHANGE_MARK_BEAT_COUNT_Click( object sender, EventArgs e )
        {
            string name = "";
            m_samlight.ScGetIDStringData( ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdGetToplevelEntity, Convert.ToInt32( EDIT_ID.Text, CultureInfo.InvariantCulture ), ref name );
            m_samlight.ScSetIDStringData( ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdSetToplevelEntity, Convert.ToInt32( EDIT_ID.Text, CultureInfo.InvariantCulture ), "temp_name" );
            m_samlight.ScSetEntityLongData( "temp_name", ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkBeatCount, Convert.ToInt32( EDIT_MARK_BEAT_COUNT.Text, CultureInfo.InvariantCulture ) );
            m_samlight.ScSetIDStringData( ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdSetToplevelEntity, Convert.ToInt32( EDIT_ID.Text, CultureInfo.InvariantCulture ), name );
        }

        private void BUTTON_GET_ENTITY_TYPE_Click(object sender, EventArgs e)
        {
            string type = "";
            m_samlight.ScGetIDStringData((int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdGetEntityType, Convert.ToInt32(EDIT_ID.Text, CultureInfo.InvariantCulture) | (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdFlagToplevelOnly, ref type);
            EDIT_ENTITY_TYPE.Text = type;
        }

        private void BUTTON_GET_ENTITY_NAME_Click(object sender, EventArgs e)
        {
            string name = "";

            m_samlight.ScGetIDStringData((int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdGetToplevelEntity, Convert.ToInt32(EDIT_ID.Text, CultureInfo.InvariantCulture), ref name);
            EDIT_ENTITY_NAME.Text = name;
        }

        private void BUTTON_SET_ENTITY_NAME_Click(object sender, EventArgs e)
        {
            m_samlight.ScSetIDStringData((int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdSetToplevelEntity, Convert.ToInt32(EDIT_ID.Text, CultureInfo.InvariantCulture), EDIT_ENTITY_NAME.Text);
        }

        private void checkBox_top_level_entity_CheckedChanged(object sender, EventArgs e)
        {
            int top_level_only;
            if (checkBox_top_level_entity.Checked)
                top_level_only = 1;
            else
                top_level_only = 0;
            m_samlight.ScSetMode(top_level_only);
        }

        private void button_access_by_id_Click(object sender, EventArgs e)
        {
            m_samlight.ScSetStringValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeSetToTopLevelEntity, "");
            int numTopEntities = m_samlight.ScGetLongValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeTopLevelEntityNum);
            int tab = 0;
            String pFileName = EDIT_FILE_PATH.Text;
            StreamWriter myFile = File.CreateText(pFileName);
            if (File.Exists(pFileName))
            {                
                iterate_and_save(numTopEntities, "", "", "", myFile, tab);
                myFile.Close();
            }

        }


        private void iterate_and_save(long numEntities, String top_level_ent_name, String top_level_ent_type, String prev_top_level_ent_name, StreamWriter myFile, int tab)
        {
            String name =  "";
            String entity_type = "";

            for (int i = 0; i < numEntities; i++)
            {
                if (top_level_ent_type == "Group" && i == 0)
                {
                    numEntities++;
                    continue;
                }
                m_samlight.ScGetIDStringData((int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdGetToplevelEntity, i, ref name);
                m_samlight.ScGetIDStringData((int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdGetEntityType, i | (int)ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlStringDataIdFlagToplevelOnly, ref entity_type);

                String toBeWritten, Tab = "", type, Cname;
                type = entity_type;
                Cname = name;

                for (int j = 0; j < tab; j++)
                {
                    Tab = Tab + "\t";
                }
                toBeWritten = Tab + Cname + "->" + type + "\n";
                myFile.WriteLine(toBeWritten);

                if (type == "Group")
                {
                    tab++;
                    prev_top_level_ent_name = top_level_ent_name;
                    top_level_ent_name = name;
                    top_level_ent_type = type;
                    m_samlight.ScSetStringValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeSetToTopLevelEntity, top_level_ent_name);
                    int numSubEntities = m_samlight.ScGetLongValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeTopLevelEntityNum);
                    iterate_and_save(numSubEntities, top_level_ent_name, top_level_ent_type, prev_top_level_ent_name,  myFile, tab);
                    m_samlight.ScSetStringValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeSetToTopLevelEntity, "");
                    m_samlight.ScSetStringValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeSetToTopLevelEntity, prev_top_level_ent_name);
                    top_level_ent_name = prev_top_level_ent_name;
                    tab--;
                }
            }
        }

        private void button_change_path_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt) | *.txt | All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            openFileDialog1.FileName = "Job_Tree.txt";

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                EDIT_FILE_PATH.Text = openFileDialog1.FileName;
            }
        }
    }
}
