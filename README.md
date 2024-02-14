# SELECT 

<p>
    
<b>'SELECT'</b> statement is used to select, filter and transform specific data from collections using LINQ in C#. A new table (or in general, a new data set) can be created from a collection with a SELECT statement.
</p>

<h2> Anonym Type  </h2>

<p>
    Anonymous types are types that do not have a named type, typically used for LINQ queries or fast temporary data migrations.
</p>


<p align="center">
  <img src="https://github.com/sercan96/ArhitectureStructure_LINQ/assets/38535473/aab66dbe-6dda-44fb-8eba-2b62a910820d" alt="Diagram">
</p>


<h2> View Model(VM) Type  </h2>

<p>
    While anonymous types are generally short-lived and used for a specific query or operation, ViewModels are classes that are generally longer-lived and designed to be used in a specific user interface (UI) part.
</p>


<p align="center">
  <img src="https://github.com/sercan96/ArhitectureStructure_LINQ/assets/38535473/7f5ee007-56af-4f78-aba1-b92fafad1d04" alt="Diagram">
  <img src="https://github.com/sercan96/ArhitectureStructure_LINQ/assets/38535473/2179c3ad-345e-489f-8420-030fa4764c35" alt="Diagram">
</p>

# Making LinQ Queries With Generic Structures

* If you notice that queries like <b>'Where, Any, All, Contains'</b> usually return a boolean value and these queries need to be treated as generic within a general structure, then it will usually be more convenient to express the return type of these queries as bool.
  
<p align="center">
  <img src="https://github.com/sercan96/ArhitectureStructure_LINQ/assets/38535473/8fdb576a-ee3d-45cd-843c-4e2e4cac1f09" alt="Diagram">
</p>


<p align="center">
  <img src="https://github.com/sercan96/ArhitectureStructure_LINQ/assets/38535473/fe3ee131-ecfe-41f8-9a32-3c8933fb802c" alt="Diagram">
</p>
* If you pay attention to the Select method we created above, it was created as a generic method... In other words, it will do its job according to the type we specify where it is called... Normally, the task of this Select is to go to the relevant table in the database and return data of the type we want from there... What type of data do we use? We tell it what we want to return by specifying its generic type when calling Select...

* The generic structure of the <b>'Select'</b> method takes a lambda expression of type <b>'Expression<Func<T, MyModel>>'</b> as a parameter and applies the transformation specified by this lambda expression. As a result, this query returns a collection by applying the specified transformation.

* In this case, the MyModel generic type is the type of elements of the collection that the Select method returns. So, the return value of the Select method will be List<MyModel>.
