using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;
using BlueprintEditorPlugin.Models.Entities.Networking;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ObjectReference.ElementData
{
    public abstract class BaseElementData : EntityNode
    {
      public BaseElementData()
      {
        AddInput("Color", ConnectionType.Property,Realm.Client);
        AddInput("Alpha", ConnectionType.Property, Realm.Client);
        AddInput("Visible", ConnectionType.Property, Realm.Client);
      }

      public override void BuildFooter()
      {
        string instanceName = TryGetProperty("InstanceName").ToString();
        Footer = instanceName == "" ? "" : $"InstanceName: {instanceName}";
      }
    }
}