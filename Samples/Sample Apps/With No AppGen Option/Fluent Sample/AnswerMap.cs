using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class AnswerMap : ClassMap<Answer> {
        
        public AnswerMap() {
			Table("answers");
			LazyLoad();
			CompositeId().KeyProperty(x => x.Aid, "aid").KeyProperty(x => x.Qsid, "qsid");
			Map(x => x.Answer).Column("answer").Not.Nullable();
			Map(x => x.Adescription).Column("adescription").Not.Nullable();
        }
    }
}
