namespace Atomikku.Models.Extension;

/// <summary>
/// Represents the entities that are used to search the page.
/// </summary>
public class LightNovelToSearch
{
    /// <summary>
    /// Title to be searched.
    /// </summary>
    public string? Tittle { get; set; }

    /// <summary>
    /// Represents the list of found lightnovels.
    /// </summary>
    public List<LightNovel>? BooksFound { get; set; }
}