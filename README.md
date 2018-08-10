# .NetAdapters
This is a collection of classes and extension methods, that adapt the Windows Phone and .Net APIs to the Android and JDK APIs

## Adapters
The Adapter directory contains adapters both for Android and Windows Phone that provide the unified interface ISharedPreferences

## Extensions
The Extensions directory contains several .Net extensions that adapt members of the .Net API to their corresponding Java API types



## ViewModelFramework
The ViewModelFramework directory contains classes that allow subclasses of AbstractViewModel to notify observers on changes to their models using the platform-specific mechanisms. In Java, this is realized using the Observer pattern, in C#, it is realized using events/delegates.


![UML class diagramm showing an example usage of the AbstractVuiewModel class](https://github.com/TilStehle/.NetAdapters/blob/master/Abstract_ViewModels.png)
