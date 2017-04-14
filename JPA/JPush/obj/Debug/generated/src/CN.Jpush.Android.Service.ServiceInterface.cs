using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']"
	[global::Android.Runtime.Register ("cn/jpush/android/service/ServiceInterface", DoNotGenerateAcw=true)]
	public partial class ServiceInterface : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/service/ServiceInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ServiceInterface); }
		}

		protected ServiceInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/constructor[@name='ServiceInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServiceInterface ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ServiceInterface)) {
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

		static IntPtr id_a;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "")]
		public static unsafe string A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetStaticMethodID (class_ref, "a", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_a), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0)
		{
			if (id_a_Landroid_content_Context_ == IntPtr.Zero)
				id_a_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("a", "(Landroid/content/Context;I)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, int p1)
		{
			if (id_a_Landroid_content_Context_I == IntPtr.Zero)
				id_a_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("a", "(Landroid/content/Context;IIII)Z", "")]
		public static unsafe bool A (global::Android.Content.Context p0, int p1, int p2, int p3, int p4)
		{
			if (id_a_Landroid_content_Context_IIII == IntPtr.Zero)
				id_a_Landroid_content_Context_IIII = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;IIII)Z");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_Context_IIII, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_Integer_Lcn_jpush_android_api_DefaultPushNotificationBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='cn.jpush.android.api.DefaultPushNotificationBuilder']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/Integer;Lcn/jpush/android/api/DefaultPushNotificationBuilder;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, global::Java.Lang.Integer p1, global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder p2)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_Integer_Lcn_jpush_android_api_DefaultPushNotificationBuilder_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_Integer_Lcn_jpush_android_api_DefaultPushNotificationBuilder_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/Integer;Lcn/jpush/android/api/DefaultPushNotificationBuilder;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_Integer_Lcn_jpush_android_api_DefaultPushNotificationBuilder_, __args);
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, string p1)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_a_Landroid_content_Context_Ljava_lang_String_Ljava_util_ArrayList_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='a' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.String&gt;'] and parameter[4][@type='long']]"
		[Register ("a", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/ArrayList;J)V", "")]
		public static unsafe void A (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IList<string> p2, long p3)
		{
			if (id_a_Landroid_content_Context_Ljava_lang_String_Ljava_util_ArrayList_J == IntPtr.Zero)
				id_a_Landroid_content_Context_Ljava_lang_String_Ljava_util_ArrayList_J = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/ArrayList;J)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_a_Landroid_content_Context_Ljava_lang_String_Ljava_util_ArrayList_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_b_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='b' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("b", "(Landroid/content/Context;)V", "")]
		public static unsafe void B (global::Android.Content.Context p0)
		{
			if (id_b_Landroid_content_Context_ == IntPtr.Zero)
				id_b_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_b_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='b' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("b", "(Landroid/content/Context;I)V", "")]
		public static unsafe void B (global::Android.Content.Context p0, int p1)
		{
			if (id_b_Landroid_content_Context_I == IntPtr.Zero)
				id_b_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "b", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_b_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_c_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='c' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("c", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool C (global::Android.Content.Context p0)
		{
			if (id_c_Landroid_content_Context_ == IntPtr.Zero)
				id_c_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_c_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_c_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='c' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("c", "(Landroid/content/Context;I)V", "")]
		public static unsafe void C (global::Android.Content.Context p0, int p1)
		{
			if (id_c_Landroid_content_Context_I == IntPtr.Zero)
				id_c_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "c", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_c_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_d_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.service']/class[@name='ServiceInterface']/method[@name='d' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("d", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool D (global::Android.Content.Context p0)
		{
			if (id_d_Landroid_content_Context_ == IntPtr.Zero)
				id_d_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "d", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_d_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
