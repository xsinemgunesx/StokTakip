namespace StokTakip.WepApp.Models
{
    public class ErrorViewModel//bir hata varsa gösteren sýnýf
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}