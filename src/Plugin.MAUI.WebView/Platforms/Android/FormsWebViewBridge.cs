using Android.Webkit;
using Java.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.MAUI.WebView.Platforms.Android
{
    public class FormsWebViewBridge : Java.Lang.Object
    {

        readonly WeakReference<FormsWebViewRenderer> Reference;

        public FormsWebViewBridge(FormsWebViewRenderer renderer)
        {
            Reference = new WeakReference<FormsWebViewRenderer>(renderer);
        }

        [JavascriptInterface]
        [Export("invokeAction")]
        public void InvokeAction(string data)
        {
            if (Reference == null || !Reference.TryGetTarget(out FormsWebViewRenderer renderer)) return;
            if (renderer.Element == null) return;

            renderer.Element.HandleScriptReceived(data);
        }
    }
}