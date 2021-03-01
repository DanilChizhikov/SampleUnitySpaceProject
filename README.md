# Galactic Empire
[English](README.md)
[Русский](README_RU.md)
<p align="center">
<img src="https://i.ibb.co/6JDsG4v/logo.png" alt="logo" border="0">
</p>

<p align="center">
<a href="https://travis-ci.org/DanilChizhikov/SampleUnitySpaceProject"><img src="https://travis-ci.org/DanilChizhikov/SampleUnitySpaceProject.svg" alt="Build Status"></a>
<a href="https://github.com/DanilChizhikov/SampleUnitySpaceProject/stargazers"><img src="https://img.shields.io/github/stars/DanilChizhikov/SampleUnitySpaceProject" alt="GitHub stars"></a>
<a href="https://unity.com"><img src="https://img.shields.io/badge/Unity-2019.4.21f1-green" alt="Unity Version"></a>
</p>

## Description
At the moment, there are already many different space simulators, the most popular are of course EliteDangerous and Star Citizen. But why not create your own, maybe not as big, but your own, with its own mechanics and logic.
I will, as far as I have free time, refine and add something new to the project and let you see how everything works and at what stage I am now.

## Table of Contents
- [Galactic Empire](#Galactic-Empire)
- [Table of Contents](#Table-of-Contents)
- [Getting Started](#Getting-Started)
  - [Quick Start: Windows](#Quick-Start-Windows)
- [Mechanics](#Mechanics)
  - [ObjectPool](#objectpool)
  - [BaseObject](#baseobject)
  - [Patterns](#patterns)
    - [Singleton](#singleton)
  - [Scene](#scene)
    - [Scene Manager](#scene-manager)
    - [Scene Builder](#scene-builder)
  - [Ship](#ship)
    - [Component](#component)
- [GIF](#gif)

## Getting Started
### Quick Start: Windows

Prerequisites:
- Windows 10
- [GIT](https://git-scm.com/downloads)
- [Unity](https://unity.com) 2019.4.21f1
- [Visual Studio](https://visualstudio.microsoft.com/) 2019

First, download and bootstrap Project itself; it can be installed anywhere, but generally we recommend using short paths projects, and installing it globally for Visual Studio projects. We recommend somewhere like C:\Unity\Project or C:\Unity\Projects\Project, since otherwise you may run into path issues.
```cmd
> git clone https://github.com/DanilChizhikov/SampleUnitySpaceProject.git
```

## Mechanics
The most basic and fundamental mechanics of the game are described here.

### ObjectPool
An ObjectPool is a container that is created only once per game and stores information about all objects that have ever been created, until this object is completely removed from the ObjectPool.
It is necessary for the subsequent implementation of saving the gameplay and optimizing the project.
```C#
    public class ObjectPool
    {
        private List<IBaseUpdater> baseUpdaters;

        public List<IBaseUpdater> getUpdates => baseUpdaters;

        public ObjectPool(object obj)
        {
            baseUpdaters = new List<IBaseUpdater>();
        }
    }
```
[Click here to view the full class listing](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/ObjectPool/ObjectPool.cs)

### BaseObject
The BaseObject is an abstraction from the standard MonoBehaviour to optimize the execution of tasks assigned to game entities. It replaces the standard start and update methods, which in the future significantly increases the response from the game and improves optimization.

- [BaseObject.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/ObjectPool/BaseObject.cs)
- [IBaseUpdater.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/ObjectPool/IBaseUpdater.cs)

### Patterns
Here are the implemented programming patterns in individual classes.
#### Singleton
A generating pattern that guarantees that only one object will be created for a particular class, and also provides an access point to that object.
- [SingletoneBase.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Paterns/Singletone/SingletoneBase.cs)
- [ISingletone.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Paterns/Singletone/ISingletone.cs)
- [Singleton.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Paterns/Singletone/Singleton.cs)
### Scene
#### Scene Manager
It is used to build the scene and scripts at the start of the game and is responsible for executing the logic of the rest of the game code.
- [SceneManager.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Scene/SceneManager.cs)

#### Scene Builder 
It is used to build the scene and is destroyed after performing its function.
- [SceneBuilder.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Scene/SceneBuilder.cs)

### Ship
This class is the parent of all other possible ships, it carries the key information that all ships must have without exception.
- [Ship.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Ship/Ship.cs)
#### Components
This class is the parent of all other possible ship components, and it contains key information that all ship components must have, without exception.
- [Component.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Component/Component.cs)

## GIF
<p align="center">
  <img src="https://i.ibb.co/1MC7vPy/2021-03-01-21-38-35.gif" alt="FlyModel" border="01">
</p>