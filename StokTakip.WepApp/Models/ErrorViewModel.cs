namespace StokTakip.WepApp.Models
{
    public class ErrorViewModel//bir hata varsa g�steren s�n�f
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}