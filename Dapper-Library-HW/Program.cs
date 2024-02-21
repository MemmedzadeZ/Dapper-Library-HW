


using Dapper_Library_HW.Entities;
using System.Data.SqlClient;

using Dapper;
using Dapper_Library_HW;

string conStr = @"Data Source=DESKTOP-QOMBEIP;Initial Catalog=LibraryDapper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

var connection = new SqlConnection(conStr);
connection.Open();



//Dapper Select


///////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
/////////////////////////////SELECT////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////



///Author Select
//string Query1 = "Select * From Author";
//IEnumerable<Author> authors = connection.Query<Author>(Query1);

//foreach (var author in authors)
//{
//    Console.WriteLine(author.ToString());
//}

///Book Select
//string Query2 = "Select * From Book";
//IEnumerable<Book> books = connection.Query<Book>(Query2);

//foreach (var book in books)
//{
//    Console.WriteLine(book.ToString());
//}

///Category Select
//string Query3 = "Select * From Category";
//IEnumerable<Category> categories = connection.Query<Category>(Query3);

//foreach (var category in categories)
//{
//    Console.WriteLine(category.ToString());
//}

///Department Select
//string Query4 = "Select * From Department";
//IEnumerable<Department> departments = connection.Query<Department>(Query4);

//foreach (var department in departments)
//{
//    Console.WriteLine(department.ToString());
//}


///Faculty Select
//string Query5 = "Select * From Faculty";
//IEnumerable<Faculty> faculties = connection.Query<Faculty>(Query5);

//foreach (var faculty in faculties)
//{
//    Console.WriteLine(faculty.ToString());
//}


///Group Select
//string Query6 = "Select * From Group";
//IEnumerable<Group> groups = connection.Query<Group>(Query6);

//foreach (var group in groups)
//{
//    Console.WriteLine(group.ToString());
//}


///Lib Select
//string Query7 = "Select * From Lib";
//IEnumerable<Lib> libs = connection.Query<Lib>(Query7);

//foreach (var lib in libs)
//{
//    Console.WriteLine(lib.ToString());
//}

///Press Select
//string Query8 = "Select * From Press";
//IEnumerable<Press> presses = connection.Query<Press>(Query8);

//foreach (var press in presses)
//{
//    Console.WriteLine(press.ToString());
//}

///SCard Select
//string Query9 = "Select * From SCard";
//IEnumerable<SCard> sCards = connection.Query<SCard>(Query9);

//foreach (var sCard in sCards)
//{
//    Console.WriteLine(sCard.ToString());
//}

///Student Select
//string Query10 = "Select * From Student";
//IEnumerable<Student> students = connection.Query<Student>(Query10);

//foreach (var student in students)
//{
//    Console.WriteLine(student.ToString());
//}


///TCard Select
//string Query11 = "Select * From TCard";
//IEnumerable<TCard> tCards = connection.Query<TCard>(Query11);

//foreach (var tCard in tCards)
//{
//    Console.WriteLine(tCard.ToString());
//}


///Teacher Select
//string Query12 = "Select * From Teacher";
//IEnumerable<Teacher> teachers = connection.Query<Teacher>(Query12);

//foreach (var teacher in teachers)
//{
//    Console.WriteLine(teacher.ToString());
//}


///Them Select
//string Query13 = "Select * From Them";
//IEnumerable<Them> thems = connection.Query<Them>(Query13);

//foreach (var them in thems)
//{
//    Console.WriteLine(them.ToString());
//}

///////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
/////////////////////////////INSERT////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////

///Author Insert
//string Query1 = "INSERT INTO Authors(Id,FirstName,LastName) VALUES(3,'Zehra','Memmedzade')";
//connection.Execute(Query1);

///Category Insert
//string Query2 = "INSERT INTO Categories(Id,Name) VALUES(1,'IT')";
//connection.Execute(Query2);

///Department Insert
//string Query3 = "INSERT INTO Departments(Id,Name) VALUES(8,'Tehlukesizlik')";
//connection.Execute(Query3);

///Lib Insert
// string  Query4 = "INSERT INTO Lib(Id,FirstName,LastName) VALUES(3,'Ellada','Efendiyeva')";
//connection.Execute(Query6);

///Press Insert
//string Query5 = "INSERT INTO Press(Id,Name) VALUES(12,'Fateh')";
//connection.Execute(Query5);

///Them Insert
//string Query6 = "INSERT INTO Them(Id,Name) VALUES(10,'Abbas')";
//connection.Execute(Query6);

///Student Insert
//string Query7 = "INSERT INTO Student(Id,FirstName,LastName,Id_Group,Term) VALUES(30,'Islam','Mehtiyev',4,96)";
//connection.Execute(Query7);

///Teacher Insert
//string Query8 = "INSERT INTO Teachers(Id,FirstName,LastName,Id_Dep) VALUES(30,'Aqsin','Salehov',1)";
//connection.Execute(Query8);

///////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
/////////////////////////////UPDATE////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////


///Author Update
//string Query1 = "UPDATE Authors SET FirstName = 'Zehra'  WHERE Id = 7";
//connection.Execute(Query1);

///Book Update
//string Query2 = "UPDATE Books SET Pages = 5000  WHERE Id = 9";
//connection.Execute(Query2);


///Category Update
//string Query3 = "UPDATE Categories SET Name = 'STEP' WHERE Id = 3";
//connection.Execute(Query3);

///Faculties Update
//string Query4 = "UPDATE Faculties SET Name = 'Alqoritm'  WHERE Id = 1";
//connection.Execute(Query4);

///Lib Update 
//string Query5 = "UPDATE Libs SET LastName = 'Hesenova'  WHERE Id = 9";
//connection.Execute(Query5);

///SCard Update
//string Query6 = "UPDATE S_Cards SET Id_Student = 20 WHERE Id = 8";
//connection.Execute(Query6);

///Them Update
//string query10 = "UPDATE Themes SET Name = 'Zehra'  WHERE Id = 5";
//connection.Execute(query10);


///////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
/////////////////////////////DELETE////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////

//SCard Delete

//string? query1 = "DELETE S_Cards WHERE Id = 2";
//connection.Execute(query1);


//string? query2 = "DELETE T_Cards WHERE Id = 5";
//connection.Execute(query2);


//string? query3 = "DELETE S_Cards WHERE Id = 10";
//connection.Execute(query3);


//string? query4 = "DELETE T_Cards WHERE Id = 35";
//connection.Execute(query4);

//string? query5 = "DELETE S_Cards WHERE Id = 13";
//connection.Execute(query5);


//string? query6 = "DELETE T_Cards WHERE Id = 58";
//connection.Execute(query6);

//string? query7 = "DELETE S_Cards WHERE Id = 12";
//connection.Execute(query7);


//string? query8 = "DELETE T_Cards WHERE Id = 5";
//connection.Execute(query8);

//string? query9 = "DELETE S_Cards WHERE Id = 32";
//connection.Execute(query9);


//string? query10 = "DELETE T_Cards WHERE Id = 25";
//connection.Execute(query10);