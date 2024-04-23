using System;

namespace ComicStripToKindle.ComicsPages
{
    interface IComicPagesProvider
    {
        event EventHandler<ComicPagesProvider.ComicPagesProviderProgressEventArgs> Progression;

        ComicPages ExtractPages();
        ComicPages ExtractRandomPage();
    }
}
