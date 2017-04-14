using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']"
	[global::Android.Runtime.Register ("cn/jiguang/api/BasePreferenceManager", DoNotGenerateAcw=true)]
	public abstract partial class BasePreferenceManager : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/api/BasePreferenceManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasePreferenceManager); }
		}

		protected BasePreferenceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/constructor[@name='BasePreferenceManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BasePreferenceManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BasePreferenceManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_commitBoolean_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='commitBoolean' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("commitBoolean", "(Landroid/content/Context;Ljava/lang/String;Z)V", "")]
		protected static unsafe void CommitBoolean (global::Android.Content.Context p0, string p1, bool p2)
		{
			if (id_commitBoolean_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
				id_commitBoolean_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "commitBoolean", "(Landroid/content/Context;Ljava/lang/String;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_commitBoolean_Landroid_content_Context_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_commitBoolean_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='commitBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("commitBoolean", "(Ljava/lang/String;Z)V", "")]
		protected static unsafe void CommitBoolean (string p0, bool p1)
		{
			if (id_commitBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_commitBoolean_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "commitBoolean", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_commitBoolean_Ljava_lang_String_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_commitInt_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='commitInt' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("commitInt", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		protected static unsafe void CommitInt (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_commitInt_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_commitInt_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "commitInt", "(Landroid/content/Context;Ljava/lang/String;I)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_commitInt_Landroid_content_Context_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_commitInt_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='commitInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("commitInt", "(Ljava/lang/String;I)V", "")]
		protected static unsafe void CommitInt (string p0, int p1)
		{
			if (id_commitInt_Ljava_lang_String_I == IntPtr.Zero)
				id_commitInt_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "commitInt", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_commitInt_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_commitLong_Landroid_content_Context_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='commitLong' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("commitLong", "(Landroid/content/Context;Ljava/lang/String;J)V", "")]
		protected static unsafe void CommitLong (global::Android.Content.Context p0, string p1, long p2)
		{
			if (id_commitLong_Landroid_content_Context_Ljava_lang_String_J == IntPtr.Zero)
				id_commitLong_Landroid_content_Context_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "commitLong", "(Landroid/content/Context;Ljava/lang/String;J)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_commitLong_Landroid_content_Context_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_commitLong_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='commitLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("commitLong", "(Ljava/lang/String;J)V", "")]
		protected static unsafe void CommitLong (string p0, long p1)
		{
			if (id_commitLong_Ljava_lang_String_J == IntPtr.Zero)
				id_commitLong_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "commitLong", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_commitLong_Ljava_lang_String_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_commitString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='commitString' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("commitString", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		protected static unsafe void CommitString (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_commitString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_commitString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "commitString", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_commitString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_commitString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='commitString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("commitString", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		protected static unsafe void CommitString (string p0, string p1)
		{
			if (id_commitString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_commitString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "commitString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_commitString_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_commitStringWithEncryption_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='commitStringWithEncryption' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("commitStringWithEncryption", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		protected static unsafe void CommitStringWithEncryption (string p0, string p1)
		{
			if (id_commitStringWithEncryption_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_commitStringWithEncryption_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "commitStringWithEncryption", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_commitStringWithEncryption_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getBoolean_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getBoolean' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getBoolean", "(Landroid/content/Context;Ljava/lang/String;Z)Ljava/lang/Boolean;", "")]
		protected static unsafe global::Java.Lang.Boolean GetBoolean (global::Android.Content.Context p0, string p1, bool p2)
		{
			if (id_getBoolean_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getBoolean", "(Landroid/content/Context;Ljava/lang/String;Z)Ljava/lang/Boolean;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBoolean_Landroid_content_Context_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getBoolean_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getBoolean", "(Ljava/lang/String;Z)Ljava/lang/Boolean;", "")]
		protected static unsafe global::Java.Lang.Boolean GetBoolean (string p0, bool p1)
		{
			if (id_getBoolean_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getBoolean", "(Ljava/lang/String;Z)Ljava/lang/Boolean;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Boolean __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBoolean_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getDecryptString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getDecryptString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getDecryptString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetDecryptString (string p0, string p1)
		{
			if (id_getDecryptString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getDecryptString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDecryptString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDecryptString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getEncryptedString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getEncryptedString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEncryptedString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetEncryptedString (string p0)
		{
			if (id_getEncryptedString_Ljava_lang_String_ == IntPtr.Zero)
				id_getEncryptedString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getEncryptedString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getEncryptedString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getInt_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getInt' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getInt", "(Landroid/content/Context;Ljava/lang/String;I)I", "")]
		protected static unsafe int GetInt (global::Android.Content.Context p0, string p1, int p2)
		{
			if (id_getInt_Landroid_content_Context_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Landroid_content_Context_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getInt", "(Landroid/content/Context;Ljava/lang/String;I)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getInt_Landroid_content_Context_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getInt_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;I)I", "")]
		protected static unsafe int GetInt (string p0, int p1)
		{
			if (id_getInt_Ljava_lang_String_I == IntPtr.Zero)
				id_getInt_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "getInt", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getInt_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getLong_Landroid_content_Context_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getLong' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("getLong", "(Landroid/content/Context;Ljava/lang/String;J)J", "")]
		protected static unsafe long GetLong (global::Android.Content.Context p0, string p1, long p2)
		{
			if (id_getLong_Landroid_content_Context_Ljava_lang_String_J == IntPtr.Zero)
				id_getLong_Landroid_content_Context_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "getLong", "(Landroid/content/Context;Ljava/lang/String;J)J");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getLong_Landroid_content_Context_Ljava_lang_String_J, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getLong_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("getLong", "(Ljava/lang/String;J)J", "")]
		protected static unsafe long GetLong (string p0, long p1)
		{
			if (id_getLong_Ljava_lang_String_J == IntPtr.Zero)
				id_getLong_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "getLong", "(Ljava/lang/String;J)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getLong_Ljava_lang_String_J, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getString' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getString", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static unsafe string GetString (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getString", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getString_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static unsafe string GetString (string p0, string p1)
		{
			if (id_getString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getStringUnencrypted_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='getStringUnencrypted' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStringUnencrypted", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		protected static unsafe string GetStringUnencrypted (string p0, string p1)
		{
			if (id_getStringUnencrypted_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getStringUnencrypted_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStringUnencrypted", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStringUnencrypted_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_removeAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='removeAll' and count(parameter)=0]"
		[Register ("removeAll", "()V", "")]
		public static unsafe void RemoveAll ()
		{
			if (id_removeAll == IntPtr.Zero)
				id_removeAll = JNIEnv.GetStaticMethodID (class_ref, "removeAll", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeAll);
			} finally {
			}
		}

		static IntPtr id_removeKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BasePreferenceManager']/method[@name='removeKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeKey", "(Ljava/lang/String;)V", "")]
		public static unsafe void RemoveKey (string p0)
		{
			if (id_removeKey_Ljava_lang_String_ == IntPtr.Zero)
				id_removeKey_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "removeKey", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeKey_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("cn/jiguang/api/BasePreferenceManager", DoNotGenerateAcw=true)]
	internal partial class BasePreferenceManagerInvoker : BasePreferenceManager {

		public BasePreferenceManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BasePreferenceManagerInvoker); }
		}

	}

}
