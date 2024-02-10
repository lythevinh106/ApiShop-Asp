namespace Service.ServiceTools.Mail
{
    public interface IMail
    {
        Task<bool> SendMailAsync(string subject, string body, string emailTo);

        Task<bool> SendMailAsyncHtml(string subject, string contentHtml, string emailTo);

        Task Disconect();
    }
}
