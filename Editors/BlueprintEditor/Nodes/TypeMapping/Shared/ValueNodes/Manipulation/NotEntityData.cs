using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;
using Frosty.Core.Controls;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ValueNodes.Manipulation
{
    public class NotNode : EntityNode
    {
        public override string ObjectType => "NotEntityData";
        public override string ToolTip => "Outputs the opposite of the input bool";

        public override void OnCreation()
		{
			base.OnCreation();

			AddInput("In", ConnectionType.Property, Realm);

			AddOutput("Out", ConnectionType.Property, Realm);
		}
    }
}