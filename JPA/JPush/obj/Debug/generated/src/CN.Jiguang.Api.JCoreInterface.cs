using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']"
	[global::Android.Runtime.Register ("cn/jiguang/api/JCoreInterface", DoNotGenerateAcw=true)]
	public partial class JCoreInterface : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/api/JCoreInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JCoreInterface); }
		}

		protected JCoreInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/constructor[@name='JCoreInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JCoreInterface ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JCoreInterface)) {
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

		static IntPtr id_getAesConfig;
		public static unsafe bool AesConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getAesConfig' and count(parameter)=0]"
			[Register ("getAesConfig", "()Z", "GetGetAesConfigHandler")]
			get {
				if (id_getAesConfig == IntPtr.Zero)
					id_getAesConfig = JNIEnv.GetStaticMethodID (class_ref, "getAesConfig", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_getAesConfig);
				} finally {
				}
			}
		}

		static IntPtr id_getAppKey;
		public static unsafe string AppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getAppKey' and count(parameter)=0]"
			[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
			get {
				if (id_getAppKey == IntPtr.Zero)
					id_getAppKey = JNIEnv.GetStaticMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppKey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getChannel;
		public static unsafe string Channel {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getChannel' and count(parameter)=0]"
			[Register ("getChannel", "()Ljava/lang/String;", "GetGetChannelHandler")]
			get {
				if (id_getChannel == IntPtr.Zero)
					id_getChannel = JNIEnv.GetStaticMethodID (class_ref, "getChannel", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getChannel), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCommonConfigAppkey;
		public static unsafe string CommonConfigAppkey {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getCommonConfigAppkey' and count(parameter)=0]"
			[Register ("getCommonConfigAppkey", "()Ljava/lang/String;", "GetGetCommonConfigAppkeyHandler")]
			get {
				if (id_getCommonConfigAppkey == IntPtr.Zero)
					id_getCommonConfigAppkey = JNIEnv.GetStaticMethodID (class_ref, "getCommonConfigAppkey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCommonConfigAppkey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDebugMode;
		static IntPtr id_setDebugMode_Z;
		public static unsafe bool DebugMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getDebugMode' and count(parameter)=0]"
			[Register ("getDebugMode", "()Z", "GetGetDebugModeHandler")]
			get {
				if (id_getDebugMode == IntPtr.Zero)
					id_getDebugMode = JNIEnv.GetStaticMethodID (class_ref, "getDebugMode", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_getDebugMode);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setDebugMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebugMode", "(Z)V", "GetSetDebugMode_ZHandler")]
			set {
				if (id_setDebugMode_Z == IntPtr.Zero)
					id_setDebugMode_Z = JNIEnv.GetStaticMethodID (class_ref, "setDebugMode", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebugMode_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isTcpConnected;
		public static unsafe bool IsTcpConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='isTcpConnected' and count(parameter)=0]"
			[Register ("isTcpConnected", "()Z", "GetIsTcpConnectedHandler")]
			get {
				if (id_isTcpConnected == IntPtr.Zero)
					id_isTcpConnected = JNIEnv.GetStaticMethodID (class_ref, "isTcpConnected", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isTcpConnected);
				} finally {
				}
			}
		}

		static IntPtr id_isValidRegistered;
		public static unsafe bool IsValidRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='isValidRegistered' and count(parameter)=0]"
			[Register ("isValidRegistered", "()Z", "GetIsValidRegisteredHandler")]
			get {
				if (id_isValidRegistered == IntPtr.Zero)
					id_isValidRegistered = JNIEnv.GetStaticMethodID (class_ref, "isValidRegistered", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isValidRegistered);
				} finally {
				}
			}
		}

		static IntPtr id_getNextRid;
		public static unsafe long NextRid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getNextRid' and count(parameter)=0]"
			[Register ("getNextRid", "()J", "GetGetNextRidHandler")]
			get {
				if (id_getNextRid == IntPtr.Zero)
					id_getNextRid = JNIEnv.GetStaticMethodID (class_ref, "getNextRid", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getNextRid);
				} finally {
				}
			}
		}

		static IntPtr id_getReportTime;
		public static unsafe long ReportTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getReportTime' and count(parameter)=0]"
			[Register ("getReportTime", "()J", "GetGetReportTimeHandler")]
			get {
				if (id_getReportTime == IntPtr.Zero)
					id_getReportTime = JNIEnv.GetStaticMethodID (class_ref, "getReportTime", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getReportTime);
				} finally {
				}
			}
		}

		static IntPtr id_getRuningFlag;
		public static unsafe bool RuningFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getRuningFlag' and count(parameter)=0]"
			[Register ("getRuningFlag", "()Z", "GetGetRuningFlagHandler")]
			get {
				if (id_getRuningFlag == IntPtr.Zero)
					id_getRuningFlag = JNIEnv.GetStaticMethodID (class_ref, "getRuningFlag", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_getRuningFlag);
				} finally {
				}
			}
		}

		static IntPtr id_getSid;
		public static unsafe int Sid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getSid' and count(parameter)=0]"
			[Register ("getSid", "()I", "GetGetSidHandler")]
			get {
				if (id_getSid == IntPtr.Zero)
					id_getSid = JNIEnv.GetStaticMethodID (class_ref, "getSid", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getSid);
				} finally {
				}
			}
		}

		static IntPtr id_getUid;
		public static unsafe long Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()J", "GetGetUidHandler")]
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetStaticMethodID (class_ref, "getUid", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getUid);
				} finally {
				}
			}
		}

		static IntPtr id_canCallDirect;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='canCallDirect' and count(parameter)=0]"
		[Register ("canCallDirect", "()Z", "")]
		public static unsafe bool CanCallDirect ()
		{
			if (id_canCallDirect == IntPtr.Zero)
				id_canCallDirect = JNIEnv.GetStaticMethodID (class_ref, "canCallDirect", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_canCallDirect);
			} finally {
			}
		}

		static IntPtr id_getBinderByType_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getBinderByType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getBinderByType", "(Ljava/lang/String;Ljava/lang/String;)Landroid/os/IBinder;", "")]
		public static unsafe global::Android.OS.IBinder GetBinderByType (string p0, string p1)
		{
			if (id_getBinderByType_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getBinderByType_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBinderByType", "(Ljava/lang/String;Ljava/lang/String;)Landroid/os/IBinder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Android.OS.IBinder __ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBinderByType_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getConnectionState_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getConnectionState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getConnectionState", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool GetConnectionState (global::Android.Content.Context p0)
		{
			if (id_getConnectionState_Landroid_content_Context_ == IntPtr.Zero)
				id_getConnectionState_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getConnectionState", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_getConnectionState_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDeviceId_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getDeviceId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDeviceId (global::Android.Content.Context p0)
		{
			if (id_getDeviceId_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceId_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceId", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceId_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getHttpConfig_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getHttpConfig' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getHttpConfig", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetHttpConfig (global::Android.Content.Context p0, string p1)
		{
			if (id_getHttpConfig_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getHttpConfig_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getHttpConfig", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHttpConfig_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getRegistrationID_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='getRegistrationID' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getRegistrationID", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetRegistrationID (global::Android.Content.Context p0)
		{
			if (id_getRegistrationID_Landroid_content_Context_ == IntPtr.Zero)
				id_getRegistrationID_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getRegistrationID", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRegistrationID_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("init", "(Landroid/content/Context;Z)Z", "")]
		public static unsafe bool Init (global::Android.Content.Context p0, bool p1)
		{
			if (id_init_Landroid_content_Context_Z == IntPtr.Zero)
				id_init_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Z)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_init_Landroid_content_Context_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initAction_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='initAction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;? extends cn.jiguang.api.JAction&gt;']]"
		[Register ("initAction", "(Ljava/lang/String;Ljava/lang/Class;)V", "")]
		public static unsafe void InitAction (string p0, global::Java.Lang.Class p1)
		{
			if (id_initAction_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_initAction_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "initAction", "(Ljava/lang/String;Ljava/lang/Class;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initAction_Ljava_lang_String_Ljava_lang_Class_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_initCrashHandler_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='initCrashHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initCrashHandler", "(Landroid/content/Context;)V", "")]
		public static unsafe void InitCrashHandler (global::Android.Content.Context p0)
		{
			if (id_initCrashHandler_Landroid_content_Context_ == IntPtr.Zero)
				id_initCrashHandler_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "initCrashHandler", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_initCrashHandler_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_onFragmentPause_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='onFragmentPause' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFragmentPause", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void OnFragmentPause (global::Android.Content.Context p0, string p1)
		{
			if (id_onFragmentPause_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_onFragmentPause_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onFragmentPause", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onFragmentPause_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onFragmentResume_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='onFragmentResume' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("onFragmentResume", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void OnFragmentResume (global::Android.Content.Context p0, string p1)
		{
			if (id_onFragmentResume_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_onFragmentResume_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onFragmentResume", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onFragmentResume_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onKillProcess_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='onKillProcess' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onKillProcess", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnKillProcess (global::Android.Content.Context p0)
		{
			if (id_onKillProcess_Landroid_content_Context_ == IntPtr.Zero)
				id_onKillProcess_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "onKillProcess", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onKillProcess_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_register_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='register' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("register", "(Landroid/content/Context;)V", "")]
		public static unsafe void Register (global::Android.Content.Context p0)
		{
			if (id_register_Landroid_content_Context_ == IntPtr.Zero)
				id_register_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "register", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_register_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_reportHttpData_Landroid_content_Context_Ljava_lang_Object_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='reportHttpData' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='java.lang.String']]"
		[Register ("reportHttpData", "(Landroid/content/Context;Ljava/lang/Object;Ljava/lang/String;)Z", "")]
		public static unsafe bool ReportHttpData (global::Android.Content.Context p0, global::Java.Lang.Object p1, string p2)
		{
			if (id_reportHttpData_Landroid_content_Context_Ljava_lang_Object_Ljava_lang_String_ == IntPtr.Zero)
				id_reportHttpData_Landroid_content_Context_Ljava_lang_Object_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reportHttpData", "(Landroid/content/Context;Ljava/lang/Object;Ljava/lang/String;)Z");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_reportHttpData_Landroid_content_Context_Ljava_lang_Object_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_requestPermission_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='requestPermission' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("requestPermission", "(Landroid/content/Context;)V", "")]
		public static unsafe void RequestPermission (global::Android.Content.Context p0)
		{
			if (id_requestPermission_Landroid_content_Context_ == IntPtr.Zero)
				id_requestPermission_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "requestPermission", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_requestPermission_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_restart_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='restart' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='boolean']]"
		[Register ("restart", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Z)V", "")]
		public static unsafe void Restart (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2, bool p3)
		{
			if (id_restart_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Z == IntPtr.Zero)
				id_restart_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Z = JNIEnv.GetStaticMethodID (class_ref, "restart", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;Z)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_restart_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_Z, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendAction_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='sendAction' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("sendAction", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public static unsafe void SendAction (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2)
		{
			if (id_sendAction_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_sendAction_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "sendAction", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendAction_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_sendData_Landroid_content_Context_Ljava_lang_String_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='sendData' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("sendData", "(Landroid/content/Context;Ljava/lang/String;I[B)V", "")]
		public static unsafe void SendData (global::Android.Content.Context p0, string p1, int p2, byte[] p3)
		{
			if (id_sendData_Landroid_content_Context_Ljava_lang_String_IarrayB == IntPtr.Zero)
				id_sendData_Landroid_content_Context_Ljava_lang_String_IarrayB = JNIEnv.GetStaticMethodID (class_ref, "sendData", "(Landroid/content/Context;Ljava/lang/String;I[B)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendData_Landroid_content_Context_Ljava_lang_String_IarrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_sendRequestData_Landroid_content_Context_Ljava_lang_String_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='sendRequestData' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("sendRequestData", "(Landroid/content/Context;Ljava/lang/String;I[B)V", "")]
		public static unsafe void SendRequestData (global::Android.Content.Context p0, string p1, int p2, byte[] p3)
		{
			if (id_sendRequestData_Landroid_content_Context_Ljava_lang_String_IarrayB == IntPtr.Zero)
				id_sendRequestData_Landroid_content_Context_Ljava_lang_String_IarrayB = JNIEnv.GetStaticMethodID (class_ref, "sendRequestData", "(Landroid/content/Context;Ljava/lang/String;I[B)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_sendRequestData_Landroid_content_Context_Ljava_lang_String_IarrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_setAnalysisAction_Lcn_jiguang_api_JAnalyticsAction_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setAnalysisAction' and count(parameter)=1 and parameter[1][@type='cn.jiguang.api.JAnalyticsAction']]"
		[Register ("setAnalysisAction", "(Lcn/jiguang/api/JAnalyticsAction;)V", "")]
		public static unsafe void SetAnalysisAction (global::CN.Jiguang.Api.IJAnalyticsAction p0)
		{
			if (id_setAnalysisAction_Lcn_jiguang_api_JAnalyticsAction_ == IntPtr.Zero)
				id_setAnalysisAction_Lcn_jiguang_api_JAnalyticsAction_ = JNIEnv.GetStaticMethodID (class_ref, "setAnalysisAction", "(Lcn/jiguang/api/JAnalyticsAction;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAnalysisAction_Lcn_jiguang_api_JAnalyticsAction_, __args);
			} finally {
			}
		}

		static IntPtr id_setCanLaunchedStoppedService_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setCanLaunchedStoppedService' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCanLaunchedStoppedService", "(Z)V", "")]
		public static unsafe void SetCanLaunchedStoppedService (bool p0)
		{
			if (id_setCanLaunchedStoppedService_Z == IntPtr.Zero)
				id_setCanLaunchedStoppedService_Z = JNIEnv.GetStaticMethodID (class_ref, "setCanLaunchedStoppedService", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCanLaunchedStoppedService_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setImLBSEnable_Landroid_content_Context_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='setImLBSEnable' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("setImLBSEnable", "(Landroid/content/Context;Z)V", "")]
		public static unsafe void SetImLBSEnable (global::Android.Content.Context p0, bool p1)
		{
			if (id_setImLBSEnable_Landroid_content_Context_Z == IntPtr.Zero)
				id_setImLBSEnable_Landroid_content_Context_Z = JNIEnv.GetStaticMethodID (class_ref, "setImLBSEnable", "(Landroid/content/Context;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setImLBSEnable_Landroid_content_Context_Z, __args);
			} finally {
			}
		}

		static IntPtr id_stop_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='stop' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("stop", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V", "")]
		public static unsafe void Stop (global::Android.Content.Context p0, string p1, global::Android.OS.Bundle p2)
		{
			if (id_stop_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ == IntPtr.Zero)
				id_stop_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_ = JNIEnv.GetStaticMethodID (class_ref, "stop", "(Landroid/content/Context;Ljava/lang/String;Landroid/os/Bundle;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stop_Landroid_content_Context_Ljava_lang_String_Landroid_os_Bundle_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_stopCrashHandler_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='JCoreInterface']/method[@name='stopCrashHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stopCrashHandler", "(Landroid/content/Context;)V", "")]
		public static unsafe void StopCrashHandler (global::Android.Content.Context p0)
		{
			if (id_stopCrashHandler_Landroid_content_Context_ == IntPtr.Zero)
				id_stopCrashHandler_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "stopCrashHandler", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stopCrashHandler_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
