using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class QuizType {
        public QuizType() {
        }
        public virtual int Qtid {
            get;
            set;
        }
        public virtual string Description {
            get;
            set;
        }
    }
}
