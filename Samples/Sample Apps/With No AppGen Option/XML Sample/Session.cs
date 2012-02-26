using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class Session {
        public Session() {
        }
        public virtual string SessKey {
            get;
            set;
        }
        public virtual System.DateTime Expiry {
            get;
            set;
        }
        public virtual System.DateTime Created {
            get;
            set;
        }
        public virtual System.DateTime Modified {
            get;
            set;
        }
        public virtual string Sessdata {
            get;
            set;
        }
    }
}
