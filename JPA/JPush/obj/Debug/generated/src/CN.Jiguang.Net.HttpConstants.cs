using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']"
	[global::Android.Runtime.Register ("cn/jiguang/net/HttpConstants", DoNotGenerateAcw=true)]
	public partial class HttpConstants : global::Java.Lang.Object {


		static IntPtr CACHE_CONTROL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='CACHE_CONTROL']"
		[Register ("CACHE_CONTROL")]
		public static string CacheControl {
			get {
				if (CACHE_CONTROL_jfieldId == IntPtr.Zero)
					CACHE_CONTROL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CACHE_CONTROL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CACHE_CONTROL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXPIRES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='EXPIRES']"
		[Register ("EXPIRES")]
		public static string Expires {
			get {
				if (EXPIRES_jfieldId == IntPtr.Zero)
					EXPIRES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXPIRES", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXPIRES_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='NET_ERROR_CODE']"
		[Register ("NET_ERROR_CODE")]
		public const int NetErrorCode = (int) 2998;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='NET_MALTFORMED_ERROR']"
		[Register ("NET_MALTFORMED_ERROR")]
		public const int NetMaltformedError = (int) 3004;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='NET_SSL_EXECPTION']"
		[Register ("NET_SSL_EXECPTION")]
		public const int NetSslExecption = (int) 3005;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='NET_TIMEOUT_CODE']"
		[Register ("NET_TIMEOUT_CODE")]
		public const int NetTimeoutCode = (int) 3001;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='NET_UNKNOW_HOST']"
		[Register ("NET_UNKNOW_HOST")]
		public const int NetUnknowHost = (int) 3003;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='STACK_OVER_EXECPTION']"
		[Register ("STACK_OVER_EXECPTION")]
		public const int StackOverExecption = (int) 3007;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/field[@name='UNKNOW_EXECPTION']"
		[Register ("UNKNOW_EXECPTION")]
		public const int UnknowExecption = (int) 3006;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/net/HttpConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpConstants); }
		}

		protected HttpConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpConstants']/constructor[@name='HttpConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpConstants)) {
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

	}
}
