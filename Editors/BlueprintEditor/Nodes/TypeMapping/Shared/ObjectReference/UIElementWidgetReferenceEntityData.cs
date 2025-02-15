namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ObjectReference
{
    public class UIElementWidgetReferenceNode : BaseLogicRefEntity
    {
        public override string ObjectType => "UIElementWidgetReferenceEntityData";
        public override string ToolTip => "This node allows you to reference a UI widget, allowing you to trigger and be triggered by it's internal logic";
    }
}