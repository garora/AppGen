using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class QuestionType {
        public QuestionType() {
			Questions = new <Question>();
        }
        public virtual int Qstid {
            get;
            set;
        }
        public virtual <Question> Questions {
            get;
            set;
        }
        public virtual string Description {
            get;
            set;
        }
    }
}
