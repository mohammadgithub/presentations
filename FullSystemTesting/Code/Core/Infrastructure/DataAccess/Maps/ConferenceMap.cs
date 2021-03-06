using CodeCampServerLite.Core.Domain.Model;
using FluentNHibernate.Mapping;

namespace CodeCampServerLite.Infrastructure.DataAccess.Maps
{
    public class ConferenceMap : EntityMap<Conference>
    {
        public ConferenceMap()
        {
            Map(x => x.Name);
            Map(x => x.SessionCount);
            Map(x => x.AttendeeCount);


        	HasMany(x => x.GetSessions())
        		.AsSet()
        		.Cascade.AllDeleteOrphan();

        	HasMany(x => x.GetAttendees())
        		.AsSet()
        		.Cascade.AllDeleteOrphan();
        }
    }
}