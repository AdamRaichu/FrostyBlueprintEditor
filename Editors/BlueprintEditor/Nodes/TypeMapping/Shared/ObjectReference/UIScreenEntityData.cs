namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ObjectReference
{
    public class UIScreenNode : BaseLogicRefEntity
    {
        public override string ObjectType => "UIScreenEntityData";
        public override string ToolTip => "This node allows you to reference a UI screen, allowing you to trigger and be triggered by it's internal logic";
    }
}