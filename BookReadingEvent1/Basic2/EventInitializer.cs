using System.Data.Entity;
using BookReadingEvent1.Common;
using System.Collections.Generic;
using System;

namespace BookReadingEvent1.Basic2
{
    public class EventInitializer : DropCreateDatabaseIfModelChanges<BookReadingContext>
    {

    }
}