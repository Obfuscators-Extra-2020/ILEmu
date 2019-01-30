using dnlib.DotNet;
using System;

namespace ILEmu.Helpers
{
    public static class CPUHelper
    {
        private static int? ptrSize = null;
        public static int PTRSize
        {
            get
            {
                if (!ptrSize.HasValue)
                    return IntPtr.Size;
                return ptrSize.Value;
            }
            set
            {
                if (ptrSize.HasValue && ptrSize.Value == value)
                    return;
                ptrSize = value;
            }
        }

        public static int? GetPTRSize(ModuleDef module)
        {
            if (module == null)
                throw new ArgumentNullException(nameof(module));
            //TODO: Check if module is set to specific cpu arch
            return null;
        }

        private static bool? isLittleEndian = null;
        public static bool IsLittleEndian
        {
            get
            {
                if (!isLittleEndian.HasValue)
                    return BitConverter.IsLittleEndian;
                return isLittleEndian.Value;
            }
            set
            {
                if (isLittleEndian.HasValue && isLittleEndian.Value == value)
                    return;
                isLittleEndian = value;
            }
        }
    }
}
