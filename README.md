<h1>Modular monolith project with .NET Core</h1>
<p>This project was made in order to demonstrate the "better" way in my understanding about the Modularity but
not more to Microservices and not even Monolith System, but the middle ground.

In a way that the project can be transformed at each end from one side to the other easily.</p>


---

---
<h2>This project was created with JetBrains Rider IDE</h2> 
<h3>So there are some recommendations to follow below when working with</h3>
---
<h2>Creating Projects on Rider IDE:</h2>
    <li>Create New Solution Folder to visualize or project structure organized</li>
    <li>Over created solution folder, select to create a new Project</li>
    <p>On selecting the New Project location folder, should be the same as your solution folders structure:</p>
        <code>[project-main-folder]/[solution-folder-name]/[child-solution-folders-and-so-on]/</code>
    Cause the solution folder is intended only for orientation when using Rider IDE, where related files to build
the visual solution structure are loaded from <code>.idea</code> directory.

The objective here is to persist the folders in the filesystem in order to be the same for whatever IDE.
  <li>Create the new project</li>
<h3>Adding project reference dependencies (other projects)</h3>
* Do the same as before, create solution folders, then create or add an existing project to new location based on
solution's folder.
    <li>Click with the right button on the project that will need this other one, and in <code>Add > Reference</code></li>