using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']"
	[global::Android.Runtime.Register ("cn/jiguang/net/HttpRequest", DoNotGenerateAcw=true)]
	public partial class HttpRequest : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/net/HttpRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpRequest); }
		}

		protected HttpRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/constructor[@name='HttpRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe HttpRequest (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (HttpRequest)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/constructor[@name='HttpRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe HttpRequest (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (HttpRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Body);
		}
#pragma warning restore 0169

		static Delegate cb_setBody_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetBody_Ljava_lang_Object_Handler ()
		{
			if (cb_setBody_Ljava_lang_Object_ == null)
				cb_setBody_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBody_Ljava_lang_Object_);
			return cb_setBody_Ljava_lang_Object_;
		}

		static void n_SetBody_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Body = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBody;
		static IntPtr id_setBody_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object Body {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getBody' and count(parameter)=0]"
			[Register ("getBody", "()Ljava/lang/Object;", "GetGetBodyHandler")]
			get {
				if (id_getBody == IntPtr.Zero)
					id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setBody' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setBody", "(Ljava/lang/Object;)V", "GetSetBody_Ljava_lang_Object_Handler")]
			set {
				if (id_setBody_Ljava_lang_Object_ == IntPtr.Zero)
					id_setBody_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setBody", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setBody_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBody", "(Ljava/lang/Object;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectTimeout;
#pragma warning disable 0169
		static Delegate GetGetConnectTimeoutHandler ()
		{
			if (cb_getConnectTimeout == null)
				cb_getConnectTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnectTimeout);
			return cb_getConnectTimeout;
		}

		static int n_GetConnectTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetConnectTimeout_IHandler ()
		{
			if (cb_setConnectTimeout_I == null)
				cb_setConnectTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnectTimeout_I);
			return cb_setConnectTimeout_I;
		}

		static void n_SetConnectTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectTimeout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectTimeout;
		static IntPtr id_setConnectTimeout_I;
		public virtual unsafe int ConnectTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getConnectTimeout' and count(parameter)=0]"
			[Register ("getConnectTimeout", "()I", "GetGetConnectTimeoutHandler")]
			get {
				if (id_getConnectTimeout == IntPtr.Zero)
					id_getConnectTimeout = JNIEnv.GetMethodID (class_ref, "getConnectTimeout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getConnectTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectTimeout", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setConnectTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectTimeout", "(I)V", "GetSetConnectTimeout_IHandler")]
			set {
				if (id_setConnectTimeout_I == IntPtr.Zero)
					id_setConnectTimeout_I = JNIEnv.GetMethodID (class_ref, "setConnectTimeout", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setConnectTimeout_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectTimeout", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDoInPut;
#pragma warning disable 0169
		static Delegate GetIsDoInPutHandler ()
		{
			if (cb_isDoInPut == null)
				cb_isDoInPut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDoInPut);
			return cb_isDoInPut;
		}

		static bool n_IsDoInPut (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoInPut;
		}
#pragma warning restore 0169

		static Delegate cb_setDoInPut_Z;
#pragma warning disable 0169
		static Delegate GetSetDoInPut_ZHandler ()
		{
			if (cb_setDoInPut_Z == null)
				cb_setDoInPut_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDoInPut_Z);
			return cb_setDoInPut_Z;
		}

		static void n_SetDoInPut_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoInPut = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDoInPut;
		static IntPtr id_setDoInPut_Z;
		public virtual unsafe bool DoInPut {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isDoInPut' and count(parameter)=0]"
			[Register ("isDoInPut", "()Z", "GetIsDoInPutHandler")]
			get {
				if (id_isDoInPut == IntPtr.Zero)
					id_isDoInPut = JNIEnv.GetMethodID (class_ref, "isDoInPut", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDoInPut);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDoInPut", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setDoInPut' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDoInPut", "(Z)V", "GetSetDoInPut_ZHandler")]
			set {
				if (id_setDoInPut_Z == IntPtr.Zero)
					id_setDoInPut_Z = JNIEnv.GetMethodID (class_ref, "setDoInPut", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDoInPut_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDoInPut", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDoOutPut;
#pragma warning disable 0169
		static Delegate GetIsDoOutPutHandler ()
		{
			if (cb_isDoOutPut == null)
				cb_isDoOutPut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDoOutPut);
			return cb_isDoOutPut;
		}

		static bool n_IsDoOutPut (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoOutPut;
		}
#pragma warning restore 0169

		static Delegate cb_setDoOutPut_Z;
#pragma warning disable 0169
		static Delegate GetSetDoOutPut_ZHandler ()
		{
			if (cb_setDoOutPut_Z == null)
				cb_setDoOutPut_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDoOutPut_Z);
			return cb_setDoOutPut_Z;
		}

		static void n_SetDoOutPut_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoOutPut = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDoOutPut;
		static IntPtr id_setDoOutPut_Z;
		public virtual unsafe bool DoOutPut {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isDoOutPut' and count(parameter)=0]"
			[Register ("isDoOutPut", "()Z", "GetIsDoOutPutHandler")]
			get {
				if (id_isDoOutPut == IntPtr.Zero)
					id_isDoOutPut = JNIEnv.GetMethodID (class_ref, "isDoOutPut", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isDoOutPut);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDoOutPut", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setDoOutPut' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDoOutPut", "(Z)V", "GetSetDoOutPut_ZHandler")]
			set {
				if (id_setDoOutPut_Z == IntPtr.Zero)
					id_setDoOutPut_Z = JNIEnv.GetMethodID (class_ref, "setDoOutPut", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setDoOutPut_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDoOutPut", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isHaveRspData;
#pragma warning disable 0169
		static Delegate GetIsHaveRspDataHandler ()
		{
			if (cb_isHaveRspData == null)
				cb_isHaveRspData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHaveRspData);
			return cb_isHaveRspData;
		}

		static bool n_IsHaveRspData (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HaveRspData;
		}
#pragma warning restore 0169

		static Delegate cb_setHaveRspData_Z;
#pragma warning disable 0169
		static Delegate GetSetHaveRspData_ZHandler ()
		{
			if (cb_setHaveRspData_Z == null)
				cb_setHaveRspData_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHaveRspData_Z);
			return cb_setHaveRspData_Z;
		}

		static void n_SetHaveRspData_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HaveRspData = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isHaveRspData;
		static IntPtr id_setHaveRspData_Z;
		public virtual unsafe bool HaveRspData {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isHaveRspData' and count(parameter)=0]"
			[Register ("isHaveRspData", "()Z", "GetIsHaveRspDataHandler")]
			get {
				if (id_isHaveRspData == IntPtr.Zero)
					id_isHaveRspData = JNIEnv.GetMethodID (class_ref, "isHaveRspData", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isHaveRspData);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHaveRspData", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setHaveRspData' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHaveRspData", "(Z)V", "GetSetHaveRspData_ZHandler")]
			set {
				if (id_setHaveRspData_Z == IntPtr.Zero)
					id_setHaveRspData_Z = JNIEnv.GetMethodID (class_ref, "setHaveRspData", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setHaveRspData_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHaveRspData", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getParasMap;
#pragma warning disable 0169
		static Delegate GetGetParasMapHandler ()
		{
			if (cb_getParasMap == null)
				cb_getParasMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParasMap);
			return cb_getParasMap;
		}

		static IntPtr n_GetParasMap (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.ParasMap);
		}
#pragma warning restore 0169

		static Delegate cb_setParasMap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetParasMap_Ljava_util_Map_Handler ()
		{
			if (cb_setParasMap_Ljava_util_Map_ == null)
				cb_setParasMap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParasMap_Ljava_util_Map_);
			return cb_setParasMap_Ljava_util_Map_;
		}

		static void n_SetParasMap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParasMap = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParasMap;
		static IntPtr id_setParasMap_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> ParasMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getParasMap' and count(parameter)=0]"
			[Register ("getParasMap", "()Ljava/util/Map;", "GetGetParasMapHandler")]
			get {
				if (id_getParasMap == IntPtr.Zero)
					id_getParasMap = JNIEnv.GetMethodID (class_ref, "getParasMap", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getParasMap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParasMap", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setParasMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setParasMap", "(Ljava/util/Map;)V", "GetSetParasMap_Ljava_util_Map_Handler")]
			set {
				if (id_setParasMap_Ljava_util_Map_ == IntPtr.Zero)
					id_setParasMap_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setParasMap", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setParasMap_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParasMap", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReadTimeout;
#pragma warning disable 0169
		static Delegate GetGetReadTimeoutHandler ()
		{
			if (cb_getReadTimeout == null)
				cb_getReadTimeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReadTimeout);
			return cb_getReadTimeout;
		}

		static int n_GetReadTimeout (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadTimeout;
		}
#pragma warning restore 0169

		static Delegate cb_setReadTimeout_I;
#pragma warning disable 0169
		static Delegate GetSetReadTimeout_IHandler ()
		{
			if (cb_setReadTimeout_I == null)
				cb_setReadTimeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReadTimeout_I);
			return cb_setReadTimeout_I;
		}

		static void n_SetReadTimeout_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadTimeout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReadTimeout;
		static IntPtr id_setReadTimeout_I;
		public virtual unsafe int ReadTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getReadTimeout' and count(parameter)=0]"
			[Register ("getReadTimeout", "()I", "GetGetReadTimeoutHandler")]
			get {
				if (id_getReadTimeout == IntPtr.Zero)
					id_getReadTimeout = JNIEnv.GetMethodID (class_ref, "getReadTimeout", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getReadTimeout);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReadTimeout", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setReadTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReadTimeout", "(I)V", "GetSetReadTimeout_IHandler")]
			set {
				if (id_setReadTimeout_I == IntPtr.Zero)
					id_setReadTimeout_I = JNIEnv.GetMethodID (class_ref, "setReadTimeout", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setReadTimeout_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadTimeout", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRequestProperties;
#pragma warning disable 0169
		static Delegate GetGetRequestPropertiesHandler ()
		{
			if (cb_getRequestProperties == null)
				cb_getRequestProperties = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequestProperties);
			return cb_getRequestProperties;
		}

		static IntPtr n_GetRequestProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.RequestProperties);
		}
