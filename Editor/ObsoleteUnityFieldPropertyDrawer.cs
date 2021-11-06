using UnityEditor;
using UnityEngine;

namespace ObsoleteFieldAttribute.Editor
{
    [CustomPropertyDrawer(typeof(ObsoleteUnityFieldAttribute))]
    public class ObsoleteUnityFieldPropertyDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var content = EditorGUIUtility.IconContent("Warning");
            var obsoleteUnityFieldAttribute = (ObsoleteUnityFieldAttribute)attribute;
            var originalEnabledState = GUI.enabled;

            GUI.enabled = obsoleteUnityFieldAttribute.editable; 
            
            content.tooltip = BuildTooltip(obsoleteUnityFieldAttribute, label.tooltip);
            content.text = label.text;

            if (property.isExpanded)
            {
                position.height = EditorGUIUtility.singleLineHeight;
            }

            EditorGUI.PropertyField(position, property, content, property.hasChildren);

            GUI.enabled = originalEnabledState;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property);
        }

        private string BuildTooltip(ObsoleteUnityFieldAttribute obsoleteUnityFieldAttribute, string tooltip)
        {
            return $"{obsoleteUnityFieldAttribute?.tooltip} {(!string.IsNullOrWhiteSpace(tooltip) ? $" - {tooltip}" : "")}";
        }
    }
}