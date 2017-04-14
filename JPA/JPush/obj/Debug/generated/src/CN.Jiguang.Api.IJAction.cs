using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAction']"
	[Register ("cn/jiguang/api/JAction", "", "CN.Jiguang.Api.IJActionInvoker")]
	public partial interface IJAction : IJavaObject {

		string SdkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAction']/method[@name='getSdkVersion' and count(parameter)=0]"
			[Register ("getSdkVersion", "()Ljava/lang/String;", "GetGetSdkVersionHandler:CN.Jiguang.Api.IJActionInvoker, JPush")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAction']/method[@name='dispatchMessage' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.nio.ByteBuffer']]"
		[Register ("dispatchMessage", "(Landroid/content/Context;JILjava/lang/Object;Ljava/nio/ByteBuffer;)J", "GetDispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_Handler:CN.Jiguang.Api.IJActionInvoker, JPush")]
		long DispatchMessage (global::Android.Content.Context p0, long p1, int p2, global::Java.Lang.Object p3, global::Java.Nio.ByteBuffer p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAction']/method[@name='dispatchTimeOutMessage' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
		[Register ("dispatchTimeOutMessage", "(Landroid/content/Context;JJI)V", "GetDispatchTimeOutMessage_Landroid_content_Context_JJIHandler:CN.Jiguang.Api.IJActionInvoker, JPush")]
		void DispatchTimeOutMessage (global::Android.Content.Context p0, long p1, long p2, int p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAction']/method[@name='getBinderByType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBinderByType", "(Ljava/lang/String;)Landroid/os/IBinder;", "GetGetBinderByType_Ljava_lang_String_Handler:CN.Jiguang.Api.IJActionInvoker, JPush")]
		global::Android.OS.IBinder GetBinderByType (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAction']/method[@name='handleMessage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.Object']]"
		[Register ("handleMessage", "(Landroid/content/Context;JLjava/lang/Object;)V", "GetHandleMessage_Landroid_content_Context_JLjava_lang_Object_Handler:CN.Jiguang.Api.IJActionInvoker, JPush")]
		void HandleMessage (global::Android.Content.Context p0, long p1, global::Java.Lang.Object p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAction']/method[@name='isSupportedCMD' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSupportedCMD", "(I)Z", "GetIsSupportedCMD_IHandler:CN.Jiguang.Api.IJActionInvoker, JPush")]
		bool IsSupportedCMD (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAction']/method[@name='onActionRun' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='java.lang.Object']]"
		[Register ("onActionRun", "(Landroid/content/Context;JLandroid/os/Bundle;Ljava/lang/Object;)V", "GetOnActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_Handler:CN.Jiguang.Api.IJActionInvoker, JPush")]
		void OnActionRun (global::Android.Content.Context p0, long p1, global::Android.OS.Bundle p2, global::Java.Lang.Object p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAction']/method[@name='onEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("onEvent", "(Landroid/content/Context;JI)V", "GetOnEvent_Landroid_content_Context_JIHandler:CN.Jiguang.Api.IJActionInvoker, JPush")]
		void OnEvent (global::Android.Content.Context p0, long p1, int p2);

	}

	[global::Android.Runtime.Register ("cn/jiguang/api/JAction", DoNotGenerateAcw=true)]
	internal class IJActionInvoker : global::Java.Lang.Object, IJAction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/jiguang/api/JAction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IJActionInvoker); }
		}

		IntPtr class_ref;

		public static IJAction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJAction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.jiguang.api.JAction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJActionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getSdkVersion;
#pragma warning disable 0169
		static Delegate GetGetSdkVersionHandler ()
		{
			if (cb_getSdkVersion == null)
				cb_getSdkVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSdkVersion);
			return cb_getSdkVersion;
		}

		static IntPtr n_GetSdkVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.IJAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SdkVersion);
		}
