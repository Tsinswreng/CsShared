using System.Runtime.InteropServices;
namespace Shr.Interop;
public static class FnPtrExt{
	public static TDelegate asFn<TDelegate>(this IntPtr z){
		if(z == IntPtr.Zero){
			return default;
		}
		return Marshal.GetDelegateForFunctionPointer<TDelegate>(z);
	}
}