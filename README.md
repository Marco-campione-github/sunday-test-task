### Solution (Marco Campione)

## Problem 1 (GameAnalytics)

I simply deleted the MyEventSystem.asmdef file containing the Assembly definitions for the MyEvenSystem. By doing so the Unity compiler will compile all the runtime scripts into a single assembly (Assembly-CSharp.dll).
This solved the error on GameAnalitics import.

## Problem 2 (Performances)

To address the performance problem I edited the Quality build settings as shown in the picture: 

![Quality](screen/Quality.png) 

I set by default the 'Medium' quality profile for the mobile (Android) devices, while leaving the 'Ultra' quality profile for PC/Mac. If performance issues keep occuring in Android, settings like Texture Quality, Anti Aliasing, Shadow Resolution, etc. can be adjusted.

## Problem 3 (Controls and FPS)

To address the problem of controls behaving inconsistently depending on the FPS the game is running at I changed the Update into a FixedUpdate. Since the movement of the ball involves a calculation of the rigidbody physics, it is better to use FixedUpdate, that instead of Update that gets executed every frame (therefore depends on the device performances), it gets called every fixed amount of time.

## Problem 4 (Git Repository)

Easy, I simply added the .gitignore file avoiding to synchronize the Unity generated files, the .vs files, the build files, etc.

## Bonus Problem 1 

I added Firebase Analytics events log to the same MyEventSystem class besides the GameAnalytics event registrations.
