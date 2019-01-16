# Zoo


This is a project designed to illustrate basic knowledge of OOP principles. A "Zoo" of object classes are all derived from a base "Animal" class. 

## Inheritance

A base class, Animal, is used to derive two child classes, Mammal and Reptile, which are in turn used to derive a number of child classes that represent different animals. Each derived class "inherits" the methods and properties of its base class.  All classes derived from Animal, for example, inherit the Devour method. If a Class is derived from Animal, for example Human, it may call and use the Devour method for itself.

## Abstraction

Abstract concepts, like the idea of an Animal, can be described as having certain properties and do certain things. We can say that an animal eats, has some way of moving, and reproduces; but the idea of an Animal cannot itself exist; the idea of an Animal cannot eat,  reproduce, or move. Abstract classes function in much the same way. Abstract classes cannot be instantiated; this means that there will never be an Object of the Animal base class. 


## Polymorphism
An abstract class describes a number of properties and methods that any derived class will share. It may either define a member outright, ensuring that all of its children have that member exactly as it is defined in the base class, or it may declare a member as "abstract". This demands that all derived classes "override" the abstract member, providing their own implementation; this is a way to ensure that all derived classes will have a certain method, even if they implement it differently. This idea of taking similar forms, but implementing them differently, is known as PolyMorphism. A Human and a

## Encapsulation
Encapsulation, while not implemented here, is the idea of "encapsulating" data within the pieces of code that use them. In many Class implementations, private fields and members will be defined that only the Class will have access to, for its own purposes. This is important both to protect that data from unintentional disruption and to minimize the amount of data that is being passed around unnecessarily. 

## Interfaces
Inheritance is limited in C# so that each derived class may only inherit the members of a single base class. However, sometimes there is functionality that we want to have common to a number of different classes that do not exist within the same inheritance chain. Moreover, we may want to be able to interact with unrelated classes in a common way, without excessive switch statements or excessively vague object typing. Interfaces define a series of members that all classes that have the Interface MUST implement. Because all implementing classes are required to implement those members, we can be sure that if a Class implements an Interface, it will be able to implement any member the Interface requires, even if that implementation may be very different. 

The following diagram illustrates the inheritance and member polymorphism structure of this project.

![Inheritance Diagram](https://github.com/RickFlinn/Zoo/blob/master/assets/zoo-class-inheritance.png)
