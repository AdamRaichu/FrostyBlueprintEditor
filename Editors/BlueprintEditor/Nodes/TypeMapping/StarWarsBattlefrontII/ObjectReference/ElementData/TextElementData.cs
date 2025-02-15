using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;
using BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ObjectReference.ElementData;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.StarWarsBattlefrontII.ObjectReference.ElementData
{
    public class TextElementData : BaseElementData
    {
        public override string ObjectType => "TextElementData";

        public TextElementData()
        {
            AddInput("LocalizedString", ConnectionType.Property, Realm);
            AddInput("Text", ConnectionType.Property, Realm);
            AddOutput("TextSize", ConnectionType.Property, Realm);
        }
    }
}