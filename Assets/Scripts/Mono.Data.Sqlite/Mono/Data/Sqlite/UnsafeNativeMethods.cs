using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Mono.Data.Sqlite
{
	[SuppressUnmanagedCodeSecurity]
	internal static class UnsafeNativeMethods
	{
		[PreserveSig]
		internal static extern int sqlite3_close(IntPtr db);

		[PreserveSig]
		internal static extern int sqlite3_create_function(IntPtr db, byte[] strName, int nArgs, int nType, IntPtr pvUser, SQLiteCallback func, SQLiteCallback fstep, SQLiteFinalCallback ffinal);

		[PreserveSig]
		internal static extern int sqlite3_finalize(IntPtr stmt);

		[PreserveSig]
		internal static extern int sqlite3_open_v2(byte[] utf8Filename, out IntPtr db, int flags, IntPtr vfs);

		[PreserveSig]
		internal static extern int sqlite3_open(byte[] utf8Filename, out IntPtr db);

		[PreserveSig]
		internal static extern int sqlite3_open16(string fileName, out IntPtr db);

		[PreserveSig]
		internal static extern int sqlite3_reset(IntPtr stmt);

		[PreserveSig]
		internal static extern IntPtr sqlite3_bind_parameter_name(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_database_name(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_database_name16(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_decltype(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_name(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_name16(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_origin_name(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_origin_name16(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_table_name(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_table_name16(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_text(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_text16(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_errmsg(IntPtr db);

		[PreserveSig]
		internal static extern int sqlite3_prepare(IntPtr db, IntPtr pSql, int nBytes, out IntPtr stmt, out IntPtr ptrRemain);

		[PreserveSig]
		internal static extern int sqlite3_table_column_metadata(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, out IntPtr ptrDataType, out IntPtr ptrCollSeq, out int notNull, out int primaryKey, out int autoInc);

		[PreserveSig]
		internal static extern IntPtr sqlite3_value_text(IntPtr p);

		[PreserveSig]
		internal static extern IntPtr sqlite3_value_text16(IntPtr p);

		[PreserveSig]
		internal static extern IntPtr sqlite3_libversion();

		[PreserveSig]
		internal static extern int sqlite3_changes(IntPtr db);

		[PreserveSig]
		internal static extern int sqlite3_busy_timeout(IntPtr db, int ms);

		[PreserveSig]
		internal static extern int sqlite3_bind_blob(IntPtr stmt, int index, byte[] value, int nSize, IntPtr nTransient);

		[PreserveSig]
		internal static extern int sqlite3_bind_double(IntPtr stmt, int index, double value);

		[PreserveSig]
		internal static extern int sqlite3_bind_int(IntPtr stmt, int index, int value);

		[PreserveSig]
		internal static extern int sqlite3_bind_int64(IntPtr stmt, int index, long value);

		[PreserveSig]
		internal static extern int sqlite3_bind_null(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern int sqlite3_bind_text(IntPtr stmt, int index, byte[] value, int nlen, IntPtr pvReserved);

		[PreserveSig]
		internal static extern int sqlite3_bind_parameter_count(IntPtr stmt);

		[PreserveSig]
		internal static extern int sqlite3_column_count(IntPtr stmt);

		[PreserveSig]
		internal static extern int sqlite3_step(IntPtr stmt);

		[PreserveSig]
		internal static extern double sqlite3_column_double(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern int sqlite3_column_int(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern long sqlite3_column_int64(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern IntPtr sqlite3_column_blob(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern int sqlite3_column_bytes(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern TypeAffinity sqlite3_column_type(IntPtr stmt, int index);

		[PreserveSig]
		internal static extern int sqlite3_create_collation(IntPtr db, byte[] strName, int nType, IntPtr pvUser, SQLiteCollation func);

		[PreserveSig]
		internal static extern IntPtr sqlite3_value_blob(IntPtr p);

		[PreserveSig]
		internal static extern int sqlite3_value_bytes(IntPtr p);

		[PreserveSig]
		internal static extern double sqlite3_value_double(IntPtr p);

		[PreserveSig]
		internal static extern long sqlite3_value_int64(IntPtr p);

		[PreserveSig]
		internal static extern TypeAffinity sqlite3_value_type(IntPtr p);

		[PreserveSig]
		internal static extern void sqlite3_result_blob(IntPtr context, byte[] value, int nSize, IntPtr pvReserved);

		[PreserveSig]
		internal static extern void sqlite3_result_double(IntPtr context, double value);

		[PreserveSig]
		internal static extern void sqlite3_result_error(IntPtr context, byte[] strErr, int nLen);

		[PreserveSig]
		internal static extern void sqlite3_result_int64(IntPtr context, long value);

		[PreserveSig]
		internal static extern void sqlite3_result_null(IntPtr context);

		[PreserveSig]
		internal static extern void sqlite3_result_text(IntPtr context, byte[] value, int nLen, IntPtr pvReserved);

		[PreserveSig]
		internal static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes);

		[PreserveSig]
		internal static extern int sqlite3_bind_text16(IntPtr stmt, int index, string value, int nlen, IntPtr pvReserved);

		[PreserveSig]
		internal static extern void sqlite3_result_error16(IntPtr context, string strName, int nLen);

		[PreserveSig]
		internal static extern void sqlite3_result_text16(IntPtr context, string strName, int nLen, IntPtr pvReserved);

		[PreserveSig]
		internal static extern int sqlite3_key(IntPtr db, byte[] key, int keylen);

		[PreserveSig]
		internal static extern IntPtr sqlite3_update_hook(IntPtr db, SQLiteUpdateCallback func, IntPtr pvUser);

		[PreserveSig]
		internal static extern IntPtr sqlite3_commit_hook(IntPtr db, SQLiteCommitCallback func, IntPtr pvUser);

		[PreserveSig]
		internal static extern IntPtr sqlite3_rollback_hook(IntPtr db, SQLiteRollbackCallback func, IntPtr pvUser);

		[PreserveSig]
		internal static extern IntPtr sqlite3_next_stmt(IntPtr db, IntPtr stmt);

		[PreserveSig]
		internal static extern int sqlite3_exec(IntPtr db, byte[] strSql, IntPtr pvCallback, IntPtr pvParam, out IntPtr errMsg);
	}
}
