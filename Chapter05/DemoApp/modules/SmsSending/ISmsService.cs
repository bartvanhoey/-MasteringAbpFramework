namespace SmsSending;

public interface ISmsService{
    Task SendAsync(string phoneNumber, string message);
}
