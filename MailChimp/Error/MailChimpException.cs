using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Error
{
    /// <summary>
    /// Mailchimp exception class
    /// </summary>
    public class MailChimpException : Exception
    {
        /// <summary>
        /// The Mailchimp API specific error information
        /// </summary>
        public Error MailChimpError { get; set; }

        /// <summary>
        /// The internal exception that fired from within the error handling code
        /// </summary>
        public Exception InternalException { get; set; }

        public MailChimpException(string message, Exception internalException, Error error)
            : base(message)
        {
            this.InternalException = internalException;
            this.MailChimpError = error;
        }
    }
}
