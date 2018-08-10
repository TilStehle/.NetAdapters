# .NetAdapters
This is a collection of classes and extension methods, that adapt the Windows Phone and .Net APIs to the Android and JDK APIs

##Adapters
The Adapter directory conatains Adapters both for Android and Windows Phone that provide the unified Interface ISharedPreferences

##Extensions
The Extensions directory conatains Several .Net Extensions that adapt members of the .Net API to their corresponding Java API types



##ViewModelFramework
The ViewModelFramework directory conatains classes that allow subclasses of AbstractViewModel to notify observers on changes to their models using the platform-specific mechanisms. In Java, this is realized using the Observer-Pattern, in C#, it is realized using events/delegates.


![UML class diagramm showing an example usage of the AbstractVuiewModel class](https://github.com/TilStehle/.NetAdapters/blob/master/Abstract_ViewModels.png)
