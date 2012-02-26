using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class Quiz {
        public Quiz() {
        }
        public virtual int Qzid {
            get;
            set;
        }
        public virtual User QzOwnerIdUser {
            get;
            set;
        }
        public virtual User QzCreaterIdUser {
            get;
            set;
        }
        public virtual QuizTemplate QuizTemplate {
            get;
            set;
        }
        public virtual string Qzdescription {
            get;
            set;
        }
    }
}
