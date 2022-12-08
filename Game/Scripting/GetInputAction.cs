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
    public class GetInputAction : Byui.Games.Scripting.Action
    {
    /// <summary>
    /// Draws the actors on the screen.
    /// </summary>
        private IKeyboardService keyboardService;

        public GetInputAction(IServiceFactory serviceFactory)
        {
            keyboardService = serviceFactory.GetKeyboardService();
        }

        public override void Execute(Scene scene, float deltaTime, IActionCallback callback)
        {
            try
            {
                if (keyboardService.IsKeyPressed(KeyboardKey.Two)){
                    Console.WriteLine("2");
                }
            }
            catch (Exception exception)
            {
                callback.OnError("Couldn't draw game.", exception);
            }
        }
    }
}