using System;

namespace HashLib
{
    public static class HashFactory
    {
        public static class Crypto
        {
            public static class SHA3
            {
                public static IHash CreateJH512()
                {
                    return new HashLib.Crypto.SHA3.JH512();
                }

                public static IHash CreateBlake512()
                {
                    return new HashLib.Crypto.SHA3.Blake512();
                }

                public static IHash CreateBlueMidnightWish512()
                {
                    return new HashLib.Crypto.SHA3.BlueMidnightWish512();
                }
               
                public static IHash CreateEcho512()
                {
                    return new HashLib.Crypto.SHA3.Echo512();
                }

                public static IHash CreateGroestl512()
                {
                    return new HashLib.Crypto.SHA3.Groestl512();
                }
                
                public static IHash CreateKeccak512()
                {
                    return new HashLib.Crypto.SHA3.Keccak512();
                }
                
                public static IHash CreateLuffa512()
                {
                    return new HashLib.Crypto.SHA3.Luffa512();
                }

                public static IHash CreateSHAvite3_512()
                {
                    return new HashLib.Crypto.SHA3.SHAvite3_512();
                }

                public static IHash CreateSIMD512()
                {
                    return new HashLib.Crypto.SHA3.SIMD512();
                }
                
                public static IHash CreateSkein512()
                {
                    return new HashLib.Crypto.SHA3.Skein512();
                }

                public static IHash CreateCubeHash224()
                {
                    return new HashLib.Crypto.SHA3.CubeHash224();
                }

                public static IHash CreateCubeHash256()
                {
                    return new HashLib.Crypto.SHA3.CubeHash256();
                }

                public static IHash CreateCubeHash384()
                {
                    return new HashLib.Crypto.SHA3.CubeHash384();
                }

                public static IHash CreateCubeHash512()
                {
                    return new HashLib.Crypto.SHA3.CubeHash512();
                }

                /// <summary>
                /// 
                /// </summary>
                /// <param name="a_hash_size">224, 256, 384, 512</param>
                /// <returns></returns>
                public static IHash CreateCubeHash(HashLib.HashSize a_hash_size)
                {
                    switch (a_hash_size)
                    {
                        case HashLib.HashSize.HashSize224: return CreateCubeHash224();
                        case HashLib.HashSize.HashSize256: return CreateCubeHash256();
                        case HashLib.HashSize.HashSize384: return CreateCubeHash384();
                        case HashLib.HashSize.HashSize512: return CreateCubeHash512();
                        default: throw new ArgumentException();
                    }
                }
            }
        }
    }
}
