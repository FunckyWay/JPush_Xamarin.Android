using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='cn.jpush.android.api']/interface[@name='TagAliasCallback']"
	[Register ("cn/jpush/android/api/TagAliasCallback", "", "CN.Jpush.Android.Api.ITagAliasCallbackInvoker")]
	public partial interface ITagAliasCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/interface[@name='TagAliasCallback']/method[@name='gotResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("gotResult", "(ILjava/lang/String;Ljava/util/Set;)V", "GetGotResult_ILjava_lang_String_Ljava_util_Set_Handler:CN.Jpush.Android.Api.ITagAliasCallbackInvoker, JPush")]
		void GotResult (int p0, string p1, global::System.Collections.Generic.ICollection<string> p2);

	}

	[global::Android.Runtime.Register ("cn/jpush/android/api/TagAliasCallback", DoNotGenerateAcw=true)]
	internal class ITagAliasCallbackInvoker : global::Java.Lang.Object, ITagAliasCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("cn/jpush/android/api/TagAliasCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITagAliasCallbackInvoker); }
		}

		IntPtr class_ref;

		public static ITagAliasCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITagAliasCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "cn.jpush.android.api.TagAliasCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITagAliasCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_gotResult_ILjava_lang_String_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetGotResult_ILjava_lang_String_Ljava_util_Set_Handler ()
		{
			if (cb_gotResult_ILjava_lang_String_Ljava_util_Set_ == null)
				cb_gotResult_ILjava_lang_String_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_GotResult_ILjava_lang_String_Ljava_util_Set_);
			return cb_gotResult_ILjava_lang_String_Ljava_util_Set_;
		}

		static void n_GotResult_ILjava_lang_String_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jpush.Android.Api.ITagAliasCallback __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.ITagAliasCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GotResult (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_gotResult_ILjava_lang_String_Ljava_util_Set_;
		public unsafe void GotResult (int p0, string p1, global::System.Collections.Generic.ICollection<string> p2)
		{
			if (id_gotResult_ILjava_lang_String_Ljava_util_Set_ == IntPtr.Zero)
				id_gotResult_ILjava_lang_String_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "gotResult", "(ILjava/lang/String;Ljava/util/Set;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (Handle, id_gotResult_ILjava_lang_String_Ljava_util_Set_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

}
