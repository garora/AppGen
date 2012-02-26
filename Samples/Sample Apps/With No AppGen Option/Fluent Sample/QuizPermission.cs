using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class QuizPermission {
        public QuizPermission() {
        }
        public virtual int Qid {
            get;
            set;
        }
        public virtual int Uid {
            get;
            set;
        }
        public virtual string Permission {
            get;
            set;
        }
        public virtual byte CreateP {
            get;
            set;
        }
        public virtual byte ReadP {
            get;
            set;
        }
        public virtual byte UpdateP {
            get;
            set;
        }
        public virtual byte DeleteP {
            get;
            set;
        }
        public virtual byte ImportP {
            get;
            set;
        }
        public virtual byte ExportP {
            get;
            set;
        }
    }
}
