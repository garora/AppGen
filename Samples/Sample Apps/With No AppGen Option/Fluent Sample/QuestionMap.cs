using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class QuestionMap : ClassMap<Question> {
        
        public QuestionMap() {
			Table("questions");
			LazyLoad();
			CompositeId().KeyProperty(x => x.Qsid, "qsid").KeyProperty(x => x.Qstid, "qstid");
			References(x => x.QuestionType).Column("qstid");
			Map(x => x.Qtitle).Column("qtitle").Not.Nullable().Length(50);
			Map(x => x.Qdescription).Column("qdescription").Not.Nullable();
        }
    }
}
