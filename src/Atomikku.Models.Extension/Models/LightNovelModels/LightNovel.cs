namespace Atomikku.Models.Extension;

/// <summary>
/// Represents the output model for the extension
/// </summary>
public class LightNovel
{
    /// <summary>
    /// Represents the tittle of the book.
    /// </summary>
    public string? Tittle { get; set; }

    /// <summary>
    /// Represents the second tittle of the book.
    /// </summary>
    public string? SecondTittle { get; set; }

    /// <summary>
    /// Represents the description of the book.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Represents the author of the book.
    /// </summary>
    public string? Author { get; set; }

    /// <summary>
    /// Represents the Genres of the book.
    /// </summary>
    public List<string>? Genres { get; set; }

    /// <summary>
    /// Represents the Source of the book.
    /// </summary>
    public string? Source { get; set; }

    /// <summary>
    /// Represents the image url of the book.
    /// </summary>
    public string? ImageUrl { get; set; }

    /// <summary>
    /// Represents the status of the book.
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Represents the chapters of the book.
    /// </summary>
    public List<Chapter>? Chapters { get; set; }

    /// <summary>
    /// Represents the url of the book.
    /// </summary>
    public string? LightNovelUrl { get; set; }

    /// <summary>
    /// Represents the release date of the book.
    /// </summary>
    public string? ReleaseDate { get; set; }
}