namespace CLTech.Core.Models;

public record ManifestModel
{
    public string? Name { get; set; }
    public string? Short_Name { get; set; }
    public string? Start_Url { get; set; }
    public string? Display { get; set; }
    public string? Background_Color { get; set; }
    public string? Theme_Color { get; set; }
    public bool? Prefer_Related_Applications { get; set; }
    public ManifestIconModel[]? Icons  { get; set; }
}

public record ManifestIconModel
{
    public string? Src { get; set; }
    public string? Type { get; set; }
    public string? Sizes { get; set; }
}
