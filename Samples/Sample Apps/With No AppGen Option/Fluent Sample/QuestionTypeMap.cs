using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class QuestionTypeMap : ClassMap<QuestionType> {
        
        public QuestionTypeMap() {
			Table("question_type");
			LazyLoad();
			Id(x => x.Qstid).GeneratedBy.Identity().Column("qstid");
			Map(x => x.Description).Column("description").Not.Nullable().Length(50);
			HasMany(x => x.Questions).KeyColumn("qstid");
        }
    }
}
