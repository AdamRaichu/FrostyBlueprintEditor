using BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ObjectReference;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.StarWarsBattlefrontII.ObjectReference
{
    public class StaticListCellReferenceNode : BaseLogicRefEntity
    {
        public override string ObjectType => "StaticListCellEntityData";
        public override string ToolTip => "This node allows you to reference a UI widget, allowing you to trigger and be triggered by it's internal logic";
    }
}