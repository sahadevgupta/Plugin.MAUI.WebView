using Android.Webkit;
using Plugin.MAUI.WebView;
using Plugin.MAUI.WebView.Platforms.Android;

namespace Plugin.MAUI.ExtendedWebView
{
    // All the code in this file is only included on Android.
    public class JavascriptValueCallback : Java.Lang.Object, IValueCallback
    {
        public Java.Lang.Object Value { get; private set; }

        readonly WeakReference<FormsWebViewRenderer> Reference;

        public JavascriptValueCallback(FormsWebViewRenderer renderer)
        {
            Reference = new WeakReference<FormsWebViewRenderer>(renderer);
        }

        public void OnReceiveValue(Java.Lang.Object value)
        {
            if (Reference == null || !Reference.TryGetTarget(out FormsWebViewRenderer renderer)) return;
            Value = value;
        }

        public void Reset()
        {
            Value = null;
        }
    }
}