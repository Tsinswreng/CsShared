namespace Shr.Date;

public static class DateUtil{

	/// <summary>
	/// TODO Test
	/// 未知 轉換後ʹ時區 統一示以中時區 抑 當地時區? AI曰潙中時區
	/// </summary>
	/// <param name="ms"></param>
	/// <returns></returns>
	public static str unixMsToIso8601(i64 ms){
	// 将毫秒时间戳转换为 DateTimeOffset 对象
		var dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(ms);
		// 将 DateTimeOffset 转换为 ISO 8601 格式的字符串
		return dateTimeOffset.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
	}

	/// <summary>
	/// AI曰 2025-02-11T13:00:10.788+08:00モ2025-02-11T13:00:14.144Zモ 皆支持
	/// </summary>
	/// <param name="iso8601"></param>
	/// <returns></returns>
	public static i64 iso8601ToUnixMs(str iso8601){
		// 解析 ISO 8601 日期字符串为 DateTimeOffset 对象
		var dateTimeOffset = DateTimeOffset.Parse(iso8601);
		// 转换为 UNIX 毫秒时间戳
		return dateTimeOffset.ToUnixTimeMilliseconds();
	}
}

