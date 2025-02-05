using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ValueNodes.Manipulation
{
    public class Vec2BuilderNode : EntityNode
    {
        public override string ObjectType => "Vec2BuilderEntityData";
        public override string ToolTip => "Outputs a vec2 given float inputs";

        public override void OnCreation()
        {
            base.OnCreation();

            AddInput("X", ConnectionType.Property, Realm);
            AddInput("Y", ConnectionType.Property, Realm);

            AddOutput("Out", ConnectionType.Property, Realm);
        }
    }
    
	public class Vec3BuilderNode : EntityNode
	{
		public override string ObjectType => "Vec3BuilderEntityData";
        public override string ToolTip => "Outputs a vec3 given float inputs";

        public override void OnCreation()
		{
			base.OnCreation();

            AddInput("X", ConnectionType.Property, Realm);
            AddInput("Y", ConnectionType.Property, Realm);
            AddInput("Z", ConnectionType.Property, Realm);

            AddOutput("Out", ConnectionType.Property, Realm);
		}
	}
    
    public class Vec4BuilderNode : EntityNode
    {
        public override string ObjectType => "Vec4BuilderEntityData";
        public override string ToolTip => "Outputs a vec4 given float inputs";

        public override void OnCreation()
        {
            base.OnCreation();

            AddInput("X", ConnectionType.Property, Realm);
            AddInput("Y", ConnectionType.Property, Realm);
            AddInput("Z", ConnectionType.Property, Realm);
            AddInput("W", ConnectionType.Property, Realm);

            AddOutput("Out", ConnectionType.Property, Realm);
        }
    }
}
