using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class SessionMap : ClassMap<Session> {
        
        public SessionMap() {
			Table("sessions");
			LazyLoad();
			Id(x => x.SessKey).GeneratedBy.Assigned().Column("sess_key");
			Map(x => x.Expiry).Column("expiry").Not.Nullable();
			Map(x => x.Created).Column("created").Not.Nullable();
			Map(x => x.Modified).Column("modified").Not.Nullable();
			Map(x => x.Sessdata).Column("sessdata");
        }
    }
}
