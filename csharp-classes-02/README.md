# csharp-classes-02
The 'csharp-classes-02' is the second 'lesson' on classes in a series of programming lessons.   

This lesson focuses on basic class inheritance.

## Project/Lesson Requirements
Create three classes - ```Animal```, ```Dog``` and ```Cat```

```Animal``` 
- Create a private variable that stores the 'name' of the animal.  
- Create a method called 'Greet' that introduces the animal and ensure you use the stored name of the animal.

```Dog``` 
- The class needs to inherit from the Animal class.  
- Create a method called 'Greet' that introduces the dog and also state what kind of animal it is.  

```Cat``` 
- The class needs to inherit from the Animal class.  
- Create a method called 'Greet' that introduces the cat and also state what kind of animal it is.  

Instantiate an instance of each class and write the output of the ```Greet``` method for each.

### Example Output
```
Hi, my name is Flash.
Hi, my name is Buzz.  I am a dog. Woof, woof!!
Hi, my name is Snowflake.  I am a cat.
```

### Hints
- you might need to consider using ```private``` for the `name` variable in the Animal class
- you might need to consider using ```override``` in the Animal class
- you might need to consider using ```virtual``` in the Animal class
- you might need to consider using ```base.Greet()``` in the inherited class

The "main" program might start with something like the following: 
 ```
 Animal animal = new Animal("Flash");
Dog dog = new Dog("Buzz");
Cat cat = new Cat("Snowflake");

Console.WriteLine(animal.Greet());
Console.WriteLine(dog.Greet());
Console.WriteLine(cat.Greet());
```

## License
Licensed under the [MIT License](./LICENSE).
