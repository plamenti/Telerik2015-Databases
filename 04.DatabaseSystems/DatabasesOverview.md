1.  What database models do you know?

> Relational Model, Object-oriented Model, Network Model, Hierarchical Model, Object-relational Model

1.  Which are the main functions performed by a Relational Database Management System (RDBMS)?

> There are several functions that a DBMS performs to ensure data integrity and consistency of data in the database. The ten functions in the DBMS are: data dictionary management, data storage management, data transformation and presentation, security management, multiuser access control, backup and recovery management, data integrity management, database access languages and application programming interfaces, database communication interfaces, and transaction management.

1.  Define what is "table" in database terms.

> In relational databases and flat file databases, a table is a set of data elements (values) using a model of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect.\[1\] A table has a specified number of columns, but can have any number of rows.\[2\] Each row is identified by one or more values appearing in a particular column subset. The columns subset which uniquely identifies a row is called the primary key.

1.  Explain the difference between a primary and a foreign key.

> While unique and primary keys both enforce uniqueness on the column(s) of one table, foreign keys define a relationship between two tables. A foreign key identifies a column or group of columns in one (referencing) table that refers to a column or group of columns in another (referenced) table – in our example above, the Employee table is the referenced table and the Employee Salary table is the referencing table.

1.  Explain the different kinds of relationships between tables in relational databases.

> There are three types of relationships:
>
> One-to-one: Both tables can have only one record on either side of the relationship. Each primary key value relates to only one (or no) record in the related table. They're like spouses—you may or may not be married, but if you are, both you and your spouse have only one spouse. Most one-to-one relationships are forced by business rules and don't flow naturally from the data. In the absence of such a rule, you can usually combine both tables into one table without breaking any normalization rules.
>
> One-to-many: The primary key table contains only one record that relates to none, one, or many records in the related table. This relationship is similar to the one between you and a parent. You have only one mother, but your mother may have several children.
>
> Many-to-many: Each record in both tables can relate to any number of records (or no records) in the other table. For instance, if you have several siblings, so do your siblings (have many siblings). Many-to-many relationships require a third table, known as an associate or linking table, because relational systems can't directly accommodate the relationship.

1.  When is a certain database schema normalized?

> Database normalization (or normalisation) is the process of organizing the columns (attributes) and tables (relations) of a relational database to minimize data redundancy.

-   What are the advantages of normalized databases?

> Normalization involves decomposing a table into less redundant (and smaller) tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones. The objective is to isolate data so that additions, deletions, and modifications of an attribute can be made in just one table and then propagated through the rest of the database using the defined foreign keys.

1.  What are database integrity constraints and when are they used?

> Integrity constraints provide a mechanism for ensuring that data conforms to guidelines specified by the database administrator. The most common types of constraints include:
>
> UNIQUE constraints
>
> To ensure that a given column is unique
>
> NOT NULL constraints
>
> To ensure that no null values are allowed
>
> FOREIGN KEY constraints
>
> To ensure that two keys share a primary key to foreign key relationship
>
> Constraints can be used for these purposes in a data warehouse:
>
> Data cleanliness
>
> Constraints verify that the data in the data warehouse conforms to a basic level of data consistency and correctness, preventing the introduction of dirty data.
>
> Query optimization
>
> The Oracle Database utilizes constraints when optimizing SQL queries

1.  Point out the pros and cons of using indexes in a database.

> Advantages: use an index for quick access to a database table specific information. The index is a structure of the database table the value of one or more columns to sort
>
> As a general rule, only when the data in the index column Frequent queries, only need to create an index on the table. The index take up disk space and reduce to add, delete, and update the line speed. In most cases, the speed advantages of indexes for data retrieval greatly exceeds it.
>
> Disadvantages: too index will affect the speed of update and insert, because it requires the same update each index file. For a frequently updated and inserted into the table, there is no need for a rarely used where the words indexed separately, small table, the cost of sorting will not be great, there is no need to create additional indexes. In some cases, the indexing words may not be fast, for example, the index is placed in a contiguous memory space, which will increase the burden of disk read, which is optimal, it should be through the actual use of the environment to be tested.

1.  What's the main purpose of the SQL language?

> SQL allows users to access data stored in a relational database management system. Users can create and delete databases, as well as set permissions on database tables, views and procedures. It also allows users to manipulate the data within a database.

1.  What are transactions used for?

> A transaction is a unit of work that is performed against a database. Transactions are units or sequences of work accomplished in a logical order, whether in a manual fashion by a user or automatically by some sort of a database program.
>
> A transaction is the propagation of one or more changes to the database. For example, if you are creating a record or updating a record or deleting a record from the table, then you are performing transaction on the table. It is important to control transactions to ensure data integrity and to handle database errors.

-   Give an example.

> DELETE RemoteServer.AdventureWorks2012.HumanResources.JobCandidate
>
> WHERE JobCandidateID = 13;

1.  What is a NoSQL database?

> NoSQL means Not Only SQL, implying that when designing a software solution or product, there are more than one storage mechanism that could be used based on the needs. NoSQL was a hashtag (\#nosql) choosen for a meetup to discuss these new databases. The most important result of the rise of NoSQL is Polyglot Persistence. NoSQL does not have a prescriptive definition but we can make a set of common observations, such as:
>
> Not using the relational model
>
> Running well on clusters
>
> Mostly open-source
>
> Built for the 21st century web estates
>
> Schema-less

1.  Explain the classical non-relational data models.

> Key-Value Cache
>
> Key-Value Store
>
> Key-Value Store (Ordered)
>
> Data-Structures server
>
> Tuple Store
>
> Object Database
>
> Document Store
>
> Wide Columnar Store
>
> Graph
>
> Tabular
>
> Multivalue databases
>
> Multimodel database

1.  Give few examples of NoSQL databases and their pros and cons.

> Advantages :
>
> High scalability
>
> Distributed Computing
>
> Lower cost
>
> Schema flexibility, semi-structure data
>
> No complicated Relationships
>
> Disadvantages
>
> No standardization
>
> Limited query capabilities (so far)
>
> Eventual consistent is not intuitive to program for
