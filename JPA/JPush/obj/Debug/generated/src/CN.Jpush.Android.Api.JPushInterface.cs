using System;
using System.Collections.Generic;
using Android.Runtime;

namespace CN.Jpush.Android.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']"
	[global::Android.Runtime.Register ("cn/jpush/android/api/JPushInterface", DoNotGenerateAcw=true)]
	public partial class JPushInterface : global::Java.Lang.Object {


		static IntPtr ACTION_ACTIVITY_OPENDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_ACTIVITY_OPENDED']"
		[Register ("ACTION_ACTIVITY_OPENDED")]
		public static string ActionActivityOpended {
			get {
				if (ACTION_ACTIVITY_OPENDED_jfieldId == IntPtr.Zero)
					ACTION_ACTIVITY_OPENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_ACTIVITY_OPENDED", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_ACTIVITY_OPENDED_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_CONNECTION_CHANGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_CONNECTION_CHANGE']"
		[Register ("ACTION_CONNECTION_CHANGE")]
		public static string ActionConnectionChange {
			get {
				if (ACTION_CONNECTION_CHANGE_jfieldId == IntPtr.Zero)
					ACTION_CONNECTION_CHANGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_CONNECTION_CHANGE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_CONNECTION_CHANGE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_MESSAGE_RECEIVED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_MESSAGE_RECEIVED']"
		[Register ("ACTION_MESSAGE_RECEIVED")]
		public static string ActionMessageReceived {
			get {
				if (ACTION_MESSAGE_RECEIVED_jfieldId == IntPtr.Zero)
					ACTION_MESSAGE_RECEIVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_MESSAGE_RECEIVED", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_MESSAGE_RECEIVED_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_NOTIFICATION_CLICK_ACTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_NOTIFICATION_CLICK_ACTION']"
		[Register ("ACTION_NOTIFICATION_CLICK_ACTION")]
		public static string ActionNotificationClickAction {
			get {
				if (ACTION_NOTIFICATION_CLICK_ACTION_jfieldId == IntPtr.Zero)
					ACTION_NOTIFICATION_CLICK_ACTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_NOTIFICATION_CLICK_ACTION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_NOTIFICATION_CLICK_ACTION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_NOTIFICATION_OPENED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_NOTIFICATION_OPENED']"
		[Register ("ACTION_NOTIFICATION_OPENED")]
		public static string ActionNotificationOpened {
			get {
				if (ACTION_NOTIFICATION_OPENED_jfieldId == IntPtr.Zero)
					ACTION_NOTIFICATION_OPENED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_NOTIFICATION_OPENED", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_NOTIFICATION_OPENED_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_NOTIFICATION_RECEIVED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_NOTIFICATION_RECEIVED']"
		[Register ("ACTION_NOTIFICATION_RECEIVED")]
		public static string ActionNotificationReceived {
			get {
				if (ACTION_NOTIFICATION_RECEIVED_jfieldId == IntPtr.Zero)
					ACTION_NOTIFICATION_RECEIVED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_NOTIFICATION_RECEIVED", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_NOTIFICATION_RECEIVED_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_NOTIFICATION_RECEIVED_PROXY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_NOTIFICATION_RECEIVED_PROXY']"
		[Register ("ACTION_NOTIFICATION_RECEIVED_PROXY")]
		public static string ActionNotificationReceivedProxy {
			get {
				if (ACTION_NOTIFICATION_RECEIVED_PROXY_jfieldId == IntPtr.Zero)
					ACTION_NOTIFICATION_RECEIVED_PROXY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_NOTIFICATION_RECEIVED_PROXY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_NOTIFICATION_RECEIVED_PROXY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_REGISTRATION_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_REGISTRATION_ID']"
		[Register ("ACTION_REGISTRATION_ID")]
		public static string ActionRegistrationId {
			get {
				if (ACTION_REGISTRATION_ID_jfieldId == IntPtr.Zero)
					ACTION_REGISTRATION_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_REGISTRATION_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_REGISTRATION_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_RESTOREPUSH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_RESTOREPUSH']"
		[Register ("ACTION_RESTOREPUSH")]
		public static string ActionRestorepush {
			get {
				if (ACTION_RESTOREPUSH_jfieldId == IntPtr.Zero)
					ACTION_RESTOREPUSH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_RESTOREPUSH", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_RESTOREPUSH_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_RICHPUSH_CALLBACK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_RICHPUSH_CALLBACK']"
		[Register ("ACTION_RICHPUSH_CALLBACK")]
		public static string ActionRichpushCallback {
			get {
				if (ACTION_RICHPUSH_CALLBACK_jfieldId == IntPtr.Zero)
					ACTION_RICHPUSH_CALLBACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_RICHPUSH_CALLBACK", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_RICHPUSH_CALLBACK_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_STATUS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_STATUS']"
		[Register ("ACTION_STATUS")]
		public static string ActionStatus {
			get {
				if (ACTION_STATUS_jfieldId == IntPtr.Zero)
					ACTION_STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_STATUS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_STATUS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ACTION_STOPPUSH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='ACTION_STOPPUSH']"
		[Register ("ACTION_STOPPUSH")]
		public static string ActionStoppush {
			get {
				if (ACTION_STOPPUSH_jfieldId == IntPtr.Zero)
					ACTION_STOPPUSH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTION_STOPPUSH", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTION_STOPPUSH_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_ACTIVITY_PARAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_ACTIVITY_PARAM']"
		[Register ("EXTRA_ACTIVITY_PARAM")]
		public static string ExtraActivityParam {
			get {
				if (EXTRA_ACTIVITY_PARAM_jfieldId == IntPtr.Zero)
					EXTRA_ACTIVITY_PARAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_ACTIVITY_PARAM", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_ACTIVITY_PARAM_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_ALERT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_ALERT']"
		[Register ("EXTRA_ALERT")]
		public static string ExtraAlert {
			get {
				if (EXTRA_ALERT_jfieldId == IntPtr.Zero)
					EXTRA_ALERT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_ALERT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_ALERT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_APP_KEY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_APP_KEY']"
		[Register ("EXTRA_APP_KEY")]
		public static string ExtraAppKey {
			get {
				if (EXTRA_APP_KEY_jfieldId == IntPtr.Zero)
					EXTRA_APP_KEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_APP_KEY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_APP_KEY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_BIG_PIC_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_BIG_PIC_PATH']"
		[Register ("EXTRA_BIG_PIC_PATH")]
		public static string ExtraBigPicPath {
			get {
				if (EXTRA_BIG_PIC_PATH_jfieldId == IntPtr.Zero)
					EXTRA_BIG_PIC_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_BIG_PIC_PATH", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_BIG_PIC_PATH_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_BIG_TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_BIG_TEXT']"
		[Register ("EXTRA_BIG_TEXT")]
		public static string ExtraBigText {
			get {
				if (EXTRA_BIG_TEXT_jfieldId == IntPtr.Zero)
					EXTRA_BIG_TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_BIG_TEXT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_BIG_TEXT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_CONNECTION_CHANGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_CONNECTION_CHANGE']"
		[Register ("EXTRA_CONNECTION_CHANGE")]
		public static string ExtraConnectionChange {
			get {
				if (EXTRA_CONNECTION_CHANGE_jfieldId == IntPtr.Zero)
					EXTRA_CONNECTION_CHANGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_CONNECTION_CHANGE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_CONNECTION_CHANGE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_CONTENT_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_CONTENT_TYPE']"
		[Register ("EXTRA_CONTENT_TYPE")]
		public static string ExtraContentType {
			get {
				if (EXTRA_CONTENT_TYPE_jfieldId == IntPtr.Zero)
					EXTRA_CONTENT_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_CONTENT_TYPE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_CONTENT_TYPE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_EXTRA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_EXTRA']"
		[Register ("EXTRA_EXTRA")]
		public static string ExtraExtra {
			get {
				if (EXTRA_EXTRA_jfieldId == IntPtr.Zero)
					EXTRA_EXTRA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_EXTRA", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_EXTRA_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_INBOX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_INBOX']"
		[Register ("EXTRA_INBOX")]
		public static string ExtraInbox {
			get {
				if (EXTRA_INBOX_jfieldId == IntPtr.Zero)
					EXTRA_INBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_INBOX", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_INBOX_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_MESSAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_MESSAGE']"
		[Register ("EXTRA_MESSAGE")]
		public static string ExtraMessage {
			get {
				if (EXTRA_MESSAGE_jfieldId == IntPtr.Zero)
					EXTRA_MESSAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_MESSAGE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_MESSAGE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_MSG_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_MSG_ID']"
		[Register ("EXTRA_MSG_ID")]
		public static string ExtraMsgId {
			get {
				if (EXTRA_MSG_ID_jfieldId == IntPtr.Zero)
					EXTRA_MSG_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_MSG_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_MSG_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_NOTIFICATION_ACTION_EXTRA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTIFICATION_ACTION_EXTRA']"
		[Register ("EXTRA_NOTIFICATION_ACTION_EXTRA")]
		public static string ExtraNotificationActionExtra {
			get {
				if (EXTRA_NOTIFICATION_ACTION_EXTRA_jfieldId == IntPtr.Zero)
					EXTRA_NOTIFICATION_ACTION_EXTRA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_NOTIFICATION_ACTION_EXTRA", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_NOTIFICATION_ACTION_EXTRA_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_NOTIFICATION_DEVELOPER_ARG0_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTIFICATION_DEVELOPER_ARG0']"
		[Register ("EXTRA_NOTIFICATION_DEVELOPER_ARG0")]
		public static string ExtraNotificationDeveloperArg0 {
			get {
				if (EXTRA_NOTIFICATION_DEVELOPER_ARG0_jfieldId == IntPtr.Zero)
					EXTRA_NOTIFICATION_DEVELOPER_ARG0_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_NOTIFICATION_DEVELOPER_ARG0", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_NOTIFICATION_DEVELOPER_ARG0_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_NOTIFICATION_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTIFICATION_ID']"
		[Register ("EXTRA_NOTIFICATION_ID")]
		public static string ExtraNotificationId {
			get {
				if (EXTRA_NOTIFICATION_ID_jfieldId == IntPtr.Zero)
					EXTRA_NOTIFICATION_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_NOTIFICATION_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_NOTIFICATION_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_NOTIFICATION_TITLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTIFICATION_TITLE']"
		[Register ("EXTRA_NOTIFICATION_TITLE")]
		public static string ExtraNotificationTitle {
			get {
				if (EXTRA_NOTIFICATION_TITLE_jfieldId == IntPtr.Zero)
					EXTRA_NOTIFICATION_TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_NOTIFICATION_TITLE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_NOTIFICATION_TITLE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_NOTI_CATEGORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTI_CATEGORY']"
		[Register ("EXTRA_NOTI_CATEGORY")]
		public static string ExtraNotiCategory {
			get {
				if (EXTRA_NOTI_CATEGORY_jfieldId == IntPtr.Zero)
					EXTRA_NOTI_CATEGORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_NOTI_CATEGORY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_NOTI_CATEGORY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_NOTI_PRIORITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTI_PRIORITY']"
		[Register ("EXTRA_NOTI_PRIORITY")]
		public static string ExtraNotiPriority {
			get {
				if (EXTRA_NOTI_PRIORITY_jfieldId == IntPtr.Zero)
					EXTRA_NOTI_PRIORITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_NOTI_PRIORITY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_NOTI_PRIORITY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_NOTI_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_NOTI_TYPE']"
		[Register ("EXTRA_NOTI_TYPE")]
		public static string ExtraNotiType {
			get {
				if (EXTRA_NOTI_TYPE_jfieldId == IntPtr.Zero)
					EXTRA_NOTI_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_NOTI_TYPE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_NOTI_TYPE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_PUSH_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_PUSH_ID']"
		[Register ("EXTRA_PUSH_ID")]
		public static string ExtraPushId {
			get {
				if (EXTRA_PUSH_ID_jfieldId == IntPtr.Zero)
					EXTRA_PUSH_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_PUSH_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_PUSH_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_REGISTRATION_ID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_REGISTRATION_ID']"
		[Register ("EXTRA_REGISTRATION_ID")]
		public static string ExtraRegistrationId {
			get {
				if (EXTRA_REGISTRATION_ID_jfieldId == IntPtr.Zero)
					EXTRA_REGISTRATION_ID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_REGISTRATION_ID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_REGISTRATION_ID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_RICHPUSH_FILE_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_RICHPUSH_FILE_PATH']"
		[Register ("EXTRA_RICHPUSH_FILE_PATH")]
		public static string ExtraRichpushFilePath {
			get {
				if (EXTRA_RICHPUSH_FILE_PATH_jfieldId == IntPtr.Zero)
					EXTRA_RICHPUSH_FILE_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_RICHPUSH_FILE_PATH", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_RICHPUSH_FILE_PATH_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_RICHPUSH_FILE_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_RICHPUSH_FILE_TYPE']"
		[Register ("EXTRA_RICHPUSH_FILE_TYPE")]
		public static string ExtraRichpushFileType {
			get {
				if (EXTRA_RICHPUSH_FILE_TYPE_jfieldId == IntPtr.Zero)
					EXTRA_RICHPUSH_FILE_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_RICHPUSH_FILE_TYPE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_RICHPUSH_FILE_TYPE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_RICHPUSH_HTML_PATH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_RICHPUSH_HTML_PATH']"
		[Register ("EXTRA_RICHPUSH_HTML_PATH")]
		public static string ExtraRichpushHtmlPath {
			get {
				if (EXTRA_RICHPUSH_HTML_PATH_jfieldId == IntPtr.Zero)
					EXTRA_RICHPUSH_HTML_PATH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_RICHPUSH_HTML_PATH", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_RICHPUSH_HTML_PATH_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_RICHPUSH_HTML_RES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_RICHPUSH_HTML_RES']"
		[Register ("EXTRA_RICHPUSH_HTML_RES")]
		public static string ExtraRichpushHtmlRes {
			get {
				if (EXTRA_RICHPUSH_HTML_RES_jfieldId == IntPtr.Zero)
					EXTRA_RICHPUSH_HTML_RES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_RICHPUSH_HTML_RES", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_RICHPUSH_HTML_RES_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_STATUS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_STATUS']"
		[Register ("EXTRA_STATUS")]
		public static string ExtraStatus {
			get {
				if (EXTRA_STATUS_jfieldId == IntPtr.Zero)
					EXTRA_STATUS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_STATUS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_STATUS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr EXTRA_TITLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/field[@name='EXTRA_TITLE']"
		[Register ("EXTRA_TITLE")]
		public static string ExtraTitle {
			get {
				if (EXTRA_TITLE_jfieldId == IntPtr.Zero)
					EXTRA_TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_TITLE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_TITLE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("cn/jpush/android/api/JPushInterface", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JPushInterface); }
		}

		protected JPushInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/constructor[@name='JPushInterface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JPushInterface ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (JPushInterface)) {
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

		static IntPtr id_addLocalNotification_Landroid_content_Context_Lcn_jpush_android_data_JPushLocalNotification_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='addLocalNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='cn.jpush.android.data.JPushLocalNotification']]"
		[Register ("addLocalNotification", "(Landroid/content/Context;Lcn/jpush/android/data/JPushLocalNotification;)V", "")]
		public static unsafe void AddLocalNotification (global::Android.Content.Context p0, global::CN.Jpush.Android.Data.JPushLocalNotification p1)
		{
			if (id_addLocalNotification_Landroid_content_Context_Lcn_jpush_android_data_JPushLocalNotification_ == IntPtr.Zero)
				id_addLocalNotification_Landroid_content_Context_Lcn_jpush_android_data_JPushLocalNotification_ = JNIEnv.GetStaticMethodID (class_ref, "addLocalNotification", "(Landroid/content/Context;Lcn/jpush/android/data/JPushLocalNotification;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addLocalNotification_Landroid_content_Context_Lcn_jpush_android_data_JPushLocalNotification_, __args);
			} finally {
			}
		}

		static IntPtr id_clearAllNotifications_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='clearAllNotifications' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearAllNotifications", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearAllNotifications (global::Android.Content.Context p0)
		{
			if (id_clearAllNotifications_Landroid_content_Context_ == IntPtr.Zero)
				id_clearAllNotifications_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearAllNotifications", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearAllNotifications_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_clearLocalNotifications_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='clearLocalNotifications' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearLocalNotifications", "(Landroid/content/Context;)V", "")]
		public static unsafe void ClearLocalNotifications (global::Android.Content.Context p0)
		{
			if (id_clearLocalNotifications_Landroid_content_Context_ == IntPtr.Zero)
				id_clearLocalNotifications_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "clearLocalNotifications", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearLocalNotifications_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_clearNotificationById_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='clearNotificationById' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("clearNotificationById", "(Landroid/content/Context;I)V", "")]
		public static unsafe void ClearNotificationById (global::Android.Content.Context p0, int p1)
		{
			if (id_clearNotificationById_Landroid_content_Context_I == IntPtr.Zero)
				id_clearNotificationById_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "clearNotificationById", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearNotificationById_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_filterValidTags_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='filterValidTags' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("filterValidTags", "(Ljava/util/Set;)Ljava/util/Set;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<string> FilterValidTags (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_filterValidTags_Ljava_util_Set_ == IntPtr.Zero)
				id_filterValidTags_Ljava_util_Set_ = JNIEnv.GetStaticMethodID (class_ref, "filterValidTags", "(Ljava/util/Set;)Ljava/util/Set;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::System.Collections.Generic.ICollection<string> __ret = global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterValidTags_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getConnectionState_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='getConnectionState' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_getRegistrationID_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='getRegistrationID' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_getStringTags_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='getStringTags' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getStringTags", "(Ljava/util/Set;)Ljava/lang/String;", "")]
		public static unsafe string GetStringTags (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_getStringTags_Ljava_util_Set_ == IntPtr.Zero)
				id_getStringTags_Ljava_util_Set_ = JNIEnv.GetStaticMethodID (class_ref, "getStringTags", "(Ljava/util/Set;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStringTags_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getUdid_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='getUdid' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUdid", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetUdid (global::Android.Content.Context p0)
		{
			if (id_getUdid_Landroid_content_Context_ == IntPtr.Zero)
				id_getUdid_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getUdid", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUdid_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			if (id_init_Landroid_content_Context_ == IntPtr.Zero)
				id_init_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_init_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_initCrashHandler_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='initCrashHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_isPushStopped_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='isPushStopped' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isPushStopped", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsPushStopped (global::Android.Content.Context p0)
		{
			if (id_isPushStopped_Landroid_content_Context_ == IntPtr.Zero)
				id_isPushStopped_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isPushStopped", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPushStopped_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onFragmentPause_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='onFragmentPause' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='onFragmentResume' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='onKillProcess' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_onPause_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onPause", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnPause (global::Android.Content.Context p0)
		{
			if (id_onPause_Landroid_content_Context_ == IntPtr.Zero)
				id_onPause_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "onPause", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onPause_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_onResume_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onResume", "(Landroid/content/Context;)V", "")]
		public static unsafe void OnResume (global::Android.Content.Context p0)
		{
			if (id_onResume_Landroid_content_Context_ == IntPtr.Zero)
				id_onResume_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "onResume", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onResume_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_removeLocalNotification_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='removeLocalNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("removeLocalNotification", "(Landroid/content/Context;J)V", "")]
		public static unsafe void RemoveLocalNotification (global::Android.Content.Context p0, long p1)
		{
			if (id_removeLocalNotification_Landroid_content_Context_J == IntPtr.Zero)
				id_removeLocalNotification_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "removeLocalNotification", "(Landroid/content/Context;J)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeLocalNotification_Landroid_content_Context_J, __args);
			} finally {
			}
		}

		static IntPtr id_reportNotificationOpened_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='reportNotificationOpened' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportNotificationOpened", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void ReportNotificationOpened (global::Android.Content.Context p0, string p1)
		{
			if (id_reportNotificationOpened_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_reportNotificationOpened_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "reportNotificationOpened", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportNotificationOpened_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_requestPermission_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='requestPermission' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_resumePush_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='resumePush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("resumePush", "(Landroid/content/Context;)V", "")]
		public static unsafe void ResumePush (global::Android.Content.Context p0)
		{
			if (id_resumePush_Landroid_content_Context_ == IntPtr.Zero)
				id_resumePush_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "resumePush", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_resumePush_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_setAlias_Landroid_content_Context_Ljava_lang_String_Lcn_jpush_android_api_TagAliasCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setAlias' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='cn.jpush.android.api.TagAliasCallback']]"
		[Register ("setAlias", "(Landroid/content/Context;Ljava/lang/String;Lcn/jpush/android/api/TagAliasCallback;)V", "")]
		public static unsafe void SetAlias (global::Android.Content.Context p0, string p1, global::CN.Jpush.Android.Api.ITagAliasCallback p2)
		{
			if (id_setAlias_Landroid_content_Context_Ljava_lang_String_Lcn_jpush_android_api_TagAliasCallback_ == IntPtr.Zero)
				id_setAlias_Landroid_content_Context_Ljava_lang_String_Lcn_jpush_android_api_TagAliasCallback_ = JNIEnv.GetStaticMethodID (class_ref, "setAlias", "(Landroid/content/Context;Ljava/lang/String;Lcn/jpush/android/api/TagAliasCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAlias_Landroid_content_Context_Ljava_lang_String_Lcn_jpush_android_api_TagAliasCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_Handler ()
		{
			if (cb_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_ == null)
				cb_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_);
			return cb_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_;
		}

		static void n_SetAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::CN.Jpush.Android.Api.JPushInterface __this = global::Java.Lang.Object.GetObject<global::CN.Jpush.Android.Api.JPushInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetAliasAndTags (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setAliasAndTags' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("setAliasAndTags", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Set;)V", "GetSetAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_Handler")]
		public virtual unsafe void SetAliasAndTags (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.ICollection<string> p2)
		{
			if (id_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_ == IntPtr.Zero)
				id_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "setAliasAndTags", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Set;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAliasAndTags", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Set;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_Lcn_jpush_android_api_TagAliasCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setAliasAndTags' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[4][@type='cn.jpush.android.api.TagAliasCallback']]"
		[Register ("setAliasAndTags", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Set;Lcn/jpush/android/api/TagAliasCallback;)V", "")]
		public static unsafe void SetAliasAndTags (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.ICollection<string> p2, global::CN.Jpush.Android.Api.ITagAliasCallback p3)
		{
			if (id_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_Lcn_jpush_android_api_TagAliasCallback_ == IntPtr.Zero)
				id_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_Lcn_jpush_android_api_TagAliasCallback_ = JNIEnv.GetStaticMethodID (class_ref, "setAliasAndTags", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Set;Lcn/jpush/android/api/TagAliasCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAliasAndTags_Landroid_content_Context_Ljava_lang_String_Ljava_util_Set_Lcn_jpush_android_api_TagAliasCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_setDebugMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setDebugMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebugMode", "(Z)V", "")]
		public static unsafe void SetDebugMode (bool p0)
		{
			if (id_setDebugMode_Z == IntPtr.Zero)
				id_setDebugMode_Z = JNIEnv.GetStaticMethodID (class_ref, "setDebugMode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebugMode_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setDefaultPushNotificationBuilder_Lcn_jpush_android_api_BasicPushNotificationBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setDefaultPushNotificationBuilder' and count(parameter)=1 and parameter[1][@type='cn.jpush.android.api.BasicPushNotificationBuilder']]"
		[Register ("setDefaultPushNotificationBuilder", "(Lcn/jpush/android/api/BasicPushNotificationBuilder;)V", "")]
		public static unsafe void SetDefaultPushNotificationBuilder (global::CN.Jpush.Android.Api.BasicPushNotificationBuilder p0)
		{
			if (id_setDefaultPushNotificationBuilder_Lcn_jpush_android_api_BasicPushNotificationBuilder_ == IntPtr.Zero)
				id_setDefaultPushNotificationBuilder_Lcn_jpush_android_api_BasicPushNotificationBuilder_ = JNIEnv.GetStaticMethodID (class_ref, "setDefaultPushNotificationBuilder", "(Lcn/jpush/android/api/BasicPushNotificationBuilder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDefaultPushNotificationBuilder_Lcn_jpush_android_api_BasicPushNotificationBuilder_, __args);
			} finally {
			}
		}

		static IntPtr id_setLatestNotificationNumber_Landroid_content_Context_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setLatestNotificationNumber' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("setLatestNotificationNumber", "(Landroid/content/Context;I)V", "")]
		public static unsafe void SetLatestNotificationNumber (global::Android.Content.Context p0, int p1)
		{
			if (id_setLatestNotificationNumber_Landroid_content_Context_I == IntPtr.Zero)
				id_setLatestNotificationNumber_Landroid_content_Context_I = JNIEnv.GetStaticMethodID (class_ref, "setLatestNotificationNumber", "(Landroid/content/Context;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLatestNotificationNumber_Landroid_content_Context_I, __args);
			} finally {
			}
		}

		static IntPtr id_setPushNotificationBuilder_Ljava_lang_Integer_Lcn_jpush_android_api_DefaultPushNotificationBuilder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setPushNotificationBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='cn.jpush.android.api.DefaultPushNotificationBuilder']]"
		[Register ("setPushNotificationBuilder", "(Ljava/lang/Integer;Lcn/jpush/android/api/DefaultPushNotificationBuilder;)V", "")]
		public static unsafe void SetPushNotificationBuilder (global::Java.Lang.Integer p0, global::CN.Jpush.Android.Api.DefaultPushNotificationBuilder p1)
		{
			if (id_setPushNotificationBuilder_Ljava_lang_Integer_Lcn_jpush_android_api_DefaultPushNotificationBuilder_ == IntPtr.Zero)
				id_setPushNotificationBuilder_Ljava_lang_Integer_Lcn_jpush_android_api_DefaultPushNotificationBuilder_ = JNIEnv.GetStaticMethodID (class_ref, "setPushNotificationBuilder", "(Ljava/lang/Integer;Lcn/jpush/android/api/DefaultPushNotificationBuilder;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPushNotificationBuilder_Ljava_lang_Integer_Lcn_jpush_android_api_DefaultPushNotificationBuilder_, __args);
			} finally {
			}
		}

		static IntPtr id_setPushTime_Landroid_content_Context_Ljava_util_Set_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setPushTime' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Set&lt;java.lang.Integer&gt;'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setPushTime", "(Landroid/content/Context;Ljava/util/Set;II)V", "")]
		public static unsafe void SetPushTime (global::Android.Content.Context p0, global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p1, int p2, int p3)
		{
			if (id_setPushTime_Landroid_content_Context_Ljava_util_Set_II == IntPtr.Zero)
				id_setPushTime_Landroid_content_Context_Ljava_util_Set_II = JNIEnv.GetStaticMethodID (class_ref, "setPushTime", "(Landroid/content/Context;Ljava/util/Set;II)V");
			IntPtr native_p1 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setPushTime_Landroid_content_Context_Ljava_util_Set_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_setSilenceTime_Landroid_content_Context_IIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setSilenceTime' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("setSilenceTime", "(Landroid/content/Context;IIII)V", "")]
		public static unsafe void SetSilenceTime (global::Android.Content.Context p0, int p1, int p2, int p3, int p4)
		{
			if (id_setSilenceTime_Landroid_content_Context_IIII == IntPtr.Zero)
				id_setSilenceTime_Landroid_content_Context_IIII = JNIEnv.GetStaticMethodID (class_ref, "setSilenceTime", "(Landroid/content/Context;IIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSilenceTime_Landroid_content_Context_IIII, __args);
			} finally {
			}
		}

		static IntPtr id_setStatisticsEnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setStatisticsEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setStatisticsEnable", "(Z)V", "")]
		public static unsafe void SetStatisticsEnable (bool p0)
		{
			if (id_setStatisticsEnable_Z == IntPtr.Zero)
				id_setStatisticsEnable_Z = JNIEnv.GetStaticMethodID (class_ref, "setStatisticsEnable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setStatisticsEnable_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setStatisticsSessionTimeout_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setStatisticsSessionTimeout' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setStatisticsSessionTimeout", "(J)V", "")]
		public static unsafe void SetStatisticsSessionTimeout (long p0)
		{
			if (id_setStatisticsSessionTimeout_J == IntPtr.Zero)
				id_setStatisticsSessionTimeout_J = JNIEnv.GetStaticMethodID (class_ref, "setStatisticsSessionTimeout", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setStatisticsSessionTimeout_J, __args);
			} finally {
			}
		}

		static IntPtr id_setTags_Landroid_content_Context_Ljava_util_Set_Lcn_jpush_android_api_TagAliasCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='setTags' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[3][@type='cn.jpush.android.api.TagAliasCallback']]"
		[Register ("setTags", "(Landroid/content/Context;Ljava/util/Set;Lcn/jpush/android/api/TagAliasCallback;)V", "")]
		public static unsafe void SetTags (global::Android.Content.Context p0, global::System.Collections.Generic.ICollection<string> p1, global::CN.Jpush.Android.Api.ITagAliasCallback p2)
		{
			if (id_setTags_Landroid_content_Context_Ljava_util_Set_Lcn_jpush_android_api_TagAliasCallback_ == IntPtr.Zero)
				id_setTags_Landroid_content_Context_Ljava_util_Set_Lcn_jpush_android_api_TagAliasCallback_ = JNIEnv.GetStaticMethodID (class_ref, "setTags", "(Landroid/content/Context;Ljava/util/Set;Lcn/jpush/android/api/TagAliasCallback;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setTags_Landroid_content_Context_Ljava_util_Set_Lcn_jpush_android_api_TagAliasCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_stopCrashHandler_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='stopCrashHandler' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
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

		static IntPtr id_stopPush_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='cn.jpush.android.api']/class[@name='JPushInterface']/method[@name='stopPush' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("stopPush", "(Landroid/content/Context;)V", "")]
		public static unsafe void StopPush (global::Android.Content.Context p0)
		{
			if (id_stopPush_Landroid_content_Context_ == IntPtr.Zero)
				id_stopPush_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "stopPush", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stopPush_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
