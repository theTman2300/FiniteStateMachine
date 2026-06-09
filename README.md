# FiniteStateMachine


## Instructions
Download the  file from the releases tab.
Unzip the file.
Open FiniteStateMachine.exe

To quit, use alt + f4

Move using WASD and see how the enemy reacts


## Devlog

### Summary
text here

### Introduction
Welcome to the devlog of my simple finite state machine. This is a project I made to learn more about how to make a finite state machine and how they work. Another goal was to learn a little about keeping (more) proper code documentation, this is something i did in draw.io with uml graphs.

### Planning

I wanted to lay out a simple flowchart to plan out all of the states, this is also something that I did in draw.io.
See here the states that I ended up with:

<img width="639" height="286" alt="afbeelding" src="https://github.com/user-attachments/assets/21de51b3-0d72-403a-8d71-7d74088e1796" />

After doing some research I also wanted to make a plan in uml on how I wanted to implement the Finite state machine(FSM)

<img width="595" height="391" alt="Screenshot 2026-06-01 160902" src="https://github.com/user-attachments/assets/3ff1828f-73b0-4017-9ed8-7e065ea96596" />

Even though this is not how I ended up implementing it exactly, it was a big help in implementing it faster and having a bigger picture of how I actually wanted things to work.
I planned the code to work in a way where states have transitions that lead to other states. Each transition can only point to one other state, but each state can have multiple transitios. The transitions attached to a state will be checked until one of them is met, in which case an event is sent out that will be recieved by the finite state machine, This will than switch the state to the new state included in the transition and start checking the new transitions.

### Basic implementations

The first thing I made was a very simple playercontroller using the new Unity input system, which is a system that I didn't have much experience with yet and wanted to become better at. The new input system is a bit more difficult to set up than the old one, however when it is set up it is a lot easier to add more control schemes to it. This means that adding controller support for example is made a lot easier.
I also made a very small level and a static top-down camera, this was all to make the eventual testing of the actual enemy and it's states a lot easier. 

<img width="908" height="746" alt="afbeelding" src="https://github.com/user-attachments/assets/e930fd77-257d-4185-84b4-866209fb960b" />

After completing the playercontroller, I moved on to implementing the code that I planned previously. This would be the abstract classes from which the actual states/transitions/statemachines would inherit. At first, i just implemented this very basic version with no actual functionality, but I made sure that it could properly be inherited from.

### State implementation

Time to do the states, the most important/fun part of this project! I have all the states and ways i want to transition between them all planned out, which mean that they only need to be implemented.
Doing this was slightly challenging, as at first i didn't know how I was actually going to change the abstract classes into something more useful. Eventually i came up with the basic version of the stateMachine script to inherit from monoBehavior and that a more specific statemachine could inherit from that if necessary. The states and transitions were both made to inherit from ScriptableObject, making them more eaily reusable and customisable.
The next issue I ran into was one where I didn't know how to reference the player and enemy in the scriptableObjects. After trying some things like passing them when setting the states, i eventually settled on them searching for the references they need by tag, because all the states and transitions can need slightly different things. On top of that, they are not called very often and not very many at the same time, meaning the performance impact should be negligable.

<img width="1805" height="287" alt="afbeelding" src="https://github.com/user-attachments/assets/2eb50e32-3a65-4bd5-aaaf-a71fed93012f" />

This is how my documentation ended up with all of the states and transitions inheriting from the abstract scripts.
To make the enemy I used Unity' built in navmesh system and navMeshAgent, this is because it is a system that works very well and is also really easy to use. I only have to set the destination of an enemy and it will just go there without having to actually program the specific movement code. 

Another thing I implemented was some UI text that showed the current state of the enemy, as this seemed like an important thing to showcase for a project all about learning about finite state machines. This is also something that is more difficult to tell just from how the enemy behaves, so I think this was a very good addition.

I held a playtest just to see if everything would function properly on another device as well, which it did, and to see if there was any feedback to make things more clear. I didn't expect much feedback, because the project is more about the functionality than the design, but I did get some feedback about the fact that the playable area didnt have any barriers on the edge, meaning you would fall off and be unable to do anything until relaucnhing the project. Very easey fix, but relatively important. 

### Reflection

I learned a lot from this project, this is a strategy that I hadn't used before and it was pretty challenging at first. I think that I now know a lot more about this and implementing it again would go a lot easier. If I were to do this again, I might find a way to set up my documentation differently, because the way that I did it this time feels unorganized, so that is something that I will have to look into more. However, the fact that the documentation is there and complete was my inital  goal, so I am hapy about that. If I were to do it again I might also put in more assets from the internet, however this time I chose against it to focus more on the actual strategy and not the look and feel of the project. All in all i would call this a great success!

<img width="1920" height="1200" alt="afbeelding" src="https://github.com/user-attachments/assets/e05d7362-657c-4b00-b7d2-e835a5681685" />
