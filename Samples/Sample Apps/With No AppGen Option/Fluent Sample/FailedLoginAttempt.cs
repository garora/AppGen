using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class FailedLoginAttempt {
        public FailedLoginAttempt() {
        }
        public virtual int Id {
            get;
            set;
        }
        public virtual string Ip {
            get;
            set;
        }
        public virtual string LastAttempt {
            get;
            set;
        }
        public virtual int NumberAttempts {
            get;
            set;
        }
    }
}
