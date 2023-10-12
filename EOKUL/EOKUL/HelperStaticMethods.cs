
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOKUL
{
    public static class HelperStaticMethods
    {
        private static string settingFilePath = GetCurrentPath() + Path.DirectorySeparatorChar + @"dbsetting.txt";
        

        /// <summary>
        /// Uygulamanın çalıştığı dizini getir.
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentPath()
        {
            return System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        }

        public static bool IsSettingFileExists()
        {
            return File.Exists(settingFilePath);
        }

        private static string ReadFileContent(string fileFullPath)
        {
            string response = String.Empty;
            if (IsSettingFileExists())
            {
                response = File.ReadAllText(fileFullPath);
            }
            return response;
        }
        public static string ReadConnectionString()
        {
            string response = String.Empty;
            if(IsSettingFileExists())
            {
                response = File.ReadAllText(settingFilePath);
            }
            return response;
        }

        public static bool OwerriteConnectionString(string connectionString)
        {
            bool response = false;
            try
            {
                File.WriteAllText(settingFilePath, connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ayarlar yazılırken bir hata oluştu!"+ ex.Message);
            }
            return response;
        }
        public static bool IsConnectionAlive(String cs)
        {
            bool response = false;
            try
            {
                using (SqlConnection baglan = new SqlConnection(cs))
                {
                    baglan.Open();
                    baglan.ChangeDatabase("master");
                }
                response = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kontrol edilirken bir sorun oluştu: " + ex.Message);
            }
            return response;
        }
        public static bool IsDbAlive()
        {
            bool response = false;
            try
            {
                using(SqlConnection baglan = new SqlConnection(ReadConnectionString()))
                {
                    baglan.Open();
                    using (SqlCommand cmd = new SqlCommand("select count(1) from sysdatabases where name = 'eOkul'", baglan))
                    {   
                        baglan.ChangeDatabase("master");
                        response = ((int)cmd.ExecuteScalar() > 0) ? true : false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kontrol edilirken bir sorun oluştu: "+ ex.Message);
            }
            return response;
        }

        public static bool CreateDatabase(string connectionString)
        {
            bool response = false;

            string sqlCommand = ReadFileContent(GetCurrentPath() + Path.DirectorySeparatorChar + @"DataScript.sql");
            try
            {
                using (SqlConnection baglan = new SqlConnection(ReadConnectionString()))
                {
                    baglan.Open();
                    using(var createCommand = new  SqlCommand("CREATE DATABASE [eOkul];", baglan))
                    {
                        createCommand.ExecuteNonQuery();
                    }
                    baglan.ChangeDatabase("eOkul");
                    using (SqlCommand cmd = new SqlCommand(sqlCommand, baglan))
                    {
                        response = ((int)cmd.ExecuteNonQuery() > 0) ? true : false;
                    }
                }
                response = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı oluşturulurken bir hata oluştu " + ex.Message);
            }
            return response;
        }
    }
}
