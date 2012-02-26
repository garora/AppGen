using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class UserGroupMap : ClassMap<UserGroup> {
        
        public UserGroupMap() {
			Table("user_groups");
			LazyLoad();
			Id(x => x.Ugid).GeneratedBy.Identity().Column("ugid");
			Map(x => x.Name).Column("name").Not.Nullable().Length(20);
			Map(x => x.Description).Column("description").Not.Nullable();
			Map(x => x.OwnerId).Column("owner_id").Not.Nullable();
        }
    }
}
