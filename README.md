[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

Write your Devlog here!


HW1 Breakdown

Objects
	1.Background
	•A plain green background representing the environment.
	2.Player (Cat?)
	•A pixel-art character, located at the center of the screen.
	3.UI
	•Displays:
	•“Seeds Planted” (current progress).
	•“Seeds Remaining” (available seeds).
	•Positioned at the top-left corner of the screen.
	4.Plants
	•The result of planting seeds in the game world.
Attributes and Actions
	1.Player Movement
	•Controlled using WASD keys to move in the environment.
	2.Planting Seeds
	•Press Spacebar to plant a seed at the current location.
   3.bunny sprite
Interactions Between Objects
	•Player → Seeds
	•When the player presses Spacebar, one seed is planted.
	•Seeds → UI
	•Planting a seed updates the UI:
	•Seeds Planted increases by 1.
	•Seeds Remaining decreases by 1.

Comparison to the Final Implementation
The final implementation closely followed the plan but included additional features, such as a menu that allows the player to choose "Play" or "Quit" before starting the game. This menu functionality was not part of the original plan but was implemented by adding buttons to the Canvas and connecting them to the appropriate methods in a new script. Additionally, I refined the UI layout to make it more intuitive and visually appealing.

Connecting the Plan to the Code
The written plan directly influenced the code structure and Unity Scene setup:

Player Movement: Implemented in the Player class using the HandleMovement() method, which reads input via Input.GetAxis() to control the movement of the Player GameObject.
Planting Seeds: Handled by the PlantSeed() method in the Player class, which checks if seeds are available, instantiates the PlantPrefab at the player's position, and updates _numSeedsLeft and _numSeedsPlanted.
UI Updates: The PlantCountUI script links to the Unity Scene's Text elements and dynamically updates seed counts using the UpdateSeedCounts(int, int) method.
Menu Functionality: Implemented in the MainMenu script with PlayGame() and QuitGame() methods, which handle starting the game and exiting the application. These methods are linked to the buttons in the Unity Scene.
Unity Scene Setup
Player: A sprite with the Player script attached for movement and planting.
Canvas: Includes two Text components for the UI and two buttons ("Play" and "Quit") for the menu.
PlantPrefab: Instantiated by the Player script during planting.


The goal of HW1 was to make a simple game with a player, planting seeds, and a working UI. I used Unity to add WASD movement and a spacebar action to plant seeds, which spawns plants and updates the "Seeds Planted" and "Seeds Remaining" UI. The hardest parts were fixing movement and making sure the UI worked correctly, but I solved them with testing and debugging. Setting up the Inspector took some extra time, but my GDIM31 class helped me finish the project more easily. Writing the devlog was the hardest part, but overall, I enjoyed making this game.



## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
