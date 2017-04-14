using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CN.Jpush.Android.Api;
using CN.Jpush.Android.Data;

namespace JPA
{
    [BroadcastReceiver(Name = "com.lvbao.JPush.MyReceiver")]
    public class MyReceiver : BroadcastReceiver
    {
        
        public override void OnReceive(Context context, Intent intent)
        {
            Bundle bundle = intent.Extras;
            

            if (JPushInterface.ActionMessageReceived.Equals(intent.Action))
            {
                string title = bundle.GetString(JPushInterface.ExtraTitle);
                string message = bundle.GetString(JPushInterface.ExtraMessage);

                NotificationManager nmanager = (NotificationManager)context.GetSystemService(Context.NotificationService);
                
                Notification notification = new Notification(Resource.Drawable.Icon,title,DateTime.Now.ToFileTimeUtc());
                notification.Flags = NotificationFlags.AutoCancel;

                Intent i = new Intent(context,typeof(FirstPage));
                PendingIntent pi = PendingIntent.GetActivity(context,0,i,PendingIntentFlags.CancelCurrent);

                notification.SetLatestEventInfo(context,title,message,pi);

                nmanager.Notify(0,notification);
                
              

                //nmanager.Cancel(0);
            }
            else if (JPushInterface.ActionNotificationReceived.Equals(intent.Action))
            {
                //设置跳转条件
                
            }

            if (JPushInterface.ActionNotificationOpened.Equals(intent.Action))
            {
                Intent it = intent.SetFlags(ActivityFlags.NewTask);
                it.SetClass(context,typeof(FirstPage));
                //Application.Context.StartActivity(intent);
                context.StartActivity(intent);
            }

        }

        private void ProcessCustomMessage(Context context,Bundle bundle)
        {
            Intent msgIntent = new Intent();
        }
    }
}