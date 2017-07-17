using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Form.Core
{
    internal class WffmActionHandler
    {
        public static void Run(WffmActionEvent remoteEvent)
        {
            using (new LanguageSwitcher(remoteEvent.ContextLanguage))
            {
                Sitecore.Form.Core.WffmActionHandler.Run(remoteEvent);
            }
        }
    }
}