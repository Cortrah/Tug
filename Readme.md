# Tug

Tug is an experiment to create a simple two-six player game using some languages and tech that I've yet to use much C#, Blazor, SignalR on the server side and Godot with animations created in Moho on the client side.

It's part of a game jam where I want to learn a few simple codie things and then focus on drawing and animating wolves playing tug.

![A sketch of a design](./Tug/Design/tug-design-4.png?raw=true "Terms and Sketch")

## Basics
To start there is a rope with
StartPt, LeftBoundPt, PrizePt, RightBoundPt, EndPt

Wolf1 walks up and click on the rope triggering a Grab event getting Grip
There is still no tension but the point of the rope raises
Wolf2 walks up and clicks on the rope triggering another Grab event getting Grip

if they are on opposite sides of the prize it creates slack/tension
probably need a start button
once started if the Tension is positive the GripDecay starts decreasing each wolves Grip

if RightWuf Clicks MoveRight it increases tension by something say +1
if LeftWuf Clicks MoveLeft it increases tension by something say +1

Anchor resists +5 tension
Shake tests just Grip
Pull tests +5 of the opponents grip

Gameloop checks if the prize ever gets
less than the LeftBoundPoint or more than the RightBoundPoint
and announces the winner if so.

## ToDo:

1) Create an About page, a Lobby page and add some content to the Home page.

2) Create a signalr data structure for the state of the match, display values like grip and tension
   and save messages that are sent to it from the players in a history queue

3) Model the basic events that need to be sent to the server and back

4) Create a simple Godot interface to send messages to the server

5) Output a moho animation to FBX and translate it to glTF
   look at the moho animation datastructure and lua to export it to svg
   look at the glTF file format

6) Have a single player experience vs a random robot opponent as a stepping point

7) Then fill out the razor Lobby page that lists registered users
   you can select users and send an invite
   or you can create a stage and it will show up in a list for folk to join
   on the stage you join a spot on the table
   when that's the case a wolf appears and walks over to it's spot and grips
   When someone presses the start button the match begins

## References

Moho Scripting Reference(lua)
https://mohoscripting.com/

Convert FXB to glTF
https://github.com/godotengine/FBX2glTF

Problems with using mohos FXB in Unity that might be similar with Godot
https://moho.lostmarble.com/blogs/webinars/webinar-recording-using-moho-for-the-video-game-catie-in-meowmeowland-with-gordana-sramekova

Razor page syntax
https://learn.microsoft.com/en-us/aspnet/core/mvc/views/razor?view=aspnetcore-7.0#rendering-html

Signal R syntax
https://learn.microsoft.com/en-us/aspnet/core/signalr/introduction?view=aspnetcore-8.0&WT.mc_id=dotnet-35129-website