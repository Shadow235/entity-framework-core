namespace EFJsonWithoutJSONColumn.Model;

public class TemplateInstance
{
	public Guid ID { get; set; } = Guid.NewGuid();

	public string Name { get; set; } = string.Empty;

	public TemplateData? Data { get; set; }
}