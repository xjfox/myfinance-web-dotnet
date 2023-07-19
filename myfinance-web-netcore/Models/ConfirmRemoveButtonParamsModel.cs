namespace myfinance_web_netcore.Models
{
    public class ConfirmRemoveButtonParamsModel
    {
        public int Id { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string ConfirmMessage { get; set; }
    }
}