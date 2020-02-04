using System;
using Convey.Types;

namespace Cine.Modules.Schedules.Infrastructure.Mongo.Documents
{
    public class HallDocument : IIdentifiable<Guid>
    {
        public Guid Id { get; set; }
    }
}
