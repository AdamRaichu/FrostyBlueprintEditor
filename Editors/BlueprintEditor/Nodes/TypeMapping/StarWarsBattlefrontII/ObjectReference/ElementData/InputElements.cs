using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;
using BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ObjectReference.ElementData;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.StarWarsBattlefrontII.ObjectReference.ElementData
{
    public class AnalogInputElementData : BaseElementData
    {
        public override string ObjectType => "AnalogInputElementData";

        public override void BuildFooter()
        {
            base.BuildFooter();

            Footer += $"\nInputType: {TryGetProperty("InputType").ToString().Substring(20)}";
        }
    }

    public class CircularAnalogInputElementData : BaseElementData
    {
        public override string ObjectType => "CircularAnalogInputElementData";

        public override void BuildFooter()
        {
            base.BuildFooter();

            Footer += $"\nInputType: {TryGetProperty("InputType").ToString().Substring(24)}";
            Footer += $"\nListenToMouse: {TryGetProperty("ListenToMouse")}";
            Footer += $"\nMouseButton: {TryGetProperty("MouseButton").ToString().Substring(14)}";
        }
    }

    public class InputConceptIconElementData : BaseElementData
    {
        public override string ObjectType => "InputConceptIconElementData";
    }
}