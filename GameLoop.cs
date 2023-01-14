using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GameLoop
    {
        // Game Loop:
        public static void Run()
        {
            // Create a stopwatch to measure time passed since last frame:
            Stopwatch frameStopwatch = Stopwatch.StartNew();

            // Create a stopwatch to measure time passed since last update:
            Stopwatch updateStopwatch = Stopwatch.StartNew();

            int frameCount = 0;
            int updateCount = 0;
            float elapsedTime = 0;

            // Target fps (frames per second):
            float targetFPS = 60;
            float frameTime = 1 / targetFPS;

            // Target ups (updates per second):
            float targetUPS = 60;
            float updateTime = 1 / targetUPS;

            // Whilst the game loop is running:
            while (true)
            {
                // Start the frame stopwatch:
                frameStopwatch.Restart();

                // Start the update stopwatch:
                updateStopwatch.Restart();

                // Increment frame count:
                frameCount++;

                // Update game logic here:
                Update();
                updateCount++;

                // Render game here:
                Render();

                // Wait until the frame time has passed:
                while (frameStopwatch.Elapsed.TotalSeconds < frameTime)
                {
                    // Do nothing....
                }

                // Wait until the update time has passed:
                while (updateStopwatch.Elapsed.TotalSeconds < updateTime)
                {
                    // Do nothing...
                }

                // Print the current fps and ups every second:
                if (elapsedTime >= 1)
                {
                    Console.WriteLine("FPS: " + frameCount + ", UPS: " + updateCount);
                    frameCount = 0;
                    updateCount = 0;
                    elapsedTime = 0;
                }
                elapsedTime += (float)frameStopwatch.Elapsed.TotalSeconds;
            }
        }

        static void Update()
        {
            // Update game logic using deltaTime.
        }

        static void Render()
        {
            // Render game.
        }
    }
}
