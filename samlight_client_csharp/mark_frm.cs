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
    public partial class mark_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        string m_text_is_marking = "";
        public mark_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
        }

        private void BUTTON_GET_LAST_MARK_TIME_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            double mark_time = 0.0;
            mark_time = m_samlight.ScGetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeLastMarkTime );
            String mark_time_string = String.Concat( "Last mark time was: ", mark_time, " seconds" );
            MessageBox.Show( mark_time_string, "Info", MessageBoxButtons.OK );
        }

        private void BUTTON_ROTATE_TEST_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            double min_x, min_y, max_x, max_y;
            double center_x, center_y;
            double ang_inc;
            double act_angle;
            long save_mark_flags;
            String entity_name = EDIT_ENTITY_NAME.Text;

            // first we calculate the center of the entity

            min_x = m_samlight.ScGetEntityOutline( entity_name, 0 );
            min_y = m_samlight.ScGetEntityOutline( entity_name, 1 );
            max_x = m_samlight.ScGetEntityOutline( entity_name, 3 );
            max_y = m_samlight.ScGetEntityOutline( entity_name, 4 );
            center_x = ( min_x + max_x ) / 2.0;
            center_y = ( min_y + max_y ) / 2.0;

            save_mark_flags = m_samlight.ScGetMarkFlags();
            m_samlight.ScSetMarkFlags( ( int )save_mark_flags | 0x4 );
            // here we do the loop

            ang_inc = ( 360.0 / 20.0 ) * Math.PI / 180.0;
            act_angle = 0.0;
            for( int i = 0; i < 20; i++ )
            {
                m_samlight.ScOpticMatrixReset();
                m_samlight.ScOpticMatrixRotate( center_x, center_y, act_angle );
                //		m_samlight.ScOpticMatrixTranslate(0,0,5*i);
                m_samlight.ScMarkEntityByName( entity_name, 1 );
                act_angle = act_angle + ang_inc;
            }
            m_samlight.ScOpticMatrixReset();
            m_samlight.ScSetMarkFlags( ( int )save_mark_flags );
        }

        private void BUTTON_RESET_SEQUENCE_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScExecCommand( 2 );
        }

        private void BUTTON_MARK_SELECTED_ENTITIES_Click( object sender, EventArgs e )
        {

            int flags = 0;
            m_samlight.ScSetMarkFlags( ( int )ScComSAMLightClientCtrlMarkFlags.scComSAMLightClientCtrlMarkFlagSelected );
            m_samlight.ScMarkEntityByName("", flags);
        }

        private void BUTTON_MARK_ENTITY_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            mark_entity( EDIT_ENTITY_NAME.Text );
        }

        private void BUTTON_MARK_ALL_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }

            mark_entity( "" );
        }

        private void BUTTON_STOP_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            m_samlight.ScStopMarking();
        }

        private void BUTTON_SET_MARK_FLAGS_Click( object sender, EventArgs e )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return;
            }
            long flags = 0;
            if( CHECK_MARK_CONTOUR.Checked == true )
                flags |= ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkFlagMarkContour;
            if( CHECK_MARK_HATCH.Checked == true )
                flags |= ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkFlagMarkHatch;

            m_samlight.ScSetEntityLongData( EDIT_ENTITY_NAME.Text, ( int )ScComSAMLightClientCtrlFlags.scComSAMLightClientCtrlLongDataIdEntityMarkFlags, ( int )flags );
        }

        private void BUTTON_GET_SLICE_FROM_Click( object sender, EventArgs e )
        {
            EDIT_SLICE_FROM.Text = Convert.ToString( m_samlight.ScGetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeSliceFrom ), CultureInfo.InvariantCulture );
            ;

        }

        private void BUTTON_CHANGE_SLICE_FROM_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeSliceFrom, Convert.ToInt32( EDIT_SLICE_FROM.Text) );

        }

        private void BUTTON_GET_SLICE_TO_Click( object sender, EventArgs e )
        {
            EDIT_SLICE_TO.Text = Convert.ToString( m_samlight.ScGetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeSliceTo ), CultureInfo.InvariantCulture );

        }

        private void BUTTON_CHANGE_SLICE_TO_Click( object sender, EventArgs e )
        {
            m_samlight.ScSetLongValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeSliceTo, Convert.ToInt32(EDIT_SLICE_TO.Text) );

        }

        private void BUTTON_3D_MARK_Click( object sender, EventArgs e )
        {
            m_samlight.ScMarkEntityByName( "@@@Scaps.SpecialTag.3d.All.Layers@@@", 0 );

        }

        private int mark_entity( String entity_name_to_mark )
        {
            if( m_samlight.ScIsRunning() == 0 )
            {
                MessageBox.Show( "SAMLight not found", "Warning", MessageBoxButtons.OK );
                return 0;
            }

            m_text_is_marking = "Sending Objects!";
            STATIC_IS_MARKING.Text = m_text_is_marking;
            long mark_flags = 0x0;
            m_samlight.ScSetMarkFlags( ( int )mark_flags );

            m_samlight.ScMarkEntityByName( entity_name_to_mark, 0 );
            m_text_is_marking = "Marking!";
            STATIC_IS_MARKING.Text = m_text_is_marking;

            //enable_all_windows( false );
            int i = 0;
            while( true )
            {
                i++;
                Application.DoEvents();
                if( i % 10 == 0 )
                {
                    if( m_samlight.ScIsMarking() == 0 )
                        break;
                }
            }
            m_samlight.ScStopMarking();
            m_text_is_marking = "Idle!";
            STATIC_IS_MARKING.Text = m_text_is_marking;
    //        enable_all_windows( true );
            return 1;
        }
    }
}
