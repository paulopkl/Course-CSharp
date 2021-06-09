using System;
using System.Collections.Generic;
using System.Text;

namespace Course.CreateLog.Entities
{
    class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return this.Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }

            LogRecord other = obj as LogRecord;
            return this.Username.Equals(other.Username);
        }
    }
}
