using System;
using System.Collections;
using System.Data;
using System.Runtime.Serialization;
using System.Reflection;
using System.Xml;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssGRAX_AthenaConnector {

	/// <summary>
	/// Structure <code>RCAthena_AuthenticationInfoRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAthena_AuthenticationInfoRecord: ISerializable, ITypedRecord<RCAthena_AuthenticationInfoRecord> {
		internal static readonly GlobalObjectKey IdAthena_AuthenticationInfo = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3583j6b6btThYVXkfxVCwQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Athena_AuthenticationInfo")]
		public STAthena_AuthenticationInfoStructure ssSTAthena_AuthenticationInfo;


		public static implicit operator STAthena_AuthenticationInfoStructure(RCAthena_AuthenticationInfoRecord r) {
			return r.ssSTAthena_AuthenticationInfo;
		}

		public static implicit operator RCAthena_AuthenticationInfoRecord(STAthena_AuthenticationInfoStructure r) {
			RCAthena_AuthenticationInfoRecord res = new RCAthena_AuthenticationInfoRecord(null);
			res.ssSTAthena_AuthenticationInfo = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAthena_AuthenticationInfoRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAthena_AuthenticationInfo = new STAthena_AuthenticationInfoStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAthena_AuthenticationInfo.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAthena_AuthenticationInfo.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAthena_AuthenticationInfoRecord r) {
			this = r;
		}


		public static bool operator == (RCAthena_AuthenticationInfoRecord a, RCAthena_AuthenticationInfoRecord b) {
			if (a.ssSTAthena_AuthenticationInfo != b.ssSTAthena_AuthenticationInfo) return false;
			return true;
		}

		public static bool operator != (RCAthena_AuthenticationInfoRecord a, RCAthena_AuthenticationInfoRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAthena_AuthenticationInfoRecord)) return false;
			return (this == (RCAthena_AuthenticationInfoRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAthena_AuthenticationInfo.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAthena_AuthenticationInfoRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAthena_AuthenticationInfo = new STAthena_AuthenticationInfoStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAthena_AuthenticationInfo", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAthena_AuthenticationInfo' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAthena_AuthenticationInfo = (STAthena_AuthenticationInfoStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAthena_AuthenticationInfo.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAthena_AuthenticationInfo.InternalRecursiveSave();
		}


		public RCAthena_AuthenticationInfoRecord Duplicate() {
			RCAthena_AuthenticationInfoRecord t;
			t.ssSTAthena_AuthenticationInfo = (STAthena_AuthenticationInfoStructure) this.ssSTAthena_AuthenticationInfo.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAthena_AuthenticationInfo.ToXml(this, recordElem, "Athena_AuthenticationInfo", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "athena_authenticationinfo") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Athena_AuthenticationInfo")) variable.Value = ssSTAthena_AuthenticationInfo; else variable.Optimized = true;
				variable.SetFieldName("athena_authenticationinfo");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAthena_AuthenticationInfo) {
				return ssSTAthena_AuthenticationInfo;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAthena_AuthenticationInfo.FillFromOther((IRecord) other.AttributeGet(IdAthena_AuthenticationInfo));
		}
		public bool IsDefault() {
			RCAthena_AuthenticationInfoRecord defaultStruct = new RCAthena_AuthenticationInfoRecord(null);
			if (this.ssSTAthena_AuthenticationInfo != defaultStruct.ssSTAthena_AuthenticationInfo) return false;
			return true;
		}
	} // RCAthena_AuthenticationInfoRecord

	/// <summary>
	/// Structure <code>RCAthena_NamedQueryRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAthena_NamedQueryRecord: ISerializable, ITypedRecord<RCAthena_NamedQueryRecord> {
		internal static readonly GlobalObjectKey IdAthena_NamedQuery = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_113VbdCHgLUwkT0B6jCTw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Athena_NamedQuery")]
		public STAthena_NamedQueryStructure ssSTAthena_NamedQuery;


		public static implicit operator STAthena_NamedQueryStructure(RCAthena_NamedQueryRecord r) {
			return r.ssSTAthena_NamedQuery;
		}

		public static implicit operator RCAthena_NamedQueryRecord(STAthena_NamedQueryStructure r) {
			RCAthena_NamedQueryRecord res = new RCAthena_NamedQueryRecord(null);
			res.ssSTAthena_NamedQuery = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAthena_NamedQueryRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAthena_NamedQuery = new STAthena_NamedQueryStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAthena_NamedQuery.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAthena_NamedQuery.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAthena_NamedQueryRecord r) {
			this = r;
		}


		public static bool operator == (RCAthena_NamedQueryRecord a, RCAthena_NamedQueryRecord b) {
			if (a.ssSTAthena_NamedQuery != b.ssSTAthena_NamedQuery) return false;
			return true;
		}

		public static bool operator != (RCAthena_NamedQueryRecord a, RCAthena_NamedQueryRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAthena_NamedQueryRecord)) return false;
			return (this == (RCAthena_NamedQueryRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAthena_NamedQuery.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAthena_NamedQueryRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAthena_NamedQuery = new STAthena_NamedQueryStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAthena_NamedQuery", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAthena_NamedQuery' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAthena_NamedQuery = (STAthena_NamedQueryStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAthena_NamedQuery.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAthena_NamedQuery.InternalRecursiveSave();
		}


		public RCAthena_NamedQueryRecord Duplicate() {
			RCAthena_NamedQueryRecord t;
			t.ssSTAthena_NamedQuery = (STAthena_NamedQueryStructure) this.ssSTAthena_NamedQuery.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAthena_NamedQuery.ToXml(this, recordElem, "Athena_NamedQuery", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "athena_namedquery") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Athena_NamedQuery")) variable.Value = ssSTAthena_NamedQuery; else variable.Optimized = true;
				variable.SetFieldName("athena_namedquery");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAthena_NamedQuery) {
				return ssSTAthena_NamedQuery;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAthena_NamedQuery.FillFromOther((IRecord) other.AttributeGet(IdAthena_NamedQuery));
		}
		public bool IsDefault() {
			RCAthena_NamedQueryRecord defaultStruct = new RCAthena_NamedQueryRecord(null);
			if (this.ssSTAthena_NamedQuery != defaultStruct.ssSTAthena_NamedQuery) return false;
			return true;
		}
	} // RCAthena_NamedQueryRecord

	/// <summary>
	/// Structure <code>RCAthena_QueryExecutionContextRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAthena_QueryExecutionContextRecord: ISerializable, ITypedRecord<RCAthena_QueryExecutionContextRecord> {
		internal static readonly GlobalObjectKey IdAthena_QueryExecutionContext = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Lu4eT1wt43jEp_9k3qVBTQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Athena_QueryExecutionContext")]
		public STAthena_QueryExecutionContextStructure ssSTAthena_QueryExecutionContext;


		public static implicit operator STAthena_QueryExecutionContextStructure(RCAthena_QueryExecutionContextRecord r) {
			return r.ssSTAthena_QueryExecutionContext;
		}

		public static implicit operator RCAthena_QueryExecutionContextRecord(STAthena_QueryExecutionContextStructure r) {
			RCAthena_QueryExecutionContextRecord res = new RCAthena_QueryExecutionContextRecord(null);
			res.ssSTAthena_QueryExecutionContext = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAthena_QueryExecutionContextRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAthena_QueryExecutionContext = new STAthena_QueryExecutionContextStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAthena_QueryExecutionContext.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAthena_QueryExecutionContext.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAthena_QueryExecutionContextRecord r) {
			this = r;
		}


		public static bool operator == (RCAthena_QueryExecutionContextRecord a, RCAthena_QueryExecutionContextRecord b) {
			if (a.ssSTAthena_QueryExecutionContext != b.ssSTAthena_QueryExecutionContext) return false;
			return true;
		}

		public static bool operator != (RCAthena_QueryExecutionContextRecord a, RCAthena_QueryExecutionContextRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAthena_QueryExecutionContextRecord)) return false;
			return (this == (RCAthena_QueryExecutionContextRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAthena_QueryExecutionContext.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAthena_QueryExecutionContextRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAthena_QueryExecutionContext = new STAthena_QueryExecutionContextStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAthena_QueryExecutionContext", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAthena_QueryExecutionContext' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAthena_QueryExecutionContext = (STAthena_QueryExecutionContextStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAthena_QueryExecutionContext.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAthena_QueryExecutionContext.InternalRecursiveSave();
		}


		public RCAthena_QueryExecutionContextRecord Duplicate() {
			RCAthena_QueryExecutionContextRecord t;
			t.ssSTAthena_QueryExecutionContext = (STAthena_QueryExecutionContextStructure) this.ssSTAthena_QueryExecutionContext.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAthena_QueryExecutionContext.ToXml(this, recordElem, "Athena_QueryExecutionContext", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "athena_queryexecutioncontext") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Athena_QueryExecutionContext")) variable.Value = ssSTAthena_QueryExecutionContext; else variable.Optimized = true;
				variable.SetFieldName("athena_queryexecutioncontext");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAthena_QueryExecutionContext) {
				return ssSTAthena_QueryExecutionContext;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAthena_QueryExecutionContext.FillFromOther((IRecord) other.AttributeGet(IdAthena_QueryExecutionContext));
		}
		public bool IsDefault() {
			RCAthena_QueryExecutionContextRecord defaultStruct = new RCAthena_QueryExecutionContextRecord(null);
			if (this.ssSTAthena_QueryExecutionContext != defaultStruct.ssSTAthena_QueryExecutionContext) return false;
			return true;
		}
	} // RCAthena_QueryExecutionContextRecord

	/// <summary>
	/// Structure <code>RCAthena_EncryptionConfigurationRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAthena_EncryptionConfigurationRecord: ISerializable, ITypedRecord<RCAthena_EncryptionConfigurationRecord> {
		internal static readonly GlobalObjectKey IdAthena_EncryptionConfiguration = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Jwq+KTx_jL6IOC5bnBBe+w");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Athena_EncryptionConfiguration")]
		public STAthena_EncryptionConfigurationStructure ssSTAthena_EncryptionConfiguration;


		public static implicit operator STAthena_EncryptionConfigurationStructure(RCAthena_EncryptionConfigurationRecord r) {
			return r.ssSTAthena_EncryptionConfiguration;
		}

		public static implicit operator RCAthena_EncryptionConfigurationRecord(STAthena_EncryptionConfigurationStructure r) {
			RCAthena_EncryptionConfigurationRecord res = new RCAthena_EncryptionConfigurationRecord(null);
			res.ssSTAthena_EncryptionConfiguration = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAthena_EncryptionConfigurationRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAthena_EncryptionConfiguration = new STAthena_EncryptionConfigurationStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAthena_EncryptionConfiguration.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAthena_EncryptionConfiguration.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAthena_EncryptionConfigurationRecord r) {
			this = r;
		}


		public static bool operator == (RCAthena_EncryptionConfigurationRecord a, RCAthena_EncryptionConfigurationRecord b) {
			if (a.ssSTAthena_EncryptionConfiguration != b.ssSTAthena_EncryptionConfiguration) return false;
			return true;
		}

		public static bool operator != (RCAthena_EncryptionConfigurationRecord a, RCAthena_EncryptionConfigurationRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAthena_EncryptionConfigurationRecord)) return false;
			return (this == (RCAthena_EncryptionConfigurationRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAthena_EncryptionConfiguration.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAthena_EncryptionConfigurationRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAthena_EncryptionConfiguration = new STAthena_EncryptionConfigurationStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAthena_EncryptionConfiguration", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAthena_EncryptionConfiguration' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAthena_EncryptionConfiguration = (STAthena_EncryptionConfigurationStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAthena_EncryptionConfiguration.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAthena_EncryptionConfiguration.InternalRecursiveSave();
		}


		public RCAthena_EncryptionConfigurationRecord Duplicate() {
			RCAthena_EncryptionConfigurationRecord t;
			t.ssSTAthena_EncryptionConfiguration = (STAthena_EncryptionConfigurationStructure) this.ssSTAthena_EncryptionConfiguration.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAthena_EncryptionConfiguration.ToXml(this, recordElem, "Athena_EncryptionConfiguration", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "athena_encryptionconfiguration") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Athena_EncryptionConfiguration")) variable.Value = ssSTAthena_EncryptionConfiguration; else variable.Optimized = true;
				variable.SetFieldName("athena_encryptionconfiguration");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAthena_EncryptionConfiguration) {
				return ssSTAthena_EncryptionConfiguration;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAthena_EncryptionConfiguration.FillFromOther((IRecord) other.AttributeGet(IdAthena_EncryptionConfiguration));
		}
		public bool IsDefault() {
			RCAthena_EncryptionConfigurationRecord defaultStruct = new RCAthena_EncryptionConfigurationRecord(null);
			if (this.ssSTAthena_EncryptionConfiguration != defaultStruct.ssSTAthena_EncryptionConfiguration) return false;
			return true;
		}
	} // RCAthena_EncryptionConfigurationRecord

	/// <summary>
	/// Structure <code>RCAthena_ResultConfigurationRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAthena_ResultConfigurationRecord: ISerializable, ITypedRecord<RCAthena_ResultConfigurationRecord> {
		internal static readonly GlobalObjectKey IdAthena_ResultConfiguration = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*YWNfjS_r9TXrEEu3dMXpNw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Athena_ResultConfiguration")]
		public STAthena_ResultConfigurationStructure ssSTAthena_ResultConfiguration;


		public static implicit operator STAthena_ResultConfigurationStructure(RCAthena_ResultConfigurationRecord r) {
			return r.ssSTAthena_ResultConfiguration;
		}

		public static implicit operator RCAthena_ResultConfigurationRecord(STAthena_ResultConfigurationStructure r) {
			RCAthena_ResultConfigurationRecord res = new RCAthena_ResultConfigurationRecord(null);
			res.ssSTAthena_ResultConfiguration = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAthena_ResultConfigurationRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAthena_ResultConfiguration = new STAthena_ResultConfigurationStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAthena_ResultConfiguration.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAthena_ResultConfiguration.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAthena_ResultConfigurationRecord r) {
			this = r;
		}


		public static bool operator == (RCAthena_ResultConfigurationRecord a, RCAthena_ResultConfigurationRecord b) {
			if (a.ssSTAthena_ResultConfiguration != b.ssSTAthena_ResultConfiguration) return false;
			return true;
		}

		public static bool operator != (RCAthena_ResultConfigurationRecord a, RCAthena_ResultConfigurationRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAthena_ResultConfigurationRecord)) return false;
			return (this == (RCAthena_ResultConfigurationRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAthena_ResultConfiguration.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAthena_ResultConfigurationRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAthena_ResultConfiguration = new STAthena_ResultConfigurationStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAthena_ResultConfiguration", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAthena_ResultConfiguration' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAthena_ResultConfiguration = (STAthena_ResultConfigurationStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAthena_ResultConfiguration.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAthena_ResultConfiguration.InternalRecursiveSave();
		}


		public RCAthena_ResultConfigurationRecord Duplicate() {
			RCAthena_ResultConfigurationRecord t;
			t.ssSTAthena_ResultConfiguration = (STAthena_ResultConfigurationStructure) this.ssSTAthena_ResultConfiguration.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAthena_ResultConfiguration.ToXml(this, recordElem, "Athena_ResultConfiguration", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "athena_resultconfiguration") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Athena_ResultConfiguration")) variable.Value = ssSTAthena_ResultConfiguration; else variable.Optimized = true;
				variable.SetFieldName("athena_resultconfiguration");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAthena_ResultConfiguration) {
				return ssSTAthena_ResultConfiguration;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAthena_ResultConfiguration.FillFromOther((IRecord) other.AttributeGet(IdAthena_ResultConfiguration));
		}
		public bool IsDefault() {
			RCAthena_ResultConfigurationRecord defaultStruct = new RCAthena_ResultConfigurationRecord(null);
			if (this.ssSTAthena_ResultConfiguration != defaultStruct.ssSTAthena_ResultConfiguration) return false;
			return true;
		}
	} // RCAthena_ResultConfigurationRecord

	/// <summary>
	/// Structure <code>RCTextRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCTextRecord: ISerializable, ITypedRecord<RCTextRecord> {
		internal static readonly GlobalObjectKey IdText = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+hjVpSjVt3s+VgjZPMJL2g");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Text")]
		public STTextStructure ssSTText;


		public static implicit operator STTextStructure(RCTextRecord r) {
			return r.ssSTText;
		}

		public static implicit operator RCTextRecord(STTextStructure r) {
			RCTextRecord res = new RCTextRecord(null);
			res.ssSTText = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCTextRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTText = new STTextStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTText.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTText.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCTextRecord r) {
			this = r;
		}


		public static bool operator == (RCTextRecord a, RCTextRecord b) {
			if (a.ssSTText != b.ssSTText) return false;
			return true;
		}

		public static bool operator != (RCTextRecord a, RCTextRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCTextRecord)) return false;
			return (this == (RCTextRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTText.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCTextRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTText = new STTextStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTText", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTText' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTText = (STTextStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTText.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTText.InternalRecursiveSave();
		}


		public RCTextRecord Duplicate() {
			RCTextRecord t;
			t.ssSTText = (STTextStructure) this.ssSTText.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTText.ToXml(this, recordElem, "Text", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "text") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Text")) variable.Value = ssSTText; else variable.Optimized = true;
				variable.SetFieldName("text");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdText) {
				return ssSTText;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTText.FillFromOther((IRecord) other.AttributeGet(IdText));
		}
		public bool IsDefault() {
			RCTextRecord defaultStruct = new RCTextRecord(null);
			if (this.ssSTText != defaultStruct.ssSTText) return false;
			return true;
		}
	} // RCTextRecord

	/// <summary>
	/// Structure <code>RCAthena_EngineVersionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAthena_EngineVersionRecord: ISerializable, ITypedRecord<RCAthena_EngineVersionRecord> {
		internal static readonly GlobalObjectKey IdAthena_EngineVersion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3eDmcTe_AwP9c+nxHqQ_Yg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Athena_EngineVersion")]
		public STAthena_EngineVersionStructure ssSTAthena_EngineVersion;


		public static implicit operator STAthena_EngineVersionStructure(RCAthena_EngineVersionRecord r) {
			return r.ssSTAthena_EngineVersion;
		}

		public static implicit operator RCAthena_EngineVersionRecord(STAthena_EngineVersionStructure r) {
			RCAthena_EngineVersionRecord res = new RCAthena_EngineVersionRecord(null);
			res.ssSTAthena_EngineVersion = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAthena_EngineVersionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAthena_EngineVersion = new STAthena_EngineVersionStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAthena_EngineVersion.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAthena_EngineVersion.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAthena_EngineVersionRecord r) {
			this = r;
		}


		public static bool operator == (RCAthena_EngineVersionRecord a, RCAthena_EngineVersionRecord b) {
			if (a.ssSTAthena_EngineVersion != b.ssSTAthena_EngineVersion) return false;
			return true;
		}

		public static bool operator != (RCAthena_EngineVersionRecord a, RCAthena_EngineVersionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAthena_EngineVersionRecord)) return false;
			return (this == (RCAthena_EngineVersionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAthena_EngineVersion.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAthena_EngineVersionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAthena_EngineVersion = new STAthena_EngineVersionStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAthena_EngineVersion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAthena_EngineVersion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAthena_EngineVersion = (STAthena_EngineVersionStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAthena_EngineVersion.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAthena_EngineVersion.InternalRecursiveSave();
		}


		public RCAthena_EngineVersionRecord Duplicate() {
			RCAthena_EngineVersionRecord t;
			t.ssSTAthena_EngineVersion = (STAthena_EngineVersionStructure) this.ssSTAthena_EngineVersion.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAthena_EngineVersion.ToXml(this, recordElem, "Athena_EngineVersion", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "athena_engineversion") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Athena_EngineVersion")) variable.Value = ssSTAthena_EngineVersion; else variable.Optimized = true;
				variable.SetFieldName("athena_engineversion");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAthena_EngineVersion) {
				return ssSTAthena_EngineVersion;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAthena_EngineVersion.FillFromOther((IRecord) other.AttributeGet(IdAthena_EngineVersion));
		}
		public bool IsDefault() {
			RCAthena_EngineVersionRecord defaultStruct = new RCAthena_EngineVersionRecord(null);
			if (this.ssSTAthena_EngineVersion != defaultStruct.ssSTAthena_EngineVersion) return false;
			return true;
		}
	} // RCAthena_EngineVersionRecord

	/// <summary>
	/// Structure <code>RCAthena_QueryExecutionRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAthena_QueryExecutionRecord: ISerializable, ITypedRecord<RCAthena_QueryExecutionRecord> {
		internal static readonly GlobalObjectKey IdAthena_QueryExecution = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*7sAebcqqXLFR0KsJ+7qXiA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Athena_QueryExecution")]
		public STAthena_QueryExecutionStructure ssSTAthena_QueryExecution;


		public static implicit operator STAthena_QueryExecutionStructure(RCAthena_QueryExecutionRecord r) {
			return r.ssSTAthena_QueryExecution;
		}

		public static implicit operator RCAthena_QueryExecutionRecord(STAthena_QueryExecutionStructure r) {
			RCAthena_QueryExecutionRecord res = new RCAthena_QueryExecutionRecord(null);
			res.ssSTAthena_QueryExecution = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAthena_QueryExecutionRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAthena_QueryExecution = new STAthena_QueryExecutionStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAthena_QueryExecution.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAthena_QueryExecution.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAthena_QueryExecutionRecord r) {
			this = r;
		}


		public static bool operator == (RCAthena_QueryExecutionRecord a, RCAthena_QueryExecutionRecord b) {
			if (a.ssSTAthena_QueryExecution != b.ssSTAthena_QueryExecution) return false;
			return true;
		}

		public static bool operator != (RCAthena_QueryExecutionRecord a, RCAthena_QueryExecutionRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAthena_QueryExecutionRecord)) return false;
			return (this == (RCAthena_QueryExecutionRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAthena_QueryExecution.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAthena_QueryExecutionRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAthena_QueryExecution = new STAthena_QueryExecutionStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAthena_QueryExecution", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAthena_QueryExecution' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAthena_QueryExecution = (STAthena_QueryExecutionStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAthena_QueryExecution.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAthena_QueryExecution.InternalRecursiveSave();
		}


		public RCAthena_QueryExecutionRecord Duplicate() {
			RCAthena_QueryExecutionRecord t;
			t.ssSTAthena_QueryExecution = (STAthena_QueryExecutionStructure) this.ssSTAthena_QueryExecution.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAthena_QueryExecution.ToXml(this, recordElem, "Athena_QueryExecution", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "athena_queryexecution") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Athena_QueryExecution")) variable.Value = ssSTAthena_QueryExecution; else variable.Optimized = true;
				variable.SetFieldName("athena_queryexecution");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAthena_QueryExecution) {
				return ssSTAthena_QueryExecution;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAthena_QueryExecution.FillFromOther((IRecord) other.AttributeGet(IdAthena_QueryExecution));
		}
		public bool IsDefault() {
			RCAthena_QueryExecutionRecord defaultStruct = new RCAthena_QueryExecutionRecord(null);
			if (this.ssSTAthena_QueryExecution != defaultStruct.ssSTAthena_QueryExecution) return false;
			return true;
		}
	} // RCAthena_QueryExecutionRecord

	/// <summary>
	/// Structure <code>RCAthena_QueryExecutionStatusRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAthena_QueryExecutionStatusRecord: ISerializable, ITypedRecord<RCAthena_QueryExecutionStatusRecord> {
		internal static readonly GlobalObjectKey IdAthena_QueryExecutionStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*0UsLQGxcYgJtJ08RNznkxA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Athena_QueryExecutionStatus")]
		public STAthena_QueryExecutionStatusStructure ssSTAthena_QueryExecutionStatus;


		public static implicit operator STAthena_QueryExecutionStatusStructure(RCAthena_QueryExecutionStatusRecord r) {
			return r.ssSTAthena_QueryExecutionStatus;
		}

		public static implicit operator RCAthena_QueryExecutionStatusRecord(STAthena_QueryExecutionStatusStructure r) {
			RCAthena_QueryExecutionStatusRecord res = new RCAthena_QueryExecutionStatusRecord(null);
			res.ssSTAthena_QueryExecutionStatus = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAthena_QueryExecutionStatusRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAthena_QueryExecutionStatus = new STAthena_QueryExecutionStatusStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAthena_QueryExecutionStatus.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAthena_QueryExecutionStatus.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAthena_QueryExecutionStatusRecord r) {
			this = r;
		}


		public static bool operator == (RCAthena_QueryExecutionStatusRecord a, RCAthena_QueryExecutionStatusRecord b) {
			if (a.ssSTAthena_QueryExecutionStatus != b.ssSTAthena_QueryExecutionStatus) return false;
			return true;
		}

		public static bool operator != (RCAthena_QueryExecutionStatusRecord a, RCAthena_QueryExecutionStatusRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAthena_QueryExecutionStatusRecord)) return false;
			return (this == (RCAthena_QueryExecutionStatusRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAthena_QueryExecutionStatus.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAthena_QueryExecutionStatusRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAthena_QueryExecutionStatus = new STAthena_QueryExecutionStatusStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAthena_QueryExecutionStatus", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAthena_QueryExecutionStatus' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAthena_QueryExecutionStatus = (STAthena_QueryExecutionStatusStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAthena_QueryExecutionStatus.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAthena_QueryExecutionStatus.InternalRecursiveSave();
		}


		public RCAthena_QueryExecutionStatusRecord Duplicate() {
			RCAthena_QueryExecutionStatusRecord t;
			t.ssSTAthena_QueryExecutionStatus = (STAthena_QueryExecutionStatusStructure) this.ssSTAthena_QueryExecutionStatus.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAthena_QueryExecutionStatus.ToXml(this, recordElem, "Athena_QueryExecutionStatus", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "athena_queryexecutionstatus") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Athena_QueryExecutionStatus")) variable.Value = ssSTAthena_QueryExecutionStatus; else variable.Optimized = true;
				variable.SetFieldName("athena_queryexecutionstatus");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAthena_QueryExecutionStatus) {
				return ssSTAthena_QueryExecutionStatus;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAthena_QueryExecutionStatus.FillFromOther((IRecord) other.AttributeGet(IdAthena_QueryExecutionStatus));
		}
		public bool IsDefault() {
			RCAthena_QueryExecutionStatusRecord defaultStruct = new RCAthena_QueryExecutionStatusRecord(null);
			if (this.ssSTAthena_QueryExecutionStatus != defaultStruct.ssSTAthena_QueryExecutionStatus) return false;
			return true;
		}
	} // RCAthena_QueryExecutionStatusRecord

	/// <summary>
	/// Structure <code>RCAthena_QueryExecutionStatisticsRecord</code>
	/// </summary>
	[Serializable()]
	public partial struct RCAthena_QueryExecutionStatisticsRecord: ISerializable, ITypedRecord<RCAthena_QueryExecutionStatisticsRecord> {
		internal static readonly GlobalObjectKey IdAthena_QueryExecutionStatistics = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*655dXTiTwdcYb68id_tlng");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Athena_QueryExecutionStatistics")]
		public STAthena_QueryExecutionStatisticsStructure ssSTAthena_QueryExecutionStatistics;


		public static implicit operator STAthena_QueryExecutionStatisticsStructure(RCAthena_QueryExecutionStatisticsRecord r) {
			return r.ssSTAthena_QueryExecutionStatistics;
		}

		public static implicit operator RCAthena_QueryExecutionStatisticsRecord(STAthena_QueryExecutionStatisticsStructure r) {
			RCAthena_QueryExecutionStatisticsRecord res = new RCAthena_QueryExecutionStatisticsRecord(null);
			res.ssSTAthena_QueryExecutionStatistics = r;
			return res;
		}

		public BitArray OptimizedAttributes;

		public RCAthena_QueryExecutionStatisticsRecord(params string[] dummy) {
			OptimizedAttributes = null;
			ssSTAthena_QueryExecutionStatistics = new STAthena_QueryExecutionStatisticsStructure(null);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[1];
			all[0] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssSTAthena_QueryExecutionStatistics.OptimizedAttributes = value[0];
				}
			}
			get {
				BitArray[] all = new BitArray[1];
				all[0] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssSTAthena_QueryExecutionStatistics.Read(r, ref index);
		}
		/// <summary>
		/// Read from database
		/// </summary>
		/// <param name="r"> Data reader</param>
		public void ReadDB(IDataReader r) {
			int index = 0;
			Read(r, ref index);
		}

		/// <summary>
		/// Read from record
		/// </summary>
		/// <param name="r"> Record</param>
		public void ReadIM(RCAthena_QueryExecutionStatisticsRecord r) {
			this = r;
		}


		public static bool operator == (RCAthena_QueryExecutionStatisticsRecord a, RCAthena_QueryExecutionStatisticsRecord b) {
			if (a.ssSTAthena_QueryExecutionStatistics != b.ssSTAthena_QueryExecutionStatistics) return false;
			return true;
		}

		public static bool operator != (RCAthena_QueryExecutionStatisticsRecord a, RCAthena_QueryExecutionStatisticsRecord b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(RCAthena_QueryExecutionStatisticsRecord)) return false;
			return (this == (RCAthena_QueryExecutionStatisticsRecord) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssSTAthena_QueryExecutionStatistics.GetHashCode()
				;
			} catch {
				return base.GetHashCode();
			}
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context) {
			Type objInfo = this.GetType();
			FieldInfo[] fields;
			fields = objInfo.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			for (int i = 0; i < fields.Length; i++)
			if (fields[i] .FieldType.IsSerializable)
			info.AddValue(fields[i] .Name, fields[i] .GetValue(this));
		}

		public RCAthena_QueryExecutionStatisticsRecord(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssSTAthena_QueryExecutionStatistics = new STAthena_QueryExecutionStatisticsStructure(null);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssSTAthena_QueryExecutionStatistics", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSTAthena_QueryExecutionStatistics' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSTAthena_QueryExecutionStatistics = (STAthena_QueryExecutionStatisticsStructure) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssSTAthena_QueryExecutionStatistics.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssSTAthena_QueryExecutionStatistics.InternalRecursiveSave();
		}


		public RCAthena_QueryExecutionStatisticsRecord Duplicate() {
			RCAthena_QueryExecutionStatisticsRecord t;
			t.ssSTAthena_QueryExecutionStatistics = (STAthena_QueryExecutionStatisticsStructure) this.ssSTAthena_QueryExecutionStatistics.Duplicate();
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Record");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
			}
			if (detailLevel > 0) {
				ssSTAthena_QueryExecutionStatistics.ToXml(this, recordElem, "Athena_QueryExecutionStatistics", detailLevel - 1);
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "athena_queryexecutionstatistics") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Athena_QueryExecutionStatistics")) variable.Value = ssSTAthena_QueryExecutionStatistics; else variable.Optimized = true;
				variable.SetFieldName("athena_queryexecutionstatistics");
			}
			if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
		}

		public bool ChangedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public bool OptimizedAttributeGet(GlobalObjectKey key) {
			throw new Exception("Method not Supported");
		}

		public object AttributeGet(GlobalObjectKey key) {
			if (key == IdAthena_QueryExecutionStatistics) {
				return ssSTAthena_QueryExecutionStatistics;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssSTAthena_QueryExecutionStatistics.FillFromOther((IRecord) other.AttributeGet(IdAthena_QueryExecutionStatistics));
		}
		public bool IsDefault() {
			RCAthena_QueryExecutionStatisticsRecord defaultStruct = new RCAthena_QueryExecutionStatisticsRecord(null);
			if (this.ssSTAthena_QueryExecutionStatistics != defaultStruct.ssSTAthena_QueryExecutionStatistics) return false;
			return true;
		}
	} // RCAthena_QueryExecutionStatisticsRecord
}
