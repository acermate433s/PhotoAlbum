using System.Security.Cryptography;

namespace PhotoAlbum.Core.Hashing
{
    public class Base62HasherSha512 : Base62HasherBase<SHA512CryptoServiceProvider>
    {
        public Base62HasherSha512(int hashLength)
        {
            HashLength = hashLength;
        }
    }
}
