namespace Atomikku.Models.Extension;

/// <summary>
/// Represents the chapter model for the extension.
/// </summary>
public class Chapter
{

    /// <summary>
    /// Represents the chapter number.
    /// </summary>
    public string? ChapterNumber { get; set; }

    /// <summary>
    /// Represents the chapter title.
    /// </summary>
    public required string Url { get; set; }

    /// <summary>
    /// Represents the chapter name.
    /// </summary>
    public string? ChapterName { get; set; }

    /// <summary>
    /// Represents the chapter release date.
    /// </summary>
    public string? ChapterReleaseDate { get; set; }

    /// <summary>
    /// Represents the chapter of the book.
    /// </summary>
    public string? ChapterOfBook { get; set; }
}