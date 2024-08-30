The game is a 3D platformer where the player tries to jump across various objects to reach a golden trophy, with the option to collect coins along the way. The player dies if they fall off. The top corner of the screen displays a timer and the number of coins collected.

The project consists of four scenes (Intro, Main, Death, End):

- The Intro scene provides instructions for playing the game, and a prompt for starting the game flashes on the screen.
- The Main scene contains the actual game and game world.
- The Death scene displays "YOU DIED" and flashes instructions for restarting or quitting the game.
- The End scene appears when the player completes the level. It shows the player's time and the number of coins collected, along with instructions similar to those in the Death scene.
- The game is set on terrain with some landscape features and trees. I decided to add fog to the game using Unity's built-in fog (Lighting -> Environment -> Fog). The playable area is situated in the middle of buildings, which are surrounded by various objects and a large number of different assets. There's denser moving fog at ground level between the buildings, created using the DustStorm prefab found in the standard assets.

The game's skybox rotates slowly, which can be seen in the movement of the clouds.

The player moves using Unity's standard assets FPS-controller, which also includes footstep sounds.

The game features many sound effects and background music:

- Each scene has its own background music.
- In the Main scene, there is also the sound of wind in the background.
- The Death scene includes sounds of agony.
- A sound plays when collecting coins.
- A small chime is heard when transitioning to the End scene.

I created animations for the collectible coins and the final trophy. The coins and trophy rotate slowly and move slightly up and down simultaneously.

I also utilized Unity's post-processing in my project (Ambient Occlusion, Bloom, Auto Exposure, Anti-aliasing). I added a slight glow effect to the trophy using a Point Light.

The game can be exited with the ESC key.
