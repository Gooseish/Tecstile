using System;

namespace Tecstile.Audio;

public class AudioContentManager
{
    private AudioContentState State;
    public AudioContentManager()
    {
        State = new AudioContentState();
    }
    #region Public Controls
    public void loadContent()
    {
        loadMusic();
        void loadMusic()
        {
            
        }

        loadSfx();
        void loadSfx()
        {
            
        }
    }
    #endregion
}
