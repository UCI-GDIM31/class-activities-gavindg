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

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
