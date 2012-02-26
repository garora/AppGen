using System; 
using System.Collections.Generic; 
using System.Text; 


namespace MySampleApplication {
    
    public class User {
        public User() {
			Quizzes = new <Quiz>();
			Quizzes = new <Quiz>();
			QuizTemplates = new <QuizTemplate>();
			QuizTemplates = new <QuizTemplate>();
			UserInGroups = new <UserInGroup>();
        }
        public virtual int Uid {
            get;
            set;
        }
        public virtual <Quiz> Quizzes {
            get;
            set;
        }
        public virtual <Quiz> Quizzes {
            get;
            set;
        }
        public virtual <QuizTemplate> QuizTemplates {
            get;
            set;
        }
        public virtual <QuizTemplate> QuizTemplates {
            get;
            set;
        }
        public virtual <UserInGroup> UserInGroups {
            get;
            set;
        }
        public virtual string UsersName {
            get;
            set;
        }
        public virtual string Password {
            get;
            set;
        }
        public virtual string FullName {
            get;
            set;
        }
        public virtual int ParentId {
            get;
            set;
        }
        public virtual string Email {
            get;
            set;
        }
        public virtual byte CreateQuiz {
            get;
            set;
        }
        public virtual byte CreateUser {
            get;
            set;
        }
        public virtual byte DeleteUser {
            get;
            set;
        }
        public virtual byte Superadmin {
            get;
            set;
        }
        public virtual byte Configurator {
            get;
            set;
        }
        public virtual string OneTimePw {
            get;
            set;
        }
    }
}
