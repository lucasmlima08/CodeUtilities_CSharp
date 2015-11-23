using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace CodeUtilities
{
    class CompressByte
    {
        public byte[] compress(byte[] byteCompress)
        {
            MemoryStream memoryStream = new MemoryStream();
            GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress);
            gzipStream.Write(byteCompress, 0, byteCompress.Length);
            byte[] byteResult = memoryStream.ToArray();
            return byteResult;
        }

        public byte[] decompress(byte[] byteDecompress)
        {
            MemoryStream compressedStream = new MemoryStream(byteDecompress);
            GZipStream gzipStream = new GZipStream(compressedStream, CompressionMode.Decompress);
            MemoryStream resultStream = new MemoryStream();
            byte[] decompressed = resultStream.ToArray();
            return decompressed;
        }
    }
}
