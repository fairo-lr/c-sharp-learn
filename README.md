# c#值类型
值类型就是直接存储在内存的栈上面
引用类型是在内存的栈上面存储一个引用, 在堆上面存储值
系统的内建类型,比如
- int
- bool
- struct
- enum
主要继承于 system.valuetype , system.object
int的默认值是0

# c#引用类型
内建引用: object, string, dynamic
其他引用: class, interface
- object
	- gettype()
- string 
- class
	- static关键字, 静态的成员变量和方法是存储在类上面, 而不是类的实例化对象上
	- 成员变量(字段), 属性, 方法, 事件, 索引
- interface 
	- 只能包含属性, 方法, 索引, 事件
	- 命名一般以I开头
## abstract class & interface 的区别
- abstract class 不能实例化
- 类只能继承一个,但接口可以继承多个
- 接口内的 都要实现
- 抽象类的 不用都实现, 具体用法依然跟类差不多. 所以可以包含成员变量, 只需要实现抽象类中的抽象方法就可以了, 对抽象类中原有的成员, 可以顺便继承.
- 接口更像是规则, 所以定义的内容都要实现


# c#集合类型
## 数组
属于引用类型, 继承于system.array
特点: 长度固定, 类型固定, 根据index排列.
- 创建一个int 数组
- 创建一个二维 string 数组
- 创建一个数组的数组 byte[][]=[5][], 每行的长度不定, 并且初始化
- 数组的初始化方式, 一维, 多维
- 数组的获取方式, for 或者 直接定位
- 可以使用foreach进行遍历
## ArrayList & List
也是通过index来访问
- ArrayList 的特点是不限制类型(都是object类型), 同一个变量内可以插入各种类型的成员;
- List 会限制成员类型, 更加安全;
## Hashtable & Dictionary
通过key来访问 (key, value)
`key一样怎么办?`
- 创建一个Hashtable: hashtable 也是没有限制类型(都是object类型), 数据不安全
- 创建一个dictionary: 创建时, 对插入的成员类型有要求
- 访问一个无效key值: hashtable 返回 null, dictionary 返回错误
- sortedlist<> 根据key值进行排序
- stack 堆栈 先进后出
- queue 先进先出


# c#异常处理机制
ExceptionHandle

- 举例抛出异常 /0
- try catch 语句解决
- throw new NullException 解释throw
- finally解释: finally语句都必须执行
- finally内语句 和 后续语句的区别: 后续语句在有异常时不会执行
- 



# c#继承
新类希望重用旧类, 又有一些方法属性需要创建, 就需要使用继承
- 继承也需要满足语义的合理性, 比如动物和猫狗可以创建继承关系, 但动物和桌子就违反了语义合理性
<b>c#中不能进行多重继承</b>
`注意: c#中不能进行多重继承? `
`但是实际我目前还没搞清楚这一点,按照多重继承的实现方式, 我实际在c#中实现了, 也没报错, 这个问题先留着, 以后研究一下`
- 抽象方法只能写在抽象类里面, 抽象类不能被实例化, 只能被继承然后实例化
- sealed 类不能被继承


# c#封装
封装: 把一些内容包装在一起, 控制访问权限
注意assbemly 和 namespace 的区别

# c#多态 
是指一个形态， 能实现多个功能

## 静态多态
编译之后会实现
### 重载(overload)
- 方法重载
实现方式： 参数的个数，参数的类型
- 运算符的重载

## 动态多态
运行时会实现 
### 重写(override)
比如在类中实现对ToString()的重写

# c# 事件
event
通过用户动作触发一些情况， 被称作事件
比如button click
事件是基于委托的

声明步骤：
1. 声明一个delegate
2. 声明一个event
3. 声明一个函数触发event
4. event 绑定delegate
5. delegate绑定处理函数

EventHandler

- 问题
1. 事件和委托必须相辅相成的工作原理
2. 


# c# 索引器
让类可以像数组一样访问每个属性

public string this[int index]{};
索引的重载可以实现类似 datatable.rows\[i]\["colname"]的功能;
- 代码的强壮性考虑的方面
1. 参数的取值范围

# C# 泛型
generic
以T作为类型通称的操作

声明方式
- class : `public class name<T>`
- 字段：` public T name;`
- 方法：`public void name<T>(T temp)`

多重泛型及限制
`public class name<T,K> where T : struct`
限制可以涉及 class , interface, instance class

泛型类的继承
`public class name<T>：father<T> where T : struct`
`public class name:father<int>`

泛型在委托 Delegate 上的实现
`delegate T name<T>(T temp)`

# c# attribute
为程序添加一些附加的信息
用`[]`来表示

自定义attribute
`public class HelpAtrribute:Atrribute{}`

调用时
`[Help()] & [HelpAttribute()]`

属性AttributeUsage 
获取Attribute 中的信息

# C# 反射 - 暂时先不看了 
reflection
system.type
- 抽象类无法实例化

# c#匿名函数
没有函数名称，直接嵌套进程序里面

## 匿名函数和委托的发展史
匿名方法:
delegate(参数){
//函数体
}

匿名方法和lambda的使用区别是
lambda无法使用无参数情况


#c# Linq
通过一个统一的接口来进行查询
Linq to Sql
Linq to XML
Linq to DataSet
Linq to Objects

1. query syntax 查询语法;
``` cpp
int[] number = {5,10,9,8,3,6,12 };
var nums = from num in number
		    where num % 2 == 0
            orderby num
            select num;
```
只有在执行时 才会被查询

