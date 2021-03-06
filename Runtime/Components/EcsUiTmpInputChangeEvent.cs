// ----------------------------------------------------------------------------
// The MIT License
// Ui extension https://github.com/Leopotam/ecs-ui
// for ECS framework https://github.com/Leopotam/ecs
// Copyright (c) 2017-2019 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using TMPro;

namespace Leopotam.Ecs.Ui.Components {
    public sealed class EcsUiTmpInputChangeEvent : IEcsAutoReset, IEcsOneFrame {
        public string WidgetName;
        public TMP_InputField Sender;
        public string Value;

        void IEcsAutoReset.Reset () {
            Sender = null;
        }
    }
}