# Audit Landing Page *VR-Observatory*

## CLIENT VISION
>The Giant Magellan Telescope will be one member of the next class of giant ground-based telescopes. It will be constructed in the Las Campanas Observatory in Chile. Commissioning of the telescope is scheduled to begin in 2024.

Our goal is to recreate the observatory in a Virtual Reality world. This software allows users to experience the observatory with a VR headset before the completion of the construction of the GMT. It can be used not only for promotion purpose but also as a tool to validate the design.

## TEAM
* Seng Cheong Song - u5767037
* Min Liu - u6339307
* Lifu Zhao - u6534756
* Yu Yang - u6412985
* Wenrui Li - u6361099
* Zhen Yu Zhao - u6210785
* Taizhou Wang - u6273306

## TOOLS USED
* Discord for communication with team members, shadow team, tutor and cilent.
* Google Drive to hold documents. 
* Solidworks for technical drawing. 
* Meshlab to process and edit 3D triangular meshes. 
* 3Ds max for animation, redering and 3D modeling. 
* Unity3D to develop game.
* Blender 

## PROJECT ARTEFACTS
* Meeting Notes(https://drive.google.com/drive/folders/1MEXEly6Cfp3RRHAZ7D2QieKS_ribvz60)
* Tutorial Notes (https://drive.google.com/drive/folders/1D2_nhiIEvt--jTButtrnbDbQWjSf-tK1)
* Client Notes (https://drive.google.com/drive/folders/11pILGl-u_sZ7EmBm4O7iB2B6F-MvDwkM)
* Team members (https://docs.google.com/document/d/1XXsPXXi1cnyj7JQd_063rteS05-5SGZM1a8oHB1HGJ0/edit)

## TECHNICAL ARTEFACTS

### MODEL

### PROTOTYPE
This is a screen shot of our prototype, and it have implemented two shutters, main entrance door opening and closing and main camera controling. 

![image](https://github.com/logeeker/VR-Observatory/blob/master/Audit%20Landing%20Page/Prototype.png)

### SOURCE CODE

## PROJECT OUTPUT (SINCE WEEK 3)

### ROLE DISTRIBUTION
Since we did not have a role distribution before the audit 1, we found that the group work was not efficient without a division. We considered two different distribution plans. The first was to split the whole group into two small groups. One group dealt with the model in Solidworks, the other added animation and collision to the models by using Unity. The second one was to allocate each memeber a role and work in parallel. 

### ROLE DISTRIBUTION
## Scene Layout
The arrangement of the observatory scene should be as close as possible to the vision, and the harmony of these matches should be guaranteed. Thus, we select the scene of 11am and 7pm around the observatory and apply for Unity to construct the scenery. Up to now, our group has finished the design of tree, glass, rise and fall of the sun. In the next stage of the project, our group will try to arrange and add decorating assets in the scene. 


## Trigger Making
In the real world, it is easy for a player to open the door, enter into the building and take the elevator to whatever levels of the floor. However, in the model, there must be a trigger to listen the player’s instructions and provide related animation. Currently, our group has implemented the door trigger. In the next stage of the project, we will add more triggers into the project.  

## Model Transformation
Our group based on the “Iterative Model” to process the Model Transformation. Since we have been stuck in file extension issue for two weeks, up to now, we only have finished the implementation of a core model. In the next stage of the project, we are supposed to concentrate on model transformation and complete it by the end of week 7. 

1. Converted part of the models into Unity.
2. Added a door-open animation to the model.
4. Used a demo to test the LOD group.
The detailed outcomes: (https://drive.google.com/drive/folders/1gAqK06plusJ-dFTzoo-Kluq5JwEL2FNu)

## VALUE DELIVERED TO THE CLIENT

* Simplify part of models. Using blender and 3DMAX to reduce polygons. We transform six
main models file format using 3DMAX, and we reduce polygons for one model (Shutter). For polygons reducing process, the main task is to find out components which can not been seen directly.
* Identify materials, textures, reflection, colors. We using shader lab to implement glass,steel and concrete materials and bind on the real models.
* Implement open/close shutters, main entrance door: One basic animation state machine has been implement to control the open/close shutters, one for control the main entrance door.
* Gravity and collision detection-for walking and logistics: Implement keyboard controller to control the player moving, which concludes a flying mode and walking mode.
* Outdoor scenery: some assets such as grass and trees has been added to the main scene as well as drawing a temporary terrain for demonstration.
* We create the draft version user manual to guide next development team or client. 

## DOCUMENTATION

* Meeting minutes: https://drive.google.com/drive/folders/1oKBWNELC3S7AG890oS9v8DCupTLNOfBR
* Decision Making Log: https://drive.google.com/drive/folders/1776P_mnA7-Wi0ipBj1ftQXCaFMPazd5l
* Feedback: https://drive.google.com/drive/folders/1E5yIg3d-5k_Wjmqf5Nhd6GIGTa_Ha3RI
* Schedual & Task: https://drive.google.com/drive/folders/1--FPXei4-tayVnUPRBbYhAE0OBaoPdw-
* Work Distribution: https://drive.google.com/drive/folders/1l0bR8nKL50gtQHXJxaDtsek5KaImEhcL
* Trouble Shooting: https://drive.google.com/drive/folders/1m3TXjq4uScbYG9tHlvmZAO0d2g0eN8dM
* Working Log: https://drive.google.com/drive/folders/1r7FeKttsb63_vF9OvEKYS0w8cvRCgsfq
* Risk Identify: https://docs.google.com/spreadsheets/d/1VCMeprx5Luwrqnj5r75JO-bccIG-6LeEqe17zqrMJkE/edit#gid=0
* Developing Guidence Handbook: https://docs.google.com/document/d/1b-LKgApiEaLc9_Oi43MBGmVRToHIzsCwrjwGGQ229qo/edit

## DECISION MAKING PROCESS
Decision making log: (https://drive.google.com/drive/folders/1m3TXjq4uScbYG9tHlvmZAO0d2g0eN8dM)

## FEEDBACK FROM CLIENT/TUTOR
Feedback folder: (https://drive.google.com/drive/folders/1E5yIg3d-5k_Wjmqf5Nhd6GIGTa_Ha3RI)

## ACTING ON FEEDBACK FROM AUDIT ONE
After first audit, some problems have be pointed by shadow team and tutor. Our team record feedback and made changes to improve our project developing process. Based on those feedback,our team made changes listed at below.

* For outcomes to client, we re-identify our MVP clearly. Our group decide to make a prototype to implement the basic animation and controlling for client delivery. Our group have implement two shutters and main entrance door animation and main camera movements. Once we finish a release version, we will submit to client to finish a iteration. In each iteration, the application developing process will repeat prototyping, testing and delivering. 

* For decision making, the decision making log will been maintained to keep track our changes and help clients knowing our working process. In the decision making process, our team use the request forms and log table to record each significant decision have made so far. The request forms contain details, justification and description about changes.

* For teamwork and communication, our team have assigned the work distribution for each member to help members have clear goal for developing process. Accoding to work distribution, our team split to two sub-teams which work on RSAA workshop in Monday and Saturday. Based on the setting of sub-team work shifting, our team decide hold weekly meeting on Sunday. During this meeting we can communicate tasks have been done and hand over unfinished tasks,and it is a good opportunity to exchange ideas and solve issues. The client meeting will be hold on each week Monday, we can show current process and changes to clients to looking for feedback. 

* For documentation, the required documents have be created and stored into the Google drive. Our team re-edit old version of documents and keep it into formal. For each documents, they can be found on the audit landing page. 

