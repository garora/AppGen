using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class QuestionType {
        public QuestionType() {
			Questions = new List<Question>();
        }
        public virtual int Qstid {
            get;
            set;
        }
        public virtual IList<Question> Questions {
            get;
            set;
        }
        public virtual string Description {
            get;
            set;
        }
    }
}
