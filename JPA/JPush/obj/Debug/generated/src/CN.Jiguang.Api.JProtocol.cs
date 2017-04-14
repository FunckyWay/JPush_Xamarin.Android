using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']"
	[global::Android.Runtime.Register ("cn/jiguang/api/JProtocol", DoNotGenerateAcw=true)]
	public abstract partial class JProtocol : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='DEFAULT_RESP_CODE']"
		[Register ("DEFAULT_RESP_CODE")]
		public const int DefaultRespCode = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='DEFAULT_RID']"
		[Register ("DEFAULT_RID")]
		public const int DefaultRid = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='DEFAULT_SID']"
		[Register ("DEFAULT_SID")]
		public const int DefaultSid = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='NO_JUID']"
		[Register ("NO_JUID")]
		public const int NoJuid = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='NO_RESP_CODE']"
		[Register ("NO_RESP_CODE")]
		public const int NoRespCode = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/field[@name='NO_SID']"
		[Register ("NO_SID")]
		public const int NoSid = (int) -1;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/api/JProtocol", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JProtocol); }
		}

		protected JProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ZIIJIJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/constructor[@name='JProtocol' and count(parameter)=6 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='int'] and parameter[6][@type='long']]"
		[Register (".ctor", "(ZIIJIJ)V", "")]
		public unsafe JProtocol (bool p0, int p1, int p2, long p3, int p4, long p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (JProtocol)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZIIJIJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZIIJIJ)V", __args);
					return;
				}

				if (id_ctor_ZIIJIJ == IntPtr.Zero)
					id_ctor_ZIIJIJ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZIIJIJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZIIJIJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZIIJIJ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_ZIIJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/constructor[@name='JProtocol' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register (".ctor", "(ZIIJ)V", "")]
		public unsafe JProtocol (bool p0, int p1, int p2, long p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (JProtocol)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZIIJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZIIJ)V", __args);
					return;
				}

				if (id_ctor_ZIIJ == IntPtr.Zero)
					id_ctor_ZIIJ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZIIJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZIIJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZIIJ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_ZLjava_lang_Object_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/constructor[@name='JProtocol' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(ZLjava/lang/Object;Ljava/nio/ByteBuffer;)V", "")]
		public unsafe JProtocol (bool p0, global::Java.Lang.Object p1, global::Java.Nio.ByteBuffer p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (JProtocol)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZLjava/lang/Object;Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ZLjava/lang/Object;Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_ZLjava_lang_Object_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_ZLjava_lang_Object_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ZLjava/lang/Object;Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZLjava_lang_Object_Ljava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ZLjava_lang_Object_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Body);
		}
#pragma warning restore 0169

		static IntPtr id_getBody;
		public virtual unsafe global::Java.Nio.ByteBuffer Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/nio/ByteBuffer;", "GetGetBodyHandler")]
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Ljava/nio/ByteBuffer;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Ljava/nio/ByteBuffer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCommand;
#pragma warning disable 0169
		static Delegate GetGetCommandHandler ()
		{
			if (cb_getCommand == null)
				cb_getCommand = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCommand);
			return cb_getCommand;
		}

		static int n_GetCommand (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Command;
		}
#pragma warning restore 0169

		static IntPtr id_getCommand;
		public virtual unsafe int Command {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getCommand' and count(parameter)=0]"
			[Register ("getCommand", "()I", "GetGetCommandHandler")]
			get {
				if (id_getCommand == IntPtr.Zero)
					id_getCommand = JNIEnv.GetMethodID (class_ref, "getCommand", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getCommand);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCommand", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isNeedParseeErrorMsg;
#pragma warning disable 0169
		static Delegate GetIsNeedParseeErrorMsgHandler ()
		{
			if (cb_isNeedParseeErrorMsg == null)
				cb_isNeedParseeErrorMsg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNeedParseeErrorMsg);
			return cb_isNeedParseeErrorMsg;
		}

		static bool n_IsNeedParseeErrorMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNeedParseeErrorMsg;
		}
#pragma warning restore 0169

		protected abstract bool IsNeedParseeErrorMsg {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='isNeedParseeErrorMsg' and count(parameter)=0]"
			[Register ("isNeedParseeErrorMsg", "()Z", "GetIsNeedParseeErrorMsgHandler")] get;
		}

		static Delegate cb_getJuid;
#pragma warning disable 0169
		static Delegate GetGetJuidHandler ()
		{
			if (cb_getJuid == null)
				cb_getJuid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetJuid);
			return cb_getJuid;
		}

		static long n_GetJuid (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Juid;
		}
