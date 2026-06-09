# FiniteStateMachine
Welcome to the devlog of my simple finite state machine. This is a project I made to learn more about how to make a finite state machine and how they work. Another goal was to learn a little about keeping (more) proper code documentation, this is something i did in draw.io with uml graphs.

## Instructions
Download the  file from the releases tab.
Unzip the file.
Open FiniteStateMachine.exe

To quit, use alt + f4

Move using WASD and see how the enemy reacts


## Devlog

### Planning

I wanted to lay out a simple flowchart to plan out all of the states, this is also something that I did in draw.io.
See here the states that I ended up with:

<img width="639" height="286" alt="afbeelding" src="https://github.com/user-attachments/assets/21de51b3-0d72-403a-8d71-7d74088e1796" />

After doing some research I also wanted to make a plan in uml on how I wanted to implement the Finite state machine(FSM)

<img width="595" height="391" alt="Screenshot 2026-06-01 160902" src="https://github.com/user-attachments/assets/3ff1828f-73b0-4017-9ed8-7e065ea96596" />

Even though this is not how I ended up implementing it exactly, it was a big help in implementing it faster and having a bigger picture of how I actually wanted things to work.

### Basic implementations

The first thing I made was a very simple playercontroller using the new Unity input system, which is a system that I didn't have much experience with yet and wanted to become better at.
I also made a very small level and a static top-down camera, this was all to make the eventual testing of the actual enemy and it's states a lot easier. 

<img width="908" height="746" alt="afbeelding" src="https://github.com/user-attachments/assets/e930fd77-257d-4185-84b4-866209fb960b" />

