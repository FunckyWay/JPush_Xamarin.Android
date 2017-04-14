using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/CustomPushNotificationBuilder", DoNotGenerateAcw=true)]
	public partial class CustomPushNotificationBuilder : global::CN.Jpush.Android.Api.BasicPushNotificationBuilder {


		static IntPtr layout_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/field[@name='layout']"
		[Register ("layout")]
		public int Layout {
			get {
				if (layout_jfieldId == IntPtr.Zero)
					layout_jfieldId = JNIEnv.GetFieldID (class_ref, "layout", "I");
				return JNIEnv.GetIntField (Handle, layout_jfieldId);
			}
			set {
				if (layout_jfieldId == IntPtr.Zero)
					layout_jfieldId = JNIEnv.GetFieldID (class_ref, "layout", "I");
				try {
					JNIEnv.SetField (Handle, layout_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr layoutContentId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/field[@name='layoutContentId']"
		[Register ("layoutContentId")]
		public int LayoutContentId {
			get {
				if (layoutContentId_jfieldId == IntPtr.Zero)
					layoutContentId_jfieldId = JNIEnv.GetFieldID (class_ref, "layoutContentId", "I");
				return JNIEnv.GetIntField (Handle, layoutContentId_jfieldId);
			}
			set {
				if (layoutContentId_jfieldId == IntPtr.Zero)
					layoutContentId_jfieldId = JNIEnv.GetFieldID (class_ref, "layoutContentId", "I");
				try {
					JNIEnv.SetField (Handle, layoutContentId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr layoutIconDrawable_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/field[@name='layoutIconDrawable']"
		[Register ("layoutIconDrawable")]
		public int LayoutIconDrawable {
			get {
				if (layoutIconDrawable_jfieldId == IntPtr.Zero)
					layoutIconDrawable_jfieldId = JNIEnv.GetFieldID (class_ref, "layoutIconDrawable", "I");
				return JNIEnv.GetIntField (Handle, layoutIconDrawable_jfieldId);
			}
			set {
				if (layoutIconDrawable_jfieldId == IntPtr.Zero)
					layoutIconDrawable_jfieldId = JNIEnv.GetFieldID (class_ref, "layoutIconDrawable", "I");
				try {
					JNIEnv.SetField (Handle, layoutIconDrawable_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr layoutIconId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/field[@name='layoutIconId']"
		[Register ("layoutIconId")]
		public int LayoutIconId {
			get {
				if (layoutIconId_jfieldId == IntPtr.Zero)
					layoutIconId_jfieldId = JNIEnv.GetFieldID (class_ref, "layoutIconId", "I");
				return JNIEnv.GetIntField (Handle, layoutIconId_jfieldId);
			}
			set {
				if (layoutIconId_jfieldId == IntPtr.Zero)
					layoutIconId_jfieldId = JNIEnv.GetFieldID (class_ref, "layoutIconId", "I");
				try {
					JNIEnv.SetField (Handle, layoutIconId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr layoutTitleId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/field[@name='layoutTitleId']"
		[Register ("layoutTitleId")]
		public int LayoutTitleId {
			get {
				if (layoutTitleId_jfieldId == IntPtr.Zero)
					layoutTitleId_jfieldId = JNIEnv.GetFieldID (class_ref, "layoutTitleId", "I");
				return JNIEnv.GetIntField (Handle, layoutTitleId_jfieldId);
			}
			set {
				if (layoutTitleId_jfieldId == IntPtr.Zero)
					layoutTitleId_jfieldId = JNIEnv.GetFieldID (class_ref, "layoutTitleId", "I");
				try {
					JNIEnv.SetField (Handle, layoutTitleId_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/api/CustomPushNotificationBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CustomPushNotificationBuilder); }
		}

		protected CustomPushNotificationBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='CustomPushNotificationBuilder']/constructor[@name='CustomPushNotificationBuilder' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;IIII)V", "")]
		public unsafe CustomPushNotificationBuilder (global::Android.Content.Context p0, int p1, int p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (CustomPushNotificationBuilder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;IIII)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_IIII == IntPtr.Zero)
					id_ctor_Landroid_content_Context_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_IIII, __args);
			} finally {
			}
		}

	}
}
