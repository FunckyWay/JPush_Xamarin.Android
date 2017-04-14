using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']"
	[global::Android.Runtime.Register ("cn/jiguang/net/HttpResponse", DoNotGenerateAcw=true)]
	public partial class HttpResponse : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/net/HttpResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpResponse); }
		}

		protected HttpResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/constructor[@name='HttpResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe HttpResponse (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (HttpResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/constructor[@name='HttpResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpResponse)) {
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

		static Delegate cb_getExpiredTime;
#pragma warning disable 0169
		static Delegate GetGetExpiredTimeHandler ()
		{
			if (cb_getExpiredTime == null)
				cb_getExpiredTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetExpiredTime);
			return cb_getExpiredTime;
		}

		static long n_GetExpiredTime (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExpiredTime;
		}
#pragma warning restore 0169

		static Delegate cb_setExpiredTime_J;
#pragma warning disable 0169
		static Delegate GetSetExpiredTime_JHandler ()
		{
			if (cb_setExpiredTime_J == null)
				cb_setExpiredTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetExpiredTime_J);
			return cb_setExpiredTime_J;
		}

		static void n_SetExpiredTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExpiredTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpiredTime;
		static IntPtr id_setExpiredTime_J;
		public virtual unsafe long ExpiredTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='getExpiredTime' and count(parameter)=0]"
			[Register ("getExpiredTime", "()J", "GetGetExpiredTimeHandler")]
			get {
				if (id_getExpiredTime == IntPtr.Zero)
					id_getExpiredTime = JNIEnv.GetMethodID (class_ref, "getExpiredTime", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod  (Handle, id_getExpiredTime);
					else
						return JNIEnv.CallNonvirtualLongMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpiredTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='setExpiredTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setExpiredTime", "(J)V", "GetSetExpiredTime_JHandler")]
			set {
				if (id_setExpiredTime_J == IntPtr.Zero)
					id_setExpiredTime_J = JNIEnv.GetMethodID (class_ref, "setExpiredTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setExpiredTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpiredTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExpiresHeader;
#pragma warning disable 0169
		static Delegate GetGetExpiresHeaderHandler ()
		{
			if (cb_getExpiresHeader == null)
				cb_getExpiresHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpiresHeader);
			return cb_getExpiresHeader;
		}

		static IntPtr n_GetExpiresHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExpiresHeader);
		}
#pragma warning restore 0169

		static IntPtr id_getExpiresHeader;
		public virtual unsafe string ExpiresHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='getExpiresHeader' and count(parameter)=0]"
			[Register ("getExpiresHeader", "()Ljava/lang/String;", "GetGetExpiresHeaderHandler")]
			get {
				if (id_getExpiresHeader == IntPtr.Zero)
					id_getExpiresHeader = JNIEnv.GetMethodID (class_ref, "getExpiresHeader", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getExpiresHeader), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpiresHeader", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isExpired;
#pragma warning disable 0169
		static Delegate GetIsExpiredHandler ()
		{
			if (cb_isExpired == null)
				cb_isExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExpired);
			return cb_isExpired;
		}

		static bool n_IsExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExpired;
		}
#pragma warning restore 0169

		static IntPtr id_isExpired;
		public virtual unsafe bool IsExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='isExpired' and count(parameter)=0]"
			[Register ("isExpired", "()Z", "GetIsExpiredHandler")]
			get {
				if (id_isExpired == IntPtr.Zero)
					id_isExpired = JNIEnv.GetMethodID (class_ref, "isExpired", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInCache;
#pragma warning disable 0169
		static Delegate GetIsInCacheHandler ()
		{
			if (cb_isInCache == null)
				cb_isInCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInCache);
			return cb_isInCache;
		}

		static bool n_IsInCache (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInCache;
		}
#pragma warning restore 0169

		static IntPtr id_isInCache;
		public virtual unsafe bool IsInCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='isInCache' and count(parameter)=0]"
			[Register ("isInCache", "()Z", "GetIsInCacheHandler")]
			get {
				if (id_isInCache == IntPtr.Zero)
					id_isInCache = JNIEnv.GetMethodID (class_ref, "isInCache", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isInCache);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInCache", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getResponseBody;
#pragma warning disable 0169
		static Delegate GetGetResponseBodyHandler ()
		{
			if (cb_getResponseBody == null)
				cb_getResponseBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseBody);
			return cb_getResponseBody;
		}

		static IntPtr n_GetResponseBody (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResponseBody);
		}
