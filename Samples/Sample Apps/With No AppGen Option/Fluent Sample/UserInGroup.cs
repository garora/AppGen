using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class UserInGroup {
        public UserInGroup() {
        }
        public virtual User User {
            get;
            set;
        }
        public virtual int Ugid {
            get;
            set;
        }
    }
}
