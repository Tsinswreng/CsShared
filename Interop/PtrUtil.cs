using static System.Runtime.InteropServices.NativeMemory;
using static System.Runtime.InteropServices.Marshal;
namespace Shr.Interop;
unsafe public static class PtrUtil{
	public static T* New<T>()where T:unmanaged{
		return (T*)AllocZeroed((nuint)SizeOf<T>());
	}

	public int SizeOf_int<T>()where T:unmanaged{
		return SizeOf<T>();
	}
}