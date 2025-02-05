namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.Comparison.Conditional

{
    public class ConditionalFloatEntityData : BaseConditionalEntityNode
    {
        public override string ObjectType => "ConditionalFloatEntityData";
        public override string ToolTip => getTooltip("float");
        public override string Header => "Conditional Float"; //idk why this one specifically was set in the nmc but whatever
    }
}