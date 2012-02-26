using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class Question {
        public Question() {
        }
        public virtual int Qsid {
            get;
            set;
        }
        public virtual int Qstid {
            get;
            set;
        }
        public virtual QuestionType QuestionType {
            get;
            set;
        }
        public virtual string Qtitle {
            get;
            set;
        }
        public virtual string Qdescription {
            get;
            set;
        }
    }
}
