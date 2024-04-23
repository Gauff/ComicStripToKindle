using ComicStripToKindle.Profiles;
using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ComicStripToKindle
{
    public static class SmtpClientExtensions
    {
        //Attention: max 33MB

        //MailMessage message = new MailMessage(txtFrom.Text, txtTo.Text);
        //Attachment attachment = new Attachment(convertedKindlePdfFilePath);
        //message.Attachments.Add(attachment);
        //message.Body = txtPdfFileName.Text;
        //SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587);
        //client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //client.UseDefaultCredentials = false;
        //System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(txtFrom.Text, 
        //    "");
        //client.EnableSsl = true;
        //client.Credentials = credentials;
        //client.Send(message);


        //smtp.SendCompleted += delegate (object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        //{
        //    if (e.Error != null)
        //    {
        //        System.Diagnostics.Trace.TraceError(e.Error.ToString());

        //    }
        //    MailMessage userMessage = e.UserState as MailMessage;
        //    if (userMessage != null)
        //    {
        //        userMessage.Dispose();
        //    }
        //};

        //smtp.SendAsync(message, message);


        public static Task SendAsync(this SmtpClient client, MailMessage message, OutputProfile profile)
        {
            var tcs = new TaskCompletionSource<object>();
            var sendGuid = Guid.NewGuid();

            SendCompletedEventHandler handler = null;
            handler = (o, ea) =>
            {
                if (ea.UserState is Guid && ((Guid)ea.UserState) == sendGuid)
                {
                    client.SendCompleted -= handler;
                    if (ea.Cancelled)
                    {
                        tcs.SetCanceled();
                    }
                    else if (ea.Error != null)
                    {
                        tcs.SetException(ea.Error);
                    }
                    else
                    {
                        tcs.SetResult(null);
                    }
                }
            };

            client.SendCompleted += handler;
            client.SendAsync(message, sendGuid);
            return tcs.Task;
        }

    }
}
