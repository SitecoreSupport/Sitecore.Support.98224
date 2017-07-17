using Sitecore.Eventing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Data.SqlServer
{
    public class SqlServerDataProvider : Sitecore.Data.SqlServer.SqlServerDataProvider
    {
        public SqlServerDataProvider(string connectionString) : base(connectionString) { }

        public override EventQueue GetEventQueue()
        {
            return new Sitecore.Support.Data.Eventing.SqlServerEventQueue(base.Api, base.Database);
        }
    }
}