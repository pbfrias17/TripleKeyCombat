Quick Triple-Key Combat System

This project is a showcase of a simple combat system that uses 3 keys.

Developed on Unity 5.2

Obtain by cloning the repo and opening the root folder into Unity.
Repo contains all necessary files for Unity to import, test and build.

How to play:
You can use alpha keys 1, 2, 3 or Left Arrow, Down Arrow, and Right Arrow
(which correspond to 1, 2, 3).

Whenever you press a combination of appropriate keys, your character will move
and attack enemies that correspond to that spot.

The game is set up into 3 sections - each section containing a 3x3 grid.
Each 3x3 grid is set up as a cartesion grid, where the origin of {1, 1} represents
the top-left corner and {3, 3} represents the lower-right corner.

So if you press:
	1, 3, 3 -> The character will move to section 1 and attack the coordinate {3, 3}
		i.e. You attack the lower-right corner of the first section
	2, 2, 2 -> You attack the middle block of the middle section

