using System;
using System.IO;
using System.Windows.Forms;
using CoHook.Database;
using CoHook.Extentions.IO;

namespace CoHook.Window
{
    public partial class FrmConfig : Form
    {
        private OpenFileDialog opfDialog;

        public FrmConfig()
        {
            InitializeComponent();
            opfDialog = new OpenFileDialog();
            opfDialog.Filter = "Conquer (.exe)|Conquer.exe";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DbConfig config = new DbConfig();
            config.ConquerDirectory = txtConquerPath.Text;
            config.Effects = true;

            Serializer.Serialize<DbConfig>(@"Database\config.coh", config);

            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (opfDialog.ShowDialog() == DialogResult.OK)
            {
                txtConquerPath.Text = Path.GetDirectoryName(opfDialog.FileName);
            }
        }
    }
}
