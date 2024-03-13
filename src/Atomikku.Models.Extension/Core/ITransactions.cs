namespace Atomikku.Models.Extension;

public interface ITransactions
{
    Task<LightNovel> GetBookData(LightNovel lightNovel);

    Task<LightNovel> GetChapters(LightNovel lightNovel);

    Task<LightNovelToSearch> GetSearchBooks(LightNovelToSearch lightNovel);
}