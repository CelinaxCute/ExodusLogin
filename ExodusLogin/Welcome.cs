using Newtonsoft.Json;

namespace ExodusLogin
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void SetLogin_Click(object sender, EventArgs e)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolderPath = Path.Combine(appDataPath, "Exodus Client"); //This get the Appdata folder
                                                                               //and combine it with ExodusFolder

            if (!Directory.Exists(appFolderPath))
            {
                Directory.CreateDirectory(appFolderPath);
            }

            string filePath = Path.Combine(appFolderPath, "Credentials.json");

            MyJsonObject jsonObject = new MyJsonObject
            {
                E = MailBox.Text,
                P = PasswordBox.Text
            };

            string jsonContent = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

            File.WriteAllText(filePath, jsonContent);

            MessageBox.Show("Login Success Set");

        }
    }
}



public class MyJsonObject
{
    [JsonProperty("e")]
    public string E { get; set; }

    [JsonProperty("p")]
    public string P { get; set; }
}