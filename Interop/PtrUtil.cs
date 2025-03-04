namespace Shr.Interop;
unsafe public static class PtrUtil{
	public static T* New<T>()where T:unmanaged{
		return (T*)AllocZeroed((nuint)SizeOf<T>());
	}
}