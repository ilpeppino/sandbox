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

Moving cube colliding with other cubes

**OBJECTIVE**

Explain the observer pattern with and without events.

We have one moving cube and three static cubes. As soon as the moving cube touches the static cubes, we get an achievement unlocked.

Observers are waiting for Subjects to trigger events which they are registered for. Subjects (static cubes) will notify all the observers (in this case only AchievementSystem), and each observer will have to implement their own logic for the abstract OnNotify method called (in this case register the achievement in PlayerPrefs).

In the NOK scenarios, we created ad-hoc class in the Observer.cs with Observer and Subject class. In the OK scenarios, we use events and observer/subjects are mono



