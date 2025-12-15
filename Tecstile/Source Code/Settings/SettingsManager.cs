using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Tecstile.Config;
using Tecstile.Input;

namespace Tecstile.Settings;

public class SettingsManager
{
    private SettingsState State;
    #region Constructor
    public SettingsManager()
    {
        State = new SettingsState();
        RecalculateLetterbox();
        restoreDefaultSettings();
        restoreSavedSettings();
    }
    #endregion
    #region Accessors
    public IReadOnlyDictionary<CommandName, Keys> keyboardMap {get {return State.keyboardMap;}}
    public Rectangle letterboxPicture {get {return new Rectangle(
        State.letterboxPictureLocationX, 
        State.letterboxPictureLocationY, 
        State.letterboxPictureWidth, 
        State.letterboxPictureHeight);}}
    #endregion

    #region Public Controls
    public void restoreDefaultSettings()
    {
        Keybinds();
        void Keybinds()
        {
            State.keyboardMap.Clear();

            State.keyboardMap[CommandName.Confirm] = Keys.Z;
            State.keyboardMap[CommandName.Cancel] = Keys.X;
            State.keyboardMap[CommandName.Up] = Keys.Up;
            State.keyboardMap[CommandName.Down] = Keys.Down;
            State.keyboardMap[CommandName.Left] = Keys.Left;
            State.keyboardMap[CommandName.Right] = Keys.Right;
            State.keyboardMap[CommandName.Start] = Keys.Enter;
            State.keyboardMap[CommandName.Select] = Keys.Back;
            State.keyboardMap[CommandName.Tab] = Keys.A;
            State.keyboardMap[CommandName.Info] = Keys.C;
            State.keyboardMap[CommandName.Escape] = Keys.Escape;
        }

        Volume();
        void Volume()
        {
            State.masterVolume = 100;
            State.musicVolume = 100;
            State.sfxVolume = 100;
        }
        
    }
    public void restoreSavedSettings()
    {
        
    }
    public void resizeGameWindow(int width, int height)
    {
        Core.Graphics.PreferredBackBufferHeight = width;
        Core.Graphics.PreferredBackBufferWidth = height;
        Core.Graphics.ApplyChanges();

        // Black bar positions for letterboxing
        RecalculateLetterbox();
    }
    #endregion
    #region Private Controls
    private void RecalculateLetterbox()
    {
        // Find scaling factor
        double widthScalingFactor = 
            (double)Core.Graphics.PreferredBackBufferWidth 
            / TecstileConfig.sourceResolutionWidth;
        
        double heightScalingFactor = 
            (double)Core.Graphics.PreferredBackBufferHeight
            / TecstileConfig.sourceResolutionHeight;
        
        double trueScalingFactor = Math.Min(widthScalingFactor, heightScalingFactor);

        // Accordingly recalculate letterbox position
        State.letterboxPictureWidth = (int)
            (TecstileConfig.sourceResolutionWidth * trueScalingFactor);

        State.letterboxPictureHeight = (int)
            (TecstileConfig.sourceResolutionHeight * trueScalingFactor);

        State.letterboxPictureLocationX = 
            (Core.Graphics.PreferredBackBufferWidth - State.letterboxPictureWidth)/2;

        State.letterboxPictureLocationY = 
            (Core.Graphics.PreferredBackBufferHeight - State.letterboxPictureHeight)/2;
    }
    #endregion
}
