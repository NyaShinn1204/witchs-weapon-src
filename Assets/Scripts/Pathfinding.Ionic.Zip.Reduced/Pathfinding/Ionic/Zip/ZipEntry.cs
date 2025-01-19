using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Pathfinding.Ionic.Crc;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	public class ZipEntry
	{
		private class CopyHelper
		{
			private static Regex re;

			private static int callCount;

			internal static string AppendCopyToFileName(string f)
			{
				return null;
			}
		}

		private short _VersionMadeBy;

		private short _InternalFileAttrs;

		private int _ExternalFileAttrs;

		private short _filenameLength;

		private short _extraFieldLength;

		private short _commentLength;

		private Stream _inputDecryptorStream;

		private object _outputLock;

		private ZipCrypto _zipCrypto_forExtract;

		private ZipCrypto _zipCrypto_forWrite;

		internal DateTime _LastModified;

		private DateTime _Mtime;

		private DateTime _Atime;

		private DateTime _Ctime;

		private bool _ntfsTimesAreSet;

		private bool _emitNtfsTimes;

		private bool _emitUnixTimes;

		private bool _TrimVolumeFromFullyQualifiedPaths;

		internal string _LocalFileName;

		private string _FileNameInArchive;

		internal short _VersionNeeded;

		internal short _BitField;

		internal short _CompressionMethod;

		private short _CompressionMethod_FromZipFile;

		private CompressionLevel _CompressionLevel;

		internal string _Comment;

		private bool _IsDirectory;

		private byte[] _CommentBytes;

		internal long _CompressedSize;

		internal long _CompressedFileDataSize;

		internal long _UncompressedSize;

		internal int _TimeBlob;

		private bool _crcCalculated;

		internal int _Crc32;

		internal byte[] _Extra;

		private bool _metadataChanged;

		private bool _restreamRequiredOnSave;

		private bool _sourceIsEncrypted;

		private bool _skippedDuringSave;

		private uint _diskNumber;

		private static Encoding ibm437;

		private Encoding _actualEncoding;

		internal ZipContainer _container;

		private long __FileDataPosition;

		private byte[] _EntryHeader;

		internal long _RelativeOffsetOfLocalHeader;

		private long _future_ROLH;

		private long _TotalEntrySize;

		private int _LengthOfHeader;

		private int _LengthOfTrailer;

		internal bool _InputUsesZip64;

		private uint _UnsupportedAlgorithmId;

		internal string _Password;

		internal ZipEntrySource _Source;

		internal EncryptionAlgorithm _Encryption;

		internal EncryptionAlgorithm _Encryption_FromZipFile;

		internal byte[] _WeakEncryptionHeader;

		internal Stream _archiveStream;

		private Stream _sourceStream;

		private long? _sourceStreamOriginalPosition;

		private bool _ioOperationCanceled;

		private bool _presumeZip64;

		private bool? _entryRequiresZip64;

		private bool? _OutputUsesZip64;

		private bool _IsText;

		private ZipEntryTimestamp _timestamp;

		private static DateTime _unixEpoch;

		private static DateTime _win32Epoch;

		private static DateTime _zeroHour;

		private WriteDelegate _WriteDelegate;

		private OpenDelegate _OpenDelegate;

		private CloseDelegate _CloseDelegate;

		internal bool AttributesIndicateDirectory
		{
			get
			{
				return false;
			}
		}

		private string UnsupportedAlgorithm
		{
			get
			{
				return null;
			}
		}

		private string UnsupportedCompressionMethod
		{
			get
			{
				return null;
			}
		}

		public DateTime LastModified
		{
			get
			{
				return default(DateTime);
			}
		}

		private int BufferSize
		{
			get
			{
				return 0;
			}
		}

		public bool EmitTimesInWindowsFormatWhenSaving
		{
			set
			{
			}
		}

		public bool EmitTimesInUnixFormatWhenSaving
		{
			set
			{
			}
		}

		internal string LocalFileName
		{
			get
			{
				return null;
			}
		}

		public string FileName
		{
			get
			{
				return null;
			}
		}

		public short VersionNeeded
		{
			get
			{
				return 0;
			}
		}

		public string Comment
		{
			get
			{
				return null;
			}
		}

		public bool? OutputUsedZip64
		{
			get
			{
				return null;
			}
		}

		public CompressionMethod CompressionMethod
		{
			get
			{
				return default(CompressionMethod);
			}
			set
			{
			}
		}

		public CompressionLevel CompressionLevel
		{
			get
			{
				return default(CompressionLevel);
			}
			set
			{
			}
		}

		public long CompressedSize
		{
			get
			{
				return 0L;
			}
		}

		public long UncompressedSize
		{
			get
			{
				return 0L;
			}
		}

		public bool IsDirectory
		{
			get
			{
				return false;
			}
		}

		public EncryptionAlgorithm Encryption
		{
			get
			{
				return default(EncryptionAlgorithm);
			}
			set
			{
			}
		}

		public string Password
		{
			set
			{
			}
		}

		public ExtractExistingFileAction ExtractExistingFile { get; set; }

		public ZipErrorAction ZipErrorAction { get; set; }

		public bool IncludedInMostRecentSave
		{
			get
			{
				return false;
			}
		}

		public SetCompressionCallback SetCompression { get; set; }

		public Encoding AlternateEncoding { get; set; }

		public ZipOption AlternateEncodingUsage { get; set; }

		public bool IsText
		{
			set
			{
			}
		}

		internal Stream ArchiveStream
		{
			get
			{
				return null;
			}
		}

		internal long FileDataPosition
		{
			get
			{
				return 0L;
			}
		}

		private int LengthOfHeader
		{
			get
			{
				return 0;
			}
		}

		internal void ResetDirEntry()
		{
		}

		internal static ZipEntry ReadDirEntry(ZipFile zf, Dictionary<string, object> previouslySeen)
		{
			return null;
		}

		internal static bool IsNotValidZipDirEntrySig(int signature)
		{
			return false;
		}

		public void Extract(Stream stream)
		{
		}

		internal CrcCalculatorStream InternalOpenReader(string password)
		{
			return null;
		}

		private void OnExtractProgress(long bytesWritten, long totalBytesToWrite)
		{
		}

		private void OnBeforeExtract(string path)
		{
		}

		private void OnAfterExtract(string path)
		{
		}

		private void OnExtractExisting(string path)
		{
		}

		private static void ReallyDelete(string fileName)
		{
		}

		private void WriteStatus(string format, params object[] args)
		{
		}

		private void InternalExtract(string baseDir, Stream outstream, string password)
		{
		}

		internal void VerifyCrcAfterExtract(int actualCrc32)
		{
		}

		private int CheckExtractExistingFile(string baseDir, string targetFileName)
		{
			return 0;
		}

		private void _CheckRead(int nbytes)
		{
		}

		private int ExtractOne(Stream output)
		{
			return 0;
		}

		internal Stream GetExtractDecompressor(Stream input2)
		{
			return null;
		}

		internal Stream GetExtractDecryptor(Stream input)
		{
			return null;
		}

		internal void _SetTimes(string fileOrDirectory, bool isFile)
		{
		}

		internal void ValidateEncryption()
		{
		}

		private void ValidateCompression()
		{
		}

		private void SetupCryptoForExtract(string password)
		{
		}

		private bool ValidateOutput(string basedir, Stream outstream, out string outFileName)
		{
			outFileName = null;
			return false;
		}

		private static bool ReadHeader(ZipEntry ze, Encoding defaultEncoding)
		{
			return false;
		}

		internal static int ReadWeakEncryptionHeader(Stream s, byte[] buffer)
		{
			return 0;
		}

		private static bool IsNotValidSig(int signature)
		{
			return false;
		}

		internal static ZipEntry ReadEntry(ZipContainer zc, bool first)
		{
			return null;
		}

		internal static void HandlePK00Prefix(Stream s)
		{
		}

		private static void HandleUnexpectedDataDescriptor(ZipEntry entry)
		{
		}

		internal int ProcessExtraField(Stream s, short extraFieldLength)
		{
			return 0;
		}

		private int ProcessExtraFieldPkwareStrongEncryption(byte[] Buffer, int j)
		{
			return 0;
		}

		private int ProcessExtraFieldZip64(byte[] buffer, int j, short dataSize, long posn)
		{
			return 0;
		}

		private int ProcessExtraFieldInfoZipTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			return 0;
		}

		private int ProcessExtraFieldUnixTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			return 0;
		}

		private int ProcessExtraFieldWindowsTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			return 0;
		}

		internal void WriteCentralDirectoryEntry(Stream s)
		{
		}

		private byte[] ConstructExtraField(bool forCentralDirectory)
		{
			return null;
		}

		private string NormalizeFileName()
		{
			return null;
		}

		private byte[] GetEncodedFileNameBytes()
		{
			return null;
		}

		private bool WantReadAgain()
		{
			return false;
		}

		private void MaybeUnsetCompressionMethodForWriting(int cycle)
		{
		}

		internal void WriteHeader(Stream s, int cycle)
		{
		}

		private int FigureCrc32()
		{
			return 0;
		}

		private void PrepSourceStream()
		{
		}

		internal void CopyMetaData(ZipEntry source)
		{
		}

		private void OnWriteBlock(long bytesXferred, long totalBytesToXfer)
		{
		}

		private void _WriteEntryData(Stream s)
		{
		}

		private long SetInputAndFigureFileLength(ref Stream input)
		{
			return 0L;
		}

		internal void FinishOutputStream(Stream s, CountingStream entryCounter, Stream encryptor, Stream compressor, CrcCalculatorStream output)
		{
		}

		internal void PostProcessOutput(Stream s)
		{
		}

		private void SetZip64Flags()
		{
		}

		internal void PrepOutputStream(Stream s, long streamLength, out CountingStream outputCounter, out Stream encryptor, out Stream compressor, out CrcCalculatorStream output)
		{
			outputCounter = null;
			encryptor = null;
			compressor = null;
			output = null;
		}

		private Stream MaybeApplyCompression(Stream s, long streamLength)
		{
			return null;
		}

		private Stream MaybeApplyEncryption(Stream s)
		{
			return null;
		}

		private void OnZipErrorWhileSaving(Exception e)
		{
		}

		internal void Write(Stream s)
		{
		}

		internal void StoreRelativeOffset()
		{
		}

		internal void NotifySaveComplete()
		{
		}

		internal void WriteSecurityMetadata(Stream outstream)
		{
		}

		private void CopyThroughOneEntry(Stream outStream)
		{
		}

		private void CopyThroughWithRecompute(Stream outstream)
		{
		}

		private void CopyThroughWithNoChange(Stream outstream)
		{
		}

		public void SetEntryTimes(DateTime created, DateTime accessed, DateTime modified)
		{
		}

		internal static ZipEntry CreateForStream(string entryName, Stream s)
		{
			return null;
		}

		private static ZipEntry Create(string nameInArchive, ZipEntrySource source, object arg1, object arg2)
		{
			return null;
		}

		internal void MarkAsDirectory()
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void SetFdpLoh()
		{
		}

		internal static int GetLengthOfCryptoHeaderBytes(EncryptionAlgorithm a)
		{
			return 0;
		}
	}
}
