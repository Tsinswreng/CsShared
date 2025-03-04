namespace Shr.Interop;
unsafe public static class CStrExt {
	public static byte* cStr(this string? z){
		return Shr.Interop.CStrUtil.csStrToCStr(z);
	}
}