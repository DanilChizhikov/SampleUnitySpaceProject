# Galactic Empire
[English](README.md)
[Русский](README_RU.md)
<p align="center">
<img src="https://i.ibb.co/6JDsG4v/logo.png" alt="logo" border="0">
</p>

<p align="center">
<a href="https://travis-ci.org/DanilChizhikov/framework"><img src="https://travis-ci.org/DanilChizhikov/SampleUnitySpaceProject.svg" alt="Build Status"></a>
<a href="https://github.com/DanilChizhikov/SampleUnitySpaceProject/stargazers"><img src="https://img.shields.io/github/stars/DanilChizhikov/SampleUnitySpaceProject" alt="GitHub stars"></a>
<a href="https://unity.com"><img src="https://img.shields.io/badge/Unity-2019.4.21f1-green" alt="Unity Version"></a>
</p>

## Описание
На данный момент уже существует множество различных космических симуляторов, самыми популярными из которых являются, конечно же, EliteDangerous и StarCitizen. Но почему бы не создать свой собственный, может быть, не такой большой, но свой, со своей механикой и логикой.
## Содержание
- [Galactic Empire](#Galactic-Empire)
- [Содержание](#содержание)
- [Как начачать](#как-начать)
  - [Быстрый старт: Windows](#быстрый-старт-Windows)
- [Механики](#механики)
  - [ObjectPool](#objectpool)
  - [BaseObject](#baseobject)
  - [Паттерны](#паттерны)
    - [Singleton](#singleton)
  - [Scene](#scene)
    - [Scene Manager](#scene-manager)
    - [Scene Builder](#scene-builder)
  - [Ship](#ship)
    - [Component](#component)
- [GIF](#gif)

## Как начать
### Быстрый старт: Windows

Требования:
- Windows 10
- [GIT](https://git-scm.com/downloads)
- [Unity](https://unity.com) 2019.4.21f1
- [Visual Studio](https://visualstudio.microsoft.com/) 2019

Во-первых, загрузите сам проект; он может быть установлен в любом месте, но обычно мы рекомендуем использовать короткие пути и устанавливать его глобально для проектов Visual Studio. Мы рекомендуем что-то вроде C:\Unity\Project или C:\Unity\Projects\Project, так как в противном случае вы можете столкнуться с проблемами.
```cmd
> git clone https://github.com/DanilChizhikov/SampleUnitySpaceProject.git
```

## Механики
Здесь описаны самые основные и фундаментальные механики игры.

### ObjectPool
ObjectPool - это контейнер, который создается только один раз за игру и хранит информацию обо всех когда-либо созданных объектах до тех пор, пока этот объект не будет полностью удален из него.
Это необходимо для последующей реализации сохранения игрового процесса и оптимизации проекта.
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
[Нажмите здесь, чтобы просмотреть полный код класса](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/ObjectPool/ObjectPool.cs)

### BaseObject
BaseObject - это абстракция от стандартного MonoBehaviour для оптимизации выполнения задач, возложенных на игровые сущности. Он заменяет стандартные методы Start и Update, что в дальнейшем значительно увеличивает отклик от игры и улучшает оптимизацию.

- [BaseObject.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/ObjectPool/BaseObject.cs)
- [IBaseUpdater.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/ObjectPool/IBaseUpdater.cs)

### Паттерны
Здесь реализованные паттерны в отдельных классах.
#### Singleton
Порождающий паттерн, который гарантирует, что для определенного класса будет создан только один объект, а также предоставляет точку доступа к этому объекту.
- [SingletoneBase.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Paterns/Singletone/SingletoneBase.cs)
- [ISingletone.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Paterns/Singletone/ISingletone.cs)
- [Singleton.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Paterns/Singletone/Singleton.cs)
### Scene
#### Scene Manager
Он используется для построения сцены и сценариев в начале игры и отвечает за выполнение логики остальной части игрового кода.
- [SceneManager.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Scene/SceneManager.cs)

#### Scene Builder 
Он используется для построения сцены и разрушается после выполнения своей функции.
- [SceneBuilder.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Scene/SceneBuilder.cs)

### Ship
Этот класс является родителем всех других возможных кораблей, он несет ключевую информацию, которой должны обладать все корабли без исключения.
- [Ship.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Ship/Ship.cs)
#### Components
Этот класс является родительским для всех других возможных компонентов корабля и содержит ключевую информацию, которой должны обладать все без исключения компоненты корабля.
- [Component.cs](https://github.com/DanilChizhikov/SampleUnitySpaceProject/blob/main/Assets/Data/Script/Core/Component/Component.cs)

## GIF
<h2>Летная модель</h2>
<p align="center">
  <img src="https://i.ibb.co/1MC7vPy/2021-03-01-21-38-35.gif" alt="FlyModel" border="01">
</p>
<h2>Первый аккумулятор</h2>
<p align="center">
<img src="https://i.ibb.co/RyWw7Gz/Power-Plant.gif" alt="Power-Plant" border="1">
</p>