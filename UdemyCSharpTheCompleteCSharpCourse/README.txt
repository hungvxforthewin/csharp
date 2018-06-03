THE COMPLETE C# COURSE
SECSION 1: THE FUNDAMENTALS OF C# PART 1

1.Course introdution

 /// <summary>
        /// Fundamental C# Part 1
        /// 
        /// -IDE, key word
		/// -Base object
		/// -New <Từ khóa rất hay>
	 	/// -This
        /// -Variables
        /// -Datatypes: note var
        /// -Loops: if else, switch case break, continue, for, while, do while, foreach
        /// -List<>, Array<>, IEnumbrable<>
		/// -String
        /// -Arithmetic Operators
        /// -Logical Operators
        /// -Comparison Operator
        /// -Systax basic
        /// -Libary .NET
        /// *OOP
        /// *Class
        /// *Method
        /// *Filed
        /// *Property
        /// *Encapsulation
        /// *Inheritance
        /// *Polymorphism
        /// *Abstraction
        /// -Linq Ranger, ADO.NET, SQL Server
        /// -Extension method
        /// -Delegate
        /// -Generic
        /// -Lambda Expression
        /// -IEnumbrable & yield
        /// -Event
        /// -Collection
        /// -Wait, Task<>
        /// -Multithreading
        /// </summary>
        /// <param name="args"></param>
2.Introduction chapter
3.Programming league
4.Compiler
5.Install visual studio
6.Exploer vs
7.Hello world
8.9.10.Data types and variable
11.Casting and type conversion
12.Comment
13.Var keyword
14.Summary

SECSION 2: THE FUNDAMENTALS OF C# PART 2

15.Introduction chapter
16.Data type depth
17.Float, double, decimal
18.Datetime
-Thao tác cơ bản với datatime
+DateTime.Now, House, Day, Minute
+string.formart("{0: yyyyy MMMMMMM ddddđd}"); độ dài ký tự
+ToShort, ToLong, DatetimeString
+AddDay.....
19.DateTime Exercise
+string.Format
20.Error Type
+Syntax
+Run-time (exception)
+Logical
21.Naming Conversion
-Đặt tên các variable, class, method, filde
+uHung
+HungOi
+a_hi_hi
22.ReadLine
23.Arithmetic Operators
-Toán tử số học
24.Arithmetic Operators Ex
25.Precedence of Operators
-Độ ưu tiên các phép toán
26.if
27.switch
28.Comparison Operator
-Toán tử so sánh
29.Logical Operator
-Toán tử logic : && ||
30.More Logical Operator
AND, OR
31.Even or old exercise
-VD về số chẵn lẻ
32.Assignment
-Bài tập
33.Summary

SECSION 3: THE FUNDAMENTALS OF C# PART 3

34.Introduction
35.TryParse, parse == Convert
36.Const = Constants
37.Cmd Convert
38.39.40.string và các thao tác cơ bản
+Indexes
+Trim
+Upper
+Lower
+Lenght
+Reaplace
+IndexOf
+LastIndexOf
+SubString
+Insert
+Remove	
41.Escape Sequences
-Chuỗi thoát
\n, \t \\
42.String Interpolation
-Chuỗi nội suy
- System.Console.Write("{0}",x);
- System.Console.Write("  " + x);
- System.Console.Write($"{x}");
43 --> 48.Loops and Math
49.Random Number
Random rd = new Random();
int x = rd.Next(0,10);
50.Array
51.52 Summay

SECSION 4: Object-oriented Programming PART 1

53.Introduction chapter
54.OOP
-Class
-Obj
-Method
-Property
55.56.Method
57.Simple ex
58.Method p3
-out, fer parameter
59.Method p4
-Overload Method
60.Overload Method exercise
61.Class
62.Constructor
63.DateTime Exploration
-Tham do
-View --> Object Brower
64.Static Method
65.Scope
-Chay main() truoc
66.Inheritance, kế thừa
-Chú ý sử dụng virtual ở method
-Phân biệt virtual với abstract <ở lớp cơ sở>
+virtual: có sử dụng or ko
+abstract: bắt buộc sử dụng
-override ở lớp dẫn xuất
67.Encapsulation, đóng gói
-Bảo vệ dữ liệu
private int a;
public int A
{
    get { return a;}
    set { a = value;}
} 
68.Vehicle Inheritance Exercise, bài tập
69.Polymorphism, đa hình
-Sử dụng 1 interface, multi function
+Overloading: cùng name nhưng khác parameter
+Overriding: Có thể thay đổi Method ở class con, virtual va overried
70.Abstract, trừu tượng
-Syntax:
+Abstract ở class, or method
+phải có ở class, method có thể có hoặc không
-Tính chất
+Không cho tạo Obj trực tiếp mà phải thông qua kế thừa
+Cho kế thừa, và lớp con kế thừa phải override method abstract
+Có method trừu tượng ỏ không.Nhưng class phải là trừu tượng
+Method abstract ko co body
71.Cars Exercise
72.Region keyword
-Systax 
#region-clear code
#endregion
73.Summary and quiz

SECSION 4: Object-oriented Programming PART 2

74.Introduction
+More classes
+Namespace
+Struct
+Enum
+This keyword
+Interface
75.Sealed Classes
-Không cho kế thừa
76.Static class
-Không cho khởi tạo đối tượng
77.Nested Classes
-Class lồng nhau, chứa class
78.Partial Classes
-Chia thành nhiều class nhưng có thể gộp vào chung 1 class --> using partial class
79.NameSpace
-Tên vùng làm việc
80.Struct
81.Class vs Struct
82.Enums
-Vừa lấy đc giá trị cũng như index
83.84.85: VD
86.This Keyword
87.Interface
-Lớp dẫn xuất thực hiện đầy đử các method	
88.Interface vs abstract class
-interface:
+Cho phép đa kế thừa
+Có chứa biến
+Không thể access modifier, everything public
+Không có body method;
-abstract
+Ko cho đa kế thừa
+ko chứa biến
+Cho phép access modifier
+Có body method
89.Exception Handing
try catch finally
90.Exception Handing ex
91.Composition
92.Aggregation
93.Association
94.BT
95.Summary + Quiz


