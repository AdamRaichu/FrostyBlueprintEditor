﻿using System;
using BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes;
using BlueprintEditorPlugin.Editors.BlueprintEditor.Nodes.Ports;
using FrostySdk;
using FrostySdk.Ebx;
using FrostySdk.IO;

namespace BlueprintEditorPlugin.Editors.BlueprintEditor.Connections
{
    public class EventConnection : EntityConnection
    {
        public override ConnectionType Type => ConnectionType.Event;

        private Realm _realm;
        public override Realm Realm
        {
            get => _realm;
            set
            {
                _realm = value;
                Type realmType = ((dynamic)Object).TargetType.GetType();
                ((dynamic)Object).TargetType = (dynamic)Enum.Parse(realmType, $"EventConnectionTargetType_{_realm.ToString()}");
                NotifyPropertyChanged(nameof(Realm));
                UpdateStatus();
            }
        }

        public EventConnection(EventOutput source, EventInput target) : base(source, target)
        {
            Object = TypeLibrary.CreateObject("EventConnection");
            
            PointerRef sourceRef;
            if (((EntityNode)source.Node).Type == PointerRefType.Internal)
            {
                sourceRef = new PointerRef(((EntityNode)source.Node).Object);
            }
            else
            {
                sourceRef = new PointerRef(new EbxImportReference()
                {
                    FileGuid = ((EntityNode)source.Node).FileGuid,
                    ClassGuid = ((EntityNode)source.Node).ClassGuid
                });
            }
            
            PointerRef targetRef;
            if (((EntityNode)target.Node).Type == PointerRefType.Internal)
            {
                targetRef = new PointerRef(((EntityNode)target.Node).Object);
            }
            else
            {
                targetRef = new PointerRef(new EbxImportReference()
                {
                    FileGuid = ((EntityNode)target.Node).FileGuid,
                    ClassGuid = ((EntityNode)target.Node).ClassGuid
                });
            }

            ((dynamic)Object).Source = sourceRef;
            ((dynamic)Object).Target = targetRef;
            ((dynamic)Object).SourceEvent.Name = source.Name;
            ((dynamic)Object).TargetEvent.Name = target.Name;

            HasPlayer = source.HasPlayer || ((EntityNode)source.Node).HasPlayerEvent;

            Realm = target.Realm;
            UpdateStatus();
        }
        
        public EventConnection(EventOutput source, EventInput target, object obj) : base(source, target, obj)
        {
            Object = obj;
            
            PointerRef sourceRef;
            if (((EntityNode)source.Node).Type == PointerRefType.Internal)
            {
                sourceRef = new PointerRef(((EntityNode)source.Node).Object);
            }
            else
            {
                sourceRef = new PointerRef(new EbxImportReference()
                {
                    FileGuid = ((EntityNode)source.Node).FileGuid,
                    ClassGuid = ((EntityNode)source.Node).ClassGuid
                });
            }
            
            PointerRef targetRef;
            if (((EntityNode)target.Node).Type == PointerRefType.Internal)
            {
                targetRef = new PointerRef(((EntityNode)target.Node).Object);
            }
            else
            {
                targetRef = new PointerRef(new EbxImportReference()
                {
                    FileGuid = ((EntityNode)target.Node).FileGuid,
                    ClassGuid = ((EntityNode)target.Node).ClassGuid
                });
            }

            HasPlayer = source.HasPlayer || ((EntityNode)source.Node).HasPlayerEvent;

            Realm = ParseRealm(((dynamic)Object).TargetType.ToString());
            UpdateStatus();
        }
    }
}