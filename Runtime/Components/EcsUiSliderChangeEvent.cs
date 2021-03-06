// ----------------------------------------------------------------------------
// The MIT License
// Ui extension https://github.com/Leopotam/ecs-ui
// for ECS framework https://github.com/Leopotam/ecs
// Copyright (c) 2017-2019 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using UnityEngine.UI;

namespace Leopotam.Ecs.Ui.Components {
    public sealed class EcsUiSliderChangeEvent : IEcsAutoReset, IEcsOneFrame {
        public string WidgetName;
        public Slider Sender;
        public float Value;

        void IEcsAutoReset.Reset () {
            Sender = null;
        }
    }
}