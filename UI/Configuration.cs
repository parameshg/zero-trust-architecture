using System.ComponentModel;

namespace UI
{
    public class Configuration
    {
        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Vault")]
        [DisplayName("Endpoint")]
        [PasswordPropertyText(false)]
        [Description("Vault Server Url")]
        public string? Endpoint { get; set; } = "http://localhost:8200";

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("Vault")]
        [DisplayName("Token")]
        [PasswordPropertyText(true)]
        [Description("Vault Root Token")]
        public string? RootToken { get; set; }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("AWS")]
        [DisplayName("Access Key")]
        [PasswordPropertyText(false)]
        [Description("AWS Access Key ID")]
        public string? AWS_Access_Key { get; set; }

        [Browsable(true)]
        [ReadOnly(false)]
        [Category("AWS")]
        [DisplayName("Secret Key")]
        [PasswordPropertyText(true)]
        [Description("AWS Secret Access Key")]
        public string? AWS_Secret_Key { get; set; }
    }
}