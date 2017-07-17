using Sitecore.Form.Core.Data;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Web;

namespace Sitecore.Support.Form.Core
{
    [DataContract, KnownType(typeof(ActionDefinition))]
    internal class WffmActionEvent : Sitecore.Form.Core.WffmActionEvent
    {
        public WffmActionEvent(WffmActionEvent actionEvent)
        {
            base.Actions = actionEvent.Actions;
            base.Fields = actionEvent.Fields;
            base.FormID = actionEvent.FormID;
            base.Password = actionEvent.Password;
            base.SessionIDGuid = actionEvent.SessionIDGuid;
            base.UserName = actionEvent.UserName;
            this.ContextLanguage = Context.Language;
        }
        [DataMember]
        public Language ContextLanguage { get; [CompilerGenerated] set; }
    }
}