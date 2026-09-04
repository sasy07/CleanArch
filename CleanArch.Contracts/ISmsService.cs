namespace CleanArch.Contracts;

public class SmsBody
{
    public string PhoneNumber { get; set; }
    public string Message { get; set; }
}

public interface ISmsService
{
    void SendSms(SmsBody body);
}

