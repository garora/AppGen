using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;

namespace MySampleApplication {
    
    
    public class QuizPermissionMap : ClassMap<QuizPermission> {
        
        public QuizPermissionMap() {
			Table("quiz_permissions");
			LazyLoad();
			CompositeId().KeyProperty(x => x.Qid, "qid").KeyProperty(x => x.Uid, "uid").KeyProperty(x => x.Permission, "permission");
			Map(x => x.CreateP).Column("create_p").Not.Nullable();
			Map(x => x.ReadP).Column("read_p").Not.Nullable();
			Map(x => x.UpdateP).Column("update_p").Not.Nullable();
			Map(x => x.DeleteP).Column("delete_p").Not.Nullable();
			Map(x => x.ImportP).Column("import_p").Not.Nullable();
			Map(x => x.ExportP).Column("export_p").Not.Nullable();
        }
    }
}
