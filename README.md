# P4-project
Our 4th semester project, in which we make a compiler to create a higher level language than G-code.


Compile for mac: 
dotnet publish -c Release -r osx.11.0-x64 -p:PublishReadyToRun=true --self-contained true

Compile for windows: 
 dotnet publish -c Release -r win10-x64 -p:PublishReadyToRun=true --self-contained true
 
 to run the OG compiler
 
 cd to the build directory:
 
 run on mac: ./OG   <_full .og filepath_> <_testprint_>
 
 run on win: OG.exe <_full .og filepath_> <_testprint_>
  
 without filepath the compiler can be run from Rider.
 
 with anything at testprint it prints the g-code to console 
 else it creates a .gcode file at the destination of the .og file
 
 
 
