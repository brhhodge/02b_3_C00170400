# 02b_3_C00170400
CMPS 358 Assignment 3

Programming Assignment:

1. Create a C# console project in Visual Studio Code and name it “02b_3_your-clid”. When the project
  runs correctly, clean the project, zip the project folder and upload it in Moodle.
  
2. In a new file located in the same namespace as the default class, create a “normal” C# class to represent
  a dirt sample that consists of the amount in grams of sand and clay in the sample. As a “normal” class,
  the dirt sample class must have
    (a) two private fields as data members to represent the state information of the sample. These are the
      amount in grams of sand and clay. The values in these fields may not be less than zero.
    (b) three public methods for each of the private fields.
      i. For sand, one method will increase the amount of sand in the sample by one gram, one method
        will decrease the amount sand in the sample by one gram and one method will return the amount
        of sand in the sample.
      ii. For clay, one method will increase the amount of clay in the sample by one gram, one method
        will decrease the amount clay in the sample by one gram and one method will return the amount
        of clay in the sample
    (c) A public “default” constructor, i. e. a constructor that receives no parameters. The default
      constructor may initialize the class fields or default initial values may be assigned to the class fields
      at their declaration.
    (d) A public parametrized constructor that receives two parameters, one each for initial values of the two
      fields. The fields are initialized with the received values if the received values are valid.
  
3. In the Main method of the default class,demonstrate that your dirt sample class can be used as a data
  type by creating at least three dirt sample class reference variables that reference one each of three
  unique dirt class objects and use them to demonstrate that each constructor, all public methods work
  correctly and that the fields in each object are unique to that object. User input is optional.
