using Sitecore.Data;
using Sitecore.Data.DataProviders.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Support.Form.Core;
using Sitecore.Eventing;

namespace Sitecore.Support.Data.Eventing
{
    internal class SqlServerEventQueue : Sitecore.Data.Eventing.SqlServerEventQueue
    {
        public SqlServerEventQueue(SqlDataApi api, Database database) : base(api, database) { }
        protected override void QueueEvent(QueuedEvent queuedEvent, bool addToGlobalQueue, bool addToLocalQueue)
        {
            if (queuedEvent.EventTypeName.StartsWith("Sitecore.Form.Core.WffmActionEvent", StringComparison.InvariantCultureIgnoreCase))
            {
                WffmActionEvent data = new WffmActionEvent(base.Serializer.Deserialize<WffmActionEvent>(queuedEvent.InstanceData));
                Type type = data.GetType();
                string instanceData = base.Serializer.Serialize<WffmActionEvent>(data);
                string instanceName = base.InstanceName;
                string name = Context.User.Name;
                QueuedEvent event3 = new QueuedEvent(typeof(WffmActionEvent).AssemblyQualifiedName, type.AssemblyQualifiedName, instanceData, instanceName, name);
                base.QueueEvent(event3, addToGlobalQueue, addToLocalQueue);
            }
            else
            {
                base.QueueEvent(queuedEvent, addToGlobalQueue, addToLocalQueue);
            }
        }
    }
}