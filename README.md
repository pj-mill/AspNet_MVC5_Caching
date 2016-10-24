# AspNet_MVC5_Caching

A look at Caching in an MVC5 project using ObjectCache & MemoryCache. Also demonstrates partial views and making ajax calls.

---

Developed with Visual Studio 2015 Community

---

###Techs
|Tech|
|----|
|C#|
|MVC5|
|AJAX|
|jQuery|
|Bootstrap|
|StructureMap.MVC5|

---

### 'OutputCacheExample'

This project focuses on the 'OutputCache' attribute used to control caching on controller actions. 

#### FEATURES

|Feature|
|-------|
|Caching data for a length of time using 'Duration'|
|Specifying were data should be cached using 'System.Web.UI.OutputCacheLocation'|
|Specifying cache profiles in web config.|
|Project also demonstrates use of partial views and AJAX calls|

#### TESTING

Navigate to the following urls and follow the instructions. The thing to watch out for is the 'Created' date. 

|Url|Description|
|---|-----------|
|http://localhost:[YourPortNumber]/Caching | Demonstrates caching data for a length of time using 'Duration'|
|http://localhost:[YourPortNumber]/Caching/LongCacheProfile | Demonstrates caching data for a length of time using 'CacheProfile'|
|http://localhost:[YourPortNumber]/Caching/ShortCacheProfile | Demonstrates caching data for a length of time using 'CacheProfile'|
|http://localhost:[YourPortNumber]/Caching/CacheByParm | Demonstrates caching data by parameter|
|http://localhost:[YourPortNumber]/Caching/AjaxCaching | Demonstrates caching data requested from an ajax call|

---

### 'MemoryCacheExample'

This projects contains a custom in-memory caching implementation using System.Runtime.MemoryCache.

#### FEATURES
|Feature|
|-------|
|Caching using System.Runtime.MemoryCache [Here](https://github.com/Apollo013/AspNet_MVC5_Caching/blob/master/MemoryCacheExample/Cache/SystemMemoryCache.cs)|
|Adapter, Decorator patterns [Here](https://github.com/Apollo013/AspNet_MVC5_Caching/blob/master/MemoryCacheExample/Services/InMemoryCachedCustomerService.cs)|
|Light-weight Repository Pattern [Here](https://github.com/Apollo013/AspNet_MVC5_Caching/tree/master/MemoryCacheExample/Repository)|
|Dependency Injection with StructureMap|
|AJAX calls|

#### TESTING
Just run the 'MemoryCacheExample' project where you will be redirected to the 'Customer' view.

Filter the list of customers from the droplist provided.

Observe the 'access date' for each customer, you will notice that it only changes after 1 minute.

---

###Resources
|Title|Author|Website|
|-----|------|-------|
|[ASP.NET Caching](https://msdn.microsoft.com/en-us/library/xsbfdd8c.aspx)||MSDN|
|[ASP.NET Caching: Techniques and Best Practices](https://msdn.microsoft.com/en-us/library/aa478965.aspx)||MSDN|
|[Caching infrastructure in MVC4 with C#](https://dotnetcodr.com/2013/02/07/caching-infrastructure-in-mvc4-with-c-caching-controller-actions/)|Andras Nemes|dotnetcodr|