2. method syntax 方法语法
```
var nums2 = number.Where(n => n % 2 == 0).OrderBy(n => n);
```

## query  syntax的写法
步骤:
1. Data Source : 需要实现IEnumerble才能使用
``` 
 int[] number = {5,10,9,8,3,6,12 };
```  
        
2. Query creation 创建query
```
var nums = from num in number
           where num % 2 == 0 /*&&等于and;||等于or*/
           orderby num
           select num;
```
关键字解析:
	- from: 获取数据源
	- where: 过滤条件,设置条件
	- select: 结果语句,把结果返回出去
	
3. Query execution 执行 这一步, 查询才会执行
```
foreach (var item in nums)
{
   Console.Write(item + " ");
}
//或者以下情况, query 会强制执行
nums2.Count();
nums2.ToList();
nums2.ToArray();
```

## query  syntax的一些操作

1. group by 使用
```
// group by 使用
List<Customer> cs = new List<Customer>();
var querycs = from c in cs
              group c by c.City;

```
2. join in 使用
``` 
// join in 使用
List<Customer> cs2 = new List<Customer>();
List<Employee> ep = new List<Employee>();

var querycp = from c in cs2
              join e in ep on c.Name equals e.Name
              select new { PersonName = c.Name, PersonID = e.ID, PersonCity = c.City };

```
3. into 使用
```
// into 使用
List<Customer> cs3 = new List<Customer>();
var querycs2 = from c in cs3
               group c by c.City into cgroup
               where cgroup.Count() == 2
               select new { City = cgroup.Key, Count = cgroup.Count() };
```
4. let 使用
```
// let 使用 
// let 作用: 临时变量
// 把string内的字符串全部转换为大写, 个人感觉类似sql中字段的操作函数,比如convert,isnull等
string[] strings = { "Hello jikexueyuan", "This is Friday!", "Are you Happy?" };
var strQuery = from str in strings
               let words = str.Split(' ')
               from word in words
               let w = word.ToUpper()
               select w;
```      

#c# 扩展方法 ExtentionMethod
类似语法糖, 但是要谨慎使用, 因为新入的成员不容易理解, 容易出错
静态类创建的静态方法
```
//扩展方法的写法
public static class Extention
{ 
    public static string Method(this string name)
    {
	    //函数体
    } 
}
```
#c# 初始化器 Initializer
初始化器 是帮助对象或集合进行初始化赋值操作
1. 初始化器语法
2. 在匿名函数, 特别是Linq中的使用
3. 在集合中的使用

总结一下, 主要语法写法是
```
 var student1 = new StudentName("Meimei", "Wang"); 
 var student4 = new StudentName("Meimei", "Wang") { ID = 101 };
 var student2 = new StudentName() { FirstName = "Meimei", LastName = "Wang", ID = 101 };
 var student3 = new StudentName { FirstName = "Meimei", LastName = "Wang", ID = 101 }; 
```

#.NET Framework & Entity Framework

Entity Framework 以 ADO.NET 为基础发展出来的对象关系对应 ( O/R Mapping ) 解决方案.

ORM
连接代码class 和 DB table 的桥梁.

- SqlLocalDB.exe


##Entity(这是个深坑)
Entity = table = class
1. POCO (Plain Old CLR Objects)
2. POCO Proxy

Entity 能够直观反映表与概念模型的关系. 表与表之间的关系也可以直观反映出来. 

总共有3种编程模式:
1. Database First
先创建一个DB, 然后在项目中添加model和class
主要用于数据库已经存在的情况
2. Code First
使用 Code First Migration 来操作数据库更新
` enable-migration; update database`
既可以用于数据库已存在,也可以用在数据库还不存在的情况;
使用时, 有两种情况: 
-  新数据库
先有class (model), 然后使用ORM机制进行数据库创建.
- 已有数据库
创建项目时, 直接可以执行ORM机制关联数据库操作. 
3. Model First
先创建数据模型,在根据model来创建一个数据库和class,
主要用于数据库还不存在的情况

----------
###Data Annotation 和 Fluent API
 使用这两个来设置更新数据库字段名, 长度, 是否为空等属性;
1.  Data Annotation
命名空间:`System.ComponentModel.DataAnnotations;` 
 比如, model 中, 实现字段长度 nvarchar(20), 代码为:
 ``` cpp
[StringLength(20)]
public string BI_SHIFT { get; set; }
 ```

2. Fluent API
直接通过代码修改
 ``` 
protected override void OnModelCreating(DbModelBuilder modelBuilder)
{
    modelBuilder.Entity<Busy_Information>()
     .Property(e => e.BI_ISREADED)
     .HasColumnName("colname");
} 
 ```

##模式选择 
![Alt text](./1527742513226.png)

#jquery css
##遍历
### 向下遍历
1. children 只能到下一级
2. find 可以在多层子孙中进行遍历
### 向上遍历
1. parent 只到上一级
2. parents 所有上级
3. parentUntil 定义区间进行遍历

#jquery 扩展(<font style="color:red">这个有啥用？？？<font>)
##书写方法
![Alt text](./1527953902352.png)



#c# mvc 

## js & ajax

使用ajax实现异步请求：
1. `Ajax.BeginForm`
2. `Ajax.ActionLink`
3. `Clinet Validataion`

ajax 分页库
pagedlist
pagedlist.mvc

