<p align="center">
  <img src="https://github.com/osmosis10/versionController/blob/master/WinFormsApp1/Resources/favicon.ico?raw=true" alt="alt text">
</p>

<h2 align="center">|CoLab!| Version Control GUI for DAW's</h2>

<p align="center">
  <img src="https://github.com/osmosis10/versionController/blob/master/WinFormsApp1/Resources/new_main_menu.png" alt="alt text">
</p>





# CoLab
---
 CoLab GUI, designed to test an implementation of version control for DAW's (Digital Audio Workstation's) 
 using *git*, for tools like FL Studio which is what CoLab currently soley caters towards. I had the idea from 
 my own experience using FL Studio and other creator's I know and thought that it would be cool to expirement with 
 a prototype to simulate what it could look like

# Use 
---
User's can utilize repositories to easily obtain stems for a project without 
having to send each other the stems in folders or the project .flp. CoLab will
copy a project's stems to the working directory to be copied to the FL studio's
recordings directory

# Features 
---

##  Create Project
### User's can create repositories from the CoLab GUI by entering their github *username* 
### and entering a generated Github *personal access token* 
![alt text](https://github.com/osmosis10/versionController/blob/master/WinFormsApp1/Resources/CreateFeaturedImage.jpg) 
---


## Join project (Coming soon)
### User's are able to clone an existing repo to a folder with a simple UI to enter in
### the repo link and a select the local destination
![alt text](https://github.com/osmosis10/versionController/blob/master/WinFormsApp1/Resources/join_feature.png)
---

## Existing Repo
### User's can enter a folder linked to an existing repo to either push or pull changes 
![alt text](https://github.com/osmosis10/versionController/blob/master/WinFormsApp1/Resources/ExistingProjectImage.jpg) 
---

### Steps for *uploading*
#### 1. Select Project name from file list
#### 2. Write summary (commit message)
#### 4. Click *upload* button
---

### Steps for *downloading*
#### 1. Select Project name from file list
#### 2. Select the *Discard* or *Save* and *Apply* local changes
#### 3. Click *download* button
--

### Revert (coming soon)


# REQUREMENTS/CONSIDERATIONS
## - CoLab requires collaberators to be using the same version of FL Studio (20 or higher)
## - CoLab DOES NOT account for or keep track of any third party plug-in's used
