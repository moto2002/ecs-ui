// ----------------------------------------------------------------------------
// The MIT License
// Ui extension https://github.com/Leopotam/ecs-ui
// for ECS framework https://github.com/Leopotam/ecs
// Copyright (c) 2017-2019 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.EventSystems;

namespace Leopotam.Ecs.Ui.Components {
    public sealed class EcsUiEndDragEvent : IEcsAutoReset, IEcsOneFrame {
        public string WidgetName;
        public GameObject Sender;
        public Vector2 Position;
        public int PointerId;
        public PointerEventData.InputButton Button;

        void IEcsAutoReset.Reset () {
            Sender = null;
        }
    }
}