#pragma warning restore 0169

		static IntPtr id_getJuid;
		public virtual unsafe long Juid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getJuid' and count(parameter)=0]"
			[Register ("getJuid", "()J", "GetGetJuidHandler")]
			get {
				if (id_getJuid == IntPtr.Zero)
					id_getJuid = JNIEnv.GetMethodID (class_ref, "getJuid", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getJuid);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJuid", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public abstract string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")] get;
		}

		static Delegate cb_getRid;
#pragma warning disable 0169
		static Delegate GetGetRidHandler ()
		{
			if (cb_getRid == null)
				cb_getRid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRid);
			return cb_getRid;
		}

		static IntPtr n_GetRid (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rid);
		}
#pragma warning restore 0169

		static IntPtr id_getRid;
		public virtual unsafe global::Java.Lang.Long Rid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getRid' and count(parameter)=0]"
			[Register ("getRid", "()Ljava/lang/Long;", "GetGetRidHandler")]
			get {
				if (id_getRid == IntPtr.Zero)
					id_getRid = JNIEnv.GetMethodID (class_ref, "getRid", "()Ljava/lang/Long;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod  (Handle, id_getRid), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRid", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSid;
#pragma warning disable 0169
		static Delegate GetGetSidHandler ()
		{
			if (cb_getSid == null)
				cb_getSid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSid);
			return cb_getSid;
		}

		static int n_GetSid (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sid;
		}
#pragma warning restore 0169

		static IntPtr id_getSid;
		public virtual unsafe int Sid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getSid' and count(parameter)=0]"
			[Register ("getSid", "()I", "GetGetSidHandler")]
			get {
				if (id_getSid == IntPtr.Zero)
					id_getSid = JNIEnv.GetMethodID (class_ref, "getSid", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSid);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSid", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		public virtual unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getVersion);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_parseBody;
#pragma warning disable 0169
		static Delegate GetParseBodyHandler ()
		{
			if (cb_parseBody == null)
				cb_parseBody = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ParseBody);
			return cb_parseBody;
		}

		static void n_ParseBody (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseBody ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='parseBody' and count(parameter)=0]"
		[Register ("parseBody", "()V", "GetParseBodyHandler")]
		protected abstract void ParseBody ();

		static Delegate cb_writeBody;
#pragma warning disable 0169
		static Delegate GetWriteBodyHandler ()
		{
			if (cb_writeBody == null)
				cb_writeBody = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WriteBody);
			return cb_writeBody;
		}

		static void n_WriteBody (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteBody ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeBody' and count(parameter)=0]"
		[Register ("writeBody", "()V", "GetWriteBodyHandler")]
		protected abstract void WriteBody ();

		static IntPtr id_writeBodyAndToBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeBodyAndToBytes' and count(parameter)=0]"
		[Register ("writeBodyAndToBytes", "()[B", "")]
		public unsafe byte[] WriteBodyAndToBytes ()
		{
			if (id_writeBodyAndToBytes == IntPtr.Zero)
				id_writeBodyAndToBytes = JNIEnv.GetMethodID (class_ref, "writeBodyAndToBytes", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_writeBodyAndToBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_writeBytes_arrayB;
#pragma warning disable 0169
		static Delegate GetWriteBytes_arrayBHandler ()
		{
			if (cb_writeBytes_arrayB == null)
				cb_writeBytes_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteBytes_arrayB);
			return cb_writeBytes_arrayB;
		}

		static void n_WriteBytes_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteBytes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writeBytes", "([B)V", "GetWriteBytes_arrayBHandler")]
		protected virtual unsafe void WriteBytes (byte[] p0)
		{
			if (id_writeBytes_arrayB == IntPtr.Zero)
				id_writeBytes_arrayB = JNIEnv.GetMethodID (class_ref, "writeBytes", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeBytes_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeBytes", "([B)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_writeInt1_I;
#pragma warning disable 0169
		static Delegate GetWriteInt1_IHandler ()
		{
			if (cb_writeInt1_I == null)
				cb_writeInt1_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteInt1_I);
			return cb_writeInt1_I;
		}

		static void n_WriteInt1_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteInt1 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeInt1_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeInt1' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeInt1", "(I)V", "GetWriteInt1_IHandler")]
		protected virtual unsafe void WriteInt1 (int p0)
		{
			if (id_writeInt1_I == IntPtr.Zero)
				id_writeInt1_I = JNIEnv.GetMethodID (class_ref, "writeInt1", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeInt1_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeInt1", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeInt2_I;
#pragma warning disable 0169
		static Delegate GetWriteInt2_IHandler ()
		{
			if (cb_writeInt2_I == null)
				cb_writeInt2_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteInt2_I);
			return cb_writeInt2_I;
		}

		static void n_WriteInt2_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteInt2 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeInt2_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeInt2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeInt2", "(I)V", "GetWriteInt2_IHandler")]
		protected virtual unsafe void WriteInt2 (int p0)
		{
			if (id_writeInt2_I == IntPtr.Zero)
				id_writeInt2_I = JNIEnv.GetMethodID (class_ref, "writeInt2", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeInt2_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeInt2", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeInt4_I;
#pragma warning disable 0169
		static Delegate GetWriteInt4_IHandler ()
		{
			if (cb_writeInt4_I == null)
				cb_writeInt4_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_WriteInt4_I);
			return cb_writeInt4_I;
		}

		static void n_WriteInt4_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteInt4 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeInt4_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeInt4' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("writeInt4", "(I)V", "GetWriteInt4_IHandler")]
		protected virtual unsafe void WriteInt4 (int p0)
		{
			if (id_writeInt4_I == IntPtr.Zero)
				id_writeInt4_I = JNIEnv.GetMethodID (class_ref, "writeInt4", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeInt4_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeInt4", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeLong8_J;
#pragma warning disable 0169
		static Delegate GetWriteLong8_JHandler ()
		{
			if (cb_writeLong8_J == null)
				cb_writeLong8_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_WriteLong8_J);
			return cb_writeLong8_J;
		}

		static void n_WriteLong8_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteLong8 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeLong8_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeLong8' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("writeLong8", "(J)V", "GetWriteLong8_JHandler")]
		protected virtual unsafe void WriteLong8 (long p0)
		{
			if (id_writeLong8_J == IntPtr.Zero)
				id_writeLong8_J = JNIEnv.GetMethodID (class_ref, "writeLong8", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeLong8_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeLong8", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeTlv2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWriteTlv2_Ljava_lang_String_Handler ()
		{
			if (cb_writeTlv2_Ljava_lang_String_ == null)
				cb_writeTlv2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WriteTlv2_Ljava_lang_String_);
			return cb_writeTlv2_Ljava_lang_String_;
		}

		static void n_WriteTlv2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Api.JProtocol __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JProtocol> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WriteTlv2 (p0);
		}
#pragma warning restore 0169

		static IntPtr id_writeTlv2_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeTlv2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("writeTlv2", "(Ljava/lang/String;)V", "GetWriteTlv2_Ljava_lang_String_Handler")]
		protected virtual unsafe void WriteTlv2 (string p0)
		{
			if (id_writeTlv2_Ljava_lang_String_ == IntPtr.Zero)
				id_writeTlv2_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "writeTlv2", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeTlv2_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeTlv2", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("cn/jiguang/api/JProtocol", DoNotGenerateAcw=true)]
	internal partial class JProtocolInvoker : JProtocol {

		public JProtocolInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (JProtocolInvoker); }
		}

		static IntPtr id_isNeedParseeErrorMsg;
		protected override unsafe bool IsNeedParseeErrorMsg {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='isNeedParseeErrorMsg' and count(parameter)=0]"
			[Register ("isNeedParseeErrorMsg", "()Z", "GetIsNeedParseeErrorMsgHandler")]
			get {
				if (id_isNeedParseeErrorMsg == IntPtr.Zero)
					id_isNeedParseeErrorMsg = JNIEnv.GetMethodID (class_ref, "isNeedParseeErrorMsg", "()Z");
				try {
					return JNIEnv.CallBooleanMethod  (Handle, id_isNeedParseeErrorMsg);
				} finally {
				}
			}
		}

		static IntPtr id_getName;
		public override unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_parseBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='parseBody' and count(parameter)=0]"
		[Register ("parseBody", "()V", "GetParseBodyHandler")]
		protected override unsafe void ParseBody ()
		{
			if (id_parseBody == IntPtr.Zero)
				id_parseBody = JNIEnv.GetMethodID (class_ref, "parseBody", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_parseBody);
			} finally {
			}
		}

		static IntPtr id_writeBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JProtocol']/method[@name='writeBody' and count(parameter)=0]"
		[Register ("writeBody", "()V", "GetWriteBodyHandler")]
		protected override unsafe void WriteBody ()
		{
			if (id_writeBody == IntPtr.Zero)
				id_writeBody = JNIEnv.GetMethodID (class_ref, "writeBody", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_writeBody);
			} finally {
			}
		}

	}

}
