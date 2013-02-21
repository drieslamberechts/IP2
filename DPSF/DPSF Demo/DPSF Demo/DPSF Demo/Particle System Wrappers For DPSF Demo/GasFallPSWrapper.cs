using System;
using BasicVirtualEnvironment.Input;
using DPSF_Demo.ParticleSystems;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace DPSF_Demo.Particle_System_Wrappers_For_DPSF_Demo
{
#if (WINDOWS)
	[Serializable]
#endif
	class GasFallDPSFDemoParticleSystemWrapper : GasFallParticleSystem, IWrapDPSFDemoParticleSystems
	{
        public GasFallDPSFDemoParticleSystemWrapper(Game cGame)
            : base(cGame)
        { }

        public void AfterAutoInitialize()
        { }

	    public void DrawStatusText(DrawTextRequirements draw)
	    { }

	    public void DrawInputControlsText(DrawTextRequirements draw)
	    {
            draw.TextWriter.DrawString(draw.Font, "Wall:", new Vector2(5, 250), draw.PropertyTextColor);
			draw.TextWriter.DrawString(draw.Font, "X", new Vector2(50, 250), draw.ControlTextColor);

            draw.TextWriter.DrawString(draw.Font, "Split:", new Vector2(5, 275), draw.PropertyTextColor);
			draw.TextWriter.DrawString(draw.Font, "C", new Vector2(50, 275), draw.ControlTextColor);
	    }

	    public void ProcessInput()
	    {
            if (KeyboardManager.KeyWasJustPressed(Keys.X))
            {
                this.LoadEvents();
            }

            if (KeyboardManager.KeyWasJustPressed(Keys.C))
            {
                this.LoadExtraEvents();
            }
	    }
	}
}