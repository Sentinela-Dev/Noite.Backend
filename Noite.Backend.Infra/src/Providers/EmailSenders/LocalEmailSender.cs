using Microsoft.Extensions.Logging;
using Noite.Backend.Adapters.EmailSenders;

namespace Noite.Backend.Infra.Providers.EmailSenders;

public class LocalEmailSender : IEmailSender
{
    private readonly ILogger<LocalEmailSender> _logger;

    public LocalEmailSender(ILogger<LocalEmailSender> logger)
    {
        _logger = logger;
    }

    public Task SendEmailVerificationCode(string code, string targetEmail)
    {
        var msg = $"{targetEmail} code is => {code} <=";

        _logger.LogInformation(msg);

        return Task.CompletedTask;
    }
}
