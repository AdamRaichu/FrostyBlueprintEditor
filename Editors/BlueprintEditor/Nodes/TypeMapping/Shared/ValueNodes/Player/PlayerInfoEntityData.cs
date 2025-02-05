using BlueprintEditorPlugin.Editors.BlueprintEditor.Connections;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.ValueNodes.Player
{
    public class PlayerInfoNode : EntityNode
    {
        public override string ObjectType => "PlayerInfoEntityData";
        public override string ToolTip => "This node allows you to get info on a player from a Player Event";

        public override void OnCreation()
        {
            base.OnCreation();
            
            AddInput("SetPlayer", ConnectionType.Event, Realm);
            AddInput("PlayerQueryInput", ConnectionType.Property, Realm);
            AddInput("SetPlayer", ConnectionType.Event, Realm);

            AddOutput("Name", ConnectionType.Property, Realm);
            AddOutput("Team", ConnectionType.Property, Realm);
            AddOutput("LocalizedName", ConnectionType.Property, Realm);
            AddOutput("CurrentCharacterKitAppearanceSkinIdData", ConnectionType.Property, Realm);
            AddOutput("IsAI", ConnectionType.Property, Realm);
            AddOutput("VehicleId", ConnectionType.Property, Realm);
            AddOutput("IsInMyParty", ConnectionType.Property, Realm);
            AddOutput("IsOutOfBounds", ConnectionType.Property, Realm);
            AddOutput("0xde417c4a", ConnectionType.Property, Realm);
            AddOutput("0x1c1a3bdd", ConnectionType.Property, Realm);
            AddOutput("CharacterId", ConnectionType.Property, Realm);
            AddOutput("HasPlayer", ConnectionType.Property, Realm);
            AddOutput("PlayerQueryOutput", ConnectionType.Property, Realm);
            AddOutput("Controllable", ConnectionType.Link, Realm);
        }

        public override void BuildFooter()
        {
            Footer = $"FilteredTypes: {TryGetProperty("FilteredTypes").ToString().Substring(18)}";
        }
    }
}