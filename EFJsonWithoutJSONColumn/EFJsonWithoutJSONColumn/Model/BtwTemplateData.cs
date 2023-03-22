namespace EFJsonWithoutJSONColumn.Model;

public class BtwTemplateData : TemplateData
{
	public string Path { get; set; } = string.Empty;

	public Dictionary<string, string> Paramters { get; set; }
}
