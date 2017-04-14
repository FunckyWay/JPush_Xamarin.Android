using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']"
	[global::Android.Runtime.Register ("cn/jpush/android/data/JPushLocalNotification", DoNotGenerateAcw=true)]
	public partial class JPushLocalNotification : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/data/JPushLocalNotification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JPushLocalNotification); }
		}

		protected JPushLocalNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/constructor[@name='JPushLocalNotification' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JPushLocalNotification ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JPushLocalNotification)) {
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

		static Delegate cb_getBroadcastTime;
#pragma warning disable 0169
		static Delegate GetGetBroadcastTimeHandler ()
		{
			if (cb_getBroadcastTime == null)
				cb_getBroadcastTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBroadcastTime);
			return cb_getBroadcastTime;
		}

		static long n_GetBroadcastTime (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BroadcastTime;
		}
#pragma warning restore 0169

		static Delegate cb_setBroadcastTime_J;
#pragma warning disable 0169
		static Delegate GetSetBroadcastTime_JHandler ()
		{
			if (cb_setBroadcastTime_J == null)
				cb_setBroadcastTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBroadcastTime_J);
			return cb_setBroadcastTime_J;
		}

		static void n_SetBroadcastTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BroadcastTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBroadcastTime;
		static IntPtr id_setBroadcastTime_J;
		public virtual unsafe long BroadcastTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getBroadcastTime' and count(parameter)=0]"
			[Register ("getBroadcastTime", "()J", "GetGetBroadcastTimeHandler")]
			get {
				if (id_getBroadcastTime == IntPtr.Zero)
					id_getBroadcastTime = JNIEnv.GetMethodID (class_ref, "getBroadcastTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getBroadcastTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBroadcastTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setBroadcastTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBroadcastTime", "(J)V", "GetSetBroadcastTime_JHandler")]
			set {
				if (id_setBroadcastTime_J == IntPtr.Zero)
					id_setBroadcastTime_J = JNIEnv.GetMethodID (class_ref, "setBroadcastTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBroadcastTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBroadcastTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBuilderId;
#pragma warning disable 0169
		static Delegate GetGetBuilderIdHandler ()
		{
			if (cb_getBuilderId == null)
				cb_getBuilderId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBuilderId);
			return cb_getBuilderId;
		}

		static long n_GetBuilderId (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BuilderId;
		}
#pragma warning restore 0169

		static Delegate cb_setBuilderId_J;
#pragma warning disable 0169
		static Delegate GetSetBuilderId_JHandler ()
		{
			if (cb_setBuilderId_J == null)
				cb_setBuilderId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBuilderId_J);
			return cb_setBuilderId_J;
		}

		static void n_SetBuilderId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BuilderId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBuilderId;
		static IntPtr id_setBuilderId_J;
		public virtual unsafe long BuilderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getBuilderId' and count(parameter)=0]"
			[Register ("getBuilderId", "()J", "GetGetBuilderIdHandler")]
			get {
				if (id_getBuilderId == IntPtr.Zero)
					id_getBuilderId = JNIEnv.GetMethodID (class_ref, "getBuilderId", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getBuilderId);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBuilderId", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setBuilderId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBuilderId", "(J)V", "GetSetBuilderId_JHandler")]
			set {
				if (id_setBuilderId_J == IntPtr.Zero)
					id_setBuilderId_J = JNIEnv.GetMethodID (class_ref, "setBuilderId", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBuilderId_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBuilderId", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContent;
#pragma warning disable 0169
		static Delegate GetGetContentHandler ()
		{
			if (cb_getContent == null)
				cb_getContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContent);
			return cb_getContent;
		}

		static IntPtr n_GetContent (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Content);
		}
#pragma warning restore 0169

		static Delegate cb_setContent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContent_Ljava_lang_String_Handler ()
		{
			if (cb_setContent_Ljava_lang_String_ == null)
				cb_setContent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContent_Ljava_lang_String_);
			return cb_setContent_Ljava_lang_String_;
		}

		static void n_SetContent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Content = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContent;
		static IntPtr id_setContent_Ljava_lang_String_;
		public virtual unsafe string Content {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getContent' and count(parameter)=0]"
			[Register ("getContent", "()Ljava/lang/String;", "GetGetContentHandler")]
			get {
				if (id_getContent == IntPtr.Zero)
					id_getContent = JNIEnv.GetMethodID (class_ref, "getContent", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getContent), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContent", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setContent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContent", "(Ljava/lang/String;)V", "GetSetContent_Ljava_lang_String_Handler")]
			set {
				if (id_setContent_Ljava_lang_String_ == IntPtr.Zero)
					id_setContent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContent", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setContent_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContent", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExtras;
#pragma warning disable 0169
		static Delegate GetGetExtrasHandler ()
		{
			if (cb_getExtras == null)
				cb_getExtras = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtras);
			return cb_getExtras;
		}

		static IntPtr n_GetExtras (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Extras);
		}
