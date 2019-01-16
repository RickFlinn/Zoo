# Zoo


This is a project designed to illustrate basic knowledge of OOP principles. A "Zoo" of object classes are all derived from a base "Animal" class. 

## Inheritance

A base class, Animal, is used to derive two child classes, Mammal and Reptile, which are in turn used to derive a number of child classes that represent different animals. Each derived class "inherits" the methods and properties of its base class. All classes derived from Animal, for example, inherit the IsAnimal boolean property; each may call this property as their own, without having to define this behavior individually in each child class. 

## Abstraction

Abstract concepts, like the idea of a Computer, can be described as having certain properties and functionality, like having a keyboard or processing data, but cannot exist themselves - I cannot hold or use the idea of a Computer, but I can hold my Asus laptop, which is a Computer. My Asus laptop has a keyboard, and can process data. Abstract classes function in much the same way. 


## Polymorphism
An abstract class describes a number of properties and methods that any derived class will share. It may either define a member outright, ensuring that all of its children have that member exactly as it is defined in the base class, or it may declare a member as "abstract". This demands that all derived classes "override" the abstract member, providing their own implementation; this is a way to ensure that all derived classes will have a certain method, even if they implement it differently. This idea of taking similar forms, but implementing them differently, is known as PolyMorphism. Both a MilitarySuperComputer and my AsusLaptop have to implement the abstract idea of ProcessData, but the details of how they do it are very different; but if I ask either of them, or any other Computer, to ProcessData, they will do it. Base classes may also declare a member as "virtual"; this allows derived classes to override its behavior, but provides a set of base behavior if they do not.

## Encapsulation
Encapsulation, while not implemented here, is the idea of "encapsulating" data within the pieces of code that use them. In many Class implementations, private fields and members will be defined that only the Class will have access to, for its own purposes. This is important both to protect that data from unintentional disruption and to minimize the amount of data that is being passed around unnecessarily. 

The following diagram illustrates the inheritance and member polymorphism structure of this project.

![Inheritance Diagram](https://github.com/RickFlinn/Zoo/blob/master/assets/zoo-class-inheritance.png)
