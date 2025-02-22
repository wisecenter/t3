using T3.Core.Operator;
using T3.Core.Operator.Attributes;
using T3.Core.Operator.Slots;

namespace T3.Operators.Types.Id_4b207e35_64b4_4833_977c_da6c7154a081
{
    public class Sharpen : Instance<Sharpen>
    {
        [Output(Guid = "d412319c-42be-480d-a4e5-60b5b5b1722d")]
        public readonly Slot<SharpDX.Direct3D11.Texture2D> TextureOutput = new();


        [Input(Guid = "cdc10025-36a4-4fae-ad59-110ea9343cb0")]
        public readonly InputSlot<SharpDX.Direct3D11.Texture2D> Image = new();

        [Input(Guid = "d6c4daf8-caa3-4991-8d03-50eaad142b39")]
        public readonly InputSlot<float> SampleRadius = new();

        [Input(Guid = "def5bcf3-d499-41ad-82b8-1b9706ebaab6")]
        public readonly InputSlot<float> Strength = new();
    }
}