#pragma warning restore 0169

		static Delegate cb_setExtras_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExtras_Ljava_lang_String_Handler ()
		{
			if (cb_setExtras_Ljava_lang_String_ == null)
				cb_setExtras_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtras_Ljava_lang_String_);
			return cb_setExtras_Ljava_lang_String_;
		}

		static void n_SetExtras_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Extras = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExtras;
		static IntPtr id_setExtras_Ljava_lang_String_;
		public virtual unsafe string Extras {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getExtras' and count(parameter)=0]"
			[Register ("getExtras", "()Ljava/lang/String;", "GetGetExtrasHandler")]
			get {
				if (id_getExtras == IntPtr.Zero)
					id_getExtras = JNIEnv.GetMethodID (class_ref, "getExtras", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getExtras), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExtras", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setExtras' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExtras", "(Ljava/lang/String;)V", "GetSetExtras_Ljava_lang_String_Handler")]
			set {
				if (id_setExtras_Ljava_lang_String_ == IntPtr.Zero)
					id_setExtras_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExtras", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setExtras_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExtras", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNotificationId;
#pragma warning disable 0169
		static Delegate GetGetNotificationIdHandler ()
		{
			if (cb_getNotificationId == null)
				cb_getNotificationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNotificationId);
			return cb_getNotificationId;
		}

		static long n_GetNotificationId (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationId;
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationId_J;
#pragma warning disable 0169
		static Delegate GetSetNotificationId_JHandler ()
		{
			if (cb_setNotificationId_J == null)
				cb_setNotificationId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetNotificationId_J);
			return cb_setNotificationId_J;
		}

		static void n_SetNotificationId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotificationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationId;
		static IntPtr id_setNotificationId_J;
		public virtual unsafe long NotificationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getNotificationId' and count(parameter)=0]"
			[Register ("getNotificationId", "()J", "GetGetNotificationIdHandler")]
			get {
				if (id_getNotificationId == IntPtr.Zero)
					id_getNotificationId = JNIEnv.GetMethodID (class_ref, "getNotificationId", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getNotificationId);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationId", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setNotificationId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setNotificationId", "(J)V", "GetSetNotificationId_JHandler")]
			set {
				if (id_setNotificationId_J == IntPtr.Zero)
					id_setNotificationId_J = JNIEnv.GetMethodID (class_ref, "setNotificationId", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setNotificationId_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationId", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		static Delegate cb_setTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setTitle_Ljava_lang_String_ == null)
				cb_setTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTitle_Ljava_lang_String_);
			return cb_setTitle_Ljava_lang_String_;
		}

		static void n_SetTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Title = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTitle;
		static IntPtr id_setTitle_Ljava_lang_String_;
		public virtual unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setBroadcastTime_IIIIII;
#pragma warning disable 0169
		static Delegate GetSetBroadcastTime_IIIIIIHandler ()
		{
			if (cb_setBroadcastTime_IIIIII == null)
				cb_setBroadcastTime_IIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, int, int>) n_SetBroadcastTime_IIIIII);
			return cb_setBroadcastTime_IIIIII;
		}

		static void n_SetBroadcastTime_IIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBroadcastTime (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		static IntPtr id_setBroadcastTime_IIIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setBroadcastTime' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("setBroadcastTime", "(IIIIII)V", "GetSetBroadcastTime_IIIIIIHandler")]
		public virtual unsafe void SetBroadcastTime (int p0, int p1, int p2, int p3, int p4, int p5)
		{
			if (id_setBroadcastTime_IIIIII == IntPtr.Zero)
				id_setBroadcastTime_IIIIII = JNIEnv.GetMethodID (class_ref, "setBroadcastTime", "(IIIIII)V");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBroadcastTime_IIIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBroadcastTime", "(IIIIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBroadcastTime_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetBroadcastTime_Ljava_util_Date_Handler ()
		{
			if (cb_setBroadcastTime_Ljava_util_Date_ == null)
				cb_setBroadcastTime_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBroadcastTime_Ljava_util_Date_);
			return cb_setBroadcastTime_Ljava_util_Date_;
		}

		static void n_SetBroadcastTime_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBroadcastTime (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBroadcastTime_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='setBroadcastTime' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("setBroadcastTime", "(Ljava/util/Date;)V", "GetSetBroadcastTime_Ljava_util_Date_Handler")]
		public virtual unsafe void SetBroadcastTime (global::Java.Util.Date p0)
		{
			if (id_setBroadcastTime_Ljava_util_Date_ == IntPtr.Zero)
				id_setBroadcastTime_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setBroadcastTime", "(Ljava/util/Date;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBroadcastTime_Ljava_util_Date_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBroadcastTime", "(Ljava/util/Date;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toJSON;
#pragma warning disable 0169
		static Delegate GetToJSONHandler ()
		{
			if (cb_toJSON == null)
				cb_toJSON = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJSON);
			return cb_toJSON;
		}

		static IntPtr n_ToJSON (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jpush.Android.Data.JPushLocalNotification __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Data.JPushLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToJSON ());
		}
#pragma warning restore 0169

		static IntPtr id_toJSON;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.data']/class[@name='JPushLocalNotification']/method[@name='toJSON' and count(parameter)=0]"
		[Register ("toJSON", "()Ljava/lang/String;", "GetToJSONHandler")]
		public virtual unsafe string ToJSON ()
		{
			if (id_toJSON == IntPtr.Zero)
				id_toJSON = JNIEnv.GetMethodID (class_ref, "toJSON", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_toJSON), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toJSON", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
