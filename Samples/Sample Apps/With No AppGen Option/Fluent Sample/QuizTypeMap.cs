using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class QuizTypeMap : ClassMap<QuizType> {
        
        public QuizTypeMap() {
			Table("quiz_type");
			LazyLoad();
			Id(x => x.Qtid).GeneratedBy.Identity().Column("qtid");
			Map(x => x.Description).Column("description").Not.Nullable().Length(50);
        }
    }
}
