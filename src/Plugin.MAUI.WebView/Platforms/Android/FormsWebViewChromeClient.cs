using Android.Webkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.MAUI.WebView.Platforms.Android
{
    public class FormsWebViewChromeClient : WebChromeClient
    {

        readonly WeakReference<FormsWebViewRenderer> Reference;

        public FormsWebViewChromeClient(FormsWebViewRenderer renderer)
        {
            Reference = new WeakReference<FormsWebViewRenderer>(renderer);
        }

    }
}
