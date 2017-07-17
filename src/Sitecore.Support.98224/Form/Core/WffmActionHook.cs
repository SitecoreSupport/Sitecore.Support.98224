using Sitecore.Eventing;
using Sitecore.Events.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Form.Core
{
    internal class WffmActionHook : IHook
    {
        public void Initialize()
        {
            EventManager.Subscribe<Sitecore.Support.Form.Core.WffmActionEvent>(new Action<Sitecore.Support.Form.Core.WffmActionEvent>(Sitecore.Support.Form.Core.WffmActionHandler.Run));
        }
    }
}