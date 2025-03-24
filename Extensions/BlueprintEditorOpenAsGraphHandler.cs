using BlueprintEditorPlugin.Editors.GraphEditor;
using BlueprintEditorPlugin.Options;
using Frosty.Core;
using Frosty.Core.Attributes;
using FrostySdk.Managers;
using CoreApp = Frosty.Core.App;
using EditorApp = FrostyEditor.App;

namespace BlueprintEditorPlugin.Extensions
{
    class BlueprintEditorOpenAsGraphHandler : IBlueprintEditorHandler
    {
        public void OpenAssetAsGraph(EbxAssetEntry asset)
        {
                IEbxGraphEditor graphEditor = ExtensionsManager.GetValidGraphEditor(asset);
                if (graphEditor == null)
                {
                    App.Logger.LogError("No valid graph editor exists for this file");
                    return;
                }

                BlueprintEditorPlugin.BlueprintEditor editor;
                if (EditorOptions.LoadBeforeOpen)
                {
                    editor = new BlueprintEditorPlugin.BlueprintEditor();
                    editor.LoadBlueprint(asset, graphEditor);
                }
                else
                {
                    editor = new BlueprintEditorPlugin.BlueprintEditor(asset, graphEditor);
                }

                CoreApp.EditorWindow.OpenEditor($"{asset.Filename} (Ebx Graph)", editor);
            
        }
    }
}
