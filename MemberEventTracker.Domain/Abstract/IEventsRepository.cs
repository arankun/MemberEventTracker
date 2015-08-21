using MemberEventTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberEventTracker.Domain.Abstract {
    public interface IEventsRepository {
        IEnumerable<Event> Events { get; }
    }
}
