using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace EOKUL
{
    class baglanti
    {
        public SqlConnection sqlbaglanti()
        {
            SqlConnection baglan = new SqlConnection(HelperStaticMethods.ReadConnectionString());
            baglan.Open();
            //Initial Catalog name 'eOkul'
            baglan.ChangeDatabase("eOkul");
            return baglan;
        }
    }
}
