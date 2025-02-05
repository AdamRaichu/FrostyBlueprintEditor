using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.Querying
{
	public class DataSourceQueryNode : EntityNode
	{
		public override string ObjectType => "DataSourceQueryEntityData";
		// public override string ToolTip => "This node converts a Player Event into a Query Result";

		public override void OnCreation()
		{
			base.OnCreation();

			AddInput("InData", ConnectionType.Property, Realm);
		}
	}
}
