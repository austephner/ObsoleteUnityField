using System;
using UnityEngine;

namespace ObsoleteFieldAttribute
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ObsoleteUnityFieldAttribute : PropertyAttribute
    {
        public readonly string tooltip = "This field is obsolete.";
        
        public ObsoleteUnityFieldAttribute() { }

        public ObsoleteUnityFieldAttribute(string tooltip)
        {
            this.tooltip = tooltip;
        }
    }
}