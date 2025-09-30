# in-class-activities
## Devlogs
### W1
When you move the Camera off of the Cat GameObject (re-parent it to another object or the scene root), moving the player will no longer move the Camera along with it.
This is because the parent-child relationship affects the transform (position, rotation, and scale) of an object.
Parent objects add the values in their transform to their child objects, making them "follow" the parent. 
Without the parent-child relationship, the Camera will not have its transform updated by the cat, leading to the disjointed behavior that is observed.

### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
