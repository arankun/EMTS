using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emts.Data.Entities
{
    public class Event : IVersionedEntity {
        private readonly IList<User> _users = new List<User>();

        public virtual long EventId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime? StartDate { get; set; }
        public virtual DateTime? EndDate { get; set; }
        public virtual DateTime CreatedDate { get; set; }
        public virtual User CreatedBy { get; set; }

        public virtual string Category { get; set; }

        public virtual string Address1 { get; set; }

        public virtual string State { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual string Country { get; set; }
        public virtual IList<User> Attendees
        {
            get { return _users; }
        }

        public virtual byte[] Version { get; set; }
    }
}
