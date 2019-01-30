using ILEmu.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ILEmu.Structures
{
    public abstract class IStructure : IPointable
    {
        public abstract int Size { get; }

        public bool InRange(int offset) => offset >= 0 && offset < Size;
        protected void TransformOffset(ref int offset)
        {
            if (!CPUHelper.IsLittleEndian)
                return;
            offset = Size - 1 - offset;
        }
        public abstract byte? GetByte(int offset);
        public abstract void SetByte(int offset, byte? data);
    }
}
