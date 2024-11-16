using System;
using Microsoft.EntityFrameworkCore;

namespace event_finder_api.models;

public class EventContext : DbContext
{
    public EventContext(DbContextOptions<EventContext> options)
        : base(options)
    {
    }

    public DbSet<Event> Events { get; set; }

}
