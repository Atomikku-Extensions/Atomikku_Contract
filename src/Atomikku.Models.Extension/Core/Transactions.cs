namespace Atomikku.Models.Extension;

public class Transactions : ITransactions
{
    private readonly ITransactions _transactions;

    public Transactions(ITransactions transactions)
    {
        _transactions = transactions;
    }

    /// <summary>
    /// Search books according the <see cref="LightNovelToSearch.Tittle"/>.
    /// </summary>
    /// <param name="lightNovel">Used to get the tittle.</param>
    /// <returns>The collection of books.</returns>
    public async Task<LightNovelToSearch> GetSearchBooks(LightNovelToSearch lightNovel) => await _transactions.GetSearchBooks(lightNovel);

    /// <summary>
    /// Get the book data.
    /// </summary>
    /// <param name="lightNovel">Used to update the information.</param>
    /// <returns>The <see cref="LightNovel"/> with data.</returns>
    public async Task<LightNovel> GetBookData(LightNovel lightNovel) => await _transactions.GetBookData(lightNovel);

    /// <summary>
    /// Get all chapters from the book.
    /// </summary>
    /// <param name="lightNovel">Used to update the information.</param>
    /// <returns>The <see cref="LightNovel"/> with the chapters.</returns>
    public async Task<LightNovel> GetChapters(LightNovel lightNovel) => await _transactions.GetChapters(lightNovel);
}