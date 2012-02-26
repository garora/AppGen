using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class CorrectAnswerMap : ClassMap<CorrectAnswer> {
        
        public CorrectAnswerMap() {
			Table("correct_answers");
			LazyLoad();
			Id(x => x.Caid).GeneratedBy.Identity().Column("caid");
			Map(x => x.Aid).Column("aid").Not.Nullable();
        }
    }
}
