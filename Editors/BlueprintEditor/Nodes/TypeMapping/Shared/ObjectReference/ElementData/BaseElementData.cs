using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ObjectReference.ElementData
{
    public abstract class BaseElementData : EntityNode
    {
      public BaseElementData()
      {
        AddInput("Color", ConnectionType.Property,Realm);
        AddInput("Alpha", ConnectionType.Property,Realm);
        AddInput("Visible", ConnectionType.Property,Realm);
      }

      public override void BuildFooter()
      {
        string instanceName = TryGetProperty("InstanceName").ToString();
        Footer = instanceName == "" ? "" : $"InstanceName: {instanceName}";
      }
    }
}