#pragma warning restore 0169

		static Delegate cb_setRequestProperties_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetRequestProperties_Ljava_util_Map_Handler ()
		{
			if (cb_setRequestProperties_Ljava_util_Map_ == null)
				cb_setRequestProperties_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRequestProperties_Ljava_util_Map_);
			return cb_setRequestProperties_Ljava_util_Map_;
		}

		static void n_SetRequestProperties_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RequestProperties = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestProperties;
		static IntPtr id_setRequestProperties_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> RequestProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getRequestProperties' and count(parameter)=0]"
			[Register ("getRequestProperties", "()Ljava/util/Map;", "GetGetRequestPropertiesHandler")]
			get {
				if (id_getRequestProperties == IntPtr.Zero)
					id_getRequestProperties = JNIEnv.GetMethodID (class_ref, "getRequestProperties", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getRequestProperties), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestProperties", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setRequestProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setRequestProperties", "(Ljava/util/Map;)V", "GetSetRequestProperties_Ljava_util_Map_Handler")]
			set {
				if (id_setRequestProperties_Ljava_util_Map_ == IntPtr.Zero)
					id_setRequestProperties_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setRequestProperties", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setRequestProperties_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestProperties", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Url = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		static IntPtr id_setUrl_Ljava_lang_String_;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getUrl' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_isUseCaches;
#pragma warning disable 0169
		static Delegate GetIsUseCachesHandler ()
		{
			if (cb_isUseCaches == null)
				cb_isUseCaches = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUseCaches);
			return cb_isUseCaches;
		}

		static bool n_IsUseCaches (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseCaches;
		}
