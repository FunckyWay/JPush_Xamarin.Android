using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.jpush.android.api']/interface[@name='PushNotificationBuilder']"
	[Register ("cn/jpush/android/api/PushNotificationBuilder", "", "CN.Jpush.Android.Api.IPushNotificationBuilderInvoker")]
	public partial interface IPushNotificationBuilder : IJavaObject {

		string DeveloperArg0 {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/interface[@name='PushNotificationBuilder']/method[@name='getDeveloperArg0' and count(parameter)=0]"
			[Register ("getDeveloperArg0", "()Ljava/lang/String;", "GetGetDeveloperArg0Handler:CN.Jpush.Android.Api.IPushNotificationBuilderInvoker, JPush")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/interface[@name='PushNotificationBuilder']/method[@name='buildNotification' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("buildNotification", "(Ljava/util/Map;)Landroid/app/Notification;", "GetBuildNotification_Ljava_util_Map_Handler:CN.Jpush.Android.Api.IPushNotificationBuilderInvoker, JPush")]
		global::Android.App.Notification BuildNotification (global::System.Collections.Generic.IDictionary<string, string> p0);

	}

	[global::Android.Runtime.Register ("cn/jpush/android/api/PushNotificationBuilder", DoNotGenerateAcw=true)]
	internal class IPushNotificationBuilderInvoker : global::Java.Lang.Object, IPushNotificationBuilder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/jpush/android/api/PushNotificationBuilder");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IPushNotificationBuilderInvoker); }
		}

		IntPtr class_ref;

		public static IPushNotificationBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPushNotificationBuilder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.jpush.android.api.PushNotificationBuilder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushNotificationBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::CN.Jpush.Android.Api.IPushNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.IPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeveloperArg0);
		}
#pragma warning restore 0169

		IntPtr id_getDeveloperArg0;
		public unsafe string DeveloperArg0 {
			get {
				if (id_getDeveloperArg0 == IntPtr.Zero)
					id_getDeveloperArg0 = JNIEnv.GetMethodID (class_ref, "getDeveloperArg0", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (Handle, id_getDeveloperArg0), JniHandleOwnership.TransferLocalRef);
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
			global::CN.Jpush.Android.Api.IPushNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.IPushNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildNotification (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_buildNotification_Ljava_util_Map_;
		public unsafe global::Android.App.Notification BuildNotification (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_buildNotification_Ljava_util_Map_ == IntPtr.Zero)
				id_buildNotification_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "buildNotification", "(Ljava/util/Map;)Landroid/app/Notification;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.App.Notification __ret = global::Java.Lang.Object.GetObject<global::Android.App.Notification> (JNIEnv.CallObjectMethod (Handle, id_buildNotification_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
