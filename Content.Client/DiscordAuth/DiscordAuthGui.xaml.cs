using Robust.Client.AutoGenerated;
using Robust.Client.Console;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.DiscordAuth;

[GenerateTypedNameReferences]
public sealed partial class DiscordAuthGui : Control
{
    [Dependency] private readonly DiscordAuthManager _discordAuth = default!;
    [Dependency] private readonly IClientConsoleHost _consoleHost = default!;


    public DiscordAuthGui()
    {
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);
        LayoutContainer.SetAnchorPreset(this, LayoutContainer.LayoutPreset.Wide);

        QuitButton.OnPressed += (_) =>
        {
            _consoleHost.ExecuteCommand("quit");
        };

        UrlEdit.Text = _discordAuth.AuthUrl;
        OpenUrlButton.OnPressed += (_) =>
        {
            if (_discordAuth.AuthUrl != string.Empty)
            {
                IoCManager.Resolve<IUriOpener>().OpenUri(_discordAuth.AuthUrl);
            }
        };
    }
}