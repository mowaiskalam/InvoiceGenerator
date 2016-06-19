using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace InvoiceGenerator.Helper
{
    public class Email
    {
        #region Configuration
        static SmtpClient _smtpClient;
        static string _defaultFromAddress = SystemParameter.DefaultFromAddress;
        static string _defaultFromAddressPassword = SystemParameter.FromEmailPassword;
        static bool _useSSL = false;
        #endregion

        public static SmtpClient getSMTPClientInstance()
        {
            SmtpClient _smtpClient = new SmtpClient(SystemParameter.SMTPServer, SystemParameter.SMTPPort);
            _smtpClient.UseDefaultCredentials = false;
            _smtpClient.Credentials = new System.Net.NetworkCredential(_defaultFromAddress, _defaultFromAddressPassword);
            _smtpClient.EnableSsl = _useSSL;

            return _smtpClient;
        }

        public void Send(MailMessage mail)
        {
            try
            {
                _smtpClient = getSMTPClientInstance();
                _smtpClient.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception("Unable to send email." + ex.Message);
            }
        }
    }

    public class SystemParameter
    {
        public static bool UseSSL
        {
            get
            {
                return Convert.ToBoolean(ConfigurationManager.AppSettings["EnableSsl"].ToString());
            }
        }

        public static string DefaultFromAddress
        {
            get
            {
                return ConfigurationManager.AppSettings["UserName"].ToString();
            }
        }

        public static string AdminEmail
        {
            get
            {
                return ConfigurationManager.AppSettings["AdminEmail"].ToString();
            }
        }

        public static string FromEmailPassword
        {
            get
            {
                return ConfigurationManager.AppSettings["Password"].ToString();
            }
        }


        public static string SMTPServer
        {
            get
            {
                return ConfigurationManager.AppSettings["SMTPClient"].ToString();
            }
        }


        public static int SMTPPort
        {
            get
            {
                return Convert.ToInt32(ConfigurationManager.AppSettings["Port"].ToString());
            }
        }

        public static string BCCEmails
        {
            get
            {
                return ConfigurationManager.AppSettings["bcc"].ToString();
            }
        }
    }
}
