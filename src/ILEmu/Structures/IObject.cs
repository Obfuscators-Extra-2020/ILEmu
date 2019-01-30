using ILEmu.Helpers;

namespace ILEmu.Structures
{
    public abstract class IObject : IPointable
    {
        public int Size => CPUHelper.PTRSize;

    }
}
