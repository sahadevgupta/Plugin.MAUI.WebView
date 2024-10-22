using Plugin.MAUI.WebView.Delegates;
using Plugin.MAUI.WebView.Enums;

namespace Plugin.Maui.WebView;

/// <summary>
/// TODO: Provide relevant comments for your APIs
/// </summary>
public interface IFormsWebView
{
    event EventHandler<DecisionHandlerDelegate> OnNavigationStarted;

    event EventHandler<string> OnNavigationCompleted;

    event EventHandler<int> OnNavigationError;

    event EventHandler OnContentLoaded;

    WebViewContentType ContentType { get; set; }

    string Source { get; set; }

    string BaseUrl { get; set; }

    bool EnableGlobalCallbacks { get; set; }

    bool EnableGlobalHeaders { get; set; }

    bool Navigating { get; }

    bool CanGoBack { get; }

    bool CanGoForward { get; }

    void GoBack();

    void GoForward();

    void Refresh();

    Task<string> InjectJavascriptAsync(string js);

    void AddLocalCallback(string functionName, Action<string> action);

    void RemoveLocalCallback(string functionName);

    void RemoveAllLocalCallbacks();
    Task ClearCookiesAsync();
}