using System.Collections.Generic;
using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;
using Frosty.Core.Controls;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ValueNodes.Manipulation
{
    public class CheckedLocalizedStringNode : EntityNode
    {
      public override string ObjectType => "CheckedLocalizedStringEntityData";
      public override string ToolTip => "Outputs the opposite of the input bool";

      public override void OnCreation()
      {
        base.OnCreation();

        dynamic argCount = TryGetProperty("Arguments");
        for (uint i = 0; i < argCount.Count; i++)
        {
          AddInput($"Arg{i}", ConnectionType.Property, Realm);
        }

        AddInput("DynamicStringId", ConnectionType.Property, Realm);

        AddOutput("LocalizedString", ConnectionType.Property, Realm);
      }

      public override void BuildFooter()
      {
        // Footer = $"DebugString: {TryGetProperty("DebugString")}\nSid: {TryGetProperty("Sid")}";
        string debugString = TryGetProperty("DebugString").ToString();
        string sid = TryGetProperty("Sid").ToString();
        Footer = $"{(debugString == "" ? "" : $"DebugString: {debugString}")}{((debugString == "" || sid == "") && !(debugString == "" && sid == "") ? "" : "\n")}{(sid == "" ? "" : $"Sid: {sid}")}";
      }
  }
}