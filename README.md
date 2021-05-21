# P4-project
Our 4th semester project, in which we make a compiler to create a higher level language than G-code.

Choose "Release" in Rider (the button right of the hammer and left of the "play" button)
Then compile the program, pressing the hammer.
 
To run the OG compiler
 
cd to the build directory (OG/OG/bin/net5.0/Release):
 
 run on mac: ./OG   <_full .og filepath_> <options>
 
 run on win: OG.exe <_full .og filepath_> <options>
 
 run platform independent: dotnet OG.dll <_full .og filepath_> <type_anything_to_write_to_console>
 to run from root (win): dotnet OG\OG\bin\Release\net5.0\OG.dll C:\Users\Martin\projects\P4\P4-project\OG\OG\testfile.og
  
 without filepath the compiler can be run from Rider, always running testfile.og
 
 with anything at options it prints the g-code to console 
 else it creates a .gcode file at the destination of the .og file
 
