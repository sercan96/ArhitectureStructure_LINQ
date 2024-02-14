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

![image](https://github.com/sercan96/ArhitectureStructure_LINQ/assets/38535473/3ec609f3-2425-4237-b910-6f6392cf52a0)

Üst taraftaki yarattıgımız Select metodu dikkat ederseniz generic bir metot olarak yaratılmıstır...Yani görevini cagrıldıgı yerde belirledigimiz tipe göre yapacaktır...Normalde bu Select'in görevi veritabanındaki ilgili tabloya gitmek ve oradan bizim istedigimiz tipte veri döndürmektir...Biz hangi tipte veri dönmesini istedigimizi ise Select'i cagırırken onun generic tipini belirleyerek söyleriz...,