#pragma warning restore 0169

		IntPtr id_getSdkVersion;
		public unsafe string SdkVersion {
			get {
				if (id_getSdkVersion == IntPtr.Zero)
					id_getSdkVersion = JNIEnv.GetMethodID (class_ref, "getSdkVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getSdkVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_dispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetDispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_dispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_ == null)
				cb_dispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, int, IntPtr, IntPtr, long>) n_DispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_);
			return cb_dispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_;
		}

		static long n_DispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::CN.Jiguang.Api.IJAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.ByteBuffer p4 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p4, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.DispatchMessage (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_dispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_;
		public unsafe long DispatchMessage (global::Android.Content.Context p0, long p1, int p2, global::Java.Lang.Object p3, global::Java.Nio.ByteBuffer p4)
		{
			if (id_dispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_dispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_ = JNIEnv.GetMethodID (class_ref, "dispatchMessage", "(Landroid/content/Context;JILjava/lang/Object;Ljava/nio/ByteBuffer;)J");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			long __ret = JNIEnv.CallLongMethod (Handle, id_dispatchMessage_Landroid_content_Context_JILjava_lang_Object_Ljava_nio_ByteBuffer_, __args);
			return __ret;
		}

		static Delegate cb_dispatchTimeOutMessage_Landroid_content_Context_JJI;
#pragma warning disable 0169
		static Delegate GetDispatchTimeOutMessage_Landroid_content_Context_JJIHandler ()
		{
			if (cb_dispatchTimeOutMessage_Landroid_content_Context_JJI == null)
				cb_dispatchTimeOutMessage_Landroid_content_Context_JJI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long, int>) n_DispatchTimeOutMessage_Landroid_content_Context_JJI);
			return cb_dispatchTimeOutMessage_Landroid_content_Context_JJI;
		}

		static void n_DispatchTimeOutMessage_Landroid_content_Context_JJI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, int p3)
		{
			global::CN.Jiguang.Api.IJAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchTimeOutMessage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_dispatchTimeOutMessage_Landroid_content_Context_JJI;
		public unsafe void DispatchTimeOutMessage (global::Android.Content.Context p0, long p1, long p2, int p3)
		{
			if (id_dispatchTimeOutMessage_Landroid_content_Context_JJI == IntPtr.Zero)
				id_dispatchTimeOutMessage_Landroid_content_Context_JJI = JNIEnv.GetMethodID (class_ref, "dispatchTimeOutMessage", "(Landroid/content/Context;JJI)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_dispatchTimeOutMessage_Landroid_content_Context_JJI, __args);
		}

		static Delegate cb_getBinderByType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBinderByType_Ljava_lang_String_Handler ()
		{
			if (cb_getBinderByType_Ljava_lang_String_ == null)
				cb_getBinderByType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBinderByType_Ljava_lang_String_);
			return cb_getBinderByType_Ljava_lang_String_;
		}

		static IntPtr n_GetBinderByType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Api.IJAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBinderByType (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getBinderByType_Ljava_lang_String_;
		public unsafe global::Android.OS.IBinder GetBinderByType (string p0)
		{
			if (id_getBinderByType_Ljava_lang_String_ == IntPtr.Zero)
				id_getBinderByType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBinderByType", "(Ljava/lang/String;)Landroid/os/IBinder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.OS.IBinder __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (Handle, id_getBinderByType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_handleMessage_Landroid_content_Context_JLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetHandleMessage_Landroid_content_Context_JLjava_lang_Object_Handler ()
		{
			if (cb_handleMessage_Landroid_content_Context_JLjava_lang_Object_ == null)
				cb_handleMessage_Landroid_content_Context_JLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_HandleMessage_Landroid_content_Context_JLjava_lang_Object_);
			return cb_handleMessage_Landroid_content_Context_JLjava_lang_Object_;
		}

		static void n_HandleMessage_Landroid_content_Context_JLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.IJAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.HandleMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_handleMessage_Landroid_content_Context_JLjava_lang_Object_;
		public unsafe void HandleMessage (global::Android.Content.Context p0, long p1, global::Java.Lang.Object p2)
		{
			if (id_handleMessage_Landroid_content_Context_JLjava_lang_Object_ == IntPtr.Zero)
				id_handleMessage_Landroid_content_Context_JLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "handleMessage", "(Landroid/content/Context;JLjava/lang/Object;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_handleMessage_Landroid_content_Context_JLjava_lang_Object_, __args);
		}

		static Delegate cb_isSupportedCMD_I;
#pragma warning disable 0169
		static Delegate GetIsSupportedCMD_IHandler ()
		{
			if (cb_isSupportedCMD_I == null)
				cb_isSupportedCMD_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsSupportedCMD_I);
			return cb_isSupportedCMD_I;
		}

		static bool n_IsSupportedCMD_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Api.IJAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupportedCMD (p0);
		}
#pragma warning restore 0169

		IntPtr id_isSupportedCMD_I;
		public unsafe bool IsSupportedCMD (int p0)
		{
			if (id_isSupportedCMD_I == IntPtr.Zero)
				id_isSupportedCMD_I = JNIEnv.GetMethodID (class_ref, "isSupportedCMD", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (Handle, id_isSupportedCMD_I, __args);
		}

		static Delegate cb_onActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_Handler ()
		{
			if (cb_onActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_ == null)
				cb_onActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_OnActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_);
			return cb_onActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_;
		}

		static void n_OnActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::CN.Jiguang.Api.IJAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnActionRun (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_;
		public unsafe void OnActionRun (global::Android.Content.Context p0, long p1, global::Android.OS.Bundle p2, global::Java.Lang.Object p3)
		{
			if (id_onActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_ == IntPtr.Zero)
				id_onActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onActionRun", "(Landroid/content/Context;JLandroid/os/Bundle;Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (Handle, id_onActionRun_Landroid_content_Context_JLandroid_os_Bundle_Ljava_lang_Object_, __args);
		}

		static Delegate cb_onEvent_Landroid_content_Context_JI;
#pragma warning disable 0169
		static Delegate GetOnEvent_Landroid_content_Context_JIHandler ()
		{
			if (cb_onEvent_Landroid_content_Context_JI == null)
				cb_onEvent_Landroid_content_Context_JI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, int>) n_OnEvent_Landroid_content_Context_JI);
			return cb_onEvent_Landroid_content_Context_JI;
		}

		static void n_OnEvent_Landroid_content_Context_JI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, int p2)
		{
			global::CN.Jiguang.Api.IJAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onEvent_Landroid_content_Context_JI;
		public unsafe void OnEvent (global::Android.Content.Context p0, long p1, int p2)
		{
			if (id_onEvent_Landroid_content_Context_JI == IntPtr.Zero)
				id_onEvent_Landroid_content_Context_JI = JNIEnv.GetMethodID (class_ref, "onEvent", "(Landroid/content/Context;JI)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (Handle, id_onEvent_Landroid_content_Context_JI, __args);
		}

	}

}
