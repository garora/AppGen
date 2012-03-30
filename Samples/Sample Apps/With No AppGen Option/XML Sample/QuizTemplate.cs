using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class QuizTemplate {
        public QuizTemplate() {
			Quizzes = new List<Quiz>();
        }
        public virtual int Qztid {
            get;
            set;
        }
        public virtual User QztOwnerIdUser {
            get;
            set;
        }
        public virtual User QztCreaterIdUser {
            get;
            set;
        }
        public virtual IList<Quiz> Quizzes {
            get;
            set;
        }
        public virtual string QztDescription {
            get;
            set;
        }
        public virtual bool IsFixed {
            get;
            set;
        }
        public virtual int MaxQuestions {
            get;
            set;
        }
        public virtual int MaxMandatoryQuestions {
            get;
            set;
        }
    }
}
