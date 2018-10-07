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
* 3Ds max for animation, redenring and 3D modeling. 
* Unity3D to develop game.
* Blender to reduce the polygon.

## PROJECT ARTEFACTS
* Meeting Notes: https://drive.google.com/drive/folders/1MEXEly6Cfp3RRHAZ7D2QieKS_ribvz60)
* Tutorial Notes: https://drive.google.com/drive/folders/1D2_nhiIEvt--jTButtrnbDbQWjSf-tK1)
* Client Notes: https://drive.google.com/drive/folders/11pILGl-u_sZ7EmBm4O7iB2B6F-MvDwkM)
* Team members: https://docs.google.com/document/d/1XXsPXXi1cnyj7JQd_063rteS05-5SGZM1a8oHB1HGJ0/edit)

## TECHNICAL ARTEFACTS

### APPROACHES
This is a diagram to show our approaches in different stages.

![image](https://github.com/logeeker/VR-Observatory/blob/master/Audit%20Landing%20Page/progress%20no%20background.png)

### PROTOTYPE
As seen in the video, our group have implemented two shutters, main entrance door opening and closing and main camera controling.

* Prototype link: https://drive.google.com/open?id=1U_Vyd_W7YGodX0voeSHBq56HqtFn4b63

## PROJECT OUTPUT (SINCE WEEK 3)

### ROLE DISTRIBUTION
Since we did not have a role distribution before the audit 1, we found that the group work was not efficient without a division. We considered two different distribution plans. The first was to split the whole group into two small groups. One group dealt with the model in Solidworks, the other added animation and collision to the models by using Unity. The second one was to allocate each member a role and work in parallel. After comparing these two plans, we chose the latter one to ensure everyone has a relative same workload. 

The role distribution was based on the skills and preferences of each member. We also allocated each member a management task in order to reduce the documentation workload of the notetaker.

The distribution of technical and management role are as follows.
![image](https://github.com/logeeker/VR-Observatory/blob/master/Audit%20Landing%20Page/Technical%20task.png)
![image](https://github.com/logeeker/VR-Observatory/blob/master/Audit%20Landing%20Page/Management%20task.png)

### Guidance Handbook (Wenrui)
Our client wanted us to have a document of instructions of all the tasks we have done. Thus, Wenrui has written a handout book to give detailed instructions to the readers. Currently this handbook only contains the guidance of exporting models. This handbook will be supplemented with the completion of each task.

### Import the Observatory models and add mirrors (Wenrui)
The observatory model is one of the challenging part as it contains about 30000 components, some of the parts have inner faces which are not necessary to import. Besides many components with high details are significantly influence the framerate and take up too much storage memory. So the works based on reduce the parts which are unnecessary to demostrate. For important components like mirrors, reflection effects are added to show the smooth surface of mirrors.

### Add a night scene demo with milky way skybox (Wenrui)
The environment of the scene are essential for graphic performance, in order to make the scene looks real, some test scene has been build, which include day night cycle, starry sky, dynamic cloud. For the night part, the milky way skybox has a better visual effect. 

### Attach spot lights on the observatory model (Wenrui)
Adding light source is to enlight the telescope in the night environment, in the inside of the upper enclosure, three group light sources have been added for enlighting the ceiling, one red light has been added to enlight the mirror.

### Adjust the texture (Wenrui)
According to the project requirements, the texture of the shutter is adjusted to be more metal like as well as the color of the pipes are modified to align with the real design. 

### One blinn-phong shading model Implementing (Wenrui)
Since one of the most important part of our project is the graphic performance, we need to attach all models with appropriate shaders. Wenrui has already implemented a blinn-phong shading model, which is the outside of the observatory. Please check the prototype link above to see the model. 

### Scene Layout (Zhenyu)
The arrangement of the observatory scene should be close to the real world scene, and the harmony of these matches should be guaranteed. Thus, we selected the scenes of 11am and 7pm around the observatory and applied for Unity to construct the scenery. Up to now, our group has finished the design of tree, glass, rise and fall of the sun. In the next stage of the project, our group will try to arrange and add decorating assets in the scene. 

### Trigger Making (Yu)
In the real world, it is easy for a player to open the door, enter into the building and take the elevator to whatever levels of the floor. However, in the model, there must be a trigger to listen the player’s instructions and provide related animation. Currently, our group has implemented the door trigger. In the next stage of the project, we will add more triggers into the project.  

### Model Transformation (Taizhou)
Our group based on the “Iterative Model” to process the Model Transformation. Since we have been stuck in file renaming issue for two weeks, up to now, we only have finished the implementation of a core model. In the next stage of the project, we are supposed to concentrate on model transformation and complete it by the end of week 7. 

### LOD group demo (Min)
By searching for some resources, the Level of Detail (LOD) group was considered as an optimization method. LOD means the complexity of a model will decrease when it move away from the viewer. Since each member worked in parallel, the optimization cannot be tested on the project model without other functions. Currently, Min has made a demo to test the effect of LOD group. Three models were added in a LOD group. This optimization method will be used in the project model this week.

### Door and shutter Animation (Lifu)
Our client required us to add some animations to the models, like the opening and closing of the door. By the end of week 9, Lifu has implemented animations of the shutter and the door. By combining the trigger with the animation, users can open the door and shutter by touching the trigger.

### Controls (Seng)
I have been mainly working on the implementation of VR. Similar to the previous non VR version, the VR version has a flying mode with no collision detection and a walking mode with collision detection activated. Both the VR and non VR version of the controls are now integrated in the actual project with the observatory models. Other than the controls I have also set up Unity Collaborate (it's basically version control for Unity) to speed up the development for the team.

## VALUE DELIVERED TO THE CLIENT

* Simplify part of models. Using blender and 3DMAX to reduce polygons. We transform six
main models file format using 3DMAX, and we reduce polygons for one model (Shutter). For polygons reducing process, the main task is to find out components which can not been seen directly.
* Identify materials, textures, reflection, colors. We use shader lab to implement glass,steel and concrete materials and bind on the real models.
* Implement open/close shutters, main entrance door: One basic animation state machine has been implement to control the open/close shutters, one for control the main entrance door.
* Gravity and collision detection-for walking and logistics: Implement keyboard controller to control the player moving, which concludes a flying mode and walking mode.
* Outdoor scenery: some assets such as grass and trees has been added to the main scene as well as drawing a temporary terrain for demonstration.
* We create the draft version user manual to guide next development team or client. 

## DOCUMENTATION

* Meeting minutes: https://drive.google.com/drive/folders/1oKBWNELC3S7AG890oS9v8DCupTLNOfBR
* Changing & Decision Making Log: https://drive.google.com/drive/folders/1776P_mnA7-Wi0ipBj1ftQXCaFMPazd5l
* Feedback: https://drive.google.com/drive/folders/1E5yIg3d-5k_Wjmqf5Nhd6GIGTa_Ha3RI
* Schedual & Task: https://drive.google.com/drive/folders/1--FPXei4-tayVnUPRBbYhAE0OBaoPdw-
* Work Distribution: https://drive.google.com/drive/folders/1l0bR8nKL50gtQHXJxaDtsek5KaImEhcL
* Trouble Shooting: https://drive.google.com/drive/folders/1m3TXjq4uScbYG9tHlvmZAO0d2g0eN8dM
* Working Log: https://drive.google.com/drive/folders/1r7FeKttsb63_vF9OvEKYS0w8cvRCgsfq
* Risk Identify: https://docs.google.com/spreadsheets/d/1VCMeprx5Luwrqnj5r75JO-bccIG-6LeEqe17zqrMJkE/edit#gid=0
* Developing Guidence Handbook: https://docs.google.com/document/d/1b-LKgApiEaLc9_Oi43MBGmVRToHIzsCwrjwGGQ229qo/edit

## DECISION MAKING PROCESS
Our group based on “Change Request Form” to process the decision making. Each time when some team members want to make certain changes, they are supposed to follow the instructions of “Change Request Form” to submit an application to the relevant person in charge (e.g. if the issue is about model processing, the responsible person is the leader of model processing). Then, the leader will decide to process this change or not. In addition, the responsible person can also identify the change into the group meeting to process. 

* Decision making log: https://drive.google.com/drive/folders/1776P_mnA7-Wi0ipBj1ftQXCaFMPazd5l

## FEEDBACK FROM CLIENT/TUTOR
We collected and documented the feedback from the shadow team and tutor, mainly from the audit feedback. Based on those feedback, we created some documents, linked above. The feedback reflection can be found in the next part. More details about the feedback can be find in the link.(https://drive.google.com/drive/folders/1E5yIg3d-5k_Wjmqf5Nhd6GIGTa_Ha3RI)

## ACTING ON FEEDBACK FROM AUDIT ONE
After first audit, some problems have be pointed by shadow team and tutor. Our team record feedback and made changes to improve our project developing process. Based on those feedback, our team made changes listed at below.

* For outcomes to client, we re-identify our MVP clearly. Our group decide to make a prototype to implement the basic animation and controlling for client delivery. Our group have implement two shutters and main entrance door animation and main camera movements. Once we finish a release version, we will submit to client to finish a iteration. In each iteration, the application developing process will repeat prototyping, testing and delivering. 

* For decision making, the decision making log will been maintained to keep track our changes and help clients knowing our working process. In the decision making process, our team use the request forms and log table to record each significant decision have made so far. The request forms contain details, justification and description about changes.

* For teamwork and communication, our team have assigned the work distribution for each member to help members have clear goal for developing process. Accoding to work distribution, our team split to two sub-teams which work on RSAA workshop in Monday and Saturday. Based on the setting of sub-team work shifting, our team decide hold weekly meeting on Sunday. During this meeting we can communicate tasks have been done and hand over unfinished tasks,and it is a good opportunity to exchange ideas and solve issues. The client meeting will be hold on each week Monday, we can show current process and changes to clients to looking for feedback. 

* For documentation, the required documents have be created and stored into the Google drive. Our team re-edit old version of documents and keep it into formal. For each documents, they can be found on the audit landing page. 

