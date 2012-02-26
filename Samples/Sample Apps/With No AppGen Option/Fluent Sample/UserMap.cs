using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class UserMap : ClassMap<User> {
        
        public UserMap() {
			Table("users");
			LazyLoad();
			Id(x => x.Uid).GeneratedBy.Identity().Column("uid");
			Map(x => x.UsersName).Column("users_name").Not.Nullable().Length(64);
			Map(x => x.Password).Column("password").Not.Nullable().Length(8000);
			Map(x => x.FullName).Column("full_name").Not.Nullable().Length(50);
			Map(x => x.ParentId).Column("parent_id").Not.Nullable();
			Map(x => x.Email).Column("email").Not.Nullable().Length(320);
			Map(x => x.CreateQuiz).Column("create_quiz").Not.Nullable();
			Map(x => x.CreateUser).Column("create_user").Not.Nullable();
			Map(x => x.DeleteUser).Column("delete_user").Not.Nullable();
			Map(x => x.Superadmin).Column("superadmin").Not.Nullable();
			Map(x => x.Configurator).Column("configurator").Not.Nullable();
			Map(x => x.OneTimePw).Column("one_time_pw").Length(2147483647);
			HasMany(x => x.Quizzes).KeyColumn("qzCreater_Id");
			HasMany(x => x.Quizzes).KeyColumn("qzOwner_Id");
			HasMany(x => x.QuizTemplates).KeyColumn("qzt_Creater_Id");
			HasMany(x => x.QuizTemplates).KeyColumn("qzt_Owner_Id");
			HasMany(x => x.UserInGroups).KeyColumn("uid");
        }
    }
}
