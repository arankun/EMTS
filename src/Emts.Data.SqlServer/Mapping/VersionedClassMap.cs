using FluentNHibernate.Mapping;
using Emts.Data.Entities;

namespace Emts.Data.SqlServer.Mapping {
    public abstract class VersionedClassMap<T> : ClassMap<T> where T : IVersionedEntity {
        protected VersionedClassMap() {
            Version(x => x.Version)
                .Column("ts")
                .CustomSqlType("Rowversion")
                .Generated.Always()
                .UnsavedValue("null");
        }
    }
}
