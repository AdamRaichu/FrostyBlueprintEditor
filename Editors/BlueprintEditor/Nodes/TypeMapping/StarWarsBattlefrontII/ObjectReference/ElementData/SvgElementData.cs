using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;
using BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ObjectReference.ElementData;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.StarWarsBattlefrontII.ObjectReference.ElementData
{
    public class SvgElementData : BaseElementData
    {
        public override string ObjectType => "SvgElementData";

        public SvgElementData()
        {
            AddInput("DynamicImage", ConnectionType.Property, Realm);
        }
    }
}