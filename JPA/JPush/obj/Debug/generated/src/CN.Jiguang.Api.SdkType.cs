using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']"
	[global::Android.Runtime.Register ("cn/jiguang/api/SdkType", DoNotGenerateAcw=true)]
	public sealed partial class SdkType : global::Java.Lang.Enum {


		static IntPtr JANALYTICS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JANALYTICS']"
		[Register ("JANALYTICS")]
		public static global::CN.Jiguang.Api.SdkType Janalytics {
			get {
				if (JANALYTICS_jfieldId == IntPtr.Zero)
					JANALYTICS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JANALYTICS", "Lcn/jiguang/api/SdkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JANALYTICS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JCORE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JCORE']"
		[Register ("JCORE")]
		public static global::CN.Jiguang.Api.SdkType Jcore {
			get {
				if (JCORE_jfieldId == IntPtr.Zero)
					JCORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JCORE", "Lcn/jiguang/api/SdkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JCORE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JMESSAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JMESSAGE']"
		[Register ("JMESSAGE")]
		public static global::CN.Jiguang.Api.SdkType Jmessage {
			get {
				if (JMESSAGE_jfieldId == IntPtr.Zero)
					JMESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JMESSAGE", "Lcn/jiguang/api/SdkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JMESSAGE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JPUSH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JPUSH']"
		[Register ("JPUSH")]
		public static global::CN.Jiguang.Api.SdkType Jpush {
			get {
				if (JPUSH_jfieldId == IntPtr.Zero)
					JPUSH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JPUSH", "Lcn/jiguang/api/SdkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JPUSH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JSHARE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/field[@name='JSHARE']"
		[Register ("JSHARE")]
		public static global::CN.Jiguang.Api.SdkType Jshare {
			get {
				if (JSHARE_jfieldId == IntPtr.Zero)
					JSHARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JSHARE", "Lcn/jiguang/api/SdkType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JSHARE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/api/SdkType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SdkType); }
		}

		internal SdkType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcn/jiguang/api/SdkType;", "")]
		public static unsafe global::CN.Jiguang.Api.SdkType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcn/jiguang/api/SdkType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::CN.Jiguang.Api.SdkType __ret = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.SdkType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='SdkType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcn/jiguang/api/SdkType;", "")]
		public static unsafe global::CN.Jiguang.Api.SdkType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcn/jiguang/api/SdkType;");
			try {
				return (global::CN.Jiguang.Api.SdkType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::CN.Jiguang.Api.SdkType));
			} finally {
			}
		}

	}
}
