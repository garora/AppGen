using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class UserGroup {
        public UserGroup() {
        }
        public virtual int Ugid {
            get;
            set;
        }
        public virtual string Name {
            get;
            set;
        }
        public virtual string Description {
            get;
            set;
        }
        public virtual int OwnerId {
            get;
            set;
        }
    }
}
