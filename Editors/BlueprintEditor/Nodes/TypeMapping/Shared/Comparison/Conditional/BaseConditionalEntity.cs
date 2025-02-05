using System.Collections.ObjectModel;
using BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.Ports;
using BlueprintEditorPlugin.Models.Nodes.Ports;
using Frosty.Core.Controls;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.Comparison.Conditional
{
    public abstract class BaseConditionalEntityNode : EntityNode
    {
        // public override string ToolTip => "This node stores a number value which can be incremented and decremented";

        // public override void BuildFooter()
        // {
        //     Footer = $"Default Value: {TryGetProperty("DefaultValue")}\nAdjustment Value: {TryGetProperty("IncDecValue")}";
        // }
        public override void BuildFooter()
        {
            Footer = $"Default Condition: {TryGetProperty("Condition")}";
        }

        public BaseConditionalEntityNode()
        {
            Inputs = new ObservableCollection<IPort>
            {
                new PropertyInput("ValueIfTrue", this),
                new PropertyInput("ValueIfFalse", this),
                new PropertyInput("Condition", this),
            };

            Outputs = new ObservableCollection<IPort>
            {
                new PropertyOutput("Output", this)
            };
        }

        protected string getTooltip(string type)
        {
          return $"Outputs a {type} depending on the condition";
        }
    }
}