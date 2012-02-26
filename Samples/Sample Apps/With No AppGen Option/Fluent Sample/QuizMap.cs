using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class QuizMap : ClassMap<Quiz> {
        
        public QuizMap() {
			Table("quiz");
			LazyLoad();
			Id(x => x.Qzid).GeneratedBy.Identity().Column("qzid");
			References(x => x.QzOwnerIdUser).Column("qzOwner_Id");
			References(x => x.QzCreaterIdUser).Column("qzCreater_Id");
			References(x => x.QuizTemplate).Column("qz_template_id");
			Map(x => x.Qzdescription).Column("qzdescription").Not.Nullable();
        }
    }
}
