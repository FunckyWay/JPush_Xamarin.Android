using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']"
	[global::Android.Runtime.Register ("cn/jiguang/service/Protocol", DoNotGenerateAcw=true)]
	public partial class Protocol : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/service/Protocol", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Protocol); }
		}

		protected Protocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_GetSdkVersion;
		public static unsafe int SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']/method[@name='GetSdkVersion' and count(parameter)=0]"
			[Register ("GetSdkVersion", "()I", "GetGetSdkVersionHandler")]
			get {
				if (id_GetSdkVersion == IntPtr.Zero)
					id_GetSdkVersion = JNIEnv.GetStaticMethodID (class_ref, "GetSdkVersion", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_GetSdkVersion);
				} finally {
				}
			}
		}

		static IntPtr id_Close_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']/method[@name='Close' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Close", "(J)I", "")]
		public static unsafe int Close (long p0)
		{
			if (id_Close_J == IntPtr.Zero)
				id_Close_J = JNIEnv.GetStaticMethodID (class_ref, "Close", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_Close_J, __args);
			} finally {
			}
		}

		static IntPtr id_InitConn;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']/method[@name='InitConn' and count(parameter)=0]"
		[Register ("InitConn", "()J", "")]
		public static unsafe long InitConn ()
		{
			if (id_InitConn == IntPtr.Zero)
				id_InitConn = JNIEnv.GetStaticMethodID (class_ref, "InitConn", "()J");
			try {
				return JNIEnv.CallStaticLongMethod  (class_ref, id_InitConn);
			} finally {
			}
		}

		static IntPtr id_InitPush_JLjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']/method[@name='InitPush' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("InitPush", "(JLjava/lang/String;I)I", "")]
		public static unsafe int InitPush (long p0, string p1, int p2)
		{
			if (id_InitPush_JLjava_lang_String_I == IntPtr.Zero)
				id_InitPush_JLjava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "InitPush", "(JLjava/lang/String;I)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_InitPush_JLjava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_LogPush_JarrayBarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']/method[@name='LogPush' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int']]"
		[Register ("LogPush", "(J[B[BI)I", "")]
		public static unsafe int LogPush (long p0, byte[] p1, byte[] p2, int p3)
		{
			if (id_LogPush_JarrayBarrayBI == IntPtr.Zero)
				id_LogPush_JarrayBarrayBI = JNIEnv.GetStaticMethodID (class_ref, "LogPush", "(J[B[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_LogPush_JarrayBarrayBI, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static IntPtr id_RecvPush_JarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']/method[@name='RecvPush' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("RecvPush", "(J[BI)I", "")]
		public static unsafe int RecvPush (long p0, byte[] p1, int p2)
		{
			if (id_RecvPush_JarrayBI == IntPtr.Zero)
				id_RecvPush_JarrayBI = JNIEnv.GetStaticMethodID (class_ref, "RecvPush", "(J[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_RecvPush_JarrayBI, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_SendData_JarrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']/method[@name='SendData' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("SendData", "(J[BI)I", "")]
		public static unsafe int SendData (long p0, byte[] p1, int p2)
		{
			if (id_SendData_JarrayBI == IntPtr.Zero)
				id_SendData_JarrayBI = JNIEnv.GetStaticMethodID (class_ref, "SendData", "(J[BI)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_SendData_JarrayBI, __args);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_Stop_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.service']/class[@name='Protocol']/method[@name='Stop' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("Stop", "(J)I", "")]
		public static unsafe int Stop (long p0)
		{
			if (id_Stop_J == IntPtr.Zero)
				id_Stop_J = JNIEnv.GetStaticMethodID (class_ref, "Stop", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_Stop_J, __args);
			} finally {
			}
		}

	}
}
