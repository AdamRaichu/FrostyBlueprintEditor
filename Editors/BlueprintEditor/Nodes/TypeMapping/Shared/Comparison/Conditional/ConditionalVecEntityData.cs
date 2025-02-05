namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.Comparison.Conditional

{
    public class ConditionalVec2EntityData : BaseConditionalEntityNode
    {
        public override string ObjectType => "ConditionalVec2EntityData";
        public override string ToolTip => getTooltip("vec2");
    }

    public class ConditionalVec3EntityData : BaseConditionalEntityNode
    {
        public override string ObjectType => "ConditionalVec3EntityData";
        public override string ToolTip => getTooltip("vec3");
    }

    public class ConditionalVec4EntityData : BaseConditionalEntityNode
    {
        public override string ObjectType => "ConditionalVec4EntityData";
        public override string ToolTip => getTooltip("vec4");
    }
}