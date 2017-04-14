using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='MultiSpHelper']"
	[global::Android.Runtime.Register ("cn/jiguang/api/MultiSpHelper", DoNotGenerateAcw=true)]
	public partial class MultiSpHelper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/api/MultiSpHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiSpHelper); }
		}

		protected MultiSpHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='MultiSpHelper']/constructor[@name='MultiSpHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MultiSpHelper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MultiSpHelper)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='MultiSpHelper']/method[@name='commitBoolean' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("commitBoolean", "(Landroid/content/Context;Ljava/lang/String;Z)V", "")]
		public static unsafe void CommitBoolean (global::Android.Content.Context p0, string p1, bool p2)
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

		static IntPtr id_commitInt_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='MultiSpHelper']/method[@name='commitInt' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("commitInt", "(Landroid/content/Context;Ljava/lang/String;I)V", "")]
		public static unsafe void CommitInt (global::Android.Content.Context p0, string p1, int p2)
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

		static IntPtr id_commitLong_Landroid_content_Context_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='MultiSpHelper']/method[@name='commitLong' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("commitLong", "(Landroid/content/Context;Ljava/lang/String;J)V", "")]
		public static unsafe void CommitLong (global::Android.Content.Context p0, string p1, long p2)
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

		static IntPtr id_commitString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='MultiSpHelper']/method[@name='commitString' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("commitString", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void CommitString (global::Android.Content.Context p0, string p1, string p2)
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

		static IntPtr id_getBoolean_Landroid_content_Context_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='MultiSpHelper']/method[@name='getBoolean' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getBoolean", "(Landroid/content/Context;Ljava/lang/String;Z)Z", "")]
		public static unsafe bool GetBoolean (global::Android.Content.Context p0, string p1, bool p2)
		{
			if (id_getBoolean_Landroid_content_Context_Ljava_lang_String_Z == IntPtr.Zero)
				id_getBoolean_Landroid_content_Context_Ljava_lang_String_Z = JNIEnv.GetStaticMethodID (class_ref, "getBoolean", "(Landroid/content/Context;Ljava/lang/String;Z)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_getBoolean_Landroid_content_Context_Ljava_lang_String_Z, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getInt_Landroid_content_Context_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='MultiSpHelper']/method[@name='getInt' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("getInt", "(Landroid/content/Context;Ljava/lang/String;I)I", "")]
		public static unsafe int GetInt (global::Android.Content.Context p0, string p1, int p2)
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

		static IntPtr id_getLong_Landroid_content_Context_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='MultiSpHelper']/method[@name='getLong' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long']]"
		[Register ("getLong", "(Landroid/content/Context;Ljava/lang/String;J)J", "")]
		public static unsafe long GetLong (global::Android.Content.Context p0, string p1, long p2)
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

		static IntPtr id_getString_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='MultiSpHelper']/method[@name='getString' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getString", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetString (global::Android.Content.Context p0, string p1, string p2)
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

	}
}
