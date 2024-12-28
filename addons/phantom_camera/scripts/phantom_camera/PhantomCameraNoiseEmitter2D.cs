using Godot;
using PhantomCamera.Resources;

namespace PhantomCamera.Cameras
{
    public class PhantomCameraNoiseEmitter2D
    {
        public readonly Node2D Node2D = null;

        public PhantomCameraNoise2D Noise
        {
            get => new((Resource)Node2D.Call(MethodNames.GetNoise));
            set => Node2D.Call(MethodNames.SetNoise, value.Resource);
        }

        public bool Continuous
        {
            get => (bool)Node2D.Call(MethodNames.GetContinuous);
            set => Node2D.Call(MethodNames.SetContinuous, value);
        }

        public float GrowthTime
        {
            get => (float)Node2D.Call(MethodNames.GetGrowthTime);
            set => Node2D.Call(MethodNames.SetGrowthTime, value);
        }

        public float Duration
        {
            get => (float)Node2D.Call(MethodNames.GetDuration);
            set => Node2D.Call(MethodNames.SetDuration, value);
        }

        public float DecayTime
        {
            get => (float)Node2D.Call(MethodNames.GetDecayTime);
            set => Node2D.Call(MethodNames.SetDecayTime, value);
        }

        public int NoiseEmitterLayer
        {
            get => (int)Node2D.Get(PropertyNames.NoiseEmitterLayer);
            set => Node2D.Set(PropertyNames.NoiseEmitterLayer, value);
        }

        public PhantomCameraNoiseEmitter2D(Node2D node2D) => Node2D = node2D;

        public void Emit() => Node2D.Call(MethodNames.Emit);
        public bool IsEmitting() => (bool)Node2D.Call(MethodNames.IsEmitting);
        public void Stop() => Node2D.Call(MethodNames.Stop);
        public void Toggle() => Node2D.Call(MethodNames.Toggle);

        public static class PropertyNames
        {
            public const string Noise = "noise";
            public const string Preview = "preview";
            public const string Continuous = "continuous";
            public const string GrowthTime = "growth_time";
            public const string Duration = "duration";
            public const string DecayTime = "decay_time";
            public const string NoiseEmitterLayer = "noise_emitter_layer";
        }

        public static class MethodNames
        {
            public const string GetNoise = "get_noise";
            public const string SetNoise = "set_noise";

            public const string GetContinuous = "get_continuous";
            public const string SetContinuous = "set_continuous";

            public const string GetGrowthTime = "get_growth_time";
            public const string SetGrowthTime = "set_growth_time";

            public const string GetDuration = "get_duration";
            public const string SetDuration = "set_duration";

            public const string GetDecayTime = "get_decay_time";
            public const string SetDecayTime = "set_decay_time";

            public const string Emit = "emit";
            public const string IsEmitting = "is_emitting";
            public const string Stop = "stop";
            public const string Toggle = "toggle";
        }
    }
}
