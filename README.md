#Isaac Vongphakdy
#Xin Ye 485
#Homework Assignment 1

Game includes:
- Menu
- Roll a Ball
- Boxes Game

Boxes Game Introduction:
  This game involves a blue cube player whose goal is to reach the green "Goal Block" on the other side of the map while
collecting items and avoiding enemies. Red enemies patrol the map and block the path to the goal. If the player comes in contact
with an enemy, the player dies and the level is reset. The player starts out with 0 Ammo and can collect an Ammo pick up item
along the way. When an ammo is picked up, the player may shoot and kill an enemy. If the player dies while having 1 ammo,
the ammo count will reset and the player must pick up the Ammo item again.

Instructions:
- Goal: stay within walls, reach Goal block, avoid/kill enemies
- Up, Down, Left, Right: arrow keys
- Shoot: ctrl button

References:
- Overall layout and idea of game: https://www.youtube.com/watch?v=qwuPiaFU37w
- Shooting physics: https://unity3d.com/learn/tutorials/projects/space-shooter-tutorial
- Item pick up: https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial

Personal Contributions:
  My game followed the concept of the video tutorials mentioned in the first link under the "References" section.
I decided to make the game more challenging by having an enemy block the path to the goal, and the only way to pass the enemy
was to kill it. To do so, I added an item pick up element, which I learned from roll a ball. If the player picked up the item,
called "Ammo", the ammoCount float would increase by 1, allowing the player to shoot one bullet. I learned how to shoot the
bullet by following the Space Shooter tutorial. If the player were to die, the entire level would reset and the Ammo would go
back to zero. I also added a menu element at the beginning of the program, and inside the Roll a Ball and Boxes Game scenes,
the player is allowed to go back to the main menu by pressing the button on the top left hand corner.

What I Learned:
  At first, it was difficult to come up with an original game while following tutorials at the same time. Once I settled on
a tutorial to base my game off of, I decided not to make it exactly like the tutorial and make the game more original. 
I added my own aspects to the game and in doing so, I had to mess around with the code myself to figure out solutions to 
program the game the way I wanted it to work. 
  I learned how to create a moveable character that was followed by the main camera. How to create a Prefab of enemies who
would die on contact from a bullet. How to create walls/boundaries that the player would not be allowed to pass. How to allow
the player to pick up items, and how to grant the player an ability from picking up the item. I also learend a bit on 
how to use GUI, which is how I made the main menu.
