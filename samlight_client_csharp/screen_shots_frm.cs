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
    public partial class screen_shots_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        double m_size = 0;
        public screen_shots_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
            string s;
            s = String.Format( "{0}", 160 );
            COMBO_SIZE.Items.Add( s );
            s = String.Format( "{0}", 320 );
            COMBO_SIZE.Items.Add( s );
            s = String.Format( "full" );
            COMBO_SIZE.Items.Add( s );
            COMBO_SIZE.SelectedIndex = 0;
            EDIT_FILE_NAME.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\SAMLight_View2D_screenshot160.bmp";

            comboBox_line_size.Items.Add("Normal");
            comboBox_line_size.Items.Add("Thick");

            EDIT_FILE_NAME_DPI.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\SAMLight_View2D_screenshotAdjDPINormal200.bmp";
            comboBox_line_size.SelectedIndex = 0;
        }

        private void COMBO_SIZE_SelectedIndexChanged( object sender, EventArgs e )
        {
            m_size = COMBO_SIZE.SelectedIndex;
            EDIT_FILE_NAME.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\SAMLight_View2D_screenshot" + COMBO_SIZE.SelectedItem.ToString() + ".bmp";
        }

        private void BUTTON_CHANGE_VARIABLE_SIZE_Click( object sender, EventArgs e )
        {
            m_size = Convert.ToDouble( EDIT_VARIABLE_SIZE.Text, CultureInfo.InvariantCulture );
        }

        private void BUTTON_SAVE_SCREEN_SHOT_Click( object sender, EventArgs e )
        {
            if( m_size == 0 )
                m_samlight.ScSetStringValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeSaveView2D160, EDIT_FILE_NAME.Text );
            else if( m_size == 1 )
                m_samlight.ScSetStringValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeSaveView2D320, EDIT_FILE_NAME.Text );
            else if( m_size == 2 )
                m_samlight.ScSetStringValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeSaveView2DFull, EDIT_FILE_NAME.Text );
            else
            {
                // Making screen shot of arbitrary size
                m_samlight.ScSetDoubleValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeSaveView2DBitmapVariableSize, m_size );
                m_samlight.ScSetStringValue( ( int )ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeSaveView2DVariableSize, EDIT_FILE_NAME.Text );
            }
        }

        private void comboBox_line_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            EDIT_FILE_NAME_DPI.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\SAMLight_View2D_screenshotAdjDPI" + comboBox_line_size.SelectedItem.ToString() + textBox_size_dpi.Text + ".bmp";
        }

        private void BUTTON_SAVE_SCREEN_SHOTS_DPI_Click(object sender, EventArgs e)
        {
            m_samlight.ScSetDoubleValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlDoubleValueTypeSaveView2DBitmapDPI, Convert.ToDouble(textBox_size_dpi.Text, CultureInfo.InvariantCulture));
            m_samlight.ScSetLongValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlLongValueTypeSaveView2DBitmapMode, comboBox_line_size.SelectedIndex); //  0: lines and pixels are drawn normal, 1: lines and pixels are drawn thicker
            m_samlight.ScSetStringValue((int)ScComSAMLightClientCtrlValueTypes.scComSAMLightClientCtrlStringValueTypeSaveView2DAdjustableDPI, EDIT_FILE_NAME_DPI.Text);
        }

        private void button_set_dpi_Click(object sender, EventArgs e)
        {
            EDIT_FILE_NAME_DPI.Text = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory) + "\\SAMLight_View2D_screenshotAdjDPI" + comboBox_line_size.SelectedItem.ToString() + textBox_size_dpi.Text + ".bmp";
        }
    }
}
