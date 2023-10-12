using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;

namespace EOKUL
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedEmployee = (string)comboBox.SelectedItem;
            if(selectedEmployee == "Hayır")
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
        }

        private string GetConnectionStringFromSettingPanel()
        {
            StringBuilder csTest = new StringBuilder();
            //"Data Source=DESKTOP-KF3O8M2;Integrated Security=True"
            //Data Source=DESKTOP-KF3O8M2;Initial Catalog=eOkul;Integrated Security=True
            csTest.Append($"Data Source={textBox1.Text};");
            if (comboBox1.Text == "Evet")
                csTest.Append($"Integrated Security=True;");
            else if(comboBox1.Text == "Hayır")
            {
                csTest.Append($"Integrated Security=False;");
                csTest.Append($"User ID={textBox2.Text};Password={textBox3.Text};");
            }
            return csTest.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                HelperStaticMethods.OwerriteConnectionString(GetConnectionStringFromSettingPanel());
            }
            catch (Exception)
            {

                throw;
            }
            MessageBox.Show("Ayarlar kaydedildi...");
         
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string cs = GetConnectionStringFromSettingPanel();

            try
            {
                if(HelperStaticMethods.IsConnectionAlive(cs) == true)
                    MessageBox.Show("Bağlantı başarılı. Kaydedin.");
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı sağlanamadı. Kontrol edin");
            }
           
        }
    }
}
