# Self Cutting Simulator

## How to add new skin colours to the application?



1. Create new albedo maps for the wrist and the forearm.  
    The naming should include the word “Albedo”, e.g. “wrist_Albedo_09”
2. Create new materials for wrist and forearm
3. Add the albedo, a normal and a roughness map to the materials.  
    The normal and the roughness maps can be cloned from the already existing versions.
4. Go to: CanvasParent > Canvas > ChangeSkinColorButton and add the materials for the forearm and the wrist to the scripts materialList container.