java -version:
==============
java version "1.8.0_261"
Java(TM) SE Runtime Environment (build 1.8.0_261-b12)
Java HotSpot(TM) 64-Bit Server VM (build 25.261-b12, mixed mode)

javac -version:
===============
javac 13

Installation directory of JDK and JRE:
======================================
C:\Program Files\Java\jdk-13
C:\Program Files\Java\jre1.8.0_261

Error: 
======
A JNI error has occurred, please check your installation and try again
Exception in thread "main" java.lang.UnsupportedClassVersionError: Addition has been compiled by a more recent version of the Java Runtime (class file version 57.0), this version of the Java Runtime only recognizes class file versions up to 52.0

Compile with parameters:
=========================
javac -target 1.8 -source 1.8 Addition.java

Run:
====
java Addition