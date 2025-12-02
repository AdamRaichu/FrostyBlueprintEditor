using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;
using BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ObjectReference.ElementData;
using BlueprintEditorPlugin.Models.Entities.Networking;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.StarWarsBattlefrontII.ObjectReference.ElementData
{
    public class TextElementData : BaseElementData
    {
        public override string ObjectType => "TextElementData";

        public TextElementData()
        {
            AddInput("LocalizedString", ConnectionType.Property, Realm.Client);
            AddInput("Text", ConnectionType.Property, Realm.Client);
            AddOutput("TextSize", ConnectionType.Property, Realm.Client);
        }
    }
}