#pragma warning restore 0169

		static Delegate cb_setUseCaches_Z;
#pragma warning disable 0169
		static Delegate GetSetUseCaches_ZHandler ()
		{
			if (cb_setUseCaches_Z == null)
				cb_setUseCaches_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseCaches_Z);
			return cb_setUseCaches_Z;
		}

		static void n_SetUseCaches_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseCaches = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isUseCaches;
		static IntPtr id_setUseCaches_Z;
		public virtual unsafe bool UseCaches {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='isUseCaches' and count(parameter)=0]"
			[Register ("isUseCaches", "()Z", "GetIsUseCachesHandler")]
			get {
				if (id_isUseCaches == IntPtr.Zero)
					id_isUseCaches = JNIEnv.GetMethodID (class_ref, "isUseCaches", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isUseCaches);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUseCaches", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setUseCaches' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseCaches", "(Z)V", "GetSetUseCaches_ZHandler")]
			set {
				if (id_setUseCaches_Z == IntPtr.Zero)
					id_setUseCaches_Z = JNIEnv.GetMethodID (class_ref, "setUseCaches", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod  (Handle, id_setUseCaches_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseCaches", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getParas;
#pragma warning disable 0169
		static Delegate GetGetParasHandler ()
		{
			if (cb_getParas == null)
				cb_getParas = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParas);
			return cb_getParas;
		}

		static IntPtr n_GetParas (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetParas ());
		}
#pragma warning restore 0169

		static IntPtr id_getParas;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getParas' and count(parameter)=0]"
		[Register ("getParas", "()[B", "GetGetParasHandler")]
		public virtual unsafe byte[] GetParas ()
		{
			if (id_getParas == IntPtr.Zero)
				id_getParas = JNIEnv.GetMethodID (class_ref, "getParas", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getParas), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParas", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getRequestProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetRequestProperty_Ljava_lang_String_Handler ()
		{
			if (cb_getRequestProperty_Ljava_lang_String_ == null)
				cb_getRequestProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetRequestProperty_Ljava_lang_String_);
			return cb_getRequestProperty_Ljava_lang_String_;
		}

		static IntPtr n_GetRequestProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetRequestProperty (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestProperty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='getRequestProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetRequestProperty_Ljava_lang_String_Handler")]
		public virtual unsafe string GetRequestProperty (string p0)
		{
			if (id_getRequestProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_getRequestProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getRequestProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestProperty", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestProperty (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetRequestProperty (string p0, string p1)
		{
			if (id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setUserAgent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserAgent_Ljava_lang_String_Handler ()
		{
			if (cb_setUserAgent_Ljava_lang_String_ == null)
				cb_setUserAgent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserAgent_Ljava_lang_String_);
			return cb_setUserAgent_Ljava_lang_String_;
		}

		static void n_SetUserAgent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::CN.Jiguang.Net.HttpRequest __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUserAgent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUserAgent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpRequest']/method[@name='setUserAgent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUserAgent", "(Ljava/lang/String;)V", "GetSetUserAgent_Ljava_lang_String_Handler")]
		public virtual unsafe void SetUserAgent (string p0)
		{
			if (id_setUserAgent_Ljava_lang_String_ == IntPtr.Zero)
				id_setUserAgent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserAgent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setUserAgent_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserAgent", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
