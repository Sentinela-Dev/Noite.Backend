namespace Noite.Backend.Adapters.EmailSenders;

public interface IEmailSender
{
    Task SendEmailVerificationCode(string code, string targetEmail);
}
