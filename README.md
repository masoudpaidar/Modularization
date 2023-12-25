# Modularization

# C# Coupling Examples

This repository contains examples of various types of coupling in C#, demonstrating how different components of a system might be interdependent in different ways.

Coupling refers to the degree of direct knowledge that one element has of another. In software engineering, reducing coupling is desirable to increase modularity and understanding, and to decrease complexity.

## Types of Coupling

### Content Coupling
Content Coupling occurs when one module modifies or relies on the internal workings of another module. A change in how one module works can break the dependent module.

### Common Coupling
Common Coupling happens when multiple modules have access to the same global data. A change in the global data can affect all modules that use it.

### External Coupling
External Coupling involves the dependencies of a software module on an external system, such as a database or a third-party service.

### Control Coupling
Control Coupling is present when one module controls the flow of another by passing it information on what to do (e.g., passing a flag).

### Stamp (Data-structured) Coupling
Stamp Coupling occurs when modules share a composite data structure and use only a part of it, possibly leading to modules being affected by changes in the structure they don't use.

### Data Coupling
Data Coupling is when modules share data with each other, and it's considered the lowest form of coupling since they only share what is necessary.

Each folder in this repository includes an example of one of these types of coupling. The examples are aimed at illustrating not only the coupling itself but also potential refactorings to improve the design and reduce the unwanted coupling.


## Cohesion Types
The repository is organized into separate directories for each cohesion type, each containing relevant examples:

- `ProceduralCohesion/`: Contains examples of methods grouped simply because they are called together forming a sequence.
- `CommunicationalCohesion/`: Demonstrates methods that are grouped because they operate on the same piece of data.
- `SequentialCohesion/`: Features methods that are organized in such a way that the output from one part serves as the input to another.
- `LogicalCohesion/`: Includes examples where multiple logically related functionalities are included within a single module. Functions perform related operations but might not be directly connected in a sequence or work on the same data.
- `TemporalCohesion/`: Functions that are related by the timing of their execution and are typically executed in the same phase of the program.
- `CoincidentalCohesion/`: Functions that are grouped arbitrarily within the same module, without a clear relationship between them.
- `FunctionalCohesion/`: Functions that together achieve a single well-defined task.






## Contact Information

For further information, feel free to contact [masoud hajyzadeh] at [masoudpaidar76@gmail.com].

## Contributions

Contributions are welcome! If you have an example to add or a refactoring suggestion, please make a pull request.

## License

This project is licensed under the [License Name] - see the LICENSE.md file for details.`