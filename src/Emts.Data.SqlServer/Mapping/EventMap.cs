using Emts.Data.Entities;
using FluentNHibernate.Mapping;

namespace Emts.Data.SqlServer.Mapping {
    public class EventMap: VersionedClassMap<Event> {
        public EventMap() {
            Id(x => x.EventId);
            Map(x => x.Title).Not.Nullable();
            Map(x => x.Description).Nullable();
            Map(x => x.StartDate).Not.Nullable();
            Map(x => x.EndDate).Nullable();
            Map(x => x.Category).Nullable();
            Map(x => x.ZipCode).Nullable();
            Map(x => x.State).Nullable();
            Map(x => x.Country).Nullable();
            Map(x => x.CreatedDate).Not.Nullable();

            References(x => x.CreatedBy, "CreatedUserId");

            HasManyToMany(x => x.Attendees)
                .Access.ReadOnlyPropertyThroughCamelCaseField(Prefix.Underscore)
                .Table("User")
                .ParentKeyColumn("EventId")
                .ChildKeyColumn("UserId");
        }
    }
}
