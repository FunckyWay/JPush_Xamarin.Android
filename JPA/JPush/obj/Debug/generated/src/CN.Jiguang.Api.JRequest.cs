using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JRequest']"
	[global::Android.Runtime.Register ("cn/jiguang/api/JRequest", DoNotGenerateAcw=true)]
	public abstract partial class JRequest : global::CN.Jiguang.Api.JProtocol {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/api/JRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JRequest); }
		}

		protected JRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IIJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JRequest']/constructor[@name='JRequest' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register (".ctor", "(IIJ)V", "")]
		public unsafe JRequest (int p0, int p1, long p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (JRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(IIJ)V", __args);
					return;
				}

				if (id_ctor_IIJ == IntPtr.Zero)
					id_ctor_IIJ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IIJ, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Object_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JRequest']/constructor[@name='JRequest' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.nio.ByteBuffer']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/nio/ByteBuffer;)V", "")]
		public unsafe JRequest (global::Java.Lang.Object p0, global::Java.Nio.ByteBuffer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (JRequest)) {
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

		static Delegate cb_setJuid_J;
#pragma warning disable 0169
		static Delegate GetSetJuid_JHandler ()
		{
			if (cb_setJuid_J == null)
				cb_setJuid_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetJuid_J);
			return cb_setJuid_J;
		}

		static void n_SetJuid_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jiguang.Api.JRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetJuid (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setJuid_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JRequest']/method[@name='setJuid' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setJuid", "(J)V", "GetSetJuid_JHandler")]
		public virtual unsafe void SetJuid (long p0)
		{
			if (id_setJuid_J == IntPtr.Zero)
				id_setJuid_J = JNIEnv.GetMethodID (class_ref, "setJuid", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setJuid_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setJuid", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSid_I;
#pragma warning disable 0169
		static Delegate GetSetSid_IHandler ()
		{
			if (cb_setSid_I == null)
				cb_setSid_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSid_I);
			return cb_setSid_I;
		}

		static void n_SetSid_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.JRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.JRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSid (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSid_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JRequest']/method[@name='setSid' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSid", "(I)V", "GetSetSid_IHandler")]
		public virtual unsafe void SetSid (int p0)
		{
			if (id_setSid_I == IntPtr.Zero)
				id_setSid_I = JNIEnv.GetMethodID (class_ref, "setSid", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setSid_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSid", "(I)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("cn/jiguang/api/JRequest", DoNotGenerateAcw=true)]
	internal partial class JRequestInvoker : JRequest {

		public JRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (JRequestInvoker); }
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
