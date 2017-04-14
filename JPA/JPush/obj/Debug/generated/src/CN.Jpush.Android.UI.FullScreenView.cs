using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']"
	[global::Android.Runtime.Register ("cn/jpush/android/ui/FullScreenView", DoNotGenerateAcw=true)]
	public partial class FullScreenView : global::Android.Widget.LinearLayout {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/ui/FullScreenView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FullScreenView); }
		}

		protected FullScreenView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/constructor[@name='FullScreenView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe FullScreenView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (FullScreenView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static Delegate cb_destory;
#pragma warning disable 0169
		static Delegate GetDestoryHandler ()
		{
			if (cb_destory == null)
				cb_destory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destory);
			return cb_destory;
		}

		static void n_Destory (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destory ();
		}
#pragma warning restore 0169

		static IntPtr id_destory;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='destory' and count(parameter)=0]"
		[Register ("destory", "()V", "GetDestoryHandler")]
		public virtual unsafe void Destory ()
		{
			if (id_destory == IntPtr.Zero)
				id_destory = JNIEnv.GetMethodID (class_ref, "destory", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_destory);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destory", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadUrl_Ljava_lang_String_Handler ()
		{
			if (cb_loadUrl_Ljava_lang_String_ == null)
				cb_loadUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadUrl_Ljava_lang_String_);
			return cb_loadUrl_Ljava_lang_String_;
		}

		static void n_LoadUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrl (p0);
		}
#pragma warning restore 0169

		static IntPtr id_loadUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='loadUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadUrl", "(Ljava/lang/String;)V", "GetLoadUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void LoadUrl (string p0)
		{
			if (id_loadUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_loadUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadUrl", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_loadUrl_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadUrl", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		static IntPtr id_pause;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_pause);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "pause", "()V"));
			} finally {
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		static IntPtr id_resume;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			if (id_resume == IntPtr.Zero)
				id_resume = JNIEnv.GetMethodID (class_ref, "resume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_resume);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resume", "()V"));
			} finally {
			}
		}

		static Delegate cb_showTitleBar;
#pragma warning disable 0169
		static Delegate GetShowTitleBarHandler ()
		{
			if (cb_showTitleBar == null)
				cb_showTitleBar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowTitleBar);
			return cb_showTitleBar;
		}

		static void n_ShowTitleBar (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowTitleBar ();
		}
#pragma warning restore 0169

		static IntPtr id_showTitleBar;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='showTitleBar' and count(parameter)=0]"
		[Register ("showTitleBar", "()V", "GetShowTitleBarHandler")]
		public virtual unsafe void ShowTitleBar ()
		{
			if (id_showTitleBar == IntPtr.Zero)
				id_showTitleBar = JNIEnv.GetMethodID (class_ref, "showTitleBar", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_showTitleBar);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showTitleBar", "()V"));
			} finally {
			}
		}

		static Delegate cb_webviewCanGoBack;
#pragma warning disable 0169
		static Delegate GetWebviewCanGoBackHandler ()
		{
			if (cb_webviewCanGoBack == null)
				cb_webviewCanGoBack = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_WebviewCanGoBack);
			return cb_webviewCanGoBack;
		}

		static bool n_WebviewCanGoBack (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WebviewCanGoBack ();
		}
#pragma warning restore 0169

		static IntPtr id_webviewCanGoBack;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='webviewCanGoBack' and count(parameter)=0]"
		[Register ("webviewCanGoBack", "()Z", "GetWebviewCanGoBackHandler")]
		public virtual unsafe bool WebviewCanGoBack ()
		{
			if (id_webviewCanGoBack == IntPtr.Zero)
				id_webviewCanGoBack = JNIEnv.GetMethodID (class_ref, "webviewCanGoBack", "()Z");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_webviewCanGoBack);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "webviewCanGoBack", "()Z"));
			} finally {
			}
		}

		static Delegate cb_webviewGoBack;
#pragma warning disable 0169
		static Delegate GetWebviewGoBackHandler ()
		{
			if (cb_webviewGoBack == null)
				cb_webviewGoBack = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WebviewGoBack);
			return cb_webviewGoBack;
		}

		static void n_WebviewGoBack (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.UI.FullScreenView __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.UI.FullScreenView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WebviewGoBack ();
		}
#pragma warning restore 0169

		static IntPtr id_webviewGoBack;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='FullScreenView']/method[@name='webviewGoBack' and count(parameter)=0]"
		[Register ("webviewGoBack", "()V", "GetWebviewGoBackHandler")]
		public virtual unsafe void WebviewGoBack ()
		{
			if (id_webviewGoBack == IntPtr.Zero)
				id_webviewGoBack = JNIEnv.GetMethodID (class_ref, "webviewGoBack", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_webviewGoBack);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "webviewGoBack", "()V"));
			} finally {
			}
		}

	}
}
