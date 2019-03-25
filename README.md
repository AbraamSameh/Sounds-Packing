# Sounds Packing
---
### Sounds Packing is a C# Windows Form Application to group set of sounds records into separate folders based on time duration regardless their order. Such that you will produce folders each has specific duration records.
---

## Example
### we need to listen to some lessons with total duration 30 hours during the month, so we need to listen to 1 hour records per day, we group these records into folders each has records with total duration about 1 hour.
---
## Example for the Input and Output of the Project

**Input**: 6 files with different durations<br/> 
**Desired**: 100 sec/folder

![Sample Input Example](https://github.com/AbraamSameh/Sounds-Packing/blob/master/Images/Sample_Input_Example.PNG?raw=true "Sample Input Image")

**Output**: 2 folders, each with max of 100 sec

![Sample Output Example](https://raw.githubusercontent.com/AbraamSameh/Sounds-Packing/master/Images/Sample_Output_Example.PNG "Sample Output Image")

---

## Your Task
Is to assign the sound files into folders each folder shall contain specific duration using as few folders as
possible. It seems that not all algorithms can find the optimal packing. Instead, your goal is to design some heuristics
and algorithms to check which run fast and produce high quality solutions.

---

## Sample Run of Application

![Sample Run](https://raw.githubusercontent.com/AbraamSameh/Sounds-Packing/master/Images/Sample_Run_1.PNG "Sample Run Image")

![Sample Run](https://raw.githubusercontent.com/AbraamSameh/Sounds-Packing/master/Images/Sample_Run_2.PNG "Sample Run Image")

---

## Algorithms Used in this Application
* Worst Fit Algorithm Using Linear Search
* Worst Fit Algorithm Using Priority Queue
* Worst Fit Decreasing Algorithm Using Linear Search
* Worst Fit Decreasing Algorithm Using Priority Queue
* Best Fit Algorithm Using Linear Search
* Best Fit Decreasing Algorithm Using Linear Search
* First Fit Decreasing Algorithm Using Linear Search
* Folder Filling Algorithm
---
