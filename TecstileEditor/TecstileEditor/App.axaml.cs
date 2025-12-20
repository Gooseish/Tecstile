using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.Markup.Xaml;
using TecstileEditor.ViewModels;
using TecstileEditor.Views;
using Microsoft.Extensions.DependencyInjection;
using TecstileEditor.Factories;
using System;
using TecstileEditor.Data;

namespace TecstileEditor;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Avoid duplicate validations from both Avalonia and the CommunityToolkit. 
            // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
            DisableAvaloniaDataAnnotationValidation();
            
            var collection = new ServiceCollection();
            collection.AddSingleton<MainWindowViewModel>();
            collection.AddTransient<TerrainEditorViewModel>();
            collection.AddTransient<UnitsEditorViewModel>();
            collection.AddTransient<ChildWindow>();

            collection.AddSingleton<Func<EditorName, EditorViewModel>>(x => name => name switch
            {
                EditorName.Terrain => x.GetRequiredService<TerrainEditorViewModel>(),
                EditorName.Units => x.GetRequiredService<UnitsEditorViewModel>(),
                _ => throw new InvalidOperationException("Editor type not recognized by editor factory.")
            });
            collection.AddSingleton<EditorFactory>();

            collection.AddSingleton<Func<EditorName, ChildWindow>>(x => name => name switch
            {
                _ => x.GetRequiredService<ChildWindow>()
            });
            collection.AddSingleton<WindowFactory>();

            var services = collection.BuildServiceProvider();

            desktop.MainWindow = new MainWindow
            {
                DataContext = services.GetRequiredService<MainWindowViewModel>()
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        var dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}