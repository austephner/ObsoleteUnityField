using System;
using UnityEngine;

namespace ObsoleteFieldAttribute
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ObsoleteUnityFieldAttribute : PropertyAttribute
    {
        public readonly string tooltip = "This field is obsolete.";

        public readonly bool editable = true;
        
        public ObsoleteUnityFieldAttribute() { }

        public ObsoleteUnityFieldAttribute(string tooltip)
        {
            this.tooltip = tooltip;
        }

        public ObsoleteUnityFieldAttribute(bool editable)
        {
            this.editable = editable;
        }
        
        public ObsoleteUnityFieldAttribute(string tooltip, bool editable)
        {
            this.tooltip = tooltip;
            this.editable = editable;
        }
    }
}