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

* Prototype link: https://drive.google.com/drive/folders/114aibWOXVej2XNXt5kSz6sESz-uZHYZu

## PROJECT OUTPUT (SINCE WEEK 6)

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
The arrangement of the observatory scene should be close to the real world scene, and the harmony of these matches should be guaranteed. Thus, Zhenyu selected the scenes of 11am and 7pm around the observatory and applied for Unity to construct the scenery. Up to now, our group has finished the design of tree, glass, rise and fall of the sun. In the next stage of the project, our group will try to arrange and add decorating assets in the scene. 

### Interaction implementation (Yu)
Yu Yang has implemented more triggers for interaction. Now users can interact with the model by keyboard. The interaction parts are as follows:
1. Users can control the shuttle open and close.
2. They can also interact with some doors inside the observatory.
3. The observatory can be rotated in another direction if users want.
4. Users can switch the inside lights.

### Model Transformation (Taizhou)
Our group based on the “Iterative Model” to process the Model Transformation. Taizhou has separated the large model into several parts, define them with new name and convert them into Blender to reduce polygons. In addition, during the convertion of the model, Taizhou process some basic operations to adjust the components and reduce the polygons.  

### File Redownloading (Min)
Since the old downloaded models missed some files, it was difficult to find the missing files in thousands of components, thus Min redownloaded all models from SolidWork PDM. Due to the wrong folder format, the thousands of files cannot be downloaded as a zip file, so Min downloaded these files manually (which really took a long time).

### Model Categorizing and Conversion (Min)
One of the most important components of our project is the telescope. The telescope assembly contains many detailed models which are not necessary for our game model, removing these trivial models can not only reduce the model size but also increase the calculating time in Unity. Min categorized the components of telescope as 16 parts, like the frame, elevation cable, stair, etc. She also converted these SOLIDWORKS Assemblies to iges files and removed the models with more than 1GB size.

### Door and shutter Animation (Lifu)
Our client required us to add some animations to the models, like the opening and closing of the door. By the end of week 9, Lifu has implemented animations of the shutter and the door. By combining the trigger with the animation, users can open the door and shutter by touching the trigger.

### Controls (Seng)
He has been mainly working on the implementation of VR. Similar to the previous non VR version, the VR version has a flying mode with no collision detection and a walking mode with collision detection activated. Both the VR and non VR version of the controls are now integrated in the actual project with the observatory models. Other than the controls he has also set up Unity Collaborate (it's basically version control for Unity) to speed up the development for the team.

## VALUE DELIVERED TO THE CLIENT

* Finalized technical documents and guidance for the next development team.
* All main components have been converted and reconstructed in unity.
* Build a unity project with interactions, animations and post-process.
* Create statistic logs of model component files that facilitates the process of reporting to the Client and resource management.
* Implemented controller of the VR version.


## DOCUMENTATION

* Meeting minutes: https://drive.google.com/drive/folders/1oKBWNELC3S7AG890oS9v8DCupTLNOfBR?usp=sharing
* Changing & Decision Making Log: https://drive.google.com/drive/folders/1776P_mnA7-Wi0ipBj1ftQXCaFMPazd5l?usp=sharing
* Feedback: https://docs.google.com/document/d/1oksp-XdE3UmiErHipuf5E_InyXZC9jp6_DyAirgbG3Y/edit?usp=sharing
* Schedual & Task: https://drive.google.com/drive/folders/1--FPXei4-tayVnUPRBbYhAE0OBaoPdw-?usp=sharing
* Work Distribution: https://docs.google.com/document/d/1XXsPXXi1cnyj7JQd_063rteS05-5SGZM1a8oHB1HGJ0/edit?usp=sharing
* Trouble Shooting: https://drive.google.com/drive/folders/1m3TXjq4uScbYG9tHlvmZAO0d2g0eN8dM?usp=sharing
* Working Log: https://drive.google.com/drive/folders/1kVoC0xX3ecMd9PkQ1O9YZVojlorRQ1va?usp=sharing
* Risk Identify: https://docs.google.com/spreadsheets/d/1VCMeprx5Luwrqnj5r75JO-bccIG-6LeEqe17zqrMJkE/edit?usp=sharing
* Developing Guidence Handbook: https://docs.google.com/document/d/1b-LKgApiEaLc9_Oi43MBGmVRToHIzsCwrjwGGQ229qo/edit?usp=sharing

## DECISION MAKING PROCESS
Our old decision making process is based on “Change Request Form”. Each time when some team members want to make certain changes, they are supposed to follow the instructions of “Change Request Form” to submit an application to the relevant person in charge (e.g. if the issue is about model processing, the responsible person is the leader of model processing). Then, the leader will decide to process this change or not. In addition, the responsible person can also identify the change into the group meeting to process.

However, from some feedback in audit 2, we think "Change Request Form" is not very necessary for a team of 7 people. Thus for small changes, like the color of texture or choosing the application for model conversion, we no longer use the "Change Request Form". We just record these decisions in decision making log in order to keep track of the decisions we made. But we still keep the "Change Request Form" for big decisions, like choosing the developing tool, which can make our project more standardized.

* Decision making log: https://drive.google.com/drive/folders/1776P_mnA7-Wi0ipBj1ftQXCaFMPazd5l

## WORK PROGRESS
From the feedback in audit 2, tutor suggested us to have a document to show the rate of the progress of each tasks. The reason to have this document is to visualize the work we have done and the work we still need to do, also the time to completion should be included. Based on the feedback, we created a work progress file which included several parts of our project. Each part it has a description, a rate of progress and the detailed items.

* Work Progress: https://docs.google.com/document/d/1ZjBEWjGe1PZEZTK4V8xZ3Bw7H1oxQY-zYsl3a8D_7Yk/edit

## FEEDBACK FROM CLIENT/TUTOR
We collected and documented the feedback from the shadow team and tutor, mainly from the audit feedback. Based on those feedback, we created some documents, linked above. The feedback reflection can be found in the next part. More details about the feedback can be find in the link.(https://drive.google.com/drive/folders/1E5yIg3d-5k_Wjmqf5Nhd6GIGTa_Ha3RI)

## ACTING ON FEEDBACK FROM AUDIT TWO
After the first audit, some problems have been pointed by shadow team and tutor. Our team record feedback and made changes to improve our project developing process. Based on that feedback, our team made changes listed at below:

### Project output:
* Recording more details in the meeting notes.  
* Updated the prototype according to the clients’ requirements. The model, now, has laser, mirrors and lights.  
* The progress has been evaluated according to what we have done, which can help the client have better understand how far we have gone.  

### Decision making: 
* Applying the change request form when facing significant changing requests. Recording the small decisions in the decision log.  
* Add one column in the decision-making log to explain why we made that decision.  
* The decision has also been recorded on time during the meetings.   
* For one decision, the alternative solutions have also been recorded and the solutions we accepted have been highlighted.  

### Communication and teamwork:
* The efficiency has been improved. We show the model to the client by a video which is a more effective way to display the current model we have.  
* The personal working log has been created to record personal progress.  
* Applying the github collaborators to develop.  

