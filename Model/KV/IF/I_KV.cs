namespace Shr.Model.KV.IF;

public interface I_KV {

	public str kType { get; set; }
	/// <summary>
	/// kStr與kI64 只能有一個有值，另一個為 null
	/// </summary>
	public str? kStr { get; set; }
	/// <summary>
	/// kStr與kI64 只能有一個有值，另一個為 null
	/// </summary>
	public i64? kI64 { get; set; }

	/// <summary>
	/// "fkey" ...
	/// </summary>
	public str? kDesc { get; set; }

	/// <summary>
	/// I64, F64, Str, ...
	/// </summary>
	public str vType { get; set; }

	public str? vDesc { get; set; }


	public str? vStr { get; set; }

	public i64? vI64 { get; set; }

	public f64? vF64 { get; set; }
}