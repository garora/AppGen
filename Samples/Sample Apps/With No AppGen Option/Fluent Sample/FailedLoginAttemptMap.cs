using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class FailedLoginAttemptMap : ClassMap<FailedLoginAttempt> {
        
        public FailedLoginAttemptMap() {
			Table("failed_login_attempts");
			LazyLoad();
			Id(x => x.Id).GeneratedBy.Identity().Column("id");
			Map(x => x.Ip).Column("ip").Not.Nullable().Length(37);
			Map(x => x.LastAttempt).Column("last_attempt").Not.Nullable().Length(20);
			Map(x => x.NumberAttempts).Column("number_attempts").Not.Nullable();
        }
    }
}
