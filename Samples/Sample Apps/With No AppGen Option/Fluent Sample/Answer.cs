using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class Answer {
        public Answer() {
        }
        public virtual int Aid {
            get;
            set;
        }
        public virtual int Qsid {
            get;
            set;
        }
        public virtual int Answer {
            get;
            set;
        }
        public virtual string Adescription {
            get;
            set;
        }
    }
}
