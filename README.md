# <img src="FacebookWinFormsApp/Resources/FBSmallLogo.png" width="50" height="50"> Facebook Desktop Application  

This project is a C# desktop application that utilizes the Facebook API to practice design patterns and thread programming.
* singleton
* facade
* adapter
* iterator
* template method
* strategy


By leveraging these design patterns, our Facebook desktop application achieves a more modular and maintainable structure, enabling seamless scalability and future enhancements.



## Selected Design Patterns

### Iterator

**Purpose:** One of the additional features added to the application is the ability to filter photos based on their likes, creation dates, tags, and more.<br>
 we employ the Iterator design pattern to hold the filtered image results in an iterator.
This allows for smooth traversal over the data collection without the client needing to be aware of the underlying data structure.


![Iterator UML Diagram](/assets/Iterator_uml.png)


- **Client:** AdvancedImageSearchForm
- **ConcreteAggregate:** FacebookFilteredImages
- **ConcreteIterator:** FilteredPhotosIterator

### Adapter

**Purpose:** The Adapter design pattern is used to reformat the way post details are written to include various additional data. The `StatusFormatAdapter` acts as the adapter, enabling the legacy class `Post` to work with the new data format.


![Adapter UML Diagram](/assets/adapter_uml.png)

- **Adapter:** StatusFormatAdapter
- **Adaptee:** Post (Legacy class)


### Strategy

**Purpose:** In order to fetch only selected types of data for a particular image at runtime, we have implemented the Strategy design pattern. This pattern allows us to define multiple strategies, each representing a different type of data that can be received for an image. By using the Strategy pattern, we make it easier to add more data types in the future by simply implementing a new strategy for that data type.



![Strategy UML Diagram](/assets/strategy_uml.png)

- **Context:** SelectedImage
- **Strategy:** IPhotoData
- **ConcreteStrategyA:** PhotoLikes
- **ConcreteStrategyB:** PhotoComments
- **ConcreteStrategyC:** PhotoTags

---
full explanation of each design pattern can be found in documentation directory
