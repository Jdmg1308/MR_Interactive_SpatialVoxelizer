# Interactable Mixed Reality Environment using a Depth Camera

This project aims to recreate a mixed-reality environment where virtual objects can interact with the user's physical surroundings in real-time. It uses an Intel RealSense D435 depth camera and an Oculus Quest 2 headset to capture and integrate the real-world environment into the virtual experience.

## Prerequisites

- Unity (version used in the project)
- Oculus Quest 2 headset
- Intel RealSense D435 depth camera

## Setup

1. Clone the repository to your local machine.

2. Connect the Intel RealSense D435 depth camera to your computer.

3. Attach the depth camera to the Oculus Quest 2 headset, ensuring that the camera is facing the same direction as the headset (tape or other means can be used for this).
   
4. Connect the Oculus Quest to the computer, and download and install the Meta Quest app if not already present on the computer. https://www.meta.com/quest/setup/

## Configuration

The main script responsible for voxelation is located at `RealsenseSDK2.0/Scripts/RSPointCloudToMesh.cs`. Here are the key parameters you can adjust:

- `voxelSize`: Controls the size of the voxels used for environment reconstruction. Smaller voxels provide higher resolution but increase computational demands.
- `MIN_POINTS_FOR_SHAPE`: Specifies the minimum number of points required within a voxel to generate a box mesh for that voxel.

## Usage

1. Open the project in Unity and navigate to the scene containing the mixed reality environment. (Sample Scene) in the Scenes file.

2. Start the meta quest app -> while in an occulus device make sure you are connected to this app.

3. Press the Play button in Unity to start the application.

4. Put on the Oculus Quest 2 headset and enter the passthrough mode to experience the mixed reality environment.

5. Interact with virtual objects and observe how they collide and interact with the physical environment!

## Video demonstration

https://www.youtube.com/watch?v=QbnuH11Asyw

