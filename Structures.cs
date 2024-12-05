using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization;
using OutSystems.ObjectKeys;
using OutSystems.RuntimeCommon;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.HubEdition.RuntimePlatform.Db;
using OutSystems.Internal.Db;

namespace OutSystems.NssGRAX_AthenaConnector {

	/// <summary>
	/// Structure <code>STAthena_AuthenticationInfoStructure</code> that represents the Service Studio
	///  structure <code>Athena_AuthenticationInfo</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAthena_AuthenticationInfoStructure: ISerializable, ITypedRecord<STAthena_AuthenticationInfoStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdAwsRegion = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*S7CrUrE2A0udgJZMy2iaHw");
		internal static readonly GlobalObjectKey IdAwsAccessKeyId = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*Pyls3MdsJUijG0imjD7v8Q");
		internal static readonly GlobalObjectKey IdAwsSecretAccessKey = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*NdFr_upXdES0cr58OEJYvw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("AwsRegion")]
		public string ssAwsRegion;

		[System.Xml.Serialization.XmlElement("AwsAccessKeyId")]
		public string ssAwsAccessKeyId;

		[System.Xml.Serialization.XmlElement("AwsSecretAccessKey")]
		public string ssAwsSecretAccessKey;


		public BitArray OptimizedAttributes;

		public STAthena_AuthenticationInfoStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssAwsRegion = "";
			ssAwsAccessKeyId = "";
			ssAwsSecretAccessKey = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssAwsRegion = r.ReadText(index++, "Athena_AuthenticationInfo.AwsRegion", "");
			ssAwsAccessKeyId = r.ReadText(index++, "Athena_AuthenticationInfo.AwsAccessKeyId", "");
			ssAwsSecretAccessKey = r.ReadText(index++, "Athena_AuthenticationInfo.AwsSecretAccessKey", "");
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
		public void ReadIM(STAthena_AuthenticationInfoStructure r) {
			this = r;
		}


		public static bool operator == (STAthena_AuthenticationInfoStructure a, STAthena_AuthenticationInfoStructure b) {
			if (a.ssAwsRegion != b.ssAwsRegion) return false;
			if (a.ssAwsAccessKeyId != b.ssAwsAccessKeyId) return false;
			if (a.ssAwsSecretAccessKey != b.ssAwsSecretAccessKey) return false;
			return true;
		}

		public static bool operator != (STAthena_AuthenticationInfoStructure a, STAthena_AuthenticationInfoStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAthena_AuthenticationInfoStructure)) return false;
			return (this == (STAthena_AuthenticationInfoStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssAwsRegion.GetHashCode()
				^ ssAwsAccessKeyId.GetHashCode()
				^ ssAwsSecretAccessKey.GetHashCode()
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

		public STAthena_AuthenticationInfoStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssAwsRegion = "";
			ssAwsAccessKeyId = "";
			ssAwsSecretAccessKey = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssAwsRegion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAwsRegion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAwsRegion = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssAwsAccessKeyId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAwsAccessKeyId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAwsAccessKeyId = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssAwsSecretAccessKey", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssAwsSecretAccessKey' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssAwsSecretAccessKey = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STAthena_AuthenticationInfoStructure Duplicate() {
			STAthena_AuthenticationInfoStructure t;
			t.ssAwsRegion = this.ssAwsRegion;
			t.ssAwsAccessKeyId = this.ssAwsAccessKeyId;
			t.ssAwsSecretAccessKey = this.ssAwsSecretAccessKey;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AwsRegion")) VarValue.AppendAttribute(recordElem, "AwsRegion", ssAwsRegion, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "AwsRegion");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AwsAccessKeyId")) VarValue.AppendAttribute(recordElem, "AwsAccessKeyId", ssAwsAccessKeyId, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "AwsAccessKeyId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".AwsSecretAccessKey")) VarValue.AppendAttribute(recordElem, "AwsSecretAccessKey", ssAwsSecretAccessKey, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "AwsSecretAccessKey");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "awsregion") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AwsRegion")) variable.Value = ssAwsRegion; else variable.Optimized = true;
			} else if (head == "awsaccesskeyid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AwsAccessKeyId")) variable.Value = ssAwsAccessKeyId; else variable.Optimized = true;
			} else if (head == "awssecretaccesskey") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".AwsSecretAccessKey")) variable.Value = ssAwsSecretAccessKey; else variable.Optimized = true;
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
			if (key == IdAwsRegion) {
				return ssAwsRegion;
			} else if (key == IdAwsAccessKeyId) {
				return ssAwsAccessKeyId;
			} else if (key == IdAwsSecretAccessKey) {
				return ssAwsSecretAccessKey;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssAwsRegion = (string) other.AttributeGet(IdAwsRegion);
			ssAwsAccessKeyId = (string) other.AttributeGet(IdAwsAccessKeyId);
			ssAwsSecretAccessKey = (string) other.AttributeGet(IdAwsSecretAccessKey);
		}
		public bool IsDefault() {
			STAthena_AuthenticationInfoStructure defaultStruct = new STAthena_AuthenticationInfoStructure(null);
			if (this.ssAwsRegion != defaultStruct.ssAwsRegion) return false;
			if (this.ssAwsAccessKeyId != defaultStruct.ssAwsAccessKeyId) return false;
			if (this.ssAwsSecretAccessKey != defaultStruct.ssAwsSecretAccessKey) return false;
			return true;
		}
	} // STAthena_AuthenticationInfoStructure

	/// <summary>
	/// Structure <code>STAthena_NamedQueryStructure</code> that represents the Service Studio structure
	///  <code>Athena_NamedQuery</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAthena_NamedQueryStructure: ISerializable, ITypedRecord<STAthena_NamedQueryStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdDatabase = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*a67O6C0eS0K7By1lodSXug");
		internal static readonly GlobalObjectKey IdDescription = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*A9IC3uKtmkSEsqr9WOjboA");
		internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*z7T_5oQcRE+uwGwwWfVvjQ");
		internal static readonly GlobalObjectKey IdNamedQueryId = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*NbiISCudckecgwdgmPOS1Q");
		internal static readonly GlobalObjectKey IdQueryString = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*XpdqmWdZEUeMyx+x2MGSVg");
		internal static readonly GlobalObjectKey IdWorkGroup = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*2giCUn3elku2__4XnIylYw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Database")]
		public string ssDatabase;

		[System.Xml.Serialization.XmlElement("Description")]
		public string ssDescription;

		[System.Xml.Serialization.XmlElement("Name")]
		public string ssName;

		[System.Xml.Serialization.XmlElement("NamedQueryId")]
		public string ssNamedQueryId;

		[System.Xml.Serialization.XmlElement("QueryString")]
		public string ssQueryString;

		[System.Xml.Serialization.XmlElement("WorkGroup")]
		public string ssWorkGroup;


		public BitArray OptimizedAttributes;

		public STAthena_NamedQueryStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssDatabase = "";
			ssDescription = "";
			ssName = "";
			ssNamedQueryId = "";
			ssQueryString = "";
			ssWorkGroup = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssDatabase = r.ReadText(index++, "Athena_NamedQuery.Database", "");
			ssDescription = r.ReadText(index++, "Athena_NamedQuery.Description", "");
			ssName = r.ReadText(index++, "Athena_NamedQuery.Name", "");
			ssNamedQueryId = r.ReadText(index++, "Athena_NamedQuery.NamedQueryId", "");
			ssQueryString = r.ReadText(index++, "Athena_NamedQuery.QueryString", "");
			ssWorkGroup = r.ReadText(index++, "Athena_NamedQuery.WorkGroup", "");
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
		public void ReadIM(STAthena_NamedQueryStructure r) {
			this = r;
		}


		public static bool operator == (STAthena_NamedQueryStructure a, STAthena_NamedQueryStructure b) {
			if (a.ssDatabase != b.ssDatabase) return false;
			if (a.ssDescription != b.ssDescription) return false;
			if (a.ssName != b.ssName) return false;
			if (a.ssNamedQueryId != b.ssNamedQueryId) return false;
			if (a.ssQueryString != b.ssQueryString) return false;
			if (a.ssWorkGroup != b.ssWorkGroup) return false;
			return true;
		}

		public static bool operator != (STAthena_NamedQueryStructure a, STAthena_NamedQueryStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAthena_NamedQueryStructure)) return false;
			return (this == (STAthena_NamedQueryStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssDatabase.GetHashCode()
				^ ssDescription.GetHashCode()
				^ ssName.GetHashCode()
				^ ssNamedQueryId.GetHashCode()
				^ ssQueryString.GetHashCode()
				^ ssWorkGroup.GetHashCode()
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

		public STAthena_NamedQueryStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssDatabase = "";
			ssDescription = "";
			ssName = "";
			ssNamedQueryId = "";
			ssQueryString = "";
			ssWorkGroup = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssDatabase", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssDatabase' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssDatabase = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssDescription", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssDescription' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssDescription = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssName", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssName' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssName = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssNamedQueryId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssNamedQueryId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssNamedQueryId = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssQueryString", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssQueryString' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssQueryString = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssWorkGroup", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssWorkGroup' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssWorkGroup = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STAthena_NamedQueryStructure Duplicate() {
			STAthena_NamedQueryStructure t;
			t.ssDatabase = this.ssDatabase;
			t.ssDescription = this.ssDescription;
			t.ssName = this.ssName;
			t.ssNamedQueryId = this.ssNamedQueryId;
			t.ssQueryString = this.ssQueryString;
			t.ssWorkGroup = this.ssWorkGroup;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Database")) VarValue.AppendAttribute(recordElem, "Database", ssDatabase, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Database");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Description")) VarValue.AppendAttribute(recordElem, "Description", ssDescription, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Description");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Name")) VarValue.AppendAttribute(recordElem, "Name", ssName, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Name");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".NamedQueryId")) VarValue.AppendAttribute(recordElem, "NamedQueryId", ssNamedQueryId, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "NamedQueryId");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".QueryString")) VarValue.AppendAttribute(recordElem, "QueryString", ssQueryString, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "QueryString");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".WorkGroup")) VarValue.AppendAttribute(recordElem, "WorkGroup", ssWorkGroup, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "WorkGroup");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "database") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Database")) variable.Value = ssDatabase; else variable.Optimized = true;
			} else if (head == "description") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Description")) variable.Value = ssDescription; else variable.Optimized = true;
			} else if (head == "name") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
			} else if (head == "namedqueryid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".NamedQueryId")) variable.Value = ssNamedQueryId; else variable.Optimized = true;
			} else if (head == "querystring") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".QueryString")) variable.Value = ssQueryString; else variable.Optimized = true;
			} else if (head == "workgroup") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".WorkGroup")) variable.Value = ssWorkGroup; else variable.Optimized = true;
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
			if (key == IdDatabase) {
				return ssDatabase;
			} else if (key == IdDescription) {
				return ssDescription;
			} else if (key == IdName) {
				return ssName;
			} else if (key == IdNamedQueryId) {
				return ssNamedQueryId;
			} else if (key == IdQueryString) {
				return ssQueryString;
			} else if (key == IdWorkGroup) {
				return ssWorkGroup;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssDatabase = (string) other.AttributeGet(IdDatabase);
			ssDescription = (string) other.AttributeGet(IdDescription);
			ssName = (string) other.AttributeGet(IdName);
			ssNamedQueryId = (string) other.AttributeGet(IdNamedQueryId);
			ssQueryString = (string) other.AttributeGet(IdQueryString);
			ssWorkGroup = (string) other.AttributeGet(IdWorkGroup);
		}
		public bool IsDefault() {
			STAthena_NamedQueryStructure defaultStruct = new STAthena_NamedQueryStructure(null);
			if (this.ssDatabase != defaultStruct.ssDatabase) return false;
			if (this.ssDescription != defaultStruct.ssDescription) return false;
			if (this.ssName != defaultStruct.ssName) return false;
			if (this.ssNamedQueryId != defaultStruct.ssNamedQueryId) return false;
			if (this.ssQueryString != defaultStruct.ssQueryString) return false;
			if (this.ssWorkGroup != defaultStruct.ssWorkGroup) return false;
			return true;
		}
	} // STAthena_NamedQueryStructure

	/// <summary>
	/// Structure <code>STAthena_QueryExecutionContextStructure</code> that represents the Service Studio
	///  structure <code>Athena_QueryExecutionContext</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAthena_QueryExecutionContextStructure: ISerializable, ITypedRecord<STAthena_QueryExecutionContextStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdCatalog = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*vSoaBPTvS0+hU5FhzENaPA");
		internal static readonly GlobalObjectKey IdDatabase = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*DIwUSPMa7EGpTJJqGGm_Qg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Catalog")]
		public string ssCatalog;

		[System.Xml.Serialization.XmlElement("Database")]
		public string ssDatabase;


		public BitArray OptimizedAttributes;

		public STAthena_QueryExecutionContextStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssCatalog = "";
			ssDatabase = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssCatalog = r.ReadText(index++, "Athena_QueryExecutionContext.Catalog", "");
			ssDatabase = r.ReadText(index++, "Athena_QueryExecutionContext.Database", "");
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
		public void ReadIM(STAthena_QueryExecutionContextStructure r) {
			this = r;
		}


		public static bool operator == (STAthena_QueryExecutionContextStructure a, STAthena_QueryExecutionContextStructure b) {
			if (a.ssCatalog != b.ssCatalog) return false;
			if (a.ssDatabase != b.ssDatabase) return false;
			return true;
		}

		public static bool operator != (STAthena_QueryExecutionContextStructure a, STAthena_QueryExecutionContextStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAthena_QueryExecutionContextStructure)) return false;
			return (this == (STAthena_QueryExecutionContextStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssCatalog.GetHashCode()
				^ ssDatabase.GetHashCode()
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

		public STAthena_QueryExecutionContextStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssCatalog = "";
			ssDatabase = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssCatalog", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssCatalog' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssCatalog = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssDatabase", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssDatabase' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssDatabase = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STAthena_QueryExecutionContextStructure Duplicate() {
			STAthena_QueryExecutionContextStructure t;
			t.ssCatalog = this.ssCatalog;
			t.ssDatabase = this.ssDatabase;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Catalog")) VarValue.AppendAttribute(recordElem, "Catalog", ssCatalog, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Catalog");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Database")) VarValue.AppendAttribute(recordElem, "Database", ssDatabase, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Database");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "catalog") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Catalog")) variable.Value = ssCatalog; else variable.Optimized = true;
			} else if (head == "database") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Database")) variable.Value = ssDatabase; else variable.Optimized = true;
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
			if (key == IdCatalog) {
				return ssCatalog;
			} else if (key == IdDatabase) {
				return ssDatabase;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssCatalog = (string) other.AttributeGet(IdCatalog);
			ssDatabase = (string) other.AttributeGet(IdDatabase);
		}
		public bool IsDefault() {
			STAthena_QueryExecutionContextStructure defaultStruct = new STAthena_QueryExecutionContextStructure(null);
			if (this.ssCatalog != defaultStruct.ssCatalog) return false;
			if (this.ssDatabase != defaultStruct.ssDatabase) return false;
			return true;
		}
	} // STAthena_QueryExecutionContextStructure

	/// <summary>
	/// Structure <code>STAthena_EncryptionConfigurationStructure</code> that represents the Service Studio
	///  structure <code>Athena_EncryptionConfiguration</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAthena_EncryptionConfigurationStructure: ISerializable, ITypedRecord<STAthena_EncryptionConfigurationStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdEncryptionOption = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*ta9goyXHwUCWmNai2iAw7g");
		internal static readonly GlobalObjectKey IdKmsKey = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*oEPiSbmLHUWSkjKd3dZUvw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EncryptionOption")]
		public string ssEncryptionOption;

		[System.Xml.Serialization.XmlElement("KmsKey")]
		public string ssKmsKey;


		public BitArray OptimizedAttributes;

		public STAthena_EncryptionConfigurationStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssEncryptionOption = "";
			ssKmsKey = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssEncryptionOption = r.ReadText(index++, "Athena_EncryptionConfiguration.EncryptionOption", "");
			ssKmsKey = r.ReadText(index++, "Athena_EncryptionConfiguration.KmsKey", "");
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
		public void ReadIM(STAthena_EncryptionConfigurationStructure r) {
			this = r;
		}


		public static bool operator == (STAthena_EncryptionConfigurationStructure a, STAthena_EncryptionConfigurationStructure b) {
			if (a.ssEncryptionOption != b.ssEncryptionOption) return false;
			if (a.ssKmsKey != b.ssKmsKey) return false;
			return true;
		}

		public static bool operator != (STAthena_EncryptionConfigurationStructure a, STAthena_EncryptionConfigurationStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAthena_EncryptionConfigurationStructure)) return false;
			return (this == (STAthena_EncryptionConfigurationStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssEncryptionOption.GetHashCode()
				^ ssKmsKey.GetHashCode()
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

		public STAthena_EncryptionConfigurationStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssEncryptionOption = "";
			ssKmsKey = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssEncryptionOption", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssEncryptionOption' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssEncryptionOption = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssKmsKey", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssKmsKey' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssKmsKey = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STAthena_EncryptionConfigurationStructure Duplicate() {
			STAthena_EncryptionConfigurationStructure t;
			t.ssEncryptionOption = this.ssEncryptionOption;
			t.ssKmsKey = this.ssKmsKey;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".EncryptionOption")) VarValue.AppendAttribute(recordElem, "EncryptionOption", ssEncryptionOption, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "EncryptionOption");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".KmsKey")) VarValue.AppendAttribute(recordElem, "KmsKey", ssKmsKey, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "KmsKey");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "encryptionoption") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EncryptionOption")) variable.Value = ssEncryptionOption; else variable.Optimized = true;
			} else if (head == "kmskey") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".KmsKey")) variable.Value = ssKmsKey; else variable.Optimized = true;
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
			if (key == IdEncryptionOption) {
				return ssEncryptionOption;
			} else if (key == IdKmsKey) {
				return ssKmsKey;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssEncryptionOption = (string) other.AttributeGet(IdEncryptionOption);
			ssKmsKey = (string) other.AttributeGet(IdKmsKey);
		}
		public bool IsDefault() {
			STAthena_EncryptionConfigurationStructure defaultStruct = new STAthena_EncryptionConfigurationStructure(null);
			if (this.ssEncryptionOption != defaultStruct.ssEncryptionOption) return false;
			if (this.ssKmsKey != defaultStruct.ssKmsKey) return false;
			return true;
		}
	} // STAthena_EncryptionConfigurationStructure

	/// <summary>
	/// Structure <code>STAthena_ResultConfigurationStructure</code> that represents the Service Studio
	///  structure <code>Athena_ResultConfiguration</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAthena_ResultConfigurationStructure: ISerializable, ITypedRecord<STAthena_ResultConfigurationStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdEncryptionConfiguration = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*C37RGA4XqkicT5v97bzguQ");
		internal static readonly GlobalObjectKey IdOutputLocation = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*NB4hOd1IeUmd9E1UfxzfLA");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EncryptionConfiguration")]
		public RCAthena_EncryptionConfigurationRecord ssEncryptionConfiguration;

		[System.Xml.Serialization.XmlElement("OutputLocation")]
		public string ssOutputLocation;


		public BitArray OptimizedAttributes;

		public STAthena_ResultConfigurationStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssEncryptionConfiguration = new RCAthena_EncryptionConfigurationRecord(null);
			ssOutputLocation = "";
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
					ssEncryptionConfiguration.OptimizedAttributes = value[0];
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
			ssOutputLocation = r.ReadText(index++, "Athena_ResultConfiguration.OutputLocation", "");
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
		public void ReadIM(STAthena_ResultConfigurationStructure r) {
			this = r;
		}


		public static bool operator == (STAthena_ResultConfigurationStructure a, STAthena_ResultConfigurationStructure b) {
			if (a.ssEncryptionConfiguration != b.ssEncryptionConfiguration) return false;
			if (a.ssOutputLocation != b.ssOutputLocation) return false;
			return true;
		}

		public static bool operator != (STAthena_ResultConfigurationStructure a, STAthena_ResultConfigurationStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAthena_ResultConfigurationStructure)) return false;
			return (this == (STAthena_ResultConfigurationStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssEncryptionConfiguration.GetHashCode()
				^ ssOutputLocation.GetHashCode()
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

		public STAthena_ResultConfigurationStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssEncryptionConfiguration = new RCAthena_EncryptionConfigurationRecord(null);
			ssOutputLocation = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssEncryptionConfiguration", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssEncryptionConfiguration' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssEncryptionConfiguration = (RCAthena_EncryptionConfigurationRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssOutputLocation", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssOutputLocation' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssOutputLocation = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssEncryptionConfiguration.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssEncryptionConfiguration.InternalRecursiveSave();
		}


		public STAthena_ResultConfigurationStructure Duplicate() {
			STAthena_ResultConfigurationStructure t;
			t.ssEncryptionConfiguration = (RCAthena_EncryptionConfigurationRecord) this.ssEncryptionConfiguration.Duplicate();
			t.ssOutputLocation = this.ssOutputLocation;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				ssEncryptionConfiguration.ToXml(this, recordElem, "EncryptionConfiguration", detailLevel - 1);
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".OutputLocation")) VarValue.AppendAttribute(recordElem, "OutputLocation", ssOutputLocation, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "OutputLocation");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "encryptionconfiguration") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EncryptionConfiguration")) variable.Value = ssEncryptionConfiguration; else variable.Optimized = true;
				variable.SetFieldName("encryptionconfiguration");
			} else if (head == "outputlocation") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".OutputLocation")) variable.Value = ssOutputLocation; else variable.Optimized = true;
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
			if (key == IdEncryptionConfiguration) {
				return ssEncryptionConfiguration;
			} else if (key == IdOutputLocation) {
				return ssOutputLocation;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssEncryptionConfiguration.FillFromOther((IRecord) other.AttributeGet(IdEncryptionConfiguration));
			ssOutputLocation = (string) other.AttributeGet(IdOutputLocation);
		}
		public bool IsDefault() {
			STAthena_ResultConfigurationStructure defaultStruct = new STAthena_ResultConfigurationStructure(null);
			if (this.ssEncryptionConfiguration != defaultStruct.ssEncryptionConfiguration) return false;
			if (this.ssOutputLocation != defaultStruct.ssOutputLocation) return false;
			return true;
		}
	} // STAthena_ResultConfigurationStructure

	/// <summary>
	/// Structure <code>STTextStructure</code> that represents the Service Studio structure
	///  <code>Text</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STTextStructure: ISerializable, ITypedRecord<STTextStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*EEJseqWtv06ZS9ENbiUXCQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("Value")]
		public string ssValue;


		public BitArray OptimizedAttributes;

		public STTextStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssValue = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssValue = r.ReadText(index++, "Text.Value", "");
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
		public void ReadIM(STTextStructure r) {
			this = r;
		}


		public static bool operator == (STTextStructure a, STTextStructure b) {
			if (a.ssValue != b.ssValue) return false;
			return true;
		}

		public static bool operator != (STTextStructure a, STTextStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STTextStructure)) return false;
			return (this == (STTextStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssValue.GetHashCode()
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

		public STTextStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssValue = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssValue", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssValue' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssValue = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STTextStructure Duplicate() {
			STTextStructure t;
			t.ssValue = this.ssValue;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Value")) VarValue.AppendAttribute(recordElem, "Value", ssValue, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Value");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "value") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
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
			if (key == IdValue) {
				return ssValue;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssValue = (string) other.AttributeGet(IdValue);
		}
		public bool IsDefault() {
			STTextStructure defaultStruct = new STTextStructure(null);
			if (this.ssValue != defaultStruct.ssValue) return false;
			return true;
		}
	} // STTextStructure

	/// <summary>
	/// Structure <code>STAthena_EngineVersionStructure</code> that represents the Service Studio structure
	///  <code>Athena_EngineVersion</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAthena_EngineVersionStructure: ISerializable, ITypedRecord<STAthena_EngineVersionStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdEffectiveEngineVersion = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*mhNYRedjwUyLk46ebw_ZfA");
		internal static readonly GlobalObjectKey IdSelectedEngineVersion = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*ps4MVuFSiUaAz8sUq_XJPw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EffectiveEngineVersion")]
		public string ssEffectiveEngineVersion;

		[System.Xml.Serialization.XmlElement("SelectedEngineVersion")]
		public string ssSelectedEngineVersion;


		public BitArray OptimizedAttributes;

		public STAthena_EngineVersionStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssEffectiveEngineVersion = "";
			ssSelectedEngineVersion = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssEffectiveEngineVersion = r.ReadText(index++, "Athena_EngineVersion.EffectiveEngineVersion", "");
			ssSelectedEngineVersion = r.ReadText(index++, "Athena_EngineVersion.SelectedEngineVersion", "");
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
		public void ReadIM(STAthena_EngineVersionStructure r) {
			this = r;
		}


		public static bool operator == (STAthena_EngineVersionStructure a, STAthena_EngineVersionStructure b) {
			if (a.ssEffectiveEngineVersion != b.ssEffectiveEngineVersion) return false;
			if (a.ssSelectedEngineVersion != b.ssSelectedEngineVersion) return false;
			return true;
		}

		public static bool operator != (STAthena_EngineVersionStructure a, STAthena_EngineVersionStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAthena_EngineVersionStructure)) return false;
			return (this == (STAthena_EngineVersionStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssEffectiveEngineVersion.GetHashCode()
				^ ssSelectedEngineVersion.GetHashCode()
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

		public STAthena_EngineVersionStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssEffectiveEngineVersion = "";
			ssSelectedEngineVersion = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssEffectiveEngineVersion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssEffectiveEngineVersion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssEffectiveEngineVersion = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssSelectedEngineVersion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSelectedEngineVersion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSelectedEngineVersion = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STAthena_EngineVersionStructure Duplicate() {
			STAthena_EngineVersionStructure t;
			t.ssEffectiveEngineVersion = this.ssEffectiveEngineVersion;
			t.ssSelectedEngineVersion = this.ssSelectedEngineVersion;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".EffectiveEngineVersion")) VarValue.AppendAttribute(recordElem, "EffectiveEngineVersion", ssEffectiveEngineVersion, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "EffectiveEngineVersion");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".SelectedEngineVersion")) VarValue.AppendAttribute(recordElem, "SelectedEngineVersion", ssSelectedEngineVersion, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "SelectedEngineVersion");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "effectiveengineversion") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EffectiveEngineVersion")) variable.Value = ssEffectiveEngineVersion; else variable.Optimized = true;
			} else if (head == "selectedengineversion") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SelectedEngineVersion")) variable.Value = ssSelectedEngineVersion; else variable.Optimized = true;
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
			if (key == IdEffectiveEngineVersion) {
				return ssEffectiveEngineVersion;
			} else if (key == IdSelectedEngineVersion) {
				return ssSelectedEngineVersion;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssEffectiveEngineVersion = (string) other.AttributeGet(IdEffectiveEngineVersion);
			ssSelectedEngineVersion = (string) other.AttributeGet(IdSelectedEngineVersion);
		}
		public bool IsDefault() {
			STAthena_EngineVersionStructure defaultStruct = new STAthena_EngineVersionStructure(null);
			if (this.ssEffectiveEngineVersion != defaultStruct.ssEffectiveEngineVersion) return false;
			if (this.ssSelectedEngineVersion != defaultStruct.ssSelectedEngineVersion) return false;
			return true;
		}
	} // STAthena_EngineVersionStructure

	/// <summary>
	/// Structure <code>STAthena_QueryExecutionStructure</code> that represents the Service Studio
	///  structure <code>Athena_QueryExecution</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAthena_QueryExecutionStructure: ISerializable, ITypedRecord<STAthena_QueryExecutionStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdEngineVersion = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*V2NnXGy+0E+WwLbP6_SgsA");
		internal static readonly GlobalObjectKey IdQuery = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*e9qVOw5qO0mb8YdNIZT8GQ");
		internal static readonly GlobalObjectKey IdQueryExecutionContext = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*D18ENSpJ0k2Iw66ALzwdOA");
		internal static readonly GlobalObjectKey IdQueryExecutionId = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*0o_sYCdKgkm86uw8_f4eQA");
		internal static readonly GlobalObjectKey IdResultConfiguration = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*l2eJaDjoukadDhkalwyCXA");
		internal static readonly GlobalObjectKey IdStatementType = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*x0T7y1B0tUm_Me3i8NpfrQ");
		internal static readonly GlobalObjectKey IdStatistics = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*A5siDDZfzk6OIdQb2r1LaA");
		internal static readonly GlobalObjectKey IdStatus = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*EuyEmzcqW0iLRPduXVj1lQ");
		internal static readonly GlobalObjectKey IdWorkGroup = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*XpbICMIUck200nxiBqisZg");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("EngineVersion")]
		public RCAthena_EngineVersionRecord ssEngineVersion;

		[System.Xml.Serialization.XmlElement("Query")]
		public string ssQuery;

		[System.Xml.Serialization.XmlElement("QueryExecutionContext")]
		public RCAthena_QueryExecutionContextRecord ssQueryExecutionContext;

		[System.Xml.Serialization.XmlElement("QueryExecutionId")]
		public string ssQueryExecutionId;

		[System.Xml.Serialization.XmlElement("ResultConfiguration")]
		public RCAthena_ResultConfigurationRecord ssResultConfiguration;

		[System.Xml.Serialization.XmlElement("StatementType")]
		public string ssStatementType;

		[System.Xml.Serialization.XmlElement("Statistics")]
		public RCAthena_QueryExecutionStatisticsRecord ssStatistics;

		[System.Xml.Serialization.XmlElement("Status")]
		public RCAthena_QueryExecutionStatusRecord ssStatus;

		[System.Xml.Serialization.XmlElement("WorkGroup")]
		public string ssWorkGroup;


		public BitArray OptimizedAttributes;

		public STAthena_QueryExecutionStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssEngineVersion = new RCAthena_EngineVersionRecord(null);
			ssQuery = "";
			ssQueryExecutionContext = new RCAthena_QueryExecutionContextRecord(null);
			ssQueryExecutionId = "";
			ssResultConfiguration = new RCAthena_ResultConfigurationRecord(null);
			ssStatementType = "";
			ssStatistics = new RCAthena_QueryExecutionStatisticsRecord(null);
			ssStatus = new RCAthena_QueryExecutionStatusRecord(null);
			ssWorkGroup = "";
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[5];
			all[0] = null;
			all[1] = null;
			all[2] = null;
			all[3] = null;
			all[4] = null;
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
					ssEngineVersion.OptimizedAttributes = value[0];
					ssQueryExecutionContext.OptimizedAttributes = value[1];
					ssResultConfiguration.OptimizedAttributes = value[2];
					ssStatistics.OptimizedAttributes = value[3];
					ssStatus.OptimizedAttributes = value[4];
				}
			}
			get {
				BitArray[] all = new BitArray[5];
				all[0] = null;
				all[1] = null;
				all[2] = null;
				all[3] = null;
				all[4] = null;
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssQuery = r.ReadText(index++, "Athena_QueryExecution.Query", "");
			ssQueryExecutionId = r.ReadText(index++, "Athena_QueryExecution.QueryExecutionId", "");
			ssStatementType = r.ReadText(index++, "Athena_QueryExecution.StatementType", "");
			ssWorkGroup = r.ReadText(index++, "Athena_QueryExecution.WorkGroup", "");
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
		public void ReadIM(STAthena_QueryExecutionStructure r) {
			this = r;
		}


		public static bool operator == (STAthena_QueryExecutionStructure a, STAthena_QueryExecutionStructure b) {
			if (a.ssEngineVersion != b.ssEngineVersion) return false;
			if (a.ssQuery != b.ssQuery) return false;
			if (a.ssQueryExecutionContext != b.ssQueryExecutionContext) return false;
			if (a.ssQueryExecutionId != b.ssQueryExecutionId) return false;
			if (a.ssResultConfiguration != b.ssResultConfiguration) return false;
			if (a.ssStatementType != b.ssStatementType) return false;
			if (a.ssStatistics != b.ssStatistics) return false;
			if (a.ssStatus != b.ssStatus) return false;
			if (a.ssWorkGroup != b.ssWorkGroup) return false;
			return true;
		}

		public static bool operator != (STAthena_QueryExecutionStructure a, STAthena_QueryExecutionStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAthena_QueryExecutionStructure)) return false;
			return (this == (STAthena_QueryExecutionStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssEngineVersion.GetHashCode()
				^ ssQuery.GetHashCode()
				^ ssQueryExecutionContext.GetHashCode()
				^ ssQueryExecutionId.GetHashCode()
				^ ssResultConfiguration.GetHashCode()
				^ ssStatementType.GetHashCode()
				^ ssStatistics.GetHashCode()
				^ ssStatus.GetHashCode()
				^ ssWorkGroup.GetHashCode()
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

		public STAthena_QueryExecutionStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssEngineVersion = new RCAthena_EngineVersionRecord(null);
			ssQuery = "";
			ssQueryExecutionContext = new RCAthena_QueryExecutionContextRecord(null);
			ssQueryExecutionId = "";
			ssResultConfiguration = new RCAthena_ResultConfigurationRecord(null);
			ssStatementType = "";
			ssStatistics = new RCAthena_QueryExecutionStatisticsRecord(null);
			ssStatus = new RCAthena_QueryExecutionStatusRecord(null);
			ssWorkGroup = "";
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssEngineVersion", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssEngineVersion' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssEngineVersion = (RCAthena_EngineVersionRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssQuery", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssQuery' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssQuery = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssQueryExecutionContext", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssQueryExecutionContext' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssQueryExecutionContext = (RCAthena_QueryExecutionContextRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssQueryExecutionId", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssQueryExecutionId' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssQueryExecutionId = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssResultConfiguration", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssResultConfiguration' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssResultConfiguration = (RCAthena_ResultConfigurationRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssStatementType", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssStatementType' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssStatementType = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssStatistics", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssStatistics' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssStatistics = (RCAthena_QueryExecutionStatisticsRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssStatus", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssStatus' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssStatus = (RCAthena_QueryExecutionStatusRecord) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssWorkGroup", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssWorkGroup' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssWorkGroup = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
			ssEngineVersion.RecursiveReset();
			ssQueryExecutionContext.RecursiveReset();
			ssResultConfiguration.RecursiveReset();
			ssStatistics.RecursiveReset();
			ssStatus.RecursiveReset();
		}

		public void InternalRecursiveSave() {
			ssEngineVersion.InternalRecursiveSave();
			ssQueryExecutionContext.InternalRecursiveSave();
			ssResultConfiguration.InternalRecursiveSave();
			ssStatistics.InternalRecursiveSave();
			ssStatus.InternalRecursiveSave();
		}


		public STAthena_QueryExecutionStructure Duplicate() {
			STAthena_QueryExecutionStructure t;
			t.ssEngineVersion = (RCAthena_EngineVersionRecord) this.ssEngineVersion.Duplicate();
			t.ssQuery = this.ssQuery;
			t.ssQueryExecutionContext = (RCAthena_QueryExecutionContextRecord) this.ssQueryExecutionContext.Duplicate();
			t.ssQueryExecutionId = this.ssQueryExecutionId;
			t.ssResultConfiguration = (RCAthena_ResultConfigurationRecord) this.ssResultConfiguration.Duplicate();
			t.ssStatementType = this.ssStatementType;
			t.ssStatistics = (RCAthena_QueryExecutionStatisticsRecord) this.ssStatistics.Duplicate();
			t.ssStatus = (RCAthena_QueryExecutionStatusRecord) this.ssStatus.Duplicate();
			t.ssWorkGroup = this.ssWorkGroup;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				ssEngineVersion.ToXml(this, recordElem, "EngineVersion", detailLevel - 1);
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".Query")) VarValue.AppendAttribute(recordElem, "Query", ssQuery, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "Query");
				ssQueryExecutionContext.ToXml(this, recordElem, "QueryExecutionContext", detailLevel - 1);
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".QueryExecutionId")) VarValue.AppendAttribute(recordElem, "QueryExecutionId", ssQueryExecutionId, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "QueryExecutionId");
				ssResultConfiguration.ToXml(this, recordElem, "ResultConfiguration", detailLevel - 1);
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".StatementType")) VarValue.AppendAttribute(recordElem, "StatementType", ssStatementType, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "StatementType");
				ssStatistics.ToXml(this, recordElem, "Statistics", detailLevel - 1);
				ssStatus.ToXml(this, recordElem, "Status", detailLevel - 1);
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".WorkGroup")) VarValue.AppendAttribute(recordElem, "WorkGroup", ssWorkGroup, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "WorkGroup");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "engineversion") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EngineVersion")) variable.Value = ssEngineVersion; else variable.Optimized = true;
				variable.SetFieldName("engineversion");
			} else if (head == "query") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Query")) variable.Value = ssQuery; else variable.Optimized = true;
			} else if (head == "queryexecutioncontext") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".QueryExecutionContext")) variable.Value = ssQueryExecutionContext; else variable.Optimized = true;
				variable.SetFieldName("queryexecutioncontext");
			} else if (head == "queryexecutionid") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".QueryExecutionId")) variable.Value = ssQueryExecutionId; else variable.Optimized = true;
			} else if (head == "resultconfiguration") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ResultConfiguration")) variable.Value = ssResultConfiguration; else variable.Optimized = true;
				variable.SetFieldName("resultconfiguration");
			} else if (head == "statementtype") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".StatementType")) variable.Value = ssStatementType; else variable.Optimized = true;
			} else if (head == "statistics") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Statistics")) variable.Value = ssStatistics; else variable.Optimized = true;
				variable.SetFieldName("statistics");
			} else if (head == "status") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".Status")) variable.Value = ssStatus; else variable.Optimized = true;
				variable.SetFieldName("status");
			} else if (head == "workgroup") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".WorkGroup")) variable.Value = ssWorkGroup; else variable.Optimized = true;
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
			if (key == IdEngineVersion) {
				return ssEngineVersion;
			} else if (key == IdQuery) {
				return ssQuery;
			} else if (key == IdQueryExecutionContext) {
				return ssQueryExecutionContext;
			} else if (key == IdQueryExecutionId) {
				return ssQueryExecutionId;
			} else if (key == IdResultConfiguration) {
				return ssResultConfiguration;
			} else if (key == IdStatementType) {
				return ssStatementType;
			} else if (key == IdStatistics) {
				return ssStatistics;
			} else if (key == IdStatus) {
				return ssStatus;
			} else if (key == IdWorkGroup) {
				return ssWorkGroup;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssEngineVersion.FillFromOther((IRecord) other.AttributeGet(IdEngineVersion));
			ssQuery = (string) other.AttributeGet(IdQuery);
			ssQueryExecutionContext.FillFromOther((IRecord) other.AttributeGet(IdQueryExecutionContext));
			ssQueryExecutionId = (string) other.AttributeGet(IdQueryExecutionId);
			ssResultConfiguration.FillFromOther((IRecord) other.AttributeGet(IdResultConfiguration));
			ssStatementType = (string) other.AttributeGet(IdStatementType);
			ssStatistics.FillFromOther((IRecord) other.AttributeGet(IdStatistics));
			ssStatus.FillFromOther((IRecord) other.AttributeGet(IdStatus));
			ssWorkGroup = (string) other.AttributeGet(IdWorkGroup);
		}
		public bool IsDefault() {
			STAthena_QueryExecutionStructure defaultStruct = new STAthena_QueryExecutionStructure(null);
			if (this.ssEngineVersion != defaultStruct.ssEngineVersion) return false;
			if (this.ssQuery != defaultStruct.ssQuery) return false;
			if (this.ssQueryExecutionContext != defaultStruct.ssQueryExecutionContext) return false;
			if (this.ssQueryExecutionId != defaultStruct.ssQueryExecutionId) return false;
			if (this.ssResultConfiguration != defaultStruct.ssResultConfiguration) return false;
			if (this.ssStatementType != defaultStruct.ssStatementType) return false;
			if (this.ssStatistics != defaultStruct.ssStatistics) return false;
			if (this.ssStatus != defaultStruct.ssStatus) return false;
			if (this.ssWorkGroup != defaultStruct.ssWorkGroup) return false;
			return true;
		}
	} // STAthena_QueryExecutionStructure

	/// <summary>
	/// Structure <code>STAthena_QueryExecutionStatusStructure</code> that represents the Service Studio
	///  structure <code>Athena_QueryExecutionStatus</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAthena_QueryExecutionStatusStructure: ISerializable, ITypedRecord<STAthena_QueryExecutionStatusStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdCompletionDateTime = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*WFQ1gH8zLEqr6A+jXn0veg");
		internal static readonly GlobalObjectKey IdState = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*NHSElvwaL0ukWBRQsyLnYQ");
		internal static readonly GlobalObjectKey IdStateChangeReason = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*mxBRHkMEREGcglYtHIWHDg");
		internal static readonly GlobalObjectKey IdSubmissionDateTime = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*LqgN0BEHZ0qxU6ql25n2sw");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("CompletionDateTime")]
		public DateTime ssCompletionDateTime;

		[System.Xml.Serialization.XmlElement("State")]
		public string ssState;

		[System.Xml.Serialization.XmlElement("StateChangeReason")]
		public string ssStateChangeReason;

		[System.Xml.Serialization.XmlElement("SubmissionDateTime")]
		public DateTime ssSubmissionDateTime;


		public BitArray OptimizedAttributes;

		public STAthena_QueryExecutionStatusStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssCompletionDateTime = new DateTime(1900, 1, 1, 0, 0, 0);
			ssState = "";
			ssStateChangeReason = "";
			ssSubmissionDateTime = new DateTime(1900, 1, 1, 0, 0, 0);
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssCompletionDateTime = r.ReadDateTime(index++, "Athena_QueryExecutionStatus.CompletionDateTime", new DateTime(1900, 1, 1, 0, 0, 0));
			ssState = r.ReadText(index++, "Athena_QueryExecutionStatus.State", "");
			ssStateChangeReason = r.ReadText(index++, "Athena_QueryExecutionStatus.StateChangeReason", "");
			ssSubmissionDateTime = r.ReadDateTime(index++, "Athena_QueryExecutionStatus.SubmissionDateTime", new DateTime(1900, 1, 1, 0, 0, 0));
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
		public void ReadIM(STAthena_QueryExecutionStatusStructure r) {
			this = r;
		}


		public static bool operator == (STAthena_QueryExecutionStatusStructure a, STAthena_QueryExecutionStatusStructure b) {
			if (a.ssCompletionDateTime != b.ssCompletionDateTime) return false;
			if (a.ssState != b.ssState) return false;
			if (a.ssStateChangeReason != b.ssStateChangeReason) return false;
			if (a.ssSubmissionDateTime != b.ssSubmissionDateTime) return false;
			return true;
		}

		public static bool operator != (STAthena_QueryExecutionStatusStructure a, STAthena_QueryExecutionStatusStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAthena_QueryExecutionStatusStructure)) return false;
			return (this == (STAthena_QueryExecutionStatusStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssCompletionDateTime.GetHashCode()
				^ ssState.GetHashCode()
				^ ssStateChangeReason.GetHashCode()
				^ ssSubmissionDateTime.GetHashCode()
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

		public STAthena_QueryExecutionStatusStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssCompletionDateTime = new DateTime(1900, 1, 1, 0, 0, 0);
			ssState = "";
			ssStateChangeReason = "";
			ssSubmissionDateTime = new DateTime(1900, 1, 1, 0, 0, 0);
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssCompletionDateTime", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssCompletionDateTime' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssCompletionDateTime = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssState", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssState' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssState = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssStateChangeReason", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssStateChangeReason' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssStateChangeReason = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssSubmissionDateTime", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssSubmissionDateTime' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssSubmissionDateTime = (DateTime) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STAthena_QueryExecutionStatusStructure Duplicate() {
			STAthena_QueryExecutionStatusStructure t;
			t.ssCompletionDateTime = this.ssCompletionDateTime;
			t.ssState = this.ssState;
			t.ssStateChangeReason = this.ssStateChangeReason;
			t.ssSubmissionDateTime = this.ssSubmissionDateTime;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".CompletionDateTime")) VarValue.AppendAttribute(recordElem, "CompletionDateTime", ssCompletionDateTime, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "CompletionDateTime");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".State")) VarValue.AppendAttribute(recordElem, "State", ssState, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "State");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".StateChangeReason")) VarValue.AppendAttribute(recordElem, "StateChangeReason", ssStateChangeReason, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "StateChangeReason");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".SubmissionDateTime")) VarValue.AppendAttribute(recordElem, "SubmissionDateTime", ssSubmissionDateTime, detailLevel, TypeKind.DateTime); else VarValue.AppendOptimizedAttribute(recordElem, "SubmissionDateTime");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "completiondatetime") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".CompletionDateTime")) variable.Value = ssCompletionDateTime; else variable.Optimized = true;
			} else if (head == "state") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".State")) variable.Value = ssState; else variable.Optimized = true;
			} else if (head == "statechangereason") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".StateChangeReason")) variable.Value = ssStateChangeReason; else variable.Optimized = true;
			} else if (head == "submissiondatetime") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".SubmissionDateTime")) variable.Value = ssSubmissionDateTime; else variable.Optimized = true;
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
			if (key == IdCompletionDateTime) {
				return ssCompletionDateTime;
			} else if (key == IdState) {
				return ssState;
			} else if (key == IdStateChangeReason) {
				return ssStateChangeReason;
			} else if (key == IdSubmissionDateTime) {
				return ssSubmissionDateTime;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssCompletionDateTime = (DateTime) other.AttributeGet(IdCompletionDateTime);
			ssState = (string) other.AttributeGet(IdState);
			ssStateChangeReason = (string) other.AttributeGet(IdStateChangeReason);
			ssSubmissionDateTime = (DateTime) other.AttributeGet(IdSubmissionDateTime);
		}
		public bool IsDefault() {
			STAthena_QueryExecutionStatusStructure defaultStruct = new STAthena_QueryExecutionStatusStructure(null);
			if (this.ssCompletionDateTime != defaultStruct.ssCompletionDateTime) return false;
			if (this.ssState != defaultStruct.ssState) return false;
			if (this.ssStateChangeReason != defaultStruct.ssStateChangeReason) return false;
			if (this.ssSubmissionDateTime != defaultStruct.ssSubmissionDateTime) return false;
			return true;
		}
	} // STAthena_QueryExecutionStatusStructure

	/// <summary>
	/// Structure <code>STAthena_QueryExecutionStatisticsStructure</code> that represents the Service
	///  Studio structure <code>Athena_QueryExecutionStatistics</code> <p> Description: </p>
	/// </summary>
	[Serializable()]
	public partial struct STAthena_QueryExecutionStatisticsStructure: ISerializable, ITypedRecord<STAthena_QueryExecutionStatisticsStructure>, ISimpleRecord {
		internal static readonly GlobalObjectKey IdDataManifestLocation = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*8q23bSegIECHu07_2fLJdQ");
		internal static readonly GlobalObjectKey IdDataScannedInBytes = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*EHhZyKzXnkOjlD_VbNjBUg");
		internal static readonly GlobalObjectKey IdEngineExecutionTimeInMillis = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*STD9jM0iUUir0DtvjY3AIQ");
		internal static readonly GlobalObjectKey IdQueryPlanningTimeInMillis = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*BjGD7_fNZ0OIbNkQAdVVmA");
		internal static readonly GlobalObjectKey IdQueryQueueTimeInMillis = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*NwkRm2UDikGQwXhbt2qdZw");
		internal static readonly GlobalObjectKey IdServiceProcessingTimeInMillis = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*Hz47HAJ+ckyJmm4UHrX8aA");
		internal static readonly GlobalObjectKey IdTotalExecutionTimeInMillis = GlobalObjectKey.Parse("8ZwTm4ohhEyDernQTlYQEg*qS8HRv2MR0CasGEL9WvHDQ");

		public static void EnsureInitialized() {}
		[System.Xml.Serialization.XmlElement("DataManifestLocation")]
		public string ssDataManifestLocation;

		[System.Xml.Serialization.XmlElement("DataScannedInBytes")]
		public long ssDataScannedInBytes;

		[System.Xml.Serialization.XmlElement("EngineExecutionTimeInMillis")]
		public long ssEngineExecutionTimeInMillis;

		[System.Xml.Serialization.XmlElement("QueryPlanningTimeInMillis")]
		public long ssQueryPlanningTimeInMillis;

		[System.Xml.Serialization.XmlElement("QueryQueueTimeInMillis")]
		public long ssQueryQueueTimeInMillis;

		[System.Xml.Serialization.XmlElement("ServiceProcessingTimeInMillis")]
		public long ssServiceProcessingTimeInMillis;

		[System.Xml.Serialization.XmlElement("TotalExecutionTimeInMillis")]
		public long ssTotalExecutionTimeInMillis;


		public BitArray OptimizedAttributes;

		public STAthena_QueryExecutionStatisticsStructure(params string[] dummy) {
			OptimizedAttributes = null;
			ssDataManifestLocation = "";
			ssDataScannedInBytes = 0L;
			ssEngineExecutionTimeInMillis = 0L;
			ssQueryPlanningTimeInMillis = 0L;
			ssQueryQueueTimeInMillis = 0L;
			ssServiceProcessingTimeInMillis = 0L;
			ssTotalExecutionTimeInMillis = 0L;
		}

		public BitArray[] GetDefaultOptimizedValues() {
			BitArray[] all = new BitArray[0];
			return all;
		}

		public BitArray[] AllOptimizedAttributes {
			set {
				if (value == null) {
				} else {
				}
			}
			get {
				BitArray[] all = new BitArray[0];
				return all;
			}
		}

		/// <summary>
		/// Read a record from database
		/// </summary>
		/// <param name="r"> Data base reader</param>
		/// <param name="index"> index</param>
		public void Read(IDataReader r, ref int index) {
			ssDataManifestLocation = r.ReadText(index++, "Athena_QueryExecutionStatistics.DataManifestLocation", "");
			ssDataScannedInBytes = r.ReadLongInteger(index++, "Athena_QueryExecutionStatistics.DataScannedInBytes", 0L);
			ssEngineExecutionTimeInMillis = r.ReadLongInteger(index++, "Athena_QueryExecutionStatistics.EngineExecutionTimeInMillis", 0L);
			ssQueryPlanningTimeInMillis = r.ReadLongInteger(index++, "Athena_QueryExecutionStatistics.QueryPlanningTimeInMillis", 0L);
			ssQueryQueueTimeInMillis = r.ReadLongInteger(index++, "Athena_QueryExecutionStatistics.QueryQueueTimeInMillis", 0L);
			ssServiceProcessingTimeInMillis = r.ReadLongInteger(index++, "Athena_QueryExecutionStatistics.ServiceProcessingTimeInMillis", 0L);
			ssTotalExecutionTimeInMillis = r.ReadLongInteger(index++, "Athena_QueryExecutionStatistics.TotalExecutionTimeInMillis", 0L);
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
		public void ReadIM(STAthena_QueryExecutionStatisticsStructure r) {
			this = r;
		}


		public static bool operator == (STAthena_QueryExecutionStatisticsStructure a, STAthena_QueryExecutionStatisticsStructure b) {
			if (a.ssDataManifestLocation != b.ssDataManifestLocation) return false;
			if (a.ssDataScannedInBytes != b.ssDataScannedInBytes) return false;
			if (a.ssEngineExecutionTimeInMillis != b.ssEngineExecutionTimeInMillis) return false;
			if (a.ssQueryPlanningTimeInMillis != b.ssQueryPlanningTimeInMillis) return false;
			if (a.ssQueryQueueTimeInMillis != b.ssQueryQueueTimeInMillis) return false;
			if (a.ssServiceProcessingTimeInMillis != b.ssServiceProcessingTimeInMillis) return false;
			if (a.ssTotalExecutionTimeInMillis != b.ssTotalExecutionTimeInMillis) return false;
			return true;
		}

		public static bool operator != (STAthena_QueryExecutionStatisticsStructure a, STAthena_QueryExecutionStatisticsStructure b) {
			return !(a==b);
		}

		public override bool Equals(object o) {
			if (o.GetType() != typeof(STAthena_QueryExecutionStatisticsStructure)) return false;
			return (this == (STAthena_QueryExecutionStatisticsStructure) o);
		}

		public override int GetHashCode() {
			try {
				return base.GetHashCode()
				^ ssDataManifestLocation.GetHashCode()
				^ ssDataScannedInBytes.GetHashCode()
				^ ssEngineExecutionTimeInMillis.GetHashCode()
				^ ssQueryPlanningTimeInMillis.GetHashCode()
				^ ssQueryQueueTimeInMillis.GetHashCode()
				^ ssServiceProcessingTimeInMillis.GetHashCode()
				^ ssTotalExecutionTimeInMillis.GetHashCode()
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

		public STAthena_QueryExecutionStatisticsStructure(SerializationInfo info, StreamingContext context) {
			OptimizedAttributes = null;
			ssDataManifestLocation = "";
			ssDataScannedInBytes = 0L;
			ssEngineExecutionTimeInMillis = 0L;
			ssQueryPlanningTimeInMillis = 0L;
			ssQueryQueueTimeInMillis = 0L;
			ssServiceProcessingTimeInMillis = 0L;
			ssTotalExecutionTimeInMillis = 0L;
			Type objInfo = this.GetType();
			FieldInfo fieldInfo = null;
			fieldInfo = objInfo.GetField("ssDataManifestLocation", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssDataManifestLocation' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssDataManifestLocation = (string) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssDataScannedInBytes", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssDataScannedInBytes' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssDataScannedInBytes = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssEngineExecutionTimeInMillis", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssEngineExecutionTimeInMillis' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssEngineExecutionTimeInMillis = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssQueryPlanningTimeInMillis", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssQueryPlanningTimeInMillis' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssQueryPlanningTimeInMillis = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssQueryQueueTimeInMillis", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssQueryQueueTimeInMillis' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssQueryQueueTimeInMillis = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssServiceProcessingTimeInMillis", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssServiceProcessingTimeInMillis' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssServiceProcessingTimeInMillis = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
			fieldInfo = objInfo.GetField("ssTotalExecutionTimeInMillis", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
			if (fieldInfo == null) {
				throw new Exception("The field named 'ssTotalExecutionTimeInMillis' was not found.");
			}
			if (fieldInfo.FieldType.IsSerializable) {
				ssTotalExecutionTimeInMillis = (long) info.GetValue(fieldInfo.Name, fieldInfo.FieldType);
			}
		}

		public void RecursiveReset() {
		}

		public void InternalRecursiveSave() {
		}


		public STAthena_QueryExecutionStatisticsStructure Duplicate() {
			STAthena_QueryExecutionStatisticsStructure t;
			t.ssDataManifestLocation = this.ssDataManifestLocation;
			t.ssDataScannedInBytes = this.ssDataScannedInBytes;
			t.ssEngineExecutionTimeInMillis = this.ssEngineExecutionTimeInMillis;
			t.ssQueryPlanningTimeInMillis = this.ssQueryPlanningTimeInMillis;
			t.ssQueryQueueTimeInMillis = this.ssQueryQueueTimeInMillis;
			t.ssServiceProcessingTimeInMillis = this.ssServiceProcessingTimeInMillis;
			t.ssTotalExecutionTimeInMillis = this.ssTotalExecutionTimeInMillis;
			t.OptimizedAttributes = null;
			return t;
		}

		IRecord IRecord.Duplicate() {
			return Duplicate();
		}

		public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
			System.Xml.XmlElement recordElem = VarValue.AppendChild(baseElem, "Structure");
			if (fieldName != null) {
				VarValue.AppendAttribute(recordElem, "debug.field", fieldName);
				fieldName = fieldName.ToLowerInvariant();
			}
			if (detailLevel > 0) {
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataManifestLocation")) VarValue.AppendAttribute(recordElem, "DataManifestLocation", ssDataManifestLocation, detailLevel, TypeKind.Text); else VarValue.AppendOptimizedAttribute(recordElem, "DataManifestLocation");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".DataScannedInBytes")) VarValue.AppendAttribute(recordElem, "DataScannedInBytes", ssDataScannedInBytes, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "DataScannedInBytes");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".EngineExecutionTimeInMillis")) VarValue.AppendAttribute(recordElem, "EngineExecutionTimeInMillis", ssEngineExecutionTimeInMillis, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "EngineExecutionTimeInMillis");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".QueryPlanningTimeInMillis")) VarValue.AppendAttribute(recordElem, "QueryPlanningTimeInMillis", ssQueryPlanningTimeInMillis, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "QueryPlanningTimeInMillis");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".QueryQueueTimeInMillis")) VarValue.AppendAttribute(recordElem, "QueryQueueTimeInMillis", ssQueryQueueTimeInMillis, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "QueryQueueTimeInMillis");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".ServiceProcessingTimeInMillis")) VarValue.AppendAttribute(recordElem, "ServiceProcessingTimeInMillis", ssServiceProcessingTimeInMillis, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "ServiceProcessingTimeInMillis");
				if (!VarValue.FieldIsOptimized(parent, fieldName + ".TotalExecutionTimeInMillis")) VarValue.AppendAttribute(recordElem, "TotalExecutionTimeInMillis", ssTotalExecutionTimeInMillis, detailLevel, TypeKind.LongInteger); else VarValue.AppendOptimizedAttribute(recordElem, "TotalExecutionTimeInMillis");
			} else {
				VarValue.AppendDeferredEvaluationElement(recordElem);
			}
		}

		public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
			String head = VarValue.GetHead(fields);
			String tail = VarValue.GetTail(fields);
			variable.Found = false;
			if (head == "datamanifestlocation") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataManifestLocation")) variable.Value = ssDataManifestLocation; else variable.Optimized = true;
			} else if (head == "datascannedinbytes") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".DataScannedInBytes")) variable.Value = ssDataScannedInBytes; else variable.Optimized = true;
			} else if (head == "engineexecutiontimeinmillis") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".EngineExecutionTimeInMillis")) variable.Value = ssEngineExecutionTimeInMillis; else variable.Optimized = true;
			} else if (head == "queryplanningtimeinmillis") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".QueryPlanningTimeInMillis")) variable.Value = ssQueryPlanningTimeInMillis; else variable.Optimized = true;
			} else if (head == "queryqueuetimeinmillis") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".QueryQueueTimeInMillis")) variable.Value = ssQueryQueueTimeInMillis; else variable.Optimized = true;
			} else if (head == "serviceprocessingtimeinmillis") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".ServiceProcessingTimeInMillis")) variable.Value = ssServiceProcessingTimeInMillis; else variable.Optimized = true;
			} else if (head == "totalexecutiontimeinmillis") {
				if (!VarValue.FieldIsOptimized(parent, baseName + ".TotalExecutionTimeInMillis")) variable.Value = ssTotalExecutionTimeInMillis; else variable.Optimized = true;
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
			if (key == IdDataManifestLocation) {
				return ssDataManifestLocation;
			} else if (key == IdDataScannedInBytes) {
				return ssDataScannedInBytes;
			} else if (key == IdEngineExecutionTimeInMillis) {
				return ssEngineExecutionTimeInMillis;
			} else if (key == IdQueryPlanningTimeInMillis) {
				return ssQueryPlanningTimeInMillis;
			} else if (key == IdQueryQueueTimeInMillis) {
				return ssQueryQueueTimeInMillis;
			} else if (key == IdServiceProcessingTimeInMillis) {
				return ssServiceProcessingTimeInMillis;
			} else if (key == IdTotalExecutionTimeInMillis) {
				return ssTotalExecutionTimeInMillis;
			} else {
				throw new Exception("Invalid key");
			}
		}
		public void FillFromOther(IRecord other) {
			if (other == null) return;
			ssDataManifestLocation = (string) other.AttributeGet(IdDataManifestLocation);
			ssDataScannedInBytes = (long) other.AttributeGet(IdDataScannedInBytes);
			ssEngineExecutionTimeInMillis = (long) other.AttributeGet(IdEngineExecutionTimeInMillis);
			ssQueryPlanningTimeInMillis = (long) other.AttributeGet(IdQueryPlanningTimeInMillis);
			ssQueryQueueTimeInMillis = (long) other.AttributeGet(IdQueryQueueTimeInMillis);
			ssServiceProcessingTimeInMillis = (long) other.AttributeGet(IdServiceProcessingTimeInMillis);
			ssTotalExecutionTimeInMillis = (long) other.AttributeGet(IdTotalExecutionTimeInMillis);
		}
		public bool IsDefault() {
			STAthena_QueryExecutionStatisticsStructure defaultStruct = new STAthena_QueryExecutionStatisticsStructure(null);
			if (this.ssDataManifestLocation != defaultStruct.ssDataManifestLocation) return false;
			if (this.ssDataScannedInBytes != defaultStruct.ssDataScannedInBytes) return false;
			if (this.ssEngineExecutionTimeInMillis != defaultStruct.ssEngineExecutionTimeInMillis) return false;
			if (this.ssQueryPlanningTimeInMillis != defaultStruct.ssQueryPlanningTimeInMillis) return false;
			if (this.ssQueryQueueTimeInMillis != defaultStruct.ssQueryQueueTimeInMillis) return false;
			if (this.ssServiceProcessingTimeInMillis != defaultStruct.ssServiceProcessingTimeInMillis) return false;
			if (this.ssTotalExecutionTimeInMillis != defaultStruct.ssTotalExecutionTimeInMillis) return false;
			return true;
		}
	} // STAthena_QueryExecutionStatisticsStructure

} // OutSystems.NssGRAX_AthenaConnector
