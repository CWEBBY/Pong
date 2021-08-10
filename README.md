# pong
Pong, in Unity.  
  
Made in: Unity 2019.4.17f1.
Time taken: 10 Hours (4 Planning, 6 Making).

Notes:
For this exercise, I wanted to make a version of Pong that could be very 'swappable', with a lot of loose coupling.
I thought of Pong and how little it takes to run as such little happens in it. From there, I decided to approach it as an event driven exercise.
I was reminded of Ryan Hipple's talk on ScriptableObject Architecture (https://www.youtube.com/watch?v=raQ3iHhE_Kk), wherein he uses SOs as a container for events and references to structs/classes, allowing them to be easily moved around the editor outside of the code.

Some assumptions were made during this excercise. Here are some of them:
1) As this was a test of code practicality, I did not go 'out of my way' to code defensively. A stray null *may* through an exception, this is less of a runtime error and more of an editor reference error.
2) With the target being small in scope and using no outside code, no namespaces were used. This is not usual of me but this excercise was small and prototypical.
3) There is a lack of nice project structure in that, due to the nature of the exercise, additive scene structure, bootstrapping and editor GUI tools are missing. There are some cases where the inheritance chain of classes form an 'ugly' looking inspector as GUI elements are not organised. With the idea of modularity in mind, additive scenes were used extensively to organise function.
4) In mind way the idea that this was the classic Pong, but written using clean code, the end product mirrors that as best it can, but also takes some liberties.

Also, I notice *some* but not all formatting (namely, some indentation) must be presenting weirdly on HTML or is weird in the file and I didn't see it in VS2019.
