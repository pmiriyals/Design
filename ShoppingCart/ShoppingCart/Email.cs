using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart
{
    class Email
    {
        public string FromAddr { get; set; }
        public string ToAddr { get; set; }
        public string Message { get; set; }
        public int MessageID { get; set; }    //message already exists in a string constants file
        public string Subject { get; set; }

        public Email()
        { }

        public Email(int msgID, string ToAddr)
        {
            this.MessageID = msgID;
            this.ToAddr = ToAddr;
        }

        private bool LookUpMessage(int MessageID)
        {
            //get message save to current object
            return true;
        }

        public bool SendEmail()
        {
            if ((FromAddr == null || ToAddr == null || Message == null) && MessageID != null && MessageID > 0)
            {
                if (!LookUpMessage(MessageID))
                    return false;
            }

            return SendEmail(this.FromAddr, this.ToAddr, this.Subject, this.Message);
        }

        public bool SendEmail(string FromAddr, string ToAddr, string Subject, string Message)
        { 
            //MailMessage mail = new MailMessage();
            //build mail
            //smtp.send(mail);
            return true;
        }
    }
}
