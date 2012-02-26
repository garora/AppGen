using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class UserInGroupMap : ClassMap<UserInGroup> {
        
        public UserInGroupMap() {
			Table("user_in_groups");
			LazyLoad();
			CompositeId();
			References(x => x.User).Column("uid");
			Map(x => x.Ugid).Column("ugid").Not.Nullable();
        }
    }
}
