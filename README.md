# ICG_Midterm
## Jelani Garnes - 100801696
### General
- [X] A playable main character
- [ ] A win/lose condition

### Controls
WASD - Player movement </br>
Spacebar - Jump </br>
Mouse pointer - Look </br>

Toon shader on plane to give the cartoon look, wanted to add more environmental effects and models but mouse wasn't working properly.
I calculated the diffuse and specular lighting for the object, then map the calculated lighting values to the ramp texture to determine the final color of the object which samples a specific color from the ramp texture based on the lighting value.

Normal mapping applied to the ship models, one moves and you can toggle with 1,2 to see the changes in lighting.
this uses a texture to store information about how to modify the surface normals across the model. The bright cyan areas in the normal map texture show a steep modification to the polygon’s surface normal.

LUT color grading was tried for giving the desert look but LUT came out weird and should toggle with 0 and 3.
Color grading is the process of altering and enhancing the color of a motion picture, video image, or still image. Changing the color of the pixel.

