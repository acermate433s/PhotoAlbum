using System.ComponentModel;

namespace PhotoAlbum.Core
{
    public interface IPhoto
    {
        /// <summary>
        /// Hash code of the photo.
        /// </summary>
        [DisplayName("Hash")]
        string Hash { get; }

        /// <summary>
        /// Name of the photo
        /// </summary>
        [DisplayName("Name")]
        string Name { get; }

        /// <summary>
        /// Resolution of the photo
        /// </summary>
        [DisplayName("Resolution")]
        string Resolution { get; }

        /// <summary>
        /// Height in pixels of the photo
        /// </summary>
        [DisplayName("Height")]
        int Height { get; }

        /// <summary>
        /// Width in pixels of the photo
        /// </summary>
        [DisplayName("Width")]
        int Width { get; }

        /// <summary>
        /// Disk space used of the photo in bytes
        /// </summary>
        [DisplayName("Size")]
        int SizeInBytes { get; }
    }
}
