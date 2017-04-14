using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='PushActivity']"
	[global::Android.Runtime.Register ("cn/jpush/android/ui/PushActivity", DoNotGenerateAcw=true)]
	public partial class PushActivity : global::Android.App.Activity {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/ui/PushActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PushActivity); }
		}

		protected PushActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='PushActivity']/constructor[@name='PushActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PushActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PushActivity)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='PushActivity']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public unsafe void A ()
		{
			if (id_a == IntPtr.Zero)
				id_a = JNIEnv.GetMethodID (class_ref, "a", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_a);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.ui']/class[@name='PushActivity']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public unsafe void B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()V");
			try {
				JNIEnv.CallVoidMethod  (Handle, id_b);
			} finally {
			}
		}

	}
}
