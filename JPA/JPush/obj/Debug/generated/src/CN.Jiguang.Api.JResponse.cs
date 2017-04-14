using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']"
	[global::Android.Runtime.Register ("cn/jiguang/api/JResponse", DoNotGenerateAcw=true)]
	public abstract partial class JResponse : global::CN.Jiguang.Api.JProtocol {


		static IntPtr code_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/field[@name='code']"
		[Register ("code")]
		public int Code {
			get {
				if (code_jfieldId == IntPtr.Zero)
					code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
				return JNIEnv.GetIntField (Handle, code_jfieldId);
			}
			set {
				if (code_jfieldId == IntPtr.Zero)
					code_jfieldId = JNIEnv.GetFieldID (class_ref, "code", "I");
				try {
					JNIEnv.SetField (Handle, code_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/api/JResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JResponse); }
		}

		protected JResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIJJILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/constructor[@name='JResponse' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(IIJJILjava/lang/String;)V", "")]
		public unsafe JResponse (int p0, int p1, long p2, long p3, int p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				if (GetType () != typeof (JResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIJJILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIJJILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_IIJJILjava_lang_String_ == IntPtr.Zero)
					id_ctor_IIJJILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIJJILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIJJILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIJJILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/constructor[@name='JResponse' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/nio/ByteBuffer;)V", "")]
		public unsafe JResponse (global::Java.Lang.Object p0, global::Java.Nio.ByteBuffer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (JResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Object;Ljava/nio/ByteBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Object;Ljava/nio/ByteBuffer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Object_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Object_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Object;Ljava/nio/ByteBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Object_Ljava_nio_ByteBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Object_Ljava_nio_ByteBuffer_, __args);
			} finally {
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
			global::CN.Jiguang.Api.JResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ParseBody ();
		}
#pragma warning restore 0169

		static IntPtr id_parseBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/method[@name='parseBody' and count(parameter)=0]"
		[Register ("parseBody", "()V", "GetParseBodyHandler")]
		protected override unsafe void ParseBody ()
		{
			if (id_parseBody == IntPtr.Zero)
				id_parseBody = JNIEnv.GetMethodID (class_ref, "parseBody", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_parseBody);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseBody", "()V"));
			} finally {
			}
		}

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
			global::CN.Jiguang.Api.JResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteBody ();
		}
#pragma warning restore 0169

		static IntPtr id_writeBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JResponse']/method[@name='writeBody' and count(parameter)=0]"
		[Register ("writeBody", "()V", "GetWriteBodyHandler")]
		protected override unsafe void WriteBody ()
		{
			if (id_writeBody == IntPtr.Zero)
				id_writeBody = JNIEnv.GetMethodID (class_ref, "writeBody", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_writeBody);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeBody", "()V"));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/jiguang/api/JResponse", DoNotGenerateAcw=true)]
	internal partial class JResponseInvoker : JResponse {

		public JResponseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (JResponseInvoker); }
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

	}

}
