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

---

###Features

The **'OutputCacheExample'** project focuses on the 'OutputCache' attribute used to control caching on controller actions. 

|Feature|
|-------|
|Caching data for a length of time using 'Duration'|
|Specifying were data should be cached using 'System.Web.UI.OutputCacheLocation'|
|Specifying cache profiles in web config.|
|Project also demonstrates use of partial views and ajax calls|

#### Testing

Navigate to the following urls. The thing to watch out for is the 'Created' date. 

|Url|Description|
|---|-----------|
|http://localhost:[YourPortNumber]/Caching | Demonstrates caching data for a length of time using 'Duration'|
|http://localhost:[YourPortNumber]/Caching/AggressiveCacheProfile | Demonstrates caching data for a length of time using 'CacheProfile'|
|http://localhost:[YourPortNumber]/Caching/ShortCacheProfile | Demonstrates caching data for a length of time using 'CacheProfile'|
|http://localhost:[YourPortNumber]/Caching/CacheByParm | Demonstrates caching data by parameter|
|http://localhost:[YourPortNumber]/Caching/AjaxCaching | Demonstrates caching data requested from an ajax call|

---

###Resources
|Title|Author|Website|
|-----|------|-------|
|[ASP.NET Caching](https://msdn.microsoft.com/en-us/library/xsbfdd8c.aspx)||MSDN|
|[ASP.NET Caching: Techniques and Best Practices](https://msdn.microsoft.com/en-us/library/aa478965.aspx)||MSDN|
|[Caching infrastructure in MVC4 with C#](https://dotnetcodr.com/2013/02/07/caching-infrastructure-in-mvc4-with-c-caching-controller-actions/)|Andras Nemes|dotnetcodr|
