namespace Shr.Model.KV.IF;

public interface I_KV {

	public str kType { get; set; }
	public str? kStr { get; set; }
	public i64? kI64 { get; set; }


	public str? kDesc { get; set; }

	public str vType { get; set; }

	public str? vDesc { get; set; }


	public str? vStr { get; set; }

	public i64? vI64 { get; set; }

	public f64? vF64 { get; set; }
}