using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Net {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']"
	[global::Android.Runtime.Register ("cn/jiguang/net/HttpUtils", DoNotGenerateAcw=true)]
	public partial class HttpUtils : global::Java.Lang.Object {


		static IntPtr ENCODING_UTF_8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='ENCODING_UTF_8']"
		[Register ("ENCODING_UTF_8")]
		public static string EncodingUtf8 {
			get {
				if (ENCODING_UTF_8_jfieldId == IntPtr.Zero)
					ENCODING_UTF_8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENCODING_UTF_8", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENCODING_UTF_8_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='EQUAL_SIGN']"
		[Register ("EQUAL_SIGN")]
		public const string EqualSign = (string) "=";

		static IntPtr HTTP_DEFUALT_PROXY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='HTTP_DEFUALT_PROXY']"
		[Register ("HTTP_DEFUALT_PROXY")]
		public static string HttpDefualtProxy {
			get {
				if (HTTP_DEFUALT_PROXY_jfieldId == IntPtr.Zero)
					HTTP_DEFUALT_PROXY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HTTP_DEFUALT_PROXY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HTTP_DEFUALT_PROXY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='PARAMETERS_SEPARATOR']"
		[Register ("PARAMETERS_SEPARATOR")]
		public const string ParametersSeparator = (string) "&";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='PATHS_SEPARATOR']"
		[Register ("PATHS_SEPARATOR")]
		public const string PathsSeparator = (string) "/";

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/field[@name='URL_AND_PARA_SEPARATOR']"
		[Register ("URL_AND_PARA_SEPARATOR")]
		public const string UrlAndParaSeparator = (string) "?";
		// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils.HttpListener']"
		[global::Android.Runtime.Register ("cn/jiguang/net/HttpUtils$HttpListener", DoNotGenerateAcw=true)]
		public abstract partial class HttpListener : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("cn/jiguang/net/HttpUtils$HttpListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (HttpListener); }
			}

			protected HttpListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcn_jiguang_net_HttpUtils_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils.HttpListener']/constructor[@name='HttpUtils.HttpListener' and count(parameter)=1 and parameter[1][@type='cn.jiguang.net.HttpUtils']]"
			[Register (".ctor", "(Lcn/jiguang/net/HttpUtils;)V", "")]
			public unsafe HttpListener (global::CN.Jiguang.Net.HttpUtils __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (GetType () != typeof (HttpListener)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcn_jiguang_net_HttpUtils_ == IntPtr.Zero)
						id_ctor_Lcn_jiguang_net_HttpUtils_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcn/jiguang/net/HttpUtils;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcn_jiguang_net_HttpUtils_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcn_jiguang_net_HttpUtils_, __args);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("cn/jiguang/net/HttpUtils$HttpListener", DoNotGenerateAcw=true)]
		internal partial class HttpListenerInvoker : HttpListener {

			public HttpListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (HttpListenerInvoker); }
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/net/HttpUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpUtils); }
		}

		protected HttpUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/constructor[@name='HttpUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpUtils)) {
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

		static IntPtr id_appendParaToUrl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='appendParaToUrl' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("appendParaToUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string AppendParaToUrl (string p0, string p1, string p2)
		{
			if (id_appendParaToUrl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_appendParaToUrl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "appendParaToUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_appendParaToUrl_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_createSSLConnection;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='createSSLConnection' and count(parameter)=0]"
		[Register ("createSSLConnection", "()V", "")]
		public static unsafe void CreateSSLConnection ()
		{
			if (id_createSSLConnection == IntPtr.Zero)
				id_createSSLConnection = JNIEnv.GetStaticMethodID (class_ref, "createSSLConnection", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_createSSLConnection);
			} finally {
			}
		}

		static IntPtr id_getHttpURLConnectionWithProxy_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='getHttpURLConnectionWithProxy' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getHttpURLConnectionWithProxy", "(Landroid/content/Context;Ljava/lang/String;)Ljava/net/HttpURLConnection;", "")]
		public static unsafe global::Java.Net.HttpURLConnection GetHttpURLConnectionWithProxy (global::Android.Content.Context p0, string p1)
		{
			if (id_getHttpURLConnectionWithProxy_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getHttpURLConnectionWithProxy_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getHttpURLConnectionWithProxy", "(Landroid/content/Context;Ljava/lang/String;)Ljava/net/HttpURLConnection;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.Net.HttpURLConnection __ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHttpURLConnectionWithProxy_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getUrlWithParas_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='getUrlWithParas' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getUrlWithParas", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetUrlWithParas (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_getUrlWithParas_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_getUrlWithParas_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "getUrlWithParas", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUrlWithParas_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getUrlWithValueEncodeParas_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='getUrlWithValueEncodeParas' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getUrlWithValueEncodeParas", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string GetUrlWithValueEncodeParas (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_getUrlWithValueEncodeParas_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_getUrlWithValueEncodeParas_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "getUrlWithValueEncodeParas", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUrlWithValueEncodeParas_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_httpGet_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGet' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jiguang.net.HttpRequest']]"
		[Register ("httpGet", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Lcn/jiguang/net/HttpResponse;", "")]
		public static unsafe global::CN.Jiguang.Net.HttpResponse HttpGet (global::Android.Content.Context p0, global::CN.Jiguang.Net.HttpRequest p1)
		{
			if (id_httpGet_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_ == IntPtr.Zero)
				id_httpGet_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_ = JNIEnv.GetStaticMethodID (class_ref, "httpGet", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Lcn/jiguang/net/HttpResponse;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::CN.Jiguang.Net.HttpResponse __ret = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_httpGet_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_httpGet_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_Lcn_jiguang_net_HttpUtils_HttpListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGet' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jiguang.net.HttpRequest'] and parameter[3][@type='cn.jiguang.net.HttpUtils.HttpListener']]"
		[Register ("httpGet", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;Lcn/jiguang/net/HttpUtils$HttpListener;)V", "")]
		public static unsafe void HttpGet (global::Android.Content.Context p0, global::CN.Jiguang.Net.HttpRequest p1, global::CN.Jiguang.Net.HttpUtils.HttpListener p2)
		{
			if (id_httpGet_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_Lcn_jiguang_net_HttpUtils_HttpListener_ == IntPtr.Zero)
				id_httpGet_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_Lcn_jiguang_net_HttpUtils_HttpListener_ = JNIEnv.GetStaticMethodID (class_ref, "httpGet", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;Lcn/jiguang/net/HttpUtils$HttpListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_httpGet_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_Lcn_jiguang_net_HttpUtils_HttpListener_, __args);
			} finally {
			}
		}

		static IntPtr id_httpGet_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGet' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("httpGet", "(Landroid/content/Context;Ljava/lang/String;)Lcn/jiguang/net/HttpResponse;", "")]
		public static unsafe global::CN.Jiguang.Net.HttpResponse HttpGet (global::Android.Content.Context p0, string p1)
		{
			if (id_httpGet_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_httpGet_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "httpGet", "(Landroid/content/Context;Ljava/lang/String;)Lcn/jiguang/net/HttpResponse;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::CN.Jiguang.Net.HttpResponse __ret = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_httpGet_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_httpGet_Landroid_content_Context_Ljava_lang_String_Lcn_jiguang_net_HttpUtils_HttpListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGet' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='cn.jiguang.net.HttpUtils.HttpListener']]"
		[Register ("httpGet", "(Landroid/content/Context;Ljava/lang/String;Lcn/jiguang/net/HttpUtils$HttpListener;)V", "")]
		public static unsafe void HttpGet (global::Android.Content.Context p0, string p1, global::CN.Jiguang.Net.HttpUtils.HttpListener p2)
		{
			if (id_httpGet_Landroid_content_Context_Ljava_lang_String_Lcn_jiguang_net_HttpUtils_HttpListener_ == IntPtr.Zero)
				id_httpGet_Landroid_content_Context_Ljava_lang_String_Lcn_jiguang_net_HttpUtils_HttpListener_ = JNIEnv.GetStaticMethodID (class_ref, "httpGet", "(Landroid/content/Context;Ljava/lang/String;Lcn/jiguang/net/HttpUtils$HttpListener;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_httpGet_Landroid_content_Context_Ljava_lang_String_Lcn_jiguang_net_HttpUtils_HttpListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_httpGetString_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGetString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jiguang.net.HttpRequest']]"
		[Register ("httpGetString", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Ljava/lang/String;", "")]
		public static unsafe string HttpGetString (global::Android.Content.Context p0, global::CN.Jiguang.Net.HttpRequest p1)
		{
			if (id_httpGetString_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_ == IntPtr.Zero)
				id_httpGetString_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_ = JNIEnv.GetStaticMethodID (class_ref, "httpGetString", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_httpGetString_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_httpGetString_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpGetString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("httpGetString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HttpGetString (global::Android.Content.Context p0, string p1)
		{
			if (id_httpGetString_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_httpGetString_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "httpGetString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_httpGetString_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_httpPost_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpPost' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jiguang.net.HttpRequest']]"
		[Register ("httpPost", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Lcn/jiguang/net/HttpResponse;", "")]
		public static unsafe global::CN.Jiguang.Net.HttpResponse HttpPost (global::Android.Content.Context p0, global::CN.Jiguang.Net.HttpRequest p1)
		{
			if (id_httpPost_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_ == IntPtr.Zero)
				id_httpPost_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_ = JNIEnv.GetStaticMethodID (class_ref, "httpPost", "(Landroid/content/Context;Lcn/jiguang/net/HttpRequest;)Lcn/jiguang/net/HttpResponse;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::CN.Jiguang.Net.HttpResponse __ret = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_httpPost_Landroid_content_Context_Lcn_jiguang_net_HttpRequest_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_httpPost_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpPost' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("httpPost", "(Landroid/content/Context;Ljava/lang/String;)Lcn/jiguang/net/HttpResponse;", "")]
		public static unsafe global::CN.Jiguang.Net.HttpResponse HttpPost (global::Android.Content.Context p0, string p1)
		{
			if (id_httpPost_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_httpPost_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "httpPost", "(Landroid/content/Context;Ljava/lang/String;)Lcn/jiguang/net/HttpResponse;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::CN.Jiguang.Net.HttpResponse __ret = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Net.HttpResponse> (JNIEnv.CallStaticObjectMethod  (class_ref, id_httpPost_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_httpPostString_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpPostString' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("httpPostString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string HttpPostString (global::Android.Content.Context p0, string p1)
		{
			if (id_httpPostString_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_httpPostString_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "httpPostString", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_httpPostString_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_httpPostString_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='httpPostString' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("httpPostString", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string HttpPostString (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_httpPostString_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_httpPostString_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "httpPostString", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_httpPostString_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_joinParas_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='joinParas' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("joinParas", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string JoinParas (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_joinParas_Ljava_util_Map_ == IntPtr.Zero)
				id_joinParas_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "joinParas", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_joinParas_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_joinParasWithEncodedValue_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='joinParasWithEncodedValue' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("joinParasWithEncodedValue", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string JoinParasWithEncodedValue (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_joinParasWithEncodedValue_Ljava_util_Map_ == IntPtr.Zero)
				id_joinParasWithEncodedValue_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "joinParasWithEncodedValue", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_joinParasWithEncodedValue_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseGmtTime_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='parseGmtTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseGmtTime", "(Ljava/lang/String;)J", "")]
		public static unsafe long ParseGmtTime (string p0)
		{
			if (id_parseGmtTime_Ljava_lang_String_ == IntPtr.Zero)
				id_parseGmtTime_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseGmtTime", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_parseGmtTime_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_readInputStream_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='readInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("readInputStream", "(Ljava/io/InputStream;)[B", "")]
		public static unsafe byte[] ReadInputStream (global::System.IO.Stream p0)
		{
			if (id_readInputStream_Ljava_io_InputStream_ == IntPtr.Zero)
				id_readInputStream_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "readInputStream", "(Ljava/io/InputStream;)[B");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_readInputStream_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setURLConnection_Ljava_util_Map_Ljava_net_HttpURLConnection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.net']/class[@name='HttpUtils']/method[@name='setURLConnection' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.net.HttpURLConnection']]"
		[Register ("setURLConnection", "(Ljava/util/Map;Ljava/net/HttpURLConnection;)V", "")]
		public static unsafe void SetURLConnection (global::System.Collections.Generic.IDictionary<string, string> p0, global::Java.Net.HttpURLConnection p1)
		{
			if (id_setURLConnection_Ljava_util_Map_Ljava_net_HttpURLConnection_ == IntPtr.Zero)
				id_setURLConnection_Ljava_util_Map_Ljava_net_HttpURLConnection_ = JNIEnv.GetStaticMethodID (class_ref, "setURLConnection", "(Ljava/util/Map;Ljava/net/HttpURLConnection;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setURLConnection_Ljava_util_Map_Ljava_net_HttpURLConnection_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
