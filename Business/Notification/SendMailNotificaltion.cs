using Hangfire;
using MediatR;
using Service.ServiceTools.Mail;

namespace Service.Notification
{
    public class SendMailNotificaltion : INotification
    {
        public string subject { get; set; }
        public string body { get; set; }
        public string emailTo { get; set; }

        public SendMailNotificaltion(string subject, string body, string mailTo)
        {
            this.subject = subject;
            this.body = body;
            this.emailTo = mailTo;

        }
    }



    public class SendMailNotificaltionHandler : INotificationHandler<SendMailNotificaltion>
    {





        public Task Handle(SendMailNotificaltion notification, CancellationToken cancellationToken)
        {




            string jobId = BackgroundJob.Enqueue<IMail>(x => x.SendMailAsync(notification.subject, notification.body, notification.emailTo));

            return Task.CompletedTask;
        }
    }


}
