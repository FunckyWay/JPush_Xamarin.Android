using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='DownloadService']"
	[global::Android.Runtime.Register ("cn/jpush/android/service/DownloadService", DoNotGenerateAcw=true)]
	public partial class DownloadService : global::Android.App.IntentService {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/service/DownloadService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DownloadService); }
		}

		protected DownloadService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='DownloadService']/constructor[@name='DownloadService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DownloadService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DownloadService)) {
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

		static Delegate cb_onHandleIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnHandleIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_onHandleIntent_Landroid_content_Intent_ == null)
				cb_onHandleIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnHandleIntent_Landroid_content_Intent_);
			return cb_onHandleIntent_Landroid_content_Intent_;
		}

		static void n_OnHandleIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Service.DownloadService __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Service.DownloadService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnHandleIntent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onHandleIntent_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='DownloadService']/method[@name='onHandleIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onHandleIntent", "(Landroid/content/Intent;)V", "GetOnHandleIntent_Landroid_content_Intent_Handler")]
		protected override unsafe void OnHandleIntent (global::Android.Content.Intent p0)
		{
			if (id_onHandleIntent_Landroid_content_Intent_ == IntPtr.Zero)
				id_onHandleIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onHandleIntent", "(Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onHandleIntent_Landroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onHandleIntent", "(Landroid/content/Intent;)V"), __args);
			} finally {
			}
		}

	}
}
