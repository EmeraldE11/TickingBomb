using System;
using System.Collections.Generic;
using Byui.Games.Casting;
using Byui.Games.Services;
using Byui.Games.Scripting;

namespace Diffuse
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Byui.Games.Scripting.Action
    {
    /// <summary>
    /// Draws the actors on the screen.
    /// </summary>
        private IVideoService _videoService;

        public DrawActorsAction(IServiceFactory serviceFactory)
        {
            _videoService = serviceFactory.GetVideoService();
        }

        public override void Execute(Scene scene, float deltaTime, IActionCallback callback)
        {
            try
            {
                // get the actors from the cast
                Image bomb = scene.GetFirstActor<Image>("bomb");
                Image manual = scene.GetFirstActor<Image>("manual");


                // draw the actors on the screen using the video service
                _videoService.ClearBuffer();
                _videoService.Draw(bomb);
                _videoService.Draw(manual);
                _videoService.FlushBuffer();
            }
            catch (Exception exception)
            {
                callback.OnError("Couldn't draw game.", exception);
            }
        }
    }
}