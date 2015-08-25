using NHibernate;
using NHibernate.Util;
using Emts.Common;
using Emts.Common.Security;
using Emts.Data.Entities;
using Emts.Data.Exceptions;
using Emts.Data.QueryProcessors;

namespace Emts.Data.SqlServer.QueryProcessors {
    public class AddEventQueryProcessor : IAddEventQueryProcessor {
        private readonly IDateTime _dateTime;
        private readonly ISession _session;
        private readonly IUserSession _userSession;

        public AddEventQueryProcessor(ISession session, IUserSession userSession, IDateTime dateTime) {
            _session = session;
            _userSession = userSession;
            _dateTime = dateTime;
        }

        public void AddEvent(Event task) {
            task.CreatedDate = _dateTime.UtcNow;
            //task.Category = _session.QueryOver<Status>().Where(
            //    x => x.Name == "Not Started").SingleOrDefault();
            task.CreatedBy = _session.Get<User>(1L);
            //task.CreatedBy = _session.QueryOver<User>().Where(
            //    x => x.EmailAddress == _userSession.EmailAddress).SingleOrDefault();

            if (task.Attendees != null && task.Attendees.Any()) {
                for (var i = 0; i < task.Attendees.Count; ++i) {
                    var user = task.Attendees[i];
                    var persistedUser = _session.Get<User>(user.UserId);
                    if (persistedUser == null) {
                        throw new ChildObjectNotFoundException("User not found");
                    }
                    task.Attendees[i] = persistedUser;
                }
            }

            _session.SaveOrUpdate(task);
        }
    }
}
