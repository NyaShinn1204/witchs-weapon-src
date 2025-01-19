using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	public class ZipFile : IEnumerable<ZipEntry>, IDisposable, IEnumerable
	{
		private long _lengthOfReadStream;

		private TextWriter _StatusMessageTextWriter;

		private bool _CaseSensitiveRetrieval;

		private Stream _readstream;

		private Stream _writestream;

		private ushort _versionMadeBy;

		private ushort _versionNeededToExtract;

		private uint _diskNumberWithCd;

		private int _maxOutputSegmentSize;

		private uint _numberOfSegmentsForMostRecentSave;

		private ZipErrorAction _zipErrorAction;

		private bool _disposed;

		private Dictionary<string, ZipEntry> _entries;

		private List<ZipEntry> _zipEntriesAsList;

		private string _name;

		private string _readName;

		private string _Comment;

		internal string _Password;

		private bool _emitNtfsTimes;

		private bool _emitUnixTimes;

		private CompressionStrategy _Strategy;

		private CompressionMethod _compressionMethod;

		private bool _fileAlreadyExists;

		private string _temporaryFileName;

		private bool _contentsChanged;

		private bool _hasBeenSaved;

		private string _TempFileFolder;

		private bool _ReadStreamIsOurs;

		private object LOCK;

		private bool _saveOperationCanceled;

		private bool _extractOperationCanceled;

		private bool _addOperationCanceled;

		private EncryptionAlgorithm _Encryption;

		private bool _JustSaved;

		private long _locEndOfCDS;

		private uint _OffsetOfCentralDirectory;

		private long _OffsetOfCentralDirectory64;

		private bool? _OutputUsesZip64;

		internal bool _inExtractAll;

		private static Encoding _defaultEncoding;

		private Encoding _alternateEncoding;

		private ZipOption _alternateEncodingUsage;

		private int _BufferSize;

		internal ParallelDeflateOutputStream ParallelDeflater;

		private long _ParallelDeflateThreshold;

		private int _maxBufferPairs;

		internal Zip64Option _zip64;

		private bool _SavingSfx;

		public static readonly int BufferSizeDefault;

		private EventHandler<SaveProgressEventArgs> SaveProgress;

		private EventHandler<ExtractProgressEventArgs> ExtractProgress;

		private EventHandler<AddProgressEventArgs> AddProgress;

		private EventHandler<ZipErrorEventArgs> ZipError;

		[CompilerGenerated]
		private bool _003CFullScan_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CSortEntriesBeforeSaving_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CAddDirectoryWillTraverseReparsePoints_003Ek__BackingField;

		[CompilerGenerated]
		private int _003CCodecBufferSize_003Ek__BackingField;

		[CompilerGenerated]
		private bool _003CFlattenFoldersOnExtract_003Ek__BackingField;

		[CompilerGenerated]
		private ExtractExistingFileAction _003CExtractExistingFile_003Ek__BackingField;

		[CompilerGenerated]
		private SetCompressionCallback _003CSetCompression_003Ek__BackingField;

		private string ArchiveNameForEvent
		{
			get
			{
				return null;
			}
		}

		private long LengthOfReadStream
		{
			get
			{
				return 0L;
			}
		}

		public bool FullScan
		{
			[CompilerGenerated]
			get
			{
				return _003CFullScan_003Ek__BackingField;
			}
		}

		public bool SortEntriesBeforeSaving
		{
			[CompilerGenerated]
			get
			{
				return _003CSortEntriesBeforeSaving_003Ek__BackingField;
			}
		}

		public bool AddDirectoryWillTraverseReparsePoints
		{
			[CompilerGenerated]
			set
			{
				_003CAddDirectoryWillTraverseReparsePoints_003Ek__BackingField = value;
			}
		}

		public int BufferSize
		{
			get
			{
				return 0;
			}
		}

		public int CodecBufferSize
		{
			[CompilerGenerated]
			get
			{
				return _003CCodecBufferSize_003Ek__BackingField;
			}
		}

		public bool FlattenFoldersOnExtract
		{
			[CompilerGenerated]
			get
			{
				return _003CFlattenFoldersOnExtract_003Ek__BackingField;
			}
		}

		public CompressionStrategy Strategy
		{
			get
			{
				return default(CompressionStrategy);
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public CompressionLevel CompressionLevel { get; set; }

		public CompressionMethod CompressionMethod
		{
			get
			{
				return default(CompressionMethod);
			}
		}

		public string Comment
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool Verbose
		{
			get
			{
				return false;
			}
		}

		public bool CaseSensitiveRetrieval
		{
			get
			{
				return false;
			}
		}

		public Zip64Option UseZip64WhenSaving
		{
			get
			{
				return default(Zip64Option);
			}
			set
			{
			}
		}

		public Encoding AlternateEncoding
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ZipOption AlternateEncodingUsage
		{
			get
			{
				return default(ZipOption);
			}
			set
			{
			}
		}

		public static Encoding DefaultEncoding
		{
			get
			{
				return null;
			}
		}

		public TextWriter StatusMessageTextWriter
		{
			get
			{
				return null;
			}
		}

		public string TempFileFolder
		{
			get
			{
				return null;
			}
		}

		public ExtractExistingFileAction ExtractExistingFile
		{
			[CompilerGenerated]
			get
			{
				return _003CExtractExistingFile_003Ek__BackingField;
			}
		}

		public ZipErrorAction ZipErrorAction
		{
			get
			{
				return default(ZipErrorAction);
			}
		}

		public EncryptionAlgorithm Encryption
		{
			get
			{
				return default(EncryptionAlgorithm);
			}
		}

		public SetCompressionCallback SetCompression
		{
			[CompilerGenerated]
			get
			{
				return _003CSetCompression_003Ek__BackingField;
			}
		}

		public int MaxOutputSegmentSize
		{
			get
			{
				return 0;
			}
		}

		public long ParallelDeflateThreshold
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public int ParallelDeflateMaxBufferPairs
		{
			get
			{
				return 0;
			}
		}

		public ZipEntry Item
		{
			get
			{
				return null;
			}
		}

		public ICollection<ZipEntry> Entries
		{
			get
			{
				return null;
			}
		}

		public ICollection<ZipEntry> EntriesSorted
		{
			get
			{
				return null;
			}
		}

		internal Stream ReadStream
		{
			get
			{
				return null;
			}
		}

		private Stream WriteStream
		{
			get
			{
				return null;
			}
		}

		public event EventHandler<ReadProgressEventArgs> ReadProgress
		{
			add
			{
			}
			remove
			{
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public ZipEntry AddEntry(string entryName, Stream stream)
		{
			return null;
		}

		private ZipEntry _InternalAddEntry(ZipEntry ze)
		{
			return null;
		}

		public ZipEntry AddEntry(string entryName, byte[] byteContent)
		{
			return null;
		}

		internal void InternalAddEntry(string name, ZipEntry entry)
		{
		}

		internal bool OnSaveBlock(ZipEntry entry, long bytesXferred, long totalBytesToXfer)
		{
			return false;
		}

		private void OnSaveEntry(int current, ZipEntry entry, bool before)
		{
		}

		private void OnSaveEvent(ZipProgressEventType eventFlavor)
		{
		}

		private void OnSaveStarted()
		{
		}

		private void OnSaveCompleted()
		{
		}

		private void OnReadStarted()
		{
		}

		private void OnReadCompleted()
		{
		}

		internal void OnReadBytes(ZipEntry entry)
		{
		}

		internal void OnReadEntry(bool before, ZipEntry entry)
		{
		}

		internal bool OnExtractBlock(ZipEntry entry, long bytesWritten, long totalBytesToWrite)
		{
			return false;
		}

		internal bool OnSingleEntryExtract(ZipEntry entry, string path, bool before)
		{
			return false;
		}

		internal bool OnExtractExisting(ZipEntry entry, string path)
		{
			return false;
		}

		internal void AfterAddEntry(ZipEntry entry)
		{
		}

		internal bool OnZipErrorSaving(ZipEntry entry, Exception exc)
		{
			return false;
		}

		public static ZipFile Read(Stream zipStream)
		{
			return null;
		}

		private static ZipFile Read(Stream zipStream, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
		{
			return null;
		}

		private static void ReadIntoInstance(ZipFile zf)
		{
		}

		private static void Zip64SeekToCentralDirectory(ZipFile zf)
		{
		}

		private static uint ReadFirstFourBytes(Stream s)
		{
			return 0u;
		}

		private static void ReadCentralDirectory(ZipFile zf)
		{
		}

		private static void ReadIntoInstance_Orig(ZipFile zf)
		{
		}

		private static void ReadCentralDirectoryFooter(ZipFile zf)
		{
		}

		private static void ReadZipFileComment(ZipFile zf)
		{
		}

		private void DeleteFileWithRetry(string filename)
		{
		}

		public void Save()
		{
		}

		private static void NotifyEntriesSaveComplete(ICollection<ZipEntry> c)
		{
		}

		private void RemoveTempFile()
		{
		}

		private void CleanupAfterSaveOperation()
		{
		}

		public void Save(Stream outputStream)
		{
		}

		public bool ContainsEntry(string name)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		internal void NotifyEntryChanged()
		{
		}

		internal Stream StreamForDiskNumber(uint diskNumber)
		{
			return null;
		}

		internal void Reset(bool whileSaving)
		{
		}

		private void _initEntriesDictionary()
		{
		}

		private void _InitInstance(string zipFileName, TextWriter statusMessageWriter)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposeManagedResources)
		{
		}

		[DebuggerHidden]
		public IEnumerator<ZipEntry> GetEnumerator()
		{
			return null;
		}
	}
}