#pragma warning restore 0169

		static Delegate cb_setResponseBody_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseBody_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseBody_Ljava_lang_String_ == null)
				cb_setResponseBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseBody_Ljava_lang_String_);
			return cb_setResponseBody_Ljava_lang_String_;
		}

		static void n_SetResponseBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ResponseBody = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseBody;
		static IntPtr id_setResponseBody_Ljava_lang_String_;
		public virtual unsafe string ResponseBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='getResponseBody' and count(parameter)=0]"
			[Register ("getResponseBody", "()Ljava/lang/String;", "GetGetResponseBodyHandler")]
			get {
				if (id_getResponseBody == IntPtr.Zero)
					id_getResponseBody = JNIEnv.GetMethodID (class_ref, "getResponseBody", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getResponseBody), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseBody", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='setResponseBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResponseBody", "(Ljava/lang/String;)V", "GetSetResponseBody_Ljava_lang_String_Handler")]
			set {
				if (id_setResponseBody_Ljava_lang_String_ == IntPtr.Zero)
					id_setResponseBody_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponseBody", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setResponseBody_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseBody", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResponseCode;
#pragma warning disable 0169
		static Delegate GetGetResponseCodeHandler ()
		{
			if (cb_getResponseCode == null)
				cb_getResponseCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResponseCode);
			return cb_getResponseCode;
		}

		static int n_GetResponseCode (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResponseCode;
		}
#pragma warning restore 0169

		static Delegate cb_setResponseCode_I;
#pragma warning disable 0169
		static Delegate GetSetResponseCode_IHandler ()
		{
			if (cb_setResponseCode_I == null)
				cb_setResponseCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResponseCode_I);
			return cb_setResponseCode_I;
		}

		static void n_SetResponseCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResponseCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponseCode;
		static IntPtr id_setResponseCode_I;
		public virtual unsafe int ResponseCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='getResponseCode' and count(parameter)=0]"
			[Register ("getResponseCode", "()I", "GetGetResponseCodeHandler")]
			get {
				if (id_getResponseCode == IntPtr.Zero)
					id_getResponseCode = JNIEnv.GetMethodID (class_ref, "getResponseCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getResponseCode);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseCode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='setResponseCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResponseCode", "(I)V", "GetSetResponseCode_IHandler")]
			set {
				if (id_setResponseCode_I == IntPtr.Zero)
					id_setResponseCode_I = JNIEnv.GetMethodID (class_ref, "setResponseCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setResponseCode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseCode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static Delegate cb_setType_I;
#pragma warning disable 0169
		static Delegate GetSetType_IHandler ()
		{
			if (cb_setType_I == null)
				cb_setType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetType_I);
			return cb_setType_I;
		}

		static void n_SetType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_I;
		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setType", "(I)V", "GetSetType_IHandler")]
			set {
				if (id_setType_I == IntPtr.Zero)
					id_setType_I = JNIEnv.GetMethodID (class_ref, "setType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Url = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		static IntPtr id_setUrl_Ljava_lang_String_;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setInCache_Z;
#pragma warning disable 0169
		static Delegate GetSetInCache_ZHandler ()
		{
			if (cb_setInCache_Z == null)
				cb_setInCache_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetInCache_Z);
			return cb_setInCache_Z;
		}

		static IntPtr n_SetInCache_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetInCache (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setInCache_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='setInCache' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInCache", "(Z)Lcn/jiguang/net/HttpResponse;", "GetSetInCache_ZHandler")]
		public virtual unsafe global::CN.Jiguang.Net.HttpResponse SetInCache (bool p0)
		{
			if (id_setInCache_Z == IntPtr.Zero)
				id_setInCache_Z = JNIEnv.GetMethodID (class_ref, "setInCache", "(Z)Lcn/jiguang/net/HttpResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (JNIEnv.CallObjectMethod  (Handle, id_setInCache_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInCache", "(Z)Lcn/jiguang/net/HttpResponse;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setResponseHeader_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResponseHeader_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setResponseHeader_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setResponseHeader_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetResponseHeader_Ljava_lang_String_Ljava_lang_String_);
			return cb_setResponseHeader_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetResponseHeader_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetResponseHeader (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setResponseHeader_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='setResponseHeader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setResponseHeader", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetResponseHeader_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetResponseHeader (string p0, string p1)
		{
			if (id_setResponseHeader_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setResponseHeader_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResponseHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResponseHeader_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseHeader", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setResponseHeaders_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetResponseHeaders_Ljava_util_Map_Handler ()
		{
			if (cb_setResponseHeaders_Ljava_util_Map_ == null)
				cb_setResponseHeaders_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponseHeaders_Ljava_util_Map_);
			return cb_setResponseHeaders_Ljava_util_Map_;
		}

		static void n_SetResponseHeaders_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpResponse __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetResponseHeaders (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setResponseHeaders_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpResponse']/method[@name='setResponseHeaders' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("setResponseHeaders", "(Ljava/util/Map;)V", "GetSetResponseHeaders_Ljava_util_Map_Handler")]
		public virtual unsafe void SetResponseHeaders (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_setResponseHeaders_Ljava_util_Map_ == IntPtr.Zero)
				id_setResponseHeaders_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setResponseHeaders", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setResponseHeaders_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponseHeaders", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
