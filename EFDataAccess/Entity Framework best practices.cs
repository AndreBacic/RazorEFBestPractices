/* Entity Framework best practices
 * 1. Optimize columns with proper decorators.
 * 2. Review your migrations - they can quickly destroy your production data.
 * 3. Remember that EF calls sp_executesql, which is not secure for desktop apps.
 * 4. When querying from the db, only use .Includes() when necessary because of 
 *      the performance hits from all of the duplicate data sent in 1:M relationships.
 * 5. Don't use C# methods in queries until the data is downloaded (a .ToList() is in the 
 *      linq chain), and remember that using C# functions instead of C# lambda expressions
 *      prevents EF from converting that C# code into SQL and improving performance.
 * 
 * 6. Know how to use the SSMS XEvent Profiler or a similar tool to review the SQL calls 
 *      EF runs behind the scenes.
 */