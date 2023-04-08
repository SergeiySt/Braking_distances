using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braking_distance
{
    public partial class FCalculator : Form
    {
        public FCalculator()
        {
            InitializeComponent();
            LoadDateBaseInfo();
        }

        private void FCalculator_Load(object sender, EventArgs e)
        {

            weatherComboBox.Items.Add("Дощ");
            weatherComboBox.Items.Add("Сніг");
            weatherComboBox.Items.Add("Сухо");
            weatherComboBox.SelectedIndex = 2; 

          
            roadTypeComboBox.Items.Add("Асфальт");
            roadTypeComboBox.Items.Add("Бетон");
            roadTypeComboBox.Items.Add("Гравій");
            roadTypeComboBox.SelectedIndex = 0; 

  
            roadConditionComboBox.Items.Add("Сухе");
            roadConditionComboBox.Items.Add("Мокре");
            roadConditionComboBox.Items.Add("Засніжане");
            roadConditionComboBox.Items.Add("Ожеледиця");
            roadConditionComboBox.SelectedIndex = 0; 

   
            tireTypeComboBox.Items.Add("Зимові");
            tireTypeComboBox.Items.Add("Літні");
            tireTypeComboBox.Items.Add("Всесезонні");
            tireTypeComboBox.SelectedIndex = 2; 

            brakesStatecomboBox.Items.Add("справні");
            brakesStatecomboBox.Items.Add("зношені");
            brakesStatecomboBox.Items.Add("несправні");
            brakesStatecomboBox.SelectedIndex = 0; 


            tireWidthTextBox.Text = "195";
            tireHeightTextBox.Text = "65";
            tireDiameterTextBox.Text = "15";


            carWeightTextBox.Text = "1500";
            textBoxSpeed.Text = "60";
        }

        private double CalculateFrictionCoefficient(string weather, string roadType, string roadCondition, string tireType)
        {
          
            double[,] frictionCoefficients = {
                  {0.95, 0.92, 0.85}, // Дождь
                  {0.90, 0.85, 0.80}, // Снег
                  {1.00, 0.95, 0.90}, // Сухо
                  {0.80, 0.75, 0.70}  // Гололедица
            };

       
            int weatherIndex = -1;
            int roadTypeIndex = -1;
            int roadConditionIndex = -1;
            int tireTypeIndex = -1;

            switch (weather)
            {
                case "Дощ":
                    weatherIndex = 0;
                    break;
                case "Сніг":
                    weatherIndex = 1;
                    break;
                case "Сухо":
                    weatherIndex = 2;
                    break;
            }

            switch (roadType)
            {
                case "Асфальт":
                    roadTypeIndex = 0;
                    break;
                case "Бетон":
                    roadTypeIndex = 1;
                    break;
                case "Гравій":
                    roadTypeIndex = 2;
                    break;
            }

            switch (roadCondition)
            {
                case "Сухе":
                    roadConditionIndex = 0;
                    break;
                case "Мокре":
                    roadConditionIndex = 1;
                    break;
                case "Засніжане":
                    roadConditionIndex = 2;
                    break;
                case "Ожеледиця":
                    roadConditionIndex = 3;
                    break;
            }

            switch (tireType)
            {
                case "Зимові":
                    tireTypeIndex = 0;
                    break;
                case "Літні":
                    tireTypeIndex = 1;
                    break;
                case "Всесезонні":
                    tireTypeIndex = 2;
                    break;
            }

            double frictionCoefficient = frictionCoefficients[weatherIndex, roadTypeIndex] * frictionCoefficients[roadConditionIndex, tireTypeIndex];
            return frictionCoefficient;
        }

        private static double CalculateBrakingDistance(double frictionCoefficient, int tireWidth, int tireHeight, int tireDiameter, string brakesState, int carWeight, int speed)
        {
            double tireRadius = (tireHeight * 0.001 * tireWidth * 0.001 + 2 * tireDiameter * 0.0254) / 2;
            double carMass = carWeight / 1000.0;
            double brakingDistance;

            if (brakesState == "справні")
            {
                double acceleration = frictionCoefficient * 9.8 * tireRadius / 0.3;
                double brakingTime = speed / (3.6 * acceleration);
                brakingDistance = speed / 3.6 * brakingTime;
            }
            else if (brakesState == "зношені")
            {
                double acceleration = frictionCoefficient * 9.8 * 0.7 * tireRadius / 0.3;
                double brakingTime = speed / (3.6 * acceleration);
                brakingDistance = speed / 3.6 * brakingTime * 1.3;
            }
            else // brakesState == "несправні"
            {
                double acceleration = frictionCoefficient * 9.8 * 0.4 * tireRadius / 0.3;
                double brakingTime = speed / (3.6 * acceleration);
                brakingDistance = speed / 3.6 * brakingTime * 1.6;
            }

            return brakingDistance + carMass * 0.01;
        }

        private async void LoadDateBaseInfo()
        {
            using (System.Data.SqlClient.SqlConnection sqlConnection_3 = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                System.Data.SqlClient.SqlDataReader reader_3;
                await sqlConnection_3.OpenAsync();

                string selectInfo = "SELECT id_info, TDate, TPogoda, TPokrutyaDorig, TStanProkrutyaDorig, TTupShunu, TShurunaShunu, TVusotaShunu, " +
                    "TDiametrShunu, TMasaAvto, TSvudkist, TStanGlm, TResult FROM TInfo";

                System.Data.SqlClient.SqlCommand sqlCommand_3 = new System.Data.SqlClient.SqlCommand(selectInfo, sqlConnection_3);

                reader_3 = sqlCommand_3.ExecuteReader();
                
                if (reader_3.HasRows)
                {
                    labelInfo.Text = " ";
                    while (reader_3.Read())
                    {
                        labelInfo.Text += $" {reader_3["id_info"]}.    {reader_3["TDate"]}    {reader_3["TPogoda"]}    {reader_3["TPokrutyaDorig"]}    {reader_3["TStanProkrutyaDorig"]}    {reader_3["TTupShunu"]}" +
                            $"    {reader_3["TShurunaShunu"]}     {reader_3["TVusotaShunu"]}     {reader_3["TDiametrShunu"]}     {reader_3["TMasaAvto"]}     {reader_3["TSvudkist"]}     {reader_3["TStanGlm"]}" +
                            $"      {reader_3["TResult"]}\n";
                    }
                }

                reader_3.Close();
                sqlConnection_3.Close();
            }  
        }


        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void BResult_Click(object sender, EventArgs e)
        {
            string weather = weatherComboBox.SelectedItem.ToString();
            string roadType = roadTypeComboBox.SelectedItem.ToString();
            string roadCondition = roadConditionComboBox.SelectedItem.ToString();
            string tireType = tireTypeComboBox.SelectedItem.ToString();
            string brakesState = brakesStatecomboBox.SelectedItem.ToString();

            if (!int.TryParse(tireWidthTextBox.Text, out int tireWidth) ||
                !int.TryParse(tireHeightTextBox.Text, out int tireHeight) ||
                !int.TryParse(tireDiameterTextBox.Text, out int tireDiameter) ||
                !int.TryParse(carWeightTextBox.Text, out int carWeight) ||
                !int.TryParse(textBoxSpeed.Text, out int speed))
            {

                MessageBox.Show($"Повинно бути тільки числові значення!", "Примітка",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double frictionCoefficient = CalculateFrictionCoefficient(weather, roadType, roadCondition, tireType);
            double brakingDistance = CalculateBrakingDistance(frictionCoefficient, tireWidth, tireHeight, tireDiameter, brakesState, carWeight, speed);

            resultLabel.Text = $"Гальмівний шлях: {brakingDistance:F2} метрів";

            using (System.Data.SqlClient.SqlConnection sqlConnection_4 = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                DateTime dateTime = DateTime.Now;

                System.Data.SqlClient.SqlDataReader reader_4;
                await sqlConnection_4.OpenAsync();

                string selectInfo = "INSERT INTO TInfo (TDate, TPogoda, TPokrutyaDorig, TStanProkrutyaDorig, TTupShunu, TShurunaShunu, TVusotaShunu, " +
                    "TDiametrShunu, TMasaAvto, TSvudkist, TStanGlm, TResult) VALUES " +
                    "(@TDate, @TPogoda, @TPokrutyaDorig, @TStanProkrutyaDorig, @TTupShunu, @TShurunaShunu, @TVusotaShunu, " +
                    "@TDiametrShunu, @TMasaAvto, @TSvudkist, @TStanGlm, @TResult)";

                using (System.Data.SqlClient.SqlCommand sqlCommand_4 = new System.Data.SqlClient.SqlCommand(selectInfo, sqlConnection_4))
                {
                    sqlCommand_4.Parameters.AddWithValue("@TDate", dateTime);
                    sqlCommand_4.Parameters.AddWithValue("@TPogoda", weatherComboBox.SelectedItem.ToString());
                    sqlCommand_4.Parameters.AddWithValue("@TPokrutyaDorig", roadTypeComboBox.SelectedItem.ToString());
                    sqlCommand_4.Parameters.AddWithValue("@TStanProkrutyaDorig", roadConditionComboBox.SelectedItem.ToString());
                    sqlCommand_4.Parameters.AddWithValue("@TTupShunu", tireTypeComboBox.SelectedItem.ToString());
                    sqlCommand_4.Parameters.AddWithValue("@TShurunaShunu", int.Parse(tireWidthTextBox.Text));
                    sqlCommand_4.Parameters.AddWithValue("@TVusotaShunu", int.Parse(tireHeightTextBox.Text));
                    sqlCommand_4.Parameters.AddWithValue("@TDiametrShunu", int.Parse(tireDiameterTextBox.Text));
                    sqlCommand_4.Parameters.AddWithValue("@TMasaAvto", int.Parse(carWeightTextBox.Text));
                    sqlCommand_4.Parameters.AddWithValue("@TSvudkist", int.Parse(textBoxSpeed.Text));
                    sqlCommand_4.Parameters.AddWithValue("@TStanGlm", brakesStatecomboBox.SelectedItem.ToString());
                    sqlCommand_4.Parameters.AddWithValue("@TResult", brakingDistance);
                    
                    reader_4 = sqlCommand_4.ExecuteReader();
                    reader_4.Close();
                }
                LoadDateBaseInfo();
            }
        }

        private void BExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
