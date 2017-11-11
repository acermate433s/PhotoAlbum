using System.Security.Cryptography;

namespace PhotoAlbum.Core.Hashing
{
    public class Base62HasherMd5 : Base62HasherBase<MD5CryptoServiceProvider>
    {
        public Base62HasherMd5(int hashLength)
        {
            HashLength = hashLength;
        }
    }
}
