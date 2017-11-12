using Xunit;
using PhotoAlbum.Core.Hashing;
using System.Collections.Generic;
using System;

namespace PhotoAlbum.Test.Hashing
{
    public class Base62HashingTest
    {
        // This are the only allowed characters for a URL
        const string SYMBOLS = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        const string CLEAR_TEXT = "The quick brown fox jumps over the lazy dog.";

        [Theory]
        [MemberData(nameof(ClearTexts))]
        public void Md5ComputeShouldReturnValidCharacters(string clearText)
        {
            var sut = new Base62HasherMd5(5);
            var hash = sut.Compute(clearText);

            bool flag = true;
            var enumerator = hash.GetEnumerator();
            while(flag && enumerator.MoveNext())
            {
                flag = SYMBOLS.Contains(enumerator.Current.ToString());
            }

            Assert.True(flag);
        }

        [Theory]
        [MemberData(nameof(ClearTexts))]
        public void Sha512ComputeShouldReturnValidCharacters(string clearText)
        {
            var sut = new Base62HasherSha512(5);
            var hash = sut.Compute(clearText);

            bool flag = true;
            var enumerator = hash.GetEnumerator();
            while(flag && enumerator.MoveNext())
            {
                flag = SYMBOLS.Contains(enumerator.Current.ToString());
            }

            Assert.True(flag);
        }

        [Theory]
        [MemberData(nameof(HashLengts))]
        public void Md5ComputeShouldReturnValidNumberOfCharacters(int hashLength)
        {
            var sut = new Base62HasherMd5(hashLength);
            var hash = sut.Compute(CLEAR_TEXT);

            Assert.StrictEqual(hashLength, hash.Length);
        }

        [Theory]
        [MemberData(nameof(HashLengts))]
        public void Sha512ComputeShouldReturnValidNumberOfCharacters(int hashLength)
        {
            var sut = new Base62HasherSha512(hashLength);
            var hash = sut.Compute(CLEAR_TEXT);

            Assert.StrictEqual(hashLength, hash.Length);
        }

        public static IEnumerable<object[]> HashLengts()
        {
            for(int i = 1; i <= 10; i++)
            {
                yield return new object[] { i };
            }
        }

        public static IEnumerable<object[]> ClearTexts()
        {
            yield return new object[] { "The quick brown fox jumps over the lazy dog." };
            yield return new object[] { "Mary had a little lamb." };
            yield return new object[] { Guid.NewGuid().ToString() };
        }
    }
}
