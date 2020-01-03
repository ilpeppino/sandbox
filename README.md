# STATIC EVENTS

**LINKS**

[https://www.youtube.com/watch?v=Jrwr6Yk_044]

[https://unity3d.college/2017/05/05/using-static-unity-events/] 

**SCENE**

Clickable Boxes which produces particles

**OBJECTIVE**

Reduce dependencies among classes with coupled dependencies

When a box ClickableBox is clicked, it invokes a static event which is called without referencing to the particle system at all.

# OBSERVER PATTERN

**LINKS**

[https://www.youtube.com/watch?v=Yy7Dt2usGy0]

**SCENE**

- Moving cube colliding with other cubes
- Chasing cube

**OBJECTIVE**

Explain the observer pattern with and without events.

We have one moving cube and three static cubes. As soon as the moving cube touches the static cubes, we get an achievement unlocked.

Observers are waiting for Subjects to trigger events which they are registered for. Subjects (static cubes) will notify all the observers (in this case only AchievementSystem), and each observer will have to implement their own logic for the abstract OnNotify method called (in this case register the achievement in PlayerPrefs).

In the NOK scenarios, we created ad-hoc class in the Observer.cs with Observer and Subject class. In the OK scenarios, we use events and observer/subjects are mono

# TYPE OBJECT

**SCENE**

No scene

**OBJECTIVE**

Usage of ScriptableObjects as property collector of object and create asset menus

# COLLISIONS AND SPAWNING

**SCENE**

Cubes spawning and colliding, Euler function

# SCRIPT COMMUNICATION WITH EVENTS (ONE-WAY)

**OBJECTIVE**

*BAD SOLUTION*: Reference to other scripts from a script with FindObjectByType<>, which searches for the object which that script is attached and return a reference of the instance of that script.
*GOOD SOLUTION*: use of non-static events

# RAYCASTING

**OBJECTIVE**

- Shows how raycast works
- Shows how layers work with raycast
- Raycasts dont collide with mesh but with colliders (with or without trigger)
- Check trigger from Project Settings -> Physics -> Queries hit triggers


