namespace PhotoAlbum.Core
{
    /// <summary>
    /// Interface for factory of Album
    /// </summary>
    interface IAlbumFactory
    {
        /// <summary>
        /// Creates an instance of an album.
        /// </summary>
        IAlbum Create();
    }
}
