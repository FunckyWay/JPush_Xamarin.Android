using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']"
	[global::Android.Runtime.Register ("cn/jiguang/api/utils/ProtocolUtil", DoNotGenerateAcw=true)]
	public partial class ProtocolUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/api/utils/ProtocolUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProtocolUtil); }
		}

		protected ProtocolUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/constructor[@name='ProtocolUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProtocolUtil ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ProtocolUtil)) {
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

		static IntPtr id_fillIntData_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='fillIntData' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("fillIntData", "([BII)V", "")]
		public static unsafe void FillIntData (byte[] p0, int p1, int p2)
		{
			if (id_fillIntData_arrayBII == IntPtr.Zero)
				id_fillIntData_arrayBII = JNIEnv.GetStaticMethodID (class_ref, "fillIntData", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fillIntData_arrayBII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_fillStringData_arrayBLjava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='fillStringData' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("fillStringData", "([BLjava/lang/String;I)V", "")]
		public static unsafe void FillStringData (byte[] p0, string p1, int p2)
		{
			if (id_fillStringData_arrayBLjava_lang_String_I == IntPtr.Zero)
				id_fillStringData_arrayBLjava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "fillStringData", "([BLjava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_fillStringData_arrayBLjava_lang_String_I, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_fixedStringToBytes_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='fixedStringToBytes' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("fixedStringToBytes", "(Ljava/lang/String;I)[B", "")]
		public static unsafe byte[] FixedStringToBytes (string p0, int p1)
		{
			if (id_fixedStringToBytes_Ljava_lang_String_I == IntPtr.Zero)
				id_fixedStringToBytes_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "fixedStringToBytes", "(Ljava/lang/String;I)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_fixedStringToBytes_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getBytes_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getBytes' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getBytes", "(Ljava/nio/ByteBuffer;)[B", "")]
		public static unsafe byte[] GetBytes (global::Java.Nio.ByteBuffer p0)
		{
			if (id_getBytes_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_getBytes_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getBytes", "(Ljava/nio/ByteBuffer;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytes_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBytesConsumed_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getBytesConsumed' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getBytesConsumed", "(Ljava/nio/ByteBuffer;)[B", "")]
		public static unsafe byte[] GetBytesConsumed (global::Java.Nio.ByteBuffer p0)
		{
			if (id_getBytesConsumed_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_getBytesConsumed_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getBytesConsumed", "(Ljava/nio/ByteBuffer;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBytesConsumed_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDefaultByte_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getDefaultByte' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDefaultByte", "(I)[B", "")]
		public static unsafe byte[] GetDefaultByte (int p0)
		{
			if (id_getDefaultByte_I == IntPtr.Zero)
				id_getDefaultByte_I = JNIEnv.GetStaticMethodID (class_ref, "getDefaultByte", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDefaultByte_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getString_Ljava_nio_ByteBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("getString", "(Ljava/nio/ByteBuffer;I)Ljava/lang/String;", "")]
		public static unsafe string GetString (global::Java.Nio.ByteBuffer p0, int p1)
		{
			if (id_getString_Ljava_nio_ByteBuffer_I == IntPtr.Zero)
				id_getString_Ljava_nio_ByteBuffer_I = JNIEnv.GetStaticMethodID (class_ref, "getString", "(Ljava/nio/ByteBuffer;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getString_Ljava_nio_ByteBuffer_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTlv2_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getTlv2' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getTlv2", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;", "")]
		public static unsafe string GetTlv2 (global::Java.Nio.ByteBuffer p0)
		{
			if (id_getTlv2_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_getTlv2_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "getTlv2", "(Ljava/nio/ByteBuffer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTlv2_Ljava_nio_ByteBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getTlv2_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='getTlv2' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='cn.jiguang.api.JResponse']]"
		[Register ("getTlv2", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)Ljava/lang/String;", "")]
		public static unsafe string GetTlv2 (global::Java.Nio.ByteBuffer p0, global::CN.Jiguang.Api.JResponse p1)
		{
			if (id_getTlv2_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_ == IntPtr.Zero)
				id_getTlv2_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_ = JNIEnv.GetStaticMethodID (class_ref, "getTlv2", "(Ljava/nio/ByteBuffer;Lcn/jiguang/api/JResponse;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTlv2_Ljava_nio_ByteBuffer_Lcn_jiguang_api_JResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_int2ByteArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='int2ByteArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("int2ByteArray", "(I)[B", "")]
		public static unsafe byte[] Int2ByteArray (int p0)
		{
			if (id_int2ByteArray_I == IntPtr.Zero)
				id_int2ByteArray_I = JNIEnv.GetStaticMethodID (class_ref, "int2ByteArray", "(I)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_int2ByteArray_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_long2ByteArray_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='long2ByteArray' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("long2ByteArray", "(J)[B", "")]
		public static unsafe byte[] Long2ByteArray (long p0)
		{
			if (id_long2ByteArray_J == IntPtr.Zero)
				id_long2ByteArray_J = JNIEnv.GetStaticMethodID (class_ref, "long2ByteArray", "(J)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_long2ByteArray_J, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_main_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='main' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("main", "([Ljava/lang/String;)V", "")]
		public static unsafe void Main (string[] p0)
		{
			if (id_main_arrayLjava_lang_String_ == IntPtr.Zero)
				id_main_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "main", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_main_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_short2ByteArray_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='short2ByteArray' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("short2ByteArray", "(S)[B", "")]
		public static unsafe byte[] Short2ByteArray (short p0)
		{
			if (id_short2ByteArray_S == IntPtr.Zero)
				id_short2ByteArray_S = JNIEnv.GetStaticMethodID (class_ref, "short2ByteArray", "(S)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_short2ByteArray_S, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_tlv2ToByteArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api.utils']/class[@name='ProtocolUtil']/method[@name='tlv2ToByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("tlv2ToByteArray", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] Tlv2ToByteArray (string p0)
		{
			if (id_tlv2ToByteArray_Ljava_lang_String_ == IntPtr.Zero)
				id_tlv2ToByteArray_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "tlv2ToByteArray", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_tlv2ToByteArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
