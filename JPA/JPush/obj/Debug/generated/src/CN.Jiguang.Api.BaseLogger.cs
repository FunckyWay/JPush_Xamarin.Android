using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jiguang.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']"
	[global::Android.Runtime.Register ("cn/jiguang/api/BaseLogger", DoNotGenerateAcw=true)]
	public abstract partial class BaseLogger : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jiguang/api/BaseLogger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseLogger); }
		}

		protected BaseLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/constructor[@name='BaseLogger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseLogger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (BaseLogger)) {
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

		static Delegate cb_getCommonTag;
#pragma warning disable 0169
		static Delegate GetGetCommonTagHandler ()
		{
			if (cb_getCommonTag == null)
				cb_getCommonTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCommonTag);
			return cb_getCommonTag;
		}

		static IntPtr n_GetCommonTag (IntPtr jnienv, IntPtr native__this)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CommonTag);
		}
#pragma warning restore 0169

		public abstract string CommonTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='getCommonTag' and count(parameter)=0]"
			[Register ("getCommonTag", "()Ljava/lang/String;", "GetGetCommonTagHandler")] get;
		}

		static Delegate cb__d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
#pragma warning disable 0169
		static Delegate Get_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler ()
		{
			if (cb__d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == null)
				cb__d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n__d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_);
			return cb__d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		}

		static void n__d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object[] p2 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
			__this._d (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id__d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='_d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object...']]"
		[Register ("_d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", "Get_d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_Handler")]
		public virtual unsafe void _d (string p0, string p1, params global:: Java.Lang.Object[] p2)
		{
			if (id__d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ == IntPtr.Zero)
				id__d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "_d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id__d_Ljava_lang_String_Ljava_lang_String_arrayLjava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "_d", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_d_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_d_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_d_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_Ljava_lang_String_);
			return cb_d_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_D_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.D (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='d' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;)V", "GetD_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void D (string p0, string p1)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_D_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_D_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.D (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='d' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetD_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void D (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_d_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "d", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_dd_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDd_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_dd_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_dd_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dd_Ljava_lang_String_Ljava_lang_String_);
			return cb_dd_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Dd_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Dd (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_dd_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='dd' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("dd", "(Ljava/lang/String;Ljava/lang/String;)V", "GetDd_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Dd (string p0, string p1)
		{
			if (id_dd_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_dd_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "dd", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dd_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dd", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_dd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetDd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_dd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_dd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Dd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_dd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Dd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Dd (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_dd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='dd' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("dd", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetDd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Dd (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_dd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_dd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "dd", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_dd_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dd", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_Ljava_lang_String_);
			return cb_e_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.E (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;)V", "GetE_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void E (string p0, string p1)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_E_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.E (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='e' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetE_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void E (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_e_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "e", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_ee_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEe_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_ee_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_ee_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Ee_Ljava_lang_String_Ljava_lang_String_);
			return cb_ee_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Ee_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Ee (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ee_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='ee' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("ee", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEe_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Ee (string p0, string p1)
		{
			if (id_ee_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ee_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "ee", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ee_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ee", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_ee_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetEe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_ee_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_ee_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Ee_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_ee_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Ee_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Ee (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_ee_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='ee' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("ee", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetEe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Ee (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_ee_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_ee_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "ee", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ee_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ee", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_flushCached2File;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='flushCached2File' and count(parameter)=0]"
		[Register ("flushCached2File", "()V", "")]
		public static unsafe void FlushCached2File ()
		{
			if (id_flushCached2File == IntPtr.Zero)
				id_flushCached2File = JNIEnv.GetStaticMethodID (class_ref, "flushCached2File", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_flushCached2File);
			} finally {
			}
		}

		static Delegate cb_i_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_i_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_i_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_I_Ljava_lang_String_Ljava_lang_String_);
			return cb_i_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_I_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.I (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;)V", "GetI_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void I (string p0, string p1)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_i_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "i", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_I_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_I_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.I (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='i' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetI_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void I (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_i_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "i", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_ii_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIi_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_ii_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_ii_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Ii_Ljava_lang_String_Ljava_lang_String_);
			return cb_ii_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Ii_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Ii (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ii_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='ii' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("ii", "(Ljava/lang/String;Ljava/lang/String;)V", "GetIi_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Ii (string p0, string p1)
		{
			if (id_ii_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ii_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "ii", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ii_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ii", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_ii_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetIi_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_ii_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_ii_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Ii_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_ii_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Ii_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Ii (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_ii_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='ii' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("ii", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetIi_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Ii (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_ii_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_ii_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "ii", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ii_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ii", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_v_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_v_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_v_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_V_Ljava_lang_String_Ljava_lang_String_);
			return cb_v_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_V_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.V (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;)V", "GetV_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void V (string p0, string p1)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_v_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "v", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_V_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_V_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.V (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='v' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetV_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void V (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_v_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "v", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_vv_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetVv_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_vv_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_vv_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Vv_Ljava_lang_String_Ljava_lang_String_);
			return cb_vv_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Vv_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Vv (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_vv_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='vv' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("vv", "(Ljava/lang/String;Ljava/lang/String;)V", "GetVv_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Vv (string p0, string p1)
		{
			if (id_vv_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_vv_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "vv", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_vv_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vv", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_vv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetVv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_vv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_vv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Vv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_vv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Vv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Vv (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_vv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='vv' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("vv", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetVv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Vv (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_vv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_vv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "vv", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_vv_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vv", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_w_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_w_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_w_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_W_Ljava_lang_String_Ljava_lang_String_);
			return cb_w_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_W_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.W (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;)V", "GetW_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void W (string p0, string p1)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_w_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "w", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_W_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_W_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.W (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='w' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetW_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void W (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_w_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "w", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_ww_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWw_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_ww_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_ww_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Ww_Ljava_lang_String_Ljava_lang_String_);
			return cb_ww_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Ww_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Ww (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_ww_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='ww' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("ww", "(Ljava/lang/String;Ljava/lang/String;)V", "GetWw_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Ww (string p0, string p1)
		{
			if (id_ww_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_ww_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "ww", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ww_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ww", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_ww_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetWw_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_ww_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_ww_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Ww_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_ww_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_Ww_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jiguang.Api.BaseLogger __this = global::Java.Lang.Object.GetObject<global::CN.Jiguang.Api.BaseLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Ww (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_ww_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='ww' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Throwable']]"
		[Register ("ww", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", "GetWw_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void Ww (string p0, string p1, global::Java.Lang.Throwable p2)
		{
			if (id_ww_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_ww_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "ww", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_ww_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Throwable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "ww", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

	[global::Android.Runtime.Register ("cn/jiguang/api/BaseLogger", DoNotGenerateAcw=true)]
	internal partial class BaseLoggerInvoker : BaseLogger {

		public BaseLoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BaseLoggerInvoker); }
		}

		static IntPtr id_getCommonTag;
		public override unsafe string CommonTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='cn.jiguang.api']/class[@name='BaseLogger']/method[@name='getCommonTag' and count(parameter)=0]"
			[Register ("getCommonTag", "()Ljava/lang/String;", "GetGetCommonTagHandler")]
			get {
				if (id_getCommonTag == IntPtr.Zero)
					id_getCommonTag = JNIEnv.GetMethodID (class_ref, "getCommonTag", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCommonTag), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}

}
