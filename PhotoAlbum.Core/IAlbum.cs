using System.Collections.Generic;
using System.ComponentModel;

namespace PhotoAlbum.Core
{
    public interface IAlbum
    {
        /// <summary>
        /// Hash code of the album.
        /// </summary>
        [DisplayName("Hash")]
        string Hash { get; }

        /// <summary>
        /// Photos in the album.
        /// </summary>
        [DisplayName("Photos")]
        IEnumerable<Photo> Photos { get; }
    }
}
