using Newtonsoft.Json;
using RestSharp;
using UI.Properties;

namespace UI
{
    public partial class MainWin : Form
    {
        private Configuration? Configuration { get; set; } = new Configuration();

        public MainWin()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Settings.Default.Configuration))
            {
                Configuration = JsonConvert.DeserializeObject<Configuration>(Settings.Default.Configuration);
            }

            pVault.SelectedObject = Configuration;
        }

        private void OnUnload(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Configuration = JsonConvert.SerializeObject(Configuration);

            Settings.Default.Save();
        }

        private async void OnEnableAwsAuth(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Configuration?.Endpoint) && !string.IsNullOrWhiteSpace(Configuration.RootToken))
                {
                    using (var api = new RestClient(Configuration.Endpoint))
                    {
                        var request = new RestRequest("/v1/sys/auth/aws", Method.Post);

                        request.AddHeader("X-Vault-Token", Configuration.RootToken);

                        request.AddBody(JsonConvert.SerializeObject(new
                        {
                            type = "aws"
                        }));

                        await api.ExecuteAsync(request);

                        txtMessage.Text = "Command completed successfully";
                    }
                }
            }
            catch (Exception error)
            {
                txtMessage.Text = error.ToString();
            }
        }

        private async void OnDisableAwsAuth(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Configuration?.Endpoint) && !string.IsNullOrWhiteSpace(Configuration.RootToken))
                {
                    using (var api = new RestClient(Configuration.Endpoint))
                    {
                        var request = new RestRequest("/v1/sys/auth/aws", Method.Delete);

                        request.AddHeader("X-Vault-Token", Configuration.RootToken);

                        request.AddBody(JsonConvert.SerializeObject(new
                        {
                            type = "aws"
                        }));

                        await api.ExecuteAsync(request);

                        txtMessage.Text = "Command completed successfully";
                    }
                }
            }
            catch (Exception error)
            {
                txtMessage.Text = error.ToString();
            }
        }

        private async void OnSetAwsConfiguration(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Configuration?.Endpoint) && !string.IsNullOrWhiteSpace(Configuration.RootToken))
                {
                    using (var api = new RestClient(Configuration.Endpoint))
                    {
                        var request = new RestRequest("/v1/auth/aws/config/client", Method.Post);

                        request.AddHeader("X-Vault-Token", Configuration.RootToken);

                        request.AddBody(JsonConvert.SerializeObject(new
                        {
                            access_key = Configuration.AWS_Access_Key,
                            secret_key = Configuration.AWS_Secret_Key
                        }));

                        await api.ExecuteAsync(request);

                        txtMessage.Text = "Command completed successfully";
                    }
                }
            }
            catch (Exception error)
            {
                txtMessage.Text = error.ToString();
            }
        }

        private async void OnGetAwsConfiguration(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Configuration?.Endpoint) && !string.IsNullOrWhiteSpace(Configuration.RootToken))
                {
                    using (var api = new RestClient(Configuration.Endpoint))
                    {
                        var request = new RestRequest("/v1/auth/aws/config/client", Method.Get);

                        request.AddHeader("X-Vault-Token", Configuration.RootToken);

                        var response = await api.ExecuteAsync(request);

                        if (response != null && response.IsSuccessful)
                        {
                            txtMessage.Text = response.Content;
                        }
                    }
                }
            }
            catch (Exception error)
            {
                txtMessage.Text = error.ToString();
            }
        }
    }
}