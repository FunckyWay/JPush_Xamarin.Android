using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']"
	[global::Android.Runtime.Register ("cn/jiguang/api/utils/ByteBufferUtils", DoNotGenerateAcw=true)]
	public partial class ByteBufferUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/field[@name='ERROR_CODE']"
		[Register ("ERROR_CODE")]
		public const int ErrorCode = (int) 10000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/api/utils/ByteBufferUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ByteBufferUtils); }
		}

		protected ByteBufferUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/constructor[@name='ByteBufferUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ByteBufferUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ByteBufferUtils)) {
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

		static IntPtr id_get_Ljava_nio_ByteBuffer_arrayBLcn_jiguang_api_JResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/method[@name='get' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='byte[]'] and parameter[3][@type='cn.jiguang.api.JResponse']]"
		[Register ("get", "(Ljava/nio/ByteBuffer;[BLcn/jiguang/api/JResponse;)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer Get (global::Java.Nio.ByteBuffer p0, byte[] p1, global::CN.Jiguang.Api.JResponse p2)
		{
			if (id_get_Ljava_nio_ByteBuffer_arrayBLcn_jiguang_api_JResponse_ == IntPtr.Zero)
				id_get_Ljava_nio_ByteBuffer_arrayBLcn_jiguang_api_JResponse_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/nio/ByteBuffer;[BLcn/jiguang/api/JResponse;)Ljava/nio/ByteBuffer;");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Java.Nio.ByteBuffer __ret = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_nio_ByteBuffer_arrayBLcn_jiguang_api_JResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_get_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='cn.jiguang.api.JResponse']]"
		[Register ("get", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)Ljava/lang/Byte;", "")]
		public static unsafe global::Java.Lang.Byte Get (global::Java.Nio.ByteBuffer p0, global::CN.Jiguang.Api.JResponse p1)
		{
			if (id_get_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_ == IntPtr.Zero)
				id_get_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)Ljava/lang/Byte;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Byte __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Byte> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInt_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='cn.jiguang.api.JResponse']]"
		[Register ("getInt", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)I", "")]
		public static unsafe int GetInt (global::Java.Nio.ByteBuffer p0, global::CN.Jiguang.Api.JResponse p1)
		{
			if (id_getInt_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_ == IntPtr.Zero)
				id_getInt_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_ = JNIEnv.GetStaticMethodID (class_ref, "getInt", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getInt_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLong_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/method[@name='getLong' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='cn.jiguang.api.JResponse']]"
		[Register ("getLong", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)J", "")]
		public static unsafe long GetLong (global::Java.Nio.ByteBuffer p0, global::CN.Jiguang.Api.JResponse p1)
		{
			if (id_getLong_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_ == IntPtr.Zero)
				id_getLong_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_ = JNIEnv.GetStaticMethodID (class_ref, "getLong", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getLong_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getShort_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ByteBufferUtils']/method[@name='getShort' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='cn.jiguang.api.JResponse']]"
		[Register ("getShort", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)S", "")]
		public static unsafe short GetShort (global::Java.Nio.ByteBuffer p0, global::CN.Jiguang.Api.JResponse p1)
		{
			if (id_getShort_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_ == IntPtr.Zero)
				id_getShort_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_ = JNIEnv.GetStaticMethodID (class_ref, "getShort", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)S");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				short __ret = JNIEnv.CallStaticShortMethod  (class_ref, id_getShort_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
