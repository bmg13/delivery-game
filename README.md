# Delivery Driver 2D Unity Game

## Overview
Based on the Udemy course [Complete C# Unity Game Developer 2D](https://www.udemy.com/course/unitycourse/), this project was built in order to create a 2D game in Unity, working with provided Assets, creation of triggers and collision effects.
Unity provided lib was used and logic was developed in C#.


## Tech Stack
- dotnet version 7.0.306
- Unity version 2023.3.6f1
- VS Code 1.81.0


## Implementation Notes
The backend implementation relies on three classes
- Driver.cs
    Setting the car speed, both on "normal" flow as well as adapting to collision or speed boosters added in the game map.
- Delivery.cs
    Logic to react to picking the packages and delivering them to the selected delivery spot in the game map. Once the package is picked up, the same is detroyed using Unity's provided Destroy() method.
- FollowCamera.cs
    Implementing the Camara tracking the car instead of fixed camera gameplay. To have an above ground view, fixing the camara position to the car's is not enough, changes in the Z axis positional point was added (```zAxisDistanceFromCameraToCar```).


## Gameplay
The next video shows the game running locally.
![Gameplay](Gameplay.mov)