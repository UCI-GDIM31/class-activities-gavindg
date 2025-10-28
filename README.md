# in-class-activities
## Devlogs
### W1
When you move the Camera off of the Cat GameObject (re-parent it to another object or the scene root), moving the player will no longer move the Camera along with it.
This is because the parent-child relationship affects the transform (position, rotation, and scale) of an object.
Parent objects add the values in their transform to their child objects, making them "follow" the parent. 
Without the parent-child relationship, the Camera will not have its transform updated by the cat, leading to the disjointed behavior that is observed.

### W2
1. The r, g, and b, values are floats because the **float** data type represents a real-valued number (aka a number that can contian a decimal point followed by a fractional component). This works best for our rgb values because they can range from 0.0 to 1.0. If we used an integer, we would only be able to use 1 or 0, which wouldn't give us much control over our colors. A boolean data type doesn't make much sense here, as a boolean can only be "true" or "false," which doesn't make much sense in the context of a real-valued number. Finally, the string data type contains text, which similarly does not convert to a decimal number.
2. The _bounce variable is an int, because integers represent whole numbers. You cannot have a fraction of a bounce; e.g. 0.2 bounces doesn't make much sense. For the same reasons as #1, a boolean's true/false values don't convert to numbers well (at least not in C#). A string's text can contain numbers in them, but they cannot actually be used for arithmetic operations like an integer or float can.
3. The lesson in Step 4 is that all lines of code need to end in a semicolon, even if the expression is otherwise correct!

### W3

(I was sitting at table 12)

```
string GetResponse(int friendshipLevel, boolean playerKnowsSecret);
```
Since we want a text response, the function should return a string. The information that the function relies on is the player's friendship level and whether they know the character's secret. I think an integer fits the friendshipLevel parameter, as I'm assuming that it's based on discrete choices given that this is a visual novel. As for whether the player knows the secret or not, I chose the boolean type because that can only be true or false.

1. A good metaphor for the relationship between classes and components is that classes & components are like thinking of something in my mind versus having the real thing. To illustrate the metaphor, take a pair of glasses as an example. I can't attach "the idea of a pair of glasses" (class) to my player, but I can attach an actual pair. Both the pair in my mind and in my hand have attributes (member variables) such as their tint, color, prescription strength, etc; and they both have things they can do (methods) such as effect my vision every frame or break OnCollisionEntered3D, but they'll only affect my vision when I'm actually wearing them. 
2. The balls get extremely bright when they bounce too many times can be seen by inspecting the OnCollisionEnter2D method on BallW3.cs. in this method, the rigidbody's linear velocity is multiplied by the speed multiplier set in the inspector (for me, 1.2f), and then its ballRenderer's color variable is multiplied based on its speed. Since the OnCollisionEnter callback is called every time the ball collides with something (aka bounces), it will speed up and then increase the magnitude of its brightness on each bounce.

### W4
17: this line defines a boolean member variable `_isGrounded` in class CatW4 and sets its value to true. CatW4 is a Component.
28: The Input.GetKeyDown method is called with the parameter KeyCode.Space, returning true if the space key is held; false otherwise. The result of this expression is and'd with the `_isGrounded` variable.
32: sets the `_isGrounded` variable to false after applying a force to the GameObject's RigidBody component to make it jump.

### W5

#### Activity 1: Collaborative Learning
My question was, what is the difference between using the public keyword and [SerializeFeild] for making variables accessible in the editor? 

The answer that I got is that the public keyword makes a variable accessible by other scripts, which may not be what you want. With [SerializeFeild], the variable is still private but can be changed in editor!

#### Activity 2: Pair Programming
Plan for creating the DeerW5.cs class:
1. add a [SerializeFeild] private Transform `_target` member variable
2. attach DeerW5.cs as a component to the Deer GameObject
3. in Start(), use GetComponent<NavMeshAgent>() to get the navmesh on the object
4. set the NavMeshAgent's destination using SetDestination(_target)
depending on your whether your _target moves, you may want to call SetDestination occasionally in Update()!
In my case, I am targetting the red mushroom, which does not move and as such can be set only once.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
