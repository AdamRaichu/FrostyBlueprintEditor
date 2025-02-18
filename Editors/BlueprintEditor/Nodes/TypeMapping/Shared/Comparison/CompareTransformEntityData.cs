using System.Collections.ObjectModel;
using BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.Ports;
using BlueprintEditorPlugin.Models.Nodes.Ports;
using Frosty.Core.Controls;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.TypeMapping.Shared.Comparison
{
    public class CompareTransformNode : EntityNode
    {
        public override string ObjectType => "CompareTransformEntityData";
        public override string ToolTip => "This node compares two LinearTransforms, triggering different events if they do or do not match.";

        public override void BuildFooter()
        {
            ClearFooter();
            if ((bool)TryGetProperty("TriggerOnStart"))
            {
                Footer = "Triggers on start";
            }

            if ((bool)TryGetProperty("TriggerOnPropertyChange"))
            {
                if (Footer != null)
                {
                    Footer += ", ";
                }
                else
                {
                    Footer = "Triggers ";
                }

                Footer += "On property changed";
            }
            
            if (TryGetProperty("AlwaysSend") != null && (bool)TryGetProperty("AlwaysSend"))
            {
                if (Footer != null)
                {
                    Footer += "\n";
                }

                Footer += "Always sends outputs";
            }
            
            if (TryGetProperty("AlwaysSendOnEvent") != null && (bool)TryGetProperty("AlwaysSendOnEvent"))
            {
                if (Footer != null)
                {
                    Footer += "\n";
                }

                Footer += "Always sends when In is triggered";
            }
        }

        public CompareTransformNode()
        {
            Inputs = new ObservableCollection<IPort>()
            {
                new PropertyInput("A", this),
                new PropertyInput("B", this)
            };
            Outputs = new ObservableCollection<IPort>()
            {
                new EventOutput("A=B", this),
                new EventOutput("A!=B", this)
            };
        }
    }
}