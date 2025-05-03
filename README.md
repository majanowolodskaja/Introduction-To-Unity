# Roll-a-Ball in Unity
![image](/images/banner.png)

A simple 3D game made in Unity! You move a ball, collect cubes, and win.  
This project was part of my e-portfolio presentation, and it shows the basics of using Unity for game dev.

## How to Get Started with Unity (and Make This Yourself)

This project is beginner-friendly, so you don’t need to know Unity or C# to get started.  
Here’s how to set everything up and follow along:

---

### 1. Install Unity Hub and Unity Editor

First let me explain the question I had myself when I first got started with Unity. **What's the difference between Unity and Unity Hub?**

So Unity is the engine, the actual tool we will use to build and run our game and Unity Hub is like a manager app for all of your projects. It let's you install Unity versions, open projects, and manage settings. For example you might be using different Unity versions for different projects and instead of needing to worry about how to manage all that it's all managed for you by Unity Hub.

- Download **Unity Hub**: [unity.com/download](https://unity.com/download). Their site has clear step by step instructions like this:
![image](/images/unity-how-to-get-started.png)
  
- Inside Unity Hub, go to the **Installs** tab
  ![image](/images/installs-tab.png)
  I already have one downloaded, but yours should be empty for now.
- Add **Unity 2022.3 LTS** (or later) - this project, that we‘ll be making uses the 3D built-in pipeline

---

### 2. Start a New Project

- In Unity Hub, go to **Projects > New project**
- Choose template: **3D (Built-In Render Pipeline)** (not URP or HDRP, those are more advanced)
- Name it something like `Roll-a-Ball`, or whatever you'd like
- Location: pick any folder you like
- No need to add a license unless you're earning a lot of cash money with your project 🤠
  (The free “Personal” license is perfect for learning and even small game devs)

---

### 3. Follow the Tutorial

If you want to build this game step by step yourself, just scroll down, everything is explained below.

If you just want to look at the finished version:
- Click the green **Code** button on the top of this page and **download the ZIP** (Unity will generate missing files when it opens the project, so don't worry if the zip looks kinda empty)
- Open it in Unity Hub (Make sure to open the folder called Roll-a-Ball Demo v3 and not the whole Introduction-To-Unity) → press **Play**

## How to Build This Game

Now that everything’s set up, let’s actually build the game together!  
I’ll walk you through each step.
You can follow along in your own Unity project, and I’ll include screenshots along the way.

### What We'll Cover

- [Roll-a-Ball in Unity](#roll-a-ball-in-unity)
  - [How to Get Started with Unity (and Make This Yourself)](#how-to-get-started-with-unity-and-make-this-yourself)
    - [1. Install Unity Hub and Unity Editor](#1-install-unity-hub-and-unity-editor)
    - [2. Start a New Project](#2-start-a-new-project)
    - [3. Follow the Tutorial](#3-follow-the-tutorial)
  - [How to Build This Game](#how-to-build-this-game)
    - [What We'll Cover](#what-well-cover)
    - [1. Set up the scene](#1-set-up-the-scene)
    - [2. How to Move Around the Scene View](#2-how-to-move-around-the-scene-view)
    - [3. Add the Floor](#3-add-the-floor)
      - [Steps:](#steps)
    - [4. Add the Player Ball](#4-add-the-player-ball)
      - [Steps:](#steps-1)
    - [5. Add Physics to the Ball (Rigidbody)](#5-add-physics-to-the-ball-rigidbody)
      - [Steps:](#steps-2)
    - [6. Make the Ball Move](#6-make-the-ball-move)
      - [Steps:](#steps-3)
    - [7. Add Pickups](#7-add-pickups)
      - [Steps:](#steps-4)
    - [8. Make Pickups Collectible](#8-make-pickups-collectible)
      - [Steps:](#steps-5)
    - [9. Add Score UI](#9-add-score-ui)
      - [Steps:](#steps-6)
    - [10. Add a Lose Condition (Fall Off = Game Over)](#10-add-a-lose-condition-fall-off--game-over)
      - [Steps:](#steps-7)
    - [11. Add Materials and Color ⋆ ˚｡⋆୨୧˚](#11-add-materials-and-color--୨୧)
      - [Steps:](#steps-8)
      - [Finished Product:](#finished-product)
  - [Code Explanation](#code-explanation)
    - [Script 1: `PlayerMovement.cs`](#script-1-playermovementcs)
    - [Script 2: `PickupCollector.cs` (Basic Version)](#script-2-pickupcollectorcs-basic-version)
    - [Script 3: `PickupCollector.cs` (With Score UI)](#script-3-pickupcollectorcs-with-score-ui)
    - [Script 4: `PickupCollector.cs` (Final Version with Win/Lose)](#script-4-pickupcollectorcs-final-version-with-winlose)
  - [Resources for Learning](#resources-for-learning)
  
---

### 1. Set up the scene

When you open Unity, you're placed inside something called a **Scene**.  
Think of it like a single level or space in your game, and for this tutorial, we’ll build everything inside **just one scene**.

You’ll see something like this in the editor:
- On the left is the **Hierarchy** - it shows all the objects in your scene
  ![image](/images/section-1-h.png)
- In the middle is the **Scene view** - this is where you build and edit things
  ![image](/images/section-1-s.png)
- On the right is the **Inspector** - it shows settings for whatever object you select
  ![image](/images/section-1-i.png)

You’ll also see a few other panels at the bottom:

- **Project** shows all your game’s files - scenes, scripts, materials, etc.
- **Console** is where Unity tells you if anything is broken (like error messages)
  ![image](/images/section-1-p.png)

And at the top, there’s a tab called **Game** - this shows what the player will actually see when the game runs.
![image](/images/section-1-g.png)  
We’ll be mostly working in the **Scene view** for now (the editor space), but later you’ll switch to the Game view to test things out.


This is where all your building happens.

---

**Also one important thing before I forget to mention it!**

Unity doesn’t **auto-save** your project. You have to manually save it,
so press **Ctrl + S** (or Cmd + S on Mac) often to save your scene!  Otherwise, you might lose changes.

Also don’t make edits while the game is playing (when Play Mode is on).  
Anything you change in Play Mode will reset when you stop the game! **You’ll know Play Mode is active when the Play button at the top turns blue.**

---

### 2. How to Move Around the Scene View

Before you start building anything you have to know how to move around in the Scene view:

- **Right-click and drag** → Look around
- **Hold right-click + W / A / S / D** → Move through the scene
- **Scroll wheel** → Zoom in/out (Or two finger drag up and down on a touchpad)
- **Hold middle mouse button** → Pan left/right/up/down (You can also do that using the **View Tool** from the tool bar - a hand icon)
  ![image](/images/view-tool.png)

Tip: You can always switch back and forth between **Scene view** (editing) and **Game view** (playing) at the top of the window. 

**Just make sure you’re in Scene view when building things.**

---

### 3. Add the Floor

Now that our scene is ready, let’s add the floor that our player will roll around on! We’ll use a **Plane**, which is a flat surface perfect for a simple game floor.

#### Steps:

1. **Right-click** in the **Hierarchy panel**  
2. Choose **3D Object → Plane**  
   ![image](/images/add-plane.png)
3. Rename it to `Floor` (optional, but helps keep things organized)

4. With the `Floor` selected, go to the **Inspector** on the right  
   You’ll see:
   - Transform (for position, rotation, scale)
   - Mesh Filter and Mesh Renderer (for shape and visuals)
   - **Box Collider** (so the ball can roll on it)

   *(No need to change the position or scale unless you want to customize your level)*

You can also move or adjust the Plane by using the **Move Tool** and **Scale Tool** from the toolbar.  
Click and drag the colored arrows (axes) to position or resize objects in the scene.

![image](/images/scale-via-tool.png)


---

### 4. Add the Player Ball

Now let’s add the player character, a sphere that we’ll later make roll around the scene!

#### Steps:

If any of this feels unclear, you can go back to the **Add the Floor** section, this is a very similar process.

1. **Right-click** in the **Hierarchy** panel  
2. Choose **3D Object → Sphere**  
3. Rename it to `Player`  

4. With the Player selected, go to the **Inspector**  
   Click the 3-dot menu next to **Transform > Position** and choose **Reset**  
   - This sets the position to (0, 0, 0), which centers the ball on the map  
   - The center of the Plane is also (0, 0, 0), so the ball should sit right on top of it

5. If the ball is sinking into the floor, raise the **Y position** a little, try `Y = 0.5`

![image](/images/player-ball.png)

---

### 5. Add Physics to the Ball (Rigidbody)

Now that the Player ball is in the scene, let’s make it respond to gravity, so it falls and rolls like a real ball.

To do that, we’ll add a **Rigidbody** component. This tells Unity to apply physics to the object.

#### Steps:

1. Select the **Player** object in the **Hierarchy**
2. In the **Inspector**, click `Add Component`
3. Search for and select **Rigidbody**  
   *(Not Rigidbody 2D, cuz this is a 3D game!)*
   ![image](/images/rigidbody.png)
4. You should now see some new settings like:
   - `Mass`
   - `Drag`
   - `Use Gravity` (should be checked by default)

That’s it, the ball now has real physics!

You can test it by pressing the play button at the top.
If your floor is flat, the ball will drop and just sit there.
![image](/images/test-rigidbody.png)  
If your floor is tilted, the ball will start rolling right away!

**To exit the play mode just click the play button again.**

---

### 6. Make the Ball Move

Now that our Player has physics, let’s make it move with the keyboard!

We’ll write a small C# script that reads keyboard input and applies force to roll the ball using Unity’s physics system.

#### Steps:

1. In the **Project** panel, right-click inside the `Assets` folder  
2. Go to **Create → C# Script**  
3. Name it `PlayerMovement` (or whatever you like)

4. Drag the script onto the **Player** object in the **Hierarchy**  
   Or: Select the Player → click `Add Component` → search for your script
   ![image](/images/add-ball-move-script.png)

5. Double-click the script to open it in your code editor (like VS Code)

6. Delete the template code and replace it with this:

```csharp
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // get the Rigidbody from this object
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float moveZ = Input.GetAxis("Vertical");   // W/S or Up/Down

        Vector3 movement = new Vector3(moveX, 0, moveZ);
        rb.AddForce(movement * moveSpeed);
    }
}
```

Now press **Play** and use **WASD** or the **arrow keys**, your ball should roll around the floor.

If nothing happens, double-check:
- The script is attached to the Player  
- The Player has a Rigidbody  
- You're in Play Mode  

Full explanations for how the code works are at the bottom of this README — feel free to keep following the steps and come back to that later.

---

### 7. Add Pickups

> **Before you continue:**  
> Make sure your **Main Camera** is positioned so the floor, player, and pickups will be easily visible in Game view.  
> You can do this by:
> - Selecting the **Main Camera** in the Hierarchy  
> - Moving or rotating it using the **Move Tool** and **Rotate Tool**  
> - Adjusting its **Position** and **Rotation** in the Inspector  
> 
> ![image](/images/adjust-camera.png)


Now let’s add some cubes for the player to collect.

We’ll start with one small cube, set it up properly, and then you can duplicate it to place more around the scene.

#### Steps:

1. **Right-click** in the **Hierarchy**  
2. Go to **3D Object → Cube**  
3. Rename it to `Pickup`

4. With the Pickup selected, go to the **Inspector** and change its **Scale** to:
   - X: `0.5`
   - Y: `0.5`
   - Z: `0.5`

5. Set the **Y Position** to `0.5`  
   This makes the pickup sit just above the floor instead of inside it

6. At the top of the **Inspector**, open the **Tag** dropdown and click **Add Tag**  
   - Click the **+** button
   - Name your new tag `Pickup`
  ![image](/images/add-tag.png)
   - Then go back to your object and assign it that tag
  ![image](/images/assign-tag.png)

1. Still in the Inspector, find the **Box Collider** component  
   - Check the box labeled **Is Trigger**
  ![image](/images/is-trigger.png)


Once it looks good, press **Ctrl + D** (or Cmd + D on Mac) to duplicate it  
Move the new ones around the scene using the **Move Tool**, try adding 5–10 pickups wherever you like!
![image](/images/duplicate-cubes.png)

---

### 8. Make Pickups Collectible

Now let’s make the pickups disappear when the player touches them.

We’ll write a small script that checks if the Player has entered a pickup’s trigger zone, and removes it from the scene. If you're confused by the steps go back to the player movement script we did earlier, this is a similar process. 

#### Steps:

1. In the **Assets** folder, right-click → **Create > C# Script**  
2. Name it something like `PickupCollector`

3. Drag the script onto the **Player** object in the **Hierarchy**  
   (Or select the Player → `Add Component` → search for the script)

4. Double-click the script to open it, and replace everything with this:

```csharp
using UnityEngine;

public class PickupCollector : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
        }
    }
}
```
Now press **Play** and roll into a pickup, it should disappear when the ball touches it.

If it doesn’t work, check that:
- The pickup is tagged `Pickup`  
- The pickup's **Box Collider** has **Is Trigger** checked  
- The script is attached to the Player and not the Pickups for example

---

### 9. Add Score UI

Now let’s show the score on screen when the player collects pickups.

We’ll add a Text UI object, update it through the script, and connect it properly in the Inspector.

#### Steps:

1. **Right-click** in the **Hierarchy**  
   Go to **UI → Text - TextMeshPro**
   ![image](/images/add-tmp.png)
   If Unity asks to import TMP Essentials, click **Import** (This is very important, otherwise it will not work.)

2. A few things will be added automatically:
   - A `Canvas` object (used for all UI)
   - An `EventSystem`
   - A new `Text (TMP)` object

3. Select the `Text (TMP)` object in the **Hierarchy**

4. In the **Inspector**, scroll to the text input box and change the text to:  
   `Score: 0`

5. Still with the text selected, adjust the font size and alignment in the Inspector:
   - Set alignment to **bottom-left** 
   - You can also change the color of the text in the inspector so you can see it more easily.

6. Set the text position in the corner of the screen:
   - Click the **Anchor Presets** icon (the 9-square box in Rect Transform)
   - Choose the **bottom-left** square
   - Then set (adjust if needed):
     Change the pos X and Y around to your liking. (For me it ended up being Pos X = 250 and Pos Y = 150.)
     ![image](/images/move-change-color-tmp.png)

7. Now go back to your `PickupCollector` script and replace the code with this:

```csharp
using UnityEngine;
using TMPro; // We added

public class PickupCollector : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // We added
    private int score = 0; // We added

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            score++; // We added
            UpdateScoreUI(); // We added
        }
    }

    void UpdateScoreUI() // We added
    {
        scoreText.text = "Score: " + score;
    }
}
```
8. In Unity, select the **Player** object in the **Hierarchy**

9. In the **Inspector**, look for the `PickupCollector` script section

10. Drag the `Text (TMP)` object from the **Hierarchy** into the **Score Text** field (This step is required, Unity won’t link the text unless you do it manually. If you skip this, you’ll get a `NullReferenceException` when the game runs.)
![image](/images/drag-tmp-ref.png)

11. Press **Play** and roll into some pickups

  - You should now see the score increase on screen each time a pickup is collected.

  If it doesn’t work, check the following:
  - The `Text (TMP)` object is assigned in the Player’s script field  
  - The pickup objects are tagged `Pickup`  
  - **Is Trigger** is checked on each pickup’s collider  
  - The script code matches exactly

---

### 10. Add a Lose Condition (Fall Off = Game Over)

Let’s make the game end if the player falls off the platform.

We’ll:
- Detect when the ball falls below a certain height
- Show a "Game Over" message on screen
- Pause the game so it doesn’t keep running

#### Steps:

1. **Right-click** in the **Hierarchy**  
   Go to **UI → Text - TextMeshPro**

2. Rename the new text object to `GameOverText`

3. With `GameOverText` selected, go to the **Inspector** and set:
   - Text: `You fell! Game Over!`
   - Font Size: `36` or higher
   - Alignment: Center
   - Anchor Preset: Middle-Center (click the grid icon and choose the center square)
   - Position X/Y/Z: `0, 0, 0`
   - Change color if you want

4. Disable the text so it stays hidden until needed:
   - In the Inspector, uncheck the box next to the object’s name (top-left)
  ![image](/images/disable-game-over-tmp.png)

5. Open your `PickupCollector` script and replace it with the following:

```csharp
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // We added

public class PickupCollector : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverText; // We added
    private int score = 0;
    private int totalPickups; // We added

    void Start() // We added
    {
        totalPickups = GameObject.FindGameObjectsWithTag("Pickup").Length;
        UpdateScoreUI();
    }

    void Update() // We added
    {
        if (transform.position.y < -5f)
        {
            GameOver();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            Destroy(other.gameObject);
            score++;
            UpdateScoreUI();

            if (score >= totalPickups) // We added
            {
                Win();
            }
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    void GameOver() // We added
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0f;
    }

    void Win() // We added
    {
        scoreText.text = "YOU WIN!";
        Time.timeScale = 0f;
    }
}
```
6. In Unity, select the Player object in the Hierarchy

7. In the Inspector, find the PickupCollector script section

8. Drag the GameOverText object from the Hierarchy into the Game Over Text field
   ![image](/images/drag-go-ref.png)

9.  Press Play and roll off the platform
- You should see the game over message appear on screen, and the game should pause.
  
---

### 11. Add Materials and Color ⋆ ˚｡⋆୨୧˚

Let’s make the game look a little nicer by adding color to the player, floor, and pickups.

We’ll use Unity’s built-in **Materials** system to do this.

#### Steps:

1. In the **Project** panel, right-click in the `Assets` folder  
2. Go to **Create → Material**, Do that 3 times
3. Name it something like `PlayerMaterial`, `FloorMaterial`, `PickupMaterial`

4. With the material selected, look in the **Inspector**  
   - Click the color box next to **Albedo**
  ![image](/images/change-mat-color.png)
   - Pick a color you like (e.g. blue for the ball, green for the floor, yellow for the pickups) Here are some nice 3-color palettes for you: [Coolors 3-Colored Palettes](https://coolors.co/palettes/popular/3%20colors)

5. Drag the material onto the object in the **Scene** or **Hierarchy**  
   ![image](/images/drag-mat-to-object.png)
   - For example, drag `PlayerMaterial` onto the Player sphere  
   - Drag `FloorMaterial` onto the Plane  
   - Make a separate material for the pickups if you want each object to have its own look or you can also select all cubes by picking them while holding Cmd on Mac and then dragging it like before.

#### Finished Product:
![image](/images/finished-product.png)

## Code Explanation

Here’s a full breakdown of how all the scripts work.

### Script 1: `PlayerMovement.cs`

**Role of the script:** This script is attached to the Player (the ball) and makes it roll using keyboard input.

**Line:**
```csharp
using UnityEngine;
```
**Explanation:**
This gives you access to Unity’s built-in functions, like Rigidbody and Input.

**Line:**
```csharp
public class PlayerMovement : MonoBehaviour
```
**Explanation:**
Defines a new class called PlayerMovement. It inherits from MonoBehaviour, which means Unity can attach it to a GameObject and run it.

**Line:**
```csharp
public float moveSpeed = 5f;
```
**Explanation:**
A speed value you can adjust in the Inspector. It controls how fast the ball rolls.

**Line:**
```csharp
private Rigidbody rb;
```
**Explanation:** A variable to store the Rigidbody component, which handles physics for the ball.

**Line:**
```csharp
void Start()
{
    rb = GetComponent<Rigidbody>();
}
```
**Explanation:** `Start()` runs once when the game begins.
`GetComponent<Rigidbody>()` finds the Rigidbody on the Player object and stores it in `rb`.

**Line:**
```csharp
void FixedUpdate()
```
**Explanation:** `FixedUpdate()` is used for physics updates. It runs at a steady rate, which makes it better than `Update()` for movement with Rigidbody.

**Line:**
```csharp
float moveX = Input.GetAxis("Horizontal");
float moveZ = Input.GetAxis("Vertical");
```

**Explanation:** Reads keyboard input.
"Horizontal" = A/D or Left/Right,
"Vertical" = W/S or Up/Down.

**Line:**
```csharp
Vector3 movement = new Vector3(moveX, 0, moveZ);
```

**Explanation:** Creates a direction vector based on the input.
Y = 0 because we’re not moving up or down.

**Line:**
```csharp
rb.AddForce(movement * moveSpeed);
```

**Explanation:** Applies force to the Rigidbody, which makes the ball roll in the direction of input.

### Script 2: `PickupCollector.cs` (Basic Version)

**Role of the script:** This script makes the ball collect pickups when it touches them.

**Line:**
```csharp
using UnityEngine;
```

**Explanation:** Gives access to Unity engine tools and features.

**Line:**
```csharp
public class PickupCollector : MonoBehaviour
```

**Explanation:** Creates a new script Unity can run.

**Line:**
```csharp
void OnTriggerEnter(Collider other)
```

**Explanation:** This function runs when the ball enters a trigger collider (like the pickup cube).

**Line:**
```csharp
if (other.CompareTag("Pickup"))
{
    Destroy(other.gameObject);
}
```

**Explanation:** Checks if the object has the "Pickup" tag and removes it from the scene if true.

### Script 3: `PickupCollector.cs` (With Score UI)

**Role of the script:** This version adds score tracking and updates a Text UI element on screen.

**Line:**
```csharp
using UnityEngine;
using TMPro;
```

**Explanation:** Adds access to Unity features and TextMeshPro (for UI text).

**Line:**
```csharp
public TextMeshProUGUI scoreText;
```

**Explanation:** Public variable so you can drag the Text (TMP) object into it in the Inspector.

**Line:**
```csharp
private int score = 0;
```

**Explanation:** Starts the score at zero.

**Line:**
```csharp
void OnTriggerEnter(Collider other)
```

**Explanation:** Runs when the player touches something with a trigger collider.

**Line:**
```csharp
if (other.CompareTag("Pickup"))
{
    Destroy(other.gameObject);
    score++;
    UpdateScoreUI();
}
```

**Explanation:** If the object has the "Pickup" tag: Destroy it, Add 1 to the score, Update the score text on screen

**Line:**
```csharp
void UpdateScoreUI()
{
    scoreText.text = "Score: " + score;
}
```

**Explanation:** Changes the text to show the updated score.

### Script 4: `PickupCollector.cs` (Final Version with Win/Lose)

**Role of the script:** This version adds: A win condition when all pickups are collected and a lose condition when the player falls off the platform.

**Line:**
```csharp
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
```

**Explanation:** Adds support for Unity, UI text, and optional scene management (for future restarts).

**Line:**
```csharp
public GameObject gameOverText;
```

**Explanation:** Lets you assign the "Game Over" UI text from the Inspector.

**Line:**
```csharp
private int totalPickups;
```

**Explanation:** Stores how many pickups were in the scene when the game started.

**Line:**
```csharp
void Start()
{
    totalPickups = GameObject.FindGameObjectsWithTag("Pickup").Length;
    UpdateScoreUI();
}
```

**Explanation:** When the game starts: Count all pickups in the scene, Display the starting score

**Line:**
```csharp
void Update()
{
    if (transform.position.y < -5f)
    {
        GameOver();
    }
}
```

**Explanation:** Every frame, check if the ball has fallen below Y = -5 (off the platform). If it has, call the GameOver function.

**Line:**
```csharp
if (score >= totalPickups)
{
    Win();
}
```

**Explanation:** If the score equals the total number of pickups, the player wins.

**Line:**
```csharp
void GameOver()
{
    gameOverText.SetActive(true);
    Time.timeScale = 0f;
}
```

**Explanation:** Shows the Game Over text and pauses the game.

**Line:**
```csharp
void Win()
{
    scoreText.text = "YOU WIN!";
    Time.timeScale = 0f;
}
```

**Explanation:** Updates the score text to a win message and freezes the game.


## Resources for Learning

- [Unity Docs](https://docs.unity.com/)  
  Official Unity documentation for all core systems and features.

- [Unity Learn](https://learn.unity.com/)  
  Unity’s free learning platform with guided tutorials and beginner courses.

- [Roll-a-Ball Official Tutorial](https://learn.unity.com/project/roll-a-ball)  
  The original tutorial this project is based on.

- [Unity for Beginners! by Dani Krossing (on YouTube)](https://youtube.com/playlist?list=PL0eyrZgxdwhwQZ9zPUC7TnJ-S0KxqGlrN&si=hD-c62u0qsDvjBe2)

- [Unity: Roll a Ball by Education Public (on YouTube)](https://youtube.com/playlist?list=PL-ptF2slHtJAYSWWJ8aqbf1a5tu9u7pAb&si=sgQqIwmogoUdRJOs)
