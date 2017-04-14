using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='MultiActionsNotificationBuilder']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/MultiActionsNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class MultiActionsNotificationBuilder : global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder {


		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='MultiActionsNotificationBuilder']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/api/MultiActionsNotificationBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiActionsNotificationBuilder); }
		}

		protected MultiActionsNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='MultiActionsNotificationBuilder']/constructor[@name='MultiActionsNotificationBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MultiActionsNotificationBuilder (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (MultiActionsNotificationBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_addJPushAction_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddJPushAction_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addJPushAction_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_addJPushAction_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_AddJPushAction_ILjava_lang_String_Ljava_lang_String_);
			return cb_addJPushAction_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_AddJPushAction_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jpush.Android.Api.MultiActionsNotificationBuilder __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.MultiActionsNotificationBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AddJPushAction (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addJPushAction_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='MultiActionsNotificationBuilder']/method[@name='addJPushAction' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("addJPushAction", "(ILjava/lang/String;Ljava/lang/String;)V", "GetAddJPushAction_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddJPushAction (int p0, string p1, string p2)
		{
			if (id_addJPushAction_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addJPushAction_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addJPushAction", "(ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addJPushAction_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addJPushAction", "(ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
