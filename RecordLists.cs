using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;
using OutSystems.HubEdition.RuntimePlatform.NewRuntime;

namespace OutSystems.NssGRAX_AthenaConnector {

	/// <summary>
	/// RecordList type <code>RLAthena_AuthenticationInfoRecordList</code> that represents a record list of
	///  <code>Athena_AuthenticationInfo</code>
	/// </summary>
	[Serializable()]
	public partial class RLAthena_AuthenticationInfoRecordList: GenericRecordList<RCAthena_AuthenticationInfoRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAthena_AuthenticationInfoRecord GetElementDefaultValue() {
			return new RCAthena_AuthenticationInfoRecord("");
		}

		public T[] ToArray<T>(Func<RCAthena_AuthenticationInfoRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAthena_AuthenticationInfoRecordList recordlist, Func<RCAthena_AuthenticationInfoRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAthena_AuthenticationInfoRecordList(RCAthena_AuthenticationInfoRecord[] array) {
			RLAthena_AuthenticationInfoRecordList result = new RLAthena_AuthenticationInfoRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAthena_AuthenticationInfoRecordList ToList<T>(T[] array, Func <T, RCAthena_AuthenticationInfoRecord> converter) {
			RLAthena_AuthenticationInfoRecordList result = new RLAthena_AuthenticationInfoRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAthena_AuthenticationInfoRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAthena_AuthenticationInfoRecord> converter) {
			RLAthena_AuthenticationInfoRecordList result = new RLAthena_AuthenticationInfoRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAthena_AuthenticationInfoRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_AuthenticationInfoRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_AuthenticationInfoRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAthena_AuthenticationInfoRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAthena_AuthenticationInfoRecord> NewList() {
			return new RLAthena_AuthenticationInfoRecordList();
		}


	} // RLAthena_AuthenticationInfoRecordList

	/// <summary>
	/// RecordList type <code>RLAthena_NamedQueryRecordList</code> that represents a record list of
	///  <code>Athena_NamedQuery</code>
	/// </summary>
	[Serializable()]
	public partial class RLAthena_NamedQueryRecordList: GenericRecordList<RCAthena_NamedQueryRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAthena_NamedQueryRecord GetElementDefaultValue() {
			return new RCAthena_NamedQueryRecord("");
		}

		public T[] ToArray<T>(Func<RCAthena_NamedQueryRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAthena_NamedQueryRecordList recordlist, Func<RCAthena_NamedQueryRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAthena_NamedQueryRecordList(RCAthena_NamedQueryRecord[] array) {
			RLAthena_NamedQueryRecordList result = new RLAthena_NamedQueryRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAthena_NamedQueryRecordList ToList<T>(T[] array, Func <T, RCAthena_NamedQueryRecord> converter) {
			RLAthena_NamedQueryRecordList result = new RLAthena_NamedQueryRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAthena_NamedQueryRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAthena_NamedQueryRecord> converter) {
			RLAthena_NamedQueryRecordList result = new RLAthena_NamedQueryRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAthena_NamedQueryRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_NamedQueryRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_NamedQueryRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAthena_NamedQueryRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAthena_NamedQueryRecord> NewList() {
			return new RLAthena_NamedQueryRecordList();
		}


	} // RLAthena_NamedQueryRecordList

	/// <summary>
	/// RecordList type <code>RLAthena_QueryExecutionContextRecordList</code> that represents a record list
	///  of <code>Athena_QueryExecutionContext</code>
	/// </summary>
	[Serializable()]
	public partial class RLAthena_QueryExecutionContextRecordList: GenericRecordList<RCAthena_QueryExecutionContextRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAthena_QueryExecutionContextRecord GetElementDefaultValue() {
			return new RCAthena_QueryExecutionContextRecord("");
		}

		public T[] ToArray<T>(Func<RCAthena_QueryExecutionContextRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAthena_QueryExecutionContextRecordList recordlist, Func<RCAthena_QueryExecutionContextRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAthena_QueryExecutionContextRecordList(RCAthena_QueryExecutionContextRecord[] array) {
			RLAthena_QueryExecutionContextRecordList result = new RLAthena_QueryExecutionContextRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAthena_QueryExecutionContextRecordList ToList<T>(T[] array, Func <T, RCAthena_QueryExecutionContextRecord> converter) {
			RLAthena_QueryExecutionContextRecordList result = new RLAthena_QueryExecutionContextRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAthena_QueryExecutionContextRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAthena_QueryExecutionContextRecord> converter) {
			RLAthena_QueryExecutionContextRecordList result = new RLAthena_QueryExecutionContextRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAthena_QueryExecutionContextRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_QueryExecutionContextRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_QueryExecutionContextRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAthena_QueryExecutionContextRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAthena_QueryExecutionContextRecord> NewList() {
			return new RLAthena_QueryExecutionContextRecordList();
		}


	} // RLAthena_QueryExecutionContextRecordList

	/// <summary>
	/// RecordList type <code>RLAthena_EncryptionConfigurationRecordList</code> that represents a record
	///  list of <code>Athena_EncryptionConfiguration</code>
	/// </summary>
	[Serializable()]
	public partial class RLAthena_EncryptionConfigurationRecordList: GenericRecordList<RCAthena_EncryptionConfigurationRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAthena_EncryptionConfigurationRecord GetElementDefaultValue() {
			return new RCAthena_EncryptionConfigurationRecord("");
		}

		public T[] ToArray<T>(Func<RCAthena_EncryptionConfigurationRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAthena_EncryptionConfigurationRecordList recordlist, Func<RCAthena_EncryptionConfigurationRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAthena_EncryptionConfigurationRecordList(RCAthena_EncryptionConfigurationRecord[] array) {
			RLAthena_EncryptionConfigurationRecordList result = new RLAthena_EncryptionConfigurationRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAthena_EncryptionConfigurationRecordList ToList<T>(T[] array, Func <T, RCAthena_EncryptionConfigurationRecord> converter) {
			RLAthena_EncryptionConfigurationRecordList result = new RLAthena_EncryptionConfigurationRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAthena_EncryptionConfigurationRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAthena_EncryptionConfigurationRecord> converter) {
			RLAthena_EncryptionConfigurationRecordList result = new RLAthena_EncryptionConfigurationRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAthena_EncryptionConfigurationRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_EncryptionConfigurationRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_EncryptionConfigurationRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAthena_EncryptionConfigurationRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAthena_EncryptionConfigurationRecord> NewList() {
			return new RLAthena_EncryptionConfigurationRecordList();
		}


	} // RLAthena_EncryptionConfigurationRecordList

	/// <summary>
	/// RecordList type <code>RLAthena_ResultConfigurationRecordList</code> that represents a record list
	///  of <code>Athena_ResultConfiguration</code>
	/// </summary>
	[Serializable()]
	public partial class RLAthena_ResultConfigurationRecordList: GenericRecordList<RCAthena_ResultConfigurationRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAthena_ResultConfigurationRecord GetElementDefaultValue() {
			return new RCAthena_ResultConfigurationRecord("");
		}

		public T[] ToArray<T>(Func<RCAthena_ResultConfigurationRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAthena_ResultConfigurationRecordList recordlist, Func<RCAthena_ResultConfigurationRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAthena_ResultConfigurationRecordList(RCAthena_ResultConfigurationRecord[] array) {
			RLAthena_ResultConfigurationRecordList result = new RLAthena_ResultConfigurationRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAthena_ResultConfigurationRecordList ToList<T>(T[] array, Func <T, RCAthena_ResultConfigurationRecord> converter) {
			RLAthena_ResultConfigurationRecordList result = new RLAthena_ResultConfigurationRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAthena_ResultConfigurationRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAthena_ResultConfigurationRecord> converter) {
			RLAthena_ResultConfigurationRecordList result = new RLAthena_ResultConfigurationRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAthena_ResultConfigurationRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_ResultConfigurationRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_ResultConfigurationRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAthena_ResultConfigurationRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAthena_ResultConfigurationRecord> NewList() {
			return new RLAthena_ResultConfigurationRecordList();
		}


	} // RLAthena_ResultConfigurationRecordList

	/// <summary>
	/// RecordList type <code>RLTextRecordList</code> that represents a record list of <code>Text</code>
	/// </summary>
	[Serializable()]
	public partial class RLTextRecordList: GenericRecordList<RCTextRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCTextRecord GetElementDefaultValue() {
			return new RCTextRecord("");
		}

		public T[] ToArray<T>(Func<RCTextRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLTextRecordList recordlist, Func<RCTextRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLTextRecordList(RCTextRecord[] array) {
			RLTextRecordList result = new RLTextRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLTextRecordList ToList<T>(T[] array, Func <T, RCTextRecord> converter) {
			RLTextRecordList result = new RLTextRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLTextRecordList FromRestList<T>(RestList<T> restList, Func <T, RCTextRecord> converter) {
			RLTextRecordList result = new RLTextRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLTextRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTextRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLTextRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLTextRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCTextRecord> NewList() {
			return new RLTextRecordList();
		}


	} // RLTextRecordList

	/// <summary>
	/// RecordList type <code>RLAthena_EngineVersionRecordList</code> that represents a record list of
	///  <code>Athena_EngineVersion</code>
	/// </summary>
	[Serializable()]
	public partial class RLAthena_EngineVersionRecordList: GenericRecordList<RCAthena_EngineVersionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAthena_EngineVersionRecord GetElementDefaultValue() {
			return new RCAthena_EngineVersionRecord("");
		}

		public T[] ToArray<T>(Func<RCAthena_EngineVersionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAthena_EngineVersionRecordList recordlist, Func<RCAthena_EngineVersionRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAthena_EngineVersionRecordList(RCAthena_EngineVersionRecord[] array) {
			RLAthena_EngineVersionRecordList result = new RLAthena_EngineVersionRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAthena_EngineVersionRecordList ToList<T>(T[] array, Func <T, RCAthena_EngineVersionRecord> converter) {
			RLAthena_EngineVersionRecordList result = new RLAthena_EngineVersionRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAthena_EngineVersionRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAthena_EngineVersionRecord> converter) {
			RLAthena_EngineVersionRecordList result = new RLAthena_EngineVersionRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAthena_EngineVersionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_EngineVersionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_EngineVersionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAthena_EngineVersionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAthena_EngineVersionRecord> NewList() {
			return new RLAthena_EngineVersionRecordList();
		}


	} // RLAthena_EngineVersionRecordList

	/// <summary>
	/// RecordList type <code>RLAthena_QueryExecutionRecordList</code> that represents a record list of
	///  <code>Athena_QueryExecution</code>
	/// </summary>
	[Serializable()]
	public partial class RLAthena_QueryExecutionRecordList: GenericRecordList<RCAthena_QueryExecutionRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAthena_QueryExecutionRecord GetElementDefaultValue() {
			return new RCAthena_QueryExecutionRecord("");
		}

		public T[] ToArray<T>(Func<RCAthena_QueryExecutionRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAthena_QueryExecutionRecordList recordlist, Func<RCAthena_QueryExecutionRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAthena_QueryExecutionRecordList(RCAthena_QueryExecutionRecord[] array) {
			RLAthena_QueryExecutionRecordList result = new RLAthena_QueryExecutionRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAthena_QueryExecutionRecordList ToList<T>(T[] array, Func <T, RCAthena_QueryExecutionRecord> converter) {
			RLAthena_QueryExecutionRecordList result = new RLAthena_QueryExecutionRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAthena_QueryExecutionRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAthena_QueryExecutionRecord> converter) {
			RLAthena_QueryExecutionRecordList result = new RLAthena_QueryExecutionRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAthena_QueryExecutionRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_QueryExecutionRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_QueryExecutionRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAthena_QueryExecutionRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAthena_QueryExecutionRecord> NewList() {
			return new RLAthena_QueryExecutionRecordList();
		}


	} // RLAthena_QueryExecutionRecordList

	/// <summary>
	/// RecordList type <code>RLAthena_QueryExecutionStatusRecordList</code> that represents a record list
	///  of <code>Athena_QueryExecutionStatus</code>
	/// </summary>
	[Serializable()]
	public partial class RLAthena_QueryExecutionStatusRecordList: GenericRecordList<RCAthena_QueryExecutionStatusRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAthena_QueryExecutionStatusRecord GetElementDefaultValue() {
			return new RCAthena_QueryExecutionStatusRecord("");
		}

		public T[] ToArray<T>(Func<RCAthena_QueryExecutionStatusRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAthena_QueryExecutionStatusRecordList recordlist, Func<RCAthena_QueryExecutionStatusRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAthena_QueryExecutionStatusRecordList(RCAthena_QueryExecutionStatusRecord[] array) {
			RLAthena_QueryExecutionStatusRecordList result = new RLAthena_QueryExecutionStatusRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAthena_QueryExecutionStatusRecordList ToList<T>(T[] array, Func <T, RCAthena_QueryExecutionStatusRecord> converter) {
			RLAthena_QueryExecutionStatusRecordList result = new RLAthena_QueryExecutionStatusRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAthena_QueryExecutionStatusRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAthena_QueryExecutionStatusRecord> converter) {
			RLAthena_QueryExecutionStatusRecordList result = new RLAthena_QueryExecutionStatusRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAthena_QueryExecutionStatusRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_QueryExecutionStatusRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_QueryExecutionStatusRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAthena_QueryExecutionStatusRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAthena_QueryExecutionStatusRecord> NewList() {
			return new RLAthena_QueryExecutionStatusRecordList();
		}


	} // RLAthena_QueryExecutionStatusRecordList

	/// <summary>
	/// RecordList type <code>RLAthena_QueryExecutionStatisticsRecordList</code> that represents a record
	///  list of <code>Athena_QueryExecutionStatistics</code>
	/// </summary>
	[Serializable()]
	public partial class RLAthena_QueryExecutionStatisticsRecordList: GenericRecordList<RCAthena_QueryExecutionStatisticsRecord>, IEnumerable, IEnumerator, ISerializable {
		public static void EnsureInitialized() {}

		protected override RCAthena_QueryExecutionStatisticsRecord GetElementDefaultValue() {
			return new RCAthena_QueryExecutionStatisticsRecord("");
		}

		public T[] ToArray<T>(Func<RCAthena_QueryExecutionStatisticsRecord, T> converter) {
			return ToArray(this, converter);
		}

		public static T[] ToArray<T>(RLAthena_QueryExecutionStatisticsRecordList recordlist, Func<RCAthena_QueryExecutionStatisticsRecord, T> converter) {
			return InnerToArray(recordlist, converter);
		}
		public static implicit operator RLAthena_QueryExecutionStatisticsRecordList(RCAthena_QueryExecutionStatisticsRecord[] array) {
			RLAthena_QueryExecutionStatisticsRecordList result = new RLAthena_QueryExecutionStatisticsRecordList();
			result.InnerFromArray(array);
			return result;
		}

		public static RLAthena_QueryExecutionStatisticsRecordList ToList<T>(T[] array, Func <T, RCAthena_QueryExecutionStatisticsRecord> converter) {
			RLAthena_QueryExecutionStatisticsRecordList result = new RLAthena_QueryExecutionStatisticsRecordList();
			result.InnerFromArray(array, converter);
			return result;
		}

		public static RLAthena_QueryExecutionStatisticsRecordList FromRestList<T>(RestList<T> restList, Func <T, RCAthena_QueryExecutionStatisticsRecord> converter) {
			RLAthena_QueryExecutionStatisticsRecordList result = new RLAthena_QueryExecutionStatisticsRecordList();
			result.InnerFromRestList(restList, converter);
			return result;
		}
		/// <summary>
		/// Default Constructor
		/// </summary>
		public RLAthena_QueryExecutionStatisticsRecordList(): base() {
		}

		/// <summary>
		/// Constructor with transaction parameter
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_QueryExecutionStatisticsRecordList(IDbTransaction trans): base(trans) {
		}

		/// <summary>
		/// Constructor with transaction parameter and alternate read method
		/// </summary>
		/// <param name="trans"> IDbTransaction Parameter</param>
		/// <param name="alternateReadDBMethod"> Alternate Read Method</param>
		[Obsolete("Use the Default Constructor and set the Transaction afterwards.")]
		public RLAthena_QueryExecutionStatisticsRecordList(IDbTransaction trans, ReadDBMethodDelegate alternateReadDBMethod): this(trans) {
			this.alternateReadDBMethod = alternateReadDBMethod;
		}

		/// <summary>
		/// Constructor declaration for serialization
		/// </summary>
		/// <param name="info"> SerializationInfo</param>
		/// <param name="context"> StreamingContext</param>
		public RLAthena_QueryExecutionStatisticsRecordList(SerializationInfo info, StreamingContext context): base(info, context) {
		}

		public override BitArray[] GetDefaultOptimizedValues() {
			BitArray[] def = new BitArray[1];
			def[0] = null;
			return def;
		}
		/// <summary>
		/// Create as new list
		/// </summary>
		/// <returns>The new record list</returns>
		protected override OSList<RCAthena_QueryExecutionStatisticsRecord> NewList() {
			return new RLAthena_QueryExecutionStatisticsRecordList();
		}


	} // RLAthena_QueryExecutionStatisticsRecordList
}
