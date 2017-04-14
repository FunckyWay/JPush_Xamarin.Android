using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/DefaultPushNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class DefaultPushNotificationBuilder : global::Java.Lang.Object, global::CN.Jpush.Android.Api.IPushNotificationBuilder {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/api/DefaultPushNotificationBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultPushNotificationBuilder); }
		}

		protected DefaultPushNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']/constructor[@name='DefaultPushNotificationBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultPushNotificationBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DefaultPushNotificationBuilder)) {
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

		static Delegate cb_getDeveloperArg0;
#pragma warning disable 0169
		static Delegate GetGetDeveloperArg0Handler ()
		{
			if (cb_getDeveloperArg0 == null)
				cb_getDeveloperArg0 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeveloperArg0);
			return cb_getDeveloperArg0;
		}

		static IntPtr n_GetDeveloperArg0 (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeveloperArg0);
		}
#pragma warning restore 0169

		static IntPtr id_getDeveloperArg0;
		public virtual unsafe string DeveloperArg0 {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']/method[@name='getDeveloperArg0' and count(parameter)=0]"
			[Register ("getDeveloperArg0", "()Ljava/lang/String;", "GetGetDeveloperArg0Handler")]
			get {
				if (id_getDeveloperArg0 == IntPtr.Zero)
					id_getDeveloperArg0 = JNIEnv.GetMethodID (class_ref, "getDeveloperArg0", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getDeveloperArg0), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeveloperArg0", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_buildNotification_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetBuildNotification_Ljava_util_Map_Handler ()
		{
			if (cb_buildNotification_Ljava_util_Map_ == null)
				cb_buildNotification_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildNotification_Ljava_util_Map_);
			return cb_buildNotification_Ljava_util_Map_;
		}

		static IntPtr n_BuildNotification_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildNotification (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildNotification_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='DefaultPushNotificationBuilder']/method[@name='buildNotification' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("buildNotification", "(Ljava/util/Map;)Landroid/app/Notification;", "GetBuildNotification_Ljava_util_Map_Handler")]
		public virtual unsafe global::Android.App.Notification BuildNotification (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_buildNotification_Ljava_util_Map_ == IntPtr.Zero)
				id_buildNotification_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "buildNotification", "(Ljava/util/Map;)Landroid/app/Notification;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.App.Notification __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallObjectMethod  (Handle, id_buildNotification_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildNotification", "(Ljava/util/Map;)Landroid/app/Notification;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
