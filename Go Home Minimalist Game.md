# Go Home Minimalist Game

#### Objects

- [x] Player Cube
      - [x] [Character Class](#character-class)
      - [x] [Player Movement Class](#player-movement-class)
- [x] Opponent Cube
      - [x] [Character Class](#character-class)
      - [x] [Patrol Movement Class](#patrol-movement-class)
      - [x] [Collision Action Class](#collision-action-class)
- [ ] Goal Cube
      - [ ] Goal Class
- [x] Walls
- [x] Floor
- [x] Game Manager
      - [x] [Game Manager Class](#game-manager-class)
      - [x] [Input Manager Class](#input-manager-class)
- [x] Action Classes
      - [x] Collision Action
      - [x] Destroy Action
      - [x] OnDestroy Action



the player and the opponent are the characters of the game. so i think they can both have the character class.

##### Character Class

​	What do character has? and what can a character do? Characters can *move* but character class wont handle the movement of itself. Let *Movement* and *Player Movement* Classes handle those things for us.

- float speed - characters do have a speed value

##### Patrol Movement Class

​	The basic movement class for our characters. These movements are the basic movement of a character that is being handled by the computer. Or the movement for the AI characters.

- GameObjects patrolPoints - points where the character will move to.

  ​

  ```c#
  this.targetPoint = this.targetPoint >= this.pointLength-1 ? 0 : ++this.targetPoint;

  ```

  when using this formula. make sure that the ++ sign is in the beginning of the variable. if you do it in normal way where you are putting it after, then it will not work.

  ​

##### Player Movement Class

​	The movement for the characters that is being controlled by the player. This class would move our character when it recieved some input from the player.



##### Collision Action Class

​	A script added to an object if you want to add an action when it collide with something.

- Tags



##### Goal Class

​	What should a goal do for our game? trigger the goal event. i dont think goals need to know if a player is within his reach. if you do this, the goal would know more information that he normally dont want to know.

##### Game Manager Class

​	The class that will manage the whole game. like where would the player spawn and look if the player is in the finishline.

- Player Prefab
- startingPoint
- Goal

##### Input Manager Class

​	this class monitors the player input from the game. and informs the game manager for input.

##### Collision Action

​	this action script enables the collision events for a game object. it only has one method but this would make the reusability of this method more easier. This class has an enum that represents what he will do on collision and a string that represents the tags that he will reponds to.

##### Destroy Action

​	this action script destroys the gameobject it is attached to. this is being used by the collision action and attaching this script to who ever collided with it.

​	this script also look in the game object it is attached to if it has OnDestroy class and preforms it if it has.

##### OnDestroy Action

​	OnDestroy class will be inputed to the objects that needs to do something before vanishing from the game. like spawning a particle system.



### Problems Encountered and Solutions Provided

##### Patrol Movement Class Problem

​	i have a method called **changeTarget**. this method would update the current location target when the last target was meet. The first solution for this is...

```c#
void changeTarget(){
	if(this.targetPoint >= this.pointLength-1){
      	this.targetPoint = 0;
	} else {
      	this.targetPoint++;
	}
}
```

​	then i have tried making this code shorter with this...

```c#
void changeTarget(){
		this.targetPoint = this.targetPoint >= this.pointLength-1 ? 0 : this.targetPoint++;
}
```

​	but this method is not working as it has supposed to be. it is not updating… or the ++ is not being called. Then what i have done wrong is because the ++ placed after the this.targetPoint. Where it should be like this.

```c#
void changeTarget(){
		this.targetPoint = this.targetPoint >= this.pointLength-1 ? 0 : ++this.targetPoint;
}
```

​	

##### Game Manager Class Problem

​	when spawning the player. i always have an error that prevents me from doing this. I have called the method called **playerCheck** on **Start** and **axisInput** methods of the class that will check if there is an active player in the game and create one if there is none.

​	It will succesfully create one but it always say that there is something missing at the **applyForce** method of the player movement class. But i didn't get any clue what that is.

​	I have solved this problem by removing the playerCheck from the Start method.



##### OnDestroy Acion Class Problem

​	when i am spawning particles on the OnDestroy function, it always throw an error when the playmode is stoping.

​	it is not recommendable to instantiate an object on OnDestroy, so i make the use the DestroyAction Class to look for this class if the object has one, and preform the **instantiateBeforeDestroy** class before actually destroying it.