using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class QuizTemplateMap : ClassMap<QuizTemplate> {
        
        public QuizTemplateMap() {
			Table("quiz_template");
			LazyLoad();
			Id(x => x.Qztid).GeneratedBy.Identity().Column("qztid");
			References(x => x.QztOwnerIdUser).Column("qzt_Owner_Id");
			References(x => x.QztCreaterIdUser).Column("qzt_Creater_Id");
			Map(x => x.QztDescription).Column("qzt_description").Not.Nullable();
			Map(x => x.IsFixed).Column("isFixed").Not.Nullable();
			Map(x => x.MaxQuestions).Column("max_questions").Not.Nullable();
			Map(x => x.MaxMandatoryQuestions).Column("max_mandatory_questions").Not.Nullable();
			HasMany(x => x.Quizzes).KeyColumn("qz_template_id");
        }
    }
}
