# 🐍**Snake**🐍

Instructions:
- Use WASD or the arrow keys to move the snake!
- Eat the (red) food to grow your snake!
- Grow the biggest snake you can... but don't run into yourself or the walls!
- When in Enemy game mode, avoid the blue enemy snake and don't let it eat your food! 

## Version History
### **Version 1.3 -- June 18, 2024**
Note, the pause menu is currently disabled for better integration and testing of the new enemy feature!
Implemented:
- A new, blue enemy snake that chases after the food, trying to eat it before you can
- Planned out ideas for toggling game modes, like endless mode (you constantly restart) versus death mode (a pause menu) and enemies versus no enemies
- You can no longer instantly die if you accidentally hit the exact opposite key of the way you're moving (thus running into yourself ~ e.g. if you're moving up and hit the down key without moving left or right first, you no longer die)

Learned:
- Did not use in this version update but I learned a lot about coroutines for waiting in Unity / C#
- A lot about making the enemy snake chase after the food! It was really fun to figure out the math conversions there, and I was happy to find a simple way to do it even though it took me awhile because I was overcomplicating things initially :)

Problems to solve (Too tired to think about them right now, reminding myself by writing it down here):
- Enemy snake keeps running into himself, potentially find a way to have him sense where his body is and where the walls are and not go in those directions?
- Toggling game modes from the settings screen (a different scene), potentially doing this via some sort of global class? 
- How to make the player snake faster than the enemy snake by a little bit

Future implementation:
- re-implementing the pause menu once enemy snake testing is complete
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
