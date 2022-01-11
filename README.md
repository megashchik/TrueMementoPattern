I decided to read here, remember the patterns.
Good description.
The pattern suggests storing the copy of the object's state in a special object called memento. The contents of the memento aren’t accessible to any other object except the one that produced it. Other objects must communicate with mementos using a limited interface which may allow fetching the snapshot’s metadata (creation time, the name of the performed operation, etc.), but not the original object’s state contained in the snapshot.

But let's see some code examples:

https://refactoring.guru/design-patterns/memento/csharp/example
https://metanit.com/sharp/patterns/3.10.php
https://tproger.ru/articles/pattern-oop-hranitel/
http://gyanendushekhar.com/2017/02/01/memento-design-pattern-c/
https://www.dofactory.com/net/memento-design-pattern

In Wikipedia, it is depicted correctly, and canonically, but these are nested classes.
https://en.wikipedia.org/wiki/Memento_pattern#C#_example

I used a separate library for the model object, which made it possible to hide the state in it.
My example is not perfect. The Memento class is still visible inside the assembly. There are no friendly classes in C #, good or bad.
