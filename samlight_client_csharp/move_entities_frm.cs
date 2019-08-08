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
    public partial class move_entities_frm : Form
    {
        AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl m_samlight;
        public move_entities_frm( AxSAMLIGHT_CLIENT_CTRL_OCXLib.AxScSamlightClientCtrl p_samlight )
        {
            InitializeComponent();
            m_samlight = p_samlight;
        }

        private void BUTTON_TRANSLATE_Click( object sender, EventArgs e )
        {
            m_samlight.ScTranslateEntity( EDIT_ENTITY_NAME.Text, Convert.ToDouble( EDIT_X.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_Y.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_Z.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_OPTIC_MATRIX_TRANSLATE_Click( object sender, EventArgs e )
        {
            m_samlight.ScOpticMatrixReset();
            m_samlight.ScOpticMatrixTranslate( Convert.ToDouble( EDIT_X.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_Y.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_Z.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_SCALE_Click( object sender, EventArgs e )
        {
            m_samlight.ScScaleEntity( EDIT_ENTITY_NAME.Text, Convert.ToDouble( EDIT_X.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_Y.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_Z.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_OPTIC_MATRIX_SCALE_Click( object sender, EventArgs e )
        {
            m_samlight.ScOpticMatrixReset();
            m_samlight.ScOpticMatrixScale( Convert.ToDouble( EDIT_X.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_Y.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_ROTATE_Click( object sender, EventArgs e )
        {
            m_samlight.ScRotateEntity( EDIT_ENTITY_NAME.Text, Convert.ToDouble( EDIT_CENTER_X.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_CENTER_Y.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_ANGLE.Text, CultureInfo.InvariantCulture ) );
        }

        private void BUTTON_OPTIC_MATRIX_ROTATE_Click( object sender, EventArgs e )
        {
            m_samlight.ScOpticMatrixReset();
            m_samlight.ScOpticMatrixRotate( Convert.ToDouble( EDIT_CENTER_X.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_CENTER_Y.Text, CultureInfo.InvariantCulture ), Convert.ToDouble( EDIT_ANGLE.Text, CultureInfo.InvariantCulture ) );
        }
    }
}
