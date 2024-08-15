# 🐍**Snake**🐍

Instructions:
- Use WASD or the arrow keys to move the snake!
- Eat the (red) food to grow your snake!
- Grow the biggest snake you can... but don't run into yourself or the walls!
- Play in regular or Endless mode! In Endless mode, you can play against a high-difficulty blue enemy snake!
- When in Enemy game mode, avoid the blue enemy snake and don't let it eat your food! 

## Version History
### **Version 1.4 -- August 14, 2024**
This will probably be the last update for a while as I plan on making some games in Unreal Engine, and this was mainly meant to be a practice to familiarize myself with Unity! 

Implemented:
- Endless mode and enemy mode!
- The toggles for endless mode and enemy mode! I also made it so that the "Enemy Mode" toggle is only triggerable when "Endless Mode" is toggled on, otherwise the GameObject is not active. 
- Re-implemented the death screen for non-endless mode
- Added a main menu button so that you can access the main menu at any point during any mode of the snake game. This button disappears when the death screen appears, if in non-endless mode! 

Learned:
- Setting visibility/activity for GameOjects and game modes via the scripts based on boolean values
- Read up on A* pathfinding and learned how it works!

Plan to implement in the future:
- A* pathfinding for my enemy snake as currently I currently just have a rudimentary script that allows it to move. It runs into itself, so pathfinding would be nice to add.
- Would love to add music, and a staff credits section!
- Would also love to update the movement script at some point.

### **Version 1.3 -- June 18, 2024**
Note, the pause menu is currently disabled for better integration and testing of the new enemy feature!
Implemented:
- A new, blue enemy snake that chases after the food, trying to eat it before you can
- Planned out ideas for toggling game modes, like endless mode (you constantly restart) versus death mode (a pause menu) and enemies versus no enemies
- You can no longer instantly die if you accidentally hit the exact opposite key of the way you're moving (thus running into yourself ~ e.g. if you're moving up and hit the down key without moving left or right first, you no longer die)

Learned:
- Did not use in this version update but I learned a lot about coroutines for waiting in Unity / C#
- A lot about making the enemy snake chase after the food! It was really fun to figure out the math conversions there, and I was happy to find a simple way to do it even though it took me awhile because I was overcomplicating things initially :)

Future implementation:
- re-implementing the death screen once enemy snake testing is complete
- Adding the gamemode toggling feature to the settings menu 

### **Version 1.2 -- June 17, 2024**
Implemented:
- Quit and Settings buttons
- Designed a Settings menu scene
- Designed a death panel, including the implementation of two buttons: Try Again and Main Menu
- Implemented it so that the snake stops when the death scene is instigated, and then begins again when Try Again is hit

Learned:
- Dealt with some massive bugs and issues when implementing the death panel, specifically with the button functionality working everywhere else aside from the Try Again and Main Menu buttons. Also debugged the snake's movement when the death panel is instigated!
- How to implement panels that pop up in the same scenes!
- and a lot more! :)) 

### **Version 1.1 -- December 29, 2023**
Implemented:
- Designed a main menu scene 
- Implemented the play button so that it loads the Snake scene
- Added buttons for future implementation: Quit, Settings, and Staff Credits

Learned:
- How to implement external fonts and assets into Unity UI objects
- How to implement interactive buttons
- Implementing multiple scenes and how to switch between scenes using buttons (and thus learning more about the SceneManager)

### **Version 1.0 -- December 27, 2023**
Thanks to Zigurous for the base tutorial on [youtube](https://www.youtube.com/watch?v=U8gUnpeaMbQ&ab_channel=Zigurous)! 

Implemented:
- Snake movement
- Food spawning (random)
- Boundaries
- Game resetting  

Learned: 
- Understanding scenes, creating various game assets within a scene, and basic Unity skills (such as debugging and testing within Unity, camera interaction, etc).
- Learned tagging for asset interaction
- Learned how to create scripts in Unity for game assets to use
- and more! :) 
