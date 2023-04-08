using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braking_distance
{
    public partial class FConnectDB : Form
    {
        public FConnectDB()
        {
            InitializeComponent();
        }

        private async void BSave_Click(object sender, EventArgs e)
        {
            if (groupBoxUser.Enabled)
            {
                if (string.IsNullOrEmpty(textBoxServer.Text) && string.IsNullOrEmpty(textBoxDB.Text) && string.IsNullOrEmpty(textBoxUser.Text)
                    && string.IsNullOrEmpty(textBoxPassword.Text) )
                {
                    MessageBox.Show($"Не всі поля заповнені", "Примітка",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string server = textBoxServer.Text;
                string databaseName = textBoxDB.Text;
                string databaseUser = textBoxUser.Text;
                string databasePassword = textBoxPassword.Text;

                Properties.Settings.Default.ConnectionString_2 = $"Data Source = {server};  Initial Catalog = master; User ID = {databaseUser}; Password = {databasePassword};";
               
                System.Data.SqlClient.SqlDataReader reader;
                System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString_2);
                await sqlConnection.OpenAsync();

                using (System.Data.SqlClient.SqlCommand sqlCommand = new System.Data.SqlClient.SqlCommand($"SELECT database_id FROM sys.databases WHERE Name = '{databaseName}'", sqlConnection))
                {
                    object result = sqlCommand.ExecuteScalar();

                    if (result == null)
                    {
                        sqlCommand.CommandText = $"CREATE DATABASE {databaseName}";
                        reader = sqlCommand.ExecuteReader();
                        reader.Close();

                        System.Data.SqlClient.SqlDataReader reader_2;
                        Properties.Settings.Default.ConnectionString = $"Data Source = {server};  Initial Catalog = {databaseName}; User ID = {databaseUser}; Password = {databasePassword};";
                        
                        System.Data.SqlClient.SqlConnection sqlConnection_2 = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString);

                        System.Data.SqlClient.SqlCommand sqlCommand_2 = new System.Data.SqlClient.SqlCommand();
                        sqlCommand_2.Connection = sqlConnection_2;

                        await sqlConnection_2.OpenAsync();

                        string createTableLevel = "CREATE TABLE TInfo(id_info int not null identity(1, 1) primary key, TDate date not null, TPogoda nvarchar(50) not null," +
                                " TPokrutyaDorig nvarchar(50) not null, TStanProkrutyaDorig nvarchar(50) not null, TTupShunu nvarchar(50) not null," +
                                " TShurunaShunu int not null, TVusotaShunu int not null, TDiametrShunu int not null, TMasaAvto int not null, TSvudkist float not null," +
                                " TStanGlm nvarchar(50) not null, TResult float not null)";

                        sqlCommand_2.CommandText = createTableLevel;
                        reader_2 = sqlCommand_2.ExecuteReader();
                        reader_2.Close();

                        Properties.Settings.Default.Save();
                        MessageBox.Show($"Підключення до SQL server відкрито. А також створено БД та таблиці", "Примітка",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        MessageBox.Show($"База даних вже підключено!", "Примітка",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
           else
            {
                if (groupBoxUser.Enabled)
                {
                    if (string.IsNullOrEmpty(textBoxServer.Text) && string.IsNullOrEmpty(textBoxDB.Text))
                    {
                        MessageBox.Show($"Не всі поля заповнені", "Примітка",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    string server = textBoxServer.Text;
                    string databaseName = textBoxDB.Text;

                    Properties.Settings.Default.ConnectionString_3 = $"Data Source = {server};  Initial Catalog = master; Trusted_Connection=True;";


                    System.Data.SqlClient.SqlDataReader reader;
                    System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString_3);
                    await sqlConnection.OpenAsync();

                    using (System.Data.SqlClient.SqlCommand sqlCommand = new System.Data.SqlClient.SqlCommand($"SELECT database_id FROM sys.databases WHERE Name = '{databaseName}'", sqlConnection))
                    {
                        object result = sqlCommand.ExecuteScalar();

                        if (result == null)
                        {
                            sqlCommand.CommandText = $"CREATE DATABASE {databaseName}";
                            reader = sqlCommand.ExecuteReader();
                            reader.Close();

                            System.Data.SqlClient.SqlDataReader reader_2;
                            Properties.Settings.Default.ConnectionString_4 = $"Data Source = {server};  Initial Catalog = {databaseName}; Trusted_Connection=True;";
                           
                            System.Data.SqlClient.SqlConnection sqlConnection_2 = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString_4);

                            System.Data.SqlClient.SqlCommand sqlCommand_2 = new System.Data.SqlClient.SqlCommand();
                            sqlCommand_2.Connection = sqlConnection_2;

                            await sqlConnection_2.OpenAsync();

                            string createTableLevel = "CREATE TABLE TInfo(id_info int not null identity(1, 1) primary key, TDate date not null, TPogoda nvarchar(50) not null," +
                                " TPokrutyaDorig nvarchar(50) not null, TStanProkrutyaDorig nvarchar(50) not null, TTupShunu nvarchar(50) not null," +
                                " TShurunaShunu int not null, TVusotaShunu int not null, TDiametrShunu int not null, TMasaAvto int not null, TSvudkist float not null," +
                                "  TStanGlm nvarchar(50) not null, TResult float not null)";

                            sqlCommand_2.CommandText = createTableLevel;
                            reader_2 = sqlCommand_2.ExecuteReader();
                            reader_2.Close();

                            Properties.Settings.Default.Save();
                            MessageBox.Show($"Підключення до SQL server відкрито. А також створено БД та таблиці", "Примітка",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {

                            MessageBox.Show($"База даних вже підключено!", "Примітка",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }    
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUser.Checked)
            {
                groupBoxUser.Enabled = true;
            }
           else
            {
                groupBoxUser.Enabled = false;
            }
        }
    }
}
