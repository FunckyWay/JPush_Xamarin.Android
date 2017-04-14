using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAnalyticsAction']"
	[Register ("cn/jiguang/api/JAnalyticsAction", "", "CN.Jiguang.Api.IJAnalyticsActionInvoker")]
	public partial interface IJAnalyticsAction : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAnalyticsAction']/method[@name='dispatchPause' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("dispatchPause", "(Landroid/content/Context;)V", "GetDispatchPause_Landroid_content_Context_Handler:CN.Jiguang.Api.IJAnalyticsActionInvoker, JPush")]
		void DispatchPause (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAnalyticsAction']/method[@name='dispatchResume' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("dispatchResume", "(Landroid/content/Context;)V", "GetDispatchResume_Landroid_content_Context_Handler:CN.Jiguang.Api.IJAnalyticsActionInvoker, JPush")]
		void DispatchResume (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/interface[@name='JAnalyticsAction']/method[@name='dispatchStatus' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("dispatchStatus", "(Landroid/content/Context;Ljava/lang/String;)V", "GetDispatchStatus_Landroid_content_Context_Ljava_lang_String_Handler:CN.Jiguang.Api.IJAnalyticsActionInvoker, JPush")]
		void DispatchStatus (global::Android.Content.Context p0, string p1);

	}

	[global::Android.Runtime.Register ("cn/jiguang/api/JAnalyticsAction", DoNotGenerateAcw=true)]
	internal class IJAnalyticsActionInvoker : global::Java.Lang.Object, IJAnalyticsAction {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/jiguang/api/JAnalyticsAction");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IJAnalyticsActionInvoker); }
		}

		IntPtr class_ref;

		public static IJAnalyticsAction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJAnalyticsAction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.jiguang.api.JAnalyticsAction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJAnalyticsActionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_dispatchPause_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDispatchPause_Landroid_content_Context_Handler ()
		{
			if (cb_dispatchPause_Landroid_content_Context_ == null)
				cb_dispatchPause_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchPause_Landroid_content_Context_);
			return cb_dispatchPause_Landroid_content_Context_;
		}

		static void n_DispatchPause_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Api.IJAnalyticsAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAnalyticsAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchPause (p0);
		}
#pragma warning restore 0169

		IntPtr id_dispatchPause_Landroid_content_Context_;
		public unsafe void DispatchPause (global::Android.Content.Context p0)
		{
			if (id_dispatchPause_Landroid_content_Context_ == IntPtr.Zero)
				id_dispatchPause_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "dispatchPause", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_dispatchPause_Landroid_content_Context_, __args);
		}

		static Delegate cb_dispatchResume_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDispatchResume_Landroid_content_Context_Handler ()
		{
			if (cb_dispatchResume_Landroid_content_Context_ == null)
				cb_dispatchResume_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DispatchResume_Landroid_content_Context_);
			return cb_dispatchResume_Landroid_content_Context_;
		}

		static void n_DispatchResume_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Api.IJAnalyticsAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAnalyticsAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DispatchResume (p0);
		}
#pragma warning restore 0169

		IntPtr id_dispatchResume_Landroid_content_Context_;
		public unsafe void DispatchResume (global::Android.Content.Context p0)
		{
			if (id_dispatchResume_Landroid_content_Context_ == IntPtr.Zero)
				id_dispatchResume_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "dispatchResume", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (Handle, id_dispatchResume_Landroid_content_Context_, __args);
		}

		static Delegate cb_dispatchStatus_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDispatchStatus_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_dispatchStatus_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_dispatchStatus_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DispatchStatus_Landroid_content_Context_Ljava_lang_String_);
			return cb_dispatchStatus_Landroid_content_Context_Ljava_lang_String_;
		}

		static void n_DispatchStatus_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.IJAnalyticsAction __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.IJAnalyticsAction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DispatchStatus (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_dispatchStatus_Landroid_content_Context_Ljava_lang_String_;
		public unsafe void DispatchStatus (global::Android.Content.Context p0, string p1)
		{
			if (id_dispatchStatus_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_dispatchStatus_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "dispatchStatus", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (Handle, id_dispatchStatus_Landroid_content_Context_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
