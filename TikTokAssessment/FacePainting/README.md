# TikTok Assessment -- Face Filter

Manouj Kumar Govindaraju
02/17/2020



The task given through this assessment was to create a 3D effect that will help evaluate my skills and creativity for the position of Interactive Engineer at TikTok. 

Since the topic was very broad and open to my creativity, I went through all the special effects that tik tok offered to get a sense of what is expected. Then I decided to create an effect that will clearly show my Augmented Reality development skills, Unity 3D proficiency, ability to work with shaders and materials and ability to think out of box.

# My Objectives:
To create an AR application with a unique effect that will utilize 
1. Face recognition
2. Raycasting and face collision detection
3. Line rendering
4. Dynamic texture update

# Milestones:
1. Design thinking and feasibility analysis
2. Scheduling
3. Prototyping and development

# Design Thinking
My ideation process started by understanding the design precedents like the existing filters and effects. I took inspiration from them and that helped me in narrowing down my objectives. I did not want to create another filter with a 3D object/texture attached to the face. Instead, I wanted to create an effect with endless possibilities.

I iterated on this idea and ultimately I decided to create an AR face filter with which the users can be creative and design their own effect by painting on their face. With this, there will be limitless possibilities to be creative.

## Functionality - User’s perspective
The AR face filter will detect the face of the users.
User Interface will contain a palette of colors and a erase tool
Users can paint on their face. The paint tracks and moves along with the face. It also receives shadows. 
Erase tool is used to remove paint from the face. 
Functionality - Development 
In order to develop this effect, I created the below list of tasks to be performed. I made sure that it is feasible to do these tasks within the time frame.
AR Core’s Face detection should be used to detect faces
A transparent  (3D) canonical mask will be overlayed on top of the face. A mesh collider will be used on this mask.
A texture mask will be overlayed on top of the face. Texture UV should be unwrapped using script to dynamically update the new texture.
Physics raycast should be done from the touch position on the screen. It should only hit the mesh collider of the face.  
A line should be rendered from the first hit point to the next. Ultimately, as the user drags their hand, a continuous line will be rendered.
Schedule
I started the design research and ideation process as soon as the task was given. Since I had to work and also complete course assignments, I decided to complete this assessment by Saturday the 15th.

February 12th and 13th 		- Research, precedent analysis and ideation
February 13th. 14th and 15th 	- prototype and development
February 16th 			- User test and incorporation of feedback
Development and User test
Tools: Unity, Photoshop, Illustrator
SDKs : Google ARCore
Platform: Android

I was able to develop the intended effect by the scheduled date. During development I faced several issues. So I had to switch to alternative development paths.
Issues and solutions:
I was updating the texture of the hit points directly to the selected color. However, the resulting line was not continuous. It was intermittent due to touch latency. So, I created a line render component to draw line from the initial touch point to the next touch location. 


Google ARCore’s face texture cannot hold a mesh collider. Thus, I had to attach the transparent 3D mask with a mesh collider. I applied the same material used for the texture object to the mask object. Any changes to the albedo of the mask object also changed the texture object. Thus, I was able to indirectly change the texture object’s material.



The texture object’s material should only show the lines drawn. It should otherwise be transparent. However, reducing the transparency will also hide the drawn lines. So a new shader was required. With this shader, the texture object’s initial color is keyed out and only the other colors are shown.


UI:

User tests:
I tested the app with my friends and family. They were able to figure the affordances on their own. They interacted with it naturally and were able to write and paint on their faces with ease.
Based on the feedback, the interface was changed and the ability to change the line width was removed. 





