namespace HALO.Api.Models;

public class AppSettings
{
    public string Authority { get; set; }
    public string Audience { get; set; }
    public string AudienceLocal { get; set; }
    public string AudienceQA { get; set; }
    public string AudienceUAT { get; set; }
    public string AudienceProd { get; set; }
}